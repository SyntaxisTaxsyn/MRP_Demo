Imports System.Linq

Public Class EditParts
    Public ProductList As Products
    Private ProdListContext As List(Of Product)
    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        'ManageParts.SetPartsDB(ProductList)
        Me.Hide()
        ManageParts.Show()
    End Sub

    Private Sub LoadParts()
        ' initial load event displays all parts in the db
        ProdListContext = ProductList.Products
        UpdatePartsList(ProdListContext)
        FillMakeBuyControl()
        FillMachineTypeControl()
    End Sub

    Private Sub FillMakeBuyControl()
        lbx_makebuy.Items.Clear()
        Dim makebuylist As New List(Of String)
        Dim newproduct As New Product
        makebuylist = newproduct.GetMakeBuyList
        For Each itm In makebuylist
            lbx_makebuy.Items.Add(itm)
        Next
    End Sub

    Private Sub FillMachineTypeControl()
        lbx_machinetype.Items.Clear()
        Dim machinelist As New List(Of String)
        Dim NewMachine As New Machine
        machinelist = NewMachine.GetMachineTypeList
        For Each itm In machinelist
            lbx_machinetype.Items.Add(itm)
        Next
    End Sub

    Private Sub UpdatePartsList(ByRef ProdContext As List(Of Product))
        lbx_partlist.Items.Clear()
        For Each itm In ProdContext
            lbx_partlist.Items.Add(itm.PartNo & " - " & itm.Description)
        Next
    End Sub

    Private Sub MakeTestParts()
        ProductList = New Products

        Dim FirstProduct As New Product
        FirstProduct.PartNo = "12345"
        FirstProduct.Description = "Product1"
        FirstProduct.DrawingNumber = "MRP001"
        FirstProduct.Quantity = 1
        FirstProduct.Price = 10.0
        FirstProduct.SupplierID = "1234"
        FirstProduct.MakeBuy = MRP_Demo.MakeBuy.Make
        FirstProduct.Labour = 2.0
        FirstProduct.MachineType = MRP_Demo.MachineType.Lathe
        FirstProduct.SubAssembly = New List(Of Product)
        ProductList.Products.Add(FirstProduct)

        Dim SecondProduct As New Product
        SecondProduct.PartNo = "54321"
        SecondProduct.Description = "Product2"
        SecondProduct.DrawingNumber = "MRP002"
        SecondProduct.Quantity = 2
        SecondProduct.Price = 20.0
        SecondProduct.SupplierID = "4321"
        SecondProduct.MakeBuy = MRP_Demo.MakeBuy.Buy
        SecondProduct.Labour = 3.0
        SecondProduct.MachineType = MRP_Demo.MachineType.Borer
        SecondProduct.SubAssembly = New List(Of Product)
        ProductList.Products.Add(SecondProduct)

    End Sub

    Private Sub EditParts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MakeTestParts()
        ProductList = ManageParts.GetPartsDB
        LoadParts()

    End Sub

    Private Sub lbx_partlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_partlist.SelectedIndexChanged
        Dim SelectedPartNo As String = ""
        Dim SelectedProduct As New Product
        If lbx_partlist.SelectedIndex > -1 Then
            SelectedPartNo = GetPartNoFromListBoxEntry(lbx_partlist.SelectedItem)
        End If
        If Not SelectedPartNo = "" Then
            SelectedProduct = GetProductFromListByProductNo(SelectedPartNo)
        End If
        If SelectedProduct IsNot Nothing Then
            UpdateProductDisplayByProduct(SelectedProduct)
        End If
    End Sub

    Private Function GetProductFromListByProductNo(ByRef prdno As String) As Product
        For Each itm In ProductList.Products
            If itm.PartNo = prdno Then
                Return itm
            End If
        Next
        Return Nothing
    End Function

    Private Sub UpdateProductDisplayByProduct(ByRef PRD As Product)
        txb_partno.Text = PRD.PartNo
        txb_description.Text = PRD.Description
        txb_drawingno.Text = PRD.DrawingNumber
        txb_quantity.Text = PRD.Quantity
        txb_price.Text = PRD.Price
        txb_supplierid.Text = PRD.SupplierID
        lbx_makebuy.SelectedIndex = PRD.MakeBuy
        txb_labor.Text = PRD.Labour
        lbx_machinetype.SelectedIndex = PRD.MachineType
        txb_subassemblies.Text = PRD.SubAssembly.Count
    End Sub

    Private Function GetPartNoFromListBoxEntry(ByRef LBXEntry As String) As String
        Dim tar() As String
        tar = Split(LBXEntry, " - ")
        Return tar(0)
    End Function

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim SelectedProduct As Product
        Dim Prdno As String = txb_partno.Text
        SelectedProduct = GetProductFromListByProductNo(Prdno)
        'SelectedProduct.PartNo = txb_partno.Text ' cant change part number 
        SelectedProduct.Description = txb_description.Text
        SelectedProduct.DrawingNumber = txb_drawingno.Text
        SelectedProduct.Quantity = Val(txb_quantity.Text)
        SelectedProduct.Price = Val(txb_price.Text)
        SelectedProduct.SupplierID = Val(txb_supplierid.Text)
        SelectedProduct.MakeBuy = lbx_makebuy.SelectedIndex
        SelectedProduct.Labour = Val(txb_labor.Text)
        SelectedProduct.MachineType = lbx_machinetype.SelectedIndex
        'ProductList = ProductList ' so i can view the byref changes
        'MsgBox("not finished yet")
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim Prodno As String = txb_partno.Text
        If CheckProductNotExist(Prodno) Then
            Dim NewProduct As New Product
            NewProduct.PartNo = txb_partno.Text ' cant change part number 
            NewProduct.Description = txb_description.Text
            NewProduct.DrawingNumber = txb_drawingno.Text
            NewProduct.Quantity = Val(txb_quantity.Text)
            NewProduct.Price = Val(txb_price.Text)
            NewProduct.SupplierID = Val(txb_supplierid.Text)
            NewProduct.MakeBuy = lbx_makebuy.SelectedIndex
            NewProduct.Labour = Val(txb_labor.Text)
            NewProduct.MachineType = lbx_machinetype.SelectedIndex
            ProductList.Products.Add(NewProduct)
            ProdListContext = ProductList.Products
            UpdatePartsList(ProdListContext)
        End If
    End Sub

    Private Function CheckProductNotExist(ByRef prodno As String) As Boolean
        Dim result As Boolean = True
        For Each itm In ProductList.Products
            If itm.PartNo = prodno Then
                result = False
                Return result
            End If
        Next
        Return result
    End Function

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim prodno As String = txb_partno.Text
        Dim Delidx As Integer = 0
        For a = 0 To ProductList.Products.Count - 1
            If ProductList.Products(a).PartNo = prodno Then
                Delidx = a
                Exit For
            End If
        Next
        ProductList.Products.RemoveAt(Delidx)
        ProdListContext = ProductList.Products
        UpdatePartsList(ProdListContext)
        lbx_partlist.SelectedIndex = 0
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim prodno As String = txb_partno.Text
        For Each itm In ProductList.Products
            If itm.PartNo = prodno Then
                Call EditSubAssembly.SetProductList(ProductList)
                Call EditSubAssembly.SetProductContext(ProductList.Products)
                Call EditSubAssembly.SetSubAssembly(itm)
                Call EditSubAssembly.SetSubAssyContext(itm.SubAssembly)
                Call EditSubAssembly.LoadSubAssyContext()
            End If
        Next
        Me.Hide()
        EditSubAssembly.Show()
    End Sub
End Class