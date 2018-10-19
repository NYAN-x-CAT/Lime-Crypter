'******* https://github.com/NYAN-x-CAT
'******* Credit to NYAN CAT

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnStartBuild_Click(sender As Object, e As EventArgs) Handles btnStartBuild.Click
        Form2.ShowDialog()
    End Sub

    Private Sub btnSelectPayload_Click(sender As Object, e As EventArgs) Handles btnSelectPayload.Click
        Try
            Dim o As New OpenFileDialog
            o.Filter = "Executable |*.exe"
            If o.ShowDialog = DialogResult.OK Then
                txtPayload.Text = o.FileName

                Try
                    Dim testAssembly As Reflection.AssemblyName = Reflection.AssemblyName.GetAssemblyName(o.FileName)
                    txtPayloadType.Text = "Type: Managed"
                Catch ex As System.BadImageFormatException
                    txtPayloadType.Text = "Type: Native"
                Finally
                    txtPayloadType.Visible = True
                    btnStartBuild.Enabled = True
                End Try
            Else
                txtPayload.Text = Nothing
                txtPayloadType.Visible = False
                btnStartBuild.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class