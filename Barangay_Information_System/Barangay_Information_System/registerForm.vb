
Public Class registerForm
    Dim i As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'register new account
        Dim que As String = "INSERT INTO `tblresident`( `FirstName`, `MiddleName`, `LastName`, `Sex`, `Occupation`, `MaritalStatus`, `BirthDay`, `Picture`, `Address_idAddress`, `tblRecord_idRecord`) Values ('" & residentNo.Text & "','" & fn.Text & "','" & mn.Text & "','" & ln.Text & "'.'" & sex.Text & "','" & occupation.Text & "','" & status.Text & "','" & bday.Value & "' ,'" & purok.Text & "','" & newRecordID & "') "
        connect(que)
        Hide()
        mainForm.Show()
    End Sub

    Private Sub registerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recordID()
    End Sub

End Class