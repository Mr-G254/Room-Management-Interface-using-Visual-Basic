Public Class Occupants
    Private fullname As String
    Private id_num As String
    Private email As String
    Private phone_number As String

    Public Sub New(Name As String, Id As String, mail As String, pho_number As String)
        fullname = Name
        id_num = Id
        email = mail
        phone_number = pho_number

    End Sub

    Public Function get_name() As String
        Return fullname
    End Function

    Public Function get_id() As String
        Return id_num
    End Function

    Public Function get_mail() As String
        Return email
    End Function

    Public Function get_number() As String
        Return phone_number
    End Function
End Class
