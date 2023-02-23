<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRSS_Access_PurchaseOrder_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_PurchaseOrder_Report))
        Me.PurchaseOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RSS_AccessDataSet = New RSS_Access.RSS_AccessDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PurchaseOrderTableAdapter = New RSS_Access.RSS_AccessDataSetTableAdapters.PurchaseOrderTableAdapter()
        Me.GRBPurchaseOrderQuery = New System.Windows.Forms.GroupBox()
        Me.BtnQuery = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtPurchaseOrderQuery = New RSS_Access.TableText()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RSS_AccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRBPurchaseOrderQuery.SuspendLayout()
        Me.SuspendLayout()
        '
        'PurchaseOrderBindingSource
        '
        Me.PurchaseOrderBindingSource.DataMember = "PurchaseOrder"
        Me.PurchaseOrderBindingSource.DataSource = Me.RSS_AccessDataSet
        '
        'RSS_AccessDataSet
        '
        Me.RSS_AccessDataSet.DataSetName = "RSS_AccessDataSet"
        Me.RSS_AccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoScroll = True
        ReportDataSource1.Name = "PurchaseOrderDS"
        ReportDataSource1.Value = Me.PurchaseOrderBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RSS_Access.PurchaseOrderReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 197)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1561, 850)
        Me.ReportViewer1.TabIndex = 0
        '
        'PurchaseOrderTableAdapter
        '
        Me.PurchaseOrderTableAdapter.ClearBeforeFill = True
        '
        'GRBPurchaseOrderQuery
        '
        Me.GRBPurchaseOrderQuery.Controls.Add(Me.BtnQuery)
        Me.GRBPurchaseOrderQuery.Controls.Add(Me.TxtPurchaseOrderQuery)
        Me.GRBPurchaseOrderQuery.Controls.Add(Me.Label1)
        Me.GRBPurchaseOrderQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GRBPurchaseOrderQuery.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GRBPurchaseOrderQuery.Location = New System.Drawing.Point(12, 4)
        Me.GRBPurchaseOrderQuery.Name = "GRBPurchaseOrderQuery"
        Me.GRBPurchaseOrderQuery.Size = New System.Drawing.Size(1044, 171)
        Me.GRBPurchaseOrderQuery.TabIndex = 1
        Me.GRBPurchaseOrderQuery.TabStop = False
        Me.GRBPurchaseOrderQuery.Text = "查詢"
        '
        'BtnQuery
        '
        Me.BtnQuery.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnQuery.BorderRadius = 10
        Me.BtnQuery.BorderThickness = 1
        Me.BtnQuery.CheckedState.Parent = Me.BtnQuery
        Me.BtnQuery.CustomImages.Parent = Me.BtnQuery
        Me.BtnQuery.FillColor = System.Drawing.Color.White
        Me.BtnQuery.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnQuery.HoverState.Parent = Me.BtnQuery
        Me.BtnQuery.Location = New System.Drawing.Point(614, 68)
        Me.BtnQuery.Name = "BtnQuery"
        Me.BtnQuery.ShadowDecoration.Parent = Me.BtnQuery
        Me.BtnQuery.Size = New System.Drawing.Size(221, 65)
        Me.BtnQuery.TabIndex = 2
        Me.BtnQuery.Text = "查詢"
        '
        'TxtPurchaseOrderQuery
        '
        Me.TxtPurchaseOrderQuery.BackColor = System.Drawing.Color.White
        Me.TxtPurchaseOrderQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPurchaseOrderQuery.Location = New System.Drawing.Point(218, 68)
        Me.TxtPurchaseOrderQuery.Name = "TxtPurchaseOrderQuery"
        Me.TxtPurchaseOrderQuery.Size = New System.Drawing.Size(360, 65)
        Me.TxtPurchaseOrderQuery.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "進貨單編號"
        '
        'frmRSS_Access_PurchaseOrder_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1640, 1053)
        Me.Controls.Add(Me.GRBPurchaseOrderQuery)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRSS_Access_PurchaseOrder_Report"
        Me.Text = "進貨單報表"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RSS_AccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRBPurchaseOrderQuery.ResumeLayout(False)
        Me.GRBPurchaseOrderQuery.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RSS_AccessDataSet As RSS_AccessDataSet
    Friend WithEvents PurchaseOrderBindingSource As BindingSource
    Friend WithEvents PurchaseOrderTableAdapter As RSS_AccessDataSetTableAdapters.PurchaseOrderTableAdapter
    Friend WithEvents GRBPurchaseOrderQuery As GroupBox
    Friend WithEvents BtnQuery As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtPurchaseOrderQuery As TableText
    Friend WithEvents Label1 As Label
End Class
