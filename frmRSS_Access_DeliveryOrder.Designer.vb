<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRSS_Access_DeliveryOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_DeliveryOrder))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDeliveryOrderID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtSaleOrderID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCustomerTaxID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtFTName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtFTTaxID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGVDeliveryOrder = New System.Windows.Forms.DataGridView()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DGVDeliveryOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "出貨單編號"
        '
        'TxtDeliveryOrderID
        '
        Me.TxtDeliveryOrderID.BorderColor = System.Drawing.Color.Black
        Me.TxtDeliveryOrderID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDeliveryOrderID.DefaultText = ""
        Me.TxtDeliveryOrderID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDeliveryOrderID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDeliveryOrderID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDeliveryOrderID.DisabledState.Parent = Me.TxtDeliveryOrderID
        Me.TxtDeliveryOrderID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDeliveryOrderID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDeliveryOrderID.FocusedState.Parent = Me.TxtDeliveryOrderID
        Me.TxtDeliveryOrderID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeliveryOrderID.ForeColor = System.Drawing.Color.Black
        Me.TxtDeliveryOrderID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDeliveryOrderID.HoverState.Parent = Me.TxtDeliveryOrderID
        Me.TxtDeliveryOrderID.Location = New System.Drawing.Point(208, 26)
        Me.TxtDeliveryOrderID.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TxtDeliveryOrderID.Name = "TxtDeliveryOrderID"
        Me.TxtDeliveryOrderID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDeliveryOrderID.PlaceholderText = ""
        Me.TxtDeliveryOrderID.SelectedText = ""
        Me.TxtDeliveryOrderID.ShadowDecoration.Parent = Me.TxtDeliveryOrderID
        Me.TxtDeliveryOrderID.Size = New System.Drawing.Size(293, 65)
        Me.TxtDeliveryOrderID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(565, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "出貨單日期"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(770, 35)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(295, 47)
        Me.DateTimePicker1.TabIndex = 3
        '
        'TxtSaleOrderID
        '
        Me.TxtSaleOrderID.BorderColor = System.Drawing.Color.Black
        Me.TxtSaleOrderID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSaleOrderID.DefaultText = ""
        Me.TxtSaleOrderID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSaleOrderID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSaleOrderID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSaleOrderID.DisabledState.Parent = Me.TxtSaleOrderID
        Me.TxtSaleOrderID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSaleOrderID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSaleOrderID.FocusedState.Parent = Me.TxtSaleOrderID
        Me.TxtSaleOrderID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaleOrderID.ForeColor = System.Drawing.Color.Black
        Me.TxtSaleOrderID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSaleOrderID.HoverState.Parent = Me.TxtSaleOrderID
        Me.TxtSaleOrderID.Location = New System.Drawing.Point(1323, 26)
        Me.TxtSaleOrderID.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TxtSaleOrderID.Name = "TxtSaleOrderID"
        Me.TxtSaleOrderID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSaleOrderID.PlaceholderText = ""
        Me.TxtSaleOrderID.SelectedText = ""
        Me.TxtSaleOrderID.ShadowDecoration.Parent = Me.TxtSaleOrderID
        Me.TxtSaleOrderID.Size = New System.Drawing.Size(293, 65)
        Me.TxtSaleOrderID.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(1127, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "銷貨單編號"
        '
        'TxtCustomerTaxID
        '
        Me.TxtCustomerTaxID.BorderColor = System.Drawing.Color.Black
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
        Me.TxtCustomerTaxID.Location = New System.Drawing.Point(242, 122)
        Me.TxtCustomerTaxID.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TxtCustomerTaxID.Name = "TxtCustomerTaxID"
        Me.TxtCustomerTaxID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCustomerTaxID.PlaceholderText = ""
        Me.TxtCustomerTaxID.SelectedText = ""
        Me.TxtCustomerTaxID.ShadowDecoration.Parent = Me.TxtCustomerTaxID
        Me.TxtCustomerTaxID.Size = New System.Drawing.Size(293, 65)
        Me.TxtCustomerTaxID.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 33)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "客戶統一編號"
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BorderColor = System.Drawing.Color.Black
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
        Me.TxtCustomerName.Location = New System.Drawing.Point(733, 122)
        Me.TxtCustomerName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCustomerName.PlaceholderText = ""
        Me.TxtCustomerName.SelectedText = ""
        Me.TxtCustomerName.ShadowDecoration.Parent = Me.TxtCustomerName
        Me.TxtCustomerName.Size = New System.Drawing.Size(494, 65)
        Me.TxtCustomerName.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(571, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 33)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "客戶名稱"
        '
        'TxtFTName
        '
        Me.TxtFTName.BorderColor = System.Drawing.Color.Black
        Me.TxtFTName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFTName.DefaultText = ""
        Me.TxtFTName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFTName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFTName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFTName.DisabledState.Parent = Me.TxtFTName
        Me.TxtFTName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFTName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtFTName.FocusedState.Parent = Me.TxtFTName
        Me.TxtFTName.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFTName.ForeColor = System.Drawing.Color.Black
        Me.TxtFTName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtFTName.HoverState.Parent = Me.TxtFTName
        Me.TxtFTName.Location = New System.Drawing.Point(715, 215)
        Me.TxtFTName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TxtFTName.Name = "TxtFTName"
        Me.TxtFTName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFTName.PlaceholderText = ""
        Me.TxtFTName.SelectedText = ""
        Me.TxtFTName.ShadowDecoration.Parent = Me.TxtFTName
        Me.TxtFTName.Size = New System.Drawing.Size(512, 65)
        Me.TxtFTName.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(485, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 33)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "貨運公司名稱"
        '
        'TxtFTTaxID
        '
        Me.TxtFTTaxID.BorderColor = System.Drawing.Color.Black
        Me.TxtFTTaxID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFTTaxID.DefaultText = ""
        Me.TxtFTTaxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFTTaxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFTTaxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFTTaxID.DisabledState.Parent = Me.TxtFTTaxID
        Me.TxtFTTaxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFTTaxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtFTTaxID.FocusedState.Parent = Me.TxtFTTaxID
        Me.TxtFTTaxID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFTTaxID.ForeColor = System.Drawing.Color.Black
        Me.TxtFTTaxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtFTTaxID.HoverState.Parent = Me.TxtFTTaxID
        Me.TxtFTTaxID.Location = New System.Drawing.Point(174, 215)
        Me.TxtFTTaxID.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TxtFTTaxID.Name = "TxtFTTaxID"
        Me.TxtFTTaxID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFTTaxID.PlaceholderText = ""
        Me.TxtFTTaxID.SelectedText = ""
        Me.TxtFTTaxID.ShadowDecoration.Parent = Me.TxtFTTaxID
        Me.TxtFTTaxID.Size = New System.Drawing.Size(293, 65)
        Me.TxtFTTaxID.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 66)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "貨運公司" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "統一編號"
        '
        'DGVDeliveryOrder
        '
        Me.DGVDeliveryOrder.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDeliveryOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVDeliveryOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDeliveryOrder.Location = New System.Drawing.Point(18, 324)
        Me.DGVDeliveryOrder.Name = "DGVDeliveryOrder"
        Me.DGVDeliveryOrder.RowHeadersWidth = 51
        Me.DGVDeliveryOrder.RowTemplate.Height = 27
        Me.DGVDeliveryOrder.Size = New System.Drawing.Size(1894, 641)
        Me.DGVDeliveryOrder.TabIndex = 14
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(1383, 215)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(192, 65)
        Me.Guna2Button1.TabIndex = 15
        Me.Guna2Button1.Text = "儲存"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button2.BorderRadius = 5
        Me.Guna2Button2.BorderThickness = 1
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button2.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(1630, 215)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(192, 65)
        Me.Guna2Button2.TabIndex = 16
        Me.Guna2Button2.Text = "列印"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(1445, 122)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(293, 65)
        Me.Guna2TextBox1.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(1283, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 33)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "發票號碼"
        '
        'frmRSS_Access_DeliveryOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.DGVDeliveryOrder)
        Me.Controls.Add(Me.TxtFTName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtFTTaxID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCustomerName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCustomerTaxID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtSaleOrderID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDeliveryOrderID)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRSS_Access_DeliveryOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出貨單"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVDeliveryOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDeliveryOrderID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TxtSaleOrderID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCustomerTaxID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCustomerName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtFTName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtFTTaxID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DGVDeliveryOrder As DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BindingSource1 As BindingSource
End Class
