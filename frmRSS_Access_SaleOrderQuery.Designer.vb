<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRSS_Access_SaleOrderQuery
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_SaleOrderQuery))
        Me.TxtTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtSaleUnitPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSaleQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCommodityUnit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCommodityClassification = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCommodityName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCommodityID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSupplyName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSupplyTaxID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCustomerTaxID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtItemNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPSaleOrder_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSaleOrder_ID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDel = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnModify = New Guna.UI2.WinForms.Guna2Button()
        Me.DGVSaleOrder = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DGVSaleOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTotal
        '
        Me.TxtTotal.BorderColor = System.Drawing.Color.Black
        Me.TxtTotal.BorderRadius = 10
        Me.TxtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTotal.DefaultText = ""
        Me.TxtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotal.DisabledState.Parent = Me.TxtTotal
        Me.TxtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotal.FocusedState.Parent = Me.TxtTotal
        Me.TxtTotal.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.Color.Black
        Me.TxtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotal.HoverState.Parent = Me.TxtTotal
        Me.TxtTotal.Location = New System.Drawing.Point(1268, 406)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTotal.PlaceholderText = ""
        Me.TxtTotal.SelectedText = ""
        Me.TxtTotal.ShadowDecoration.Parent = Me.TxtTotal
        Me.TxtTotal.Size = New System.Drawing.Size(306, 62)
        Me.TxtTotal.TabIndex = 100
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(1110, 419)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(151, 33)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = "單項總價"
        '
        'TxtSaleUnitPrice
        '
        Me.TxtSaleUnitPrice.BorderColor = System.Drawing.Color.Black
        Me.TxtSaleUnitPrice.BorderRadius = 10
        Me.TxtSaleUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSaleUnitPrice.DefaultText = ""
        Me.TxtSaleUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSaleUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSaleUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSaleUnitPrice.DisabledState.Parent = Me.TxtSaleUnitPrice
        Me.TxtSaleUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSaleUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSaleUnitPrice.FocusedState.Parent = Me.TxtSaleUnitPrice
        Me.TxtSaleUnitPrice.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaleUnitPrice.ForeColor = System.Drawing.Color.Black
        Me.TxtSaleUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSaleUnitPrice.HoverState.Parent = Me.TxtSaleUnitPrice
        Me.TxtSaleUnitPrice.Location = New System.Drawing.Point(887, 406)
        Me.TxtSaleUnitPrice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtSaleUnitPrice.Name = "TxtSaleUnitPrice"
        Me.TxtSaleUnitPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSaleUnitPrice.PlaceholderText = ""
        Me.TxtSaleUnitPrice.SelectedText = ""
        Me.TxtSaleUnitPrice.ShadowDecoration.Parent = Me.TxtSaleUnitPrice
        Me.TxtSaleUnitPrice.Size = New System.Drawing.Size(182, 62)
        Me.TxtSaleUnitPrice.TabIndex = 98
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(717, 419)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 33)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "銷貨單價"
        '
        'TxtSaleQty
        '
        Me.TxtSaleQty.BorderColor = System.Drawing.Color.Black
        Me.TxtSaleQty.BorderRadius = 10
        Me.TxtSaleQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSaleQty.DefaultText = ""
        Me.TxtSaleQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSaleQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSaleQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSaleQty.DisabledState.Parent = Me.TxtSaleQty
        Me.TxtSaleQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSaleQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSaleQty.FocusedState.Parent = Me.TxtSaleQty
        Me.TxtSaleQty.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaleQty.ForeColor = System.Drawing.Color.Black
        Me.TxtSaleQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSaleQty.HoverState.Parent = Me.TxtSaleQty
        Me.TxtSaleQty.Location = New System.Drawing.Point(448, 406)
        Me.TxtSaleQty.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtSaleQty.Name = "TxtSaleQty"
        Me.TxtSaleQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSaleQty.PlaceholderText = ""
        Me.TxtSaleQty.SelectedText = ""
        Me.TxtSaleQty.ShadowDecoration.Parent = Me.TxtSaleQty
        Me.TxtSaleQty.Size = New System.Drawing.Size(204, 62)
        Me.TxtSaleQty.TabIndex = 96
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(290, 419)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 33)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "銷貨數量"
        '
        'TxtCommodityUnit
        '
        Me.TxtCommodityUnit.BorderColor = System.Drawing.Color.Black
        Me.TxtCommodityUnit.BorderRadius = 10
        Me.TxtCommodityUnit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCommodityUnit.DefaultText = ""
        Me.TxtCommodityUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCommodityUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCommodityUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCommodityUnit.DisabledState.Parent = Me.TxtCommodityUnit
        Me.TxtCommodityUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCommodityUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCommodityUnit.FocusedState.Parent = Me.TxtCommodityUnit
        Me.TxtCommodityUnit.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCommodityUnit.ForeColor = System.Drawing.Color.Black
        Me.TxtCommodityUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCommodityUnit.HoverState.Parent = Me.TxtCommodityUnit
        Me.TxtCommodityUnit.Location = New System.Drawing.Point(170, 406)
        Me.TxtCommodityUnit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCommodityUnit.Name = "TxtCommodityUnit"
        Me.TxtCommodityUnit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCommodityUnit.PlaceholderText = ""
        Me.TxtCommodityUnit.SelectedText = ""
        Me.TxtCommodityUnit.ShadowDecoration.Parent = Me.TxtCommodityUnit
        Me.TxtCommodityUnit.Size = New System.Drawing.Size(92, 62)
        Me.TxtCommodityUnit.TabIndex = 94
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 419)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 33)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "商品單位"
        '
        'TxtCommodityClassification
        '
        Me.TxtCommodityClassification.BorderColor = System.Drawing.Color.Black
        Me.TxtCommodityClassification.BorderRadius = 10
        Me.TxtCommodityClassification.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCommodityClassification.DefaultText = ""
        Me.TxtCommodityClassification.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCommodityClassification.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCommodityClassification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCommodityClassification.DisabledState.Parent = Me.TxtCommodityClassification
        Me.TxtCommodityClassification.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCommodityClassification.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCommodityClassification.FocusedState.Parent = Me.TxtCommodityClassification
        Me.TxtCommodityClassification.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCommodityClassification.ForeColor = System.Drawing.Color.Black
        Me.TxtCommodityClassification.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCommodityClassification.HoverState.Parent = Me.TxtCommodityClassification
        Me.TxtCommodityClassification.Location = New System.Drawing.Point(1608, 311)
        Me.TxtCommodityClassification.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCommodityClassification.Name = "TxtCommodityClassification"
        Me.TxtCommodityClassification.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCommodityClassification.PlaceholderText = ""
        Me.TxtCommodityClassification.SelectedText = ""
        Me.TxtCommodityClassification.ShadowDecoration.Parent = Me.TxtCommodityClassification
        Me.TxtCommodityClassification.Size = New System.Drawing.Size(201, 62)
        Me.TxtCommodityClassification.TabIndex = 92
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(1450, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 33)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "商品分類"
        '
        'TxtCommodityName
        '
        Me.TxtCommodityName.BorderColor = System.Drawing.Color.Black
        Me.TxtCommodityName.BorderRadius = 10
        Me.TxtCommodityName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCommodityName.DefaultText = ""
        Me.TxtCommodityName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCommodityName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCommodityName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCommodityName.DisabledState.Parent = Me.TxtCommodityName
        Me.TxtCommodityName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCommodityName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCommodityName.FocusedState.Parent = Me.TxtCommodityName
        Me.TxtCommodityName.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCommodityName.ForeColor = System.Drawing.Color.Black
        Me.TxtCommodityName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCommodityName.HoverState.Parent = Me.TxtCommodityName
        Me.TxtCommodityName.Location = New System.Drawing.Point(705, 311)
        Me.TxtCommodityName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCommodityName.Name = "TxtCommodityName"
        Me.TxtCommodityName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCommodityName.PlaceholderText = ""
        Me.TxtCommodityName.SelectedText = ""
        Me.TxtCommodityName.ShadowDecoration.Parent = Me.TxtCommodityName
        Me.TxtCommodityName.Size = New System.Drawing.Size(678, 62)
        Me.TxtCommodityName.TabIndex = 90
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(541, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 33)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "商品名稱"
        '
        'TxtCommodityID
        '
        Me.TxtCommodityID.BorderColor = System.Drawing.Color.Black
        Me.TxtCommodityID.BorderRadius = 10
        Me.TxtCommodityID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCommodityID.DefaultText = ""
        Me.TxtCommodityID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCommodityID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCommodityID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCommodityID.DisabledState.Parent = Me.TxtCommodityID
        Me.TxtCommodityID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCommodityID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCommodityID.FocusedState.Parent = Me.TxtCommodityID
        Me.TxtCommodityID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCommodityID.ForeColor = System.Drawing.Color.Black
        Me.TxtCommodityID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCommodityID.HoverState.Parent = Me.TxtCommodityID
        Me.TxtCommodityID.Location = New System.Drawing.Point(170, 311)
        Me.TxtCommodityID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCommodityID.Name = "TxtCommodityID"
        Me.TxtCommodityID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCommodityID.PlaceholderText = ""
        Me.TxtCommodityID.SelectedText = ""
        Me.TxtCommodityID.ShadowDecoration.Parent = Me.TxtCommodityID
        Me.TxtCommodityID.Size = New System.Drawing.Size(306, 62)
        Me.TxtCommodityID.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 33)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "商品編號"
        '
        'TxtSupplyName
        '
        Me.TxtSupplyName.BorderColor = System.Drawing.Color.Black
        Me.TxtSupplyName.BorderRadius = 10
        Me.TxtSupplyName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSupplyName.DefaultText = ""
        Me.TxtSupplyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSupplyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSupplyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSupplyName.DisabledState.Parent = Me.TxtSupplyName
        Me.TxtSupplyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSupplyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSupplyName.FocusedState.Parent = Me.TxtSupplyName
        Me.TxtSupplyName.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupplyName.ForeColor = System.Drawing.Color.Black
        Me.TxtSupplyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSupplyName.HoverState.Parent = Me.TxtSupplyName
        Me.TxtSupplyName.Location = New System.Drawing.Point(852, 219)
        Me.TxtSupplyName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtSupplyName.Name = "TxtSupplyName"
        Me.TxtSupplyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSupplyName.PlaceholderText = ""
        Me.TxtSupplyName.SelectedText = ""
        Me.TxtSupplyName.ShadowDecoration.Parent = Me.TxtSupplyName
        Me.TxtSupplyName.Size = New System.Drawing.Size(654, 62)
        Me.TxtSupplyName.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(650, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 33)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "供應商名稱"
        '
        'TxtSupplyTaxID
        '
        Me.TxtSupplyTaxID.BorderColor = System.Drawing.Color.Black
        Me.TxtSupplyTaxID.BorderRadius = 10
        Me.TxtSupplyTaxID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSupplyTaxID.DefaultText = ""
        Me.TxtSupplyTaxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSupplyTaxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSupplyTaxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSupplyTaxID.DisabledState.Parent = Me.TxtSupplyTaxID
        Me.TxtSupplyTaxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSupplyTaxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSupplyTaxID.FocusedState.Parent = Me.TxtSupplyTaxID
        Me.TxtSupplyTaxID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupplyTaxID.ForeColor = System.Drawing.Color.Black
        Me.TxtSupplyTaxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSupplyTaxID.HoverState.Parent = Me.TxtSupplyTaxID
        Me.TxtSupplyTaxID.Location = New System.Drawing.Point(282, 219)
        Me.TxtSupplyTaxID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtSupplyTaxID.Name = "TxtSupplyTaxID"
        Me.TxtSupplyTaxID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSupplyTaxID.PlaceholderText = ""
        Me.TxtSupplyTaxID.SelectedText = ""
        Me.TxtSupplyTaxID.ShadowDecoration.Parent = Me.TxtSupplyTaxID
        Me.TxtSupplyTaxID.Size = New System.Drawing.Size(306, 62)
        Me.TxtSupplyTaxID.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(253, 33)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "供應商統一編號"
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BorderColor = System.Drawing.Color.Black
        Me.TxtCustomerName.BorderRadius = 10
        Me.TxtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCustomerName.DefaultText = ""
        Me.TxtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCustomerName.DisabledState.Parent = Me.TxtCustomerName
        Me.TxtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCustomerName.FocusedState.Parent = Me.TxtCustomerName
        Me.TxtCustomerName.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.ForeColor = System.Drawing.Color.Black
        Me.TxtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCustomerName.HoverState.Parent = Me.TxtCustomerName
        Me.TxtCustomerName.Location = New System.Drawing.Point(832, 121)
        Me.TxtCustomerName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCustomerName.PlaceholderText = ""
        Me.TxtCustomerName.SelectedText = ""
        Me.TxtCustomerName.ShadowDecoration.Parent = Me.TxtCustomerName
        Me.TxtCustomerName.Size = New System.Drawing.Size(654, 65)
        Me.TxtCustomerName.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(661, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 33)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "客戶名稱"
        '
        'TxtCustomerTaxID
        '
        Me.TxtCustomerTaxID.BorderColor = System.Drawing.Color.Black
        Me.TxtCustomerTaxID.BorderRadius = 10
        Me.TxtCustomerTaxID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCustomerTaxID.DefaultText = ""
        Me.TxtCustomerTaxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCustomerTaxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCustomerTaxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCustomerTaxID.DisabledState.Parent = Me.TxtCustomerTaxID
        Me.TxtCustomerTaxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCustomerTaxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCustomerTaxID.FocusedState.Parent = Me.TxtCustomerTaxID
        Me.TxtCustomerTaxID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerTaxID.ForeColor = System.Drawing.Color.Black
        Me.TxtCustomerTaxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCustomerTaxID.HoverState.Parent = Me.TxtCustomerTaxID
        Me.TxtCustomerTaxID.Location = New System.Drawing.Point(242, 124)
        Me.TxtCustomerTaxID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCustomerTaxID.Name = "TxtCustomerTaxID"
        Me.TxtCustomerTaxID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCustomerTaxID.PlaceholderText = ""
        Me.TxtCustomerTaxID.SelectedText = ""
        Me.TxtCustomerTaxID.ShadowDecoration.Parent = Me.TxtCustomerTaxID
        Me.TxtCustomerTaxID.Size = New System.Drawing.Size(306, 62)
        Me.TxtCustomerTaxID.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 33)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "客戶統一編號"
        '
        'TxtItemNo
        '
        Me.TxtItemNo.BorderColor = System.Drawing.Color.Black
        Me.TxtItemNo.BorderRadius = 10
        Me.TxtItemNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtItemNo.DefaultText = ""
        Me.TxtItemNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtItemNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtItemNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtItemNo.DisabledState.Parent = Me.TxtItemNo
        Me.TxtItemNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtItemNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtItemNo.FocusedState.Parent = Me.TxtItemNo
        Me.TxtItemNo.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemNo.ForeColor = System.Drawing.Color.Black
        Me.TxtItemNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtItemNo.HoverState.Parent = Me.TxtItemNo
        Me.TxtItemNo.Location = New System.Drawing.Point(918, 29)
        Me.TxtItemNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtItemNo.Name = "TxtItemNo"
        Me.TxtItemNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtItemNo.PlaceholderText = ""
        Me.TxtItemNo.SelectedText = ""
        Me.TxtItemNo.ShadowDecoration.Parent = Me.TxtItemNo
        Me.TxtItemNo.Size = New System.Drawing.Size(102, 62)
        Me.TxtItemNo.TabIndex = 75
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(828, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 33)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "項次"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(1043, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 33)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "銷貨單日期"
        '
        'DTPSaleOrder_Date
        '
        Me.DTPSaleOrder_Date.CalendarFont = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DTPSaleOrder_Date.CustomFormat = "yyyy年MM月dd日"
        Me.DTPSaleOrder_Date.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DTPSaleOrder_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPSaleOrder_Date.Location = New System.Drawing.Point(1256, 37)
        Me.DTPSaleOrder_Date.Name = "DTPSaleOrder_Date"
        Me.DTPSaleOrder_Date.Size = New System.Drawing.Size(286, 47)
        Me.DTPSaleOrder_Date.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 33)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "銷貨單編號"
        '
        'TxtSaleOrder_ID
        '
        Me.TxtSaleOrder_ID.BorderColor = System.Drawing.Color.Black
        Me.TxtSaleOrder_ID.BorderRadius = 10
        Me.TxtSaleOrder_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSaleOrder_ID.DefaultText = ""
        Me.TxtSaleOrder_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSaleOrder_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSaleOrder_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSaleOrder_ID.DisabledState.Parent = Me.TxtSaleOrder_ID
        Me.TxtSaleOrder_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSaleOrder_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSaleOrder_ID.FocusedState.Parent = Me.TxtSaleOrder_ID
        Me.TxtSaleOrder_ID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaleOrder_ID.ForeColor = System.Drawing.Color.Black
        Me.TxtSaleOrder_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSaleOrder_ID.HoverState.Parent = Me.TxtSaleOrder_ID
        Me.TxtSaleOrder_ID.Location = New System.Drawing.Point(222, 28)
        Me.TxtSaleOrder_ID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtSaleOrder_ID.Name = "TxtSaleOrder_ID"
        Me.TxtSaleOrder_ID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSaleOrder_ID.PlaceholderText = ""
        Me.TxtSaleOrder_ID.SelectedText = ""
        Me.TxtSaleOrder_ID.ShadowDecoration.Parent = Me.TxtSaleOrder_ID
        Me.TxtSaleOrder_ID.Size = New System.Drawing.Size(306, 62)
        Me.TxtSaleOrder_ID.TabIndex = 73
        '
        'BtnSearch
        '
        Me.BtnSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSearch.BorderRadius = 10
        Me.BtnSearch.BorderThickness = 1
        Me.BtnSearch.CheckedState.Parent = Me.BtnSearch
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.CustomBorderColor = System.Drawing.Color.White
        Me.BtnSearch.CustomImages.Parent = Me.BtnSearch
        Me.BtnSearch.FillColor = System.Drawing.Color.White
        Me.BtnSearch.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSearch.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSearch.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.HoverState.Parent = Me.BtnSearch
        Me.BtnSearch.Location = New System.Drawing.Point(551, 28)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.ShadowDecoration.Parent = Me.BtnSearch
        Me.BtnSearch.Size = New System.Drawing.Size(231, 62)
        Me.BtnSearch.TabIndex = 74
        Me.BtnSearch.Text = "查詢"
        '
        'BtnPrint
        '
        Me.BtnPrint.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPrint.BorderRadius = 10
        Me.BtnPrint.BorderThickness = 1
        Me.BtnPrint.CheckedState.Parent = Me.BtnPrint
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.CustomImages.Parent = Me.BtnPrint
        Me.BtnPrint.FillColor = System.Drawing.Color.White
        Me.BtnPrint.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPrint.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPrint.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPrint.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPrint.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnPrint.HoverState.Parent = Me.BtnPrint
        Me.BtnPrint.Location = New System.Drawing.Point(970, 511)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.ShadowDecoration.Parent = Me.BtnPrint
        Me.BtnPrint.Size = New System.Drawing.Size(231, 65)
        Me.BtnPrint.TabIndex = 71
        Me.BtnPrint.Text = "列印"
        '
        'BtnReset
        '
        Me.BtnReset.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnReset.BorderRadius = 10
        Me.BtnReset.BorderThickness = 1
        Me.BtnReset.CheckedState.Parent = Me.BtnReset
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.CustomImages.Parent = Me.BtnReset
        Me.BtnReset.FillColor = System.Drawing.Color.White
        Me.BtnReset.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnReset.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnReset.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnReset.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnReset.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnReset.HoverState.Parent = Me.BtnReset
        Me.BtnReset.Location = New System.Drawing.Point(656, 511)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.ShadowDecoration.Parent = Me.BtnReset
        Me.BtnReset.Size = New System.Drawing.Size(231, 65)
        Me.BtnReset.TabIndex = 70
        Me.BtnReset.Text = "重設"
        '
        'BtnDel
        '
        Me.BtnDel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDel.BorderRadius = 10
        Me.BtnDel.BorderThickness = 1
        Me.BtnDel.CheckedState.Parent = Me.BtnDel
        Me.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDel.CustomImages.Parent = Me.BtnDel
        Me.BtnDel.FillColor = System.Drawing.Color.White
        Me.BtnDel.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDel.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDel.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDel.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnDel.HoverState.Parent = Me.BtnDel
        Me.BtnDel.Location = New System.Drawing.Point(342, 511)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.ShadowDecoration.Parent = Me.BtnDel
        Me.BtnDel.Size = New System.Drawing.Size(231, 65)
        Me.BtnDel.TabIndex = 69
        Me.BtnDel.Text = "刪除"
        '
        'BtnModify
        '
        Me.BtnModify.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnModify.BorderRadius = 10
        Me.BtnModify.BorderThickness = 1
        Me.BtnModify.CheckedState.Parent = Me.BtnModify
        Me.BtnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModify.CustomImages.Parent = Me.BtnModify
        Me.BtnModify.FillColor = System.Drawing.Color.White
        Me.BtnModify.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnModify.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnModify.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnModify.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnModify.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnModify.HoverState.Parent = Me.BtnModify
        Me.BtnModify.Location = New System.Drawing.Point(28, 511)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.ShadowDecoration.Parent = Me.BtnModify
        Me.BtnModify.Size = New System.Drawing.Size(231, 65)
        Me.BtnModify.TabIndex = 68
        Me.BtnModify.Text = "修改"
        '
        'DGVSaleOrder
        '
        Me.DGVSaleOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVSaleOrder.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSaleOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVSaleOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSaleOrder.Location = New System.Drawing.Point(14, 618)
        Me.DGVSaleOrder.Name = "DGVSaleOrder"
        Me.DGVSaleOrder.RowHeadersWidth = 51
        Me.DGVSaleOrder.RowTemplate.Height = 27
        Me.DGVSaleOrder.Size = New System.Drawing.Size(1900, 376)
        Me.DGVSaleOrder.TabIndex = 67
        '
        'frmRSS_Access_SaleOrderQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtSaleUnitPrice)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtSaleQty)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtCommodityUnit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtCommodityClassification)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtCommodityName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtCommodityID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtSupplyName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtSupplyTaxID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCustomerName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCustomerTaxID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtItemNo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTPSaleOrder_Date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSaleOrder_ID)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.DGVSaleOrder)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRSS_Access_SaleOrderQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "銷貨單查詢修改刪除"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVSaleOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtSaleUnitPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtSaleQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtCommodityUnit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCommodityClassification As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCommodityName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCommodityID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtSupplyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSupplyTaxID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCustomerName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCustomerTaxID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtItemNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DTPSaleOrder_Date As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSaleOrder_ID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnModify As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGVSaleOrder As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
End Class
