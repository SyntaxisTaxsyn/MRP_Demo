Public Class EditSubAssembly
    Private ProductList As Products
    Private ProdListContext As List(Of Product)
    Private SubAssembly As Product
    Private SubassemblyListContext As List(Of Product)
    Private Sub EditSubAssembly_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub SetProductList(ByRef prdlst As Products)
        ProductList = prdlst
    End Sub
    Public Sub SetProductContext(ByRef prdctx As List(Of Product))
        ProdListContext = prdctx
    End Sub
    Public Sub SetSubAssembly(ByRef prd As Product)
        SubAssembly = prd
    End Sub
    Public Sub SetSubAssyContext(ByRef subctx As List(Of Product))
        SubassemblyListContext = subctx
    End Sub
    Private Sub EditSubAssembly_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Public Sub LoadSubAssyContext()
        LoadParts()
        UpdateParentProductDisplayByContext()
        UpdateSubPartsList()
        DisableExcessControls()
        DisableButtonControls()
    End Sub

    ''' <summary>
    ''' select enabled button controls depending on active listbox
    ''' </summary>
    ''' <param name="SelectCtx">0 = Parts list controls, 1 = Sub assy parts list controls</param>
    Private Sub UpdateControlEditContext(ByRef SelectCtx As Boolean)
        If SelectCtx = False Then
            btn_add.Enabled = True
            btn_edit.Enabled = False
            btn_update.Enabled = False
            btn_delete.Enabled = False
            btn_return.Enabled = True
        Else
            btn_add.Enabled = False
            btn_edit.Enabled = False
            btn_update.Enabled = True
            btn_delete.Enabled = True
            btn_return.Enabled = True
        End If
    End Sub

    Private Sub EnableEditControl(ByRef Enable As Boolean)
        If Enable Then
            btn_edit.Enabled = True
        Else
            btn_edit.Enabled = False
        End If
    End Sub

    Private Sub DisableButtonControls()
        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_update.Enabled = False
        btn_delete.Enabled = False
        btn_return.Enabled = False
    End Sub

    Private Sub DisableExcessControls()
        txb_partno.Enabled = False
        txb_description.Enabled = False
        txb_drawingno.Enabled = False
        txb_quantity.Enabled = True
        txb_price.Enabled = False
        txb_supplierid.Enabled = False
        lbx_makebuy.Enabled = False
        txb_labor.Enabled = False
        lbx_machinetype.Enabled = False
        txb_subassemblies.Enabled = False
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
        UpdateControlEditContext(False)
    End Sub

    Private Function GetPartNoFromListBoxEntry(ByRef LBXEntry As String) As String
        Dim tar() As String
        tar = Split(LBXEntry, " - ")
        Return tar(0)
    End Function

    Private Function GetProductFromListByProductNo(ByRef prdno As String) As Product
        For Each itm In ProductList.Products
            If itm.PartNo = prdno Then
                Return itm
            End If
        Next
        Return Nothing
    End Function

    Private Function GetProductFromSubAssyByProductNo(ByRef prdno As String) As Product
        For Each itm In SubAssembly.SubAssembly
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

    Private Sub UpdateParentProductDisplayByContext()
        txb_parentpartno.Text = SubAssembly.PartNo
        txb_parentdescription.Text = SubAssembly.Description
    End Sub

    Private Sub UpdateSubPartsList()
        lbx_subassylist.Items.Clear()
        If SubassemblyListContext.Count > 0 Then
            For Each itm In SubassemblyListContext
                lbx_subassylist.Items.Add(itm.PartNo & " - " & itm.Description)
            Next
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim SelectedProduct As Product
        Dim NewProduct As New Product
        Dim Prdno As String = txb_partno.Text
        SelectedProduct = GetProductFromListByProductNo(Prdno)
        Call AssignNewProduct(SelectedProduct, NewProduct)
        SubAssembly.SubAssembly.Add(NewProduct)
        UpdateSubPartsList()
    End Sub

    Private Sub AssignNewProduct(ByRef SP As Product, ByRef NP As Product)
        NP.PartNo = SP.PartNo
        NP.Description = SP.Description
        NP.DrawingNumber = SP.DrawingNumber
        NP.Quantity = SP.Quantity
        NP.Price = SP.Price
        NP.SupplierID = SP.SupplierID
        NP.MakeBuy = SP.MakeBuy
        NP.Labour = SP.Labour
        NP.MachineType = SP.MachineType
        NP.SubAssembly = SP.SubAssembly.ToList
    End Sub

    Private Sub lbx_subassylist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_subassylist.SelectedIndexChanged
        Dim SelectedPartNo As String = ""
        Dim SelectedProduct As New Product
        If lbx_subassylist.SelectedIndex > -1 Then
            SelectedPartNo = GetPartNoFromListBoxEntry(lbx_subassylist.SelectedItem)
        End If
        If Not SelectedPartNo = "" Then
            SelectedProduct = GetProductFromSubAssyByProductNo(SelectedPartNo)
        End If
        If SelectedProduct IsNot Nothing Then
            UpdateProductDisplayByProduct(SelectedProduct)
        End If
        UpdateControlEditContext(True)
        If SelectedProduct.MakeBuy = MakeBuy.Make Then
            EnableEditControl(True)
        Else
            EnableEditControl(False)
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim SelectedProduct As Product
        Dim Prdno As String = txb_partno.Text
        SelectedProduct = GetProductFromSubAssyByProductNo(Prdno)
        'SelectedProduct.PartNo = txb_partno.Text ' cant change part number 
        'SelectedProduct.Description = txb_description.Text
        'SelectedProduct.DrawingNumber = txb_drawingno.Text
        SelectedProduct.Quantity = Val(txb_quantity.Text) ' Only the quantity can change
        'SelectedProduct.Price = Val(txb_price.Text)
        'SelectedProduct.SupplierID = Val(txb_supplierid.Text)
        'SelectedProduct.MakeBuy = lbx_makebuy.SelectedIndex
        'SelectedProduct.Labour = Val(txb_labor.Text)
        'SelectedProduct.MachineType = lbx_machinetype.SelectedIndex
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            Dim prodno As String = txb_partno.Text
            Dim Delidx As Integer = 0
            For a = 0 To SubAssembly.SubAssembly.Count - 1
                If SubAssembly.SubAssembly(a).PartNo = prodno Then
                    Delidx = a
                    Exit For
                End If
            Next
            SubAssembly.SubAssembly.RemoveAt(Delidx)
            SubassemblyListContext = SubAssembly.SubAssembly
            UpdateSubPartsList()
            lbx_subassylist.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        EditParts.Show()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

    End Sub
End Class