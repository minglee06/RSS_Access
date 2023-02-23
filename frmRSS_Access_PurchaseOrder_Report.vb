Public Class frmRSS_Access_PurchaseOrder_Report
    Private Sub frmRSS_Access_PurchaseOrder_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'RSS_AccessDataSet.PurchaseOrder' 資料表。您可以視需要進行移動或移除。
        Me.PurchaseOrderTableAdapter.Fill(Me.RSS_AccessDataSet.PurchaseOrder)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnQuery_Click(sender As Object, e As EventArgs) Handles BtnQuery.Click
        Try
            If Not String.IsNullOrEmpty(TxtPurchaseOrderQuery.TextBox1.Text) Then
                Dim KeyWord As String = TxtPurchaseOrderQuery.TextBox1.Text
                Me.PurchaseOrderBindingSource.Filter = "PurchaseOrder_ID=" & KeyWord
                Me.ReportViewer1.RefreshReport()
            Else
                Me.PurchaseOrderBindingSource.RemoveFilter()
                frmRSS_Access_PurchaseOrder_Report_Load(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 0 + 48, "警告訊息")
        End Try
    End Sub
End Class