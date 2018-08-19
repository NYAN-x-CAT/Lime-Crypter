Imports System.CodeDom.Compiler

Public Class Codedom
    Public Shared OK As Boolean = False

    Public Shared Sub Compiler(ByVal Path As String, ByVal Code As String, Optional ICOPath As String = "")

        Dim providerOptions = New Collections.Generic.Dictionary(Of String, String)
        providerOptions.Add("CompilerVersion", "v4.0")
        Dim CodeProvider As New Microsoft.VisualBasic.VBCodeProvider(providerOptions)
        Dim Parameters As New CompilerParameters
        Dim OP As String = " /target:winexe /platform:x86 /optimize+ /nowarn"
        If ICOPath IsNot Nothing Then
            OP += " /win32icon:" + Chr(34) + ICOPath + Chr(34)
        End If
        With Parameters
            .GenerateExecutable = True
            .OutputAssembly = Path
            .CompilerOptions = OP
            .IncludeDebugInformation = False
            .ReferencedAssemblies.Add("System.Windows.Forms.dll")
            .ReferencedAssemblies.Add("system.dll")
            .ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
            .EmbeddedResources.Add(IO.Path.GetTempPath & "\" + Main.ResName + ".Resources")

            'Check for errors
            Dim Results = CodeProvider.CompileAssemblyFromSource(Parameters, Code)
            If Results.Errors.Count > 0 Then
                For Each E In Results.Errors
                    MsgBox(E.ErrorText, MsgBoxStyle.Critical)
                Next
                OK = False
                Return
            Else
                OK = True
            End If
        End With

    End Sub


End Class
