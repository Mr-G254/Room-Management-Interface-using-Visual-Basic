Public Class Room
    Private Rm_number As Integer
    Private Rm_status As String
    Private Bed_num As Integer

    Public Sub New(Room_number As Integer, Room_status As String, No_of_beds As Integer)
        Rm_number = Room_number
        Rm_status = Room_status
        Bed_num = No_of_beds

        If Bed_num > 5 Then
            Bed_num = 5
        End If

    End Sub

    Public Function get_Room_Number() As Integer
        Return Rm_number
    End Function

    Public Function get_Room_Status() As String
        Return Rm_status
    End Function

    Public Function get_Number_of_Beds() As Integer
        Return Bed_num
    End Function

End Class
