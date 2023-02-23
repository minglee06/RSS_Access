<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRSS_Access_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRSS_Access_Main))
        Me.RSS_Accsess_Menu = New System.Windows.Forms.MenuStrip()
        Me.Menu_RSS_Access_SaleCommodity = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_SaleOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_SaleOrder_QM = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_DeliveryOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.出貨單查詢ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_RSS_Access_PruchaseGoods = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_PurchasOrderADU = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_PurchaseOrderQuery = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_WarehouseVoucher = New System.Windows.Forms.ToolStripMenuItem()
        Me.入庫單查詢ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_RSS_Access_Supply = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_SupplyADU = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_SupplyQuery = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_RSS_Access_Customer = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CustomerADU = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CustomerQuery = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_RSS_Access_Commodity = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CommodityADU = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CommodityQuery = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Commodity_Detail = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_RSS_Access_Report = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_RSS_Access_Chart = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_RSS_Access_Parameter = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Admin = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Commodity_Classification = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Purchaser = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_SaleMan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_FreightTransport = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RSS_Accsess_Menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RSS_Accsess_Menu
        '
        Me.RSS_Accsess_Menu.BackColor = System.Drawing.Color.Gold
        Me.RSS_Accsess_Menu.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.RSS_Accsess_Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RSS_Accsess_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_RSS_Access_SaleCommodity, Me.Menu_RSS_Access_PruchaseGoods, Me.Menu_RSS_Access_Supply, Me.Menu_RSS_Access_Customer, Me.Menu_RSS_Access_Commodity, Me.Menu_RSS_Access_Report, Me.Menu_RSS_Access_Chart, Me.Menu_RSS_Access_Parameter, Me.MenuWindows})
        Me.RSS_Accsess_Menu.Location = New System.Drawing.Point(0, 0)
        Me.RSS_Accsess_Menu.MdiWindowListItem = Me.MenuWindows
        Me.RSS_Accsess_Menu.Name = "RSS_Accsess_Menu"
        Me.RSS_Accsess_Menu.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.RSS_Accsess_Menu.Size = New System.Drawing.Size(1627, 41)
        Me.RSS_Accsess_Menu.TabIndex = 0
        Me.RSS_Accsess_Menu.Text = "MenuStrip1"
        '
        'Menu_RSS_Access_SaleCommodity
        '
        Me.Menu_RSS_Access_SaleCommodity.BackColor = System.Drawing.Color.Gold
        Me.Menu_RSS_Access_SaleCommodity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_SaleOrder, Me.MenuItem_SaleOrder_QM, Me.MenuItem_DeliveryOrder, Me.出貨單查詢ToolStripMenuItem})
        Me.Menu_RSS_Access_SaleCommodity.Font = New System.Drawing.Font("標楷體", 19.8!)
        Me.Menu_RSS_Access_SaleCommodity.Name = "Menu_RSS_Access_SaleCommodity"
        Me.Menu_RSS_Access_SaleCommodity.Size = New System.Drawing.Size(97, 37)
        Me.Menu_RSS_Access_SaleCommodity.Text = "銷貨"
        '
        'MenuItem_SaleOrder
        '
        Me.MenuItem_SaleOrder.Name = "MenuItem_SaleOrder"
        Me.MenuItem_SaleOrder.Size = New System.Drawing.Size(427, 38)
        Me.MenuItem_SaleOrder.Text = "銷貨單"
        '
        'MenuItem_SaleOrder_QM
        '
        Me.MenuItem_SaleOrder_QM.Name = "MenuItem_SaleOrder_QM"
        Me.MenuItem_SaleOrder_QM.Size = New System.Drawing.Size(427, 38)
        Me.MenuItem_SaleOrder_QM.Text = "銷貨單查詢修改刪除"
        '
        'MenuItem_DeliveryOrder
        '
        Me.MenuItem_DeliveryOrder.Name = "MenuItem_DeliveryOrder"
        Me.MenuItem_DeliveryOrder.Size = New System.Drawing.Size(427, 38)
        Me.MenuItem_DeliveryOrder.Text = "出貨單"
        '
        '出貨單查詢ToolStripMenuItem
        '
        Me.出貨單查詢ToolStripMenuItem.Name = "出貨單查詢ToolStripMenuItem"
        Me.出貨單查詢ToolStripMenuItem.Size = New System.Drawing.Size(427, 38)
        Me.出貨單查詢ToolStripMenuItem.Text = "出貨單查詢"
        '
        'Menu_RSS_Access_PruchaseGoods
        '
        Me.Menu_RSS_Access_PruchaseGoods.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_PurchasOrderADU, Me.MenuItem_PurchaseOrderQuery, Me.MenuItem_WarehouseVoucher, Me.入庫單查詢ToolStripMenuItem})
        Me.Menu_RSS_Access_PruchaseGoods.Name = "Menu_RSS_Access_PruchaseGoods"
        Me.Menu_RSS_Access_PruchaseGoods.Size = New System.Drawing.Size(97, 37)
        Me.Menu_RSS_Access_PruchaseGoods.Text = "進貨"
        '
        'MenuItem_PurchasOrderADU
        '
        Me.MenuItem_PurchasOrderADU.Name = "MenuItem_PurchasOrderADU"
        Me.MenuItem_PurchasOrderADU.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_PurchasOrderADU.Text = "進貨單"
        '
        'MenuItem_PurchaseOrderQuery
        '
        Me.MenuItem_PurchaseOrderQuery.Name = "MenuItem_PurchaseOrderQuery"
        Me.MenuItem_PurchaseOrderQuery.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_PurchaseOrderQuery.Text = "進貨單查詢"
        '
        'MenuItem_WarehouseVoucher
        '
        Me.MenuItem_WarehouseVoucher.Name = "MenuItem_WarehouseVoucher"
        Me.MenuItem_WarehouseVoucher.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_WarehouseVoucher.Text = "入庫單"
        '
        '入庫單查詢ToolStripMenuItem
        '
        Me.入庫單查詢ToolStripMenuItem.Name = "入庫單查詢ToolStripMenuItem"
        Me.入庫單查詢ToolStripMenuItem.Size = New System.Drawing.Size(291, 38)
        Me.入庫單查詢ToolStripMenuItem.Text = "入庫單查詢"
        '
        'Menu_RSS_Access_Supply
        '
        Me.Menu_RSS_Access_Supply.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_SupplyADU, Me.MenuItem_SupplyQuery})
        Me.Menu_RSS_Access_Supply.Name = "Menu_RSS_Access_Supply"
        Me.Menu_RSS_Access_Supply.Size = New System.Drawing.Size(131, 37)
        Me.Menu_RSS_Access_Supply.Text = "供應商"
        '
        'MenuItem_SupplyADU
        '
        Me.MenuItem_SupplyADU.Name = "MenuItem_SupplyADU"
        Me.MenuItem_SupplyADU.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_SupplyADU.Text = "供應商資料"
        '
        'MenuItem_SupplyQuery
        '
        Me.MenuItem_SupplyQuery.Name = "MenuItem_SupplyQuery"
        Me.MenuItem_SupplyQuery.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_SupplyQuery.Text = "供應商查詢"
        '
        'Menu_RSS_Access_Customer
        '
        Me.Menu_RSS_Access_Customer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_CustomerADU, Me.MenuItem_CustomerQuery})
        Me.Menu_RSS_Access_Customer.Name = "Menu_RSS_Access_Customer"
        Me.Menu_RSS_Access_Customer.Size = New System.Drawing.Size(97, 37)
        Me.Menu_RSS_Access_Customer.Text = "客戶"
        '
        'MenuItem_CustomerADU
        '
        Me.MenuItem_CustomerADU.Name = "MenuItem_CustomerADU"
        Me.MenuItem_CustomerADU.Size = New System.Drawing.Size(257, 38)
        Me.MenuItem_CustomerADU.Text = "客戶資料"
        '
        'MenuItem_CustomerQuery
        '
        Me.MenuItem_CustomerQuery.Name = "MenuItem_CustomerQuery"
        Me.MenuItem_CustomerQuery.Size = New System.Drawing.Size(257, 38)
        Me.MenuItem_CustomerQuery.Text = "客戶查詢"
        '
        'Menu_RSS_Access_Commodity
        '
        Me.Menu_RSS_Access_Commodity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_CommodityADU, Me.MenuItem_CommodityQuery, Me.MenuItem_Commodity_Detail})
        Me.Menu_RSS_Access_Commodity.Name = "Menu_RSS_Access_Commodity"
        Me.Menu_RSS_Access_Commodity.Size = New System.Drawing.Size(97, 37)
        Me.Menu_RSS_Access_Commodity.Text = "商品"
        '
        'MenuItem_CommodityADU
        '
        Me.MenuItem_CommodityADU.Name = "MenuItem_CommodityADU"
        Me.MenuItem_CommodityADU.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_CommodityADU.Text = "商品主資料"
        '
        'MenuItem_CommodityQuery
        '
        Me.MenuItem_CommodityQuery.Name = "MenuItem_CommodityQuery"
        Me.MenuItem_CommodityQuery.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_CommodityQuery.Text = "商品主查詢"
        '
        'MenuItem_Commodity_Detail
        '
        Me.MenuItem_Commodity_Detail.Name = "MenuItem_Commodity_Detail"
        Me.MenuItem_Commodity_Detail.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_Commodity_Detail.Text = "商品細資料"
        '
        'Menu_RSS_Access_Report
        '
        Me.Menu_RSS_Access_Report.Name = "Menu_RSS_Access_Report"
        Me.Menu_RSS_Access_Report.Size = New System.Drawing.Size(97, 37)
        Me.Menu_RSS_Access_Report.Text = "報表"
        '
        'Menu_RSS_Access_Chart
        '
        Me.Menu_RSS_Access_Chart.Name = "Menu_RSS_Access_Chart"
        Me.Menu_RSS_Access_Chart.Size = New System.Drawing.Size(165, 37)
        Me.Menu_RSS_Access_Chart.Text = "圖表分析"
        '
        'Menu_RSS_Access_Parameter
        '
        Me.Menu_RSS_Access_Parameter.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_Admin, Me.MenuItem_Commodity_Classification, Me.MenuItem_Purchaser, Me.MenuItem_SaleMan, Me.MenuItem_FreightTransport})
        Me.Menu_RSS_Access_Parameter.Name = "Menu_RSS_Access_Parameter"
        Me.Menu_RSS_Access_Parameter.Size = New System.Drawing.Size(165, 37)
        Me.Menu_RSS_Access_Parameter.Text = "參數管理"
        '
        'MenuItem_Admin
        '
        Me.MenuItem_Admin.Name = "MenuItem_Admin"
        Me.MenuItem_Admin.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_Admin.Text = "管理者權限"
        '
        'MenuItem_Commodity_Classification
        '
        Me.MenuItem_Commodity_Classification.Name = "MenuItem_Commodity_Classification"
        Me.MenuItem_Commodity_Classification.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_Commodity_Classification.Text = "商品分類"
        '
        'MenuItem_Purchaser
        '
        Me.MenuItem_Purchaser.Name = "MenuItem_Purchaser"
        Me.MenuItem_Purchaser.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_Purchaser.Text = "進貨人員"
        '
        'MenuItem_SaleMan
        '
        Me.MenuItem_SaleMan.Name = "MenuItem_SaleMan"
        Me.MenuItem_SaleMan.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_SaleMan.Text = "銷貨人員"
        '
        'MenuItem_FreightTransport
        '
        Me.MenuItem_FreightTransport.Name = "MenuItem_FreightTransport"
        Me.MenuItem_FreightTransport.Size = New System.Drawing.Size(291, 38)
        Me.MenuItem_FreightTransport.Text = "貨運公司"
        '
        'MenuWindows
        '
        Me.MenuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeMenu, Me.TileVerticalMenu, Me.TileHorizontalMenu, Me.CloseMenuItem})
        Me.MenuWindows.Name = "MenuWindows"
        Me.MenuWindows.Size = New System.Drawing.Size(148, 37)
        Me.MenuWindows.Text = "視窗(&W)"
        '
        'CascadeMenu
        '
        Me.CascadeMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CascadeMenu.Name = "CascadeMenu"
        Me.CascadeMenu.Size = New System.Drawing.Size(308, 38)
        Me.CascadeMenu.Text = "重疊顯示(&C)"
        '
        'TileVerticalMenu
        '
        Me.TileVerticalMenu.Name = "TileVerticalMenu"
        Me.TileVerticalMenu.Size = New System.Drawing.Size(308, 38)
        Me.TileVerticalMenu.Text = "垂直並排(&V)"
        '
        'TileHorizontalMenu
        '
        Me.TileHorizontalMenu.Name = "TileHorizontalMenu"
        Me.TileHorizontalMenu.Size = New System.Drawing.Size(308, 38)
        Me.TileHorizontalMenu.Text = "水平並排(&H)"
        '
        'CloseMenuItem
        '
        Me.CloseMenuItem.Name = "CloseMenuItem"
        Me.CloseMenuItem.Size = New System.Drawing.Size(308, 38)
        Me.CloseMenuItem.Text = "全部關閉(&L)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.RSS_Access.My.Resources.Resources.RSS_1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 41)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1627, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmRSS_Access_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1627, 833)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RSS_Accsess_Menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.RSS_Accsess_Menu
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRSS_Access_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RSS進銷存管理系統主畫面"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RSS_Accsess_Menu.ResumeLayout(False)
        Me.RSS_Accsess_Menu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RSS_Accsess_Menu As MenuStrip
    Friend WithEvents Menu_RSS_Access_SaleCommodity As ToolStripMenuItem
    Friend WithEvents Menu_RSS_Access_PruchaseGoods As ToolStripMenuItem
    Friend WithEvents Menu_RSS_Access_Supply As ToolStripMenuItem
    Friend WithEvents Menu_RSS_Access_Customer As ToolStripMenuItem
    Friend WithEvents Menu_RSS_Access_Commodity As ToolStripMenuItem
    Friend WithEvents Menu_RSS_Access_Report As ToolStripMenuItem
    Friend WithEvents Menu_RSS_Access_Chart As ToolStripMenuItem
    Friend WithEvents Menu_RSS_Access_Parameter As ToolStripMenuItem
    Friend WithEvents MenuWindows As ToolStripMenuItem
    Friend WithEvents CascadeMenu As ToolStripMenuItem
    Friend WithEvents TileVerticalMenu As ToolStripMenuItem
    Friend WithEvents TileHorizontalMenu As ToolStripMenuItem
    Friend WithEvents CloseMenuItem As ToolStripMenuItem
    Friend WithEvents MenuItem_Admin As ToolStripMenuItem
    Friend WithEvents MenuItem_Commodity_Classification As ToolStripMenuItem
    Friend WithEvents MenuItem_Purchaser As ToolStripMenuItem
    Friend WithEvents MenuItem_SupplyADU As ToolStripMenuItem
    Friend WithEvents MenuItem_SupplyQuery As ToolStripMenuItem
    Friend WithEvents MenuItem_CustomerADU As ToolStripMenuItem
    Friend WithEvents MenuItem_CustomerQuery As ToolStripMenuItem
    Friend WithEvents MenuItem_CommodityADU As ToolStripMenuItem
    Friend WithEvents MenuItem_CommodityQuery As ToolStripMenuItem
    Friend WithEvents MenuItem_SaleMan As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuItem_PurchasOrderADU As ToolStripMenuItem
    Friend WithEvents MenuItem_PurchaseOrderQuery As ToolStripMenuItem
    Friend WithEvents MenuItem_WarehouseVoucher As ToolStripMenuItem
    Friend WithEvents 入庫單查詢ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuItem_Commodity_Detail As ToolStripMenuItem
    Friend WithEvents MenuItem_SaleOrder As ToolStripMenuItem
    Friend WithEvents MenuItem_SaleOrder_QM As ToolStripMenuItem
    Friend WithEvents MenuItem_DeliveryOrder As ToolStripMenuItem
    Friend WithEvents 出貨單查詢ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuItem_FreightTransport As ToolStripMenuItem
End Class
