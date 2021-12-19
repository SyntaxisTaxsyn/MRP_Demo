Public Class ViewBom

    Private View_Bom As BOM
    Private Sub ViewBom_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Call CreateBomView()
    End Sub

    Public Sub CreateBomView()
        Call SetTableHeadings()
        Call GetViewBom()
        Call DisplayBom()
        Call UpdateTotals()
    End Sub

    Private Sub UpdateTotals()
        lbl_totalcost.Text = "Total cost - $ " & View_Bom.TotalPrice
        lbl_totallabor.Text = "Total labor - Hr " & View_Bom.TotalLabor
    End Sub

    Private Sub SetTableHeadings()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("PartNo", "PartNo")
        DataGridView1.Columns.Add("Description", "Description")
        DataGridView1.Columns.Add("DrawingNumber", "DrawingNumber")
        DataGridView1.Columns.Add("Quantity", "Quantity")
        DataGridView1.Columns.Add("Price", "Price")
        DataGridView1.Columns.Add("SupplierID", "SupplierID")
        DataGridView1.Columns.Add("MakeBuy", "MakeBuy")
        DataGridView1.Columns.Add("Labour", "Labour")
        DataGridView1.Columns.Add("MachineType", "MachineType")
    End Sub

    Private Sub GetViewBom()
        View_Bom = ViewParts.GetBom
    End Sub

    Private Sub DisplayBom()
        For Each itm In View_Bom.Products
            DataGridView1.Rows.Add(CreateBomRow(itm))
        Next
    End Sub

    Private Function CreateBomRow(ByRef prd As Product) As String()
        Dim retval As String()
        Dim tmpstr As String = ""
        tmpstr += prd.PartNo & ","
        tmpstr += prd.Description & ","
        tmpstr += prd.DrawingNumber & ","
        tmpstr += prd.Quantity.ToString & ","
        tmpstr += prd.Price.ToString & ","
        tmpstr += prd.SupplierID.ToString & ","
        tmpstr += prd.GetMakeBuy & ","
        tmpstr += prd.Labour.ToString & ","
        tmpstr += prd.GetMachineType
        retval = tmpstr.Split(",")
        Return retval
    End Function

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        ViewParts.Show()
    End Sub

    Private Sub btn_exportbom_Click(sender As Object, e As EventArgs) Handles btn_exportbom.Click
        Dim ReportOutput As New ReportOutputPage()

        ReportOutput.TotalCost = View_Bom.TotalPrice.ToString
        ReportOutput.TotalLabor = View_Bom.TotalLabor.ToString
        ReportOutput.ParentPart = View_Bom.Product.PartNo & " - " & View_Bom.Product.Description

        For Each itm In View_Bom.Products
            ReportOutput.AddListItem(Join(CreateBomRow(itm), ","))
        Next

        Dim Report As New ReportOutput()
        Report.AddPage(ReportOutput)
        Report.GenerateHTMLReport()

    End Sub
End Class