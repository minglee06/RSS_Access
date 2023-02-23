<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRSS_Access_SaleOrder
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_SaleOrder))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSummation = New Guna.UI2.WinForms.Guna2Button()
        Me.lblToTalSum = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblDelRow = New System.Windows.Forms.Label()
        Me.BtnPrint_SaleOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.LblAddRow = New System.Windows.Forms.Label()
        Me.TLPSaleOrder = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCustomer_Name = New RSS_Access.TableText()
        Me.TxtCustomer_Tax_ID = New RSS_Access.TableText()
        Me.TxtSaleOrder_ID = New RSS_Access.TableText()
        Me.TLPSaleOrder.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(585, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 33)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "客戶名稱"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 66)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "客戶" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "統一編號"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy年M月d日"
        Me.DateTimePicker1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(773, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(283, 47)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(582, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 33)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "銷貨單日期"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "銷貨單編號"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BorderColor = System.Drawing.Color.Transparent
        Me.BtnSave.BorderRadius = 10
        Me.BtnSave.CheckedState.Parent = Me.BtnSave
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.CustomImages.Parent = Me.BtnSave
        Me.BtnSave.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnSave.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnSave.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnSave.HoverState.Parent = Me.BtnSave
        Me.BtnSave.Location = New System.Drawing.Point(1063, 239)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.Size = New System.Drawing.Size(157, 65)
        Me.BtnSave.TabIndex = 33
        Me.BtnSave.Text = "儲存"
        '
        'BtnSummation
        '
        Me.BtnSummation.BackColor = System.Drawing.Color.Transparent
        Me.BtnSummation.BorderColor = System.Drawing.Color.Transparent
        Me.BtnSummation.BorderRadius = 10
        Me.BtnSummation.CheckedState.Parent = Me.BtnSummation
        Me.BtnSummation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSummation.CustomImages.Parent = Me.BtnSummation
        Me.BtnSummation.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSummation.ForeColor = System.Drawing.Color.White
        Me.BtnSummation.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnSummation.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnSummation.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnSummation.HoverState.Parent = Me.BtnSummation
        Me.BtnSummation.Location = New System.Drawing.Point(30, 239)
        Me.BtnSummation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSummation.Name = "BtnSummation"
        Me.BtnSummation.ShadowDecoration.Parent = Me.BtnSummation
        Me.BtnSummation.Size = New System.Drawing.Size(157, 65)
        Me.BtnSummation.TabIndex = 27
        Me.BtnSummation.Text = "總合計"
        '
        'lblToTalSum
        '
        Me.lblToTalSum.AutoSize = True
        Me.lblToTalSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblToTalSum.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.lblToTalSum.ForeColor = System.Drawing.Color.Red
        Me.lblToTalSum.Location = New System.Drawing.Point(350, 257)
        Me.lblToTalSum.Name = "lblToTalSum"
        Me.lblToTalSum.Size = New System.Drawing.Size(222, 28)
        Me.lblToTalSum.TabIndex = 29
        Me.lblToTalSum.Text = "***************"
        Me.lblToTalSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(206, 257)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 28)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "合計總價："
        '
        'LblDelRow
        '
        Me.LblDelRow.AutoSize = True
        Me.LblDelRow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblDelRow.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.LblDelRow.ForeColor = System.Drawing.Color.Blue
        Me.LblDelRow.Location = New System.Drawing.Point(1452, 256)
        Me.LblDelRow.Name = "LblDelRow"
        Me.LblDelRow.Size = New System.Drawing.Size(124, 28)
        Me.LblDelRow.TabIndex = 31
        Me.LblDelRow.Text = "刪除一列"
        '
        'BtnPrint_SaleOrder
        '
        Me.BtnPrint_SaleOrder.BorderColor = System.Drawing.Color.White
        Me.BtnPrint_SaleOrder.BorderRadius = 10
        Me.BtnPrint_SaleOrder.CheckedState.Parent = Me.BtnPrint_SaleOrder
        Me.BtnPrint_SaleOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint_SaleOrder.CustomImages.Parent = Me.BtnPrint_SaleOrder
        Me.BtnPrint_SaleOrder.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.BtnPrint_SaleOrder.ForeColor = System.Drawing.Color.White
        Me.BtnPrint_SaleOrder.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnPrint_SaleOrder.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnPrint_SaleOrder.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnPrint_SaleOrder.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnPrint_SaleOrder.HoverState.Parent = Me.BtnPrint_SaleOrder
        Me.BtnPrint_SaleOrder.Location = New System.Drawing.Point(1242, 239)
        Me.BtnPrint_SaleOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPrint_SaleOrder.Name = "BtnPrint_SaleOrder"
        Me.BtnPrint_SaleOrder.ShadowDecoration.Parent = Me.BtnPrint_SaleOrder
        Me.BtnPrint_SaleOrder.Size = New System.Drawing.Size(192, 65)
        Me.BtnPrint_SaleOrder.TabIndex = 30
        Me.BtnPrint_SaleOrder.Text = "列印銷貨單"
        '
        'LblAddRow
        '
        Me.LblAddRow.AutoSize = True
        Me.LblAddRow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAddRow.Font = New System.Drawing.Font("標楷體", 18.0!)
        Me.LblAddRow.ForeColor = System.Drawing.Color.Blue
        Me.LblAddRow.Location = New System.Drawing.Point(1578, 255)
        Me.LblAddRow.Name = "LblAddRow"
        Me.LblAddRow.Size = New System.Drawing.Size(133, 30)
        Me.LblAddRow.TabIndex = 32
        Me.LblAddRow.Text = "增加一列"
        '
        'TLPSaleOrder
        '
        Me.TLPSaleOrder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TLPSaleOrder.ColumnCount = 10
        Me.TLPSaleOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TLPSaleOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210.0!))
        Me.TLPSaleOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TLPSaleOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me.TLPSaleOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me.TLPSaleOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TLPSaleOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TLPSaleOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TLPSaleOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TLPSaleOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.TLPSaleOrder.Controls.Add(Me.Label6, 4, 0)
        Me.TLPSaleOrder.Controls.Add(Me.Label7, 6, 0)
        Me.TLPSaleOrder.Controls.Add(Me.Label8, 7, 0)
        Me.TLPSaleOrder.Controls.Add(Me.Label5, 1, 0)
        Me.TLPSaleOrder.Controls.Add(Me.Label10, 2, 0)
        Me.TLPSaleOrder.Controls.Add(Me.Label11, 3, 0)
        Me.TLPSaleOrder.Controls.Add(Me.Label12, 0, 0)
        Me.TLPSaleOrder.Controls.Add(Me.Label14, 8, 0)
        Me.TLPSaleOrder.Controls.Add(Me.Label15, 9, 0)
        Me.TLPSaleOrder.Controls.Add(Me.Label9, 5, 0)
        Me.TLPSaleOrder.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TLPSaleOrder.Location = New System.Drawing.Point(6, 322)
        Me.TLPSaleOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TLPSaleOrder.Name = "TLPSaleOrder"
        Me.TLPSaleOrder.RowCount = 1
        Me.TLPSaleOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TLPSaleOrder.Size = New System.Drawing.Size(1940, 82)
        Me.TLPSaleOrder.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(888, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 90)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "商品名稱"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1330, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 90)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "單位"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1481, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 90)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "數量"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(105, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(1)
        Me.Label5.Size = New System.Drawing.Size(204, 90)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "供應商統編"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(316, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(294, 90)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "供應商名稱"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(617, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(264, 90)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "商品編號"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(4, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 90)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "項次"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(1632, 1)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 90)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "單價"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(1783, 1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 90)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "合計"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1159, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 90)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "商品種類"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCustomer_Name
        '
        Me.TxtCustomer_Name.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_Name.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtCustomer_Name.Location = New System.Drawing.Point(742, 132)
        Me.TxtCustomer_Name.Name = "TxtCustomer_Name"
        Me.TxtCustomer_Name.Size = New System.Drawing.Size(548, 65)
        Me.TxtCustomer_Name.TabIndex = 15
        '
        'TxtCustomer_Tax_ID
        '
        Me.TxtCustomer_Tax_ID.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_Tax_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_Tax_ID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtCustomer_Tax_ID.Location = New System.Drawing.Point(216, 134)
        Me.TxtCustomer_Tax_ID.Name = "TxtCustomer_Tax_ID"
        Me.TxtCustomer_Tax_ID.Size = New System.Drawing.Size(302, 65)
        Me.TxtCustomer_Tax_ID.TabIndex = 13
        '
        'TxtSaleOrder_ID
        '
        Me.TxtSaleOrder_ID.BackColor = System.Drawing.Color.White
        Me.TxtSaleOrder_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSaleOrder_ID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtSaleOrder_ID.Location = New System.Drawing.Point(215, 25)
        Me.TxtSaleOrder_ID.Name = "TxtSaleOrder_ID"
        Me.TxtSaleOrder_ID.Size = New System.Drawing.Size(302, 65)
        Me.TxtSaleOrder_ID.TabIndex = 9
        '
        'frmRSS_Access_SaleOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1202)
        Me.Controls.Add(Me.TLPSaleOrder)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnSummation)
        Me.Controls.Add(Me.lblToTalSum)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LblDelRow)
        Me.Controls.Add(Me.BtnPrint_SaleOrder)
        Me.Controls.Add(Me.LblAddRow)
        Me.Controls.Add(Me.TxtCustomer_Name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCustomer_Tax_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSaleOrder_ID)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRSS_Access_SaleOrder"
        Me.Text = "銷貨單"
        Me.TLPSaleOrder.ResumeLayout(False)
        Me.TLPSaleOrder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCustomer_Name As TableText
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCustomer_Tax_ID As TableText
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSaleOrder_ID As TableText
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSummation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblToTalSum As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LblDelRow As Label
    Friend WithEvents BtnPrint_SaleOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblAddRow As Label
    Friend WithEvents TLPSaleOrder As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
End Class
