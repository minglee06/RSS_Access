<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRSS_Access_Purchaser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_Purchaser))
        Me.lblPurchaserID = New System.Windows.Forms.Label()
        Me.lblPurchaserName = New System.Windows.Forms.Label()
        Me.lblDateTimeNow = New System.Windows.Forms.Label()
        Me.lblCellphine = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DGVPurChaser = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl09 = New System.Windows.Forms.Label()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDel = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnModify = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtAddress = New RSS_Access.TableText()
        Me.TxtCellphone = New RSS_Access.TableText()
        Me.TxtPurchaserName = New RSS_Access.TableText()
        Me.TxtDepartment = New RSS_Access.TableText()
        Me.TxtPurchaserID = New RSS_Access.TableText()
        Me.DateTimePicker1 = New RSS_Access.MCDateTimePicker()
        CType(Me.DGVPurChaser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPurchaserID
        '
        Me.lblPurchaserID.AutoSize = True
        Me.lblPurchaserID.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblPurchaserID.Location = New System.Drawing.Point(25, 130)
        Me.lblPurchaserID.Name = "lblPurchaserID"
        Me.lblPurchaserID.Size = New System.Drawing.Size(219, 33)
        Me.lblPurchaserID.TabIndex = 2
        Me.lblPurchaserID.Text = "進貨人員編號"
        '
        'lblPurchaserName
        '
        Me.lblPurchaserName.AutoSize = True
        Me.lblPurchaserName.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblPurchaserName.Location = New System.Drawing.Point(715, 130)
        Me.lblPurchaserName.Name = "lblPurchaserName"
        Me.lblPurchaserName.Size = New System.Drawing.Size(219, 33)
        Me.lblPurchaserName.TabIndex = 4
        Me.lblPurchaserName.Text = "進貨人員姓名"
        '
        'lblDateTimeNow
        '
        Me.lblDateTimeNow.AutoSize = True
        Me.lblDateTimeNow.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblDateTimeNow.Location = New System.Drawing.Point(25, 37)
        Me.lblDateTimeNow.Name = "lblDateTimeNow"
        Me.lblDateTimeNow.Size = New System.Drawing.Size(253, 33)
        Me.lblDateTimeNow.TabIndex = 16
        Me.lblDateTimeNow.Text = "現在日期跟時間"
        '
        'lblCellphine
        '
        Me.lblCellphine.AutoSize = True
        Me.lblCellphine.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblCellphine.Location = New System.Drawing.Point(25, 233)
        Me.lblCellphine.Name = "lblCellphine"
        Me.lblCellphine.Size = New System.Drawing.Size(151, 33)
        Me.lblCellphine.TabIndex = 6
        Me.lblCellphine.Text = "手機號碼"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblAddress.Location = New System.Drawing.Point(490, 233)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(83, 33)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "地址"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblDepartment.Location = New System.Drawing.Point(414, 130)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(83, 33)
        Me.lblDepartment.TabIndex = 2
        Me.lblDepartment.Text = "部門"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DGVPurChaser
        '
        Me.DGVPurChaser.BackgroundColor = System.Drawing.Color.White
        Me.DGVPurChaser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPurChaser.Location = New System.Drawing.Point(27, 412)
        Me.DGVPurChaser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVPurChaser.MultiSelect = False
        Me.DGVPurChaser.Name = "DGVPurChaser"
        Me.DGVPurChaser.RowHeadersWidth = 51
        Me.DGVPurChaser.RowTemplate.Height = 29
        Me.DGVPurChaser.Size = New System.Drawing.Size(1885, 380)
        Me.DGVPurChaser.TabIndex = 15
        Me.DGVPurChaser.TabStop = False
        '
        'lbl09
        '
        Me.lbl09.AutoSize = True
        Me.lbl09.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lbl09.Location = New System.Drawing.Point(178, 233)
        Me.lbl09.Name = "lbl09"
        Me.lbl09.Size = New System.Drawing.Size(49, 33)
        Me.lbl09.TabIndex = 7
        Me.lbl09.Text = "09"
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
        Me.BtnAdd.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.HoverState.Parent = Me.BtnAdd
        Me.BtnAdd.Location = New System.Drawing.Point(46, 321)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.ShadowDecoration.Parent = Me.BtnAdd
        Me.BtnAdd.Size = New System.Drawing.Size(200, 65)
        Me.BtnAdd.TabIndex = 11
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
        Me.BtnDel.Location = New System.Drawing.Point(281, 322)
        Me.BtnDel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.ShadowDecoration.Parent = Me.BtnDel
        Me.BtnDel.Size = New System.Drawing.Size(200, 65)
        Me.BtnDel.TabIndex = 12
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
        Me.BtnModify.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.BtnModify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnModify.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnModify.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnModify.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnModify.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnModify.HoverState.Parent = Me.BtnModify
        Me.BtnModify.Location = New System.Drawing.Point(517, 322)
        Me.BtnModify.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.ShadowDecoration.Parent = Me.BtnModify
        Me.BtnModify.Size = New System.Drawing.Size(200, 65)
        Me.BtnModify.TabIndex = 13
        Me.BtnModify.Text = "修改"
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
        Me.BtnReset.Location = New System.Drawing.Point(752, 321)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.ShadowDecoration.Parent = Me.BtnReset
        Me.BtnReset.Size = New System.Drawing.Size(200, 65)
        Me.BtnReset.TabIndex = 14
        Me.BtnReset.Text = "重填"
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.Color.White
        Me.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtAddress.Location = New System.Drawing.Point(579, 217)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(867, 65)
        Me.TxtAddress.TabIndex = 10
        '
        'TxtCellphone
        '
        Me.TxtCellphone.BackColor = System.Drawing.Color.White
        Me.TxtCellphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCellphone.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCellphone.Location = New System.Drawing.Point(224, 217)
        Me.TxtCellphone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCellphone.Name = "TxtCellphone"
        Me.TxtCellphone.Size = New System.Drawing.Size(178, 65)
        Me.TxtCellphone.TabIndex = 8
        '
        'TxtPurchaserName
        '
        Me.TxtPurchaserName.BackColor = System.Drawing.Color.White
        Me.TxtPurchaserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPurchaserName.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtPurchaserName.Location = New System.Drawing.Point(944, 114)
        Me.TxtPurchaserName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPurchaserName.Name = "TxtPurchaserName"
        Me.TxtPurchaserName.Size = New System.Drawing.Size(325, 65)
        Me.TxtPurchaserName.TabIndex = 5
        '
        'TxtDepartment
        '
        Me.TxtDepartment.BackColor = System.Drawing.Color.White
        Me.TxtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDepartment.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtDepartment.Location = New System.Drawing.Point(500, 114)
        Me.TxtDepartment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDepartment.Name = "TxtDepartment"
        Me.TxtDepartment.Size = New System.Drawing.Size(147, 65)
        Me.TxtDepartment.TabIndex = 3
        '
        'TxtPurchaserID
        '
        Me.TxtPurchaserID.BackColor = System.Drawing.Color.White
        Me.TxtPurchaserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPurchaserID.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtPurchaserID.Location = New System.Drawing.Point(258, 114)
        Me.TxtPurchaserID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPurchaserID.Name = "TxtPurchaserID"
        Me.TxtPurchaserID.Size = New System.Drawing.Size(116, 65)
        Me.TxtPurchaserID.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.DateTimePicker1.BorderSize = 0
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.CustomFormat = "yyyy年MM月dd日 HH:mm:ss"
        Me.DateTimePicker1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(302, 28)
        Me.DateTimePicker1.MinimumSize = New System.Drawing.Size(4, 35)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(482, 47)
        Me.DateTimePicker1.SkinColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.TabIndex = 18
        Me.DateTimePicker1.TextColor = System.Drawing.Color.White
        '
        'frmRSS_Access_Purchaser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 975)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TxtCellphone)
        Me.Controls.Add(Me.TxtPurchaserName)
        Me.Controls.Add(Me.TxtDepartment)
        Me.Controls.Add(Me.TxtPurchaserID)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.lbl09)
        Me.Controls.Add(Me.DGVPurChaser)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCellphine)
        Me.Controls.Add(Me.lblDateTimeNow)
        Me.Controls.Add(Me.lblPurchaserName)
        Me.Controls.Add(Me.lblPurchaserID)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRSS_Access_Purchaser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "進貨人員資料"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVPurChaser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPurchaserID As Label
    Friend WithEvents lblPurchaserName As Label
    Friend WithEvents lblDateTimeNow As Label
    Friend WithEvents lblCellphine As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DGVPurChaser As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents lbl09 As Label
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnModify As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtPurchaserID As TableText
    Friend WithEvents TxtDepartment As TableText
    Friend WithEvents TxtPurchaserName As TableText
    Friend WithEvents TxtCellphone As TableText
    Friend WithEvents TxtAddress As TableText
    Friend WithEvents DateTimePicker1 As MCDateTimePicker
End Class
