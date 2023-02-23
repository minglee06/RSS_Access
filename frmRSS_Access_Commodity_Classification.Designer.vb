<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRSS_Access_Commodity_Classification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_Commodity_Classification))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDel = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.DGVCommodity_Classification = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCommodity_TypeID = New RSS_Access.TableText()
        Me.TxtCommodity_Type_Name = New RSS_Access.TableText()
        Me.TxtCommodity_Type_Description = New RSS_Access.TableText()
        Me.DateTimePicker1 = New RSS_Access.MCDateTimePicker()
        CType(Me.DGVCommodity_Classification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label1.Location = New System.Drawing.Point(43, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "商品類別編號"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label2.Location = New System.Drawing.Point(484, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "商品類別名稱"
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
        Me.BtnAdd.Location = New System.Drawing.Point(42, 194)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.ShadowDecoration.Parent = Me.BtnAdd
        Me.BtnAdd.Size = New System.Drawing.Size(200, 65)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "新增"
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
        Me.BtnUpdate.Location = New System.Drawing.Point(333, 194)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.ShadowDecoration.Parent = Me.BtnUpdate
        Me.BtnUpdate.Size = New System.Drawing.Size(200, 65)
        Me.BtnUpdate.TabIndex = 7
        Me.BtnUpdate.Text = "修改"
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
        Me.BtnDel.Location = New System.Drawing.Point(625, 194)
        Me.BtnDel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.ShadowDecoration.Parent = Me.BtnDel
        Me.BtnDel.Size = New System.Drawing.Size(200, 65)
        Me.BtnDel.TabIndex = 8
        Me.BtnDel.Text = "刪除"
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
        Me.BtnReset.Location = New System.Drawing.Point(916, 194)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.ShadowDecoration.Parent = Me.BtnReset
        Me.BtnReset.Size = New System.Drawing.Size(200, 65)
        Me.BtnReset.TabIndex = 9
        Me.BtnReset.Text = "重填"
        '
        'DGVCommodity_Classification
        '
        Me.DGVCommodity_Classification.BackgroundColor = System.Drawing.Color.White
        Me.DGVCommodity_Classification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCommodity_Classification.Location = New System.Drawing.Point(20, 294)
        Me.DGVCommodity_Classification.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVCommodity_Classification.Name = "DGVCommodity_Classification"
        Me.DGVCommodity_Classification.RowHeadersWidth = 51
        Me.DGVCommodity_Classification.RowTemplate.Height = 29
        Me.DGVCommodity_Classification.Size = New System.Drawing.Size(1906, 453)
        Me.DGVCommodity_Classification.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label14.Location = New System.Drawing.Point(43, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(253, 33)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "現在日期及時間"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label3.Location = New System.Drawing.Point(898, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "商品類別說明"
        '
        'TxtCommodity_TypeID
        '
        Me.TxtCommodity_TypeID.BackColor = System.Drawing.Color.White
        Me.TxtCommodity_TypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCommodity_TypeID.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCommodity_TypeID.Location = New System.Drawing.Point(273, 92)
        Me.TxtCommodity_TypeID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCommodity_TypeID.Name = "TxtCommodity_TypeID"
        Me.TxtCommodity_TypeID.Size = New System.Drawing.Size(151, 65)
        Me.TxtCommodity_TypeID.TabIndex = 1
        '
        'TxtCommodity_Type_Name
        '
        Me.TxtCommodity_Type_Name.BackColor = System.Drawing.Color.White
        Me.TxtCommodity_Type_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCommodity_Type_Name.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCommodity_Type_Name.Location = New System.Drawing.Point(714, 92)
        Me.TxtCommodity_Type_Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCommodity_Type_Name.Name = "TxtCommodity_Type_Name"
        Me.TxtCommodity_Type_Name.Size = New System.Drawing.Size(151, 65)
        Me.TxtCommodity_Type_Name.TabIndex = 3
        '
        'TxtCommodity_Type_Description
        '
        Me.TxtCommodity_Type_Description.BackColor = System.Drawing.Color.White
        Me.TxtCommodity_Type_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCommodity_Type_Description.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCommodity_Type_Description.Location = New System.Drawing.Point(1128, 92)
        Me.TxtCommodity_Type_Description.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCommodity_Type_Description.Name = "TxtCommodity_Type_Description"
        Me.TxtCommodity_Type_Description.Size = New System.Drawing.Size(668, 65)
        Me.TxtCommodity_Type_Description.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.DateTimePicker1.BorderSize = 0
        Me.DateTimePicker1.CustomFormat = "yyyy年MM月dd日 HH:mm:ss"
        Me.DateTimePicker1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(333, 15)
        Me.DateTimePicker1.MinimumSize = New System.Drawing.Size(0, 35)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(499, 47)
        Me.DateTimePicker1.SkinColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.TabIndex = 102
        Me.DateTimePicker1.TextColor = System.Drawing.Color.White
        '
        'frmRSS_Access_Commodity_Classification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1843, 1055)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtCommodity_Type_Description)
        Me.Controls.Add(Me.TxtCommodity_Type_Name)
        Me.Controls.Add(Me.TxtCommodity_TypeID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DGVCommodity_Classification)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRSS_Access_Commodity_Classification"
        Me.Text = "商品分類"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVCommodity_Classification,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGVCommodity_Classification As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCommodity_TypeID As TableText
    Friend WithEvents TxtCommodity_Type_Name As TableText
    Friend WithEvents TxtCommodity_Type_Description As TableText
    Friend WithEvents DateTimePicker1 As MCDateTimePicker
End Class
