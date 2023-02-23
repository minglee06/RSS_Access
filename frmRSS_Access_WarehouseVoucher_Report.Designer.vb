<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRSS_Access_WarehouseVoucher_Report
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_WarehouseVoucher_Report))
        Me.WarehouseVoucherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RSS_AccessDataSet1 = New RSS_Access.RSS_AccessDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.WarehouseVoucherTableAdapter = New RSS_Access.RSS_AccessDataSet1TableAdapters.WarehouseVoucherTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnQuery = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtWarehouseVoucherQuery = New RSS_Access.TableText()
        CType(Me.WarehouseVoucherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RSS_AccessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WarehouseVoucherBindingSource
        '
        Me.WarehouseVoucherBindingSource.DataMember = "WarehouseVoucher"
        Me.WarehouseVoucherBindingSource.DataSource = Me.RSS_AccessDataSet1
        '
        'RSS_AccessDataSet1
        '
        Me.RSS_AccessDataSet1.DataSetName = "RSS_AccessDataSet1"
        Me.RSS_AccessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "WarehouseVoucher"
        ReportDataSource1.Value = Me.WarehouseVoucherBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RSS_Access.WarehouseVoucherReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 201)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1887, 811)
        Me.ReportViewer1.TabIndex = 0
        '
        'WarehouseVoucherTableAdapter
        '
        Me.WarehouseVoucherTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "入庫單編號"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnQuery)
        Me.GroupBox1.Controls.Add(Me.TxtWarehouseVoucherQuery)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1018, 179)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查詢"
        '
        'BtnQuery
        '
        Me.BtnQuery.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnQuery.BorderRadius = 10
        Me.BtnQuery.BorderThickness = 1
        Me.BtnQuery.CheckedState.Parent = Me.BtnQuery
        Me.BtnQuery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQuery.CustomImages.Parent = Me.BtnQuery
        Me.BtnQuery.FillColor = System.Drawing.Color.White
        Me.BtnQuery.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnQuery.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnQuery.HoverState.CustomBorderColor = System.Drawing.Color.Red
        Me.BtnQuery.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnQuery.HoverState.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnQuery.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnQuery.HoverState.Parent = Me.BtnQuery
        Me.BtnQuery.Location = New System.Drawing.Point(647, 71)
        Me.BtnQuery.Name = "BtnQuery"
        Me.BtnQuery.ShadowDecoration.Parent = Me.BtnQuery
        Me.BtnQuery.Size = New System.Drawing.Size(221, 65)
        Me.BtnQuery.TabIndex = 3
        Me.BtnQuery.Text = "查詢"
        '
        'TxtWarehouseVoucherQuery
        '
        Me.TxtWarehouseVoucherQuery.BackColor = System.Drawing.Color.White
        Me.TxtWarehouseVoucherQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtWarehouseVoucherQuery.Location = New System.Drawing.Point(221, 71)
        Me.TxtWarehouseVoucherQuery.Name = "TxtWarehouseVoucherQuery"
        Me.TxtWarehouseVoucherQuery.Size = New System.Drawing.Size(360, 65)
        Me.TxtWarehouseVoucherQuery.TabIndex = 2
        '
        'frmRSS_Access_WarehouseVoucher_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRSS_Access_WarehouseVoucher_Report"
        Me.Text = "入庫單報表"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WarehouseVoucherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RSS_AccessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RSS_AccessDataSet1 As RSS_AccessDataSet1
    Friend WithEvents WarehouseVoucherBindingSource As BindingSource
    Friend WithEvents WarehouseVoucherTableAdapter As RSS_AccessDataSet1TableAdapters.WarehouseVoucherTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnQuery As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtWarehouseVoucherQuery As TableText
End Class
