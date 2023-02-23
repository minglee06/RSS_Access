Public Class frmLoginSucced
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        Dim myFrm As New frmRSS_Access_Main
        myFrm.Show()
        Me.Close()
        Me.Dispose()
    End Sub
End Class