<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRSS_Access_WarehouseVoucher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_WarehouseVoucher))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.LblDelRow = New System.Windows.Forms.Label()
        Me.BtnPrint_WV = New Guna.UI2.WinForms.Guna2Button()
        Me.LblAddRow = New System.Windows.Forms.Label()
        Me.BtnSummation = New Guna.UI2.WinForms.Guna2Button()
        Me.lblToTalSum = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TLPWV = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtSupply_Name = New RSS_Access.TableText()
        Me.TxtSupply_Tax_ID = New RSS_Access.TableText()
        Me.TxtWVID = New RSS_Access.TableText()
        Me.TLPWV.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "入庫單編號"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(581, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "入庫日期"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(756, 49)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(269, 47)
        Me.DateTimePicker1.TabIndex = 3
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BorderColor = System.Drawing.Color.Transparent
        Me.BtnSave.BorderRadius = 10
        Me.BtnSave.CheckedState.Parent = Me.BtnSave
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.CustomImages.Parent = Me.BtnSave
        Me.BtnSave.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnSave.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnSave.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnSave.HoverState.Parent = Me.BtnSave
        Me.BtnSave.Location = New System.Drawing.Point(717, 261)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.Size = New System.Drawing.Size(157, 65)
        Me.BtnSave.TabIndex = 11
        Me.BtnSave.Text = "儲存"
        '
        'LblDelRow
        '
        Me.LblDelRow.AutoSize = True
        Me.LblDelRow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblDelRow.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.LblDelRow.ForeColor = System.Drawing.Color.Blue
        Me.LblDelRow.Location = New System.Drawing.Point(1106, 278)
        Me.LblDelRow.Name = "LblDelRow"
        Me.LblDelRow.Size = New System.Drawing.Size(124, 28)
        Me.LblDelRow.TabIndex = 13
        Me.LblDelRow.Text = "刪除一列"
        '
        'BtnPrint_WV
        '
        Me.BtnPrint_WV.BorderColor = System.Drawing.Color.White
        Me.BtnPrint_WV.BorderRadius = 10
        Me.BtnPrint_WV.CheckedState.Parent = Me.BtnPrint_WV
        Me.BtnPrint_WV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint_WV.CustomImages.Parent = Me.BtnPrint_WV
        Me.BtnPrint_WV.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.BtnPrint_WV.ForeColor = System.Drawing.Color.White
        Me.BtnPrint_WV.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnPrint_WV.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnPrint_WV.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnPrint_WV.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnPrint_WV.HoverState.Parent = Me.BtnPrint_WV
        Me.BtnPrint_WV.Location = New System.Drawing.Point(896, 261)
        Me.BtnPrint_WV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPrint_WV.Name = "BtnPrint_WV"
        Me.BtnPrint_WV.ShadowDecoration.Parent = Me.BtnPrint_WV
        Me.BtnPrint_WV.Size = New System.Drawing.Size(192, 65)
        Me.BtnPrint_WV.TabIndex = 12
        Me.BtnPrint_WV.Text = "列印入庫單"
        '
        'LblAddRow
        '
        Me.LblAddRow.AutoSize = True
        Me.LblAddRow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAddRow.Font = New System.Drawing.Font("標楷體", 18.0!)
        Me.LblAddRow.ForeColor = System.Drawing.Color.Blue
        Me.LblAddRow.Location = New System.Drawing.Point(1232, 277)
        Me.LblAddRow.Name = "LblAddRow"
        Me.LblAddRow.Size = New System.Drawing.Size(133, 30)
        Me.LblAddRow.TabIndex = 14
        Me.LblAddRow.Text = "增加一列"
        '
        'BtnSummation
        '
        Me.BtnSummation.BackColor = System.Drawing.Color.Transparent
        Me.BtnSummation.BorderColor = System.Drawing.Color.Transparent
        Me.BtnSummation.BorderRadius = 10
        Me.BtnSummation.CheckedState.Parent = Me.BtnSummation
        Me.BtnSummation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSummation.CustomImages.Parent = Me.BtnSummation
        Me.BtnSummation.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSummation.ForeColor = System.Drawing.Color.White
        Me.BtnSummation.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnSummation.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnSummation.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnSummation.HoverState.Parent = Me.BtnSummation
        Me.BtnSummation.Location = New System.Drawing.Point(34, 261)
        Me.BtnSummation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSummation.Name = "BtnSummation"
        Me.BtnSummation.ShadowDecoration.Parent = Me.BtnSummation
        Me.BtnSummation.Size = New System.Drawing.Size(157, 65)
        Me.BtnSummation.TabIndex = 8
        Me.BtnSummation.Text = "總合計"
        '
        'lblToTalSum
        '
        Me.lblToTalSum.AutoSize = True
        Me.lblToTalSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblToTalSum.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.lblToTalSum.ForeColor = System.Drawing.Color.Red
        Me.lblToTalSum.Location = New System.Drawing.Point(354, 279)
        Me.lblToTalSum.Name = "lblToTalSum"
        Me.lblToTalSum.Size = New System.Drawing.Size(222, 28)
        Me.lblToTalSum.TabIndex = 10
        Me.lblToTalSum.Text = "***************"
        Me.lblToTalSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("標楷體", 16.2!)
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(210, 279)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 28)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "合計總價："
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(28, 161)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(185, 33)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "供應商統編"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(581, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(185, 33)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "供應商名稱"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(1671, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(271, 78)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "合計"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1410, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(254, 78)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "進貨單價"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(4, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 78)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "項次"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(867, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 78)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "商品種類"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(366, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(494, 78)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "商品名稱"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(105, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(1)
        Me.Label3.Size = New System.Drawing.Size(254, 78)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "商品編號"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1229, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 78)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "單位"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1048, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 78)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "入庫數量"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TLPWV
        '
        Me.TLPWV.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TLPWV.ColumnCount = 8
        Me.TLPWV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TLPWV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.TLPWV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500.0!))
        Me.TLPWV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TLPWV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TLPWV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TLPWV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.TLPWV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277.0!))
        Me.TLPWV.Controls.Add(Me.Label6, 4, 0)
        Me.TLPWV.Controls.Add(Me.Label8, 5, 0)
        Me.TLPWV.Controls.Add(Me.Label3, 1, 0)
        Me.TLPWV.Controls.Add(Me.Label4, 2, 0)
        Me.TLPWV.Controls.Add(Me.Label5, 3, 0)
        Me.TLPWV.Controls.Add(Me.Label10, 0, 0)
        Me.TLPWV.Controls.Add(Me.Label11, 6, 0)
        Me.TLPWV.Controls.Add(Me.Label12, 7, 0)
        Me.TLPWV.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TLPWV.Location = New System.Drawing.Point(2, 343)
        Me.TLPWV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TLPWV.Name = "TLPWV"
        Me.TLPWV.RowCount = 1
        Me.TLPWV.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPWV.Size = New System.Drawing.Size(1900, 80)
        Me.TLPWV.TabIndex = 15
        '
        'TxtSupply_Name
        '
        Me.TxtSupply_Name.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Name.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtSupply_Name.Location = New System.Drawing.Point(772, 148)
        Me.TxtSupply_Name.Name = "TxtSupply_Name"
        Me.TxtSupply_Name.Size = New System.Drawing.Size(794, 65)
        Me.TxtSupply_Name.TabIndex = 7
        '
        'TxtSupply_Tax_ID
        '
        Me.TxtSupply_Tax_ID.BackColor = System.Drawing.Color.White
        Me.TxtSupply_Tax_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupply_Tax_ID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtSupply_Tax_ID.Location = New System.Drawing.Point(215, 148)
        Me.TxtSupply_Tax_ID.Name = "TxtSupply_Tax_ID"
        Me.TxtSupply_Tax_ID.Size = New System.Drawing.Size(283, 65)
        Me.TxtSupply_Tax_ID.TabIndex = 5
        '
        'TxtWVID
        '
        Me.TxtWVID.BackColor = System.Drawing.Color.White
        Me.TxtWVID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtWVID.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtWVID.Location = New System.Drawing.Point(219, 43)
        Me.TxtWVID.Name = "TxtWVID"
        Me.TxtWVID.Size = New System.Drawing.Size(283, 65)
        Me.TxtWVID.TabIndex = 1
        '
        'frmRSS_Access_WarehouseVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.TLPWV)
        Me.Controls.Add(Me.TxtSupply_Name)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtSupply_Tax_ID)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BtnSummation)
        Me.Controls.Add(Me.lblToTalSum)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.LblDelRow)
        Me.Controls.Add(Me.BtnPrint_WV)
        Me.Controls.Add(Me.LblAddRow)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtWVID)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRSS_Access_WarehouseVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "入庫單"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TLPWV.ResumeLayout(False)
        Me.TLPWV.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtWVID As TableText
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblDelRow As Label
    Friend WithEvents BtnPrint_WV As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblAddRow As Label
    Friend WithEvents BtnSummation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblToTalSum As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtSupply_Tax_ID As TableText
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtSupply_Name As TableText
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TLPWV As TableLayoutPanel
End Class
