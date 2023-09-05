Public Class Form1
    Private Sub BtnYourGender_Click(sender As Object, e As EventArgs) Handles btnYourGender.Click
        Dim YourGender As String
        YourGender = ListBox1.SelectedItem
        MsgBox("You are " & YourGender)

    End Sub
End Class
