Public Class ViewParts
    Private ProductList As Products
    Private ProdListContext As List(Of Product)
    Private View_Bom As BOM

    Public Function GetBom() As BOM
        Return View_Bom
    End Function

    Private Sub ViewParts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'LoadParts()
    End Sub

    Public Sub LoadParts()
        ' initial load event displays all parts in the db
        ProductList = ManageParts.GetPartsDB
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
    End Sub

    Private Function GetProductFromListByProductNo(ByRef prdno As String) As Product
        For Each itm In ProductList.Products
            If itm.PartNo = prdno Then
                Return itm
            End If
        Next
        Return Nothing
    End Function

    Private Function GetPartNoFromListBoxEntry(ByRef LBXEntry As String) As String
        Dim tar() As String
        tar = Split(LBXEntry, " - ")
        Return tar(0)
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

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        ManageParts.Show()
    End Sub

    Private Sub btn_viewBOM_Click(sender As Object, e As EventArgs) Handles btn_viewBOM.Click
        Dim prodno As String = txb_partno.Text
        View_Bom = New BOM
        For a = 0 To ProductList.Products.Count - 1
            If ProductList.Products(a).PartNo = prodno Then
                View_BOM.Product = ProductList.Products(a)
                View_BOM.CreateBOM()
            End If
        Next
        Me.Hide()
        ViewBom.CreateBomView()
        ViewBom.Show()
    End Sub
End Class