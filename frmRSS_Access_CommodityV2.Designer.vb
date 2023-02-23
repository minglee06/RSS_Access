<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRSS_Access_CommodityV2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_CommodityV2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CMBCommodity_Unit = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblCommodity_Image_Path = New System.Windows.Forms.Label()
        Me.ImageBtnOpenFile = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BtnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGVCommodity = New System.Windows.Forms.DataGridView()
        Me.BtnDel = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PicCommodity = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CMBCommodity_Type = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DateTimePicker1 = New RSS_Access.MCDateTimePicker()
        Me.TxtCommodity_Qty_PerUnit = New RSS_Access.TableText()
        Me.TxtCommodity_SafeQty = New RSS_Access.TableText()
        Me.TxtSupply_Name = New RSS_Access.TableText()
        Me.TxtSupply_Tax_ID = New RSS_Access.TableText()
        Me.TxtCommodity_Name = New RSS_Access.TableText()
        Me.TxtCommodity_ID = New RSS_Access.TableText()
        CType(Me.DGVCommodity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCommodity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMBCommodity_Unit
        '
        Me.CMBCommodity_Unit.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBCommodity_Unit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMBCommodity_Unit.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.CMBCommodity_Unit.ForeColor = System.Drawing.Color.White
        Me.CMBCommodity_Unit.FormattingEnabled = True
        Me.CMBCommodity_Unit.Items.AddRange(New Object() {"請選擇"})
        Me.CMBCommodity_Unit.Location = New System.Drawing.Point(856, 380)
        Me.CMBCommodity_Unit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CMBCommodity_Unit.Name = "CMBCommodity_Unit"
        Me.CMBCommodity_Unit.Size = New System.Drawing.Size(184, 41)
        Me.CMBCommodity_Unit.TabIndex = 12
        Me.CMBCommodity_Unit.Text = "請選擇"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(1104, 384)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 33)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "數量/1單位"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(777, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 33)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "單位"
        '
        'LblCommodity_Image_Path
        '
        Me.LblCommodity_Image_Path.AutoSize = True
        Me.LblCommodity_Image_Path.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.LblCommodity_Image_Path.ForeColor = System.Drawing.Color.Black
        Me.LblCommodity_Image_Path.Location = New System.Drawing.Point(343, 101)
        Me.LblCommodity_Image_Path.Name = "LblCommodity_Image_Path"
        Me.LblCommodity_Image_Path.Size = New System.Drawing.Size(423, 33)
        Me.LblCommodity_Image_Path.TabIndex = 25
        Me.LblCommodity_Image_Path.Text = "請按下圖檔資料夾選擇圖檔"
        '
        'ImageBtnOpenFile
        '
        Me.ImageBtnOpenFile.AccessibleDescription = "開啟檔案"
        Me.ImageBtnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImageBtnOpenFile.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.ImageBtnOpenFile.CheckedState.Parent = Me.ImageBtnOpenFile
        Me.ImageBtnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImageBtnOpenFile.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.ImageBtnOpenFile.HoverState.Parent = Me.ImageBtnOpenFile
        Me.ImageBtnOpenFile.Image = CType(resources.GetObject("ImageBtnOpenFile.Image"), System.Drawing.Image)
        Me.ImageBtnOpenFile.ImageSize = New System.Drawing.Size(65, 65)
        Me.ImageBtnOpenFile.Location = New System.Drawing.Point(267, 87)
        Me.ImageBtnOpenFile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ImageBtnOpenFile.Name = "ImageBtnOpenFile"
        Me.ImageBtnOpenFile.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.ImageBtnOpenFile.PressedState.Parent = Me.ImageBtnOpenFile
        Me.ImageBtnOpenFile.Size = New System.Drawing.Size(58, 51)
        Me.ImageBtnOpenFile.TabIndex = 24
        Me.ImageBtnOpenFile.Tag = "開啟檔案"
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
        Me.BtnReset.Location = New System.Drawing.Point(865, 466)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.ShadowDecoration.Parent = Me.BtnReset
        Me.BtnReset.Size = New System.Drawing.Size(200, 65)
        Me.BtnReset.TabIndex = 20
        Me.BtnReset.Text = "重填"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(28, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(253, 33)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "現在日期及時間"
        '
        'DGVCommodity
        '
        Me.DGVCommodity.BackgroundColor = System.Drawing.Color.White
        Me.DGVCommodity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVCommodity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCommodity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("標楷體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCommodity.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVCommodity.GridColor = System.Drawing.Color.Black
        Me.DGVCommodity.Location = New System.Drawing.Point(1, 542)
        Me.DGVCommodity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVCommodity.Name = "DGVCommodity"
        Me.DGVCommodity.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DGVCommodity.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVCommodity.RowTemplate.Height = 29
        Me.DGVCommodity.Size = New System.Drawing.Size(2358, 466)
        Me.DGVCommodity.TabIndex = 26
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
        Me.BtnDel.Location = New System.Drawing.Point(586, 466)
        Me.BtnDel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.ShadowDecoration.Parent = Me.BtnDel
        Me.BtnDel.Size = New System.Drawing.Size(200, 65)
        Me.BtnDel.TabIndex = 19
        Me.BtnDel.Text = "刪除"
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
        Me.BtnUpdate.Location = New System.Drawing.Point(307, 466)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.ShadowDecoration.Parent = Me.BtnUpdate
        Me.BtnUpdate.Size = New System.Drawing.Size(200, 65)
        Me.BtnUpdate.TabIndex = 18
        Me.BtnUpdate.Text = "修改"
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
        Me.BtnAdd.Location = New System.Drawing.Point(27, 466)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.ShadowDecoration.Parent = Me.BtnAdd
        Me.BtnAdd.Size = New System.Drawing.Size(200, 65)
        Me.BtnAdd.TabIndex = 17
        Me.BtnAdd.Text = "新增"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(351, 367)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 66)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "商品" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "安全庫存"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicCommodity
        '
        Me.PicCommodity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCommodity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicCommodity.Location = New System.Drawing.Point(28, 167)
        Me.PicCommodity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicCommodity.Name = "PicCommodity"
        Me.PicCommodity.Size = New System.Drawing.Size(267, 237)
        Me.PicCommodity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCommodity.TabIndex = 217
        Me.PicCommodity.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(28, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 33)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "商品圖檔路徑"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(894, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 66)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "供應商" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "名稱"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(351, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 66)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "供應商" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "統一編號"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(889, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "商品名稱"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(351, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "商品編號"
        '
        'Timer1
        '
        '
        'CMBCommodity_Type
        '
        Me.CMBCommodity_Type.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBCommodity_Type.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMBCommodity_Type.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.CMBCommodity_Type.ForeColor = System.Drawing.Color.White
        Me.CMBCommodity_Type.FormattingEnabled = True
        Me.CMBCommodity_Type.Items.AddRange(New Object() {"請選擇"})
        Me.CMBCommodity_Type.Location = New System.Drawing.Point(1674, 185)
        Me.CMBCommodity_Type.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CMBCommodity_Type.Name = "CMBCommodity_Type"
        Me.CMBCommodity_Type.Size = New System.Drawing.Size(192, 41)
        Me.CMBCommodity_Type.TabIndex = 5
        Me.CMBCommodity_Type.Text = "請選擇"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(1519, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 33)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "商品種類"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.png "
        Me.OpenFileDialog1.Filter = "Png File|*.png|Jpg File|*.jpg|Bmp File|*.bmp|All File|*.*"
        Me.OpenFileDialog1.InitialDirectory = "../Commodity_Image/"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.DateTimePicker1.BorderSize = 0
        Me.DateTimePicker1.CustomFormat = "yyyy年MM月dd日 HH:mm:ss"
        Me.DateTimePicker1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(299, 24)
        Me.DateTimePicker1.MinimumSize = New System.Drawing.Size(4, 35)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(499, 47)
        Me.DateTimePicker1.SkinColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.TabIndex = 22
        Me.DateTimePicker1.TextColor = System.Drawing.Color.White
        '
        'TxtCommodity_Qty_PerUnit
        '
        Me.TxtCommodity_Qty_PerUnit.BackColor = System.Drawing.Color.White
        Me.TxtCommodity_Qty_PerUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCommodity_Qty_PerUnit.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCommodity_Qty_PerUnit.Location = New System.Drawing.Point(1293, 368)
        Me.TxtCommodity_Qty_PerUnit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCommodity_Qty_PerUnit.Name = "TxtCommodity_Qty_PerUnit"
        Me.TxtCommodity_Qty_PerUnit.Size = New System.Drawing.Size(159, 65)
        Me.TxtCommodity_Qty_PerUnit.TabIndex = 14
        '
        'TxtCommodity_SafeQty
        '
        Me.TxtCommodity_SafeQty.BackColor = System.Drawing.Color.White
        Me.TxtCommodity_SafeQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCommodity_SafeQty.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCommodity_SafeQty.Location = New System.Drawing.Point(507, 368)
        Me.TxtCommodity_SafeQty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCommodity_SafeQty.Name = "TxtCommodity_SafeQty"
        Me.TxtCommodity_SafeQty.Size = New System.Drawing.Size(222, 65)
        Me.TxtCommodity_SafeQty.TabIndex = 219
        '
        'TxtSupply_Name
        '
        Me.TxtSupply_Name.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Name.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtSupply_Name.Location = New System.Drawing.Point(1016, 273)
        Me.TxtSupply_Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSupply_Name.Name = "TxtSupply_Name"
        Me.TxtSupply_Name.Size = New System.Drawing.Size(478, 65)
        Me.TxtSupply_Name.TabIndex = 9
        '
        'TxtSupply_Tax_ID
        '
        Me.TxtSupply_Tax_ID.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Tax_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Tax_ID.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtSupply_Tax_ID.Location = New System.Drawing.Point(512, 273)
        Me.TxtSupply_Tax_ID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSupply_Tax_ID.Name = "TxtSupply_Tax_ID"
        Me.TxtSupply_Tax_ID.Size = New System.Drawing.Size(286, 65)
        Me.TxtSupply_Tax_ID.TabIndex = 7
        '
        'TxtCommodity_Name
        '
        Me.TxtCommodity_Name.BackColor = System.Drawing.Color.White
        Me.TxtCommodity_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCommodity_Name.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCommodity_Name.Location = New System.Drawing.Point(1045, 173)
        Me.TxtCommodity_Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCommodity_Name.Name = "TxtCommodity_Name"
        Me.TxtCommodity_Name.Size = New System.Drawing.Size(430, 65)
        Me.TxtCommodity_Name.TabIndex = 3
        '
        'TxtCommodity_ID
        '
        Me.TxtCommodity_ID.BackColor = System.Drawing.Color.White
        Me.TxtCommodity_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCommodity_ID.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.TxtCommodity_ID.Location = New System.Drawing.Point(505, 173)
        Me.TxtCommodity_ID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCommodity_ID.Name = "TxtCommodity_ID"
        Me.TxtCommodity_ID.Size = New System.Drawing.Size(286, 65)
        Me.TxtCommodity_ID.TabIndex = 1
        '
        'frmRSS_Access_CommodityV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.CMBCommodity_Type)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CMBCommodity_Unit)
        Me.Controls.Add(Me.TxtCommodity_Qty_PerUnit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblCommodity_Image_Path)
        Me.Controls.Add(Me.ImageBtnOpenFile)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGVCommodity)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtCommodity_SafeQty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PicCommodity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSupply_Name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtSupply_Tax_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCommodity_Name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCommodity_ID)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRSS_Access_CommodityV2"
        Me.Text = "商品資料"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVCommodity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCommodity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As MCDateTimePicker
    Friend WithEvents CMBCommodity_Unit As ComboBox
    Friend WithEvents TxtCommodity_Qty_PerUnit As TableText
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblCommodity_Image_Path As Label
    Friend WithEvents ImageBtnOpenFile As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BtnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DGVCommodity As DataGridView
    Friend WithEvents BtnDel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtCommodity_SafeQty As TableText
    Friend WithEvents Label6 As Label
    Friend WithEvents PicCommodity As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSupply_Name As TableText
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSupply_Tax_ID As TableText
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCommodity_Name As TableText
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCommodity_ID As TableText
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CMBCommodity_Type As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
