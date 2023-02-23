Imports System.Data.OleDb

Public Class frmRSS_Access_Purchaser
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = Now

    End Sub

    Private Sub frmRSS_Access_Purchaser_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtPurchaserID.TextBox1.MaxLength = 4
        TxtCellphone.TextBox1.MaxLength = 8
        TxtDepartment.TextBox1.MaxLength = 20
        TxtPurchaserName.TextBox1.MaxLength = 20
        TxtAddress.TextBox1.MaxLength = 255
        DateTimePicker1.BackColor = Color.AliceBlue
        Purchaser_Employee_GetMaxID()
        Purchaser_GetData()
    End Sub

    Private Sub DGVPurChaser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPurChaser.CellClick
        Try
            If DGVPurChaser.Rows.Count > 0 Then
                TxtPurchaserID.TextBox1.Text = DGVPurChaser.CurrentRow.Cells(0).Value
                TxtDepartment.TextBox1.Text = DGVPurChaser.CurrentRow.Cells(1).Value
                TxtPurchaserName.TextBox1.Text = DGVPurChaser.CurrentRow.Cells(2).Value
                TxtCellphone.TextBox1.Text = Strings.Right(DGVPurChaser.CurrentRow.Cells(3).Value, 8)
                TxtAddress.TextBox1.Text = DGVPurChaser.CurrentRow.Cells(4).Value
            End If
        Catch ex As Exception
            MessageBox.Show("請選有資料的列位，你點選的位置超過列數", "注意!選擇列位超過範圍", MessageBoxButtons.OK)

        End Try

    End Sub

    Private Sub TxtDepartment_Enter(sender As Object, e As EventArgs) Handles TxtDepartment.Enter
        Dim myConn As New OleDbConnection(Access_Connection.ConnStr)
        myConn.Open()
        Dim mySelStr As String = "SELECT * FROM Purchaser_Employee WHERE PurID =@PurID"
        Dim myComm As New OleDbCommand(mySelStr, myConn)
        Dim myID As String = TxtPurchaserID.TextBox1.Text
        myComm.Parameters.AddWithValue("@PurID", myID)
        myComm.ExecuteNonQuery()
        Dim myReader As OleDbDataReader = myComm.ExecuteReader
        If myReader.HasRows Then
            While myReader.Read
                TxtDepartment.TextBox1.Text = myReader.Item("Department").ToString
                TxtPurchaserName.TextBox1.Text = myReader.Item("Employee_Name").ToString
                TxtCellphone.TextBox1.Text = Strings.Right(myReader.Item("CellPhoneNo").ToString, 8)
                TxtAddress.TextBox1.Text = myReader.Item("Address").ToString
            End While
            myReader.Close()
        Else
            MsgBox("無此資料，請新增", 0 + 48, "警告訊息")
        End If
        myConn.Close()
    End Sub
    Private Sub Purchaser_GetData()
        BindingSource1.DataSource = Access_Connection.GetData("Select * from Purchaser_Employee Order By PurID ASC")
        DGVPurChaser.DataSource = BindingSource1
        With DGVPurChaser
            .ReadOnly = True
            .AutoGenerateColumns = True
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            '.ColumnHeadersBorderStyle = 0
            .DefaultCellStyle.Font = New Font("標楷體", 20)
            .EditMode = DataGridViewEditMode.EditProgrammatically
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
            .EnableHeadersVisualStyles = False
            .Columns(0).HeaderText = "編號"
            .Columns(1).HeaderText = "部門"
            .Columns(2).HeaderText = "員工姓名"
            .Columns(3).HeaderText = "手機號碼"
            .Columns(4).HeaderText = "地址"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .ColumnHeadersDefaultCellStyle.Font = New Font("標楷體", 20)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Dim myConn As New OleDbConnection(Access_Connection.ConnStr)
        myConn.Open()
        Dim myId As String = TxtPurchaserID.TextBox1.Text
        Dim myDe As String = TxtDepartment.TextBox1.Text
        Dim myEN As String = TxtPurchaserName.TextBox1.Text
        Dim myPhone As String = TxtCellphone.TextBox1.Text
        Dim myPhone09 As String = "09" + TxtCellphone.TextBox1.Text
        Dim myAddR As String = TxtAddress.TextBox1.Text

        '判別 TxtPurchaserID，TxtDepartment，TxtPurchaserName，TxtCellphone，TxtAddress 不能空白

        If myId = "" Then
            MessageBox.Show("編號不能空白", "注意!!編號不能空白", MessageBoxButtons.OK)
        ElseIf myDe = "" Then
            MessageBox.Show("部門不能空白", "注意!!部門不能空白", MessageBoxButtons.OK)
        ElseIf myEN = "" Then
            MessageBox.Show("姓名不能空白", "注意!!姓名不能空白", MessageBoxButtons.OK)
        ElseIf myPhone = "" Then
            MessageBox.Show("手機號碼不能空白", "注意!!手機號碼不能空白", MessageBoxButtons.OK)
        ElseIf myAddR = "" Then
            MessageBox.Show("地址不能空白", "注意!!地址不能空白", MessageBoxButtons.OK)
        Else
            If IsNumeric(myId) = False And Len(myId) <> 4 Then
                MsgBox("編號只能輸入4個數字!!!", 0 + 48, "警告訊息")

            ElseIf IsNumeric(myPhone) = False And Len(myPhone) <> 8 Then
                MsgBox("手機號碼只能是數字!!!", 0 + 48, "警告訊息")
            Else
                Dim myStr As String = "SELECT PurID from Purchaser_Employee Where PurID=@PurID"
                Dim myComm1 As New OleDbCommand(myStr, myConn)
                myComm1.Parameters.AddWithValue("@PurID", myId)
                myComm1.ExecuteNonQuery()
                Dim myReader As OleDbDataReader = myComm1.ExecuteReader
                If myReader.HasRows Then
                    MsgBox("已有此筆資料，無法新增!!!", 0 + 48, "警告訊息")
                    TxtPurchaserID.Focus()

                Else
                    Dim myInsertStr As String = "INSERT INTO Purchaser_Employee(PurID,Department,Employee_Name,CellPhoneNO,Address) VALUES(@PurID,@Department,@Employee_Name,@CellPhoneNO,@Address)"
                    Dim myComm As New OleDbCommand(myInsertStr, myConn)
                    myComm.Parameters.AddWithValue("@PurID", myId)
                    myComm.Parameters.AddWithValue("@Department", myDe)
                    myComm.Parameters.AddWithValue("@Employee_Name", myEN)
                    myComm.Parameters.AddWithValue("@CellPhoneNO", myPhone09)
                    myComm.Parameters.AddWithValue("@Address", myAddR)
                    myComm.ExecuteNonQuery()
                    MsgBox("新增資料成功!!!", 0 + 48, "通知訊息")
                End If
            End If
        End If
        myConn.Close()
        Purchaser_GetData()
        ClearText()
        Purchaser_Employee_GetMaxID()
    End Sub

    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles BtnModify.Click
        Dim myConn As New OleDbConnection(Access_Connection.ConnStr)
        myConn.Open()
        Dim myId As String = TxtPurchaserID.TextBox1.Text
        Dim myDe As String = TxtDepartment.TextBox1.Text
        Dim myEN As String = TxtPurchaserName.TextBox1.Text
        Dim myPhone As String = TxtCellphone.TextBox1.Text
        Dim myPhone09 As String = "09" + TxtCellphone.TextBox1.Text
        Dim myAddR As String = TxtAddress.TextBox1.Text
        'Dim PurIDStr As String = TxtPurchaserID.TextBox1.Text
        If myId = "" Then
            MessageBox.Show("注意!!編號不能空白", "編號不能空白", MessageBoxButtons.OK)
        ElseIf myDe = "" Then
            MessageBox.Show("注意!!部門不能空白", "部門不能空白", MessageBoxButtons.OK)
        ElseIf myEN = "" Then
            MessageBox.Show("注意!!姓名不能空白", "姓名不能空白", MessageBoxButtons.OK)
        ElseIf myPhone = "" Then
            MessageBox.Show("注意!!手機號碼不能空白", "手機號碼不能空白", MessageBoxButtons.OK)
        ElseIf myAddR = "" Then
            MessageBox.Show("注意!!地址不能空白", "地址不能空白", MessageBoxButtons.OK)
        Else
            If IsNumeric(myId) = False And Len(myId) <> 4 Then
                MsgBox("編號只能輸入4個數字!!!", 0 + 48, "警告訊息")

            ElseIf IsNumeric(myPhone) = False And Len(myPhone) <> 8 Then
                MsgBox("手機號碼只能是數字!!!", 0 + 48, "警告訊息")
            Else
                Dim SelStr As String = "SELECT * FROM Purchaser_Employee WHERE PurID=@PurID"
                Dim myComm As New OleDbCommand(SelStr, myConn)
                myComm.Parameters.AddWithValue("@PurID", myId)
                myComm.ExecuteNonQuery()
                Dim myReader As OleDbDataReader = myComm.ExecuteReader
                If myReader.HasRows Then
                    While myReader.Read
                        Dim x = MsgBox("確定要修改此筆資料?", 4 + 48, "警告訊息")
                        If x = 6 Then
                            Dim myUpdateStr As String = "UPDATE Purchaser_Employee SET PurID=@PurID,Department=@Department,Employee_Name=@Employee_Name,CellPhoneNo=@CellPhoneNo,Address=@Address WHERE PurID=@PurID"
                            Dim myComm1 As New OleDbCommand(myUpdateStr, myConn)
                            myComm1.Parameters.AddWithValue("@PurID", myId)
                            myComm1.Parameters.AddWithValue("@Department", myDe)
                            myComm1.Parameters.AddWithValue("@Employee_Name", myEN)
                            myComm1.Parameters.AddWithValue("@CellPhoneNo", myPhone09)
                            myComm1.Parameters.AddWithValue("@Address", myAddR)
                            myComm1.ExecuteNonQuery()
                            MsgBox("更新資料完畢", 0 + 48, "更新資料")
                        End If
                    End While
                    myReader.Close()
                Else
                    MsgBox("無此資料!!!", 0 + 48, "警告訊息")
                End If
            End If
        End If
        myConn.Close()
        Purchaser_GetData()
        ClearText()
        Purchaser_Employee_GetMaxID()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ClearText()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim myConn As New OleDbConnection(Access_Connection.ConnStr)
        Dim PurIDStr As String = TxtPurchaserID.TextBox1.Text
        myConn.Open()
        If PurIDStr = "" Then
            MessageBox.Show("編號請輸入資料，不能空白!!!", "注意!!編號不能空白", MessageBoxButtons.OK)
        Else
            Dim SelStr As String = "SELECT * FROM Purchaser_Employee WHERE PurID =@PurID"
            Dim myComm As New OleDbCommand(SelStr, myConn)
            myComm.Parameters.AddWithValue("@PurID", PurIDStr)
            myComm.ExecuteNonQuery()
            Dim myReader As OleDbDataReader = myComm.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    Dim x = MsgBox("確定要刪除此筆資料?", 4 + 48, "警告訊息")
                    If x = 6 Then
                        Dim myDelStr As String = "DELETE FROM Purchaser_Employee WHERE PurID=@PurID"
                        Dim myComm1 As New OleDbCommand(myDelStr, myConn)
                        myComm1.Parameters.AddWithValue("@PurID", PurIDStr)
                        myComm1.ExecuteNonQuery()
                        MsgBox("刪除資料完畢", 0 + 48, "通知訊息")
                    End If
                End While
                myReader.Close()
            Else
                MsgBox("無此筆資料，請新增資料!!!", 0 + 48, "警告訊息")
            End If
        End If
        myConn.Close()
        Purchaser_GetData()
        ClearText()
        Purchaser_Employee_GetMaxID()
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

    Private Sub ClearText()
        TxtPurchaserID.TextBox1.Text = ""
        TxtDepartment.TextBox1.Text = ""
        TxtPurchaserName.TextBox1.Text = ""
        TxtCellphone.TextBox1.Text = ""
        TxtAddress.TextBox1.Text = ""
    End Sub
    Private Sub Purchaser_Employee_GetMaxID()
        Dim myConnStr As String = Access_Connection.ConnStr
        Dim myConn As New OleDbConnection(myConnStr)
        myConn.Open()
        Dim mySelectStr As String = "Select PurID from Purchaser_Employee Order By PurID"
        Dim myComm As New OleDbCommand(mySelectStr, myConn)
        myComm.ExecuteNonQuery()
        Dim myReader As OleDbDataReader = myComm.ExecuteReader
        Dim myStrID As String
        Dim i As Integer
        If myReader.HasRows Then
            While myReader.Read
                myStrID = myReader.Item(0).ToString
                i = Convert.ToInt32(myStrID)
            End While
            myReader.Close()
            i += 1
            If Len(Convert.ToString(i)) = 1 Then
                TxtPurchaserID.TextBox1.Text = "000" + Convert.ToString(i)
            ElseIf Len(Convert.ToString(i)) = 2 Then
                TxtPurchaserID.TextBox1.Text = "00" + Convert.ToString(i)
            ElseIf Len(Convert.ToString(i)) = 3 Then
                TxtPurchaserID.TextBox1.Text = "0" + Convert.ToString(i)
            ElseIf Len(Convert.ToString(i)) = 4 Then
                TxtPurchaserID.TextBox1.Text = Convert.ToString(i)
            End If
        Else
            TxtPurchaserID.TextBox1.Text = "0001"
        End If
        myConn.Close()
    End Sub
End Class