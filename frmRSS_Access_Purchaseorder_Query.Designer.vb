<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRSS_Access_Purchaseorder_Query
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_Purchaseorder_Query))
        Me.CHBPurchaseOrder_ID = New System.Windows.Forms.CheckBox()
        Me.CHBCommodity_ID = New System.Windows.Forms.CheckBox()
        Me.TxtPurchaseOrder_ID = New RSS_Access.TableText()
        Me.CHBSupply_Tax_ID = New System.Windows.Forms.CheckBox()
        Me.CHBPurchaseOrder_Date = New System.Windows.Forms.CheckBox()
        Me.DTPPurchaseOrder_Date_Begin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPPurchaseOrder_Date_End = New System.Windows.Forms.DateTimePicker()
        Me.TxtCommodity_ID = New RSS_Access.TableText()
        Me.TxtSupply_Tax_ID = New RSS_Access.TableText()
        Me.BtnPurchaseOrder_Query = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BtnReChoice = New Guna.UI2.WinForms.Guna2Button()
        Me.DGVPurchaseOrder = New System.Windows.Forms.DataGridView()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.DGVPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CHBPurchaseOrder_ID
        '
        Me.CHBPurchaseOrder_ID.AutoSize = True
        Me.CHBPurchaseOrder_ID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CHBPurchaseOrder_ID.Location = New System.Drawing.Point(12, 113)
        Me.CHBPurchaseOrder_ID.Name = "CHBPurchaseOrder_ID"
        Me.CHBPurchaseOrder_ID.Size = New System.Drawing.Size(309, 37)
        Me.CHBPurchaseOrder_ID.TabIndex = 0
        Me.CHBPurchaseOrder_ID.Text = "依進貨單編號查詢"
        Me.CHBPurchaseOrder_ID.UseVisualStyleBackColor = True
        '
        'CHBCommodity_ID
        '
        Me.CHBCommodity_ID.AutoSize = True
        Me.CHBCommodity_ID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CHBCommodity_ID.Location = New System.Drawing.Point(658, 113)
        Me.CHBCommodity_ID.Name = "CHBCommodity_ID"
        Me.CHBCommodity_ID.Size = New System.Drawing.Size(275, 37)
        Me.CHBCommodity_ID.TabIndex = 2
        Me.CHBCommodity_ID.Text = "依商品編號查詢"
        Me.CHBCommodity_ID.UseVisualStyleBackColor = True
        '
        'TxtPurchaseOrder_ID
        '
        Me.TxtPurchaseOrder_ID.BackColor = System.Drawing.Color.White
        Me.TxtPurchaseOrder_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPurchaseOrder_ID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtPurchaseOrder_ID.Location = New System.Drawing.Point(352, 101)
        Me.TxtPurchaseOrder_ID.Name = "TxtPurchaseOrder_ID"
        Me.TxtPurchaseOrder_ID.Size = New System.Drawing.Size(240, 65)
        Me.TxtPurchaseOrder_ID.TabIndex = 1
        '
        'CHBSupply_Tax_ID
        '
        Me.CHBSupply_Tax_ID.AutoSize = True
        Me.CHBSupply_Tax_ID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CHBSupply_Tax_ID.Location = New System.Drawing.Point(1262, 113)
        Me.CHBSupply_Tax_ID.Name = "CHBSupply_Tax_ID"
        Me.CHBSupply_Tax_ID.Size = New System.Drawing.Size(377, 37)
        Me.CHBSupply_Tax_ID.TabIndex = 4
        Me.CHBSupply_Tax_ID.Text = "依供應商統一編號查詢"
        Me.CHBSupply_Tax_ID.UseVisualStyleBackColor = True
        '
        'CHBPurchaseOrder_Date
        '
        Me.CHBPurchaseOrder_Date.AutoSize = True
        Me.CHBPurchaseOrder_Date.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CHBPurchaseOrder_Date.Location = New System.Drawing.Point(12, 215)
        Me.CHBPurchaseOrder_Date.Name = "CHBPurchaseOrder_Date"
        Me.CHBPurchaseOrder_Date.Size = New System.Drawing.Size(207, 37)
        Me.CHBPurchaseOrder_Date.TabIndex = 6
        Me.CHBPurchaseOrder_Date.Text = "依日期查詢"
        Me.CHBPurchaseOrder_Date.UseVisualStyleBackColor = True
        '
        'DTPPurchaseOrder_Date_Begin
        '
        Me.DTPPurchaseOrder_Date_Begin.CalendarFont = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DTPPurchaseOrder_Date_Begin.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTPPurchaseOrder_Date_Begin.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DTPPurchaseOrder_Date_Begin.Location = New System.Drawing.Point(244, 211)
        Me.DTPPurchaseOrder_Date_Begin.Name = "DTPPurchaseOrder_Date_Begin"
        Me.DTPPurchaseOrder_Date_Begin.Size = New System.Drawing.Size(293, 47)
        Me.DTPPurchaseOrder_Date_Begin.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(545, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 33)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "~"
        '
        'DTPPurchaseOrder_Date_End
        '
        Me.DTPPurchaseOrder_Date_End.CalendarFont = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DTPPurchaseOrder_Date_End.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTPPurchaseOrder_Date_End.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DTPPurchaseOrder_Date_End.Location = New System.Drawing.Point(586, 211)
        Me.DTPPurchaseOrder_Date_End.Name = "DTPPurchaseOrder_Date_End"
        Me.DTPPurchaseOrder_Date_End.Size = New System.Drawing.Size(293, 47)
        Me.DTPPurchaseOrder_Date_End.TabIndex = 8
        '
        'TxtCommodity_ID
        '
        Me.TxtCommodity_ID.BackColor = System.Drawing.Color.White
        Me.TxtCommodity_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCommodity_ID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtCommodity_ID.Location = New System.Drawing.Point(962, 101)
        Me.TxtCommodity_ID.Name = "TxtCommodity_ID"
        Me.TxtCommodity_ID.Size = New System.Drawing.Size(240, 65)
        Me.TxtCommodity_ID.TabIndex = 3
        '
        'TxtSupply_Tax_ID
        '
        Me.TxtSupply_Tax_ID.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Tax_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Tax_ID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtSupply_Tax_ID.Location = New System.Drawing.Point(1670, 101)
        Me.TxtSupply_Tax_ID.Name = "TxtSupply_Tax_ID"
        Me.TxtSupply_Tax_ID.Size = New System.Drawing.Size(240, 65)
        Me.TxtSupply_Tax_ID.TabIndex = 5
        '
        'BtnPurchaseOrder_Query
        '
        Me.BtnPurchaseOrder_Query.BorderRadius = 10
        Me.BtnPurchaseOrder_Query.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.BtnPurchaseOrder_Query.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        'Me.BtnPurchaseOrder_Query.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        'Me.BtnPurchaseOrder_Query.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        'Me.BtnPurchaseOrder_Query.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnPurchaseOrder_Query.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPurchaseOrder_Query.ForeColor = System.Drawing.Color.White
        Me.BtnPurchaseOrder_Query.Location = New System.Drawing.Point(1283, 202)
        Me.BtnPurchaseOrder_Query.Name = "BtnPurchaseOrder_Query"
        Me.BtnPurchaseOrder_Query.Size = New System.Drawing.Size(221, 65)
        Me.BtnPurchaseOrder_Query.TabIndex = 10
        Me.BtnPurchaseOrder_Query.Text = "查詢"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.BorderRadius = 10
        Me.Guna2GroupBox1.Controls.Add(Me.BtnReChoice)
        Me.Guna2GroupBox1.Controls.Add(Me.CHBPurchaseOrder_ID)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnPurchaseOrder_Query)
        Me.Guna2GroupBox1.Controls.Add(Me.CHBCommodity_ID)
        Me.Guna2GroupBox1.Controls.Add(Me.TxtSupply_Tax_ID)
        Me.Guna2GroupBox1.Controls.Add(Me.TxtPurchaseOrder_ID)
        Me.Guna2GroupBox1.Controls.Add(Me.TxtCommodity_ID)
        Me.Guna2GroupBox1.Controls.Add(Me.CHBSupply_Tax_ID)
        Me.Guna2GroupBox1.Controls.Add(Me.DTPPurchaseOrder_Date_End)
        Me.Guna2GroupBox1.Controls.Add(Me.CHBPurchaseOrder_Date)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.DTPPurchaseOrder_Date_Begin)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(2198, 321)
        Me.Guna2GroupBox1.TabIndex = 12
        Me.Guna2GroupBox1.Text = "進貨查詢"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2GroupBox1.TextOffset = New System.Drawing.Point(0, 13)
        '
        'BtnReChoice
        '
        Me.BtnReChoice.BorderRadius = 10
        Me.BtnReChoice.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.BtnReChoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        'Me.BtnReChoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        'Me.BtnReChoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        'Me.BtnReChoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnReChoice.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReChoice.ForeColor = System.Drawing.Color.White
        Me.BtnReChoice.Location = New System.Drawing.Point(992, 202)
        Me.BtnReChoice.Name = "BtnReChoice"
        Me.BtnReChoice.Size = New System.Drawing.Size(221, 65)
        Me.BtnReChoice.TabIndex = 9
        Me.BtnReChoice.Text = "重新選擇"
        '
        'DGVPurchaseOrder
        '
        Me.DGVPurchaseOrder.BackgroundColor = System.Drawing.Color.White
        Me.DGVPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("標楷體", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPurchaseOrder.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPurchaseOrder.Location = New System.Drawing.Point(0, 327)
        Me.DGVPurchaseOrder.Name = "DGVPurchaseOrder"
        Me.DGVPurchaseOrder.RowHeadersWidth = 51
        Me.DGVPurchaseOrder.RowTemplate.Height = 27
        Me.DGVPurchaseOrder.Size = New System.Drawing.Size(2198, 647)
        Me.DGVPurchaseOrder.TabIndex = 13
        '
        'frmRSS_Access_Purchaseorder_Query
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 986)
        Me.Controls.Add(Me.DGVPurchaseOrder)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRSS_Access_Purchaseorder_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "進貨單查詢"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.DGVPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CHBPurchaseOrder_ID As CheckBox
    Friend WithEvents CHBCommodity_ID As CheckBox
    Friend WithEvents TxtPurchaseOrder_ID As TableText
    Friend WithEvents CHBSupply_Tax_ID As CheckBox
    Friend WithEvents CHBPurchaseOrder_Date As CheckBox
    Friend WithEvents DTPPurchaseOrder_Date_Begin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPPurchaseOrder_Date_End As DateTimePicker
    Friend WithEvents TxtCommodity_ID As TableText
    Friend WithEvents TxtSupply_Tax_ID As TableText
    Friend WithEvents BtnPurchaseOrder_Query As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents DGVPurchaseOrder As DataGridView
    Friend WithEvents BtnReChoice As Guna.UI2.WinForms.Guna2Button
End Class
