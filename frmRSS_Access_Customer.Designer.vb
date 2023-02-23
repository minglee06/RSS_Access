<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRSS_Access_Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_Customer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBPhoneCode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDel = New Guna.UI2.WinForms.Guna2Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DGVCustomer = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtCustomer_Tax_ID = New RSS_Access.TableText()
        Me.TxtCustomer_Co_Name = New RSS_Access.TableText()
        Me.TxtCustomer_Co_PhoneNo = New RSS_Access.TableText()
        Me.TxtCustomer_Co_Address = New RSS_Access.TableText()
        Me.TxtCustomer_President_Name = New RSS_Access.TableText()
        Me.TxtCustomer_President_JobTitle = New RSS_Access.TableText()
        Me.TxtCustomer_Charge_Department = New RSS_Access.TableText()
        Me.TxtCustomer_Charge_Name = New RSS_Access.TableText()
        Me.TxtCustomer_President_CellPhone = New RSS_Access.TableText()
        Me.TxtCustomer_Charge_CellPhone = New RSS_Access.TableText()
        Me.TxtCustomer_Charge_JobTitle = New RSS_Access.TableText()
        Me.DateTimePicker1 = New RSS_Access.MCDateTimePicker()
        CType(Me.DGVCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label1.Location = New System.Drawing.Point(20, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "統一編號"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label2.Location = New System.Drawing.Point(445, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "公司行號名稱"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label3.Location = New System.Drawing.Point(20, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "電    話"
        '
        'CMBPhoneCode
        '
        Me.CMBPhoneCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.CMBPhoneCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMBPhoneCode.Font = New System.Drawing.Font("標楷體", 18.0!)
        Me.CMBPhoneCode.ForeColor = System.Drawing.Color.White
        Me.CMBPhoneCode.FormattingEnabled = True
        Me.CMBPhoneCode.Items.AddRange(New Object() {"請選擇區碼", "02", "03", "037", "04", "05", "06", "07", "08", "082", "089"})
        Me.CMBPhoneCode.Location = New System.Drawing.Point(181, 202)
        Me.CMBPhoneCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CMBPhoneCode.Name = "CMBPhoneCode"
        Me.CMBPhoneCode.Size = New System.Drawing.Size(192, 38)
        Me.CMBPhoneCode.TabIndex = 5
        Me.CMBPhoneCode.Text = "請選擇區碼"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label4.Location = New System.Drawing.Point(641, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 33)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "地址"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label5.Location = New System.Drawing.Point(20, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 33)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "負 責 人"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label6.Location = New System.Drawing.Point(436, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 33)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "職稱"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label7.Location = New System.Drawing.Point(804, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 33)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "手機"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label8.Location = New System.Drawing.Point(893, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 33)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "09"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label9.Location = New System.Drawing.Point(20, 414)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 33)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "接 洽 人"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label10.Location = New System.Drawing.Point(804, 413)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 33)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "職稱"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label11.Location = New System.Drawing.Point(1164, 414)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 33)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "手機"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label12.Location = New System.Drawing.Point(1243, 414)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 33)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "09"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label13.Location = New System.Drawing.Point(436, 414)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 33)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "部門"
        '
        'BtnAdd
        '
        Me.BtnAdd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdd.BorderRadius = 10
        Me.BtnAdd.BorderThickness = 1
        Me.BtnAdd.CheckedState.Parent = Me.BtnAdd
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.CustomBorderThickness = New System.Windows.Forms.Padding(1)
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
        Me.BtnAdd.Location = New System.Drawing.Point(47, 502)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.ShadowDecoration.Parent = Me.BtnAdd
        Me.BtnAdd.Size = New System.Drawing.Size(200, 65)
        Me.BtnAdd.TabIndex = 25
        Me.BtnAdd.Text = "新增"
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
        Me.BtnDel.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.BtnDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDel.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnDel.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnDel.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnDel.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnDel.HoverState.Parent = Me.BtnDel
        Me.BtnDel.Location = New System.Drawing.Point(636, 502)
        Me.BtnDel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.ShadowDecoration.Parent = Me.BtnDel
        Me.BtnDel.Size = New System.Drawing.Size(200, 65)
        Me.BtnDel.TabIndex = 27
        Me.BtnDel.Text = "刪除"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label14.Location = New System.Drawing.Point(20, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(253, 33)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "現在日期及時間"
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
        Me.BtnReset.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.BtnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnReset.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnReset.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnReset.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnReset.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnReset.HoverState.Parent = Me.BtnReset
        Me.BtnReset.Location = New System.Drawing.Point(943, 502)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.ShadowDecoration.Parent = Me.BtnReset
        Me.BtnReset.Size = New System.Drawing.Size(200, 65)
        Me.BtnReset.TabIndex = 28
        Me.BtnReset.Text = "重填"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DGVCustomer
        '
        Me.DGVCustomer.BackgroundColor = System.Drawing.Color.White
        Me.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCustomer.Location = New System.Drawing.Point(11, 591)
        Me.DGVCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVCustomer.Name = "DGVCustomer"
        Me.DGVCustomer.RowHeadersWidth = 51
        Me.DGVCustomer.RowTemplate.Height = 29
        Me.DGVCustomer.Size = New System.Drawing.Size(2293, 453)
        Me.DGVCustomer.TabIndex = 29
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdate.BorderRadius = 10
        Me.BtnUpdate.BorderThickness = 1
        Me.BtnUpdate.CheckedState.Parent = Me.BtnUpdate
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.CustomImages.Parent = Me.BtnUpdate
        Me.BtnUpdate.FillColor = System.Drawing.Color.White
        Me.BtnUpdate.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdate.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnUpdate.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnUpdate.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnUpdate.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.HoverState.Parent = Me.BtnUpdate
        Me.BtnUpdate.Location = New System.Drawing.Point(340, 502)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.ShadowDecoration.Parent = Me.BtnUpdate
        Me.BtnUpdate.Size = New System.Drawing.Size(200, 65)
        Me.BtnUpdate.TabIndex = 26
        Me.BtnUpdate.Text = "修改"
        '
        'TxtCustomer_Tax_ID
        '
        Me.TxtCustomer_Tax_ID.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_Tax_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_Tax_ID.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCustomer_Tax_ID.Location = New System.Drawing.Point(177, 86)
        Me.TxtCustomer_Tax_ID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomer_Tax_ID.Name = "TxtCustomer_Tax_ID"
        Me.TxtCustomer_Tax_ID.Size = New System.Drawing.Size(222, 65)
        Me.TxtCustomer_Tax_ID.TabIndex = 1
        '
        'TxtCustomer_Co_Name
        '
        Me.TxtCustomer_Co_Name.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_Co_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_Co_Name.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCustomer_Co_Name.Location = New System.Drawing.Point(679, 86)
        Me.TxtCustomer_Co_Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomer_Co_Name.Name = "TxtCustomer_Co_Name"
        Me.TxtCustomer_Co_Name.Size = New System.Drawing.Size(622, 65)
        Me.TxtCustomer_Co_Name.TabIndex = 3
        '
        'TxtCustomer_Co_PhoneNo
        '
        Me.TxtCustomer_Co_PhoneNo.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_Co_PhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_Co_PhoneNo.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCustomer_Co_PhoneNo.Location = New System.Drawing.Point(379, 189)
        Me.TxtCustomer_Co_PhoneNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomer_Co_PhoneNo.Name = "TxtCustomer_Co_PhoneNo"
        Me.TxtCustomer_Co_PhoneNo.Size = New System.Drawing.Size(228, 65)
        Me.TxtCustomer_Co_PhoneNo.TabIndex = 6
        '
        'TxtCustomer_Co_Address
        '
        Me.TxtCustomer_Co_Address.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_Co_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_Co_Address.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCustomer_Co_Address.Location = New System.Drawing.Point(730, 189)
        Me.TxtCustomer_Co_Address.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomer_Co_Address.Name = "TxtCustomer_Co_Address"
        Me.TxtCustomer_Co_Address.Size = New System.Drawing.Size(889, 65)
        Me.TxtCustomer_Co_Address.TabIndex = 8
        '
        'TxtCustomer_President_Name
        '
        Me.TxtCustomer_President_Name.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_President_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_President_Name.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCustomer_President_Name.Location = New System.Drawing.Point(177, 297)
        Me.TxtCustomer_President_Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomer_President_Name.Name = "TxtCustomer_President_Name"
        Me.TxtCustomer_President_Name.Size = New System.Drawing.Size(222, 65)
        Me.TxtCustomer_President_Name.TabIndex = 10
        '
        'TxtCustomer_President_JobTitle
        '
        Me.TxtCustomer_President_JobTitle.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_President_JobTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_President_JobTitle.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCustomer_President_JobTitle.Location = New System.Drawing.Point(525, 297)
        Me.TxtCustomer_President_JobTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomer_President_JobTitle.Name = "TxtCustomer_President_JobTitle"
        Me.TxtCustomer_President_JobTitle.Size = New System.Drawing.Size(222, 65)
        Me.TxtCustomer_President_JobTitle.TabIndex = 12
        '
        'TxtCustomer_Charge_Department
        '
        Me.TxtCustomer_Charge_Department.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_Charge_Department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_Charge_Department.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCustomer_Charge_Department.Location = New System.Drawing.Point(525, 402)
        Me.TxtCustomer_Charge_Department.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomer_Charge_Department.Name = "TxtCustomer_Charge_Department"
        Me.TxtCustomer_Charge_Department.Size = New System.Drawing.Size(222, 65)
        Me.TxtCustomer_Charge_Department.TabIndex = 19
        '
        'TxtCustomer_Charge_Name
        '
        Me.TxtCustomer_Charge_Name.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_Charge_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_Charge_Name.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCustomer_Charge_Name.Location = New System.Drawing.Point(177, 402)
        Me.TxtCustomer_Charge_Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomer_Charge_Name.Name = "TxtCustomer_Charge_Name"
        Me.TxtCustomer_Charge_Name.Size = New System.Drawing.Size(222, 65)
        Me.TxtCustomer_Charge_Name.TabIndex = 17
        '
        'TxtCustomer_President_CellPhone
        '
        Me.TxtCustomer_President_CellPhone.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_President_CellPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_President_CellPhone.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCustomer_President_CellPhone.Location = New System.Drawing.Point(948, 297)
        Me.TxtCustomer_President_CellPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomer_President_CellPhone.Name = "TxtCustomer_President_CellPhone"
        Me.TxtCustomer_President_CellPhone.Size = New System.Drawing.Size(222, 65)
        Me.TxtCustomer_President_CellPhone.TabIndex = 15
        '
        'TxtCustomer_Charge_CellPhone
        '
        Me.TxtCustomer_Charge_CellPhone.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_Charge_CellPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_Charge_CellPhone.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCustomer_Charge_CellPhone.Location = New System.Drawing.Point(1292, 402)
        Me.TxtCustomer_Charge_CellPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomer_Charge_CellPhone.Name = "TxtCustomer_Charge_CellPhone"
        Me.TxtCustomer_Charge_CellPhone.Size = New System.Drawing.Size(222, 65)
        Me.TxtCustomer_Charge_CellPhone.TabIndex = 24
        '
        'TxtCustomer_Charge_JobTitle
        '
        Me.TxtCustomer_Charge_JobTitle.BackColor = System.Drawing.Color.White
        Me.TxtCustomer_Charge_JobTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer_Charge_JobTitle.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCustomer_Charge_JobTitle.Location = New System.Drawing.Point(893, 402)
        Me.TxtCustomer_Charge_JobTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomer_Charge_JobTitle.Name = "TxtCustomer_Charge_JobTitle"
        Me.TxtCustomer_Charge_JobTitle.Size = New System.Drawing.Size(222, 65)
        Me.TxtCustomer_Charge_JobTitle.TabIndex = 21
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.DateTimePicker1.BorderSize = 0
        Me.DateTimePicker1.CustomFormat = "yyyy年MM月dd日 HH:mm:ss"
        Me.DateTimePicker1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(290, 12)
        Me.DateTimePicker1.MinimumSize = New System.Drawing.Size(4, 35)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(499, 47)
        Me.DateTimePicker1.SkinColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.TabIndex = 100
        Me.DateTimePicker1.TextColor = System.Drawing.Color.White
        '
        'frmRSS_Access_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtCustomer_Charge_JobTitle)
        Me.Controls.Add(Me.TxtCustomer_Charge_CellPhone)
        Me.Controls.Add(Me.TxtCustomer_President_CellPhone)
        Me.Controls.Add(Me.TxtCustomer_Charge_Name)
        Me.Controls.Add(Me.TxtCustomer_Charge_Department)
        Me.Controls.Add(Me.TxtCustomer_President_JobTitle)
        Me.Controls.Add(Me.TxtCustomer_President_Name)
        Me.Controls.Add(Me.TxtCustomer_Co_Address)
        Me.Controls.Add(Me.TxtCustomer_Co_PhoneNo)
        Me.Controls.Add(Me.TxtCustomer_Co_Name)
        Me.Controls.Add(Me.TxtCustomer_Tax_ID)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.DGVCustomer)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CMBPhoneCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRSS_Access_Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "客戶資料"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CMBPhoneCode As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DGVCustomer As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BtnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtCustomer_Tax_ID As TableText
    Friend WithEvents TxtCustomer_Co_Name As TableText
    Friend WithEvents TxtCustomer_Co_PhoneNo As TableText
    Friend WithEvents TxtCustomer_Co_Address As TableText
    Friend WithEvents TxtCustomer_President_Name As TableText
    Friend WithEvents TxtCustomer_President_JobTitle As TableText
    Friend WithEvents TxtCustomer_Charge_Department As TableText
    Friend WithEvents TxtCustomer_Charge_Name As TableText
    Friend WithEvents TxtCustomer_President_CellPhone As TableText
    Friend WithEvents TxtCustomer_Charge_CellPhone As TableText
    Friend WithEvents TxtCustomer_Charge_JobTitle As TableText
    Friend WithEvents DateTimePicker1 As MCDateTimePicker
End Class
