<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRSS_Access_PurchaseOrder
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_PurchaseOrder))
        Me.lblPurchaseOrderNo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TLPPurchaseOrder = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblAddRow = New System.Windows.Forms.Label()
        Me.BtnPrint_PurchaseOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.LblDelRow = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblToTalSum = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSummation = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.DateTimePicker1 = New RSS_Access.MCDateTimePicker()
        Me.TxtSupply_Name = New RSS_Access.TableText()
        Me.TxtSupply_Tax_ID = New RSS_Access.TableText()
        Me.TxtPurchaseOrderID = New RSS_Access.TableText()
        Me.TLPPurchaseOrder.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPurchaseOrderNo
        '
        Me.lblPurchaseOrderNo.AutoSize = True
        Me.lblPurchaseOrderNo.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblPurchaseOrderNo.Location = New System.Drawing.Point(24, 125)
        Me.lblPurchaseOrderNo.Name = "lblPurchaseOrderNo"
        Me.lblPurchaseOrderNo.Size = New System.Drawing.Size(185, 33)
        Me.lblPurchaseOrderNo.TabIndex = 0
        Me.lblPurchaseOrderNo.Text = "進貨單編號"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(4, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 78)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "項次"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(767, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 78)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "商品種類"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(366, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(394, 78)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "商品名稱"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(1)
        Me.Label1.Size = New System.Drawing.Size(254, 78)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "商品編號"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TLPPurchaseOrder
        '
        Me.TLPPurchaseOrder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TLPPurchaseOrder.ColumnCount = 10
        Me.TLPPurchaseOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TLPPurchaseOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.TLPPurchaseOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.TLPPurchaseOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TLPPurchaseOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TLPPurchaseOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TLPPurchaseOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TLPPurchaseOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TLPPurchaseOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TLPPurchaseOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269.0!))
        Me.TLPPurchaseOrder.Controls.Add(Me.Label6, 4, 0)
        Me.TLPPurchaseOrder.Controls.Add(Me.Label7, 5, 0)
        Me.TLPPurchaseOrder.Controls.Add(Me.Label8, 6, 0)
        Me.TLPPurchaseOrder.Controls.Add(Me.Label9, 7, 0)
        Me.TLPPurchaseOrder.Controls.Add(Me.Label1, 1, 0)
        Me.TLPPurchaseOrder.Controls.Add(Me.Label2, 2, 0)
        Me.TLPPurchaseOrder.Controls.Add(Me.Label3, 3, 0)
        Me.TLPPurchaseOrder.Controls.Add(Me.Label10, 0, 0)
        Me.TLPPurchaseOrder.Controls.Add(Me.Label4, 8, 0)
        Me.TLPPurchaseOrder.Controls.Add(Me.Label5, 9, 0)
        Me.TLPPurchaseOrder.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TLPPurchaseOrder.Location = New System.Drawing.Point(3, 275)
        Me.TLPPurchaseOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TLPPurchaseOrder.Name = "TLPPurchaseOrder"
        Me.TLPPurchaseOrder.RowCount = 1
        Me.TLPPurchaseOrder.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPPurchaseOrder.Size = New System.Drawing.Size(2100, 80)
        Me.TLPPurchaseOrder.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(948, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 78)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "進貨數量"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1129, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 78)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "安全庫存"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1310, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 78)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "單位"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1491, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 78)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "庫存數量"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1672, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 78)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "進貨單價"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1853, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(263, 78)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "合計"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label11.Location = New System.Drawing.Point(671, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 66)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "供應商" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "統一編號"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label12.Location = New System.Drawing.Point(1138, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 66)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "供應商" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "名稱"
        '
        'LblAddRow
        '
        Me.LblAddRow.AutoSize = True
        Me.LblAddRow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAddRow.Font = New System.Drawing.Font("標楷體", 18.0!)
        Me.LblAddRow.ForeColor = System.Drawing.Color.Blue
        Me.LblAddRow.Location = New System.Drawing.Point(1575, 222)
        Me.LblAddRow.Name = "LblAddRow"
        Me.LblAddRow.Size = New System.Drawing.Size(133, 30)
        Me.LblAddRow.TabIndex = 11
        Me.LblAddRow.Text = "增加一列"
        '
        'BtnPrint_PurchaseOrder
        '
        Me.BtnPrint_PurchaseOrder.BorderColor = System.Drawing.Color.White
        Me.BtnPrint_PurchaseOrder.BorderRadius = 10
        Me.BtnPrint_PurchaseOrder.CheckedState.Parent = Me.BtnPrint_PurchaseOrder
        Me.BtnPrint_PurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint_PurchaseOrder.CustomImages.Parent = Me.BtnPrint_PurchaseOrder
        Me.BtnPrint_PurchaseOrder.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.BtnPrint_PurchaseOrder.ForeColor = System.Drawing.Color.White
        Me.BtnPrint_PurchaseOrder.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnPrint_PurchaseOrder.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnPrint_PurchaseOrder.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnPrint_PurchaseOrder.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnPrint_PurchaseOrder.HoverState.Parent = Me.BtnPrint_PurchaseOrder
        Me.BtnPrint_PurchaseOrder.Location = New System.Drawing.Point(1239, 206)
        Me.BtnPrint_PurchaseOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPrint_PurchaseOrder.Name = "BtnPrint_PurchaseOrder"
        Me.BtnPrint_PurchaseOrder.ShadowDecoration.Parent = Me.BtnPrint_PurchaseOrder
        Me.BtnPrint_PurchaseOrder.Size = New System.Drawing.Size(192, 65)
        Me.BtnPrint_PurchaseOrder.TabIndex = 9
        Me.BtnPrint_PurchaseOrder.Text = "列印進貨單"
        '
        'LblDelRow
        '
        Me.LblDelRow.AutoSize = True
        Me.LblDelRow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblDelRow.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.LblDelRow.ForeColor = System.Drawing.Color.Blue
        Me.LblDelRow.Location = New System.Drawing.Point(1449, 223)
        Me.LblDelRow.Name = "LblDelRow"
        Me.LblDelRow.Size = New System.Drawing.Size(124, 28)
        Me.LblDelRow.TabIndex = 10
        Me.LblDelRow.Text = "刪除一列"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(203, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 28)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "合計總價："
        '
        'lblToTalSum
        '
        Me.lblToTalSum.AutoSize = True
        Me.lblToTalSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblToTalSum.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.lblToTalSum.ForeColor = System.Drawing.Color.Red
        Me.lblToTalSum.Location = New System.Drawing.Point(347, 224)
        Me.lblToTalSum.Name = "lblToTalSum"
        Me.lblToTalSum.Size = New System.Drawing.Size(222, 28)
        Me.lblToTalSum.TabIndex = 8
        Me.lblToTalSum.Text = "***************"
        Me.lblToTalSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label15.Location = New System.Drawing.Point(21, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(253, 33)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "現在日期及時間"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
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
        Me.BtnSummation.Location = New System.Drawing.Point(27, 206)
        Me.BtnSummation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSummation.Name = "BtnSummation"
        Me.BtnSummation.ShadowDecoration.Parent = Me.BtnSummation
        Me.BtnSummation.Size = New System.Drawing.Size(157, 65)
        Me.BtnSummation.TabIndex = 6
        Me.BtnSummation.Text = "總合計"
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
        Me.BtnSave.Location = New System.Drawing.Point(1060, 206)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.Size = New System.Drawing.Size(157, 65)
        Me.BtnSave.TabIndex = 26
        Me.BtnSave.Text = "儲存"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.DateTimePicker1.BorderSize = 0
        Me.DateTimePicker1.CustomFormat = "yyyy年MM月dd日 HH:mm:ss"
        Me.DateTimePicker1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(285, 26)
        Me.DateTimePicker1.MinimumSize = New System.Drawing.Size(4, 35)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(499, 47)
        Me.DateTimePicker1.SkinColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.TabIndex = 100
        Me.DateTimePicker1.TextColor = System.Drawing.Color.White
        '
        'TxtSupply_Name
        '
        Me.TxtSupply_Name.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Name.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtSupply_Name.Location = New System.Drawing.Point(1261, 114)
        Me.TxtSupply_Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSupply_Name.Name = "TxtSupply_Name"
        Me.TxtSupply_Name.Size = New System.Drawing.Size(497, 65)
        Me.TxtSupply_Name.TabIndex = 5
        '
        'TxtSupply_Tax_ID
        '
        Me.TxtSupply_Tax_ID.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Tax_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Tax_ID.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtSupply_Tax_ID.Location = New System.Drawing.Point(828, 114)
        Me.TxtSupply_Tax_ID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSupply_Tax_ID.Name = "TxtSupply_Tax_ID"
        Me.TxtSupply_Tax_ID.Size = New System.Drawing.Size(271, 65)
        Me.TxtSupply_Tax_ID.TabIndex = 3
        '
        'TxtPurchaseOrderID
        '
        Me.TxtPurchaseOrderID.BackColor = System.Drawing.Color.White
        Me.TxtPurchaseOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPurchaseOrderID.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtPurchaseOrderID.Location = New System.Drawing.Point(220, 114)
        Me.TxtPurchaseOrderID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPurchaseOrderID.Name = "TxtPurchaseOrderID"
        Me.TxtPurchaseOrderID.Size = New System.Drawing.Size(414, 65)
        Me.TxtPurchaseOrderID.TabIndex = 1
        '
        'frmRSS_Access_PurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtSupply_Name)
        Me.Controls.Add(Me.TxtSupply_Tax_ID)
        Me.Controls.Add(Me.TxtPurchaseOrderID)
        Me.Controls.Add(Me.BtnSummation)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblToTalSum)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LblDelRow)
        Me.Controls.Add(Me.BtnPrint_PurchaseOrder)
        Me.Controls.Add(Me.LblAddRow)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TLPPurchaseOrder)
        Me.Controls.Add(Me.lblPurchaseOrderNo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRSS_Access_PurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "進貨單"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TLPPurchaseOrder.ResumeLayout(False)
        Me.TLPPurchaseOrder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPurchaseOrderNo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TLPPurchaseOrder As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LblAddRow As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnPrint_PurchaseOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblDelRow As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblToTalSum As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnSummation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtPurchaseOrderID As TableText
    Friend WithEvents TxtSupply_Tax_ID As TableText
    Friend WithEvents TxtSupply_Name As TableText
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents DateTimePicker1 As MCDateTimePicker
End Class
