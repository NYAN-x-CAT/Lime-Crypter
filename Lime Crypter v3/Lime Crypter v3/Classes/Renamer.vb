Imports Mono.Cecil

Public Class Renamer

    Public Shared Sub Mono(ByVal File As String)
        Dim definition As AssemblyDefinition = AssemblyDefinition.ReadAssembly(File)
        Try
            ' definition.CustomAttributes.Clear()
            definition.Name = New AssemblyNameDefinition(Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(3, 10)), New Version(rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10)))
            Dim definition2 As ModuleDefinition
            For Each definition2 In definition.Modules
                definition2.Name = Randomi(rand.Next(5, 15))
                Dim definition3 As TypeDefinition
                For Each definition3 In definition2.Types
                    definition3.Namespace = Randomi(rand.Next(5, 15))
                    definition3.Name = Randomi(rand.Next(5, 15))
                    For Each F In definition3.Fields
                        F.Name = Randomi(rand.Next(5, 15))
                    Next
                    Dim definition4 As MethodDefinition
                    For Each definition4 In definition3.Methods
                        If Not definition4.IsConstructor AndAlso Not definition4.IsRuntimeSpecialName Then
                            definition4.Name = Randomi(rand.Next(5, 15))
                            For Each P As ParameterDefinition In definition4.Parameters
                                P.Name = Randomi(rand.Next(5, 15))
                            Next
                        End If
                    Next
                Next
            Next
            definition.Write("Crypted_.exe")
            definition.Dispose()
            IO.File.Delete(File)
        Catch ex As Exception
            definition.Dispose()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

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

End Class
