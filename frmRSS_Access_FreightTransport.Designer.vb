<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRSS_Access_FreightTransport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_FreightTransport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBPhoneCode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMBFaxCode = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDel = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGVFT = New System.Windows.Forms.DataGridView()
        Me.TxtEmailTail = New RSS_Access.TableText()
        Me.TxtEMailHead = New RSS_Access.TableText()
        Me.TxtFT_Charge_CellPhone = New RSS_Access.TableText()
        Me.TxtCharge = New RSS_Access.TableText()
        Me.TxtFTFax = New RSS_Access.TableText()
        Me.TxtFT_Co_PhoneNo = New RSS_Access.TableText()
        Me.TxtAddress = New RSS_Access.TableText()
        Me.TxtFreightTransportName = New RSS_Access.TableText()
        Me.TxtFreightTranspaort_Tax_ID = New RSS_Access.TableText()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CMBEmailDomain = New System.Windows.Forms.ComboBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVFT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 66)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "貨運公司" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "統一編號"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(610, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "貨運公司"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 33)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "地址"
        '
        'CMBPhoneCode
        '
        Me.CMBPhoneCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.CMBPhoneCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMBPhoneCode.Font = New System.Drawing.Font("標楷體", 18.0!)
        Me.CMBPhoneCode.ForeColor = System.Drawing.Color.White
        Me.CMBPhoneCode.FormattingEnabled = True
        Me.CMBPhoneCode.Items.AddRange(New Object() {"請選擇區碼", "02", "03", "037", "04", "05", "06", "07", "08", "082", "089"})
        Me.CMBPhoneCode.Location = New System.Drawing.Point(173, 142)
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
        Me.Label4.Location = New System.Drawing.Point(12, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 33)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "電    話"
        '
        'CMBFaxCode
        '
        Me.CMBFaxCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.CMBFaxCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMBFaxCode.Font = New System.Drawing.Font("標楷體", 18.0!)
        Me.CMBFaxCode.ForeColor = System.Drawing.Color.White
        Me.CMBFaxCode.FormattingEnabled = True
        Me.CMBFaxCode.Items.AddRange(New Object() {"請選擇區碼", "02", "03", "037", "04", "05", "06", "07", "08", "082", "089"})
        Me.CMBFaxCode.Location = New System.Drawing.Point(813, 139)
        Me.CMBFaxCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CMBFaxCode.Name = "CMBFaxCode"
        Me.CMBFaxCode.Size = New System.Drawing.Size(192, 38)
        Me.CMBFaxCode.TabIndex = 8
        Me.CMBFaxCode.Text = "請選擇區碼"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label5.Location = New System.Drawing.Point(652, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 33)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "傳    真"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 33)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "接洽人"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label8.Location = New System.Drawing.Point(532, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 33)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "09"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label7.Location = New System.Drawing.Point(443, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 33)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "手機"
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
        Me.BtnUpdate.Location = New System.Drawing.Point(311, 421)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.ShadowDecoration.Parent = Me.BtnUpdate
        Me.BtnUpdate.Size = New System.Drawing.Size(200, 65)
        Me.BtnUpdate.TabIndex = 22
        Me.BtnUpdate.Text = "修改"
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
        Me.BtnReset.Location = New System.Drawing.Point(914, 421)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.ShadowDecoration.Parent = Me.BtnReset
        Me.BtnReset.Size = New System.Drawing.Size(200, 65)
        Me.BtnReset.TabIndex = 24
        Me.BtnReset.Text = "重填"
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
        Me.BtnDel.Location = New System.Drawing.Point(607, 421)
        Me.BtnDel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.ShadowDecoration.Parent = Me.BtnDel
        Me.BtnDel.Size = New System.Drawing.Size(200, 65)
        Me.BtnDel.TabIndex = 23
        Me.BtnDel.Text = "刪除"
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
        Me.BtnAdd.Location = New System.Drawing.Point(18, 421)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.ShadowDecoration.Parent = Me.BtnAdd
        Me.BtnAdd.Size = New System.Drawing.Size(200, 65)
        Me.BtnAdd.TabIndex = 21
        Me.BtnAdd.Text = "新增"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(866, 339)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 33)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "E-Mail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(1237, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 33)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "@"
        '
        'DGVFT
        '
        Me.DGVFT.BackgroundColor = System.Drawing.Color.White
        Me.DGVFT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFT.Location = New System.Drawing.Point(12, 511)
        Me.DGVFT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVFT.Name = "DGVFT"
        Me.DGVFT.RowHeadersWidth = 51
        Me.DGVFT.RowTemplate.Height = 29
        Me.DGVFT.Size = New System.Drawing.Size(2293, 453)
        Me.DGVFT.TabIndex = 25
        '
        'TxtEmailTail
        '
        Me.TxtEmailTail.BackColor = System.Drawing.Color.White
        Me.TxtEmailTail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmailTail.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtEmailTail.Location = New System.Drawing.Point(1275, 324)
        Me.TxtEmailTail.Name = "TxtEmailTail"
        Me.TxtEmailTail.Size = New System.Drawing.Size(242, 65)
        Me.TxtEmailTail.TabIndex = 20
        '
        'TxtEMailHead
        '
        Me.TxtEMailHead.BackColor = System.Drawing.Color.White
        Me.TxtEMailHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEMailHead.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtEMailHead.Location = New System.Drawing.Point(989, 324)
        Me.TxtEMailHead.Name = "TxtEMailHead"
        Me.TxtEMailHead.Size = New System.Drawing.Size(242, 65)
        Me.TxtEMailHead.TabIndex = 18
        '
        'TxtFT_Charge_CellPhone
        '
        Me.TxtFT_Charge_CellPhone.BackColor = System.Drawing.Color.White
        Me.TxtFT_Charge_CellPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFT_Charge_CellPhone.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtFT_Charge_CellPhone.Location = New System.Drawing.Point(581, 324)
        Me.TxtFT_Charge_CellPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtFT_Charge_CellPhone.Name = "TxtFT_Charge_CellPhone"
        Me.TxtFT_Charge_CellPhone.Size = New System.Drawing.Size(222, 65)
        Me.TxtFT_Charge_CellPhone.TabIndex = 16
        '
        'TxtCharge
        '
        Me.TxtCharge.BackColor = System.Drawing.Color.White
        Me.TxtCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCharge.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtCharge.Location = New System.Drawing.Point(135, 324)
        Me.TxtCharge.Name = "TxtCharge"
        Me.TxtCharge.Size = New System.Drawing.Size(242, 65)
        Me.TxtCharge.TabIndex = 13
        '
        'TxtFTFax
        '
        Me.TxtFTFax.BackColor = System.Drawing.Color.White
        Me.TxtFTFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFTFax.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtFTFax.Location = New System.Drawing.Point(1011, 126)
        Me.TxtFTFax.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtFTFax.Name = "TxtFTFax"
        Me.TxtFTFax.Size = New System.Drawing.Size(228, 65)
        Me.TxtFTFax.TabIndex = 9
        '
        'TxtFT_Co_PhoneNo
        '
        Me.TxtFT_Co_PhoneNo.BackColor = System.Drawing.Color.White
        Me.TxtFT_Co_PhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFT_Co_PhoneNo.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtFT_Co_PhoneNo.Location = New System.Drawing.Point(371, 129)
        Me.TxtFT_Co_PhoneNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtFT_Co_PhoneNo.Name = "TxtFT_Co_PhoneNo"
        Me.TxtFT_Co_PhoneNo.Size = New System.Drawing.Size(228, 65)
        Me.TxtFT_Co_PhoneNo.TabIndex = 6
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.Color.White
        Me.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(101, 225)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(1250, 65)
        Me.TxtAddress.TabIndex = 11
        '
        'TxtFreightTransportName
        '
        Me.TxtFreightTransportName.BackColor = System.Drawing.Color.White
        Me.TxtFreightTransportName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFreightTransportName.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtFreightTransportName.Location = New System.Drawing.Point(766, 34)
        Me.TxtFreightTransportName.Name = "TxtFreightTransportName"
        Me.TxtFreightTransportName.Size = New System.Drawing.Size(386, 65)
        Me.TxtFreightTransportName.TabIndex = 3
        '
        'TxtFreightTranspaort_Tax_ID
        '
        Me.TxtFreightTranspaort_Tax_ID.BackColor = System.Drawing.Color.White
        Me.TxtFreightTranspaort_Tax_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFreightTranspaort_Tax_ID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtFreightTranspaort_Tax_ID.Location = New System.Drawing.Point(169, 34)
        Me.TxtFreightTranspaort_Tax_ID.Name = "TxtFreightTranspaort_Tax_ID"
        Me.TxtFreightTranspaort_Tax_ID.Size = New System.Drawing.Size(279, 65)
        Me.TxtFreightTranspaort_Tax_ID.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(1524, 355)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 33)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "."
        '
        'CMBEmailDomain
        '
        Me.CMBEmailDomain.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBEmailDomain.FormattingEnabled = True
        Me.CMBEmailDomain.Items.AddRange(New Object() {"com", "com.tw", "org", "net", "me", "tw", "cc", "cloud", "life", "co", "course", "one", "edu", "gov", "mil", "int"})
        Me.CMBEmailDomain.Location = New System.Drawing.Point(1562, 341)
        Me.CMBEmailDomain.Name = "CMBEmailDomain"
        Me.CMBEmailDomain.Size = New System.Drawing.Size(170, 48)
        Me.CMBEmailDomain.TabIndex = 27
        '
        'frmRSS_Access_FreightTransport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.CMBEmailDomain)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DGVFT)
        Me.Controls.Add(Me.TxtEmailTail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtEMailHead)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtFT_Charge_CellPhone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCharge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtFTFax)
        Me.Controls.Add(Me.CMBFaxCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtFT_Co_PhoneNo)
        Me.Controls.Add(Me.CMBPhoneCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtFreightTransportName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtFreightTranspaort_Tax_ID)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRSS_Access_FreightTransport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "貨運公司"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVFT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFreightTranspaort_Tax_ID As TableText
    Friend WithEvents TxtFreightTransportName As TableText
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAddress As TableText
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFT_Co_PhoneNo As TableText
    Friend WithEvents CMBPhoneCode As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtFTFax As TableText
    Friend WithEvents CMBFaxCode As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCharge As TableText
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtFT_Charge_CellPhone As TableText
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtEMailHead As TableText
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtEmailTail As TableText
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DGVFT As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents CMBEmailDomain As ComboBox
End Class
