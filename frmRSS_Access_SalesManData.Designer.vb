<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRSS_Access_SalesManData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_SalesManData))
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl09 = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCellphine = New System.Windows.Forms.Label()
        Me.lblDateTimeNow = New System.Windows.Forms.Label()
        Me.lblSalesManName = New System.Windows.Forms.Label()
        Me.lblSalesManID = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DGVSalesMan = New System.Windows.Forms.DataGridView()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDel = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnModify = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtSalesManID = New RSS_Access.TableText()
        Me.TxtSalesManName = New RSS_Access.TableText()
        Me.TxtCellphone = New RSS_Access.TableText()
        Me.TxtDepartment = New RSS_Access.TableText()
        Me.TxtAddress = New RSS_Access.TableText()
        Me.DateTimePicker1 = New RSS_Access.MCDateTimePicker()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSalesMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl09
        '
        Me.lbl09.AutoSize = True
        Me.lbl09.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lbl09.Location = New System.Drawing.Point(183, 217)
        Me.lbl09.Name = "lbl09"
        Me.lbl09.Size = New System.Drawing.Size(49, 33)
        Me.lbl09.TabIndex = 7
        Me.lbl09.Text = "09"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblDepartment.Location = New System.Drawing.Point(416, 113)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(83, 33)
        Me.lblDepartment.TabIndex = 2
        Me.lblDepartment.Text = "部門"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblAddress.Location = New System.Drawing.Point(475, 217)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(83, 33)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "地址"
        '
        'lblCellphine
        '
        Me.lblCellphine.AutoSize = True
        Me.lblCellphine.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblCellphine.Location = New System.Drawing.Point(28, 217)
        Me.lblCellphine.Name = "lblCellphine"
        Me.lblCellphine.Size = New System.Drawing.Size(151, 33)
        Me.lblCellphine.TabIndex = 6
        Me.lblCellphine.Text = "手機號碼"
        '
        'lblDateTimeNow
        '
        Me.lblDateTimeNow.AutoSize = True
        Me.lblDateTimeNow.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblDateTimeNow.Location = New System.Drawing.Point(26, 26)
        Me.lblDateTimeNow.Name = "lblDateTimeNow"
        Me.lblDateTimeNow.Size = New System.Drawing.Size(253, 33)
        Me.lblDateTimeNow.TabIndex = 16
        Me.lblDateTimeNow.Text = "現在日期跟時間"
        '
        'lblSalesManName
        '
        Me.lblSalesManName.AutoSize = True
        Me.lblSalesManName.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblSalesManName.Location = New System.Drawing.Point(720, 113)
        Me.lblSalesManName.Name = "lblSalesManName"
        Me.lblSalesManName.Size = New System.Drawing.Size(219, 33)
        Me.lblSalesManName.TabIndex = 4
        Me.lblSalesManName.Text = "銷貨人員姓名"
        '
        'lblSalesManID
        '
        Me.lblSalesManID.AutoSize = True
        Me.lblSalesManID.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblSalesManID.Location = New System.Drawing.Point(29, 113)
        Me.lblSalesManID.Name = "lblSalesManID"
        Me.lblSalesManID.Size = New System.Drawing.Size(219, 33)
        Me.lblSalesManID.TabIndex = 0
        Me.lblSalesManID.Text = "銷貨人員編號"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DGVSalesMan
        '
        Me.DGVSalesMan.BackgroundColor = System.Drawing.Color.White
        Me.DGVSalesMan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSalesMan.Location = New System.Drawing.Point(26, 407)
        Me.DGVSalesMan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVSalesMan.MultiSelect = False
        Me.DGVSalesMan.Name = "DGVSalesMan"
        Me.DGVSalesMan.RowHeadersWidth = 51
        Me.DGVSalesMan.RowTemplate.Height = 29
        Me.DGVSalesMan.Size = New System.Drawing.Size(1940, 380)
        Me.DGVSalesMan.TabIndex = 15
        Me.DGVSalesMan.TabStop = False
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
        Me.BtnAdd.Location = New System.Drawing.Point(40, 302)
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
        Me.BtnDel.Location = New System.Drawing.Point(272, 302)
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
        Me.BtnModify.Location = New System.Drawing.Point(504, 302)
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
        Me.BtnReset.Location = New System.Drawing.Point(736, 302)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.ShadowDecoration.Parent = Me.BtnReset
        Me.BtnReset.Size = New System.Drawing.Size(200, 65)
        Me.BtnReset.TabIndex = 14
        Me.BtnReset.Text = "重填"
        '
        'TxtSalesManID
        '
        Me.TxtSalesManID.BackColor = System.Drawing.Color.White
        Me.TxtSalesManID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSalesManID.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtSalesManID.Location = New System.Drawing.Point(258, 97)
        Me.TxtSalesManID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSalesManID.Name = "TxtSalesManID"
        Me.TxtSalesManID.Size = New System.Drawing.Size(116, 65)
        Me.TxtSalesManID.TabIndex = 1
        '
        'TxtSalesManName
        '
        Me.TxtSalesManName.BackColor = System.Drawing.Color.White
        Me.TxtSalesManName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSalesManName.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtSalesManName.Location = New System.Drawing.Point(947, 97)
        Me.TxtSalesManName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSalesManName.Name = "TxtSalesManName"
        Me.TxtSalesManName.Size = New System.Drawing.Size(325, 65)
        Me.TxtSalesManName.TabIndex = 5
        '
        'TxtCellphone
        '
        Me.TxtCellphone.BackColor = System.Drawing.Color.White
        Me.TxtCellphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCellphone.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCellphone.Location = New System.Drawing.Point(229, 201)
        Me.TxtCellphone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCellphone.Name = "TxtCellphone"
        Me.TxtCellphone.Size = New System.Drawing.Size(178, 65)
        Me.TxtCellphone.TabIndex = 8
        '
        'TxtDepartment
        '
        Me.TxtDepartment.BackColor = System.Drawing.Color.White
        Me.TxtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDepartment.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtDepartment.Location = New System.Drawing.Point(495, 97)
        Me.TxtDepartment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDepartment.Name = "TxtDepartment"
        Me.TxtDepartment.Size = New System.Drawing.Size(147, 65)
        Me.TxtDepartment.TabIndex = 3
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.Color.White
        Me.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtAddress.Location = New System.Drawing.Point(554, 201)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(871, 65)
        Me.TxtAddress.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.DateTimePicker1.BorderSize = 0
        Me.DateTimePicker1.CustomFormat = "yyyy年MM月dd日 HH:mm:ss"
        Me.DateTimePicker1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(302, 19)
        Me.DateTimePicker1.MinimumSize = New System.Drawing.Size(0, 35)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(499, 47)
        Me.DateTimePicker1.SkinColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.TabIndex = 17
        Me.DateTimePicker1.TextColor = System.Drawing.Color.White
        '
        'frmRSS_Access_SalesManData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TxtDepartment)
        Me.Controls.Add(Me.TxtCellphone)
        Me.Controls.Add(Me.TxtSalesManName)
        Me.Controls.Add(Me.TxtSalesManID)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DGVSalesMan)
        Me.Controls.Add(Me.lbl09)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCellphine)
        Me.Controls.Add(Me.lblDateTimeNow)
        Me.Controls.Add(Me.lblSalesManName)
        Me.Controls.Add(Me.lblSalesManID)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRSS_Access_SalesManData"
        Me.Text = "銷貨人員資料"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSalesMan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents lbl09 As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCellphine As Label
    Friend WithEvents lblDateTimeNow As Label
    Friend WithEvents lblSalesManName As Label
    Friend WithEvents lblSalesManID As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DGVSalesMan As DataGridView
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnModify As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtSalesManID As TableText
    Friend WithEvents TxtSalesManName As TableText
    Friend WithEvents TxtCellphone As TableText
    Friend WithEvents TxtDepartment As TableText
    Friend WithEvents TxtAddress As TableText
    Friend WithEvents DateTimePicker1 As MCDateTimePicker
End Class
