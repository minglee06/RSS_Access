Imports System.Data.OleDb
Public Class frmRSS_Access_Customer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = Now

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
    Private Sub Customer_GetData()
        Dim mySelectStr As String = "SELECT * FROM Customer"
        BindingSource1.DataSource = Access_Connection.GetData(mySelectStr)
        DGVCustomer.DataSource = BindingSource1
        With DGVCustomer
            .ReadOnly = True
            .AutoGenerateColumns = True
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            '.ColumnHeadersBorderStyle = 0
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
            .EnableHeadersVisualStyles = False
            .DefaultCellStyle.Font = New Font("標楷體", 18)
            .EditMode = DataGridViewEditMode.EditProgrammatically
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .ColumnHeadersDefaultCellStyle.Font = New Font("標楷體", 20)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).HeaderText = "統一編號"
            .Columns(1).HeaderText = "客戶名稱"
            .Columns(2).HeaderText = "客戶電話"
            .Columns(3).HeaderText = "地址"
            .Columns(4).HeaderText = "負責人"
            .Columns(5).HeaderText = "職稱"
            .Columns(6).HeaderText = "手機號碼"
            .Columns(7).HeaderText = "接洽人"
            .Columns(8).HeaderText = "部門"
            .Columns(9).HeaderText = "職稱"
            .Columns(10).HeaderText = "手機號碼"

        End With
    End Sub

    Private Sub frmRSS_Access_Customer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Customer_GetData()
        TxtCustomer_Tax_ID.TextBox1.MaxLength = 8
        TxtCustomer_Co_Name.TextBox1.MaxLength = 20
        TxtCustomer_Co_PhoneNo.TextBox1.MaxLength = 8
        TxtCustomer_Co_Address.TextBox1.MaxLength = 200
        TxtCustomer_President_Name.TextBox1.MaxLength = 20
        TxtCustomer_President_JobTitle.TextBox1.MaxLength = 20
        TxtCustomer_President_CellPhone.TextBox1.MaxLength = 8
        TxtCustomer_Charge_Name.TextBox1.MaxLength = 20
        TxtCustomer_Charge_Department.TextBox1.MaxLength = 20
        TxtCustomer_Charge_JobTitle.TextBox1.MaxLength = 20
        TxtCustomer_Charge_CellPhone.TextBox1.MaxLength = 8
    End Sub
    Private Sub ClearText()
        TxtCustomer_Tax_ID.TextBox1.Text = ""
        TxtCustomer_Co_Name.TextBox1.Text = ""
        CMBPhoneCode.Text = "請選擇區碼"
        TxtCustomer_Co_PhoneNo.TextBox1.Text = ""
        TxtCustomer_Co_Address.TextBox1.Text = ""
        TxtCustomer_President_Name.TextBox1.Text = ""
        TxtCustomer_President_JobTitle.TextBox1.Text = ""
        TxtCustomer_President_CellPhone.TextBox1.Text = ""
        TxtCustomer_Charge_Name.TextBox1.Text = ""
        TxtCustomer_Charge_Department.TextBox1.Text = ""
        TxtCustomer_Charge_JobTitle.TextBox1.Text = ""
        TxtCustomer_Charge_CellPhone.TextBox1.Text = ""
    End Sub

    Private Sub CMBPhoneCode_SelectedValueChanged(sender As Object, e As EventArgs) Handles CMBPhoneCode.SelectedValueChanged
        TxtCustomer_Co_PhoneNo.TextBox1.Text = ""
        If Len(CMBPhoneCode.Text) = 3 Then
            TxtCustomer_Co_PhoneNo.TextBox1.MaxLength = 7
        Else
            TxtCustomer_Co_PhoneNo.TextBox1.MaxLength = 8
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim myConnStr As String = Access_Connection.ConnStr
        Dim myConn As New OleDbConnection(myConnStr)
        myConn.Open()
        Dim myInsertIntoStr As String = "INSERT INTO Customer VALUES(@Customer_Tax_ID,@Customer_Co_Name," &
            "@Customer_Co_Tel,@Customer_Co_Address,@Customer_President_Name,@Customer_President_JobTitle," &
            "@Customer_President_CellPhone,@Customer_Charge_Name,@Customer_Charge_Department,@Customer_Charge_JobTitle," &
            "@Customer_Charge_CellPhone)"
        Dim mySelectStr As String = "SELECT Customer_Tax_ID FROM Customer WHERE Customer_Tax_ID=@Customer_Tax_ID"
        Dim myComm As New OleDbCommand(myInsertIntoStr, myConn)
        Dim myComm1 As New OleDbCommand(mySelectStr, myConn)
        Dim TaxID As String = TxtCustomer_Tax_ID.TextBox1.Text
        Dim CustomerCoName As String = TxtCustomer_Co_Name.TextBox1.Text
        Dim CustomerCoTel As String = TxtCustomer_Co_PhoneNo.TextBox1.Text
        Dim CustomerCoAddress As String = TxtCustomer_Co_Address.TextBox1.Text
        Dim CustomerPresidentName As String = TxtCustomer_President_Name.TextBox1.Text
        Dim CustomerPresidentJobTitle As String = TxtCustomer_President_JobTitle.TextBox1.Text
        Dim CustomerPresidentCellPhone As String = TxtCustomer_President_CellPhone.TextBox1.Text
        Dim CustomerPresidentCellPhone09 As String = "09" & CustomerPresidentCellPhone
        Dim CustomerChargeName As String = TxtCustomer_Charge_Name.TextBox1.Text
        Dim CustomerChargeDepartment As String = TxtCustomer_Charge_Department.TextBox1.Text
        Dim CustomerChargeJobTitle As String = TxtCustomer_Charge_JobTitle.TextBox1.Text
        Dim CustomerChargeCellPhone As String = TxtCustomer_Charge_CellPhone.TextBox1.Text
        Dim CustomerChargeCellPhone09 As String = "09" & CustomerChargeCellPhone
        Dim CustomerPhone As String
        If TaxID = "" Then
            MsgBox("統一編號不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Tax_ID.Focus()
        ElseIf CustomerCoName = "" Then
            MsgBox("公司行號名稱不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Co_Name.Focus()
        ElseIf CustomerCoTel = "" Then
            MsgBox("公司行號電話不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Co_PhoneNo.Focus()
        ElseIf CustomerPresidentName = "" Then
            MsgBox("負責人姓名不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_President_Name.Focus()
        ElseIf CustomerPresidentJobTitle = "" Then
            MsgBox("負責人職稱不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_President_JobTitle.Focus()
        ElseIf CustomerPresidentCellPhone = "" Then
            MsgBox("負責人手機號碼不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_President_CellPhone.Focus()
        ElseIf CustomerChargeName = "" Then
            MsgBox("接洽人姓名不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Charge_Name.Focus()
        ElseIf CustomerChargeDepartment = "" Then
            MsgBox("接洽人部門不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Charge_Department.Focus()
        ElseIf CustomerChargeJobTitle = "" Then
            MsgBox("接洽人部門不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Charge_JobTitle.Focus()
        ElseIf CustomerChargeCellPhone = "" Then
            MsgBox("接洽人手機號碼不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Charge_CellPhone.Focus()
        Else
            If CMBPhoneCode.Text = "請選擇區碼" Or CMBPhoneCode.SelectedText = "請選擇區碼" Then
                MsgBox("區碼需選擇!!!", 0 + 48, "警告訊息!!!")
                CMBPhoneCode.Focus()
            Else
                CustomerPhone = CMBPhoneCode.Text & CustomerCoTel
                If IsNumeric(TaxID) = False Or Len(TaxID) <> 8 Then
                    MsgBox("統一編號只能輸入8個數字!!!", 0 + 48, "警告訊息!!!")
                    TxtCustomer_Tax_ID.Focus()
                ElseIf IsNumeric(CustomerPhone) = False Or Len(CustomerPhone) <> 10 Then
                    MsgBox("電話號碼只能輸入數字!!!", 0 + 48, "警告訊息!!!")
                    TxtCustomer_Co_PhoneNo.Focus()
                ElseIf IsNumeric(CustomerPresidentCellPhone) = False Or Len(CustomerPresidentCellPhone) <> 8 Then
                    MsgBox("負責人手機號碼只能輸入數字!!!", 0 + 48, "警告訊息!!!")
                    TxtCustomer_President_CellPhone.Focus()
                ElseIf IsNumeric(CustomerChargeCellPhone) = False Or Len(CustomerChargeCellPhone) <> 8 Then
                    MsgBox("接洽人手機號碼只能輸入數字!!!", 0 + 48, "警告訊息!!!")
                    TxtCustomer_Charge_CellPhone.Focus()
                Else
                    myComm1.Parameters.AddWithValue("@Customer_Tax_ID", TaxID)
                    myComm1.ExecuteNonQuery()
                    Dim myReader As OleDbDataReader = myComm1.ExecuteReader
                    If myReader.HasRows Then
                        MsgBox("已有此筆資料，無法新增", 0 + 48, "警告訊息!!!")
                    Else
                        myComm.Parameters.AddWithValue("@Customer_Tax_ID", TaxID)
                        myComm.Parameters.AddWithValue("@Customer_Co_Name", CustomerCoName)
                        myComm.Parameters.AddWithValue("@Customer_Co_Tel", CustomerPhone)
                        myComm.Parameters.AddWithValue("@Customer_Co_Address", CustomerCoAddress)
                        myComm.Parameters.AddWithValue("@Customer_President_Name", CustomerPresidentName)
                        myComm.Parameters.AddWithValue("@Customer_President_JobTitle", CustomerPresidentJobTitle)
                        myComm.Parameters.AddWithValue("@Customer_President_CellPhone", CustomerPresidentCellPhone09)
                        myComm.Parameters.AddWithValue("@Customer_Charge_Name", CustomerChargeName)
                        myComm.Parameters.AddWithValue("@Customer_Charge_Department", CustomerChargeDepartment)
                        myComm.Parameters.AddWithValue("@Customer_Charge_JobTitle", CustomerChargeJobTitle)
                        myComm.Parameters.AddWithValue("@Customer_Charge_CellPhone", CustomerChargeCellPhone09)
                        myComm.ExecuteNonQuery()
                        MsgBox("新增一筆資料成功", 0 + 48, "通知訊息")
                        myConn.Close()
                        Customer_GetData()
                        ClearText()
                    End If

                End If

            End If
        End If
        myConn.Close()
    End Sub

    Private Sub DGVCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCustomer.CellClick
        Try
            If DGVCustomer.Rows.Count > 0 Then
                TxtCustomer_Tax_ID.TextBox1.Text = DGVCustomer.CurrentRow.Cells(0).Value
                TxtCustomer_Co_Name.TextBox1.Text = DGVCustomer.CurrentRow.Cells(1).Value
                Dim i As Integer
                Dim code As String = Strings.Left(Convert.ToString(DGVCustomer.CurrentRow.Cells(2).Value), 3)
                Select Case code
                    Case "037"
                        CMBPhoneCode.Text = "037"
                    Case "049"
                        CMBPhoneCode.Text = "049"
                    Case "082"
                        CMBPhoneCode.Text = "082"
                    Case "089"
                        CMBPhoneCode.Text = "089"
                    Case Else
                        CMBPhoneCode.Text = Strings.Left(Convert.ToString(DGVCustomer.CurrentRow.Cells(2).Value), 2)
                End Select
                i = Len(CMBPhoneCode.Text)
                If i = 3 Then
                    TxtCustomer_Co_PhoneNo.TextBox1.Text = Strings.Right(DGVCustomer.CurrentRow.Cells(2).Value, 7)
                Else
                    TxtCustomer_Co_PhoneNo.TextBox1.Text = Strings.Right(DGVCustomer.CurrentRow.Cells(2).Value, 8)
                End If
                TxtCustomer_Co_Address.TextBox1.Text = DGVCustomer.CurrentRow.Cells(3).Value
                TxtCustomer_President_Name.TextBox1.Text = DGVCustomer.CurrentRow.Cells(4).Value
                TxtCustomer_President_JobTitle.TextBox1.Text = DGVCustomer.CurrentRow.Cells(5).Value
                TxtCustomer_President_CellPhone.TextBox1.Text = Strings.Right(DGVCustomer.CurrentRow.Cells(6).Value, 8)
                TxtCustomer_Charge_Name.TextBox1.Text = DGVCustomer.CurrentRow.Cells(7).Value
                TxtCustomer_Charge_Department.TextBox1.Text = DGVCustomer.CurrentRow.Cells(8).Value
                TxtCustomer_Charge_JobTitle.TextBox1.Text = DGVCustomer.CurrentRow.Cells(9).Value
                TxtCustomer_Charge_CellPhone.TextBox1.Text = Strings.Right(DGVCustomer.CurrentRow.Cells(10).Value, 8)
            End If
        Catch ex As Exception
            MsgBox("請選有資料的列位，你點選的位置超過列數", vbCritical, "警告訊息")
        End Try
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ClearText()
    End Sub
    Private Sub ClearTextExceptTaxID()
        TxtCustomer_Co_Name.TextBox1.Text = ""
        CMBPhoneCode.Text = "請選擇區碼"
        TxtCustomer_Co_PhoneNo.TextBox1.Text = ""
        TxtCustomer_Co_Address.TextBox1.Text = ""
        TxtCustomer_President_Name.TextBox1.Text = ""
        TxtCustomer_President_JobTitle.TextBox1.Text = ""
        TxtCustomer_President_CellPhone.TextBox1.Text = ""
        TxtCustomer_Charge_Name.TextBox1.Text = ""
        TxtCustomer_Charge_Department.TextBox1.Text = ""
        TxtCustomer_Charge_JobTitle.TextBox1.Text = ""
        TxtCustomer_Charge_CellPhone.TextBox1.Text = ""
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim ConnStr = Access_Connection.ConnStr
        Dim myConn As New OleDbConnection(ConnStr)
        Dim StrID As String = TxtCustomer_Tax_ID.TextBox1.Text
        Dim myStr As String = "Select * from Customer WHERE Customer_Tax_ID=@Customer_Tax_ID "
        Dim myDelStr As String = "DELETE from Customer WHERE Customer_Tax_ID=@Customer_Tax_ID"
        myConn.Open()
        Dim myComm As New OleDbCommand(myStr, myConn)
        Dim myComm1 As New OleDbCommand(myDelStr, myConn)
        myComm.Parameters.AddWithValue("@Customer_Tax_ID", StrID)
        myComm.ExecuteNonQuery()
        If StrID = "" Then
            MsgBox("統一編號不能空白!!!", 0 + 48, "統一編號要填寫!!!")
            TxtCustomer_Tax_ID.Focus()
        Else
            Dim myReader As OleDbDataReader = myComm.ExecuteReader
            If myReader.HasRows Then
                Dim x = MsgBox("確定要刪除此筆資料嗎?", 4 + 48, "警告訊息")
                If x = 6 Then
                    myComm1.Parameters.AddWithValue("@Customer_Tax_ID", StrID)
                    myComm1.ExecuteNonQuery()
                    MsgBox("刪除資料成功!!!", 0 + 48, "通知訊息")
                Else
                    Exit Sub
                End If
            Else
                MsgBox("無此筆資料!!!", 0 + 48, "警告訊息!!!")
            End If
        End If
        myConn.Close()
        Customer_GetData()
        ClearText()
    End Sub



    Private Sub TxtCustomer_Co_Name_Enter(sender As Object, e As EventArgs) Handles TxtCustomer_Co_Name.Enter
        Dim MyConnStr As String = Access_Connection.ConnStr
        Dim MySelectStr As String = "SELECT * FROM Customer WHERE Customer_Tax_ID=@Customer_Tax_ID"
        Dim MyID As String = TxtCustomer_Tax_ID.TextBox1.Text
        Dim myConn As New OleDbConnection(MyConnStr)
        myConn.Open()
        Dim myComm As New OleDbCommand(MySelectStr, myConn)
        myComm.Parameters.AddWithValue("@Customer_Tax_ID", MyID)
        myComm.ExecuteNonQuery()
        Dim MyReader As OleDbDataReader = myComm.ExecuteReader
        If MyID = "" Then
            MsgBox("統一編號不能空白!!!", vbCritical, "警告訊息")
            TxtCustomer_Tax_ID.Focus()
        Else
            If MyReader.HasRows Then
                While MyReader.Read
                    TxtCustomer_Co_Name.TextBox1.Text = MyReader.Item(1).ToString
                    Dim i As Integer
                    Dim code As String = Strings.Left(MyReader.Item(2).ToString, 3)
                    Select Case code
                        Case "037"
                            CMBPhoneCode.Text = "037"
                        Case "049"
                            CMBPhoneCode.Text = "049"
                        Case "082"
                            CMBPhoneCode.Text = "082"
                        Case "089"
                            CMBPhoneCode.Text = "089"
                        Case Else
                            CMBPhoneCode.Text = Strings.Left(MyReader.Item(2).ToString, 2)
                    End Select
                    i = Len(CMBPhoneCode.Text)
                    If i = 3 Then
                        TxtCustomer_Co_PhoneNo.TextBox1.Text = Strings.Right(MyReader.Item(2).ToString, 7)
                    Else
                        TxtCustomer_Co_PhoneNo.TextBox1.Text = Strings.Right(MyReader.Item(2).ToString, 8)
                    End If
                    TxtCustomer_Co_Address.TextBox1.Text = MyReader.Item(3).ToString
                    TxtCustomer_President_Name.TextBox1.Text = MyReader.Item(4).ToString
                    TxtCustomer_President_JobTitle.TextBox1.Text = MyReader.Item(5).ToString
                    TxtCustomer_President_CellPhone.TextBox1.Text = Strings.Right(MyReader.Item(6).ToString, 8)
                    TxtCustomer_Charge_Name.TextBox1.Text = MyReader.Item(7).ToString
                    TxtCustomer_Charge_Department.TextBox1.Text = MyReader.Item(8).ToString
                    TxtCustomer_Charge_JobTitle.TextBox1.Text = MyReader.Item(9).ToString
                    TxtCustomer_Charge_CellPhone.TextBox1.Text = Strings.Right(MyReader.Item(10).ToString, 8)
                End While
            Else
                MsgBox("無此筆資料，需要新增資料!!!!", vbCritical, "警告訊息")
                TxtCustomer_Co_Name.Focus()
                ClearTextExceptTaxID()

            End If
        End If
        myConn.Close()
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim myConnStr As String = Access_Connection.ConnStr
        Dim mySelectStr As String = "SELECT * FROM Customer WHERE Customer_Tax_ID=@Customer_Tax_ID"
        Dim myUpdateStr As String = "UPDATE Customer SET Customer_Tax_ID=@Customer_Tax_ID," &
            "Customer_Co_Name=@Customer_Co_Name,Customer_Co_Tel=@Customer_Co_Tel,Customer_Co_Address=@Customer_Co_Address," &
            "Customer_President_Name=@Customer_President_Name,Customer_President_JobTitle=@Customer_President_JobTitle," &
            "Customer_President_CellPhone=@Customer_President_CellPhone,Customer_Charge_Name=@Customer_Charge_Name," &
            "Customer_Charge_Department=@Customer_Charge_Department,Customer_Charge_JobTitle=@Customer_Charge_JobTitle," &
            "Customer_Charge_CellPhone=@Customer_Charge_CellPhone WHERE Customer_Tax_ID=@Customer_Tax_ID"
        Dim MyConn As New OleDbConnection(myConnStr)
        MyConn.Open()
        Dim MyComm As New OleDbCommand(mySelectStr, MyConn)
        Dim MyComm1 As New OleDbCommand(myUpdateStr, MyConn)
        Dim TaxID As String = TxtCustomer_Tax_ID.TextBox1.Text
        Dim CustomerCoName As String = TxtCustomer_Co_Name.TextBox1.Text
        Dim CustomerCoTel As String = TxtCustomer_Co_PhoneNo.TextBox1.Text
        Dim CustomerCoAddress As String = TxtCustomer_Co_Address.TextBox1.Text
        Dim CustomerPresidentName As String = TxtCustomer_President_Name.TextBox1.Text
        Dim CustomerPresidentJobTitle As String = TxtCustomer_President_JobTitle.TextBox1.Text
        Dim CustomerPresidentCellPhone As String = TxtCustomer_President_CellPhone.TextBox1.Text
        Dim CustomerPresidentCellPhone09 As String = "09" & CustomerPresidentCellPhone
        Dim CustomerChargeName As String = TxtCustomer_Charge_Name.TextBox1.Text
        Dim CustomerChargeDepartment As String = TxtCustomer_Charge_Department.TextBox1.Text
        Dim CustomerChargeJobTitle As String = TxtCustomer_Charge_JobTitle.TextBox1.Text
        Dim CustomerChargeCellPhone As String = TxtCustomer_Charge_CellPhone.TextBox1.Text
        Dim CustomerChargeCellPhone09 As String = "09" & CustomerChargeCellPhone
        Dim CustomerPhone As String
        If TaxID = "" Then
            MsgBox("統一編號不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Tax_ID.Focus()
        ElseIf CustomerCoName = "" Then
            MsgBox("公司行號名稱不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Co_Name.Focus()
        ElseIf CustomerCoTel = "" Then
            MsgBox("公司行號電話不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Co_PhoneNo.Focus()
        ElseIf CustomerPresidentName = "" Then
            MsgBox("負責人姓名不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_President_Name.Focus()
        ElseIf CustomerPresidentJobTitle = "" Then
            MsgBox("負責人職稱不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_President_JobTitle.Focus()
        ElseIf CustomerPresidentCellPhone = "" Then
            MsgBox("負責人手機號碼不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_President_CellPhone.Focus()
        ElseIf CustomerChargeName = "" Then
            MsgBox("接洽人姓名不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Charge_Name.Focus()
        ElseIf CustomerChargeDepartment = "" Then
            MsgBox("接洽人部門不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Charge_Department.Focus()
        ElseIf CustomerChargeJobTitle = "" Then
            MsgBox("接洽人部門不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Charge_JobTitle.Focus()
        ElseIf CustomerChargeCellPhone = "" Then
            MsgBox("接洽人手機號碼不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCustomer_Charge_CellPhone.Focus()
        Else
            If CMBPhoneCode.Text = "請選擇區碼" Or CMBPhoneCode.SelectedText = "請選擇區碼" Then
                MsgBox("區碼需選擇!!!", 0 + 48, "警告訊息!!!")
                CMBPhoneCode.Focus()
            Else
                CustomerPhone = CMBPhoneCode.Text & CustomerCoTel
                If IsNumeric(TaxID) = False Or Len(TaxID) <> 8 Then
                    MsgBox("統一編號只能輸入8個數字!!!", 0 + 48, "警告訊息!!!")
                    TxtCustomer_Tax_ID.Focus()
                ElseIf IsNumeric(CustomerPhone) = False Or Len(CustomerPhone) <> 10 Then
                    MsgBox("電話號碼只能輸入數字!!!", 0 + 48, "警告訊息!!!")
                    TxtCustomer_Co_PhoneNo.Focus()
                ElseIf IsNumeric(CustomerPresidentCellPhone) = False Or Len(CustomerPresidentCellPhone) <> 8 Then
                    MsgBox("負責人手機號碼只能輸入8個數字!!!", 0 + 48, "警告訊息!!!")
                    TxtCustomer_President_CellPhone.Focus()
                ElseIf IsNumeric(CustomerChargeCellPhone) = False Or Len(CustomerChargeCellPhone) <> 8 Then
                    MsgBox("接洽人手機號碼只能輸入8個數字!!!", 0 + 48, "警告訊息!!!")
                    TxtCustomer_Charge_CellPhone.Focus()
                Else
                    MyComm.Parameters.AddWithValue("@Customer_Tax_ID", TaxID)
                    MyComm.ExecuteNonQuery()
                    Dim myReder As OleDbDataReader = MyComm.ExecuteReader
                    If myReder.HasRows Then
                        Dim x = MsgBox("確定要更新此資料?", 4 + 48, "詢問訊息")
                        If x = 6 Then
                            MyComm1.Parameters.AddWithValue("@Customer_Tax_ID", TaxID)
                            MyComm1.Parameters.AddWithValue("@Customer_Co_Name", CustomerCoName)
                            MyComm1.Parameters.AddWithValue("@Customer_Co_Tel", CustomerPhone)
                            MyComm1.Parameters.AddWithValue("@Customer_Co_Address", CustomerCoAddress)
                            MyComm1.Parameters.AddWithValue("@Customer_President_Name", CustomerPresidentName)
                            MyComm1.Parameters.AddWithValue("@Customer_President_JobTitle", CustomerPresidentJobTitle)
                            MyComm1.Parameters.AddWithValue("@Customer_President_CellPhone", CustomerPresidentCellPhone09)
                            MyComm1.Parameters.AddWithValue("@Customer_Charge_Name", CustomerChargeName)
                            MyComm1.Parameters.AddWithValue("@Customer_Charge_Department", CustomerChargeDepartment)
                            MyComm1.Parameters.AddWithValue("@Customer_Charge_JobTitle", CustomerChargeJobTitle)
                            MyComm1.Parameters.AddWithValue("@Customer_Charge_CellPhone", CustomerChargeCellPhone09)
                            MyComm1.ExecuteNonQuery()
                            MsgBox("更新資料成功!!!", 0 + 48, "通知訊息")
                            ClearText()
                        Else
                            MyConn.Close()
                            Exit Sub
                        End If
                    Else
                        MsgBox("無此筆統一編號資料!!!", vbCritical, "警告訊息")
                    End If
                End If
            End If
        End If
        MyConn.Close()
        Customer_GetData()
    End Sub


End Class