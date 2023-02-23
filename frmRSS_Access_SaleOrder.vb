Imports System.Data.OleDb
Imports RSS_Access.Access_Connection
Public Class frmRSS_Access_SaleOrder
    Private Property myTableText As New TableText
    Private Property myTableText1 As New TableText
    Private Property myTableText2 As New TableText
    Private Property myTableText3 As New TableText
    Private Property myRowCount As Integer
    Private Sub frmRSS_Access_SaleOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtCustomer_Tax_ID.TextBox1.MaxLength = 8
        TLPSaleOrder.RowCount += 1
        TLPSaleOrder.Height += 80
        Dim i As Double = TLPSaleOrder.Height / TLPSaleOrder.RowCount
        TLPSaleOrder.RowStyles.Add(New RowStyle(sizeType:=SizeType.Absolute, i))
        For Each style As RowStyle In TLPSaleOrder.RowStyles
            style.SizeType = SizeType.Absolute
            style.Height = i
        Next
        SaleOrderData()
        AddhandleData()
        Dim mySelectStr1 As String = "Select SaleOrder_ID from SaleOrder "
        Dim myDT As DataTable = GetData(mySelectStr1)
        Dim mySelectRowsStr = "Select SaleOrder_ID from SaleOrder Order By SaleOrder_ID ASC"
        Dim mySaleOrderID As String
        Dim StrYear As String = Now.Date.Year
        Dim StrMonth As String = Now.Date.Month
        If Len(StrMonth) = 1 Then
            StrMonth = "00" & StrMonth
        ElseIf Len(StrMonth) = 2 Then
            StrMonth = "0" & StrMonth
        End If
        Dim LeftStr As String = StrYear & StrMonth
        Dim StrNumber As Integer
        Connection.Open()
        If myDT.Rows.Count = 0 Then
            mySaleorderID = StrYear & StrMonth & "00001"
            TxtSaleOrder_ID.TextBox1.Text = mySaleorderID
        ElseIf myDT.Rows.Count = 1 Then
            Dim mySelectOnlyOneComm As New OleDbCommand(mySelectStr1, Connection)
            mySelectOnlyOneComm.ExecuteNonQuery()
            Dim mySelectOnlyOneReader As OleDbDataReader = mySelectOnlyOneComm.ExecuteReader
            While mySelectOnlyOneReader.Read
                mySaleorderID = mySelectOnlyOneReader.Item(0).ToString
                If Convert.ToInt32(Strings.Left(mySaleOrderID, 4)) = Now.Year Then
                    Dim Str1 As String = Strings.Left(mySaleOrderID, 7)
                    Dim Str2 As String = Strings.Right(Str1, 3)
                    If Convert.ToInt32(Str2) = Now.Month Then
                        StrNumber = Convert.ToInt32(mySaleOrderID, 5)
                        StrNumber += 1
                        If Strings.Len(StrNumber) = 5 Then
                            TxtSaleOrder_ID.TextBox1.Text = Str1 & StrNumber
                        ElseIf Strings.Len(StrNumber) = 4 Then
                            TxtSaleOrder_ID.TextBox1.Text = Str1 & "0" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 3 Then
                            TxtSaleOrder_ID.TextBox1.Text = Str1 & "00" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 2 Then
                            TxtSaleOrder_ID.TextBox1.Text = Str1 & "000" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 1 Then
                            TxtSaleOrder_ID.TextBox1.Text = Str1 & "0000" & StrNumber
                        End If
                    ElseIf Convert.ToInt32(Str2) < Now.Month Then
                        TxtSaleOrder_ID.TextBox1.Text = StrYear & StrMonth & "00001"
                    End If
                ElseIf Convert.ToInt32(Strings.Left(mySaleOrderID, 4)) < Now.Year Then
                    TxtSaleOrder_ID.TextBox1.Text = StrYear & StrMonth & "00001"
                End If
            End While
            mySelectOnlyOneReader.Close()
        ElseIf myDT.Rows.Count > 1 Then
            Dim mySelectComm As New OleDbCommand(mySelectRowsStr, Connection)
            mySelectComm.ExecuteNonQuery()
            Dim myReader1 As OleDbDataReader = mySelectComm.ExecuteReader
            If myReader1.HasRows Then
                While myReader1.Read
                    mySaleorderID = myReader1.Item(0).ToString
                    If Convert.ToInt32(Strings.Left(mySaleOrderID, 4)) = Now.Year Then
                        Dim Str1 As String = Strings.Left(mySaleOrderID, 7)
                        Dim Str2 As String = Strings.Right(Str1, 3)
                        If Convert.ToInt32(Str2) = Now.Month Then
                            StrNumber = Convert.ToInt32(mySaleOrderID, 5)
                            StrNumber += 1
                            If Strings.Len(StrNumber) = 5 Then
                                TxtSaleOrder_ID.TextBox1.Text = Str1 & StrNumber
                            ElseIf Strings.Len(StrNumber) = 4 Then
                                TxtSaleOrder_ID.TextBox1.Text = Str1 & "0" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 3 Then
                                TxtSaleOrder_ID.TextBox1.Text = Str1 & "00" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 2 Then
                                TxtSaleOrder_ID.TextBox1.Text = Str1 & "000" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 1 Then
                                TxtSaleOrder_ID.TextBox1.Text = Str1 & "0000" & StrNumber
                            End If
                        ElseIf Convert.ToInt32(Str2) < Now.Month Then
                            TxtSaleOrder_ID.TextBox1.Text = StrYear & StrMonth & "00001"
                        End If
                    ElseIf Convert.ToInt32(Strings.Left(mySaleOrderID, 4)) < Now.Year Then
                        TxtSaleOrder_ID.TextBox1.Text = StrYear & StrMonth & "00001"
                    End If
                End While
                myReader1.Close()
            End If
        End If
        Connection.Close()
    End Sub
    Private Sub SaleOrderData()
        Dim myLabelItem As New Label
        With myLabelItem
            .Name = "myLabelItem" & TLPSaleOrder.RowCount - 1
            .TextAlign = 32
            .Font = New Font("標楷體", 20)
            .Dock = DockStyle.None
            .Text = TLPSaleOrder.RowCount - 1
            .Anchor = AnchorStyles.None
        End With
        Dim TxtSupplyID As New TableText
        With TxtSupplyID
            .Name = "TxtSupplyID" & TLPSaleOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            '.Dock = DockStyle.Fill
            .TextBox1.MaxLength = 8
            .Anchor = AnchorStyles.None
        End With
        Dim TxtSupplyName As New TableText
        With TxtSupplyName
            .Name = "TxtSupplyName" & TLPSaleOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            '.Dock = DockStyle.Fill
            '.TextBox1.MaxLength = 20
            .Anchor = AnchorStyles.None
        End With
        Dim TxtCommodityID As New TableText
        With TxtCommodityID
            .Name = "TxtCommodityID" & TLPSaleOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            '.Dock = DockStyle.Fill
            .TextBox1.MaxLength = 13
            .Anchor = AnchorStyles.None
        End With
        Dim TxtCommodityName As New TableText
        With TxtCommodityName
            .Name = "TxtCommodityName" & TLPSaleOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            '.Dock = DockStyle.Fill
            '.TextBox1.MaxLength = 20
            .Anchor = AnchorStyles.None
        End With
        Connection.Open()
        Dim mySelectStr As String = "Select Commodity_Classification_Type from Commodity_Classification"
        Dim myComm As New OleDbCommand(mySelectStr, Connection)
        myComm.ExecuteNonQuery()
        Dim CMBCommodityClassificationType As New ComboBox
        Dim myReader As OleDbDataReader = myComm.ExecuteReader
        If myReader.HasRows Then
            While myReader.Read
                CMBCommodityClassificationType.Items.Add(myReader.Item(0).ToString)
            End While
            myReader.Close()
        End If
        With CMBCommodityClassificationType
            .Name = "CMBCommodityClassificationType" & TLPSaleOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            .BackColor = Color.FromArgb(94, 148, 255)
            .ForeColor = Color.White
            ' .Dock = DockStyle.Fill
            .Text = "請選擇"
        End With
        Connection.Close()
        Dim CMBCommodityUnit As New ComboBox
        With CMBCommodityUnit
            .Name = "CMBCommodityUnit" & TLPSaleOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            .BackColor = Color.FromArgb(94, 148, 255)
            .ForeColor = Color.White
            '.Dock = DockStyle.Fill
            '.Anchor = AnchorStyles.None
            .Text = "請選擇"
        End With
        CMBCommodityUnit.Items.Add("包")
        CMBCommodityUnit.Items.Add("袋")
        CMBCommodityUnit.Items.Add("箱")
        CMBCommodityUnit.Items.Add("盒")
        CMBCommodityUnit.Items.Add("瓶")
        CMBCommodityUnit.Items.Add("罐")
        CMBCommodityUnit.Items.Add("台")
        CMBCommodityUnit.Items.Add("張")
        CMBCommodityUnit.Items.Add("座")
        CMBCommodityUnit.Items.Add("本")
        Dim TxtCommodityQty As New TableText
        With TxtCommodityQty
            Name = "TxtCommodityQty" & TLPSaleOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            .Dock = DockStyle.None
            .Anchor = AnchorStyles.None
            .TextBox1.MaxLength = 6
            '.TextBox1.TextAlign = HorizontalAlignment.Center
            .TextBox1.Text = "0"
        End With
        Dim TxtCommodityUnitPrice As New TableText
        With TxtCommodityUnitPrice
            .Name = "TxtCommodityUnitPrice" & TLPSaleOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            .Dock = DockStyle.None
            .Anchor = AnchorStyles.None
            .TextBox1.MaxLength = 6
            .TextBox1.Text = "0"
        End With
        Dim TxtCommodityTotalPrice As New TableText
        With TxtCommodityTotalPrice
            .Name = "TxtCommodityTotalPrice" & TLPSaleOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            .Dock = DockStyle.None
            .Anchor = AnchorStyles.None
            .TextBox1.MaxLength = 10
            .TextBox1.Text = "0"
        End With
        TLPSaleOrder.Controls.Add(myLabelItem, 0, TLPSaleOrder.RowCount - 1)
        TLPSaleOrder.Controls.Add(TxtSupplyID, 1, TLPSaleOrder.RowCount - 1)
        TLPSaleOrder.Controls.Add(TxtSupplyName, 2, TLPSaleOrder.RowCount - 1)
        TLPSaleOrder.Controls.Add(TxtCommodityID, 3, TLPSaleOrder.RowCount - 1)
        TLPSaleOrder.Controls.Add(TxtCommodityName, 4, TLPSaleOrder.RowCount - 1)
        TLPSaleOrder.Controls.Add(CMBCommodityClassificationType, 5, TLPSaleOrder.RowCount - 1)
        TLPSaleOrder.Controls.Add(CMBCommodityUnit, 6, TLPSaleOrder.RowCount - 1)
        TLPSaleOrder.Controls.Add(TxtCommodityQty, 7, TLPSaleOrder.RowCount - 1)
        TLPSaleOrder.Controls.Add(TxtCommodityUnitPrice, 8, TLPSaleOrder.RowCount - 1)
        TLPSaleOrder.Controls.Add(TxtCommodityTotalPrice, 9, TLPSaleOrder.RowCount - 1)
    End Sub
    Private Sub GetSupplyName()
        Dim mySelectSupply As String = "Select Supply_Co_Name from Supply where Supply_Tax_ID=@Supply_Tax_ID"
        Dim mySelectSupplyComm As New OleDbCommand(mySelectSupply, Connection)
        Connection.Open()
        If TxtCustomer_Tax_ID.TextBox1.Text = "" Or IsNumeric(TxtCustomer_Tax_ID.TextBox1.Text) = False Or Len(TxtCustomer_Tax_ID.TextBox1.Text) <> 8 Then
            MsgBox("客戶統一編號須是8碼數字", 0 + 48, "警告訊息")
        ElseIf TxtCustomer_Name.TextBox1.Text = "" Then
            MsgBox("客戶名稱不能空白", 0 + 48, "警告訊息")
        Else
            Dim TxtSupplyTaxID As New TableText
            TxtSupplyTaxID = TLPSaleOrder.GetControlFromPosition(1, TLPSaleOrder.RowCount - 1)
            Dim TxtSupplyName As New TableText
            TxtSupplyName = TLPSaleOrder.GetControlFromPosition(2, TLPSaleOrder.RowCount - 1)
            If TxtSupplyTaxID.TextBox1.Text = "" Or IsNumeric(TxtSupplyTaxID.TextBox1.Text) = False Or Len(TxtSupplyTaxID.TextBox1.Text) <> 8 Then
                MsgBox("供應商統一編號須是8碼數字", 0 + 48, "警告訊息")
            Else
                mySelectSupplyComm.Parameters.AddWithValue("@Supply_Tax_ID", TxtSupplyTaxID.TextBox1.Text)
                mySelectSupplyComm.ExecuteNonQuery()
                Dim myReader As OleDbDataReader = mySelectSupplyComm.ExecuteReader
                If myReader.HasRows Then
                    While myReader.Read
                        TxtSupplyName.TextBox1.Text = myReader.Item(0).ToString
                    End While
                    myReader.Close()
                Else
                    MsgBox("無此筆供應商資料，請新增", 0 + 48, "警告訊息")
                End If
            End If
        End If
        Connection.Close()
    End Sub
    Private Sub GetCommodityName()
        Dim mySelectCommodityID As String = "Select Commodity_ID from Commodity where Supply_Tax_ID=@Supply_Tax_ID"
        Dim mySelectCommodityIDComm As New OleDbCommand(mySelectCommodityID, Connection)
        Dim mySelectCommodityName As String = "Select * from Commodity Where Commodity_ID=@Commodity_ID"
        Dim mySelectCommodityNameComm As New OleDbCommand(mySelectCommodityName, Connection)
        Dim TxtSupplyTaxID As New TableText
        TxtSupplyTaxID = TLPSaleOrder.GetControlFromPosition(1, TLPSaleOrder.RowCount - 1)
        Dim TxtCommodityID As New TableText
        TxtCommodityID = TLPSaleOrder.GetControlFromPosition(3, TLPSaleOrder.RowCount - 1)
        Dim TxtCommodityName As New TableText
        TxtCommodityName = TLPSaleOrder.GetControlFromPosition(4, TLPSaleOrder.RowCount - 1)
        Dim CMBCommodityClassificationType As New ComboBox
        CMBCommodityClassificationType = TLPSaleOrder.GetControlFromPosition(5, TLPSaleOrder.RowCount - 1)
        Dim CMBCommodityUnit As New ComboBox
        CMBCommodityUnit = TLPSaleOrder.GetControlFromPosition(6, TLPSaleOrder.RowCount - 1)
        Dim i As Integer = TLPSaleOrder.RowCount - 1
        Connection.Open()
        If i > 0 Then
            If TxtSupplyTaxID.TextBox1.Text = "" Or IsNumeric(TxtSupplyTaxID.TextBox1.Text) = False Or Len(TxtSupplyTaxID.TextBox1.Text) <> 8 Then
                MsgBox("供應商統一編號須是8碼數字", 0 + 48, "警告訊息")
            ElseIf TxtCommodityID.TextBox1.Text = "" Or IsNumeric(TxtCommodityID.TextBox1.Text) = False Or Len(TxtCommodityID.TextBox1.Text) <> 13 Then
                MsgBox("商品編號須是13碼數字", 0 + 48, "警告訊息")
            Else
                mySelectCommodityIDComm.Parameters.AddWithValue("@Supply_Tax_ID", TxtSupplyTaxID.TextBox1.Text)
                mySelectCommodityIDComm.ExecuteNonQuery()
                Dim myReader As OleDbDataReader = mySelectCommodityIDComm.ExecuteReader
                If myReader.HasRows = False Then
                    MsgBox("此供應商無此商品", 0 + 48, "警告訊息")
                Else
                    mySelectCommodityNameComm.Parameters.AddWithValue("@Commodity_ID", TxtCommodityID.TextBox1.Text)
                    mySelectCommodityNameComm.ExecuteNonQuery()
                    Dim myReader1 As OleDbDataReader = mySelectCommodityNameComm.ExecuteReader
                    If myReader1.HasRows Then
                        While myReader1.Read
                            TxtCommodityName.TextBox1.Text = myReader1.Item(2).ToString
                            CMBCommodityClassificationType.Text = myReader1.Item(3).ToString
                            CMBCommodityUnit.Text = myReader1.Item(8).ToString
                        End While
                        myReader1.Close()
                        TxtCommodityName.Enabled = False
                        CMBCommodityClassificationType.Enabled = False
                        CMBCommodityUnit.Enabled = False
                    End If
                End If
            End If
        End If
        Connection.Close()
    End Sub
    Private Sub GetSumTotalPrice(sender As Object, e As EventArgs)
        If TLPSaleOrder.RowCount > 1 Then
            For i = 1 To TLPSaleOrder.RowCount - 1
                myTableText = TLPSaleOrder.GetControlFromPosition(7, i)
                myTableText1 = TLPSaleOrder.GetControlFromPosition(8, i)
                myTableText2 = TLPSaleOrder.GetControlFromPosition(9, i)
                Dim myNum As Integer = Convert.ToInt32(myTableText.TextBox1.Text) * Convert.ToDouble(myTableText1.TextBox1.Text)
                myTableText2.TextBox1.Text = Convert.ToString(myNum)
            Next
        End If
    End Sub
    Private Sub AddhandleData()
        myRowCount = TLPSaleOrder.RowCount
        Dim i As Integer = myRowCount - 1
        'myTableText.Name = "TxtSupplyName" & i
        myTableText = TLPSaleOrder.GetControlFromPosition(2, i)
        'myTableText2.Name = "TxtCommodityName" & i
        myTableText2 = TLPSaleOrder.GetControlFromPosition(4, i)
        'myTableText3.Name = "TxtCommodityTotalPrice" & i
        myTableText3 = TLPSaleOrder.GetControlFromPosition(9, i)
        AddHandler myTableText.Enter, AddressOf GetSupplyName
        AddHandler myTableText.MouseEnter, AddressOf GetSupplyName
        AddHandler myTableText.Click, AddressOf GetSupplyName
        AddHandler myTableText.MouseClick, AddressOf GetSupplyName
        AddHandler myTableText2.Enter, AddressOf GetCommodityName
        AddHandler myTableText2.MouseEnter, AddressOf GetCommodityName
        AddHandler myTableText2.Click, AddressOf GetCommodityName
        AddHandler myTableText2.MouseClick, AddressOf GetCommodityName
        AddHandler myTableText3.Enter, AddressOf GetSumTotalPrice
        AddHandler myTableText3.MouseEnter, AddressOf GetSumTotalPrice
        AddHandler myTableText3.Click, AddressOf GetSumTotalPrice
        AddHandler myTableText3.MouseClick, AddressOf GetSumTotalPrice
    End Sub

    Private Sub TxtCustomer_Name_Enter(sender As Object, e As EventArgs) Handles TxtCustomer_Name.Enter
        Connection.Open()
        Dim SelectCustomerStr As String = "Select Customer_Co_Name from Customer where Customer_Tax_ID=@Customer_Tax_ID"
        Dim SelectCustomerComm As New OleDbCommand(SelectCustomerStr, Connection)
        SelectCustomerComm.Parameters.AddWithValue("@Customer_Tax_ID", TxtCustomer_Tax_ID.TextBox1.Text)
        SelectCustomerComm.ExecuteNonQuery()
        If TxtCustomer_Tax_ID.TextBox1.Text = "" Or IsNumeric(TxtCustomer_Tax_ID.TextBox1.Text) = False Or Len(TxtCustomer_Tax_ID.TextBox1.Text) <> 8 Then
            MsgBox("客戶統一編號須是8碼數字", 0 + 48, "警告訊息")
        Else
            Dim myReader As OleDbDataReader = SelectCustomerComm.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    TxtCustomer_Name.TextBox1.Text = myReader.Item(0).ToString
                End While
            Else
                MsgBox("無此供應商或是供應商統一編號輸錯", 0 + 16, "警告訊息")
            End If
            myReader.Close()
        End If
        Connection.Close()
    End Sub

    Private Sub BtnSummation_Click(sender As Object, e As EventArgs) Handles BtnSummation.Click
        Dim i As Integer
        Dim mySum As Integer = 0
        Dim myTableInt As Integer
        If TLPSaleOrder.RowCount > 1 Then
            For i = 1 To TLPSaleOrder.RowCount - 1
                myTableText = TLPSaleOrder.GetControlFromPosition(9, i)
                myTableInt = Convert.ToInt32(myTableText.TextBox1.Text)
                mySum += myTableInt
            Next
            Dim myTotalSum = mySum
            MsgBox(myTotalSum)
            lblToTalSum.Text = String.Format("${0:0,0}", myTotalSum)
        End If
    End Sub

    Private Sub LblAddRow_Click(sender As Object, e As EventArgs) Handles LblAddRow.Click
        If TLPSaleOrder.RowCount = 1 Then
            TLPSaleOrder.RowCount += 1
            TLPSaleOrder.Height += 80
            Dim i As Double = TLPSaleOrder.Height / TLPSaleOrder.RowCount
            TLPSaleOrder.RowStyles.Add(New RowStyle(sizeType:=SizeType.Absolute, i))
            For Each style As RowStyle In TLPSaleOrder.RowStyles
                style.SizeType = SizeType.Absolute
                style.Height = i
            Next
            'SaleOrderData()
            Dim myLabelItem As New Label
            With myLabelItem
                .Name = "myLabelItem" & TLPSaleOrder.RowCount - 1
                .TextAlign = 32
                .Font = New Font("標楷體", 20)
                .Dock = DockStyle.None
                .Text = TLPSaleOrder.RowCount - 1
                .Anchor = AnchorStyles.None
            End With
            Dim TxtSupplyID As New TableText
            With TxtSupplyID
                .Name = "TxtSupplyID" & TLPSaleOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                '.Dock = DockStyle.Fill
                .TextBox1.MaxLength = 8
                .Anchor = AnchorStyles.None
            End With
            Dim TxtSupplyName As New TableText
            With TxtSupplyName
                .Name = "TxtSupplyName" & TLPSaleOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                '.Dock = DockStyle.Fill
                '.TextBox1.MaxLength = 20
                .Anchor = AnchorStyles.None
            End With
            Dim TxtCommodityID As New TableText
            With TxtCommodityID
                .Name = "TxtCommodityID" & TLPSaleOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                '.Dock = DockStyle.Fill
                .TextBox1.MaxLength = 13
                .Anchor = AnchorStyles.None
            End With
            Dim TxtCommodityName As New TableText
            With TxtCommodityName
                .Name = "TxtCommodityName" & TLPSaleOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                '.Dock = DockStyle.Fill
                '.TextBox1.MaxLength = 20
                .Anchor = AnchorStyles.None
            End With
            Connection.Open()
            Dim mySelectStr As String = "Select Commodity_Classification_Type from Commodity_Classification"
            Dim myComm As New OleDbCommand(mySelectStr, Connection)
            myComm.ExecuteNonQuery()
            Dim CMBCommodityClassificationType As New ComboBox
            Dim myReader As OleDbDataReader = myComm.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    CMBCommodityClassificationType.Items.Add(myReader.Item(0).ToString)
                End While
                myReader.Close()
            End If
            With CMBCommodityClassificationType
                .Name = "CMBCommodityClassificationType" & TLPSaleOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                .BackColor = Color.FromArgb(94, 148, 255)
                .ForeColor = Color.White
                ' .Dock = DockStyle.Fill
                .Text = "請選擇"
            End With
            Connection.Close()
            Dim CMBCommodityUnit As New ComboBox
            With CMBCommodityUnit
                .Name = "CMBCommodityUnit" & TLPSaleOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                .BackColor = Color.FromArgb(94, 148, 255)
                .ForeColor = Color.White
                '.Dock = DockStyle.Fill
                '.Anchor = AnchorStyles.None
                .Text = "請選擇"
            End With
            CMBCommodityUnit.Items.Add("包")
            CMBCommodityUnit.Items.Add("袋")
            CMBCommodityUnit.Items.Add("箱")
            CMBCommodityUnit.Items.Add("盒")
            CMBCommodityUnit.Items.Add("瓶")
            CMBCommodityUnit.Items.Add("罐")
            CMBCommodityUnit.Items.Add("台")
            CMBCommodityUnit.Items.Add("張")
            CMBCommodityUnit.Items.Add("座")
            CMBCommodityUnit.Items.Add("本")
            Dim TxtCommodityQty As New TableText
            With TxtCommodityQty
                Name = "TxtCommodityQty" & TLPSaleOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                .Dock = DockStyle.None
                .Anchor = AnchorStyles.None
                .TextBox1.MaxLength = 6
                '.TextBox1.TextAlign = HorizontalAlignment.Center
                .TextBox1.Text = "0"
            End With
            Dim TxtCommodityUnitPrice As New TableText
            With TxtCommodityUnitPrice
                .Name = "TxtCommodityUnitPrice" & TLPSaleOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                .Dock = DockStyle.None
                .Anchor = AnchorStyles.None
                .TextBox1.MaxLength = 6
                .TextBox1.Text = "0"
            End With
            Dim TxtCommodityTotalPrice As New TableText
            With TxtCommodityTotalPrice
                .Name = "TxtCommodityTotalPrice" & TLPSaleOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                .Dock = DockStyle.None
                .Anchor = AnchorStyles.None
                .TextBox1.MaxLength = 10
                .TextBox1.Text = "0"
            End With
            TLPSaleOrder.Controls.Add(myLabelItem, 0, TLPSaleOrder.RowCount - 1)
            TLPSaleOrder.Controls.Add(TxtSupplyID, 1, TLPSaleOrder.RowCount - 1)
            TLPSaleOrder.Controls.Add(TxtSupplyName, 2, TLPSaleOrder.RowCount - 1)
            TLPSaleOrder.Controls.Add(TxtCommodityID, 3, TLPSaleOrder.RowCount - 1)
            TLPSaleOrder.Controls.Add(TxtCommodityName, 4, TLPSaleOrder.RowCount - 1)
            TLPSaleOrder.Controls.Add(CMBCommodityClassificationType, 5, TLPSaleOrder.RowCount - 1)
            TLPSaleOrder.Controls.Add(CMBCommodityUnit, 6, TLPSaleOrder.RowCount - 1)
            TLPSaleOrder.Controls.Add(TxtCommodityQty, 7, TLPSaleOrder.RowCount - 1)
            TLPSaleOrder.Controls.Add(TxtCommodityUnitPrice, 8, TLPSaleOrder.RowCount - 1)
            TLPSaleOrder.Controls.Add(TxtCommodityTotalPrice, 9, TLPSaleOrder.RowCount - 1)
            AddhandleData()
        ElseIf TLPSaleOrder.RowCount >= 2 Then
            Dim TxtSupplyID As New TableText
            TxtSupplyID = TLPSaleOrder.GetControlFromPosition(1, TLPSaleOrder.RowCount - 1)
            Dim TxtCommodityID As New TableText
            TxtCommodityID = TLPSaleOrder.GetControlFromPosition(3, TLPSaleOrder.RowCount - 1)
            If TxtSupplyID.TextBox1.Text = "" Or IsNumeric(TxtSupplyID.TextBox1.Text) = False Or Len(TxtSupplyID.TextBox1.Text) <> 8 Then
                MsgBox("供應商統一編號須是8碼數字", 0 + 48, "警告訊息")
            ElseIf TxtCommodityID.TextBox1.Text = "" Or IsNumeric(TxtCommodityID.TextBox1.Text) = False Or Len(TxtCommodityID.TextBox1.Text) <> 13 Then
                MsgBox("商品編號須是13碼數字", 0 + 48, "警告訊息")
            Else
                If TLPSaleOrder.RowCount < 11 Then
                    TLPSaleOrder.RowCount += 1
                    TLPSaleOrder.Height += 80
                    Dim i As Double = TLPSaleOrder.Height / TLPSaleOrder.RowCount
                    TLPSaleOrder.RowStyles.Add(New RowStyle(sizeType:=SizeType.Absolute, i))
                    For Each style As RowStyle In TLPSaleOrder.RowStyles
                        style.SizeType = SizeType.Absolute
                        style.Height = i
                    Next
                    Dim myLabelItem As New Label
                    With myLabelItem
                        .Name = "myLabelItem" & TLPSaleOrder.RowCount - 1
                        .TextAlign = 32
                        .Font = New Font("標楷體", 20)
                        .Dock = DockStyle.None
                        .Text = TLPSaleOrder.RowCount - 1
                        .Anchor = AnchorStyles.None
                    End With

                    With TxtSupplyID
                        .Name = "TxtSupplyID" & TLPSaleOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        '.Dock = DockStyle.Fill
                        .TextBox1.MaxLength = 8
                        .Anchor = AnchorStyles.None
                    End With
                    Dim TxtSupplyName As New TableText
                    With TxtSupplyName
                        .Name = "TxtSupplyName" & TLPSaleOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        '.Dock = DockStyle.Fill
                        '.TextBox1.MaxLength = 20
                        .Anchor = AnchorStyles.None
                    End With

                    With TxtCommodityID
                        .Name = "TxtCommodityID" & TLPSaleOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        '.Dock = DockStyle.Fill
                        .TextBox1.MaxLength = 13
                        .Anchor = AnchorStyles.None
                    End With
                    Dim TxtCommodityName As New TableText
                    With TxtCommodityName
                        .Name = "TxtCommodityName" & TLPSaleOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        '.Dock = DockStyle.Fill
                        '.TextBox1.MaxLength = 20
                        .Anchor = AnchorStyles.None
                    End With
                    Connection.Open()
                    Dim mySelectStr As String = "Select Commodity_Classification_Type from Commodity_Classification"
                    Dim myComm As New OleDbCommand(mySelectStr, Connection)
                    myComm.ExecuteNonQuery()
                    Dim CMBCommodityClassificationType As New ComboBox
                    Dim myReader As OleDbDataReader = myComm.ExecuteReader
                    If myReader.HasRows Then
                        While myReader.Read
                            CMBCommodityClassificationType.Items.Add(myReader.Item(0).ToString)
                        End While
                        myReader.Close()
                    End If
                    With CMBCommodityClassificationType
                        .Name = "CMBCommodityClassificationType" & TLPSaleOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        .BackColor = Color.FromArgb(94, 148, 255)
                        .ForeColor = Color.White
                        ' .Dock = DockStyle.Fill
                        .Text = "請選擇"
                    End With
                    Connection.Close()
                    Dim CMBCommodityUnit As New ComboBox
                    With CMBCommodityUnit
                        .Name = "CMBCommodityUnit" & TLPSaleOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        .BackColor = Color.FromArgb(94, 148, 255)
                        .ForeColor = Color.White
                        '.Dock = DockStyle.Fill
                        '.Anchor = AnchorStyles.None
                        .Text = "請選擇"
                    End With
                    CMBCommodityUnit.Items.Add("包")
                    CMBCommodityUnit.Items.Add("袋")
                    CMBCommodityUnit.Items.Add("箱")
                    CMBCommodityUnit.Items.Add("盒")
                    CMBCommodityUnit.Items.Add("瓶")
                    CMBCommodityUnit.Items.Add("罐")
                    CMBCommodityUnit.Items.Add("台")
                    CMBCommodityUnit.Items.Add("張")
                    CMBCommodityUnit.Items.Add("座")
                    CMBCommodityUnit.Items.Add("本")
                    Dim TxtCommodityQty As New TableText
                    With TxtCommodityQty
                        Name = "TxtCommodityQty" & TLPSaleOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        .Dock = DockStyle.None
                        .Anchor = AnchorStyles.None
                        .TextBox1.MaxLength = 6
                        '.TextBox1.TextAlign = HorizontalAlignment.Center
                        .TextBox1.Text = "0"
                    End With
                    Dim TxtCommodityUnitPrice As New TableText
                    With TxtCommodityUnitPrice
                        .Name = "TxtCommodityUnitPrice" & TLPSaleOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        .Dock = DockStyle.None
                        .Anchor = AnchorStyles.None
                        .TextBox1.MaxLength = 6
                        .TextBox1.Text = "0"
                    End With
                    Dim TxtCommodityTotalPrice As New TableText
                    With TxtCommodityTotalPrice
                        .Name = "TxtCommodityTotalPrice" & TLPSaleOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        .Dock = DockStyle.None
                        .Anchor = AnchorStyles.None
                        .TextBox1.MaxLength = 10
                        .TextBox1.Text = "0"
                    End With
                    Dim TXtSupplyIDX As New TableText
                    Dim TxtCommodityIDX As New TableText
                    TLPSaleOrder.Controls.Add(myLabelItem, 0, TLPSaleOrder.RowCount - 1)
                    TLPSaleOrder.Controls.Add(TXtSupplyIDX, 1, TLPSaleOrder.RowCount - 1)
                    TLPSaleOrder.Controls.Add(TxtSupplyName, 2, TLPSaleOrder.RowCount - 1)
                    TLPSaleOrder.Controls.Add(TxtCommodityIDX, 3, TLPSaleOrder.RowCount - 1)
                    TLPSaleOrder.Controls.Add(TxtCommodityName, 4, TLPSaleOrder.RowCount - 1)
                    TLPSaleOrder.Controls.Add(CMBCommodityClassificationType, 5, TLPSaleOrder.RowCount - 1)
                    TLPSaleOrder.Controls.Add(CMBCommodityUnit, 6, TLPSaleOrder.RowCount - 1)
                    TLPSaleOrder.Controls.Add(TxtCommodityQty, 7, TLPSaleOrder.RowCount - 1)
                    TLPSaleOrder.Controls.Add(TxtCommodityUnitPrice, 8, TLPSaleOrder.RowCount - 1)
                    TLPSaleOrder.Controls.Add(TxtCommodityTotalPrice, 9, TLPSaleOrder.RowCount - 1)
                    AddhandleData()
                Else
                    MsgBox("只能增加10筆", 0 + 48, "警告訊息")
                End If
            End If

        End If
    End Sub

    Private Sub LblDelRow_Click(sender As Object, e As EventArgs) Handles LblDelRow.Click
        Dim RowCount As Integer = TLPSaleOrder.RowCount
        If RowCount > 1 Then
            DelRow()
        End If
    End Sub
    Private Sub DelRow()
        Try
            If TLPSaleOrder.RowCount > 1 Then
                Dim j As Double = TLPSaleOrder.Height / TLPSaleOrder.RowCount
                Dim i As Integer = TLPSaleOrder.RowCount - 1
                TLPSaleOrder.RowCount -= 1
                TLPSaleOrder.Height -= 80
                For Each style As RowStyle In TLPSaleOrder.RowStyles
                    style.SizeType = SizeType.Absolute
                    style.Height = j
                Next

                Dim myLabelItem As New Label
                myLabelItem.Name = "myLabelItem" & i
                myLabelItem = TLPSaleOrder.GetControlFromPosition(0, i)
                Dim TxtSupplyTaxID As New TableText
                TxtSupplyTaxID.Name = "TxtSupplyTaxID" & i
                TxtSupplyTaxID = TLPSaleOrder.GetControlFromPosition(1, i)
                Dim TxtSupplyName As New TableText
                TxtSupplyName.Name = "TxtSupplyName" & i
                TxtSupplyName = TLPSaleOrder.GetControlFromPosition(2, i)
                Dim TxtCommodityID As New TableText
                TxtCommodityID.Name = "TxtCommodityID" & i
                TxtCommodityID = TLPSaleOrder.GetControlFromPosition(3, i)
                Dim TxtCommodityName As New TableText
                TxtCommodityName.Name = "TxtCommodityName" & i
                TxtCommodityName = TLPSaleOrder.GetControlFromPosition(4, i)
                Dim CMBCommodityClassificationType As New ComboBox
                CMBCommodityClassificationType.Name = "CMBCommodityClassificationType" & i
                CMBCommodityClassificationType = TLPSaleOrder.GetControlFromPosition(5, i)
                Dim CMBCommodityUnit As New ComboBox
                CMBCommodityUnit = TLPSaleOrder.GetControlFromPosition(6, i)
                CMBCommodityUnit.Name = "CMBCommodityUnit" & i
                Dim TxtCommodityQty As New TableText
                TxtCommodityQty = TLPSaleOrder.GetControlFromPosition(7, i)
                TxtCommodityQty.Name = "TxtCommodityQty" & i
                Dim TxtCommodityUnitPrice As New TableText
                TxtCommodityUnitPrice.Name = "TxtCommodityUnitPrice" & i
                TxtCommodityUnitPrice = TLPSaleOrder.GetControlFromPosition(8, i)
                Dim TxtCommodityTotalPrice As New TableText
                TxtCommodityTotalPrice = TLPSaleOrder.GetControlFromPosition(9, i)
                TxtCommodityTotalPrice.Name = "TxtCommodityTotalPrice" & i
                For i = 1 To TLPSaleOrder.RowCount
                    TLPSaleOrder.Controls.Remove(myLabelItem)
                    TLPSaleOrder.Controls.Remove(TxtSupplyTaxID)
                    TLPSaleOrder.Controls.Remove(TxtSupplyName)
                    TLPSaleOrder.Controls.Remove(TxtCommodityID)
                    TLPSaleOrder.Controls.Remove(TxtCommodityName)
                    TLPSaleOrder.Controls.Remove(CMBCommodityClassificationType)
                    TLPSaleOrder.Controls.Remove(CMBCommodityUnit)
                    TLPSaleOrder.Controls.Remove(TxtCommodityQty)
                    TLPSaleOrder.Controls.Remove(TxtCommodityUnitPrice)
                    TLPSaleOrder.Controls.Remove(TxtCommodityTotalPrice)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim InsertIntoStr As String = "Insert Into SaleOrder(ItemNo,SaleOrder_ID,SaleOrder_Date,Customer_Tax_ID," &
            "Customer_Name,Supply_Tax_ID,Supply_Name,Commodity_ID,Commodity_Name," &
            "Commodity_Classification_Type,Commodity_Unit,Commodity_Qty,Commodity_Price,CommodityTotalPrice)" &
            " Values(@ItemNo,@SaleOrder_ID,@SaleOrder_Date,@Customer_Tax_ID,@Customer_Name,@Supply_Tax_ID" &
            ",@Supply_Name,@Commodity_ID,@Commodity_Name,@Commodity_Classification_Type,@Commodity_Unit," &
            "@Commodity_Qty,@Commodity_Price,@CommodityTotalPrice)"
        Dim StrDate As String = Convert.ToString(DateTimePicker1.Value)
        Connection.Open()
        If TxtCustomer_Tax_ID.TextBox1.Text = "" Or IsNumeric(TxtCustomer_Tax_ID.TextBox1.Text) = False Or Len(TxtCustomer_Tax_ID.TextBox1.Text) <> 8 Then
            MsgBox("客戶統一編號須是8碼數字", 0 + 16, "警告訊息")
        ElseIf TxtCustomer_Name.TextBox1.Text = "" Then
            MsgBox("客戶不能空白", 0 + 16, "警告訊息")
        Else
            Dim MaxItemNoStr As String
            Dim SelectStr As String = "Select MAX(ItemNo) From SaleOrder "
            Dim SelectComm As New OleDbCommand(SelectStr, Connection)
            SelectComm.ExecuteNonQuery()
            Dim SelectReader As OleDbDataReader = SelectComm.ExecuteReader
            If SelectReader.HasRows Then
                While SelectReader.Read
                    MaxItemNoStr = SelectReader.Item(0).ToString
                    For i = 1 To TLPSaleOrder.RowCount - 1
                        Dim MaxItemNoInt As Integer
                        MaxItemNoInt = CInt(MaxItemNoStr) + i
                        Dim InsertIntoComm As New OleDbCommand(InsertIntoStr, Connection)
                        Dim myLabelItem As New Label
                        myLabelItem.Name = "myLabelItem" & i
                        myLabelItem = TLPSaleOrder.GetControlFromPosition(0, i)
                        Dim TxtSupplyTaxID As New TableText
                        TxtSupplyTaxID.Name = "TxtSupplyTaxID" & i
                        TxtSupplyTaxID = TLPSaleOrder.GetControlFromPosition(1, i)
                        Dim TxtSupplyName As New TableText
                        TxtSupplyName.Name = "TxtSupplyName" & i
                        TxtSupplyName = TLPSaleOrder.GetControlFromPosition(2, i)
                        Dim TxtCommodityID As New TableText
                        TxtCommodityID.Name = "TxtCommodityID" & i
                        TxtCommodityID = TLPSaleOrder.GetControlFromPosition(3, i)
                        Dim TxtCommodityName As New TableText
                        TxtCommodityName.Name = "TxtCommodityName" & i
                        TxtCommodityName = TLPSaleOrder.GetControlFromPosition(4, i)
                        Dim CMBCommodityClassificationType As New ComboBox
                        CMBCommodityClassificationType.Name = "CMBCommodityClassificationType" & i
                        CMBCommodityClassificationType = TLPSaleOrder.GetControlFromPosition(5, i)
                        Dim CMBCommodityUnit As New ComboBox
                        CMBCommodityUnit = TLPSaleOrder.GetControlFromPosition(6, i)
                        CMBCommodityUnit.Name = "CMBCommodityUnit" & i
                        Dim TxtCommodityQty As New TableText
                        TxtCommodityQty = TLPSaleOrder.GetControlFromPosition(7, i)
                        TxtCommodityQty.Name = "TxtCommodityQty" & i
                        Dim TxtCommodityUnitPrice As New TableText
                        TxtCommodityUnitPrice.Name = "TxtCommodityUnitPrice" & i
                        TxtCommodityUnitPrice = TLPSaleOrder.GetControlFromPosition(8, i)
                        Dim TxtCommodityTotalPrice As New TableText
                        TxtCommodityTotalPrice = TLPSaleOrder.GetControlFromPosition(9, i)
                        TxtCommodityTotalPrice.Name = "TxtCommodityTotalPrice" & i
                        If TxtSupplyTaxID.TextBox1.Text = "" Or IsNumeric(TxtSupplyTaxID.TextBox1.Text) = False Or Len(TxtSupplyTaxID.TextBox1.Text) <> 8 Then
                            MsgBox("供應商統一編號須是8碼數字", 0 + 48, "警告訊息")
                        ElseIf TxtSupplyName.TextBox1.Text = "" Then
                            MsgBox("供應商不能空白", 0 + 48, "警告訊息")
                        ElseIf TxtCommodityID.TextBox1.Text = "" Or IsNumeric(TxtCommodityID.TextBox1.Text) = False Or Len(TxtCommodityID.TextBox1.Text) <> 13 Then
                            MsgBox("商品編號須是13碼數字", 0 + 48, "警告訊息")
                        ElseIf TxtCommodityName.TextBox1.Text = "" Then
                            MsgBox("商品不能空白且", 0 + 48, "警告訊息")
                        Else
                            InsertIntoComm.Parameters.AddWithValue("@ItemNo", MaxItemNoInt)
                            InsertIntoComm.Parameters.AddWithValue("@SaleOrder_ID", TxtSaleOrder_ID.TextBox1.Text)
                            InsertIntoComm.Parameters.AddWithValue("@SaleOrder_Date", StrDate)
                            InsertIntoComm.Parameters.AddWithValue("@Customer_Tax_ID", TxtCustomer_Tax_ID.TextBox1.Text)
                            InsertIntoComm.Parameters.AddWithValue("@Customer_Name", TxtCustomer_Name.TextBox1.Text)
                            InsertIntoComm.Parameters.AddWithValue("@Supply_Tax_ID", TxtSupplyTaxID.TextBox1.Text)
                            InsertIntoComm.Parameters.AddWithValue("@Supply_Name", TxtSupplyName.TextBox1.Text)
                            InsertIntoComm.Parameters.AddWithValue("@Commodity_ID", TxtCommodityID.TextBox1.Text)
                            InsertIntoComm.Parameters.AddWithValue("@Commodity_Name", TxtCommodityName.TextBox1.Text)
                            InsertIntoComm.Parameters.AddWithValue("@Commodity_Classification_Type", CMBCommodityClassificationType.Text)
                            InsertIntoComm.Parameters.AddWithValue("@Commodity_Unit", CMBCommodityUnit.Text)
                            InsertIntoComm.Parameters.AddWithValue("@Commodity_Qty", TxtCommodityQty.TextBox1.Text)
                            InsertIntoComm.Parameters.AddWithValue("@Commodity_Price", TxtCommodityUnitPrice.TextBox1.Text)
                            InsertIntoComm.Parameters.AddWithValue("@CommodityTotalPrice", TxtCommodityTotalPrice.TextBox1.Text)
                            InsertIntoComm.ExecuteNonQuery()
                        End If
                    Next
                End While
            End If
        End If
        Connection.Close()
        Dim mySelectStr1 As String = "Select SaleOrder_ID from SaleOrder "
        Dim myDT As DataTable = GetData(mySelectStr1)
        Dim mySelectRowsStr = "Select SaleOrder_ID from SaleOrder Order By SaleOrder_ID ASC"
        Dim mySaleorderID As String
        Dim StrYear As String = Now.Year
        Dim StrMonth As String = Now.Month
        If Len(StrMonth) = 1 Then
            StrMonth = "00" & StrMonth
        ElseIf Len(StrMonth) = 2 Then
            StrMonth = "0" & StrMonth
        End If
        Dim StrNumber As Integer
        Connection.Open()
        If myDT.Rows.Count = 0 Then
            mySaleorderID = StrYear & StrMonth & "00001"
            TxtSaleOrder_ID.TextBox1.Text = mySaleorderID
        ElseIf myDT.Rows.Count = 1 Then
            Dim mySelectOnlyOneComm As New OleDbCommand(mySelectStr1, Connection)
            mySelectOnlyOneComm.ExecuteNonQuery()
            Dim mySelectOnlyOneReader As OleDbDataReader = mySelectOnlyOneComm.ExecuteReader
            While mySelectOnlyOneReader.Read
                mySaleorderID = mySelectOnlyOneReader.Item(0).ToString
                If Convert.ToInt32(Strings.Left(mySaleorderID, 4)) = Now.Year Then
                    Dim Str1 As String = Strings.Left(mySaleorderID, 7)
                    Dim Str2 As String = Strings.Right(Str1, 3)
                    If Convert.ToInt32(Str2) = Now.Month Then
                        StrNumber = Convert.ToInt32(mySaleorderID, 5)
                        StrNumber += 1
                        If Strings.Len(StrNumber) = 5 Then
                            TxtSaleOrder_ID.TextBox1.Text = Str1 & StrNumber
                        ElseIf Strings.Len(StrNumber) = 4 Then
                            TxtSaleOrder_ID.TextBox1.Text = Str1 & "0" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 3 Then
                            TxtSaleOrder_ID.TextBox1.Text = Str1 & "00" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 2 Then
                            TxtSaleOrder_ID.TextBox1.Text = Str1 & "000" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 1 Then
                            TxtSaleOrder_ID.TextBox1.Text = Str1 & "0000" & StrNumber
                        End If
                    ElseIf Convert.ToInt32(Str2) < Now.Month Then
                        TxtSaleOrder_ID.TextBox1.Text = StrYear & StrMonth & "00001"
                    End If
                ElseIf Convert.ToInt32(Strings.Left(mySaleorderID, 4)) < Now.Year Then
                    TxtSaleOrder_ID.TextBox1.Text = StrYear & StrMonth & "00001"
                End If
            End While
            mySelectOnlyOneReader.Close()
        ElseIf myDT.Rows.Count > 1 Then
            Connection.Open()
            Dim mySelectComm As New OleDbCommand(mySelectRowsStr, Connection)
            mySelectComm.ExecuteNonQuery()
            Dim myReader1 As OleDbDataReader = mySelectComm.ExecuteReader
            If myReader1.HasRows Then
                While myReader1.Read
                    mySaleorderID = myReader1.Item(0).ToString
                    If Convert.ToInt32(Strings.Left(mySaleorderID, 4)) = Now.Year Then
                        Dim Str1 As String = Strings.Left(mySaleorderID, 7)
                        Dim Str2 As String = Strings.Right(Str1, 3)
                        If Convert.ToInt32(Str2) = Now.Month Then
                            StrNumber = Convert.ToInt32(mySaleorderID, 5)
                            StrNumber += 1
                            If Strings.Len(StrNumber) = 5 Then
                                TxtSaleOrder_ID.TextBox1.Text = Str1 & StrNumber
                            ElseIf Strings.Len(StrNumber) = 4 Then
                                TxtSaleOrder_ID.TextBox1.Text = Str1 & "0" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 3 Then
                                TxtSaleOrder_ID.TextBox1.Text = Str1 & "00" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 2 Then
                                TxtSaleOrder_ID.TextBox1.Text = Str1 & "000" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 1 Then
                                TxtSaleOrder_ID.TextBox1.Text = Str1 & "0000" & StrNumber
                            End If
                        ElseIf Convert.ToInt32(Str2) < Now.Month Then
                            TxtSaleOrder_ID.TextBox1.Text = StrYear & StrMonth & "00001"
                        End If
                    ElseIf Convert.ToInt32(Strings.Left(mySaleorderID, 4)) < Now.Year Then
                        TxtSaleOrder_ID.TextBox1.Text = StrYear & StrMonth & "00001"
                    End If
                End While
                myReader1.Close()
            End If
            Connection.Close()
        End If
        TxtCustomer_Tax_ID.TextBox1.Text = ""
        TxtCustomer_Name.TextBox1.Text = ""
        Dim k As Integer
        For k = 1 To TLPSaleOrder.RowCount - 1
            DelRow()
        Next
    End Sub

    Private Sub BtnPrint_SaleOrder_Click(sender As Object, e As EventArgs) Handles BtnPrint_SaleOrder.Click
        Dim myForm As New frmRSS_Access_SaleOrder_Report
        myForm.TopMost = True
        myForm.Show()
    End Sub
End Class