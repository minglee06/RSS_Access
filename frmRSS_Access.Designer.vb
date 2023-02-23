<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRSS_Access
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVersionNum = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEnter = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.RSS_Access.My.Resources.Resources.RSS_Access
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1177, 365)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 25.8!)
        Me.Label1.Location = New System.Drawing.Point(38, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "版本："
        '
        'lblVersionNum
        '
        Me.lblVersionNum.AutoSize = True
        Me.lblVersionNum.Font = New System.Drawing.Font("標楷體", 25.8!)
        Me.lblVersionNum.Location = New System.Drawing.Point(178, 367)
        Me.lblVersionNum.Name = "lblVersionNum"
        Me.lblVersionNum.Size = New System.Drawing.Size(151, 43)
        Me.lblVersionNum.TabIndex = 2
        Me.lblVersionNum.Text = "Label2"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RSS_Access.My.Resources.Resources.logo7
        Me.PictureBox2.Location = New System.Drawing.Point(44, 446)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(264, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("標楷體", 25.8!)
        Me.Label2.Location = New System.Drawing.Point(325, 454)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(459, 43)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "版權所有，翻印必究。"
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEnter.Font = New System.Drawing.Font("標楷體", 25.8!)
        Me.lblEnter.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lblEnter.Location = New System.Drawing.Point(373, 366)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(195, 43)
        Me.lblEnter.TabIndex = 5
        Me.lblEnter.TabStop = True
        Me.lblEnter.Text = "進入系統"
        Me.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRSS_Access
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1177, 509)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblVersionNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmRSS_Access"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RSS_Access進銷存管理系統"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblVersionNum As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEnter As LinkLabel
End Class
