Imports System.Data.OleDb
Imports RSS_Access.Access_Connection
Public Class frmRSS_Access_DeliveryOrder
    Private Sub frmRSS_Access_DeliveryOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim StrYear As String = Now.Date.Year
        Dim StrMonth As String = Now.Date.Month
        If Len(StrMonth) = 1 Then
            StrMonth = "00" & StrMonth
        ElseIf Len(StrMonth) = 2 Then
            StrMonth = "0" & StrMonth
        End If
        Dim SelectStr As String = "Select DeliveryOrder_ID From DeliveryOrder"
        Dim SelectComm As New OleDbCommand(SelectStr, Connection)
        Dim SelectDOStr As String = "Select DeliveryOrder_ID From DeliveryOrder Order By DeliveryOrder_ID ASC"
        Dim SelectDOComm As New OleDbCommand(SelectDOStr, Connection)
        Dim LeftStr As String = StrYear & StrMonth
        Dim StrNumber As Integer
        Dim DeliveryOrderID As String
        Dim DODt As DataTable = GetData(SelectStr)
        Connection.Open()
        If DODt.Rows.Count = 0 Then
            DeliveryOrderID = StrYear & StrMonth & "00001"
            TxtDeliveryOrderID.Text = DeliveryOrderID
        ElseIf DODt.Rows.Count = 1 Then
            SelectComm.ExecuteNonQuery()
            Dim SelectReader As OleDbDataReader = SelectComm.ExecuteReader
            While SelectReader.Read
                DeliveryOrderID = SelectReader.Item(0).ToString
                If Convert.ToInt32(Strings.Left(DeliveryOrderID, 4)) = Now.Year Then
                    Dim Str1 As String = Strings.Left(DeliveryOrderID, 7)
                    Dim Str2 As String = Strings.Right(Str1, 3)
                    If Convert.ToInt32(Str2) = Now.Month Then
                        StrNumber = Convert.ToInt32(DeliveryOrderID, 5)
                        StrNumber += 1
                        If Strings.Len(StrNumber) = 2 Then
                            TxtDeliveryOrderID.Text = Str1 & "0" & StrNumber
                        ElseIf Strings.Len(StrNumber) = 1 Then
                            TxtDeliveryOrderID.Text = Str1 & "00" & StrNumber
                        End If
                    ElseIf Convert.ToInt32(Str2) < Now.Month Then
                        TxtDeliveryOrderID.Text = StrYear & StrMonth & "00001"
                    End If
                ElseIf Convert.ToInt32(Strings.Left(DeliveryOrderID, 4)) < Now.Year Then
                    TxtDeliveryOrderID.Text = StrYear & StrMonth & "00001"
                End If
            End While
            SelectReader.Close()
        ElseIf DODT.Rows.Count > 1 Then
            SelectDOComm.ExecuteNonQuery()
            Dim SelectDOCReader As OleDbDataReader = SelectDOComm.ExecuteReader
            If SelectDOCReader.HasRows Then
                While SelectDOCReader.Read
                    DeliveryOrderID = SelectDOCReader.Item(0).ToString
                    If Convert.ToInt32(Strings.Left(DeliveryOrderID, 4)) = Now.Year Then
                        Dim Str1 As String = Strings.Left(DeliveryOrderID, 7)
                        Dim Str2 As String = Strings.Right(Str1, 3)
                        If Convert.ToInt32(Str2) = Now.Month Then
                            StrNumber = Convert.ToInt32(DeliveryOrderID, 5)
                            StrNumber += 1
                            If Strings.Len(StrNumber) = 2 Then
                                TxtDeliveryOrderID.Text = Str1 & "0" & StrNumber
                            ElseIf Strings.Len(StrNumber) = 1 Then
                                TxtDeliveryOrderID.Text = Str1 & "00" & StrNumber
                            End If
                        ElseIf Convert.ToInt32(Str2) < Now.Month Then
                            TxtDeliveryOrderID.Text = StrYear & StrMonth & "00001"
                        End If
                    ElseIf Convert.ToInt32(Strings.Left(DeliveryOrderID, 4)) < Now.Year Then
                        TxtDeliveryOrderID.Text = StrYear & StrMonth & "00001"
                    End If
                End While
                SelectDOCReader.Close()
            End If
        End If
        Connection.Close()
        Dim SelectAllStr As String = "Select * from DeliveryOrder"
        BindingSource1.DataSource = GetData(SelectAllStr)
        DGVDeliveryOrder.DataSource = BindingSource1
        With DGVDeliveryOrder
            .AutoGenerateColumns = True
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
            .EnableHeadersVisualStyles = False
            .DefaultCellStyle.Font = New Font("標楷體", 14)
            .EditMode = DataGridViewEditMode.EditProgrammatically
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            .ColumnHeadersDefaultCellStyle.Font = New Font("標楷體", 14)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).HeaderText = "項次"
            .Columns(1).HeaderText = "出貨單編號"
            .Columns(2).HeaderText = "出貨單日期"
            .Columns(3).HeaderText = "銷貨單編號"
            .Columns(4).HeaderText = "客戶統編"
            .Columns(5).HeaderText = "客戶名稱"
            .Columns(6).HeaderText = "發票號碼"
            .Columns(7).HeaderText = "貨運公司統編"
            .Columns(8).HeaderText = "貨運公司名稱"
            .Columns(9).HeaderText = "供應商統編"
            .Columns(10).HeaderText = "供應商名稱"
            .Columns(11).HeaderText = "商品編號"
            .Columns(12).HeaderText = "商品名稱"
            .Columns(13).HeaderText = "商品種類"
            .Columns(14).HeaderText = "商品單位"
            .Columns(15).HeaderText = "商品數量"
            .Columns(16).HeaderText = "商品單價"
            .Columns(17).HeaderText = "單項合計"
        End With

    End Sub
End Class