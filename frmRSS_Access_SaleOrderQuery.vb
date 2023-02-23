Imports System.Data.OleDb
Imports RSS_Access.Access_Connection

Public Class frmRSS_Access_SaleOrderQuery
    Private _SaleOrderID As String
    Public ReadOnly Property GetSaleOrderID As String
        Get
            If TxtSaleOrder_ID.Text <> "" And IsNumeric(TxtSaleOrder_ID.Text) And Len(TxtSaleOrder_ID.Text) = 12 Then
                _SaleOrderID = TxtSaleOrder_ID.Text
            End If
            Return _SaleOrderID
        End Get

    End Property
    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles BtnModify.Click
        Dim SelectStr As String = "Select * from SaleOrder Where ItemNo=@ItemNo And SaleOrder_ID=@SaleOrder_ID"
        Dim SelectComm As New OleDbCommand(SelectStr, Connection)
        Dim UpdateStr As String = "UPDATE SaleOrder SET ItemNo=@ItemNo,Customer_Tax_ID=@Customer_Tax_ID," &
            "Customer_Name=@Customer_Name,Supply_Tax_ID=@Supply_Tax_ID," &
            "Supply_Name=@Supply_Name,Commodity_ID=@Commodity_ID," &
            "Commodity_Name=@Commodity_Name,Commodity_Classification_Type=@Commodity_Classification_Type," &
            "Commodity_Unit=@Commodity_Unit,Commodity_Qty=@Commodity_Qty," &
            "Commodity_Price=@Commodity_Price,CommodityTotalPrice=@CommodityTotalPrice WHERE ItemNo=@ItemNo"
        If TxtSaleOrder_ID.Text = "" Or IsNumeric(TxtSaleOrder_ID.Text) = False Or Len(TxtSaleOrder_ID.Text) <> 12 Then
            MsgBox("銷貨單編號需12碼數字", 0 + 48, "警告訊息")
        ElseIf TxtItemNo.Text = "" Or IsNumeric(TxtItemNo.Text) = False Then
            MsgBox("項次不能空白", 0 + 48, "警告訊息")
        ElseIf TxtCustomerTaxID.Text = "" Or IsNumeric(TxtCustomerTaxID.Text) = False Or Len(TxtCustomerTaxID.Text) <> 8 Then
            MsgBox("客戶統編必須是8碼數字", 0 + 48, "警告訊息")
        ElseIf TxtCustomerName.Text = "" Then
            MsgBox("客戶名稱不能空白", 0 + 48, "警告訊息")
        ElseIf TxtSupplyTaxID.Text = "" Or Len(TxtSupplyTaxID.Text) <> 8 Or IsNumeric(TxtSupplyTaxID.Text) = False Then
            MsgBox("供應商統編必須是8碼數字", 0 + 48, "警告訊息")
        ElseIf TxtSupplyName.Text = "" Then
            MsgBox("供應商名稱不能空白", 0 + 48, "警告訊息")
        ElseIf TxtCommodityID.Text = "" Or IsNumeric(TxtCommodityID.Text) = False Or Len(TxtCommodityID.Text) <> 13 Then
            MsgBox("商品編號必須是13碼數字", 0 + 48, "警告訊息")
        ElseIf TxtCommodityName.Text = "" Then
            MsgBox("商品名稱不能空白", 0 + 48, "警告訊息")
        ElseIf TxtCommodityClassification.Text = "" Then
            MsgBox("商品分類不能空白", 0 + 48, "警告訊息")
        ElseIf TxtCommodityUnit.Text = "" Then
            MsgBox("商品單位不能空白", 0 + 48, "警告訊息")
        ElseIf TxtSaleQty.Text = "" Or IsNumeric(TxtSaleQty.Text) = False Then
            MsgBox("數量必須是數字", 0 + 48, "警告訊息")
        ElseIf TxtSaleUnitPrice.Text = "" Or IsNumeric(TxtSaleUnitPrice.Text) = False Then
            MsgBox("單價必須是數字", 0 + 48, "警告訊息")
        ElseIf TxtTotal.Text = "" Or IsNumeric(TxtTotal.Text) = False Then
            MsgBox("合計必須是數字", 0 + 48, "警告訊息")
        Else
            TxtTotal.Text = CInt(TxtSaleQty.Text) * CInt(TxtSaleUnitPrice.Text)
            Connection.Open()
            Dim UpdateComm As New OleDbCommand(UpdateStr, Connection)
            SelectComm.Parameters.AddWithValue("@ItemNo", CInt(TxtItemNo.Text))
            SelectComm.Parameters.AddWithValue("@SaleOrder_ID", TxtSaleOrder_ID.Text)
            SelectComm.ExecuteNonQuery()
            Dim SelectReader As OleDbDataReader = SelectComm.ExecuteReader
            If SelectReader.HasRows Then
                Dim x = MsgBox("確定要更新?", 4 + 48, "詢問訊息")
                If x = 6 Then
                    UpdateComm.Parameters.AddWithValue("@ItemNo", CInt(TxtItemNo.Text))
                    ' UpdateComm.Parameters.AddWithValue("@SaleOrder_ID", TxtSaleOrder_ID.Text)
                    UpdateComm.Parameters.AddWithValue("@Customer_Tax_ID", TxtCustomerTaxID.Text)
                    UpdateComm.Parameters.AddWithValue("@Customer_Name", TxtCustomerName.Text)
                    UpdateComm.Parameters.AddWithValue("@Supply_Tax_ID", TxtSupplyTaxID.Text)
                    UpdateComm.Parameters.AddWithValue("@Supply_Name", TxtSupplyName.Text)
                    UpdateComm.Parameters.AddWithValue("@Commodity_ID", TxtCommodityID.Text)
                    UpdateComm.Parameters.AddWithValue("@Commodity_Name", TxtCommodityName.Text)
                    UpdateComm.Parameters.AddWithValue("@Commodity_Classification_Type", TxtCommodityClassification.Text)
                    UpdateComm.Parameters.AddWithValue("@Commodity_Unit", TxtCommodityUnit.Text)
                    UpdateComm.Parameters.AddWithValue("@Commodity_Qty", TxtSaleQty.Text)
                    UpdateComm.Parameters.AddWithValue("@Commodity_Price", TxtSaleUnitPrice.Text)
                    UpdateComm.Parameters.AddWithValue("@CommodityTotalPrice", TxtTotal.Text)
                    UpdateComm.ExecuteNonQuery()
                    MsgBox("更新成功", 0 + 48, "通知訊息")
                End If
            End If

        End If
        Connection.Close()
        Dim y = MsgBox("要修改另一銷貨單嗎", 4 + 48, "通知訊息")
        If y = 6 Then
            Dim ReSelectStr As String = "Select * From SaleOrder Order by ItemNo "
            BindingSource1.DataSource = GetData(ReSelectStr)
            BindingSource1.Filter = ""
            DGVSaleOrder.DataSource = BindingSource1
            EnabledFalse()
            BtnReset.PerformClick()
            TxtSaleOrder_ID.Focus()
        Else
            Dim ReSelectStr As String = "Select * From SaleOrder Order by ItemNo "
            BindingSource1.DataSource = GetData(ReSelectStr)
            BindingSource1.Filter = "SaleOrder_ID=" & TxtSaleOrder_ID.Text
            DGVSaleOrder.DataSource = BindingSource1
        End If

    End Sub

    Private Sub frmRSS_Access_SaleOrderQuery_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim SelectStr As String = "Select * From SaleOrder Order By ItemNo"
        BindingSource1.DataSource = GetData(SelectStr)
        DGVSaleOrder.DataSource = BindingSource1
        With DGVSaleOrder
            .AutoGenerateColumns = True
            '.ColumnHeadersBorderStyle = 0
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
            .EnableHeadersVisualStyles = False
            .DefaultCellStyle.Font = New Font("標楷體", 14)
            .EditMode = DataGridViewEditMode.EditProgrammatically
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            .ColumnHeadersDefaultCellStyle.Font = New Font("標楷體", 14)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).HeaderText = "項次"
            .Columns(1).HeaderText = "銷貨單編號"
            .Columns(2).HeaderText = "銷貨單日期"
            .Columns(3).HeaderText = "客戶統編"
            .Columns(4).HeaderText = "客戶名稱"
            .Columns(5).HeaderText = "供應商統編"
            .Columns(6).HeaderText = "供應商名稱"
            .Columns(7).HeaderText = "商品編號"
            .Columns(8).HeaderText = "商品名稱"
            .Columns(9).HeaderText = "商品分類"
            .Columns(10).HeaderText = "商品單位"
            .Columns(11).HeaderText = "銷貨數量"
            .Columns(12).HeaderText = "銷貨單價"
            .Columns(13).HeaderText = "合計"
        End With
        EnabledFalse()

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim SelectStr As String = "Select * From SaleOrder where SaleOrder_ID=@SaleOrder_ID"
        If TxtSaleOrder_ID.Text = "" Or Len(TxtSaleOrder_ID.Text) <> 12 Or IsNumeric(TxtSaleOrder_ID.Text) = False Then
            MsgBox("銷貨單編號須是12碼數字", 0 + 48, "警告訊息")
        Else
            Connection.Open()
            Dim mySelectComm As New OleDbCommand(SelectStr, Connection)
            mySelectComm.Parameters.AddWithValue("@SaleOrder_ID", TxtSaleOrder_ID.Text)
            mySelectComm.ExecuteNonQuery()
            Dim myDA As New OleDbDataAdapter(mySelectComm)
            Dim myDT As New DataTable
            myDA.Fill(myDT)
            Connection.Close()
            BindingSource1.DataSource = myDT
            DGVSaleOrder.DataSource = BindingSource1
            DGVSaleOrder.Enabled = True
        End If
    End Sub
    Private Sub EnabledFalse()
        TxtSaleOrder_ID.Enabled = True
        BtnSearch.Enabled = True
        TxtItemNo.Enabled = False
        DTPSaleOrder_Date.Enabled = False
        TxtCustomerTaxID.Enabled = False
        TxtCustomerName.Enabled = False
        TxtSupplyTaxID.Enabled = False
        TxtSupplyName.Enabled = False
        TxtCommodityID.Enabled = False
        TxtCommodityName.Enabled = False
        TxtCommodityClassification.Enabled = False
        TxtCommodityUnit.Enabled = False
        TxtSaleQty.Enabled = False
        TxtSaleUnitPrice.Enabled = False
        TxtTotal.Enabled = False
        'BtnDel.Enabled = False
        'BtnModify.Enabled = False
        'BtnPrint.Enabled = False
        'BtnReset.Enabled = False
        DGVSaleOrder.Enabled = False
    End Sub
    Private Sub EnabledTrue()
        TxtSaleOrder_ID.Enabled = False
        TxtItemNo.Enabled = False
        DTPSaleOrder_Date.Enabled = False
        TxtCustomerTaxID.Enabled = True
        TxtCustomerName.Enabled = True
        TxtSupplyTaxID.Enabled = True
        TxtSupplyName.Enabled = True
        TxtCommodityID.Enabled = True
        TxtCommodityName.Enabled = True
        TxtCommodityClassification.Enabled = False
        TxtCommodityUnit.Enabled = False
        TxtSaleQty.Enabled = True
        TxtSaleUnitPrice.Enabled = True
        TxtTotal.Enabled = True
        BtnDel.Enabled = True
        BtnModify.Enabled = True
        BtnPrint.Enabled = True
        BtnReset.Enabled = True
        BtnSearch.Enabled = False
    End Sub

    Private Sub DGVSaleOrder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSaleOrder.CellClick
        TxtItemNo.Text = DGVSaleOrder.CurrentRow.Cells(0).Value
        TxtSaleOrder_ID.Text = DGVSaleOrder.CurrentRow.Cells(1).Value
        DTPSaleOrder_Date.Value = DGVSaleOrder.CurrentRow.Cells(2).Value
        TxtCustomerTaxID.Text = DGVSaleOrder.CurrentRow.Cells(3).Value
        TxtCustomerName.Text = DGVSaleOrder.CurrentRow.Cells(4).Value
        TxtSupplyTaxID.Text = DGVSaleOrder.CurrentRow.Cells(5).Value
        TxtSupplyName.Text = DGVSaleOrder.CurrentRow.Cells(6).Value
        TxtCommodityID.Text = DGVSaleOrder.CurrentRow.Cells(7).Value
        TxtCommodityName.Text = DGVSaleOrder.CurrentRow.Cells(8).Value
        TxtCommodityClassification.Text = DGVSaleOrder.CurrentRow.Cells(9).Value
        TxtCommodityUnit.Text = DGVSaleOrder.CurrentRow.Cells(10).Value
        TxtSaleQty.Text = DGVSaleOrder.CurrentRow.Cells(11).Value
        TxtSaleUnitPrice.Text = DGVSaleOrder.CurrentRow.Cells(12).Value
        TxtTotal.Text = DGVSaleOrder.CurrentRow.Cells(13).Value
        EnabledTrue()
    End Sub

    Private Sub TxtTotal_Enter(sender As Object, e As EventArgs) Handles TxtTotal.Enter
        If TxtSaleQty.Text = "" Or IsNumeric(TxtSaleQty.Text) = False Then
            MsgBox("銷貨數量須是數字", 0 + 48, "警告訊息")
        ElseIf TxtSaleUnitPrice.Text = "" Or IsNumeric(TxtSaleUnitPrice.Text) = False Then
            MsgBox("銷貨單價須是數字", 0 + 48, "警告訊息")
        Else
            TxtTotal.Text = CInt(TxtSaleQty.Text) * CInt(TxtSaleUnitPrice.Text)
        End If
    End Sub

    Private Sub TxtCustomerName_Enter(sender As Object, e As EventArgs) Handles TxtCustomerName.Enter
        Dim CustomerSelectStr As String = "Select Customer_Co_Name from Customer Where Customer_Tax_ID=@Customer_Tax_ID"
        Connection.Open()

        If TxtCustomerTaxID.Text = "" Or IsNumeric(TxtCustomerTaxID.Text) = False Or Len(TxtCustomerTaxID.Text) <> 8 Then
            MsgBox("客戶統一編號須為8碼數字", 0 + 48, "警告訊息")
        Else
            Dim SelectComm As New OleDbCommand(CustomerSelectStr, Connection)
            SelectComm.Parameters.AddWithValue("@Customer_Co_ID", TxtCustomerTaxID.Text)
            SelectComm.ExecuteNonQuery()
            Dim SelectReader As OleDbDataReader = SelectComm.ExecuteReader
            While SelectReader.Read
                TxtCustomerName.Text = SelectReader.Item(0).ToString
            End While
        End If
        Connection.Close()
    End Sub

    Private Sub TxtSupplyName_Enter(sender As Object, e As EventArgs) Handles TxtSupplyName.Enter
        Dim SelectStr As String = "Select Supply_Co_Name From Supply Where Supply_Tax_ID=@Supply_Tax_ID"
        Connection.Open()
        If TxtSupplyTaxID.Text = "" Or IsNumeric(TxtSupplyTaxID.Text) = False Or Len(TxtSupplyTaxID.Text) <> 8 Then
            MsgBox("供應商統一編號須為8碼數字", 0 + 48, "警告訊息")
        Else
            Dim SelectComm As New OleDbCommand(SelectStr, Connection)
            SelectComm.Parameters.AddWithValue("@Supply_Tax_ID", TxtSupplyTaxID.Text)
            SelectComm.ExecuteNonQuery()
            Dim SelectReader As OleDbDataReader = SelectComm.ExecuteReader
            While SelectReader.Read
                TxtSupplyName.Text = SelectReader.Item(0).ToString
            End While
        End If
        Connection.Close()
    End Sub

    Private Sub TxtCommodityName_Enter(sender As Object, e As EventArgs) Handles TxtCommodityName.Enter
        Dim SelectStr As String = "Select * From Commodity Where Commodity_ID=@Commodity_ID"
        Connection.Open()
        If TxtCommodityID.Text = "" Or Len(TxtCommodityID.Text) <> 13 Or IsNumeric(TxtCommodityID.Text) = False Then
            MsgBox("商品編號須為13碼數字", 0 + 48, "警告訊息")
        Else
            Dim SelectCom As New OleDbCommand(SelectStr, Connection)
            SelectCom.Parameters.AddWithValue("@Commodity_ID", TxtCommodityID.Text)
            SelectCom.ExecuteNonQuery()
            Dim SelectReader As OleDbDataReader = SelectCom.ExecuteReader
            If SelectReader.HasRows Then
                While SelectReader.Read
                    TxtCommodityName.Text = SelectReader.Item(2).ToString
                    TxtCommodityClassification.Text = SelectReader.Item(3).ToString
                    TxtCommodityUnit.Text = SelectReader.Item(8).ToString
                End While
            End If
        End If
        Connection.Close()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtSaleOrder_ID.Text = ""
        TxtItemNo.Text = ""
        DTPSaleOrder_Date.Value = Now
        TxtCustomerTaxID.Text = ""
        TxtCustomerName.Text = ""
        TxtSupplyTaxID.Text = ""
        TxtSupplyName.Text = ""
        TxtCommodityID.Text = ""
        TxtCommodityName.Text = ""
        TxtCommodityClassification.Text = ""
        TxtCommodityUnit.Text = ""
        TxtSaleQty.Text = ""
        TxtSaleUnitPrice.Text = ""
        TxtTotal.Text = ""
        Dim SelectStr As String = "Select * From SaleOrder Order By ItemNo"
        BindingSource1.DataSource = GetData(SelectStr)
        DGVSaleOrder.DataSource = BindingSource1
        EnabledFalse()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim DelStr As String = "Delete from SaleOrder Where ItemNo=@ItemNo"
        Dim SelectStr As String = "Select * From SaleOrder Where ItemNo=@ItemNo"
        Connection.Open()
        Dim SelectComm As New OleDbCommand(SelectStr, Connection)
        Dim DelComm As New OleDbCommand(DelStr, Connection)
        If TxtItemNo.Text = "" Or IsNumeric(TxtItemNo.Text) = False Then
            MsgBox("項次須為數字", 0 + 48, "警告訊息")
        Else
            SelectComm.Parameters.AddWithValue("@ItemNo", TxtItemNo.Text)
            SelectComm.ExecuteNonQuery()
            Dim SelectReader As OleDbDataReader = SelectComm.ExecuteReader
            If SelectReader.HasRows Then
                Dim X = MsgBox("]確定要刪除此筆資料?", 4 + 48, "警告訊息")
                If X = 6 Then
                    DelComm.Parameters.AddWithValue("@ItemNo", TxtItemNo.Text)
                    DelComm.ExecuteNonQuery()
                End If
            Else
                MsgBox("無此項次編號", 0 + 48, "警告訊息")
            End If
        End If
        Connection.Close()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim myForm As New frmRSS_Access_SaleOrder_Report
        myForm.TopMost = True
        myForm.Show()
    End Sub
End Class