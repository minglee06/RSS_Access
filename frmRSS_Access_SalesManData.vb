Imports System.Data.OleDb
Public Class frmRSS_Access_SalesManData
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = Now
    End Sub

    Private Sub frmRSS_Access_SalesManData_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtSalesManID.TextBox1.MaxLength = 4
        TxtCellphone.TextBox1.MaxLength = 8
        TxtDepartment.TextBox1.MaxLength = 20
        TxtSalesManName.TextBox1.MaxLength = 20
        TxtAddress.TextBox1.MaxLength = 255
        Sales_GetData()
        Sales_Employee_GetMaxID()
    End Sub


    Private Sub DGVSalesMan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSalesMan.CellClick
        Try
            If DGVSalesMan.Rows.Count > 0 Then
                TxtSalesManID.TextBox1.Text = DGVSalesMan.CurrentRow.Cells(0).Value
                TxtDepartment.TextBox1.Text = DGVSalesMan.CurrentRow.Cells(1).Value
                TxtSalesManName.TextBox1.Text = DGVSalesMan.CurrentRow.Cells(2).Value
                TxtCellphone.TextBox1.Text = Strings.Right(DGVSalesMan.CurrentRow.Cells(3).Value, 8)
                TxtAddress.TextBox1.Text = DGVSalesMan.CurrentRow.Cells(4).Value
            End If
        Catch ex As Exception
            MessageBox.Show("請選有資料的列位，你點選的位置超過列數", "注意!選擇列位超過範圍", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub TxtDepartment_Enter(sender As Object, e As EventArgs) Handles TxtDepartment.Enter
        Dim myConn As New OleDbConnection(Access_Connection.ConnStr)
        myConn.Open()
        Dim mySelStr As String = "SELECT * FROM Sales_Employee WHERE SalesID =@SalesID"
        Dim myComm As New OleDbCommand(mySelStr, myConn)
        Dim myID As String = TxtSalesManID.TextBox1.Text
        myComm.Parameters.AddWithValue("@SalesID", myID)
        myComm.ExecuteNonQuery()
        Dim myReader As OleDbDataReader = myComm.ExecuteReader
        If myReader.HasRows Then
            While myReader.Read
                TxtDepartment.TextBox1.Text = myReader.Item("Department").ToString
                TxtSalesManName.TextBox1.Text = myReader.Item("Employee_Name").ToString
                TxtCellphone.TextBox1.Text = Strings.Right(myReader.Item("CellPhoneNo").ToString, 8)
                TxtAddress.TextBox1.Text = myReader.Item("Address").ToString
            End While
        Else
            MsgBox("無此資料，請新增", vbInformation, "請新增資料")
        End If
        myConn.Close()
    End Sub
    Private Sub Sales_GetData()
        BindingSource1.DataSource = Access_Connection.GetData("Select * from Sales_Employee Order By SalesID ASC")
        DGVSalesMan.DataSource = BindingSource1
        With DGVSalesMan
            .ReadOnly = True
            .DataSource = BindingSource1
            .AutoGenerateColumns = True
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            '.ColumnHeadersBorderStyle = 0
            .DefaultCellStyle.Font = New Font("標楷體", 20)
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
            .EnableHeadersVisualStyles = False
            .EditMode = DataGridViewEditMode.EditOnEnter
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

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ClearText()
    End Sub

    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles BtnModify.Click
        Dim myConn As New OleDbConnection(Access_Connection.ConnStr)
        myConn.Open()
        Dim myId As String = TxtSalesManID.TextBox1.Text
        Dim myDe As String = TxtDepartment.TextBox1.Text
        Dim myEN As String = TxtSalesManName.TextBox1.Text
        Dim myPhone As String = TxtCellphone.TextBox1.Text
        Dim myPhone09 As String = "09" + TxtCellphone.TextBox1.Text
        Dim myAddR As String = TxtAddress.TextBox1.Text

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
            If IsNumeric(myId) = False Or Len(myId) <> 4 Then
                MessageBox.Show("輸入格式錯誤，編號只能4個數字", "注意!!編號輸入格是錯誤", MessageBoxButtons.OK)
            Else
                If IsNumeric(myPhone) = True And Len(myPhone) = 8 Then
                    Dim SelStr As String = "SELECT * FROM Sales_Employee WHERE SalesID=@SalesID"
                    Dim myComm As New OleDbCommand(SelStr, myConn)
                    myComm.Parameters.AddWithValue("@SalesID", myId)
                    myComm.ExecuteNonQuery()
                    Dim myReader As OleDbDataReader = myComm.ExecuteReader
                    If myReader.HasRows Then
                        While myReader.Read
                            Dim x = MsgBox("確定要修改此筆資料?", 4 + 48, "注意!!修改此筆資料")
                            If x = 6 Then
                                Dim myUpdateStr As String = "UPDATE Sales_Employee SET SalesID=@SalesID,Department=@Department,Employee_Name=@Employee_Name,CellPhoneNo=@CellPhoneNo,Address=@Address WHERE SalesID=@SalesID"
                                Dim myComm1 As New OleDbCommand(myUpdateStr, myConn)
                                myComm1.Parameters.AddWithValue("@salesID", myId)
                                myComm1.Parameters.AddWithValue("@Department", myDe)
                                myComm1.Parameters.AddWithValue("@Employee_Name", myEN)
                                myComm1.Parameters.AddWithValue("@CellPhoneNo", myPhone09)
                                myComm1.Parameters.AddWithValue("@Address", myAddR)
                                myComm1.ExecuteNonQuery()
                                ' MessageBox.Show("刪除資料完畢", "", MessageBoxButtons.OK)
                                MsgBox("更新資料完畢", vbInformation, "更新資料")
                            End If
                        End While
                        myReader.Close()
                    Else
                        MsgBox("無資料，請新增資料", vbInformation, "無資料")
                    End If
                End If
            End If
        End If
        myConn.Close()
        Sales_GetData()
        ClearText()
        Sales_Employee_GetMaxID()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim myConn As New OleDbConnection(Access_Connection.ConnStr)
        Dim SalesIDStr As String = TxtSalesManID.TextBox1.Text
        myConn.Open()

        If SalesIDStr = "" Then
            MessageBox.Show("編號請輸入資料，不能空白!!!", "注意!!編號不能空白", MessageBoxButtons.OK)
        Else
            Dim SelStr As String = "SELECT * FROM Sales_Employee WHERE SalesID =@SalesID"
            Dim myComm As New OleDbCommand(SelStr, myConn)
            myComm.Parameters.AddWithValue("@SalesID", SalesIDStr)
            myComm.ExecuteNonQuery()
            Dim myReader As OleDbDataReader = myComm.ExecuteReader

            If myReader.HasRows Then

                Dim x = MsgBox("確定要刪除此筆資料?", 4 + 48, "注意!!刪除此筆資料")
                If x = 6 Then
                    Dim myDelStr As String = "DELETE FROM Sales_Employee WHERE SalesID=@SalesID"
                    Dim myComm1 As New OleDbCommand(myDelStr, myConn)
                    myComm1.Parameters.AddWithValue("@SalesID", SalesIDStr)
                    myComm1.ExecuteNonQuery()
                    MsgBox("刪除資料完畢", vbInformation, "刪除資料")
                End If
            Else
                MsgBox("無此筆資料", vbCritical, "警告訊息")
            End If
        End If
        myConn.Close()
        Sales_GetData()
        ClearText()
        Sales_Employee_GetMaxID()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ' Dim myConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\RSS_Access\myBin\App_Data\RSS_Access.mdb;Persist Security Info=True"
        Dim myConn As New OleDbConnection(Access_Connection.ConnStr)
        myConn.Open()
        Dim myId As String = TxtSalesManID.TextBox1.Text
        Dim myDe As String = TxtDepartment.TextBox1.Text
        Dim myEN As String = TxtSalesManName.TextBox1.Text
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
            If IsNumeric(myId) = False Or Len(myId) <> 4 Then
                MessageBox.Show("編號只能輸入4個數字", "注意!!編號輸入格式錯誤", MessageBoxButtons.OK)
            Else
                If IsNumeric(myPhone) = True And Len(myPhone) = 8 Then
                    Dim myInsertStr As String = "INSERT INTO Sales_Employee(SalesID,Department,Employee_Name,CellPhoneNO,Address) VALUES(@SalesID,@Department,@Employee_Name,@CellPhoneNO,@Address)"
                    Dim myComm As New OleDbCommand(myInsertStr, myConn)
                    myComm.Parameters.AddWithValue("@SalesID", myId)
                    myComm.Parameters.AddWithValue("@Department", myDe)
                    myComm.Parameters.AddWithValue("@Employee_Name", myEN)
                    myComm.Parameters.AddWithValue("@CellPhoneNO", myPhone09)
                    myComm.Parameters.AddWithValue("@Address", myAddR)
                    Try
                        myComm.ExecuteNonQuery()
                        MessageBox.Show("新增成功", "新增資料", MessageBoxButtons.OK)
                    Catch ex As Exception
                        ' MessageBox.Show(ex.Message, "注意!!編號不能重複", MessageBoxButtons.OK)
                        MsgBox("注意!!編號不能重複", vbCritical, "注意!!編號不能重複")
                        TxtSalesManID.Focus()
                    End Try
                Else
                    ' MessageBox.Show("手機號碼只能是數字", "注意!!手機號碼輸入格式錯誤", MessageBoxButtons.OK)
                    MsgBox("手機號碼只能是數字!!!", vbCritical, "警告訊息")
                End If
            End If
        End If

        myConn.Close()
        Sales_GetData()
        ClearText()
        Sales_Employee_GetMaxID()
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
    Private Sub Sales_Employee_GetMaxID()
        Dim myConnStr As String = Access_Connection.ConnStr
        Dim myConn As New OleDbConnection(myConnStr)
        myConn.Open()
        Dim mySelectStr As String = "Select SalesID from Sales_Employee Order By SalesID"
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
                TxtSalesManID.TextBox1.Text = "000" + Convert.ToString(i)
            ElseIf Len(Convert.ToString(i)) = 2 Then
                TxtSalesManID.TextBox1.Text = "00" + Convert.ToString(i)
            ElseIf Len(Convert.ToString(i)) = 3 Then
                TxtSalesManID.TextBox1.Text = "0" + Convert.ToString(i)
            ElseIf Len(Convert.ToString(i)) = 4 Then
                TxtSalesManID.TextBox1.Text = Convert.ToString(i)
            End If
        Else
            TxtSalesManID.TextBox1.Text = "0001"
        End If
        myConn.Close()
    End Sub
    Private Sub ClearText()
        TxtSalesManID.TextBox1.Text = ""
        TxtDepartment.TextBox1.Text = ""
        TxtSalesManName.TextBox1.Text = ""
        TxtCellphone.TextBox1.Text = ""
        TxtAddress.TextBox1.Text = ""
    End Sub
End Class