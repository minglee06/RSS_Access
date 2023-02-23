Imports System.ComponentModel
Imports RSS_Access.Access_Connection
Public Class frmRSS_Access_Main
    Private Sub frmRSS_Access_Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Connection.Dispose()
        Me.Dispose()
        frmLogin.Close()
        frmRSS_Access.Dispose()
    End Sub

    Private Sub TileVerticalMenu_Click(sender As Object, e As EventArgs) Handles TileVerticalMenu.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalMenu_Click(sender As Object, e As EventArgs) Handles TileHorizontalMenu.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CascadeMenu_Click(sender As Object, e As EventArgs) Handles CascadeMenu.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub CloseMenuItem_Click(sender As Object, e As EventArgs) Handles CloseMenuItem.Click
        ' 關閉父表單的所有子表單。
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Private Sub MenuItem_SupplyADU_Click(sender As Object, e As EventArgs) Handles MenuItem_SupplyADU.Click
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_Supply" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()

                '  Me.ActivateMdiChild(myChildForm)
            End If
        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_Supply With {.MdiParent = Me}
            myForm.Show()

        End If
        'MenuOpenMdiChild(frmRSS_Access_Supply)
    End Sub

    Private Sub MenuItem_CustomerADU_Click(sender As Object, e As EventArgs) Handles MenuItem_CustomerADU.Click
        'MenuOpenMdiChild(frmRSS_Access_Customer)
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_Customer" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If

        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_Customer With {.MdiParent = Me}
            myForm.Show()
        End If
    End Sub
    'Public Property NewForm As Form = New Form
    Private Sub GetNewform(NewForm As Form)
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = NewForm.Name Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If
        Next
        If isFind = False Then
            Dim myFrm As New Form With {
                .Name = NewForm.Name,
                .MdiParent = Me
            }
            myFrm.Show()
        End If
    End Sub
    Private Sub MenuItem_SaleMan_Click(sender As Object, e As EventArgs) Handles MenuItem_SaleMan.Click
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_SalesManData" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If
        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_SalesManData With {.MdiParent = Me}
            myForm.Show()
        End If
    End Sub

    Private Sub MenuItem_Purchaser_Click(sender As Object, e As EventArgs) Handles MenuItem_Purchaser.Click
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_Purchaser" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If
        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_Purchaser With {.MdiParent = Me}
            myForm.Show()
        End If
    End Sub
    Private Sub MenuItem_CommodityADU_Click(sender As Object, e As EventArgs) Handles MenuItem_CommodityADU.Click
        'GetNewform(frmRSS_Access_Commodity)
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_CommodityV2" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If
        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_CommodityV2 With {.MdiParent = Me}
            myForm.Show()
        End If
    End Sub

    Private Sub MenuItem_Commodity_Classification_Click(sender As Object, e As EventArgs) Handles MenuItem_Commodity_Classification.Click
        'GetNewform(frmRSS_Access_Commodity)
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_Commodity_Classification" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If
        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_Commodity_Classification With {.MdiParent = Me}
            myForm.Show()
        End If
    End Sub

    Private Sub MenuItem_PurchasOrderADU_Click(sender As Object, e As EventArgs) Handles MenuItem_PurchasOrderADU.Click
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_PurchaseOrder" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If
        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_PurchaseOrder With {.MdiParent = Me}
            myForm.Show()
        End If
    End Sub

    Private Sub MenuItem_PurchaseOrderQuery_Click(sender As Object, e As EventArgs) Handles MenuItem_PurchaseOrderQuery.Click
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_PurchaseOrder_Query" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If
        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_Purchaseorder_Query With {.MdiParent = Me}
            myForm.Show()
        End If
    End Sub

    Private Sub MenuItem_WarehouseVoucher_Click(sender As Object, e As EventArgs) Handles MenuItem_WarehouseVoucher.Click
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_WarehouseVoucher" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If
        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_WarehouseVoucher With {.MdiParent = Me}
            myForm.Show()
        End If
    End Sub

    Private Sub MenuItem_FreightTransport_Click(sender As Object, e As EventArgs) Handles MenuItem_FreightTransport.Click
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_FreightTransport" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If
        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_FreightTransport With {.MdiParent = Me}
            myForm.Show()
        End If
    End Sub

    Private Sub MenuItem_SaleOrder_Click(sender As Object, e As EventArgs) Handles MenuItem_SaleOrder.Click
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_SaleOrder" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If
        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_SaleOrder With {.MdiParent = Me}
            myForm.Show()
        End If
    End Sub

    Private Sub MenuItem_DeliveryOrder_Click(sender As Object, e As EventArgs) Handles MenuItem_DeliveryOrder.Click
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_DeliveryOrder" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If
        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_DeliveryOrder With {.MdiParent = Me}
            myForm.Show()
        End If
    End Sub

    Private Sub MenuItem_SaleOrder_QM_Click(sender As Object, e As EventArgs) Handles MenuItem_SaleOrder_QM.Click
        Dim isFind As Boolean = False
        For Each myChildForm As Form In Me.MdiChildren
            If myChildForm.Name = "frmRSS_Access_SaleOrderQuery" Then
                isFind = True
                myChildForm.MdiParent = Me
                myChildForm.Focus()
            End If
        Next
        '  Try
        If isFind = False Then
            Dim myForm As New frmRSS_Access_SaleOrderQuery With {.MdiParent = Me}
            myForm.Show()
        End If
    End Sub
End Class