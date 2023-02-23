Public Class frmRSS_Access
    Private Sub frmRSS_Access_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            lblVersionNum.Text = My.Application.Info.Version.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub lblEnter_Click(sender As Object, e As EventArgs) Handles lblEnter.Click
        Try
            Me.Hide()
            frmLogin.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class