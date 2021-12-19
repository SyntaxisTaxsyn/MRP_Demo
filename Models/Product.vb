Public Class Products
    Public Products As List(Of Product)
    Public Sub New()
        Products = New List(Of Product)
    End Sub
End Class

Public Class Machines
    Public Machines As List(Of Machine)
    Public Sub New()
        Machines = New List(Of Machine)
    End Sub
End Class

Public Class BOM
    Public Product As Product
    Public Products As List(Of Product)
    Public TotalPrice As Single
    Public TotalLabor As Single

    Public Sub CreateBOM()
        Itemise()
        Totalise()
    End Sub

    Public Sub Itemise()
        Products = New List(Of Product)
        Products.Add(Product)
        For Each itm In Product.SubAssembly
            subitemise(itm)
        Next
    End Sub

    Private Sub subitemise(ByRef prd As Product)
        Products.Add(prd)
        If prd.SubAssembly.Count > 0 Then
            For Each itm In prd.SubAssembly
                subitemise(itm)
            Next
        End If
        'For Each itm In prd.SubAssembly
        '    Products.Add(itm)
        '    If itm.SubAssembly.Count > 0 Then
        '        For Each sitm In itm.SubAssembly
        '            subitemise(sitm)
        '        Next
        '    End If
        'Next
    End Sub

    Public Sub Totalise()
        TotalPrice = 0
        TotalLabor = 0
        For Each itm In Products
            TotalPrice += itm.Price * itm.Quantity
            TotalLabor += itm.Labour * itm.Quantity
            'SubTotalise(itm)
        Next
    End Sub

    Public Sub SubTotalise(ByRef prd As Product)
        TotalPrice += prd.Price * prd.Quantity
        TotalLabor += prd.Labour * prd.Quantity
        If prd.SubAssembly.Count > 0 Then
            For Each itm In prd.SubAssembly
                SubTotalise(itm)
            Next
        End If
    End Sub

End Class

Public Class Product
    Public PartNo As String
    Public Description As String
    Public DrawingNumber As String
    Public Quantity As Integer
    Public Price As Single ' Can be blank if this is parent of a sub assembly
    Public SupplierID As Integer
    Public MakeBuy As MakeBuy ' False = Make, True = Buy
    Public Labour As Single ' Number of hours required to make this
    Public MachineType As MachineType ' Type of machine that can make this product 
    Public SubAssembly As List(Of Product)
    Public Sub New()
        SubAssembly = New List(Of Product)
    End Sub
    Public Function GetMakeBuy() As String
        Select Case MakeBuy
            Case MakeBuy.Make
                Return "Make"
            Case MakeBuy.Buy
                Return "Buy"
            Case Else
                Return "Unset"
        End Select
    End Function

    Public Function GetMachineType() As String
        ' This is a yucky kludge but it keeps the machine type enum to string translator in the machine class
        Dim TempMachine As New Machine
        TempMachine.MachineType = MachineType
        Return TempMachine.GetMachineType
    End Function

    Public Function GetMakeBuyList() As List(Of String)
        ' Important, these must be added to the list in the same order as the enum is declared
        Dim retlist As New List(Of String)
        retlist.Add("Make")
        retlist.Add("Buy")
        Return retlist
    End Function
End Class

Public Enum MakeBuy
    Make
    Buy
End Enum

Public Class Machine
    Public MachineID As String
    Public MachineType As MachineType
    Public Function GetMachineType() As String
        Select Case MachineType
            Case MachineType.Vertical
                Return "Vertical"
            Case MachineType.Horizontal
                Return "Horizontal"
            Case MachineType.Milling
                Return "Milling"
            Case MachineType.Lathe
                Return "Lathe"
            Case MachineType.Borer
                Return "Borer"
            Case Else
                Return "Default"
        End Select
    End Function

    Public Function GetMachineTypeList() As List(Of String)
        ' Important, these must be added to the list in the same order as the enum is declared
        Dim retlist As New List(Of String)
        retlist.Add("None")
        retlist.Add("Vertical")
        retlist.Add("Horizontal")
        retlist.Add("Milling")
        retlist.Add("Lathe")
        retlist.Add("Borer")
        Return retlist
    End Function
End Class

Public Enum MachineType
    None
    Vertical
    Horizontal
    Milling
    Lathe
    Borer
End Enum

