Imports System.Data.OleDb
Imports RSS_Access.Access_Connection
Public Class frmRSS_Access_Supply
    Private Sub frmRSS_Access_Supply_Load(sender As Object, e As EventArgs) Handles Me.Load

        TxtSupply_Tax_ID.TextBox1.MaxLength = 8
        TxtSupply_Co_Name.TextBox1.MaxLength = 20
        TxtSupply_Co_Phone.TextBox1.MaxLength = 8
        TxtSupply_Co_Address.TextBox1.MaxLength = 200
        TxtSupply_Present_Name.TextBox1.MaxLength = 20
        TxtSupply_Present_CellPhone.TextBox1.MaxLength = 8
        TxtChargeName.TextBox1.MaxLength = 20
        TxtChargeDepartment.TextBox1.MaxLength = 20
        TxtChargeCellphone.TextBox1.MaxLength = 8

        Supply_GetData()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = Now
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Connection.Open()
        Dim StrID As String = TxtSupply_Tax_ID.TextBox1.Text
        Dim StrCoName As String = TxtSupply_Co_Name.TextBox1.Text
        Dim StrCoTel As String = TxtSupply_Co_Phone.TextBox1.Text
        Dim StrCoAddress As String = TxtSupply_Co_Address.TextBox1.Text
        Dim StrCoPresentName As String = TxtSupply_Present_Name.TextBox1.Text
        Dim StrCoPresidentJobTitle As String = TxtPresident_JobTitle.TextBox1.Text
        Dim StrCoPresentCellPhone As String = TxtSupply_Present_CellPhone.TextBox1.Text
        Dim StrCoPresentCellPhone09 As String = "09" & StrCoPresentCellPhone
        Dim StrChargeName As String = TxtChargeName.TextBox1.Text
        Dim StrChargeDepartment As String = TxtChargeDepartment.TextBox1.Text
        Dim StrChargeJobTitle As String = TxtCharge_JobTitle.TextBox1.Text
        Dim StrChargeCellPhone As String = TxtChargeCellphone.TextBox1.Text
        Dim StrChargeCellPhone09 As String = "09" & StrChargeCellPhone
        Dim StrCoTelCode As String
        If StrID = "" Then
            MsgBox("統一編號不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtSupply_Tax_ID.Focus()
        ElseIf StrCoName = "" Then
            MsgBox("供應商名稱不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtSupply_Co_Name.Focus()
        ElseIf StrCoTel = "" Then
            MsgBox("供應商電話不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtSupply_Co_Phone.Focus()
        ElseIf StrCoAddress = "" Then
            MsgBox("供應商地址不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtSupply_Co_Address.Focus()
        ElseIf StrCoPresentName = "" Then
            MsgBox("供應商負責人不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtSupply_Present_Name.Focus()
        ElseIf StrCoPresidentJobTitle = "" Then
            MsgBox("供應商負責人職稱不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtPresident_JobTitle.Focus()
        ElseIf StrCoPresentCellPhone = "" Then
            MsgBox("供應商負責人手機號碼不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtSupply_Present_CellPhone.Focus()
        ElseIf StrChargeName = "" Then
            MsgBox("供應商接洽人不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtChargeName.Focus()
        ElseIf StrChargeDepartment = "" Then
            MsgBox("供應商接洽人部門不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtChargeDepartment.Focus()
        ElseIf StrChargeJobTitle = "" Then
            MsgBox("供應商接洽人職稱不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCharge_JobTitle.Focus()
        ElseIf StrChargeCellPhone = "" Then
            MsgBox("供應商接洽人手機號碼不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtChargeCellphone.Focus()
        Else
            If ComBPhoneCode.SelectedText = "請選擇區碼" Or ComBPhoneCode.Text = "請選擇區碼" Then
                MsgBox("請選擇數字區域號碼!!!", 0 + 48, "警告訊息")
                ComBPhoneCode.Focus()
            Else
                StrCoTelCode = ComBPhoneCode.Text & StrCoTel
                Dim myInsertIntoStr As String = "INSERT INTO Supply VALUES(" &
                        "@Supply_Tax_ID,@Supply_Co_Name," &
                        "@Supply_Co_Telphone,@Supply_Co_Address," &
                        "@Supply_Co_President_Name," &
                        "@Supply_Co_President_JobTitle," &
                        "@Supply_Co_President_CellPhone," &
                        "@Supply_Charge_Name," &
                        "@Supply_Charge_Department," &
                        "@Supply_Charge_JobTitle," &
                        "@Supply_Charge_CellPhone)"
                Dim mySelectStr As String = "SELECT Supply_Tax_ID from Supply WHERE Supply_Tax_ID=@Supply_Tax_ID"
                Dim myCommand As New OleDbCommand(mySelectStr, Connection)
                Dim myCommand1 As New OleDbCommand(myInsertIntoStr, Connection)
                If IsNumeric(StrID) = False Or Len(StrID) <> 8 Then
                    MsgBox("統一編號只能8個數字或輸入錯誤", vbCritical, "警告訊息")
                    TxtSupply_Tax_ID.Focus()
                ElseIf IsNumeric(StrCoTel) = False Or Len(StrCoTelCode) <> 10 Then
                    MsgBox("電話號碼含區碼只能10個數字或輸入錯誤", vbCritical, "警告訊息")
                    TxtSupply_Co_Phone.Focus()
                ElseIf IsNumeric(StrCoPresentCellPhone) = False Or Len(StrCoPresentCellPhone) <> 8 Then
                    MsgBox("手機號碼含09只能10個數字或輸入錯誤", vbCritical, "警告訊息")
                    TxtSupply_Present_CellPhone.Focus()
                ElseIf IsNumeric(StrChargeCellPhone) = False Or Len(StrChargeCellPhone) <> 8 Then
                    MsgBox("手機號碼含09只能10個數字或輸入錯誤", vbCritical, "警告訊息")
                    TxtChargeCellphone.Focus()
                Else
                    myCommand.Parameters.AddWithValue("@Supply_Tax_ID", StrID)
                    myCommand.ExecuteNonQuery()
                    Dim myReader As OleDbDataReader = myCommand.ExecuteReader
                    If myReader.HasRows Then
                        MsgBox("已有此筆統一編號資料!!!", vbCritical, "警告訊息")
                    Else
                        myCommand1.Parameters.AddWithValue("@Supply_Tax_ID", StrID)
                        myCommand1.Parameters.AddWithValue("@Supply_Co_Name", StrCoName)
                        myCommand1.Parameters.AddWithValue("@Supply_Co_Telphone", StrCoTelCode)
                        myCommand1.Parameters.AddWithValue("@Supply_Co_Address", StrCoAddress)
                        myCommand1.Parameters.AddWithValue("@Supply_Co_President_Name", StrCoPresentName)
                        myCommand1.Parameters.AddWithValue("@Supply_Co_President_JobTitle", StrCoPresidentJobTitle)
                        myCommand1.Parameters.AddWithValue("@Supply_Co_President_CellPhone", StrCoPresentCellPhone09)
                        myCommand1.Parameters.AddWithValue("@Supply_Charge_Name", StrChargeName)
                        myCommand1.Parameters.AddWithValue("@Supply_Charge_Department", StrChargeDepartment)
                        myCommand1.Parameters.AddWithValue("@Supply_Charge_JobTitle", StrChargeJobTitle)
                        myCommand1.Parameters.AddWithValue("@Supply_Charge_CellPhone", StrChargeCellPhone09)
                        myCommand1.ExecuteNonQuery()
                        MsgBox("新增資料成功", vbInformation, "通知訊息")
                        ClearText()
                    End If
                End If
            End If
        End If
        Connection.Close()
        Supply_GetData()
    End Sub
    Private Sub Supply_GetData()
        Dim mySelectStr As String = "Select * from Supply"
        BindingSource1.DataSource = GetData(mySelectStr)
        DGVSupply.DataSource = BindingSource1
        With DGVSupply
            .ReadOnly = True
            .AutoGenerateColumns = True
            '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
            .EnableHeadersVisualStyles = False
            .DefaultCellStyle.Font = New Font("標楷體", 18)
            .EditMode = DataGridViewEditMode.EditProgrammatically
            .Columns(0).HeaderText = "統一編號"
            '.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .Columns(1).Width = 600
            .Columns(1).HeaderText = "供應商名稱"
            .Columns(2).HeaderText = "電話"
            .Columns(3).HeaderText = "地址"
            .Columns(4).HeaderText = "負責人"
            '.Columns(4).HeaderCell.Style.Font = New Font("標楷體", 14)
            '.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .Columns(5).HeaderText = "職稱"
            .Columns(6).HeaderText = "手機號碼"
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(7).HeaderText = "接洽人"
            '.Columns(7).HeaderCell.Style.Font = New Font("標楷體", 14)
            .Columns(8).HeaderText = "部門"
            .Columns(9).HeaderText = "職稱"
            .Columns(10).HeaderText = "手機號碼"
            .Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .ColumnHeadersDefaultCellStyle.Font = New Font("標楷體", 20)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub DGVSupply_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSupply.CellClick
        Try
            If DGVSupply.Rows.Count > 0 Then
                TxtSupply_Tax_ID.TextBox1.Text = DGVSupply.CurrentRow.Cells(0).Value
                TxtSupply_Co_Name.TextBox1.Text = DGVSupply.CurrentRow.Cells(1).Value
                Dim i As Integer
                Dim code As String = Strings.Left(Convert.ToString(DGVSupply.CurrentRow.Cells(2).Value), 3)
                Select Case code
                    Case "037"
                        ComBPhoneCode.Text = "037"
                    Case "049"
                        ComBPhoneCode.Text = "049"
                    Case "082"
                        ComBPhoneCode.Text = "082"
                    Case "089"
                        ComBPhoneCode.Text = "089"
                    Case Else
                        ComBPhoneCode.Text = Strings.Left(Convert.ToString(DGVSupply.CurrentRow.Cells(2).Value), 2)
                End Select
                i = Len(ComBPhoneCode.Text)
                If i = 3 Then
                    TxtSupply_Co_Phone.TextBox1.Text = Strings.Right(DGVSupply.CurrentRow.Cells(2).Value, 7)
                Else
                    TxtSupply_Co_Phone.TextBox1.Text = Strings.Right(DGVSupply.CurrentRow.Cells(2).Value, 8)
                End If
                TxtSupply_Co_Address.TextBox1.Text = DGVSupply.CurrentRow.Cells(3).Value
                TxtSupply_Present_Name.TextBox1.Text = DGVSupply.CurrentRow.Cells(4).Value
                TxtPresident_JobTitle.TextBox1.Text = DGVSupply.CurrentRow.Cells(5).Value
                TxtSupply_Present_CellPhone.TextBox1.Text = Strings.Right(DGVSupply.CurrentRow.Cells(6).Value, 8)
                TxtChargeName.TextBox1.Text = DGVSupply.CurrentRow.Cells(7).Value
                TxtChargeDepartment.TextBox1.Text = DGVSupply.CurrentRow.Cells(8).Value
                TxtCharge_JobTitle.TextBox1.Text = DGVSupply.CurrentRow.Cells(9).Value
                TxtChargeCellphone.TextBox1.Text = Strings.Right(DGVSupply.CurrentRow.Cells(10).Value, 8)
            End If
        Catch ex As Exception
            MsgBox("請選有資料的列位，你點選的位置超過列數", vbCritical, "警告訊息")
        End Try

    End Sub
    Private Sub ClearText()
        TxtSupply_Tax_ID.TextBox1.Text = ""
        TxtSupply_Co_Name.TextBox1.Text = ""
        ComBPhoneCode.Text = "請選擇區碼"
        TxtSupply_Co_Address.TextBox1.Text = ""
        TxtSupply_Co_Phone.TextBox1.Text = ""
        TxtSupply_Present_Name.TextBox1.Text = ""
        TxtPresident_JobTitle.TextBox1.Text = ""
        TxtSupply_Present_CellPhone.TextBox1.Text = ""
        TxtChargeName.TextBox1.Text = ""
        TxtChargeDepartment.TextBox1.Text = ""
        TxtCharge_JobTitle.TextBox1.Text = ""
        TxtChargeCellphone.TextBox1.Text = ""
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ClearText()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim ConnStr = Access_Connection.ConnStr
        Dim myConn As New OleDbConnection(ConnStr)
        Dim StrID As String = TxtSupply_Tax_ID.TextBox1.Text
        Dim myStr As String = "Select * from Supply WHERE Supply_Tax_ID=@Supply_Tax_ID "
        Dim myDelStr As String = "DELETE from Supply WHERE Supply_Tax_ID=@Supply_Tax_ID"
        myConn.Open()
        Dim myComm As New OleDbCommand(myStr, myConn)
        Dim myComm1 As New OleDbCommand(myDelStr, myConn)
        myComm.Parameters.AddWithValue("@Supply_Tax_ID", StrID)
        myComm.ExecuteNonQuery()
        If StrID = "" Then
            MsgBox("統一編號不能空白!!!", 0 + 48, "統一編號要填寫!!!")
            TxtSupply_Tax_ID.Focus()
        Else
            Dim myReader As OleDbDataReader = myComm.ExecuteReader
            If myReader.HasRows Then
                Dim x = MsgBox("確定要刪除此筆資料嗎?", 4 + 48, "警告訊息")
                If x = 6 Then
                    myComm1.Parameters.AddWithValue("@Supply_Tax_ID", StrID)
                    myComm1.ExecuteNonQuery()
                    MsgBox("刪除資料成功!!!", 0 + 48, "通知訊息")
                Else
                    Exit Sub
                End If
            End If
        End If
        myConn.Close()
        Supply_GetData()
        ClearText()
    End Sub

    Private Sub TxtSupply_Co_Name_Enter(sender As Object, e As EventArgs) Handles TxtSupply_Co_Name.Enter
        Dim MyConnStr As String = Access_Connection.ConnStr
        Dim MySelectStr As String = "SELECT * FROM Supply WHERE Supply_Tax_ID=@Supply_Tax_ID"
        Dim MyID As String = TxtSupply_Tax_ID.TextBox1.Text
        Dim myConn As New OleDbConnection(MyConnStr)
        myConn.Open()
        Dim myComm As New OleDbCommand(MySelectStr, myConn)
        myComm.Parameters.AddWithValue("@Supply_Tax_ID", MyID)
        myComm.ExecuteNonQuery()
        Dim MyReader As OleDbDataReader = myComm.ExecuteReader
        If MyID = "" Then
            MsgBox("統一編號不能空白!!!", vbCritical, "警告訊息")
        Else
            If MyReader.HasRows Then
                While MyReader.Read
                    TxtSupply_Co_Name.TextBox1.Text = MyReader.Item(1).ToString
                    Dim i As Integer
                    Dim code As String = Strings.Left(MyReader.Item(2).ToString, 3)
                    Select Case code
                        Case "037"
                            ComBPhoneCode.Text = "037"
                        Case "049"
                            ComBPhoneCode.Text = "049"
                        Case "082"
                            ComBPhoneCode.Text = "082"
                        Case "089"
                            ComBPhoneCode.Text = "089"
                        Case Else
                            ComBPhoneCode.Text = Strings.Left(MyReader.Item(2).ToString, 2)
                    End Select
                    i = Len(ComBPhoneCode.Text)
                    If i = 3 Then
                        TxtSupply_Co_Phone.TextBox1.Text = Strings.Right(MyReader.Item(2).ToString, 7)
                    Else
                        TxtSupply_Co_Phone.TextBox1.Text = Strings.Right(MyReader.Item(2).ToString, 8)
                    End If
                    TxtSupply_Co_Address.TextBox1.Text = MyReader.Item(3).ToString
                    TxtSupply_Present_Name.TextBox1.Text = MyReader.Item(4).ToString
                    TxtPresident_JobTitle.TextBox1.Text = MyReader.Item(5).ToString
                    TxtSupply_Present_CellPhone.TextBox1.Text = Strings.Right(MyReader.Item(6).ToString, 8)
                    TxtChargeName.TextBox1.Text = MyReader.Item(7).ToString
                    TxtChargeDepartment.TextBox1.Text = MyReader.Item(8).ToString
                    TxtCharge_JobTitle.TextBox1.Text = MyReader.Item(9).ToString
                    TxtChargeCellphone.TextBox1.Text = Strings.Right(MyReader.Item(10).ToString, 8)
                End While
            Else
                MsgBox("無此筆資料!!!!", vbCritical, "警告訊息")
            End If
        End If
        myConn.Close()
    End Sub

    Private Sub ComBPhoneCode_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComBPhoneCode.SelectedValueChanged
        TxtSupply_Co_Phone.TextBox1.Text = ""
        If Len(ComBPhoneCode.Text) = 3 Then
            TxtSupply_Co_Phone.TextBox1.MaxLength = 7
        Else
            TxtSupply_Co_Phone.TextBox1.MaxLength = 8
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Connection.Open()
        Dim StrID As String = TxtSupply_Tax_ID.TextBox1.Text
        Dim StrCoName As String = TxtSupply_Co_Name.TextBox1.Text
        Dim StrCoTel As String = TxtSupply_Co_Phone.TextBox1.Text
        Dim StrCoAddress As String = TxtSupply_Co_Address.TextBox1.Text
        Dim StrCoPresentName As String = TxtSupply_Present_Name.TextBox1.Text
        Dim StrCoPresidentJobTitle As String = TxtPresident_JobTitle.TextBox1.Text
        Dim StrCoPresentCellPhone As String = TxtSupply_Present_CellPhone.TextBox1.Text
        Dim StrCoPresentCellPhone09 As String = "09" & StrCoPresentCellPhone
        Dim StrChargeName As String = TxtChargeName.TextBox1.Text
        Dim StrChargeDepartment As String = TxtChargeDepartment.TextBox1.Text
        Dim StrChargeJobTitle As String = TxtCharge_JobTitle.TextBox1.Text
        Dim StrChargeCellPhone As String = TxtChargeCellphone.TextBox1.Text
        Dim StrChargeCellPhone09 As String = "09" & StrChargeCellPhone
        Dim StrCoTelCode As String
        If StrID = "" Then
            MsgBox("統一編號不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtSupply_Tax_ID.Focus()
        ElseIf StrCoName = "" Then
            MsgBox("供應商名稱不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtSupply_Co_Name.Focus()
        ElseIf StrCoTel = "" Then
            MsgBox("供應商電話不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtSupply_Co_Phone.Focus()
        ElseIf StrCoAddress = "" Then
            MsgBox("供應商地址不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtSupply_Co_Address.Focus()
        ElseIf StrCoPresentName = "" Then
            MsgBox("供應商負責人不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtSupply_Present_Name.Focus()
        ElseIf StrCoPresidentJobTitle = "" Then
            MsgBox("供應商負責人職稱不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtPresident_JobTitle.Focus()
        ElseIf StrCoPresentCellPhone = "" Then
            MsgBox("供應商負責人手機號碼不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtSupply_Present_CellPhone.Focus()
        ElseIf StrChargeName = "" Then
            MsgBox("供應商接洽人不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtChargeName.Focus()
        ElseIf StrChargeDepartment = "" Then
            MsgBox("供應商接洽人部門不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtChargeDepartment.Focus()
        ElseIf StrChargeJobTitle = "" Then
            MsgBox("供應商接洽人職稱不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtCharge_JobTitle.Focus()
        ElseIf StrChargeCellPhone = "" Then
            MsgBox("供應商接洽人手機號碼不能空白!!!", 0 + 48, "警告訊息!!!")
            TxtChargeCellphone.Focus()
        Else
            If ComBPhoneCode.SelectedText = "請選擇區碼" Or ComBPhoneCode.Text = "請選擇區碼" Then
                MsgBox("請選擇數字區域號碼!!!", 0 + 48, "警告訊息")
                ComBPhoneCode.Focus()
            Else
                StrCoTelCode = ComBPhoneCode.Text & StrCoTel
                If IsNumeric(StrID) = False Or Len(StrID) <> 8 Then
                    MsgBox("統一編號只能8個數字或輸入錯誤", vbCritical, "警告訊息")
                    TxtSupply_Tax_ID.Focus()
                ElseIf IsNumeric(StrCoTel) = False Or Len(StrCoTelCode) <> 10 Then
                    MsgBox("電話號碼含區碼只能10個數字或輸入錯誤", vbCritical, "警告訊息")
                    TxtSupply_Co_Phone.Focus()
                ElseIf IsNumeric(StrCoPresentCellPhone) = False Or Len(StrCoPresentCellPhone) <> 8 Then
                    MsgBox("手機號碼含09只能10個數字或輸入錯誤", vbCritical, "警告訊息")
                    TxtSupply_Present_CellPhone.Focus()
                ElseIf IsNumeric(StrChargeCellPhone) = False Or Len(StrChargeCellPhone) <> 8 Then
                    MsgBox("手機號碼含09只能10個數字或輸入錯誤", vbCritical, "警告訊息")
                    TxtChargeCellphone.Focus()
                Else
                    Dim mySelectStr As String = "SELECT * FROM Supply WHERE Supply_Tax_ID=@Supply_Tax_ID"
                    Dim myUpdateStr As String = "UPDATE Supply SET Supply_Tax_ID=@Supply_Tax_ID," &
                             "Supply_Co_Name=@Supply_Co_Name," &
                             "Supply_Co_Telphone=@Supply_Co_Telphone,Supply_Co_Address=@Supply_Co_Address," &
                             "Supply_Co_President_Name=@Supply_Co_President_Name," &
                             "Supply_Co_President_JobTitle=@Supply_Co_President_JobTitle," &
                            "Supply_Co_President_CellPhone=@Supply_Co_President_CellPhone," &
                            "Supply_Charge_Name=@Supply_Charge_Name," &
                            "Supply_Charge_Department=@Supply_Charge_Department," &
                            "Supply_Charge_JobTitle=@Supply_Charge_JobTitle," &
                            "Supply_Charge_CellPhone=@Supply_Charge_CellPhone Where Supply_Tax_ID=@Supply_Tax_ID"
                    Dim myCommand As New OleDbCommand(mySelectStr, Connection)
                    Dim myCommand1 As New OleDbCommand(myUpdateStr, Connection)
                    myCommand.Parameters.AddWithValue("@Supply_Tax_ID", StrID)
                    myCommand.ExecuteNonQuery()
                    Dim myReader As OleDbDataReader = myCommand.ExecuteReader
                    If myReader.HasRows Then
                        MsgBox("有此筆資料")
                        Dim x = MsgBox("確定要更新此資料?", 4 + 48, "詢問訊息")
                        If x = 6 Then
                            myCommand1.Parameters.AddWithValue("@Supply_Tax_ID", StrID)
                            myCommand1.Parameters.AddWithValue("@Supply_Co_Name", StrCoName)
                            myCommand1.Parameters.AddWithValue("@Supply_Co_Telphone", StrCoTelCode)
                            myCommand1.Parameters.AddWithValue("@Supply_Co_Address", StrCoAddress)
                            myCommand1.Parameters.AddWithValue("@Supply_Co_President_Name", StrCoPresentName)
                            myCommand1.Parameters.AddWithValue("@Supply_Co_President_JobTitle", StrCoPresidentJobTitle)
                            myCommand1.Parameters.AddWithValue("@Supply_Co_President_CellPhone", StrCoPresentCellPhone09)
                            myCommand1.Parameters.AddWithValue("@Supply_Charge_Name", StrChargeName)
                            myCommand1.Parameters.AddWithValue("@Supply_Charge_Department", StrChargeDepartment)
                            myCommand1.Parameters.AddWithValue("@Supply_Charge_JobTitle", StrChargeJobTitle)
                            myCommand1.Parameters.AddWithValue("@Supply_Charge_CellPhone", StrChargeCellPhone09)
                            myCommand1.ExecuteNonQuery()
                            MsgBox("修改資料成功", vbInformation, "通知訊息")
                        End If
                    Else
                        MsgBox("無此筆統一編號資料!!!", vbCritical, "警告訊息")
                    End If
                End If
            End If
        End If
        Connection.Close()
        Supply_GetData()
        ClearText()
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
End Class