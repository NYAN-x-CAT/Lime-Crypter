Public Class Algorithm

    Public Shared Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function

    Public Shared Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function


    Public Shared Function String_To_Bytes(ByVal strInput As String) As Byte()
        Dim i As Integer = 0
        Dim x As Integer = 0
        Dim bytes As Byte() = New Byte((strInput.Length) / 2 - 1) {}

        While strInput.Length > i + 1
            Dim lngDecimal As Long = Convert.ToInt32(strInput.Substring(i, 2), 16)
            bytes(x) = Convert.ToByte(lngDecimal)
            i = i + 2
            x += 1
        End While

        Return bytes
    End Function

    Public Shared Function Bytes_To_String(ByVal bytes_Input As Byte()) As String
        Dim strTemp As String = ""

        For x As Integer = 0 To bytes_Input.GetUpperBound(0)
            Dim number As Integer = Integer.Parse(bytes_Input(x).ToString())
            strTemp += number.ToString("X").PadLeft(2, "0"c)
        Next

        Return strTemp
    End Function


End Class
