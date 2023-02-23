Imports System.Data.OleDb
Imports RSS_Access.Access_Connection

Public Class frmRSS_Access_PurchaseOrder
    Private Property myTableText As New TableText
    Private Property myTableText1 As New TableText
    Private Property myTableText2 As New TableText
    Private Property myTableText3 As New TableText
    Private Property myRowCount As Integer
    Private Sub LblAddRow_Click(sender As Object, e As EventArgs) Handles LblAddRow.Click
        Dim myTxtPanel_Commodity_ID As New TableText
        If TLPPurchaseOrder.RowCount = 1 Then
            TLPPurchaseOrder.RowCount += 1
            TLPPurchaseOrder.Height += 80
            Dim i As Double = TLPPurchaseOrder.Height / TLPPurchaseOrder.RowCount
            TLPPurchaseOrder.RowStyles.Add(New RowStyle(sizeType:=SizeType.Absolute, i))
            For Each style As RowStyle In TLPPurchaseOrder.RowStyles
                style.SizeType = SizeType.Absolute
                style.Height = i
            Next
            Dim myLabelItem As New Label
            With myLabelItem
                .Name = "myLabelItem" & TLPPurchaseOrder.RowCount - 1
                .TextAlign = 32
                .Font = New Font("標楷體", 20)
                .Dock = DockStyle.None
                .Text = TLPPurchaseOrder.RowCount - 1
                .Anchor = AnchorStyles.None
            End With

            With myTxtPanel_Commodity_ID
                .Name = "TxtPanel_Commodity_ID" & TLPPurchaseOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                '.Dock = DockStyle.Fill
                .TextBox1.MaxLength = 15
                .Anchor = AnchorStyles.None
            End With
            Dim myTxtPanel_Commodity_Name As New TableText
            With myTxtPanel_Commodity_Name
                .Name = "TxtPanel_Commodity_Name" & TLPPurchaseOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                '.Dock = DockStyle.Fill
                .TextBox1.MaxLength = 20
                .Anchor = AnchorStyles.None
            End With
            Connection.Open()
            Dim mySelectStr As String = "Select Commodity_Classification_Type from Commodity_Classification"
            Dim myComm As New OleDbCommand(mySelectStr, Connection)
            myComm.ExecuteNonQuery()
            Dim myCOMB_Commodity_Type As New ComboBox
            Dim myReader As OleDbDataReader = myComm.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    myCOMB_Commodity_Type.Items.Add(myReader.Item(0).ToString)
                End While
                myReader.Close()
            End If
            With myCOMB_Commodity_Type
                .Name = "COMB_Commodity_Type" & TLPPurchaseOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                .BackColor = Color.FromArgb(94, 148, 255)
                .ForeColor = Color.White
                ' .Dock = DockStyle.Fill
                .Text = "請選擇"
            End With
            Connection.Close()
            Dim TxtPanel_Commodity_Qty As New TableText
            With TxtPanel_Commodity_Qty
                .Name = "TxtPanel_Commodity_Qty" & TLPPurchaseOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                .Dock = DockStyle.None
                .Anchor = AnchorStyles.None
                .TextBox1.MaxLength = 6
                '.TextBox1.TextAlign = HorizontalAlignment.Center
                .TextBox1.Text = "0"
            End With
            Dim TxtPanel_Commodity_SafeQty As New TableText
            With TxtPanel_Commodity_SafeQty
                .Name = "TxtPanel_Commodity_SafeQty" & TLPPurchaseOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                .Dock = DockStyle.None
                .Anchor = AnchorStyles.None
                .TextBox1.MaxLength = 6
                .TextBox1.Text = "0"
            End With
            Dim CMB_Commodity_Unit As New ComboBox
            With CMB_Commodity_Unit
                .Name = "CMB_Commodity_Unit" & TLPPurchaseOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                .BackColor = Color.FromArgb(94, 148, 255)
                .ForeColor = Color.White
                '.Dock = DockStyle.Fill
                '.Anchor = AnchorStyles.None
                .Text = "請選擇"
            End With
            CMB_Commodity_Unit.Items.Add("包")
            CMB_Commodity_Unit.Items.Add("袋")
            CMB_Commodity_Unit.Items.Add("箱")
            CMB_Commodity_Unit.Items.Add("盒")
            CMB_Commodity_Unit.Items.Add("瓶")
            CMB_Commodity_Unit.Items.Add("罐")
            CMB_Commodity_Unit.Items.Add("台")
            CMB_Commodity_Unit.Items.Add("張")
            CMB_Commodity_Unit.Items.Add("座")
            CMB_Commodity_Unit.Items.Add("本")
            Dim TxtPanel_Commodity_Stock_Qty As New TableText
            With TxtPanel_Commodity_Stock_Qty
                .Name = "TxtPanel_Commodity_Stock_Qty" & TLPPurchaseOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                .Dock = DockStyle.None
                .Anchor = AnchorStyles.None
                .TextBox1.MaxLength = 6
                ' .TextBox1.TextAlign = HorizontalAlignment.Center
                .TextBox1.Text = "0"
            End With
            Dim TxtPanel_Commodity_UnitPrice As New TableText
            With TxtPanel_Commodity_UnitPrice
                .Name = "TxtPanel_Commodity_UnitPrice" & TLPPurchaseOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                .Dock = DockStyle.None
                .Anchor = AnchorStyles.None
                .TextBox1.MaxLength = 6
                .TextBox1.Text = "0"
            End With
            Dim TxtPanel_Commodity_TotalPrice As New TableText
            With TxtPanel_Commodity_TotalPrice
                .Name = "TxtPanel_Commodity_TotalPrice" & TLPPurchaseOrder.RowCount - 1
                .Font = New Font("標楷體", 20)
                .Dock = DockStyle.None
                .Anchor = AnchorStyles.None
                .TextBox1.MaxLength = 10
                .TextBox1.Text = "0"
            End With
            TLPPurchaseOrder.Controls.Add(myLabelItem, 0, TLPPurchaseOrder.RowCount - 1)
            TLPPurchaseOrder.Controls.Add(myTxtPanel_Commodity_ID, 1, TLPPurchaseOrder.RowCount - 1)
            TLPPurchaseOrder.Controls.Add(myTxtPanel_Commodity_Name, 2, TLPPurchaseOrder.RowCount - 1)
            TLPPurchaseOrder.Controls.Add(myCOMB_Commodity_Type, 3, TLPPurchaseOrder.RowCount - 1)
            TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_Qty, 4, TLPPurchaseOrder.RowCount - 1)
            TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_SafeQty, 5, TLPPurchaseOrder.RowCount - 1)
            TLPPurchaseOrder.Controls.Add(CMB_Commodity_Unit, 6, TLPPurchaseOrder.RowCount - 1)
            TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_Stock_Qty, 7, TLPPurchaseOrder.RowCount - 1)
            TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_UnitPrice, 8, TLPPurchaseOrder.RowCount - 1)
            TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_TotalPrice, 9, TLPPurchaseOrder.RowCount - 1)
            AddhandleData()
        ElseIf TLPPurchaseOrder.RowCount >= 2 Then
            myTxtPanel_Commodity_ID = TLPPurchaseOrder.GetControlFromPosition(1, TLPPurchaseOrder.RowCount - 1)
            If myTxtPanel_Commodity_ID.TextBox1.Text <> "" Then
                If TLPPurchaseOrder.RowCount < 11 Then
                    TLPPurchaseOrder.RowCount += 1
                    TLPPurchaseOrder.Height += 80
                    Dim i As Double = TLPPurchaseOrder.Height / TLPPurchaseOrder.RowCount
                    TLPPurchaseOrder.RowStyles.Add(New RowStyle(sizeType:=SizeType.Absolute, i))
                    For Each style As RowStyle In TLPPurchaseOrder.RowStyles
                        style.SizeType = SizeType.Absolute
                        style.Height = i
                    Next
                    Dim myLabelItem As New Label
                    With myLabelItem
                        .Name = "myLabelItem" & TLPPurchaseOrder.RowCount - 1
                        .TextAlign = 32
                        .Font = New Font("標楷體", 20)
                        .Dock = DockStyle.None
                        .Text = TLPPurchaseOrder.RowCount - 1
                        .Anchor = AnchorStyles.None
                    End With
                    With myTxtPanel_Commodity_ID
                        .Name = "TxtPanel_Commodity_ID" & TLPPurchaseOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        '.Dock = DockStyle.Fill
                        .TextBox1.MaxLength = 15
                        .Anchor = AnchorStyles.None
                    End With
                    Dim myTxtPanel_Commodity_Name As New TableText
                    With myTxtPanel_Commodity_Name
                        .Name = "TxtPanel_Commodity_Name" & TLPPurchaseOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        '.Dock = DockStyle.Fill
                        .TextBox1.MaxLength = 20
                        .Anchor = AnchorStyles.None
                    End With
                    Connection.Open()

                    Dim mySelectStr As String = "Select Commodity_Classification_Type from Commodity_Classification"
                    Dim myComm As New OleDbCommand(mySelectStr, Connection)
                    myComm.ExecuteNonQuery()
                    Dim myCOMB_Commodity_Type As New ComboBox
                    Dim myReader As OleDbDataReader = myComm.ExecuteReader
                    If myReader.HasRows Then
                        While myReader.Read
                            myCOMB_Commodity_Type.Items.Add(myReader.Item(0).ToString)
                        End While
                        myReader.Close()
                    End If
                    With myCOMB_Commodity_Type
                        .Name = "COMB_Commodity_Type" & TLPPurchaseOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        .BackColor = Color.FromArgb(94, 148, 255)
                        .ForeColor = Color.White
                        ' .Dock = DockStyle.Fill
                        .Text = "請選擇"
                    End With
                    Connection.Close()
                    Dim TxtPanel_Commodity_Qty As New TableText
                    With TxtPanel_Commodity_Qty
                        .Name = "TxtPanel_Commodity_Qty" & TLPPurchaseOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        .Dock = DockStyle.None
                        .Anchor = AnchorStyles.None
                        .TextBox1.MaxLength = 6
                        '.TextBox1.TextAlign = HorizontalAlignment.Center
                        .TextBox1.Text = "0"
                    End With
                    Dim TxtPanel_Commodity_SafeQty As New TableText
                    With TxtPanel_Commodity_SafeQty
                        .Name = "TxtPanel_Commodity_SafeQty" & TLPPurchaseOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        .Dock = DockStyle.None
                        .Anchor = AnchorStyles.None
                        .TextBox1.MaxLength = 6
                        .TextBox1.Text = "0"
                    End With
                    Dim CMB_Commodity_Unit As New ComboBox
                    With CMB_Commodity_Unit
                        .Name = "CMB_Commodity_Unit" & TLPPurchaseOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        .BackColor = Color.FromArgb(94, 148, 255)
                        .ForeColor = Color.White
                        '.Dock = DockStyle.Fill
                        '.Anchor = AnchorStyles.None
                        .Text = "請選擇"
                    End With
                    CMB_Commodity_Unit.Items.Add("包")
                    CMB_Commodity_Unit.Items.Add("袋")
                    CMB_Commodity_Unit.Items.Add("箱")
                    CMB_Commodity_Unit.Items.Add("盒")
                    CMB_Commodity_Unit.Items.Add("瓶")
                    CMB_Commodity_Unit.Items.Add("罐")
                    CMB_Commodity_Unit.Items.Add("台")
                    CMB_Commodity_Unit.Items.Add("張")
                    CMB_Commodity_Unit.Items.Add("座")
                    CMB_Commodity_Unit.Items.Add("本")
                    Dim TxtPanel_Commodity_Stock_Qty As New TableText
                    With TxtPanel_Commodity_Stock_Qty
                        .Name = "TxtPanel_Commodity_Stock_Qty" & TLPPurchaseOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        .Dock = DockStyle.None
                        .Anchor = AnchorStyles.None
                        .TextBox1.MaxLength = 6
                        ' .TextBox1.TextAlign = HorizontalAlignment.Center
                        .TextBox1.Text = "0"
                    End With
                    Dim TxtPanel_Commodity_UnitPrice As New TableText
                    With TxtPanel_Commodity_UnitPrice
                        .Name = "TxtPanel_Commodity_UnitPrice" & TLPPurchaseOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        .Dock = DockStyle.None
                        .Anchor = AnchorStyles.None
                        .TextBox1.MaxLength = 6
                        .TextBox1.Text = "0"
                    End With
                    Dim TxtPanel_Commodity_TotalPrice As New TableText
                    With TxtPanel_Commodity_TotalPrice
                        .Name = "TxtPanel_Commodity_TotalPrice" & TLPPurchaseOrder.RowCount - 1
                        .Font = New Font("標楷體", 20)
                        .Dock = DockStyle.None
                        .Anchor = AnchorStyles.None
                        .TextBox1.MaxLength = 10
                        .TextBox1.Text = "0"
                    End With
                    Dim myTxtPanel_Commodity_IDX As New TableText
                    TLPPurchaseOrder.Controls.Add(myLabelItem, 0, TLPPurchaseOrder.RowCount - 1)
                    TLPPurchaseOrder.Controls.Add(myTxtPanel_Commodity_IDX, 1, TLPPurchaseOrder.RowCount - 1)
                    TLPPurchaseOrder.Controls.Add(myTxtPanel_Commodity_Name, 2, TLPPurchaseOrder.RowCount - 1)
                    TLPPurchaseOrder.Controls.Add(myCOMB_Commodity_Type, 3, TLPPurchaseOrder.RowCount - 1)
                    TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_Qty, 4, TLPPurchaseOrder.RowCount - 1)
                    TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_SafeQty, 5, TLPPurchaseOrder.RowCount - 1)
                    TLPPurchaseOrder.Controls.Add(CMB_Commodity_Unit, 6, TLPPurchaseOrder.RowCount - 1)
                    TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_Stock_Qty, 7, TLPPurchaseOrder.RowCount - 1)
                    TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_UnitPrice, 8, TLPPurchaseOrder.RowCount - 1)
                    TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_TotalPrice, 9, TLPPurchaseOrder.RowCount - 1)
                    AddhandleData()
                Else
                    MsgBox("只能增加10筆", 0 + 48, "警告訊息")
                End If
            Else
                MsgBox("商品編號不能空白", 0 + 48, "警告訊息")
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = Now
        'Me.Refresh()
        'myRowCount = TLPPurchaseOrder.RowCount
    End Sub
    Private Sub DateTimePicker1_Click(sender As Object, e As EventArgs)
        Timer1.Stop()
    End Sub

    Private Sub DateTimePicker1_Enter(sender As Object, e As EventArgs)
        Timer1.Stop()
        DateTimePicker1.Show()
    End Sub

    Private Sub DateTimePicker1_MouseLeave(sender As Object, e As EventArgs)
        Timer1.Start()
    End Sub

    Private Sub DateTimePicker1_MouseEnter(sender As Object, e As EventArgs)
        Timer1.Stop()
    End Sub
    Private Sub GetSumTotalPrice(sender As Object, e As EventArgs)
        If TLPPurchaseOrder.RowCount > 1 Then
            For i = 1 To TLPPurchaseOrder.RowCount - 1
                myTableText = TLPPurchaseOrder.GetControlFromPosition(4, i)
                myTableText1 = TLPPurchaseOrder.GetControlFromPosition(8, i)
                myTableText2 = TLPPurchaseOrder.GetControlFromPosition(9, i)
                Dim myNum As Integer = Convert.ToInt32(myTableText.TextBox1.Text) * Convert.ToDouble(myTableText1.TextBox1.Text)
                myTableText2.TextBox1.Text = Convert.ToString(myNum)
            Next
        End If
    End Sub

    Private Sub BtnSummation_Click(sender As Object, e As EventArgs) Handles BtnSummation.Click
        Dim i As Integer
        Dim mySum As Integer = 0
        Dim myTableInt As Integer
        If TLPPurchaseOrder.RowCount > 1 Then
            For i = 1 To TLPPurchaseOrder.RowCount - 1
                myTableText = TLPPurchaseOrder.GetControlFromPosition(9, i)
                myTableInt = Convert.ToInt32(myTableText.TextBox1.Text)
                mySum += myTableInt
            Next
            Dim myTotalSum = mySum
            MsgBox(myTotalSum)
            lblToTalSum.Text = String.Format("${0:0,0}", myTotalSum)
        End If
    End Sub

    Private Sub TxtSupply_Name_Enter(sender As Object, e As EventArgs) Handles TxtSupply_Name.Enter
        Connection.Open()
        Dim mySelectStr As String = "Select Supply_Co_Name From Supply Where Supply_Tax_ID=@Supply_Tax_ID"
        Dim myComm As New OleDbCommand(mySelectStr, Connection)
        myComm.Parameters.AddWithValue("@Supply_Tax_ID", TxtSupply_Tax_ID.TextBox1.Text)
        Dim mySupplyTaxID As String = TxtSupply_Tax_ID.TextBox1.Text
        myComm.ExecuteNonQuery()
        If mySupplyTaxID = "" Then
            MsgBox("供應商統一編號不能空白", 0 + 48, "警告訊息")
            TxtSupply_Name.Focus()
        Else
            Dim MyReader As OleDbDataReader = myComm.ExecuteReader
            If MyReader.HasRows Then
                While MyReader.Read
                    TxtSupply_Name.TextBox1.Text = MyReader.Item(0).ToString
                End While
                MyReader.Close()
            End If
        End If
        Connection.Close()
    End Sub
    Private Sub GetCommodityName()
        Connection.Open()
        Dim SupplyTaxIDStr As String = TxtSupply_Tax_ID.TextBox1.Text
        Dim i = TLPPurchaseOrder.RowCount - 1
        Dim MySelectStr As String = "Select * from Commodity Where Commodity_ID=@Commodity_ID AND Supply_Tax_ID=@Supply_Tax_ID"

        If TxtSupply_Tax_ID.TextBox1.Text = "" Then
            MsgBox("供應商編號不能空白", 0 + 48, "警告訊息")
            TxtSupply_Tax_ID.Focus()
        ElseIf TxtSupply_Name.TextBox1.Text = "" Then
            MsgBox("供應商名稱不能空白", 0 + 48, "警告訊息")
            TxtSupply_Name.Focus()
        Else
            If i > 0 Then
                myTableText1.Name = "TxtPanel_Commodity_ID" & i
                myTableText1 = TLPPurchaseOrder.GetControlFromPosition(1, i)
                Dim myCommodityIDStr = myTableText1.TextBox1.Text
                myTableText2.Name = "TxtPanel_Commodity_Name" & i
                myTableText2 = TLPPurchaseOrder.GetControlFromPosition(2, i)
                Dim myCOMB_Commodity_Type As New ComboBox
                myCOMB_Commodity_Type.Name = "COMB_Commodity_Type" & i
                myCOMB_Commodity_Type = TLPPurchaseOrder.GetControlFromPosition(3, i)
                Dim TxtPanel_Commodity_SafeQty As New TableText
                TxtPanel_Commodity_SafeQty.Name = "TxtPanel_Commodity_SafeQty" & i
                TxtPanel_Commodity_SafeQty = TLPPurchaseOrder.GetControlFromPosition(5, i)
                Dim CMB_Commodity_Unit As New ComboBox
                CMB_Commodity_Unit.Name = "CMB_Commodity_Unit" & i
                CMB_Commodity_Unit = TLPPurchaseOrder.GetControlFromPosition(6, i)
                Dim TxtPanel_Commodity_Stock_Qty As New TableText
                TxtPanel_Commodity_Stock_Qty.Name = "TxtPanel_Commodity_Stock_Qty" & i
                TxtPanel_Commodity_Stock_Qty = TLPPurchaseOrder.GetControlFromPosition(7, i)
                If myCommodityIDStr = "" Then
                    myTableText1.Focus()
                    Connection.Close()
                    Exit Sub
                Else
                    If IsNumeric(myCommodityIDStr) = False Then
                        myTableText1.Focus()
                        Connection.Close()
                        Exit Sub
                    Else
                        Dim myComm As New OleDbCommand(MySelectStr, Connection)
                        myComm.Parameters.AddWithValue("@Commodity_ID", myCommodityIDStr)
                        myComm.Parameters.AddWithValue("@Supply_Tax_ID", SupplyTaxIDStr)
                        myComm.ExecuteNonQuery()
                        Dim myReader As OleDbDataReader = myComm.ExecuteReader
                        If myReader.HasRows Then
                            While myReader.Read
                                myTableText2.TextBox1.Text = myReader.Item(2).ToString
                                myTableText2.TextBox1.ReadOnly = True
                                myCOMB_Commodity_Type.Text = myReader.Item(3).ToString
                                myCOMB_Commodity_Type.Enabled = False
                                TxtPanel_Commodity_SafeQty.TextBox1.Text = myReader.Item(7).ToString
                                TxtPanel_Commodity_SafeQty.TextBox1.ReadOnly = True
                                CMB_Commodity_Unit.Text = myReader.Item(8).ToString
                                CMB_Commodity_Unit.Enabled = False
                                TxtPanel_Commodity_Stock_Qty.TextBox1.Text = myReader.Item(10)
                                TxtPanel_Commodity_Stock_Qty.TextBox1.ReadOnly = True
                            End While
                            myReader.Close()
                        Else
                            MsgBox("此供應商無此商品編號", 0 + 48, "警告訊息")
                            myReader.Close()
                        End If
                    End If
                End If
            End If
        End If
        Connection.Close()
    End Sub
    Private Sub frmRSS_Access_PurchaseOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        TLPPurchaseOrder.RowCount += 1
        TLPPurchaseOrder.Height += 80
        Dim i As Double = TLPPurchaseOrder.Height / TLPPurchaseOrder.RowCount
        TLPPurchaseOrder.RowStyles.Add(New RowStyle(sizeType:=SizeType.Absolute, i))
        For Each style As RowStyle In TLPPurchaseOrder.RowStyles
            style.SizeType = SizeType.Absolute
            style.Height = i
        Next
        PruchaseOrderGetData()
        AddhandleData()
        Dim mySelectStr1 As String = "Select PurchaseOrder_ID from PurchaseOrder "
        Dim myDT As DataTable = GetData(mySelectStr1)
        Dim mySelectRowsStr = "Select PurchaseOrder_ID from PurchaseOrder Order By PurchaseOrder_ID ASC"
        Dim myPruchaseOrderID As String
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
            myPruchaseOrderID = StrYear & StrMonth & "00001"
            TxtPurchaseOrderID.TextBox1.Text = myPruchaseOrderID
        ElseIf myDT.Rows.Count = 1 Then
            Dim mySelectOnlyOneComm As New OleDbCommand(mySelectStr1, Connection)
            mySelectOnlyOneComm.ExecuteNonQuery()
            Dim mySelectOnlyOneReader As OleDbDataReader = mySelectOnlyOneComm.ExecuteReader
            While mySelectOnlyOneReader.Read
                myPruchaseOrderID = mySelectOnlyOneReader.Item(0).ToString
                If Convert.ToInt32(Strings.Left(myPruchaseOrderID, 4)) = Now.Year Then
                    Dim Str1 As String = Strings.Left(myPruchaseOrderID, 7)
                    Dim Str2 As String = Strings.Right(Str1, 3)
                    If Convert.ToInt32(Str2) = Now.Month Then
                        StrNumber = Convert.ToInt32(myPruchaseOrderID, 5)
                        StrNumber += 1
                        If Strings.Len(StrNumber) = 5 Then
                            TxtPurchaseOrderID.TextBox1.Text = Str1 & StrNumber
                        ElseIf Strings.Len(StrNumber) = 4 Then
                            TxtPurchaseOrderID.TextBox1.Text = Str1 & "0" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 3 Then
                            TxtPurchaseOrderID.TextBox1.Text = Str1 & "00" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 2 Then
                            TxtPurchaseOrderID.TextBox1.Text = Str1 & "000" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 1 Then
                            TxtPurchaseOrderID.TextBox1.Text = Str1 & "0000" & StrNumber
                        End If
                    ElseIf Convert.ToInt32(Str2) < Now.Month Then
                        TxtPurchaseOrderID.TextBox1.Text = StrYear & StrMonth & "00001"
                    End If
                ElseIf Convert.ToInt32(Strings.Left(myPruchaseOrderID, 4)) < Now.Year Then
                    TxtPurchaseOrderID.TextBox1.Text = StrYear & StrMonth & "00001"
                End If
            End While
            mySelectOnlyOneReader.Close()
        ElseIf myDT.Rows.Count > 1 Then
            Dim mySelectComm As New OleDbCommand(mySelectRowsStr, Connection)
            mySelectComm.ExecuteNonQuery()
            Dim myReader1 As OleDbDataReader = mySelectComm.ExecuteReader
            If myReader1.HasRows Then
                While myReader1.Read
                    myPruchaseOrderID = myReader1.Item(0).ToString
                    If Convert.ToInt32(Strings.Left(myPruchaseOrderID, 4)) = Now.Year Then
                        Dim Str1 As String = Strings.Left(myPruchaseOrderID, 7)
                        Dim Str2 As String = Strings.Right(Str1, 3)
                        If Convert.ToInt32(Str2) = Now.Month Then
                            StrNumber = Convert.ToInt32(myPruchaseOrderID, 5)
                            StrNumber += 1
                            If Strings.Len(StrNumber) = 5 Then
                                TxtPurchaseOrderID.TextBox1.Text = Str1 & StrNumber
                            ElseIf Strings.Len(StrNumber) = 4 Then
                                TxtPurchaseOrderID.TextBox1.Text = Str1 & "0" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 3 Then
                                TxtPurchaseOrderID.TextBox1.Text = Str1 & "00" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 2 Then
                                TxtPurchaseOrderID.TextBox1.Text = Str1 & "000" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 1 Then
                                TxtPurchaseOrderID.TextBox1.Text = Str1 & "0000" & StrNumber
                            End If
                        ElseIf Convert.ToInt32(Str2) < Now.Month Then
                            TxtPurchaseOrderID.TextBox1.Text = StrYear & StrMonth & "00001"
                        End If
                    ElseIf Convert.ToInt32(Strings.Left(myPruchaseOrderID, 4)) < Now.Year Then
                        TxtPurchaseOrderID.TextBox1.Text = StrYear & StrMonth & "00001"
                    End If
                End While
                myReader1.Close()
            End If
        End If
        Connection.Close()
    End Sub

    Private Sub LblDelRow_Click(sender As Object, e As EventArgs) Handles LblDelRow.Click
        Dim RowCount As Integer = TLPPurchaseOrder.RowCount
        If RowCount > 2 Then
            DelRow()
        End If

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim mySelectStr As String = "Select * from PurchaseOrder Where PuchaseOrder_ID=@PurchaseOrder_ID"
        Dim mySelectComm As New OleDbCommand(mySelectStr, Connection)
        Dim StrDate As String = Convert.ToString(Now.Date)
        Connection.Open()
        If TxtSupply_Tax_ID.TextBox1.Text = "" Or IsNumeric(TxtSupply_Tax_ID.TextBox1.Text) = False Then
            MsgBox("供應商統一編號不能空白且是數字", 0 + 48, "警告訊息")
        ElseIf TxtSupply_Name.TextBox1.Text = "" Then
            MsgBox("供應商名稱不能空白", 0 + 48, "警告訊息")
        Else
            Try
                If TLPPurchaseOrder.RowCount > 1 Then
                    For i = 1 To TLPPurchaseOrder.RowCount - 1
                        Dim myInsertStr = "Insert Into PurchaseOrder(PurchaseOrder_ID,PurchaseOrder_Date," &
                            "Supply_Tax_ID,Supply_Name,Commodity_ID,Commodity_Name," &
                            "Commodity_Classification_Type,Commodity_Qty," &
                            "Commodity_Unit,Commodity_UnitCost,Commodity_TotalPrice) " &
                        " Values(@PurchaseOrder_ID," &
                        "@PurchaseOrder_Date,@Supply_Tax_ID,@Supply_Name," &
                        "@Commodity_ID,@Commodity_Name," &
                        "@Commodity_Classification_Type,@Commodity_Qty,@Commodity_Unit," &
                        "@Commodity_UnitCost,@Commodity_TotalPrice)"
                        Dim myInsertComm As New OleDbCommand(myInsertStr, Connection)
                        Dim myLabelItem As New Label
                        myLabelItem.Name = "myLabelItem" & i
                        myLabelItem = TLPPurchaseOrder.GetControlFromPosition(0, i)
                        Dim myTxtPanel_Commodity_ID As New TableText
                        myTxtPanel_Commodity_ID.Name = "TxtPanel_Commodity_ID" & i
                        myTxtPanel_Commodity_ID = TLPPurchaseOrder.GetControlFromPosition(1, i)
                        Dim myTxtPanel_Commodity_Name As New TableText
                        myTxtPanel_Commodity_Name.Name = "TxtPanel_Commodity_Name" & i
                        myTxtPanel_Commodity_Name = TLPPurchaseOrder.GetControlFromPosition(2, i)
                        Dim myCOMB_Commodity_Type As New ComboBox
                        myCOMB_Commodity_Type.Name = "COMB_Commodity_Type" & i
                        myCOMB_Commodity_Type = TLPPurchaseOrder.GetControlFromPosition(3, i)
                        Dim TxtPanel_Commodity_Qty As New TableText
                        TxtPanel_Commodity_Qty.Name = "TxtPanel_Commodity_Qty" & i
                        TxtPanel_Commodity_Qty = TLPPurchaseOrder.GetControlFromPosition(4, i)
                        Dim TxtPanel_Commodity_SafeQty As New TableText
                        TxtPanel_Commodity_SafeQty.Name = "TxtPanel_Commodity_SafeQty" & i
                        TxtPanel_Commodity_SafeQty = TLPPurchaseOrder.GetControlFromPosition(5, i)
                        Dim CMB_Commodity_Unit As New ComboBox
                        CMB_Commodity_Unit.Name = "CMB_Commodity_Unit" & i
                        CMB_Commodity_Unit = TLPPurchaseOrder.GetControlFromPosition(6, i)
                        Dim TxtPanel_Commodity_Stock_Qty As New TableText
                        TxtPanel_Commodity_Stock_Qty.Name = "TxtPanel_Commodity_Stock_Qty" & i
                        TxtPanel_Commodity_Stock_Qty = TLPPurchaseOrder.GetControlFromPosition(7, i)
                        Dim TxtPanel_Commodity_UnitPrice As New TableText
                        TxtPanel_Commodity_UnitPrice.Name = "TxtPanel_Commodity_UnitPrice" & i
                        TxtPanel_Commodity_UnitPrice = TLPPurchaseOrder.GetControlFromPosition(8, i)
                        Dim TxtPanel_Commodity_TotalPrice As New TableText
                        TxtPanel_Commodity_TotalPrice.Name = "TxtPanel_Commodity_TotalPrice" & i
                        TxtPanel_Commodity_TotalPrice = TLPPurchaseOrder.GetControlFromPosition(9, i)
                        If myTxtPanel_Commodity_ID.TextBox1.Text = "" Or IsNumeric(myTxtPanel_Commodity_ID.TextBox1.Text) = False Then
                            MsgBox("商品編號不能空白且是數字", 0 + 48, "警告訊息")
                        ElseIf myTxtPanel_Commodity_Name.TextBox1.Text = "" Then
                            MsgBox("商品名稱不能空白", 0 + 48, "警告訊息")
                        Else
                            myInsertComm.Parameters.AddWithValue("@PurchaseOrder_ID", TxtPurchaseOrderID.TextBox1.Text)
                            myInsertComm.Parameters.AddWithValue("@PurchaseOrder_Date", StrDate)
                            myInsertComm.Parameters.AddWithValue("@Supply_Tax_ID", TxtSupply_Tax_ID.TextBox1.Text)
                            myInsertComm.Parameters.AddWithValue("@Supply_Name", TxtSupply_Name.TextBox1.Text)
                            myInsertComm.Parameters.AddWithValue("@Commodity_ID", myTxtPanel_Commodity_ID.TextBox1.Text)
                            myInsertComm.Parameters.AddWithValue("@Commodity_Name", myTxtPanel_Commodity_Name.TextBox1.Text)
                            myInsertComm.Parameters.AddWithValue("@Commodity_Classification_Type", myCOMB_Commodity_Type.Text)
                            myInsertComm.Parameters.AddWithValue("@Commodity_Qty", TxtPanel_Commodity_Qty.TextBox1.Text)
                            myInsertComm.Parameters.AddWithValue("@Commodity_Unit", CMB_Commodity_Unit.Text)
                            myInsertComm.Parameters.AddWithValue("@Commodity_UnitCost", TxtPanel_Commodity_UnitPrice.TextBox1.Text)
                            myInsertComm.Parameters.AddWithValue("@Commodity_TotalPrice", TxtPanel_Commodity_TotalPrice.TextBox1.Text)
                            myInsertComm.ExecuteNonQuery()
                        End If
                    Next
                    MsgBox("新增資料成功", 0 + 48, "通知訊息")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Connection.Close()
        Dim mySelectStr1 As String = "Select PurchaseOrder_ID from PurchaseOrder "
        Dim myDT As DataTable = GetData(mySelectStr1)
        Dim mySelectRowsStr = "Select PurchaseOrder_ID from PurchaseOrder Order By PurchaseOrder_ID ASC"
        Dim myPruchaseOrderID As String
        Dim StrYear As String = Now.Date.Year
        Dim StrMonth As String = Now.Date.Month
        If Len(StrMonth) = 1 Then
            StrMonth = "00" & StrMonth
        ElseIf Len(StrMonth) = 2 Then
            StrMonth = "0" & StrMonth
        End If

        Dim StrNumber As Integer

        Connection.Open()

        If myDT.Rows.Count = 0 Then
            myPruchaseOrderID = StrYear & StrMonth & "00001"
            TxtPurchaseOrderID.TextBox1.Text = myPruchaseOrderID
        ElseIf myDT.Rows.Count = 1 Then
            Dim mySelectOnlyOneComm As New OleDbCommand(mySelectStr1, Connection)
            mySelectOnlyOneComm.ExecuteNonQuery()
            Dim mySelectOnlyOneReader As OleDbDataReader = mySelectOnlyOneComm.ExecuteReader
            While mySelectOnlyOneReader.Read
                myPruchaseOrderID = mySelectOnlyOneReader.Item(0).ToString
                If Convert.ToInt32(Strings.Left(myPruchaseOrderID, 4)) = Now.Year Then
                    Dim Str1 As String = Strings.Left(myPruchaseOrderID, 7)
                    Dim Str2 As String = Strings.Right(Str1, 3)
                    If Convert.ToInt32(Str2) = Now.Month Then
                        StrNumber = Convert.ToInt32(myPruchaseOrderID, 5)
                        StrNumber += 1
                        If Strings.Len(StrNumber) = 5 Then
                            TxtPurchaseOrderID.TextBox1.Text = Str1 & StrNumber
                        ElseIf Strings.Len(StrNumber) = 4 Then
                            TxtPurchaseOrderID.TextBox1.Text = Str1 & "0" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 3 Then
                            TxtPurchaseOrderID.TextBox1.Text = Str1 & "00" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 2 Then
                            TxtPurchaseOrderID.TextBox1.Text = Str1 & "000" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 1 Then
                            TxtPurchaseOrderID.TextBox1.Text = Str1 & "0000" & StrNumber
                        End If
                    ElseIf Convert.ToInt32(Str2) < Now.Month Then
                        TxtPurchaseOrderID.TextBox1.Text = StrYear & StrMonth & "00001"
                    End If
                ElseIf Convert.ToInt32(Strings.Left(myPruchaseOrderID, 4)) < Now.Year Then
                    TxtPurchaseOrderID.TextBox1.Text = StrYear & StrMonth & "00001"
                End If
            End While
            mySelectOnlyOneReader.Close()
        ElseIf myDT.Rows.Count > 1 Then
            Dim mySelectComm1 As New OleDbCommand(mySelectRowsStr, Connection)
            mySelectComm1.ExecuteNonQuery()
            Dim myReader1 As OleDbDataReader = mySelectComm1.ExecuteReader
            If myReader1.HasRows Then
                While myReader1.Read
                    myPruchaseOrderID = myReader1.Item(0).ToString
                    If Convert.ToInt32(Strings.Left(myPruchaseOrderID, 4)) = Now.Year Then
                        Dim Str1 As String = Strings.Left(myPruchaseOrderID, 7)
                        Dim Str2 As String = Strings.Right(Str1, 3)
                        If Convert.ToInt32(Str2) = Now.Month Then
                            StrNumber = Convert.ToInt32(myPruchaseOrderID, 5)
                            StrNumber += 1
                            If Strings.Len(StrNumber) = 5 Then
                                TxtPurchaseOrderID.TextBox1.Text = Str1 & StrNumber
                            ElseIf Strings.Len(StrNumber) = 4 Then
                                TxtPurchaseOrderID.TextBox1.Text = Str1 & "0" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 3 Then
                                TxtPurchaseOrderID.TextBox1.Text = Str1 & "00" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 2 Then
                                TxtPurchaseOrderID.TextBox1.Text = Str1 & "000" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 1 Then
                                TxtPurchaseOrderID.TextBox1.Text = Str1 & "0000" & StrNumber
                            End If
                        ElseIf Convert.ToInt32(Str2) < Now.Month Then
                            TxtPurchaseOrderID.TextBox1.Text = StrYear & StrMonth & "00001"
                        End If
                    ElseIf Convert.ToInt32(Strings.Left(myPruchaseOrderID, 4)) < Now.Year Then
                        TxtPurchaseOrderID.TextBox1.Text = StrYear & StrMonth & "00001"
                    End If
                End While
                myReader1.Close()
            End If
        End If
        Connection.Close()
        TxtSupply_Tax_ID.TextBox1.Text = ""
        TxtSupply_Name.TextBox1.Text = ""

        Dim k As Integer
        For k = 1 To TLPPurchaseOrder.RowCount - 1
            DelRow()
        Next

    End Sub
    Private Sub DelRow()
        Try
            If TLPPurchaseOrder.RowCount > 1 Then
                Dim j As Double = TLPPurchaseOrder.Height / TLPPurchaseOrder.RowCount
                Dim i As Integer = TLPPurchaseOrder.RowCount - 1
                TLPPurchaseOrder.RowCount -= 1
                TLPPurchaseOrder.Height -= 80
                For Each style As RowStyle In TLPPurchaseOrder.RowStyles
                    style.SizeType = SizeType.Absolute
                    style.Height = i
                Next
                Dim myLabelItem As New Label
                myLabelItem.Name = "myLabelItem" & i
                myLabelItem = TLPPurchaseOrder.GetControlFromPosition(0, i)
                Dim myTxtPanel_Commodity_ID As New TableText
                myTxtPanel_Commodity_ID.Name = "TxtPanel_Commodity_ID" & i
                myTxtPanel_Commodity_ID = TLPPurchaseOrder.GetControlFromPosition(1, i)
                Dim myTxtPanel_Commodity_Name As New TableText
                myTxtPanel_Commodity_Name.Name = "TxtPanel_Commodity_Name" & i
                myTxtPanel_Commodity_Name = TLPPurchaseOrder.GetControlFromPosition(2, i)
                Dim myCOMB_Commodity_Type As New ComboBox
                myCOMB_Commodity_Type.Name = "COMB_Commodity_Type" & i
                myCOMB_Commodity_Type = TLPPurchaseOrder.GetControlFromPosition(3, i)
                Dim TxtPanel_Commodity_Qty As New TableText
                TxtPanel_Commodity_Qty.Name = "TxtPanel_Commodity_Qty" & i
                TxtPanel_Commodity_Qty = TLPPurchaseOrder.GetControlFromPosition(4, i)
                Dim TxtPanel_Commodity_SafeQty As New TableText
                TxtPanel_Commodity_SafeQty.Name = "TxtPanel_Commodity_SafeQty" & i
                TxtPanel_Commodity_SafeQty = TLPPurchaseOrder.GetControlFromPosition(5, i)
                Dim CMB_Commodity_Unit As New ComboBox
                CMB_Commodity_Unit.Name = "CMB_Commodity_Unit" & i
                CMB_Commodity_Unit = TLPPurchaseOrder.GetControlFromPosition(6, i)
                Dim TxtPanel_Commodity_Stock_Qty As New TableText
                TxtPanel_Commodity_Stock_Qty.Name = "TxtPanel_Commodity_Stock_Qty" & i
                TxtPanel_Commodity_Stock_Qty = TLPPurchaseOrder.GetControlFromPosition(7, i)
                Dim TxtPanel_Commodity_UnitPrice As New TableText
                TxtPanel_Commodity_UnitPrice.Name = "TxtPanel_Commodity_UnitPrice" & i
                TxtPanel_Commodity_UnitPrice = TLPPurchaseOrder.GetControlFromPosition(8, i)
                Dim TxtPanel_Commodity_TotalPrice As New TableText
                TxtPanel_Commodity_TotalPrice.Name = "TxtPanel_Commodity_TotalPrice" & i
                TxtPanel_Commodity_TotalPrice = TLPPurchaseOrder.GetControlFromPosition(9, i)
                For i = 1 To TLPPurchaseOrder.RowCount - 1
                    TLPPurchaseOrder.Controls.Remove(myLabelItem)
                    TLPPurchaseOrder.Controls.Remove(myTxtPanel_Commodity_ID)
                    TLPPurchaseOrder.Controls.Remove(myTxtPanel_Commodity_Name)
                    TLPPurchaseOrder.Controls.Remove(myCOMB_Commodity_Type)
                    TLPPurchaseOrder.Controls.Remove(TxtPanel_Commodity_Qty)
                    TLPPurchaseOrder.Controls.Remove(TxtPanel_Commodity_SafeQty)
                    TLPPurchaseOrder.Controls.Remove(CMB_Commodity_Unit)
                    TLPPurchaseOrder.Controls.Remove(TxtPanel_Commodity_Stock_Qty)
                    TLPPurchaseOrder.Controls.Remove(TxtPanel_Commodity_UnitPrice)
                    TLPPurchaseOrder.Controls.Remove(TxtPanel_Commodity_TotalPrice)
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PruchaseOrderGetData()
        Dim myLabelItem As New Label
        With myLabelItem
            .Name = "myLabelItem" & TLPPurchaseOrder.RowCount - 1
            .TextAlign = 32
            .Font = New Font("標楷體", 20)
            .Dock = DockStyle.None
            .Text = TLPPurchaseOrder.RowCount - 1
            .Anchor = AnchorStyles.None
        End With
        Dim myTxtPanel_Commodity_ID As New TableText
        With myTxtPanel_Commodity_ID
            .Name = "TxtPanel_Commodity_ID" & TLPPurchaseOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            '.Dock = DockStyle.Fill
            .TextBox1.MaxLength = 15
            .Anchor = AnchorStyles.None
        End With
        Dim myTxtPanel_Commodity_Name As New TableText
        With myTxtPanel_Commodity_Name
            .Name = "TxtPanel_Commodity_Name" & TLPPurchaseOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            '.Dock = DockStyle.Fill
            .TextBox1.MaxLength = 20
            .Anchor = AnchorStyles.None
        End With
        Connection.Open()
        Dim mySelectStr As String = "Select Commodity_Classification_Type from Commodity_Classification"
        Dim myComm As New OleDbCommand(mySelectStr, Connection)
        myComm.ExecuteNonQuery()
        Dim myCOMB_Commodity_Type As New ComboBox
        Dim myReader As OleDbDataReader = myComm.ExecuteReader
        If myReader.HasRows Then
            While myReader.Read
                myCOMB_Commodity_Type.Items.Add(myReader.Item(0).ToString)
            End While
            myReader.Close()
        End If
        With myCOMB_Commodity_Type
            .Name = "COMB_Commodity_Type" & TLPPurchaseOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            .BackColor = Color.FromArgb(94, 148, 255)
            .ForeColor = Color.White
            ' .Dock = DockStyle.Fill
            .Text = "請選擇"
        End With
        Connection.Close()
        Dim TxtPanel_Commodity_Qty As New TableText
        With TxtPanel_Commodity_Qty
            .Name = "TxtPanel_Commodity_Qty" & TLPPurchaseOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            .Dock = DockStyle.None
            .Anchor = AnchorStyles.None
            .TextBox1.MaxLength = 6
            '.TextBox1.TextAlign = HorizontalAlignment.Center
            .TextBox1.Text = "0"
        End With
        Dim TxtPanel_Commodity_SafeQty As New TableText
        With TxtPanel_Commodity_SafeQty
            .Name = "TxtPanel_Commodity_SafeQty" & TLPPurchaseOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            .Dock = DockStyle.None
            .Anchor = AnchorStyles.None
            .TextBox1.MaxLength = 6
            .TextBox1.Text = "0"
        End With
        Dim CMB_Commodity_Unit As New ComboBox
        With CMB_Commodity_Unit
            .Name = "CMB_Commodity_Unit" & TLPPurchaseOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            .BackColor = Color.FromArgb(94, 148, 255)
            .ForeColor = Color.White
            '.Dock = DockStyle.Fill
            '.Anchor = AnchorStyles.None
            .Text = "請選擇"
        End With
        CMB_Commodity_Unit.Items.Add("包")
        CMB_Commodity_Unit.Items.Add("袋")
        CMB_Commodity_Unit.Items.Add("箱")
        CMB_Commodity_Unit.Items.Add("盒")
        CMB_Commodity_Unit.Items.Add("瓶")
        CMB_Commodity_Unit.Items.Add("罐")
        CMB_Commodity_Unit.Items.Add("台")
        CMB_Commodity_Unit.Items.Add("張")
        CMB_Commodity_Unit.Items.Add("座")
        CMB_Commodity_Unit.Items.Add("本")
        Dim TxtPanel_Commodity_Stock_Qty As New TableText
        With TxtPanel_Commodity_Stock_Qty
            .Name = "TxtPanel_Commodity_Stock_Qty" & TLPPurchaseOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            .Dock = DockStyle.None
            .Anchor = AnchorStyles.None
            .TextBox1.MaxLength = 6
            ' .TextBox1.TextAlign = HorizontalAlignment.Center
            .TextBox1.Text = "0"
        End With
        Dim TxtPanel_Commodity_UnitPrice As New TableText
        With TxtPanel_Commodity_UnitPrice
            .Name = "TxtPanel_Commodity_UnitPrice" & TLPPurchaseOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            .Dock = DockStyle.None
            .Anchor = AnchorStyles.None
            .TextBox1.MaxLength = 6
            .TextBox1.Text = "0"
        End With
        Dim TxtPanel_Commodity_TotalPrice As New TableText
        With TxtPanel_Commodity_TotalPrice
            .Name = "TxtPanel_Commodity_TotalPrice" & TLPPurchaseOrder.RowCount - 1
            .Font = New Font("標楷體", 20)
            .Dock = DockStyle.None
            .Anchor = AnchorStyles.None
            .TextBox1.MaxLength = 10
            .TextBox1.Text = "0"
        End With
        TLPPurchaseOrder.Controls.Add(myLabelItem, 0, TLPPurchaseOrder.RowCount - 1)
        TLPPurchaseOrder.Controls.Add(myTxtPanel_Commodity_ID, 1, TLPPurchaseOrder.RowCount - 1)
        TLPPurchaseOrder.Controls.Add(myTxtPanel_Commodity_Name, 2, TLPPurchaseOrder.RowCount - 1)
        TLPPurchaseOrder.Controls.Add(myCOMB_Commodity_Type, 3, TLPPurchaseOrder.RowCount - 1)
        TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_Qty, 4, TLPPurchaseOrder.RowCount - 1)
        TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_SafeQty, 5, TLPPurchaseOrder.RowCount - 1)
        TLPPurchaseOrder.Controls.Add(CMB_Commodity_Unit, 6, TLPPurchaseOrder.RowCount - 1)
        TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_Stock_Qty, 7, TLPPurchaseOrder.RowCount - 1)
        TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_UnitPrice, 8, TLPPurchaseOrder.RowCount - 1)
        TLPPurchaseOrder.Controls.Add(TxtPanel_Commodity_TotalPrice, 9, TLPPurchaseOrder.RowCount - 1)
    End Sub

    Private Sub BtnPrint_PurchaseOrder_Click(sender As Object, e As EventArgs) Handles BtnPrint_PurchaseOrder.Click
        Dim f As New frmRSS_Access_PurchaseOrder_Report
        f.TopMost = True
        f.Show()
    End Sub
    Private Sub AddhandleData()
        myRowCount = TLPPurchaseOrder.RowCount
        Dim i As Integer = myRowCount - 1
        myTableText2.Name = "TxtPanel_Commodity_Name" & i
        myTableText2 = TLPPurchaseOrder.GetControlFromPosition(2, i)
        myTableText3.Name = "TxtPanel_Commodity_TotalPrice" & i
        myTableText3 = TLPPurchaseOrder.GetControlFromPosition(9, i)
        AddHandler myTableText2.Enter, AddressOf GetCommodityName
        AddHandler myTableText2.MouseEnter, AddressOf GetCommodityName
        AddHandler myTableText2.Click, AddressOf GetCommodityName
        AddHandler myTableText2.MouseClick, AddressOf GetCommodityName
        AddHandler myTableText3.Enter, AddressOf GetSumTotalPrice
        AddHandler myTableText3.MouseEnter, AddressOf GetSumTotalPrice
    End Sub
End Class