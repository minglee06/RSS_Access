Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Public Class frmRSS_Access_Commodity_Classification
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = Now
    End Sub

    Private Sub frmRSS_Access_Commodity_Classification_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtCommodity_TypeID.TextBox1.MaxLength = 4
        TxtCommodity_Type_Name.TextBox1.MaxLength = 10
        TxtCommodity_Type_Description.TextBox1.MaxLength = 200
        Commodity_Classification_GetMaxTypeID()
        Commodity_Classification_GetData()
    End Sub
    Private Sub Commodity_Classification_GetData()
        Dim mySelectStr As String = "SELECT * FROM Commodity_Classification ORDER BY Commodity_Type_ID ASC"
        BindingSource1.DataSource = Access_Connection.GetData(mySelectStr)
        DGVCommodity_Classification.DataSource = BindingSource1
        With DGVCommodity_Classification
            .ReadOnly = True
            .AutoGenerateColumns = True
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            '.ColumnHeadersBorderStyle = 0
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
            .EnableHeadersVisualStyles = False
            .DefaultCellStyle.Font = New Font("標楷體", 20)
            .EditMode = DataGridViewEditMode.EditProgrammatically
            .Columns(0).HeaderText = "編號"
            .Columns(1).HeaderText = "分類名稱"
            .Columns(2).HeaderText = "分類說明"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .ColumnHeadersDefaultCellStyle.Font = New Font("標楷體", 20)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim MyConnStr As String = Access_Connection.ConnStr
        Dim InsertIntoStr As String = "Insert Into Commodity_Classification values(@Commodity_Type_ID,@Commodity_Classification_Type,@Commodity_Cassification_Description)"
        Dim SelectStr As String = "Select Commodity_Type_ID from Commodity_Classification Where Commodity_Type_ID=@Commodity_Type_ID"
        Dim myConn As New OleDbConnection(MyConnStr)
        myConn.Open()
        Dim ClassificationID As String = TxtCommodity_TypeID.TextBox1.Text
        Dim ClassificationType As String = TxtCommodity_Type_Name.TextBox1.Text
        Dim ClassificationDescription As String = TxtCommodity_Type_Description.TextBox1.Text
        Dim myComm As New OleDbCommand(InsertIntoStr, myConn)
        Dim myComm1 As New OleDbCommand(SelectStr, myConn)
        If ClassificationID = "" Then
            MsgBox("編號不能空白!!!", 0 + 48, "警告訊息")
            TxtCommodity_TypeID.Focus()
        ElseIf ClassificationType = "" Then
            MsgBox("名稱不能空白!!!", 0 + 48, "警告訊息")
            TxtCommodity_Type_Name.Focus()
        ElseIf ClassificationDescription = "" Then
            MsgBox("說明不能空白!!!", 0 + 48, "警告訊息")
            TxtCommodity_Type_Description.Focus()
        Else
            If IsNumeric(ClassificationID) = False Or Len(ClassificationID) <> 4 Then
                MsgBox("編號只能輸入4個數字!!!", 0 + 48, "警告訊息")
                TxtCommodity_TypeID.Focus()
            Else
                myComm1.Parameters.AddWithValue("@Commodity_Type_ID", ClassificationID)
                myComm1.ExecuteNonQuery()
                Dim myReader As OleDbDataReader = myComm1.ExecuteReader
                If myReader.HasRows Then
                    MsgBox("已有此筆資料，無法新增!!!", 0 + 48, "警告訊息")
                    TxtCommodity_TypeID.Focus()
                    ClearText()
                Else
                    myComm.Parameters.AddWithValue("@Commodity_Type_ID", ClassificationID)
                    myComm.Parameters.AddWithValue("@Commodity_Classification_Type", ClassificationType)
                    myComm.Parameters.AddWithValue("@Commodity_Cassification_Description", ClassificationDescription)
                    myComm.ExecuteNonQuery()
                    MsgBox("新增資料成功", 0 + 48, "通知訊息")
                End If
            End If
        End If
        myConn.Close()
        ClearText()
        Commodity_Classification_GetMaxTypeID()
        Commodity_Classification_GetData()
    End Sub
    Private Sub ClearText()
        TxtCommodity_TypeID.TextBox1.Text = ""
        TxtCommodity_Type_Name.TextBox1.Text = ""
        TxtCommodity_Type_Description.TextBox1.Text = ""
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ClearText()
    End Sub

    Private Sub DGVCommodity_Classification_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCommodity_Classification.CellClick
        Try
            If DGVCommodity_Classification.Rows.Count > 0 Then
                TxtCommodity_TypeID.TextBox1.Text = DGVCommodity_Classification.CurrentRow.Cells(0).Value
                TxtCommodity_Type_Name.TextBox1.Text = DGVCommodity_Classification.CurrentRow.Cells(1).Value
                TxtCommodity_Type_Description.TextBox1.Text = DGVCommodity_Classification.CurrentRow.Cells(2).Value
            End If
        Catch ex As Exception
            MessageBox.Show("請選有資料的列位，你點選的位置超過列數", "注意!選擇列位超過範圍", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub TxtCommodity_Type_Name_Enter(sender As Object, e As EventArgs) Handles TxtCommodity_Type_Name.Enter
        Dim myConn As New OleDbConnection(Access_Connection.ConnStr)
        myConn.Open()
        Dim mySelStr As String = "SELECT * FROM Commodity_Classification WHERE Commodity_Type_ID=@Commodity_Type_ID"
        Dim myComm As New OleDbCommand(mySelStr, myConn)
        Dim myID As String = TxtCommodity_TypeID.TextBox1.Text
        myComm.Parameters.AddWithValue("@Commodity_Type_ID", myID)
        myComm.ExecuteNonQuery()
        Dim myReader As OleDbDataReader = myComm.ExecuteReader
        If myReader.HasRows Then
            While myReader.Read
                TxtCommodity_TypeID.TextBox1.Text = myReader.Item(0).ToString
                TxtCommodity_Type_Name.TextBox1.Text = myReader.Item(1).ToString
                TxtCommodity_Type_Description.TextBox1.Text = myReader.Item(2).ToString
            End While
            myReader.Close()
        Else
            MsgBox("無此資料，請新增!!!!", 0 + 48, "警告訊息")
        End If
        myConn.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim myConn As New OleDbConnection(Access_Connection.ConnStr)
        myConn.Open()
        Dim ClassificationID As String = TxtCommodity_TypeID.TextBox1.Text
        Dim ClassificationType As String = TxtCommodity_Type_Name.TextBox1.Text
        Dim ClassificationDescription As String = TxtCommodity_Type_Description.TextBox1.Text
        If ClassificationID = "" Then
            MsgBox("編號不能空白!!!", 0 + 48, "警告訊息")
            TxtCommodity_TypeID.Focus()
        ElseIf ClassificationType = "" Then
            MsgBox("名稱不能空白!!!", 0 + 48, "警告訊息")
            TxtCommodity_Type_Name.Focus()
        ElseIf ClassificationDescription = "" Then
            MsgBox("說明不能空白!!!", 0 + 48, "警告訊息")
            TxtCommodity_Type_Description.Focus()
        Else
            If IsNumeric(ClassificationID) = False Or Len(ClassificationID) <> 4 Then
                MsgBox("編號只能輸入4個數字!!!", 0 + 48, "警告訊息")
                TxtCommodity_TypeID.Focus()
            Else
                Dim SelectStr As String = "Select * from Commodity_Classification Where Commodity_Type_ID=@Commodity_Type_ID"
                Dim myUpdateStr As String = "UPDATE Commodity_Classification Set Commodity_Type_ID=@Commodity_Type_ID,Commodity_Classification_Type=@Commodity_Classification_Type,Commodity_Classification_Description=@Commodity_Classification_Description Where Commodity_Type_ID=@Commodity_Type_ID"
                Dim myComm As New OleDbCommand(SelectStr, myConn)
                Dim myComm1 As New OleDbCommand(myUpdateStr, myConn)
                myComm.Parameters.AddWithValue("@Commodity_Type_ID", ClassificationID)
                myComm.ExecuteNonQuery()
                Dim myReader As OleDbDataReader = myComm.ExecuteReader
                If myReader.HasRows Then
                    Dim x = MsgBox("確定要更新此筆資料?", 4 + 48, "警告訊息")
                    If x = 6 Then
                        myComm1.Parameters.AddWithValue("@Commodity_Type_ID", ClassificationID)
                        myComm1.Parameters.AddWithValue("@Commodity_Classification_Type", ClassificationType)
                        myComm1.Parameters.AddWithValue("@Commodity_Classification_Description", ClassificationDescription)
                        myComm1.ExecuteNonQuery()
                        MsgBox("更新資料成功!!!", 0 + 48, "通知訊息")
                    End If
                End If
                ClearText()
            End If
        End If
        myConn.Close()
        Commodity_Classification_GetMaxTypeID()
        Commodity_Classification_GetData()
    End Sub
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim myConn As New OleDbConnection(Access_Connection.ConnStr)
        myConn.Open()
        Dim ClassificationID As String = TxtCommodity_TypeID.TextBox1.Text
        Dim ClassificationType As String = TxtCommodity_Type_Name.TextBox1.Text
        Dim ClassificationDescription As String = TxtCommodity_Type_Description.TextBox1.Text
        If ClassificationID = "" Then
            MsgBox("編號不能空白!!!", 0 + 48, "警告訊息")
            TxtCommodity_TypeID.Focus()
        Else
            If IsNumeric(ClassificationID) = False And Len(ClassificationID) <> 4 Then
                MsgBox("編號只能輸入4個數字!!!", 0 + 48, "警告訊息")
                TxtCommodity_TypeID.Focus()
            Else
                Dim SelectStr As String = "Select * from Commodity_Classification Where Commmodity_Type_ID=@Commmodity_Type_ID"
                Dim myComm As New OleDbCommand(SelectStr, myConn)
                myComm.Parameters.AddWithValue("@Commmodity_Type_ID", ClassificationID)
                myComm.ExecuteNonQuery()
                Dim myReader As OleDbDataReader = myComm.ExecuteReader
                If myReader.HasRows Then
                    Dim x = MsgBox("確定要刪除此筆資料?", 4 + 48, "警告訊息")
                    If x = 6 Then
                        Dim myDelStr As String = "DELETE from Commodity_Classification Where Commodity_Type_ID=@Commodity_Type_ID"
                        Dim myComm1 As New OleDbCommand(myDelStr, myConn)
                        myComm1.Parameters.AddWithValue("@Commodity_Type_ID", ClassificationID)
                        myComm1.ExecuteNonQuery()
                        MsgBox("刪除此筆資料成功!!!", 0 + 48, "通知訊息")
                    End If
                End If
                ClearText()
            End If
        End If
        myConn.Close()
        Commodity_Classification_GetMaxTypeID()
        Commodity_Classification_GetData()
    End Sub
    Private Sub Commodity_Classification_GetMaxTypeID()
        Dim myConnStr As String = Access_Connection.ConnStr
        Dim myConn As New OleDbConnection(myConnStr)
        myConn.Open()
        Dim mySelectStr As String = "Select Commodity_Type_ID from Commodity_Classification Order By Commodity_Type_ID"
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
                TxtCommodity_TypeID.TextBox1.Text = "000" + Convert.ToString(i)
            ElseIf Len(Convert.ToString(i)) = 2 Then
                TxtCommodity_TypeID.TextBox1.Text = "00" + Convert.ToString(i)
            ElseIf Len(Convert.ToString(i)) = 3 Then
                TxtCommodity_TypeID.TextBox1.Text = "0" + Convert.ToString(i)
            ElseIf Len(Convert.ToString(i)) = 4 Then
                TxtCommodity_TypeID.TextBox1.Text = Convert.ToString(i)
            End If
        Else
            TxtCommodity_TypeID.TextBox1.Text = "0001"
        End If
        myConn.Close()
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