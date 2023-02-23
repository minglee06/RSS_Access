Imports System.Data.OleDb
Imports System.IO
Imports RSS_Access.Access_Connection
Public Class frmRSS_Access_CommodityV2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = Now
    End Sub

    Private Sub frmRSS_Access_CommodityV2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim myConnStr As String = Access_Connection.ConnStr
        Dim MyConn As New OleDbConnection(myConnStr)
        MyConn.Open()
        Dim MyCommStr As String = "Select Commodity_Classification_Type from Commodity_Classification"
        Dim myComm As New OleDbCommand(MyCommStr, MyConn)
        myComm.ExecuteNonQuery()
        Dim myReader As OleDbDataReader = myComm.ExecuteReader
        If myReader.HasRows Then
            While myReader.Read
                CMBCommodity_Type.Items.Add(myReader.Item(0))
            End While
        Else
            CMBCommodity_Type.Text = "請選擇"
        End If
        myReader.Close()
        MyConn.Close()
        CMBCommodity_Unit.Items.Add("包")
        CMBCommodity_Unit.Items.Add("袋")
        CMBCommodity_Unit.Items.Add("箱")
        CMBCommodity_Unit.Items.Add("盒")
        CMBCommodity_Unit.Items.Add("瓶")
        CMBCommodity_Unit.Items.Add("罐")
        CMBCommodity_Unit.Items.Add("台")
        CMBCommodity_Unit.Items.Add("張")
        CMBCommodity_Unit.Items.Add("座")
        CMBCommodity_Unit.Items.Add("本")
        'Commodity_GetData()
        TxtSupply_Tax_ID.TextBox1.MaxLength = 8
        PicCommodity.ImageLocation = "C://RSS_Access/Bin/Commodity_RAW_Image/Picture-icon.png"
        PicCommodity.Show()
        Commodity_GetData()
    End Sub
    Private Sub ClearText()
        TxtCommodity_ID.TextBox1.Text = ""
        LblCommodity_Image_Path.Text = "請按下圖檔資料夾選擇圖檔"
        PicCommodity.ImageLocation = ImageRawPath & "Picture-icon.png"
        TxtCommodity_Name.TextBox1.Text = ""
        CMBCommodity_Type.Text = "請選擇"
        TxtSupply_Tax_ID.TextBox1.Text = ""
        TxtSupply_Name.TextBox1.Text = ""
        TxtCommodity_SafeQty.TextBox1.Text = "0"
        CMBCommodity_Unit.Text = "請選擇"
        TxtCommodity_Qty_PerUnit.TextBox1.Text = "0"
        'TxtCommodity_StockQty.TextBox1.Text = "0"
    End Sub
    Private Sub ClearTextExceptCommodityID()
        'LblCommodity_Image_Path.Text = "請按下圖檔資料夾選擇圖檔"
        TxtCommodity_Name.TextBox1.Text = ""
        CMBCommodity_Type.Text = "請選擇"
        TxtSupply_Tax_ID.TextBox1.Text = ""
        TxtSupply_Name.TextBox1.Text = ""
        TxtCommodity_SafeQty.TextBox1.Text = "0"
        CMBCommodity_Unit.Text = "請選擇"
        TxtCommodity_Qty_PerUnit.TextBox1.Text = "0"
        'TxtCommodity_StockQty.TextBox1.Text = "0"
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Dim myConnStr As String = Access_Connection.ConnStr
            Dim myConn As New OleDbConnection(myConnStr)
            myConn.Open()
            Dim mySelectStr As String = "Select * From Commodity Where Commodity_ID=@CommodityID"
            Dim myComm As New OleDbCommand(mySelectStr, myConn)
            Dim myInsertStr As String = "Insert Into Commodity(Commodity_ID,Commodity_Name," &
                "Commodity_Type,Commodity_Image,Supply_Tax_ID,Supply_Co_Name," &
                "Commodity_SafeQty,Commodity_Unit,Commodity_Qty_PerUnit) " &
                " Values(@Commodity_ID,@Commodity_Name,@Commodity_Type," &
                "@Commodity_Image,@Supply_Tax_ID,@Supply_Co_Name," &
                "@Commodity_SafeQty,@Commodity_Unit,@Commodity_Qty_PerUnit)"
            Dim myInsertComm As New OleDbCommand(myInsertStr, myConn)
            Dim myCommodityRAWImagePath As String = LblCommodity_Image_Path.Text
            Dim myCommodityID As String = TxtCommodity_ID.TextBox1.Text
            Dim myCommodityName As String = TxtCommodity_Name.TextBox1.Text
            Dim myCommodityType As String = CMBCommodity_Type.Text
            Dim mySupplyTaxID As String = TxtSupply_Tax_ID.TextBox1.Text
            Dim mySupplyName As String = TxtSupply_Name.TextBox1.Text
            Dim myCommoditySQty As String = TxtCommodity_SafeQty.TextBox1.Text
            Dim myCommodityUnit As String = CMBCommodity_Unit.Text
            Dim myCommodityQtyPerUnit As String = TxtCommodity_Qty_PerUnit.TextBox1.Text

            If myCommodityRAWImagePath = "" Then
                MsgBox("須選擇商品圖檔", 0 + 48, "警告訊息")
                ImageBtnOpenFile.Focus()
            ElseIf myCommodityID = "" Then
                MsgBox("商品編號不能空白", 0 + 48, "警告訊息")
                TxtCommodity_ID.Focus()
            ElseIf myCommodityName = "" Then
                MsgBox("商品名稱不能空白", 0 + 48, "警告訊息")
                TxtCommodity_Name.Focus()
            ElseIf myCommodityType = "請選擇" Then
                MsgBox("商品種類須選擇", 0 + 48, "警告訊息")
                CMBCommodity_Type.Focus()
            ElseIf mySupplyTaxID = "" Then
                MsgBox("供應商統一編號不能空白", 0 + 48, "警告訊息")
                TxtSupply_Tax_ID.Focus()
            ElseIf mySupplyName = "" Then
                MsgBox("供應商名稱不能空白", 0 + 48, "警告訊息")
                TxtSupply_Name.Focus()
            ElseIf myCommoditySQty = "" Then
                MsgBox("商品安全庫存不能空白", 0 + 48, "警告訊息")
                TxtCommodity_SafeQty.Focus()
            ElseIf myCommodityUnit = "" Then
                MsgBox("商品單位不能空白", 0 + 48, "警告訊息")
                CMBCommodity_Unit.Focus()
            ElseIf myCommodityQtyPerUnit = "" Then
                MsgBox("商品每單位數量不能空白", 0 + 48, "警告訊息")
                TxtCommodity_Qty_PerUnit.TextBox1.Focus()

            Else
                If IsNumeric(mySupplyTaxID) = False Then
                    MsgBox("供應商統一編號為8個數字", 0 + 48, "警告訊息")
                ElseIf IsNumeric(myCommoditySQty) = False Then
                    MsgBox("安全存量須為數字", 0 + 48, "警告訊息")
                ElseIf IsNumeric(myCommodityQtyPerUnit) = False Then
                    MsgBox("每單位數量須為數字", 0 + 48, "警告訊息")

                Else
                    myComm.Parameters.AddWithValue("@Commodity_ID", myCommodityID)
                    myComm.ExecuteNonQuery()
                    Dim myReader As OleDbDataReader = myComm.ExecuteReader
                    If myReader.HasRows Then
                        MsgBox("已有此商品", 0 + 48, "警告訊息")
                    Else
                        Dim x = MsgBox("要新增資料嗎?", 4 + 48, "詢問訊息")
                        If x = 6 Then
                            myInsertComm.Parameters.AddWithValue("@Commodity_ID", myCommodityID)
                            myInsertComm.Parameters.AddWithValue("@Commodity_Name", myCommodityName)
                            myInsertComm.Parameters.AddWithValue("@Commodity_Type", myCommodityType)
                            Dim myCommodityImagePath = ImagePath & myCommodityID & ".png"
                            If File.Exists(myCommodityImagePath) = False Then
                                File.Copy(myCommodityRAWImagePath, myCommodityImagePath)
                                Dim myByte As Byte() = File.ReadAllBytes(myCommodityImagePath)
                                'Dim bf As New IO.MemoryStream(myByte)
                                myInsertComm.Parameters.Add("@Commodity_Image", OleDb.OleDbType.Binary).Value = myByte
                                'myInsertComm.Parameters.Add("@Commodity_Image", OleDbType.Binary)
                                'myInsertComm.Parameters("@Commodity_Image").Value = myImg
                            Else
                                File.Delete(myCommodityImagePath)
                                File.Copy(myCommodityRAWImagePath, myCommodityImagePath)
                                Dim myByte As Byte() = File.ReadAllBytes(myCommodityImagePath)
                                myInsertComm.Parameters.Add("@Commodity_Image", OleDb.OleDbType.Binary).Value = myByte
                                'myInsertComm.Parameters.Add("@Commodity_Image", OleDbType.Binary)
                                'myInsertComm.Parameters("@Commodity_Image").Value = myImg

                            End If
                            myInsertComm.Parameters.AddWithValue("@Supply_Tax_ID", mySupplyTaxID)
                            myInsertComm.Parameters.AddWithValue("@Supply_Co_Name", mySupplyName)
                            myInsertComm.Parameters.AddWithValue("@Commodity_SafeQty", myCommoditySQty)
                            myInsertComm.Parameters.AddWithValue("@Commodity_Unit", myCommodityUnit)
                            myInsertComm.Parameters.AddWithValue("@Commodity_Qty_PerUnit", myCommodityQtyPerUnit)

                            myInsertComm.ExecuteNonQuery()
                            MsgBox("新增成功", 0 + 48, "通知訊息")
                        End If
                    End If
                End If
            End If
            myConn.Close()
            Commodity_GetData()
            ClearText()
        Catch ex As Exception
            MsgBox(ex.Message, 0 + 48, "警告訊息")
        End Try
        Commodity_GetData()
        ClearText()
    End Sub
    Private Sub ImageBtnOpenFile_Click(sender As Object, e As EventArgs) Handles ImageBtnOpenFile.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            If OpenFileDialog1.FileName <> "" Then

                LblCommodity_Image_Path.Text = OpenFileDialog1.FileName
                PicCommodity.ImageLocation = OpenFileDialog1.FileName
            End If
        End If
    End Sub
    Private Sub TxtSupply_Name_Enter(sender As Object, e As EventArgs) Handles TxtSupply_Name.Enter
        Connection.Open()
        Dim mySelectStr As String = "Select Supply_Co_Name from Supply Where Supply_Tax_ID=@Supply_Tax_ID"
        Dim mySelectComm As New OleDbCommand(mySelectStr, Connection)
        Dim mySupplyID As String = TxtSupply_Tax_ID.TextBox1.Text
        mySelectComm.Parameters.AddWithValue("@Supply_Tax_ID", mySupplyID)
        mySelectComm.ExecuteNonQuery()
        Dim myReader As OleDbDataReader = mySelectComm.ExecuteReader
        If mySupplyID = "" Then
            MsgBox("供應商編號不能空白", 0 + 48, "警告訊息")
            TxtSupply_Tax_ID.Focus()
        ElseIf myReader.HasRows = False Then
            MsgBox("無此供應商資料，請新增", 0 + 48, "警告訊息")
            TxtSupply_Tax_ID.Focus()
        Else
            While myReader.Read
                TxtSupply_Name.TextBox1.Text = myReader.Item(0).ToString
            End While
            myReader.Close()
        End If
        Connection.Close()
    End Sub
    Private Sub Commodity_GetData()
        Dim mySelectStr As String = "Select * from Commodity"
        'BindingSource1.DataSource = Access_Connection.GetData(mySelectStr)
        DGVCommodity.DataSource = Access_Connection.GetData(mySelectStr)
        With DGVCommodity
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
            .BorderStyle = BorderStyle.FixedSingle
            .ReadOnly = True
            .AutoGenerateColumns = True
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            '.ColumnHeadersBorderStyle = 0
            .DefaultCellStyle.Font = New Font("標楷體", 16)
            .EditMode = DataGridViewEditMode.EditProgrammatically
            .EnableHeadersVisualStyles = False
            .Columns(0).HeaderText = "項次"
            .Columns(0).Width = 80
            '.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .Columns(1).HeaderText = "商品編號"
            .Columns(1).Width = 180
            .Columns(2).HeaderText = "商品名稱"
            .Columns(2).Width = 400
            .Columns(3).HeaderText = "商品種類"
            .Columns(3).Width = 80
            .Columns(4).HeaderText = "商品圖檔"
            .Columns(4).Width = 150
            .Columns(5).HeaderText = "供應商統一編號"
            .Columns(5).Width = 150
            .Columns(6).HeaderText = "供應商名稱"
            .Columns(6).Width = 280
            .Columns(7).HeaderText = "安全庫存"
            .Columns(7).Width = 80
            .Columns(8).HeaderText = "單位"
            .Columns(8).Width = 80
            ' .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .Columns(9).HeaderText = "每單位數量"
            .Columns(9).Width = 110

            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .ColumnHeadersDefaultCellStyle.Font = New Font("標楷體", 16)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub
    Private Sub DGVCommodity_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCommodity.CellClick
        Try
            If DGVCommodity.Rows.Count > 0 Then

                TxtCommodity_ID.TextBox1.Text = DGVCommodity.CurrentRow.Cells(1).Value
                TxtCommodity_Name.TextBox1.Text = DGVCommodity.CurrentRow.Cells(2).Value
                CMBCommodity_Type.Text = DGVCommodity.CurrentRow.Cells(3).Value

                LblCommodity_Image_Path.Text = ImagePath & TxtCommodity_ID.TextBox1.Text & ".png"
                Dim ms As New IO.MemoryStream(CType(DGVCommodity.CurrentRow.Cells(4).Value, Byte()))
                Dim returnImage As Image = Image.FromStream(ms)
                PicCommodity.Image = returnImage
                TxtSupply_Tax_ID.TextBox1.Text = DGVCommodity.CurrentRow.Cells(5).Value
                TxtSupply_Name.TextBox1.Text = DGVCommodity.CurrentRow.Cells(6).Value
                TxtCommodity_SafeQty.TextBox1.Text = DGVCommodity.CurrentRow.Cells(7).Value
                CMBCommodity_Unit.Text = DGVCommodity.CurrentRow.Cells(8).Value
                TxtCommodity_Qty_PerUnit.TextBox1.Text = DGVCommodity.CurrentRow.Cells(9).Value

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Connection.Open()
        Dim mySelectStr As String = "Select * from Commodity Where Commodity_ID=@Commodity_ID"
        Dim myComm As New OleDbCommand(mySelectStr, Connection)
        Dim myCommodityID As String = TxtCommodity_ID.TextBox1.Text
        Dim myDelStr As String = "Delete from Commodity where Commodity_ID=@Commodity_ID"
        Dim myDelComm As New OleDbCommand(myDelStr, Connection)
        myComm.Parameters.AddWithValue("@Commodity_ID", myCommodityID)
        myComm.ExecuteNonQuery()
        Dim myReader As OleDbDataReader = myComm.ExecuteReader
        If myReader.HasRows = False Then
            MsgBox("無此筆資料", 0 + 48, "警告訊息")
            TxtCommodity_ID.Focus()
        Else
            Dim X = MsgBox("確定要刪除此筆資料?", 4 + 48, "詢問訊息")
            If X = 6 Then
                Dim myCommodityImagePath = ImagePath & myCommodityID & ".png"
                myDelComm.Parameters.AddWithValue("@Commodity_ID", myCommodityID)
                myDelComm.ExecuteNonQuery()
                File.Delete(myCommodityImagePath)
                MsgBox("刪除資料成功", 0 + 48, "通知訊息")
            End If
        End If
        Connection.Close()
        Commodity_GetData()
        ClearText()
    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ClearText()
    End Sub
    Private Sub TxtCommodity_Name_Enter(sender As Object, e As EventArgs) Handles TxtCommodity_Name.Enter
        Dim myCommodityID As String = TxtCommodity_ID.TextBox1.Text
        Connection.Open()
        Dim mySelectStr As String = "Select * From Commodity Where Commodity_ID=@Commodity_ID"
        Dim myComm As New OleDbCommand(mySelectStr, Connection)
        myComm.Parameters.AddWithValue("@Commodity_ID", myCommodityID)
        myComm.ExecuteNonQuery()
        Dim myReader As OleDbDataReader = myComm.ExecuteReader
        If myCommodityID = "" Or IsNumeric(myCommodityID) = False Then
            MsgBox("商品編號不能空白且是數字", 0 + 48, "警告訊息")
            TxtCommodity_ID.Focus()
        ElseIf myReader.HasRows = False Then
            MsgBox("無此商品資料，請新增", 0 + 48, "警告訊息")
            TxtCommodity_Name.Focus()
            ClearTextExceptCommodityID()
        Else
            While myReader.Read
                TxtCommodity_Name.TextBox1.Text = myReader.Item(2).ToString
                CMBCommodity_Type.Text = myReader.Item(3).ToString
                LblCommodity_Image_Path.Text = myReader.Item(4).ToString
                PicCommodity.ImageLocation = myReader.Item(4).ToString
                TxtSupply_Tax_ID.TextBox1.Text = myReader.Item(5).ToString
                TxtSupply_Name.TextBox1.Text = myReader.Item(6).ToString
                TxtCommodity_SafeQty.TextBox1.Text = myReader.Item(7).ToString
            End While
            myReader.Close()
        End If
        Connection.Close()
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Connection.Open()
        Dim myUpdateStr As String = "UPDATE Commodity SET Commodity_ID=@Commodity_ID," &
            "Commodity_Name=@Commodity_Name,Commodity_Type=@Commodity_Type," &
            "Commodity_Image=@Commodity_Image,Supply_Tax_ID=@Supply_Tax_ID," &
            "Supply_Co_Name=@Supply_Co_Name,Commodity_SafeQty=@Commodity_SafeQty," &
            "Commodity_Unit=@Commodity_unit,Commodity_Qty_PerUnit=@Commodity_Qty_PerUnit" &
            " WHERE Commodity_ID=@Commodity_ID"
        Dim myUpdateComm As New OleDbCommand(myUpdateStr, Connection)
        Dim mySelectStr As String = "Select * From Commodity Where Commodity_ID=@Commodity_ID"
        Dim mySelectComm As New OleDbCommand(mySelectStr, Connection)
        Dim myCommodityImagePath1 As String = LblCommodity_Image_Path.Text
        Dim myCommodityID As String = TxtCommodity_ID.TextBox1.Text
        Dim myCommodityName As String = TxtCommodity_Name.TextBox1.Text
        Dim myCommodityType As String = CMBCommodity_Type.Text
        Dim mySupplyTaxID As String = TxtSupply_Tax_ID.TextBox1.Text
        Dim mySupplyName As String = TxtSupply_Name.TextBox1.Text
        Dim myCommoditySQty As String = TxtCommodity_SafeQty.TextBox1.Text
        Dim myCommodityUnit As String = CMBCommodity_Unit.Text
        Dim myCommodityQtyPerUnit As String = TxtCommodity_Qty_PerUnit.TextBox1.Text

        If myCommodityImagePath1 = "" Then
            MsgBox("須選擇商品圖檔", 0 + 48, "警告訊息")
            ImageBtnOpenFile.Focus()
        ElseIf myCommodityID = "" Then
            MsgBox("商品編號不能空白", 0 + 48, "警告訊息")
            TxtCommodity_ID.Focus()
        ElseIf myCommodityName = "" Then
            MsgBox("商品名稱不能空白", 0 + 48, "警告訊息")
            TxtCommodity_Name.Focus()
        ElseIf myCommodityType = "請選擇" Then
            MsgBox("商品種類須選擇", 0 + 48, "警告訊息")
            CMBCommodity_Type.Focus()
        ElseIf mySupplyTaxID = "" Then
            MsgBox("供應商統一編號不能空白", 0 + 48, "警告訊息")
            TxtSupply_Tax_ID.Focus()
        ElseIf mySupplyName = "" Then
            MsgBox("供應商名稱不能空白", 0 + 48, "警告訊息")
            TxtSupply_Name.Focus()
        ElseIf myCommoditySQty = "" Then
            MsgBox("商品安全庫存不能空白", 0 + 48, "警告訊息")
            TxtCommodity_SafeQty.Focus()
        ElseIf myCommodityUnit = "" Then
            MsgBox("商品單位不能空白", 0 + 48, "警告訊息")
            CMBCommodity_Unit.Focus()
        ElseIf myCommodityQtyPerUnit = "" Then
            MsgBox("商品每單位數量不能空白", 0 + 48, "警告訊息")
            TxtCommodity_Qty_PerUnit.Focus()

        Else
            If IsNumeric(mySupplyTaxID) = False Then
                MsgBox("供應商統一編號為8個數字", 0 + 48, "警告訊息")
            ElseIf IsNumeric(myCommoditySQty) = False Then
                MsgBox("安全存量須為數字", 0 + 48, "警告訊息")
            ElseIf IsNumeric(myCommodityQtyPerUnit) = False Then
                MsgBox("每單位數量須為數字", 0 + 48, "警告訊息")

            Else
                mySelectComm.Parameters.AddWithValue("@Commodity_ID", myCommodityID)
                mySelectComm.ExecuteNonQuery()
                Dim myReader As OleDbDataReader = mySelectComm.ExecuteReader
                If myReader.HasRows = False Then
                    MsgBox("無此筆資料，無法更新", 0 + 48, "警告訊息")
                Else
                    Dim X = MsgBox("你確定要修改嗎?", 4 + 48, "詢問訊息")
                    If X = 6 Then
                        Dim myCommodityImagePath = ImagePath & myCommodityID & ".png"
                        Try
                            myUpdateComm.Parameters.AddWithValue("@Commodity_ID", myCommodityID)
                            myUpdateComm.Parameters.AddWithValue("@Commodity_Name", myCommodityName)
                            myUpdateComm.Parameters.AddWithValue("@Commodity_Type", myCommodityType)
                            If myCommodityImagePath = myCommodityImagePath1 Then
                                Dim myByte As Byte() = File.ReadAllBytes(myCommodityImagePath)
                                myUpdateComm.Parameters.Add("@Commodity_Image", OleDb.OleDbType.Binary).Value = myByte
                                'myUpdateComm.Parameters.AddWithValue("@Commodity_Image", myCommodityImagePath)
                            Else
                                If File.Exists(myCommodityImagePath) = True Then
                                    File.Delete(myCommodityImagePath)
                                    File.Copy(myCommodityImagePath1, myCommodityImagePath)
                                    Dim myByte As Byte() = File.ReadAllBytes(myCommodityImagePath)
                                    myUpdateComm.Parameters.Add("@Commodity_Image", OleDb.OleDbType.Binary).Value = myByte
                                Else
                                    File.Copy(myCommodityImagePath1, myCommodityImagePath)
                                    Dim myByte As Byte() = File.ReadAllBytes(myCommodityImagePath)
                                    myUpdateComm.Parameters.Add("@Commodity_Image", OleDb.OleDbType.Binary).Value = myByte
                                End If
                            End If

                            myUpdateComm.Parameters.AddWithValue("@Supply_Tax_ID", mySupplyTaxID)
                            myUpdateComm.Parameters.AddWithValue("@Supply_Name", mySupplyName)
                            myUpdateComm.Parameters.AddWithValue("@Commodity_SafeQty", myCommoditySQty)
                            myUpdateComm.Parameters.AddWithValue("@Commodity_Unit", myCommodityUnit)
                            myUpdateComm.Parameters.AddWithValue("@Commodity_Qty_PerUnit", myCommodityQtyPerUnit)

                            myUpdateComm.ExecuteNonQuery()
                            MsgBox("更新成功", 0 + 48, "詢問訊息")
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                End If
            End If
        End If
        Connection.Close()
        Commodity_GetData()
        ClearText()
    End Sub
End Class