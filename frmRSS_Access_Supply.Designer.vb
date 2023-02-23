<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRSS_Access_Supply
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_Supply))
        Me.lblDateTimeNow = New System.Windows.Forms.Label()
        Me.lblSupply_Tax_ID = New System.Windows.Forms.Label()
        Me.lblSupply_Co_Name = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblSupply_Co_Tel = New System.Windows.Forms.Label()
        Me.ComBPhoneCode = New System.Windows.Forms.ComboBox()
        Me.lblSupply_Co_Address = New System.Windows.Forms.Label()
        Me.lblSupply_Present_Name = New System.Windows.Forms.Label()
        Me.lblSupply_Present_CellPhone = New System.Windows.Forms.Label()
        Me.lblCellphone09 = New System.Windows.Forms.Label()
        Me.lblChargeName = New System.Windows.Forms.Label()
        Me.lblChargeDepartment = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblChargeCellPhone = New System.Windows.Forms.Label()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDel = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.DGVSupply = New System.Windows.Forms.DataGridView()
        Me.lblCharge_JobTitle = New System.Windows.Forms.Label()
        Me.lblPresident_JobTitle = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtChargeCellphone = New RSS_Access.TableText()
        Me.TxtCharge_JobTitle = New RSS_Access.TableText()
        Me.TxtChargeDepartment = New RSS_Access.TableText()
        Me.TxtChargeName = New RSS_Access.TableText()
        Me.TxtSupply_Present_CellPhone = New RSS_Access.TableText()
        Me.TxtPresident_JobTitle = New RSS_Access.TableText()
        Me.TxtSupply_Present_Name = New RSS_Access.TableText()
        Me.TxtSupply_Co_Address = New RSS_Access.TableText()
        Me.TxtSupply_Co_Phone = New RSS_Access.TableText()
        Me.TxtSupply_Co_Name = New RSS_Access.TableText()
        Me.TxtSupply_Tax_ID = New RSS_Access.TableText()
        Me.DateTimePicker1 = New RSS_Access.MCDateTimePicker()
        CType(Me.DGVSupply, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDateTimeNow
        '
        Me.lblDateTimeNow.AutoSize = True
        Me.lblDateTimeNow.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblDateTimeNow.Location = New System.Drawing.Point(22, 31)
        Me.lblDateTimeNow.Name = "lblDateTimeNow"
        Me.lblDateTimeNow.Size = New System.Drawing.Size(253, 33)
        Me.lblDateTimeNow.TabIndex = 98
        Me.lblDateTimeNow.Text = "現在日期跟時間"
        '
        'lblSupply_Tax_ID
        '
        Me.lblSupply_Tax_ID.AutoSize = True
        Me.lblSupply_Tax_ID.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblSupply_Tax_ID.Location = New System.Drawing.Point(23, 113)
        Me.lblSupply_Tax_ID.Name = "lblSupply_Tax_ID"
        Me.lblSupply_Tax_ID.Size = New System.Drawing.Size(151, 33)
        Me.lblSupply_Tax_ID.TabIndex = 0
        Me.lblSupply_Tax_ID.Text = "統一編號"
        '
        'lblSupply_Co_Name
        '
        Me.lblSupply_Co_Name.AutoSize = True
        Me.lblSupply_Co_Name.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblSupply_Co_Name.Location = New System.Drawing.Point(403, 113)
        Me.lblSupply_Co_Name.Name = "lblSupply_Co_Name"
        Me.lblSupply_Co_Name.Size = New System.Drawing.Size(219, 33)
        Me.lblSupply_Co_Name.TabIndex = 2
        Me.lblSupply_Co_Name.Text = "公司行號名稱"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblSupply_Co_Tel
        '
        Me.lblSupply_Co_Tel.AutoSize = True
        Me.lblSupply_Co_Tel.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblSupply_Co_Tel.Location = New System.Drawing.Point(22, 220)
        Me.lblSupply_Co_Tel.Name = "lblSupply_Co_Tel"
        Me.lblSupply_Co_Tel.Size = New System.Drawing.Size(83, 33)
        Me.lblSupply_Co_Tel.TabIndex = 4
        Me.lblSupply_Co_Tel.Text = "電話"
        '
        'ComBPhoneCode
        '
        Me.ComBPhoneCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ComBPhoneCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComBPhoneCode.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.ComBPhoneCode.ForeColor = System.Drawing.Color.White
        Me.ComBPhoneCode.FormattingEnabled = True
        Me.ComBPhoneCode.Items.AddRange(New Object() {"請選擇區碼", "02", "03", "037", "04", "049", "05", "06", "07", "08", "082", "089"})
        Me.ComBPhoneCode.Location = New System.Drawing.Point(106, 220)
        Me.ComBPhoneCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComBPhoneCode.Name = "ComBPhoneCode"
        Me.ComBPhoneCode.Size = New System.Drawing.Size(193, 35)
        Me.ComBPhoneCode.TabIndex = 5
        Me.ComBPhoneCode.Text = "請選擇區碼"
        '
        'lblSupply_Co_Address
        '
        Me.lblSupply_Co_Address.AutoSize = True
        Me.lblSupply_Co_Address.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblSupply_Co_Address.Location = New System.Drawing.Point(541, 220)
        Me.lblSupply_Co_Address.Name = "lblSupply_Co_Address"
        Me.lblSupply_Co_Address.Size = New System.Drawing.Size(83, 33)
        Me.lblSupply_Co_Address.TabIndex = 7
        Me.lblSupply_Co_Address.Text = "地址"
        '
        'lblSupply_Present_Name
        '
        Me.lblSupply_Present_Name.AutoSize = True
        Me.lblSupply_Present_Name.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblSupply_Present_Name.Location = New System.Drawing.Point(23, 332)
        Me.lblSupply_Present_Name.Name = "lblSupply_Present_Name"
        Me.lblSupply_Present_Name.Size = New System.Drawing.Size(185, 33)
        Me.lblSupply_Present_Name.TabIndex = 9
        Me.lblSupply_Present_Name.Text = "負責人姓名"
        '
        'lblSupply_Present_CellPhone
        '
        Me.lblSupply_Present_CellPhone.AutoSize = True
        Me.lblSupply_Present_CellPhone.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblSupply_Present_CellPhone.Location = New System.Drawing.Point(949, 332)
        Me.lblSupply_Present_CellPhone.Name = "lblSupply_Present_CellPhone"
        Me.lblSupply_Present_CellPhone.Size = New System.Drawing.Size(151, 33)
        Me.lblSupply_Present_CellPhone.TabIndex = 13
        Me.lblSupply_Present_CellPhone.Text = "手機號碼"
        '
        'lblCellphone09
        '
        Me.lblCellphone09.AutoSize = True
        Me.lblCellphone09.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblCellphone09.Location = New System.Drawing.Point(1104, 332)
        Me.lblCellphone09.Name = "lblCellphone09"
        Me.lblCellphone09.Size = New System.Drawing.Size(49, 33)
        Me.lblCellphone09.TabIndex = 14
        Me.lblCellphone09.Text = "09"
        '
        'lblChargeName
        '
        Me.lblChargeName.AutoSize = True
        Me.lblChargeName.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblChargeName.Location = New System.Drawing.Point(23, 439)
        Me.lblChargeName.Name = "lblChargeName"
        Me.lblChargeName.Size = New System.Drawing.Size(185, 33)
        Me.lblChargeName.TabIndex = 16
        Me.lblChargeName.Text = "接洽人姓名"
        '
        'lblChargeDepartment
        '
        Me.lblChargeDepartment.AutoSize = True
        Me.lblChargeDepartment.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblChargeDepartment.Location = New System.Drawing.Point(541, 439)
        Me.lblChargeDepartment.Name = "lblChargeDepartment"
        Me.lblChargeDepartment.Size = New System.Drawing.Size(83, 33)
        Me.lblChargeDepartment.TabIndex = 18
        Me.lblChargeDepartment.Text = "部門"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label2.Location = New System.Drawing.Point(1504, 439)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 33)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "09"
        '
        'lblChargeCellPhone
        '
        Me.lblChargeCellPhone.AutoSize = True
        Me.lblChargeCellPhone.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblChargeCellPhone.Location = New System.Drawing.Point(1352, 439)
        Me.lblChargeCellPhone.Name = "lblChargeCellPhone"
        Me.lblChargeCellPhone.Size = New System.Drawing.Size(151, 33)
        Me.lblChargeCellPhone.TabIndex = 22
        Me.lblChargeCellPhone.Text = "手機號碼"
        '
        'BtnAdd
        '
        Me.BtnAdd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdd.BorderRadius = 10
        Me.BtnAdd.BorderThickness = 1
        Me.BtnAdd.CheckedState.Parent = Me.BtnAdd
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.CustomImages.Parent = Me.BtnAdd
        Me.BtnAdd.FillColor = System.Drawing.Color.White
        Me.BtnAdd.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdd.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnAdd.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnAdd.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnAdd.HoverState.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.BtnAdd.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.HoverState.Parent = Me.BtnAdd
        Me.BtnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnAdd.Location = New System.Drawing.Point(29, 524)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.ShadowDecoration.Parent = Me.BtnAdd
        Me.BtnAdd.Size = New System.Drawing.Size(200, 65)
        Me.BtnAdd.TabIndex = 25
        Me.BtnAdd.Text = "新增"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.White
        Me.BtnUpdate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdate.BorderRadius = 10
        Me.BtnUpdate.BorderThickness = 1
        Me.BtnUpdate.CheckedState.Parent = Me.BtnUpdate
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnUpdate.CustomImages.Parent = Me.BtnUpdate
        Me.BtnUpdate.FillColor = System.Drawing.Color.White
        Me.BtnUpdate.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdate.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnUpdate.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnUpdate.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnUpdate.HoverState.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.BtnUpdate.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.HoverState.Parent = Me.BtnUpdate
        Me.BtnUpdate.Location = New System.Drawing.Point(305, 524)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.ShadowDecoration.Parent = Me.BtnUpdate
        Me.BtnUpdate.Size = New System.Drawing.Size(200, 65)
        Me.BtnUpdate.TabIndex = 26
        Me.BtnUpdate.Text = "修改"
        '
        'BtnDel
        '
        Me.BtnDel.BackColor = System.Drawing.Color.White
        Me.BtnDel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDel.BorderRadius = 10
        Me.BtnDel.BorderThickness = 1
        Me.BtnDel.CheckedState.Parent = Me.BtnDel
        Me.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDel.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnDel.CustomImages.Parent = Me.BtnDel
        Me.BtnDel.FillColor = System.Drawing.Color.White
        Me.BtnDel.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.BtnDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDel.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnDel.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnDel.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnDel.HoverState.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.BtnDel.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnDel.HoverState.Parent = Me.BtnDel
        Me.BtnDel.Location = New System.Drawing.Point(581, 524)
        Me.BtnDel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.ShadowDecoration.Parent = Me.BtnDel
        Me.BtnDel.Size = New System.Drawing.Size(200, 65)
        Me.BtnDel.TabIndex = 27
        Me.BtnDel.Text = "刪除"
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.White
        Me.BtnReset.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnReset.BorderRadius = 10
        Me.BtnReset.BorderThickness = 1
        Me.BtnReset.CheckedState.Parent = Me.BtnReset
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnReset.CustomImages.Parent = Me.BtnReset
        Me.BtnReset.FillColor = System.Drawing.Color.White
        Me.BtnReset.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.BtnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnReset.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnReset.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnReset.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnReset.HoverState.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.BtnReset.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnReset.HoverState.Parent = Me.BtnReset
        Me.BtnReset.Location = New System.Drawing.Point(857, 524)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.ShadowDecoration.Parent = Me.BtnReset
        Me.BtnReset.Size = New System.Drawing.Size(200, 65)
        Me.BtnReset.TabIndex = 28
        Me.BtnReset.Text = "重填"
        '
        'DGVSupply
        '
        Me.DGVSupply.BackgroundColor = System.Drawing.Color.White
        Me.DGVSupply.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSupply.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVSupply.ColumnHeadersHeight = 50
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVSupply.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVSupply.GridColor = System.Drawing.Color.Black
        Me.DGVSupply.Location = New System.Drawing.Point(5, 618)
        Me.DGVSupply.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVSupply.Name = "DGVSupply"
        Me.DGVSupply.RowHeadersWidth = 51
        Me.DGVSupply.RowTemplate.Height = 29
        Me.DGVSupply.Size = New System.Drawing.Size(2052, 540)
        Me.DGVSupply.TabIndex = 29
        '
        'lblCharge_JobTitle
        '
        Me.lblCharge_JobTitle.AutoSize = True
        Me.lblCharge_JobTitle.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblCharge_JobTitle.Location = New System.Drawing.Point(960, 439)
        Me.lblCharge_JobTitle.Name = "lblCharge_JobTitle"
        Me.lblCharge_JobTitle.Size = New System.Drawing.Size(83, 33)
        Me.lblCharge_JobTitle.TabIndex = 20
        Me.lblCharge_JobTitle.Text = "職稱"
        '
        'lblPresident_JobTitle
        '
        Me.lblPresident_JobTitle.AutoSize = True
        Me.lblPresident_JobTitle.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblPresident_JobTitle.Location = New System.Drawing.Point(541, 332)
        Me.lblPresident_JobTitle.Name = "lblPresident_JobTitle"
        Me.lblPresident_JobTitle.Size = New System.Drawing.Size(83, 33)
        Me.lblPresident_JobTitle.TabIndex = 11
        Me.lblPresident_JobTitle.Text = "職稱"
        '
        'TxtChargeCellphone
        '
        Me.TxtChargeCellphone.BackColor = System.Drawing.Color.White
        Me.TxtChargeCellphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtChargeCellphone.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtChargeCellphone.Location = New System.Drawing.Point(1559, 423)
        Me.TxtChargeCellphone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtChargeCellphone.Name = "TxtChargeCellphone"
        Me.TxtChargeCellphone.Size = New System.Drawing.Size(178, 65)
        Me.TxtChargeCellphone.TabIndex = 24
        '
        'TxtCharge_JobTitle
        '
        Me.TxtCharge_JobTitle.BackColor = System.Drawing.Color.White
        Me.TxtCharge_JobTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCharge_JobTitle.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCharge_JobTitle.Location = New System.Drawing.Point(1047, 423)
        Me.TxtCharge_JobTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCharge_JobTitle.Name = "TxtCharge_JobTitle"
        Me.TxtCharge_JobTitle.Size = New System.Drawing.Size(276, 65)
        Me.TxtCharge_JobTitle.TabIndex = 21
        '
        'TxtChargeDepartment
        '
        Me.TxtChargeDepartment.BackColor = System.Drawing.Color.White
        Me.TxtChargeDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtChargeDepartment.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtChargeDepartment.Location = New System.Drawing.Point(639, 423)
        Me.TxtChargeDepartment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtChargeDepartment.Name = "TxtChargeDepartment"
        Me.TxtChargeDepartment.Size = New System.Drawing.Size(276, 65)
        Me.TxtChargeDepartment.TabIndex = 19
        '
        'TxtChargeName
        '
        Me.TxtChargeName.BackColor = System.Drawing.Color.White
        Me.TxtChargeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtChargeName.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtChargeName.Location = New System.Drawing.Point(217, 423)
        Me.TxtChargeName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtChargeName.Name = "TxtChargeName"
        Me.TxtChargeName.Size = New System.Drawing.Size(276, 65)
        Me.TxtChargeName.TabIndex = 17
        '
        'TxtSupply_Present_CellPhone
        '
        Me.TxtSupply_Present_CellPhone.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Present_CellPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Present_CellPhone.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtSupply_Present_CellPhone.Location = New System.Drawing.Point(1153, 316)
        Me.TxtSupply_Present_CellPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSupply_Present_CellPhone.Name = "TxtSupply_Present_CellPhone"
        Me.TxtSupply_Present_CellPhone.Size = New System.Drawing.Size(178, 65)
        Me.TxtSupply_Present_CellPhone.TabIndex = 15
        '
        'TxtPresident_JobTitle
        '
        Me.TxtPresident_JobTitle.BackColor = System.Drawing.Color.White
        Me.TxtPresident_JobTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPresident_JobTitle.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtPresident_JobTitle.Location = New System.Drawing.Point(639, 316)
        Me.TxtPresident_JobTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPresident_JobTitle.Name = "TxtPresident_JobTitle"
        Me.TxtPresident_JobTitle.Size = New System.Drawing.Size(276, 65)
        Me.TxtPresident_JobTitle.TabIndex = 12
        '
        'TxtSupply_Present_Name
        '
        Me.TxtSupply_Present_Name.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Present_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Present_Name.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtSupply_Present_Name.Location = New System.Drawing.Point(217, 316)
        Me.TxtSupply_Present_Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSupply_Present_Name.Name = "TxtSupply_Present_Name"
        Me.TxtSupply_Present_Name.Size = New System.Drawing.Size(276, 65)
        Me.TxtSupply_Present_Name.TabIndex = 10
        '
        'TxtSupply_Co_Address
        '
        Me.TxtSupply_Co_Address.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Co_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Co_Address.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtSupply_Co_Address.Location = New System.Drawing.Point(639, 204)
        Me.TxtSupply_Co_Address.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSupply_Co_Address.Name = "TxtSupply_Co_Address"
        Me.TxtSupply_Co_Address.Size = New System.Drawing.Size(765, 65)
        Me.TxtSupply_Co_Address.TabIndex = 8
        '
        'TxtSupply_Co_Phone
        '
        Me.TxtSupply_Co_Phone.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Co_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Co_Phone.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtSupply_Co_Phone.Location = New System.Drawing.Point(305, 204)
        Me.TxtSupply_Co_Phone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSupply_Co_Phone.Name = "TxtSupply_Co_Phone"
        Me.TxtSupply_Co_Phone.Size = New System.Drawing.Size(178, 65)
        Me.TxtSupply_Co_Phone.TabIndex = 6
        '
        'TxtSupply_Co_Name
        '
        Me.TxtSupply_Co_Name.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Co_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Co_Name.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtSupply_Co_Name.Location = New System.Drawing.Point(639, 97)
        Me.TxtSupply_Co_Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSupply_Co_Name.Name = "TxtSupply_Co_Name"
        Me.TxtSupply_Co_Name.Size = New System.Drawing.Size(765, 65)
        Me.TxtSupply_Co_Name.TabIndex = 3
        '
        'TxtSupply_Tax_ID
        '
        Me.TxtSupply_Tax_ID.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Tax_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Tax_ID.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtSupply_Tax_ID.Location = New System.Drawing.Point(183, 97)
        Me.TxtSupply_Tax_ID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSupply_Tax_ID.Name = "TxtSupply_Tax_ID"
        Me.TxtSupply_Tax_ID.Size = New System.Drawing.Size(178, 65)
        Me.TxtSupply_Tax_ID.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.DateTimePicker1.BorderSize = 0
        Me.DateTimePicker1.CustomFormat = "yyyy年MM月dd日 HH:mm:ss"
        Me.DateTimePicker1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(292, 22)
        Me.DateTimePicker1.MinimumSize = New System.Drawing.Size(4, 35)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(499, 47)
        Me.DateTimePicker1.SkinColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.TabIndex = 99
        Me.DateTimePicker1.TextColor = System.Drawing.Color.White
        '
        'frmRSS_Access_Supply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtChargeCellphone)
        Me.Controls.Add(Me.TxtCharge_JobTitle)
        Me.Controls.Add(Me.TxtChargeDepartment)
        Me.Controls.Add(Me.TxtChargeName)
        Me.Controls.Add(Me.TxtSupply_Present_CellPhone)
        Me.Controls.Add(Me.TxtPresident_JobTitle)
        Me.Controls.Add(Me.TxtSupply_Present_Name)
        Me.Controls.Add(Me.TxtSupply_Co_Address)
        Me.Controls.Add(Me.TxtSupply_Co_Phone)
        Me.Controls.Add(Me.TxtSupply_Co_Name)
        Me.Controls.Add(Me.TxtSupply_Tax_ID)
        Me.Controls.Add(Me.lblPresident_JobTitle)
        Me.Controls.Add(Me.lblCharge_JobTitle)
        Me.Controls.Add(Me.DGVSupply)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblChargeCellPhone)
        Me.Controls.Add(Me.lblChargeDepartment)
        Me.Controls.Add(Me.lblChargeName)
        Me.Controls.Add(Me.lblCellphone09)
        Me.Controls.Add(Me.lblSupply_Present_CellPhone)
        Me.Controls.Add(Me.lblSupply_Present_Name)
        Me.Controls.Add(Me.lblSupply_Co_Address)
        Me.Controls.Add(Me.ComBPhoneCode)
        Me.Controls.Add(Me.lblSupply_Co_Tel)
        Me.Controls.Add(Me.lblSupply_Co_Name)
        Me.Controls.Add(Me.lblSupply_Tax_ID)
        Me.Controls.Add(Me.lblDateTimeNow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRSS_Access_Supply"
        Me.Opacity = 0.5R
        Me.Text = "供應商資料"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVSupply, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDateTimeNow As Label
    Friend WithEvents lblSupply_Tax_ID As Label
    Friend WithEvents lblSupply_Co_Name As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblSupply_Co_Tel As Label
    Friend WithEvents ComBPhoneCode As ComboBox
    Friend WithEvents lblSupply_Co_Address As Label
    Friend WithEvents lblSupply_Present_Name As Label
    Friend WithEvents lblSupply_Present_CellPhone As Label
    Friend WithEvents lblCellphone09 As Label
    Friend WithEvents lblChargeName As Label
    Friend WithEvents lblChargeDepartment As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblChargeCellPhone As Label
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGVSupply As DataGridView
    Friend WithEvents lblCharge_JobTitle As Label
    Friend WithEvents lblPresident_JobTitle As Label
    Friend WithEvents TxtSupply_Tax_ID As TableText
    Friend WithEvents TxtSupply_Co_Name As TableText
    Friend WithEvents TxtSupply_Co_Phone As TableText
    Friend WithEvents TxtSupply_Co_Address As TableText
    Friend WithEvents TxtSupply_Present_Name As TableText
    Friend WithEvents TxtPresident_JobTitle As TableText
    Friend WithEvents TxtSupply_Present_CellPhone As TableText
    Friend WithEvents TxtChargeName As TableText
    Friend WithEvents TxtChargeDepartment As TableText
    Friend WithEvents TxtCharge_JobTitle As TableText
    Friend WithEvents TxtChargeCellphone As TableText
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DateTimePicker1 As MCDateTimePicker
End Class
