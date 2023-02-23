Imports System.Data.OleDb
Imports RSS_Access.Access_Connection
Public Class frmRSS_Access_FreightTransport
    Private Sub frmRSS_Access_FreightTransport_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim FTStr As String = "Select * From FreightTransport Order By ItemNo ASC"
        BindingSource1.DataSource = GetData(FTStr)
        DGVFT.DataSource = BindingSource1
        With DGVFT
            .BorderStyle = BorderStyle.FixedSingle
            .GridColor = Color.Black
            .AutoGenerateColumns = True
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .EnableHeadersVisualStyles = False
            .DefaultCellStyle.Font = New Font("標楷體", 16)
            .EditMode = DataGridViewEditMode.EditProgrammatically
            .Columns(0).HeaderText = "項次"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "統一編號"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "名稱"
            .Columns(2).Width = 200
            .Columns(3).HeaderText = "電話"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "傳真"
            .Columns(4).Width = 150
            .Columns(5).HeaderText = "地址"
            .Columns(5).Width = 300
            .Columns(6).HeaderText = "接洽人"
            .Columns(6).Width = 200
            .Columns(7).HeaderText = "手機號碼"
            .Columns(7).Width = 150
            .Columns(8).HeaderText = "E-Mail"
            .Columns(8).Width = 300
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .ColumnHeadersDefaultCellStyle.Font = New Font("標楷體", 18)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        TxtFreightTranspaort_Tax_ID.TextBox1.MaxLength = 8
        TxtFT_Co_PhoneNo.TextBox1.MaxLength = 8
        TxtFTFax.TextBox1.MaxLength = 8
        TxtFT_Charge_CellPhone.TextBox1.MaxLength = 8


    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim FTStr As String = "Select * From FreightTransport Where FT_Tax_ID=@FT_Tax_ID"
        Dim FTSelectComm As New OleDbCommand(FTStr, Connection)
        If TxtFreightTranspaort_Tax_ID.TextBox1.Text = "" Or
            Len(TxtFreightTranspaort_Tax_ID.TextBox1.Text) <> 8 Or
        IsNumeric(TxtFreightTranspaort_Tax_ID.TextBox1.Text) = False Then
            MsgBox("貨運公司統一編號不能空白且必須是8個數字", 0 + 48, "警告訊息")
        Else
            If TxtFreightTransportName.TextBox1.Text = "" Then
                MsgBox("貨運公司名稱不能空白", 0 + 48, "警告訊息")
            ElseIf CMBPhoneCode.Text = "請選擇區碼" Then
                MsgBox("電話號碼區碼需選擇", 0 + 48, "警告訊息")
            ElseIf TxtFT_Co_PhoneNo.TextBox1.Text = "" Or IsNumeric(TxtFT_Co_PhoneNo.TextBox1.Text) = False Then
                MsgBox("電話號碼不能空白且是數字", 0 + 48, "警告訊息")
            ElseIf CMBFaxCode.Text = "請選擇區碼" Then
                MsgBox("傳真號碼區碼需選擇", 0 + 48, "警告訊息")
            ElseIf TxtFTFax.TextBox1.Text = "" Or isnumeric(TxtFTFax.TextBox1.Text) = False Then
                MsgBox("傳真號碼不能空白且是數字", 0 + 48, "警告訊息")
            ElseIf TxtAddress.TextBox1.Text = "" Then
                MsgBox("地址不能空白", 0 + 48, "警告訊息")
            ElseIf TxtCharge.TextBox1.Text = "" Then
                MsgBox("接洽人不能空白", 0 + 48, "警告訊息")
            ElseIf TxtFT_Charge_CellPhone.TextBox1.Text = "" Or
                IsNumeric(TxtFT_Charge_CellPhone.TextBox1.Text) = False Then
                MsgBox("接洽人手機號碼不能空白且是數字", 0 + 48, "警告訊息")
            ElseIf TxtEMailHead.TextBox1.Text = "" Then
                MsgBox("Email帳號不能空白", 0 + 48, "警告訊息")
            ElseIf TxtEmailTail.TextBox1.Text = "" Then
                MsgBox("Email網域名稱不能空白", 0 + 48, "警告訊息")
            ElseIf CMBEmailDomain.Text = "" Then
                MsgBox("Email網域不能空白", 0 + 48, "警告訊息")
            Else
                If JugePhone() = False Then
                    MsgBox("電話號碼錯誤", 0 + 48, "警告訊息")
                ElseIf JugeFax = False Then
                    MsgBox("傳真號碼錯誤", 0 + 48, "警告訊息")
                ElseIf len(TxtFT_Charge_CellPhone.TextBox1.Text) <> 8 Then
                    MsgBox("手機號碼錯誤", 0 + 48, "警告訊息")
                Else
                    Connection.Open()
                    FTSelectComm.Parameters.AddWithValue("@FT_Tax_ID", TxtFreightTranspaort_Tax_ID.TextBox1.Text)
                    FTSelectComm.ExecuteNonQuery()
                    Dim FTReader As OleDbDataReader = FTSelectComm.ExecuteReader
                    If FTReader.HasRows Then
                        MsgBox("已有此筆資料", 0 + 48, "警告訊息")
                    Else
                        Dim InsertIntoStr As String = "Insert Into FreightTransport(FT_Tax_ID,FT_Name," &
                            "FT_Phone,FT_Fax,FT_Address,FT_Charge,FT_Charge_CellPhone,FT_Charge_Email" &
                            ")Values(@FT_Tax_ID,@FT_Name,@FT_Phone,@FT_Fax,@FT_Address,@FT_Charge," &
                            "@FT_Charge_CellPhone,@FT_Charge_Email)"
                        Dim InsertIntoComm As New OleDbCommand(InsertIntoStr, Connection)
                        Dim FTTaxIDStr As String = TxtFreightTranspaort_Tax_ID.TextBox1.Text
                        Dim FTNameStr As String = TxtFreightTransportName.TextBox1.Text
                        Dim FTPhoneStr As String = CMBPhoneCode.Text & TxtFT_Co_PhoneNo.TextBox1.Text
                        Dim FTFaxStr As String = CMBFaxCode.Text & TxtFTFax.TextBox1.Text
                        Dim FTAddressStr As String = TxtAddress.TextBox1.Text
                        Dim FTChargeStr As String = TxtCharge.TextBox1.Text
                        Dim FTChargeCellPhoneStr As String = "09" & TxtFT_Charge_CellPhone.TextBox1.Text
                        Dim FTChargeEmailStr As String = TxtEMailHead.TextBox1.Text & "@" & TxtEmailTail.TextBox1.Text & "." & CMBEmailDomain.Text
                        InsertIntoComm.Parameters.AddWithValue("@FT_Tax_ID", FTTaxIDStr)
                        InsertIntoComm.Parameters.AddWithValue("@FT_Name", FTNameStr)
                        InsertIntoComm.Parameters.AddWithValue("@FT_Phone", FTPhoneStr)
                        InsertIntoComm.Parameters.AddWithValue("@FT_Fax", FTFaxStr)
                        InsertIntoComm.Parameters.AddWithValue("@FT_Address", FTAddressStr)
                        InsertIntoComm.Parameters.AddWithValue("@FT_Charge", FTChargeStr)
                        InsertIntoComm.Parameters.AddWithValue("@FT_Charge_CellPhone", FTChargeCellPhoneStr)
                        InsertIntoComm.Parameters.AddWithValue("@FT_Charge_Email", FTChargeEmailStr)
                        InsertIntoComm.ExecuteNonQuery()
                        MsgBox("新增成功", 0 + 48, "通知訊息")
                    End If
                    Connection.Close()
                End If
            End If
        End If
    End Sub

    Private Sub TxtFreightTransportName_Enter(sender As Object, e As EventArgs) Handles TxtFreightTransportName.Enter

        Dim FTStr As String = "Select * From FreightTransport Where FT_Tax_ID=@FT_Tax_ID"
        Dim FTSelectComm As New OleDbCommand(FTStr, Connection)
        If TxtFreightTranspaort_Tax_ID.TextBox1.Text = "" Or
           Len(TxtFreightTranspaort_Tax_ID.TextBox1.Text) <> 8 Or
       IsNumeric(TxtFreightTranspaort_Tax_ID.TextBox1.Text) = False Then
            MsgBox("貨運公司統一編號只能8個數字", 0 + 48, "警告訊息")
        Else
            Connection.Open()
            FTSelectComm.Parameters.AddWithValue("@FT_Tax_ID", TxtFreightTranspaort_Tax_ID.TextBox1.Text)
            FTSelectComm.ExecuteNonQuery()
            Dim FTReader As OleDbDataReader = FTSelectComm.ExecuteReader
            If FTReader.HasRows Then
                While FTReader.Read
                    TxtFreightTransportName.TextBox1.Text = FTReader.Item(2).ToString
                    Dim code As String = Strings.Left(FTReader.Item(3).ToString, 3)
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
                            CMBPhoneCode.Text = Strings.Left(FTReader.Item(3).ToString, 2)
                    End Select
                    Dim i As Integer
                    i = Len(CMBPhoneCode.Text)
                    If i = 3 Then
                        TxtFT_Co_PhoneNo.TextBox1.Text = Strings.Right(FTReader.Item(3).ToString, 7)
                    Else
                        TxtFT_Co_PhoneNo.TextBox1.Text = Strings.Right(FTReader.Item(3).ToString, 8)
                    End If
                    Dim CodeFax As String = Strings.Left(FTReader.Item(4).ToString, 3)
                    Dim j As Integer = Len(CMBFaxCode.Text)
                    Select Case CodeFax
                        Case "037"
                            CMBFaxCode.Text = "037"
                        Case "049"
                            CMBFaxCode.Text = "049"
                        Case "082"
                            CMBFaxCode.Text = "082"
                        Case "089"
                            CMBFaxCode.Text = "089"
                        Case Else
                            CMBFaxCode.Text = Strings.Left(FTReader.Item(4).ToString, 2)
                    End Select
                    TxtAddress.TextBox1.Text = FTReader.Item(5).ToString
                    TxtCharge.TextBox1.Text = FTReader.Item(6).ToString
                    TxtFT_Charge_CellPhone.TextBox1.Text = Strings.Right(FTReader.Item(7).ToString, 8)
                    Dim strEmail = Strings.Split(FTReader.Item(8).ToString, "@")
                    TxtEMailHead.TextBox1.Text = strEmail(0)
                    Dim StrEmailtail = Strings.Split(strEmail(1), ".")
                    If StrEmailtail.Count = 2 Then
                        TxtEmailTail.TextBox1.Text = StrEmailtail(0)
                        CMBEmailDomain.Text = StrEmailtail(1)
                    ElseIf StrEmailtail.Count = 3 Then
                        TxtEmailTail.TextBox1.Text = StrEmailtail(0)
                        CMBEmailDomain.Text = StrEmailtail(1) & "." & StrEmailtail(2)
                    End If

                End While
                FTReader.Close()
            Else
                MsgBox("無此筆資料，請新增", 0 + 48, "警告訊息")
            End If

            Connection.Close()
        End If
    End Sub

    Private Sub TxtFT_Co_PhoneNo_Enter(sender As Object, e As EventArgs) Handles TxtFT_Co_PhoneNo.Enter
        If CMBPhoneCode.Text = "請選擇區碼" Then
            MsgBox("電話區碼需選擇", 0 + 48, "警告訊息")
        Else
            If Len(CMBPhoneCode.Text) = 3 Then
                TxtFT_Co_PhoneNo.TextBox1.MaxLength = 7
            ElseIf Len(CMBPhoneCode.Text) = 2 Then
                TxtFT_Co_PhoneNo.TextBox1.MaxLength = 8
            ElseIf CMBPhoneCode.Text = "02" Then
                If Strings.Left(TxtFT_Co_PhoneNo.TextBox1.Text, 3) = "412" Then
                    TxtFT_Co_PhoneNo.TextBox1.MaxLength = 7
                End If
            End If
        End If
    End Sub

    Private Sub TxtFTFax_Enter(sender As Object, e As EventArgs) Handles TxtFTFax.Enter
        If CMBFaxCode.Text = "請選擇區碼" Then
            MsgBox("電話區碼需選擇", 0 + 48, "警告訊息")
        Else
            If Len(CMBFaxCode.Text) = 3 Then
                TxtFTFax.TextBox1.MaxLength = 7
            ElseIf Len(CMBFaxCode.Text) = 2 Then
                TxtFTFax.TextBox1.MaxLength = 8
            ElseIf CMBFaxCode.Text = "02" Then
                If Strings.Left(TxtFTFax.TextBox1.Text, 3) = "412" Then
                    TxtFTFax.TextBox1.MaxLength = 7
                End If
            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim UpdateStr As String = "UPDATE FreightTransport Set " &
            "FT_Name=@FT_Name,FT_Phone=@FT_Phone,FT_Fax=@FT_Fax," &
            "FT_Address=FT_Address,FT_Charge=@FT_Charge," &
            "FT_Charge_CellPhone=@FT_Charge_CellPhone," &
            "FT_Charge_Email=@FT_Charge_Email " &
            "Where FT_Tax_ID=@FT_Tax_ID"
        Dim UpDateComm As New OleDbCommand(UpdateStr, Connection)
        Dim SelectStr As String = "Select * from FreightTransport where FT_Tax_ID=@FT_Tax_ID"
        Dim SelectComm As New OleDbCommand(SelectStr, Connection)
        If TxtFreightTranspaort_Tax_ID.TextBox1.Text = "" Or
            Len(TxtFreightTranspaort_Tax_ID.TextBox1.Text) <> 8 Or
        IsNumeric(TxtFreightTranspaort_Tax_ID.TextBox1.Text) = False Then
            MsgBox("貨運公司統一編號不能空白且必須是8個數字", 0 + 48, "警告訊息")
        Else
            If TxtFreightTransportName.TextBox1.Text = "" Then
                MsgBox("貨運公司名稱不能空白", 0 + 48, "警告訊息")
            ElseIf CMBPhoneCode.Text = "請選擇區碼" Then
                MsgBox("電話號碼區碼需選擇", 0 + 48, "警告訊息")
            ElseIf TxtFT_Co_PhoneNo.TextBox1.Text = "" Or IsNumeric(TxtFT_Co_PhoneNo.TextBox1.Text) = False Then
                MsgBox("電話號碼不能空白且是數字", 0 + 48, "警告訊息")
            ElseIf CMBFaxCode.Text = "請選擇區碼" Then
                MsgBox("傳真號碼區碼需選擇", 0 + 48, "警告訊息")
            ElseIf TxtFTFax.TextBox1.Text = "" Or IsNumeric(TxtFTFax.TextBox1.Text) = False Then
                MsgBox("傳真號碼不能空白且必須是數字", 0 + 48, "警告訊息")
            ElseIf TxtAddress.TextBox1.Text = "" Then
                MsgBox("地址不能空白", 0 + 48, "警告訊息")
            ElseIf TxtCharge.TextBox1.Text = "" Then
                MsgBox("接洽人不能空白", 0 + 48, "警告訊息")
            ElseIf TxtFT_Charge_CellPhone.TextBox1.Text = "" Or
                IsNumeric(TxtFT_Charge_CellPhone.TextBox1.Text) = False Then
                MsgBox("接洽人手機號碼不能空白且是數字", 0 + 48, "警告訊息")
            ElseIf TxtEMailHead.TextBox1.Text = "" Then
                MsgBox("Email帳號不能空白", 0 + 48, "警告訊息")
            ElseIf TxtEmailTail.TextBox1.Text = "" Then
                MsgBox("Email網域名稱不能空白", 0 + 48, "警告訊息")
            ElseIf CMBEmailDomain.Text = "" Then
                MsgBox("Email網域不能空白", 0 + 48, "警告訊息")
            Else
                If JugePhone() = False Then
                    MsgBox("電話號碼錯誤", 0 + 48, "警告訊息")
                ElseIf JugeFax() = False Then
                    MsgBox("傳真號碼錯誤", 0 + 48, "警告訊息")
                ElseIf Len(TxtFT_Charge_CellPhone.TextBox1.Text) <> 8 Then
                    MsgBox("手機號碼必須是8個數字", 0 + 48, "警告訊息")
                Else
                    Connection.Open()

                    Dim FTTaxIDStr As String = TxtFreightTranspaort_Tax_ID.TextBox1.Text
                    Dim FTNameStr As String = TxtFreightTransportName.TextBox1.Text
                    Dim FTPhoneStr As String = CMBPhoneCode.Text & TxtFT_Co_PhoneNo.TextBox1.Text
                    Dim FTFaxStr As String = CMBFaxCode.Text & TxtFTFax.TextBox1.Text
                    Dim FTAddressStr As String = TxtAddress.TextBox1.Text
                    Dim FTChargeStr As String = TxtCharge.TextBox1.Text
                    Dim FTChargeCellPhoneStr As String = "09" & TxtFT_Charge_CellPhone.TextBox1.Text
                    Dim FTChargeEmailStr As String = TxtEMailHead.TextBox1.Text & "@" & TxtEmailTail.TextBox1.Text & "." & CMBEmailDomain.Text
                    SelectComm.Parameters.AddWithValue("@FT_Tax_ID", FTTaxIDStr)
                    SelectComm.ExecuteNonQuery()
                    Dim FTReader As OleDbDataReader = SelectComm.ExecuteReader
                    If FTReader.HasRows Then
                        UpDateComm.Parameters.AddWithValue("@FT_Tax_ID", FTTaxIDStr)
                        UpDateComm.Parameters.AddWithValue("@FT_Name", FTNameStr)
                        UpDateComm.Parameters.AddWithValue("@FT_Phone", FTPhoneStr)
                        UpDateComm.Parameters.AddWithValue("@FT_Fax", FTFaxStr)
                        UpDateComm.Parameters.AddWithValue("@FT_Address", FTAddressStr)
                        UpDateComm.Parameters.AddWithValue("@FT_Charge", FTChargeStr)
                        UpDateComm.Parameters.AddWithValue("@FT_Charge_CellPhone", FTChargeCellPhoneStr)
                        UpDateComm.Parameters.AddWithValue("@FT_Charge_Email", FTChargeEmailStr)
                        UpDateComm.ExecuteNonQuery()
                        MsgBox("更新成功", 0 + 48, "通知訊息")
                    Else
                        MsgBox("無此筆資料請新增", 0 + 48, "警告訊息")
                    End If
                    Connection.Close()
                End If
            End If
        End If
    End Sub

    Private Function JugePhone() As Boolean
        If Len(CMBPhoneCode.Text) = 3 And Len(TxtFT_Co_PhoneNo.TextBox1.Text) = 7 Then
            Return True
        ElseIf Len(CMBPhoneCode.Text) = 2 And Len(TxtFT_Co_PhoneNo.TextBox1.Text) = 8 Then
            Return True
        ElseIf CMBPhoneCode.Text = "02" And Strings.Left(TxtFT_Co_PhoneNo.TextBox1.Text, 3) = "412" And Len(TxtFT_Co_PhoneNo.TextBox1.Text) = 7 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function JugeFax() As Boolean
        If Len(CMBFaxCode.Text) = 3 And Len(TxtFTFax.TextBox1.Text) = 7 Then
            Return True
        ElseIf Len(CMBFaxCode.Text) = 2 And Len(TxtFTFax.TextBox1.Text) = 8 Then
            Return True
        ElseIf CMBFaxCode.Text = "02" And Strings.Left(TxtFTFax.TextBox1.Text, 3) = "412" And Len(TxtFTFax.TextBox1.Text) = 7 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim SelectStr As String = "Select * from FreightTransport where FT_Tax_ID=@FT_Tax_ID"
        Dim FTSelectComm As New OleDbCommand(SelectStr, Connection)
        Dim DelStr As String = "Delete From FreightTransport Where FT_Tax_ID=@FT_Tax_ID"
        Dim DeleteComm As New OleDbCommand(DelStr, Connection)
        Dim FTTaxIDstr As String = TxtFreightTranspaort_Tax_ID.TextBox1.Text
        Connection.Open()
        FTSelectComm.Parameters.AddWithValue("@FT_Tax_ID", FTTaxIDstr)
        FTSelectComm.ExecuteNonQuery()
        Dim FTReader As OleDbDataReader = FTSelectComm.ExecuteReader
        If FTTaxIDstr <> "" And IsNumeric(FTTaxIDstr) And Len(FTTaxIDstr) = 8 Then
            If FTReader.HasRows Then
                Dim x = MsgBox("確定要刪除此筆資料嗎?", 4 + 48, "警告訊息")
                If x = 6 Then
                    DeleteComm.Parameters.AddWithValue("@FT_Tax_ID", FTTaxIDstr)
                    DeleteComm.ExecuteNonQuery()
                    MsgBox("刪除資料成功!!!", 0 + 48, "通知訊息")
                End If
            Else
                MsgBox("無此筆資料!!!", 0 + 48, "警告訊息!!!")
            End If
        Else
            MsgBox("貨運公司統編不能空白且必須是8個數字", 0 + 48, "警告訊息")
        End If
        Connection.Close()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtFreightTranspaort_Tax_ID.TextBox1.Text = ""
        TxtFreightTransportName.TextBox1.Text = ""
        CMBPhoneCode.Text = "請選擇區碼"
        TxtFT_Co_PhoneNo.TextBox1.Text = ""
        CMBFaxCode.Text = "請選擇區碼"
        TxtFTFax.TextBox1.Text = ""
        TxtAddress.TextBox1.Text = ""
        TxtCharge.TextBox1.Text = ""
        TxtFT_Charge_CellPhone.TextBox1.Text = ""
        TxtEMailHead.TextBox1.Text = ""
        TxtEmailTail.TextBox1.Text = ""
        CMBEmailDomain.Text = ""
    End Sub

    Private Sub TxtFT_Co_PhoneNo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFT_Co_PhoneNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CMBPhoneCode.Text = "02" And Strings.Left(TxtFT_Co_PhoneNo.TextBox1.Text, 3) = "412" Then
                TxtFT_Co_PhoneNo.TextBox1.MaxLength = 7
            End If
        End If
    End Sub
End Class