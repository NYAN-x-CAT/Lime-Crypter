Module JunkCoder
    Public RN As New Random
    Function RandomNumber(ByVal MaxNumber As Integer,
   Optional ByVal MinNumber As Integer = 0) As Integer
        Dim r As New Random(System.DateTime.Now.Millisecond)
        If MinNumber > MaxNumber Then
            Dim t As Integer = MinNumber
            MinNumber = MaxNumber
            MaxNumber = t
        End If

        Return r.Next(MinNumber, MaxNumber)
    End Function

    'create fake subs inside our stub's class
    Function GenerateJunk(ByVal Ammount As Integer) As String

        If Ammount = 0 Then
            Ammount = 1
        End If

        Dim out As String = ""
        Dim y As Integer = 0

        Do Until y = Ammount

            Rnd()
            Dim a As Integer = n(3, 1)

            Dim e As String = s(7)
            If a = 1 Then
                out += vbNewLine & vbNewLine & "Public Function " & s(5) & "(" & s(8) & " as string)as string" & vbNewLine

                out += "on error goto " & e & vbNewLine
            Else
                out += vbNewLine & "Public Sub " & s(n(5, 8)) & "(" & s(9) & " as string)" & vbNewLine
            End If

            Dim i As Integer = 0

            Dim limit As Integer = n(10, 5)

            Do Until i = limit
                Rnd()
                Dim type As Integer = n(5, 0)


                If type = 1 Then
                    out += "Dim " & s(9) & " as string = " & Chr(34) & s(n(3, 11)) & Chr(34) & vbNewLine
                    i += 1
                ElseIf type = 2 Then
                    out += "msgbox(" & Chr(34) & s(n(7, 20)) & " " & s(n(7, 20)) & Chr(34) & ")" & vbNewLine
                    i += 1
                ElseIf type = 3 Then
                    Rnd()
                    out += "Dim " & s(10) & " as integer = " & n(12, 5) & vbNewLine
                    i += 1
                Else
                    out += "dim " & s(n(5, 10)) & " as integer = " & n(12, 5) & " + " & n(10, 19) & " + " & n(10, 19) & " + " & n(10, 19) & vbNewLine
                End If

            Loop
            If a = 1 Then
                out += e & ":" & vbNewLine

                Dim h As Integer = 0
                Dim hl As Integer = n(10, 3)
                Do Until h = hl

                    Dim type As Integer = n(4, 0)


                    If type = 1 Then
                        out += "Dim " & s(6) & " as string = " & Chr(34) & s(n(4, 9)) & Chr(34) & vbNewLine
                        i += 1
                    ElseIf type > 1 Then
                        out += "msgbox(" & Chr(34) & s(n(5, 10)) & " " & s(n(5, 10)) & Chr(34) & ")" & vbNewLine
                        i += 1
                        out += "If " & n(10, 19) & " > " & n(10, 19) & " then" & vbNewLine

                        out += "Dim " & s(6) & " as string = " & Chr(34) & s(n(4, 9)) & Chr(34) & vbNewLine
                        out += "Dim " & s(6) & " as string = " & Chr(34) & s(n(4, 9)) & Chr(34) & vbNewLine
                        out += "Dim " & s(6) & " as string = " & Chr(34) & s(n(4, 9)) & Chr(34) & vbNewLine
                        out += "End if" & vbNewLine

                    Else
                        Rnd()
                        out += "Dim " & s(12) & " as integer = " & n(9, 10) & vbNewLine
                        i += 1
                    End If
                    h += 1
                Loop
                out += vbNewLine

                out += "End Function" & vbNewLine & vbNewLine

            Else
                out += "End Sub" & vbNewLine & vbNewLine
            End If
            y += 1
        Loop


        Return out
    End Function

    'create fake classes and subs ..etc
    Function GenerateJunkClass(ByVal Ammount As Integer) As String
        If Ammount = 0 Then
            Ammount = 1
        End If

        Dim out As String = "Class " & s(12)
        Dim y As Integer = 0

        Do Until y = Ammount

            Rnd()
            Dim a As Integer = n(3, 1)

            Dim e As String = s(7)
            If a = 1 Then
                out += vbNewLine & vbNewLine & "Public Function " & s(5) & "(" & s(8) & " as string)as string" & vbNewLine

                out += "on error goto " & e & vbNewLine
            Else
                out += vbNewLine & "Public Sub " & s(n(5, 8)) & "(" & s(9) & " as string)" & vbNewLine
            End If

            Dim i As Integer = 0

            Dim limit As Integer = n(10, 5)

            Do Until i = limit
                Rnd()
                Dim type As Integer = n(5, 0)


                If type = 1 Then
                    out += "Dim " & s(9) & " as string = " & Chr(34) & s(n(3, 11)) & Chr(34) & vbNewLine
                    i += 1
                ElseIf type = 2 Then
                    out += "msgbox(" & Chr(34) & s(n(7, 20)) & " " & s(n(7, 20)) & Chr(34) & ")" & vbNewLine
                    i += 1
                ElseIf type = 3 Then
                    Rnd()
                    out += "Dim " & s(10) & " as integer = " & n(12, 5) & vbNewLine
                    i += 1
                Else
                    out += "dim " & s(n(5, 10)) & " as integer = " & n(12, 5) & " + " & n(10, 19) & " + " & n(10, 19) & " + " & n(10, 19) & vbNewLine
                End If

            Loop
            If a = 1 Then
                out += e & ":" & vbNewLine

                Dim h As Integer = 0
                Dim hl As Integer = n(10, 3)
                Do Until h = hl

                    Dim type As Integer = n(4, 0)


                    If type = 1 Then
                        out += "Dim " & s(6) & " as string = " & Chr(34) & s(n(4, 9)) & Chr(34) & vbNewLine
                        i += 1
                    ElseIf type > 1 Then
                        out += "msgbox(" & Chr(34) & s(n(5, 10)) & " " & s(n(5, 10)) & Chr(34) & ")" & vbNewLine
                        i += 1
                        out += "If " & n(10, 19) & " > " & n(10, 19) & " then" & vbNewLine

                        out += "Dim " & s(6) & " as string = " & Chr(34) & s(n(4, 9)) & Chr(34) & vbNewLine
                        out += "Dim " & s(6) & " as string = " & Chr(34) & s(n(4, 9)) & Chr(34) & vbNewLine
                        out += "Dim " & s(6) & " as string = " & Chr(34) & s(n(4, 9)) & Chr(34) & vbNewLine
                        out += "End if" & vbNewLine

                    Else
                        Rnd()
                        out += "Dim " & s(12) & " as integer = " & n(9, 10) & vbNewLine
                        i += 1
                    End If
                    h += 1
                Loop
                out += vbNewLine

                out += "End Function" & vbNewLine & vbNewLine

            Else
                out += "End Sub" & vbNewLine & vbNewLine
            End If
            y += 1
        Loop
        out += "End Class"

        Return out
    End Function





    Function s(ByVal len As String) As String
        Dim x As New Password
        Return x.GeneratePassword(True, True, False, False, len)
    End Function

    Public Function n(ByVal MaxNumber As Integer,
    Optional ByVal MinNumber As Integer = 0) As Integer
        Rnd()
        Threading.Thread.Sleep(5)
        'initialize random number generator
        Dim r As New Random(System.DateTime.Now.Millisecond)

        If MinNumber > MaxNumber Then
            Dim t As Integer = MinNumber
            MinNumber = MaxNumber
            MaxNumber = t
        End If

        Return r.Next(MinNumber, MaxNumber)

    End Function

    Public Class Password

        Private Const PASS_UPPERS As String = "顾氏家族的成泽是顾商城公司的首席执行官顾太太希望她的生物孙"
        Private Const PASS_LOWERS As String = "子顾金羽接管公司顾成泽的任务是引导合法的继承人成为名受人尊敬的商"
        Private Const PASS_NUMBERS As String = "0123456789"
        Private Const PASS_SPECIALS As String = "~`!@#$%^&*()_+=-{[}]|;:'<,>.?"

        Public Function GeneratePassword(ByVal Uppers As Boolean, ByVal Lowers As Boolean, ByVal Numbers As Boolean, ByVal Specials As Boolean, ByVal passwordLength As Integer) As String

            Dim strCharacters As String
            Dim strNewPassword As String
            Dim p As Integer

            If Uppers = True Then
                strCharacters = strCharacters & PASS_UPPERS
            End If
            If Lowers = True Then
                strCharacters = strCharacters & PASS_LOWERS
            End If
            If Numbers = True Then
                strCharacters = strCharacters & PASS_NUMBERS
            End If
            If Specials = True Then
                strCharacters = strCharacters & PASS_SPECIALS
            End If

            Randomize()

            For p = 0 To (passwordLength - 1)
                strNewPassword = strNewPassword + Mid(strCharacters, Len(strCharacters) * Rnd() + 1, 1)
            Next

            GeneratePassword = strNewPassword

        End Function

    End Class
End Module