Public Class login
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim varUser As String = txtUsername.Text
        Dim VarPass As String = txtPassword.Text

        Dim VarActUser As String = "admin"
        Dim varActPass As String = "Pass1234"

        If ((varUser = VarActUser) And (VarPass = varActPass)) Then

            ' successful login
            frmMenu.Show()
            Me.Hide()

        Else

            ' login failure
            MsgBox("Login failed")

        End If

    End Sub
End Class