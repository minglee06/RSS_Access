<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginSucced
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginSucced))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCheck = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "歡迎你，登入成功。"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.RSS_Access.My.Resources.Resources.RSS_1
        Me.PictureBox1.InitialImage = Global.RSS_Access.My.Resources.Resources.RSS_1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(611, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnCheck
        '
        Me.BtnCheck.BorderColor = System.Drawing.Color.DimGray
        Me.BtnCheck.BorderRadius = 10
        Me.BtnCheck.BorderThickness = 1
        Me.BtnCheck.Cursor = System.Windows.Forms.Cursors.Hand
        ' Me.BtnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        'Me.BtnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        'Me.BtnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        'Me.BtnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCheck.FillColor = System.Drawing.Color.White
        Me.BtnCheck.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCheck.ForeColor = System.Drawing.Color.Blue
        Me.BtnCheck.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnCheck.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnCheck.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnCheck.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnCheck.Location = New System.Drawing.Point(163, 330)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(225, 65)
        Me.BtnCheck.TabIndex = 3
        Me.BtnCheck.Text = "確定"
        '
        'frmLoginSucced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(22.0!, 43.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(611, 447)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("標楷體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoginSucced"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "登入成功"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCheck As Guna.UI2.WinForms.Guna2Button
End Class
