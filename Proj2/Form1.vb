Public Class Form1

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim strName As String
        strName = tbx.Text
        lblName.Text = strName
        lblName.Visible = True
        tbx.Text = ""

    End Sub

    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        lblName.Text = ""

    End Sub
End Class
