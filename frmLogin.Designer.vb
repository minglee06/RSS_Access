<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.lblAccountStr = New System.Windows.Forms.Label()
        Me.lblPwdStr = New System.Windows.Forms.Label()
        Me.BtnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAccount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPwd = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.RSS_Access.My.Resources.Resources.RSS_Access
        Me.PictureBox1.InitialImage = Global.RSS_Access.My.Resources.Resources.RSS_Access
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(904, 202)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Font = New System.Drawing.Font("標楷體", 25.8!)
        Me.lblAccount.Location = New System.Drawing.Point(12, 246)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(151, 43)
        Me.lblAccount.TabIndex = 0
        Me.lblAccount.Text = "帳號："
        '
        'lblPwd
        '
        Me.lblPwd.AutoSize = True
        Me.lblPwd.Font = New System.Drawing.Font("標楷體", 25.8!)
        Me.lblPwd.Location = New System.Drawing.Point(11, 369)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(151, 43)
        Me.lblPwd.TabIndex = 3
        Me.lblPwd.Text = "密碼："
        '
        'lblAccountStr
        '
        Me.lblAccountStr.AutoSize = True
        Me.lblAccountStr.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblAccountStr.ForeColor = System.Drawing.Color.Red
        Me.lblAccountStr.Location = New System.Drawing.Point(551, 251)
        Me.lblAccountStr.Name = "lblAccountStr"
        Me.lblAccountStr.Size = New System.Drawing.Size(32, 33)
        Me.lblAccountStr.TabIndex = 2
        Me.lblAccountStr.Text = "*"
        '
        'lblPwdStr
        '
        Me.lblPwdStr.AutoSize = True
        Me.lblPwdStr.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.lblPwdStr.ForeColor = System.Drawing.Color.Red
        Me.lblPwdStr.Location = New System.Drawing.Point(551, 374)
        Me.lblPwdStr.Name = "lblPwdStr"
        Me.lblPwdStr.Size = New System.Drawing.Size(32, 33)
        Me.lblPwdStr.TabIndex = 5
        Me.lblPwdStr.Text = "*"
        '
        'BtnLogin
        '
        Me.BtnLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLogin.BorderRadius = 10
        Me.BtnLogin.BorderThickness = 1
        Me.BtnLogin.CheckedState.Parent = Me.BtnLogin
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.CustomImages.Parent = Me.BtnLogin
        Me.BtnLogin.FillColor = System.Drawing.Color.White
        Me.BtnLogin.Font = New System.Drawing.Font("標楷體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLogin.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnLogin.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnLogin.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnLogin.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.HoverState.Parent = Me.BtnLogin
        Me.BtnLogin.Location = New System.Drawing.Point(39, 476)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.ShadowDecoration.Parent = Me.BtnLogin
        Me.BtnLogin.Size = New System.Drawing.Size(225, 65)
        Me.BtnLogin.TabIndex = 6
        Me.BtnLogin.Text = "登入"
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
        Me.BtnReset.Font = New System.Drawing.Font("標楷體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnReset.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnReset.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnReset.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnReset.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnReset.HoverState.Parent = Me.BtnReset
        Me.BtnReset.Location = New System.Drawing.Point(338, 476)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.ShadowDecoration.Parent = Me.BtnReset
        Me.BtnReset.Size = New System.Drawing.Size(225, 65)
        Me.BtnReset.TabIndex = 7
        Me.BtnReset.Text = "重填"
        '
        'txtAccount
        '
        Me.txtAccount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAccount.BorderRadius = 10
        Me.txtAccount.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAccount.DefaultText = ""
        Me.txtAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAccount.DisabledState.Parent = Me.txtAccount
        Me.txtAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAccount.FocusedState.Parent = Me.txtAccount
        Me.txtAccount.Font = New System.Drawing.Font("標楷體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtAccount.ForeColor = System.Drawing.Color.Black
        Me.txtAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAccount.HoverState.Parent = Me.txtAccount
        Me.txtAccount.Location = New System.Drawing.Point(125, 230)
        Me.txtAccount.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccount.PlaceholderText = "請輸入"
        Me.txtAccount.SelectedText = ""
        Me.txtAccount.ShadowDecoration.Parent = Me.txtAccount
        Me.txtAccount.Size = New System.Drawing.Size(420, 75)
        Me.txtAccount.TabIndex = 1
        '
        'txtPwd
        '
        Me.txtPwd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPwd.BorderRadius = 10
        Me.txtPwd.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPwd.DefaultText = ""
        Me.txtPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPwd.DisabledState.Parent = Me.txtPwd
        Me.txtPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPwd.FocusedState.Parent = Me.txtPwd
        Me.txtPwd.Font = New System.Drawing.Font("標楷體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPwd.ForeColor = System.Drawing.Color.Black
        Me.txtPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPwd.HoverState.Parent = Me.txtPwd
        Me.txtPwd.Location = New System.Drawing.Point(125, 353)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.PlaceholderText = "請輸入"
        Me.txtPwd.SelectedText = ""
        Me.txtPwd.ShadowDecoration.Parent = Me.txtPwd
        Me.txtPwd.Size = New System.Drawing.Size(420, 75)
        Me.txtPwd.TabIndex = 4
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(904, 602)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.lblPwdStr)
        Me.Controls.Add(Me.lblAccountStr)
        Me.Controls.Add(Me.lblPwd)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("標楷體", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RSS_Access進銷存管理系統_登入系統"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAccount As Label
    Friend WithEvents lblPwd As Label
    Friend WithEvents lblAccountStr As Label
    Friend WithEvents lblPwdStr As Label
    Friend WithEvents BtnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAccount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPwd As Guna.UI2.WinForms.Guna2TextBox
End Class
