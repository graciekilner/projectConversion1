Public Class frmMenu
    Private Sub btnPounds_Click(sender As Object, e As EventArgs) Handles btnPounds.Click
        Conversion1.Show()
        Me.Close()
    End Sub

    Private Sub btnKilograms_Click(sender As Object, e As EventArgs) Handles btnKilograms.Click
        Conversion2.Show()
        Me.Close()
    End Sub
End Class