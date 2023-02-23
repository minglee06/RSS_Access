Imports System.Data.OleDb
Imports RSS_Access.Access_Connection
Public Class frmRSS_Access_Purchaseorder_Query
    Private Sub frmRSS_Access_Purchaseorder_Query_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim StrSelect As String = "Select * from PurchaseOrder Order By ItemNo ASC"
        Connection.Open()
        Dim myComm As New OleDbCommand(StrSelect, Connection)
        myComm.ExecuteNonQuery()
        Dim myReader As OleDbDataReader = myComm.ExecuteReader
        If myReader.HasRows Then
            Connection.Close()
            DGVPurchaseOrder.DataSource = GetData(StrSelect)
            With DGVPurchaseOrder
                .ReadOnly = True
                .AutoGenerateColumns = True
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
                '.ColumnHeadersBorderStyle = 0
                .DefaultCellStyle.Font = New Font("標楷體", 16)
                .EditMode = DataGridViewEditMode.EditProgrammatically
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .ColumnHeadersDefaultCellStyle.Font = New Font("標楷體", 16)
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(0).HeaderText = "項次"
                .Columns(1).HeaderText = "進貨單編號"
                .Columns(2).HeaderText = "進貨單日期"
                .Columns(3).HeaderText = "供應商統一編號"
                .Columns(4).HeaderText = "供應商名稱"
                .Columns(5).HeaderText = "商品編號"
                .Columns(6).HeaderText = "商品名稱"
                .Columns(7).HeaderText = "商品分類"
                .Columns(8).HeaderText = "進貨數量"
                .Columns(9).HeaderText = "進貨單位"
                .Columns(10).HeaderText = "進貨單價"
                .Columns(11).HeaderText = "總價"
            End With
        End If
        Connection.Close()
    End Sub

    Private Sub CHBPurchaseOrder_ID_Click(sender As Object, e As EventArgs) Handles CHBPurchaseOrder_ID.Click
        CHBSupply_Tax_ID.Enabled = False
        CHBPurchaseOrder_Date.Enabled = False
        DTPPurchaseOrder_Date_Begin.Enabled = False
        DTPPurchaseOrder_Date_End.Enabled = False
        TxtSupply_Tax_ID.Enabled = False
    End Sub

    Private Sub BtnReChoice_Click(sender As Object, e As EventArgs) Handles BtnReChoice.Click
        CHBSupply_Tax_ID.Enabled = True
        CHBSupply_Tax_ID.Checked = False
        TxtSupply_Tax_ID.Enabled = True
        CHBPurchaseOrder_ID.Enabled = True
        CHBPurchaseOrder_ID.Checked = False
        TxtPurchaseOrder_ID.Enabled = True
        CHBCommodity_ID.Enabled = True
        CHBCommodity_ID.Checked = False
        TxtCommodity_ID.Enabled = True
        CHBPurchaseOrder_Date.Enabled = True
        CHBPurchaseOrder_Date.Checked = False
        DTPPurchaseOrder_Date_Begin.Enabled = True
        DTPPurchaseOrder_Date_End.Enabled = True

    End Sub
    Private Sub BtnPurchaseOrder_Query_Click(sender As Object, e As EventArgs) Handles BtnPurchaseOrder_Query.Click
        Dim SelectStr As String
        'Dim StrDate As String
        Connection.Open()
        Dim PurchaseOrderIDStr As String = TxtPurchaseOrder_ID.TextBox1.Text
        Dim CommodityIDStr As String = TxtCommodity_ID.TextBox1.Text
        Dim SupplyTaxIDStr As String = TxtSupply_Tax_ID.TextBox1.Text
        '假如進貨單編號被選擇的話
        If CHBPurchaseOrder_ID.Checked Then
            If PurchaseOrderIDStr = "" Then
                MsgBox("進貨單日期不能空白", 0 + 48, "警告訊息")
            Else
                SelectStr = "Select * from PurchaseOrder where PurchaseOrder_ID=@PurchaseOrder_ID"
                Dim myComm As New OleDbCommand(SelectStr, Connection)
                myComm.Parameters.AddWithValue("@PurchaseOrder_ID", PurchaseOrderIDStr)
                myComm.ExecuteNonQuery()
                Dim myDA As New OleDbDataAdapter(myComm)
                Dim myDT As New DataTable
                myDA.Fill(myDT)
                DGVPurchaseOrder.DataSource = myDT
            End If

            '假如進貨單編號及商品編號被選擇的話
        ElseIf CHBPurchaseOrder_ID.Checked And CHBCommodity_ID.Checked Then
            If PurchaseOrderIDStr = "" Then
                MsgBox("進貨單日期不能空白", 0 + 48, "警告訊息")
            ElseIf CommodityIDStr = "" Then
                MsgBox("商品編號不能空白", 0 + 48, "警告訊息")
            Else
                SelectStr = "Select * from PurchaseOrder where PurchaseOrder_ID=@PurchaseOrder_ID and Commodity_ID=@Commodity_ID"
                Dim myComm As New OleDbCommand(SelectStr, Connection)
                myComm.Parameters.AddWithValue("@PurchaseOrder_ID", PurchaseOrderIDStr)
                myComm.Parameters.AddWithValue("@Commodity_ID", CommodityIDStr)
                myComm.ExecuteNonQuery()
                Dim myDA As New OleDbDataAdapter(myComm)
                Dim myDT As New DataTable
                myDA.Fill(myDT)
                DGVPurchaseOrder.DataSource = myDT
            End If

            '假如商品編號被選擇的話
        ElseIf CHBCommodity_ID.Checked Then
            SelectStr = "Select * from PurchaseOrder Where Commodity_ID=@Commodity_ID"
            Dim myComm As New OleDbCommand(SelectStr, Connection)
            myComm.Parameters.AddWithValue("@Commodity_ID", CommodityIDStr)
            myComm.ExecuteNonQuery()
            Dim myDA As New OleDbDataAdapter(myComm)
            Dim myDT As New DataTable
            myDA.Fill(myDT)
            DGVPurchaseOrder.DataSource = myDT
            '假如商品編號及進貨單日期被選擇的話
        ElseIf CHBCommodity_ID.Checked And CHBPurchaseOrder_Date.Checked Then
            SelectStr = "Select * from PurchaseOrder where Commodity_ID=@Commodity_ID and PurchaseOrder_Date Between @PurchaseOrder_Date_Begin and @PurchaseOrder_Date_End"
            Dim myComm As New OleDbCommand(SelectStr, Connection)
            myComm.Parameters.AddWithValue("@Commodity_ID", CommodityIDStr)
            myComm.Parameters.AddWithValue("@PurchaseOrder_Date_Begin", DTPPurchaseOrder_Date_Begin.Value)
            myComm.Parameters.AddWithValue("@PurchaseOrder_Date_End", DTPPurchaseOrder_Date_End.Value)
            myComm.ExecuteNonQuery()
            Dim myDA As New OleDbDataAdapter(myComm)
            Dim myDT As New DataTable
            myDA.Fill(myDT)
            DGVPurchaseOrder.DataSource = myDT
            '假如供應商統一編號被選擇的話
        ElseIf CHBSupply_Tax_ID.Checked Then
            SelectStr = "Select * from PurchaseOrder Where Supply_Tax_ID=@Supply_Tax_ID"
            Dim myComm As New OleDbCommand(SelectStr, Connection)
            myComm.Parameters.AddWithValue("@Supply_Tax_ID", SupplyTaxIDStr)
            myComm.ExecuteNonQuery()
            Dim myDA As New OleDbDataAdapter(myComm)
            Dim myDT As New DataTable
            myDA.Fill(myDT)
            DGVPurchaseOrder.DataSource = myDT
            '假如供應商統一編號及進貨單日期被選擇
        ElseIf CHBSupply_Tax_ID.Checked And CHBPurchaseOrder_Date.Checked Then
            SelectStr = "Select * from PurchaseOrder Where Supply_Tax_ID=@Supply_Tax_ID and PurChaseOrder_Date Between @PurchaseOrder_Date_Begin and @PurChaseOrder_Date_End"
            Dim myComm As New OleDbCommand(SelectStr, Connection)
            myComm.Parameters.AddWithValue("@Supply_Tax_ID", SupplyTaxIDStr)
            myComm.Parameters.AddWithValue("@PurchaseOrder_Date_Begin", DTPPurchaseOrder_Date_Begin.Value)
            myComm.Parameters.AddWithValue("@PurchaseOrder_Date_End", DTPPurchaseOrder_Date_End.Value)
            myComm.ExecuteNonQuery()
            Dim myDA As New OleDbDataAdapter(myComm)
            Dim myDT As New DataTable
            myDA.Fill(myDT)
            DGVPurchaseOrder.DataSource = myDT
            '假如進貨單日期被選擇的話
        ElseIf CHBPurchaseOrder_Date.Checked Then
            SelectStr = "Select * from PurchaseOrder Where PurchaseOrder_Date Between @PurchaseOrder_Date_Begin and @PurchaseOrder_Date_End"
            Dim myComm As New OleDbCommand(SelectStr, Connection)
            myComm.Parameters.AddWithValue("@PurchaseOrder_Date_Begin", DTPPurchaseOrder_Date_Begin.Value)
            myComm.Parameters.AddWithValue("@PurchaseOrder_Date_End", DTPPurchaseOrder_Date_End.Value)
            myComm.ExecuteNonQuery()
            Dim myDA As New OleDbDataAdapter(myComm)
            Dim myDT As New DataTable
            myDA.Fill(myDT)
            DGVPurchaseOrder.DataSource = myDT
        End If

        Connection.Close()
    End Sub

    Private Sub CHBCommodity_ID_Click(sender As Object, e As EventArgs) Handles CHBCommodity_ID.Click
        CHBSupply_Tax_ID.Enabled = False
        TxtSupply_Tax_ID.Enabled = False
    End Sub
End Class