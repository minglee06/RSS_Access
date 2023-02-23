Public Class frmRSS_Access_WarehouseVoucher_Report
    Private Sub frmRSS_Access_WarehouseVoucher_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'RSS_AccessDataSet1.WarehouseVoucher' 資料表。您可以視需要進行移動或移除。
        Me.WarehouseVoucherTableAdapter.Fill(Me.RSS_AccessDataSet1.WarehouseVoucher)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnQuery_Click(sender As Object, e As EventArgs) Handles BtnQuery.Click
        Try
            If Not String.IsNullOrEmpty(TxtWarehouseVoucherQuery.TextBox1.Text) Then
                Dim KeyWord As String = TxtWarehouseVoucherQuery.TextBox1.Text
                Me.WarehouseVoucherBindingSource.Filter = "WV_ID=" & KeyWord
                Me.ReportViewer1.RefreshReport()
            Else
                Me.WarehouseVoucherBindingSource.RemoveFilter()
                frmRSS_Access_WarehouseVoucher_Report_Load(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 0 + 48, "警告訊息")
        End Try
    End Sub
End Class