<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSubAssembly
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_loginheading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbx_partlist = New System.Windows.Forms.ListBox()
        Me.lbx_makebuy = New System.Windows.Forms.ListBox()
        Me.lbx_machinetype = New System.Windows.Forms.ListBox()
        Me.lbl_subassemblies = New System.Windows.Forms.Label()
        Me.txb_subassemblies = New System.Windows.Forms.TextBox()
        Me.lbl_machinetype = New System.Windows.Forms.Label()
        Me.lbl_labor = New System.Windows.Forms.Label()
        Me.txb_labor = New System.Windows.Forms.TextBox()
        Me.lbl_makebuy = New System.Windows.Forms.Label()
        Me.lbl_supplierid = New System.Windows.Forms.Label()
        Me.txb_supplierid = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txb_price = New System.Windows.Forms.TextBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.txb_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_drawingno = New System.Windows.Forms.Label()
        Me.txb_drawingno = New System.Windows.Forms.TextBox()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.txb_description = New System.Windows.Forms.TextBox()
        Me.lbl_partno = New System.Windows.Forms.Label()
        Me.txb_partno = New System.Windows.Forms.TextBox()
        Me.lbl_parentpartno = New System.Windows.Forms.Label()
        Me.txb_parentpartno = New System.Windows.Forms.TextBox()
        Me.lbl_parentdescription = New System.Windows.Forms.Label()
        Me.txb_parentdescription = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_parentassembly = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.lbx_subassylist = New System.Windows.Forms.ListBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_partslistheader = New System.Windows.Forms.Label()
        Me.lbl_subassemblyheader = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_loginheading
        '
        Me.lbl_loginheading.AutoSize = True
        Me.lbl_loginheading.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_loginheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loginheading.Location = New System.Drawing.Point(522, 9)
        Me.lbl_loginheading.Name = "lbl_loginheading"
        Me.lbl_loginheading.Size = New System.Drawing.Size(549, 37)
        Me.lbl_loginheading.TabIndex = 13
        Me.lbl_loginheading.Text = "MRP Dashboard - Edit Sub Assembly"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1599, 56)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'lbx_partlist
        '
        Me.lbx_partlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_partlist.FormattingEnabled = True
        Me.lbx_partlist.ItemHeight = 24
        Me.lbx_partlist.Location = New System.Drawing.Point(12, 112)
        Me.lbx_partlist.Name = "lbx_partlist"
        Me.lbx_partlist.Size = New System.Drawing.Size(457, 532)
        Me.lbx_partlist.TabIndex = 14
        '
        'lbx_makebuy
        '
        Me.lbx_makebuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_makebuy.FormattingEnabled = True
        Me.lbx_makebuy.ItemHeight = 24
        Me.lbx_makebuy.Location = New System.Drawing.Point(702, 477)
        Me.lbx_makebuy.Name = "lbx_makebuy"
        Me.lbx_makebuy.Size = New System.Drawing.Size(320, 28)
        Me.lbx_makebuy.TabIndex = 59
        '
        'lbx_machinetype
        '
        Me.lbx_machinetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_machinetype.FormattingEnabled = True
        Me.lbx_machinetype.ItemHeight = 24
        Me.lbx_machinetype.Location = New System.Drawing.Point(703, 548)
        Me.lbx_machinetype.Name = "lbx_machinetype"
        Me.lbx_machinetype.Size = New System.Drawing.Size(320, 28)
        Me.lbx_machinetype.TabIndex = 58
        '
        'lbl_subassemblies
        '
        Me.lbl_subassemblies.AutoSize = True
        Me.lbl_subassemblies.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subassemblies.Location = New System.Drawing.Point(550, 583)
        Me.lbl_subassemblies.Name = "lbl_subassemblies"
        Me.lbl_subassemblies.Size = New System.Drawing.Size(146, 24)
        Me.lbl_subassemblies.TabIndex = 57
        Me.lbl_subassemblies.Text = "Sub Assemblies"
        '
        'txb_subassemblies
        '
        Me.txb_subassemblies.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_subassemblies.Location = New System.Drawing.Point(702, 583)
        Me.txb_subassemblies.Name = "txb_subassemblies"
        Me.txb_subassemblies.Size = New System.Drawing.Size(321, 29)
        Me.txb_subassemblies.TabIndex = 56
        '
        'lbl_machinetype
        '
        Me.lbl_machinetype.AutoSize = True
        Me.lbl_machinetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_machinetype.Location = New System.Drawing.Point(550, 548)
        Me.lbl_machinetype.Name = "lbl_machinetype"
        Me.lbl_machinetype.Size = New System.Drawing.Size(131, 24)
        Me.lbl_machinetype.TabIndex = 55
        Me.lbl_machinetype.Text = "Machine Type"
        '
        'lbl_labor
        '
        Me.lbl_labor.AutoSize = True
        Me.lbl_labor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_labor.Location = New System.Drawing.Point(550, 513)
        Me.lbl_labor.Name = "lbl_labor"
        Me.lbl_labor.Size = New System.Drawing.Size(58, 24)
        Me.lbl_labor.TabIndex = 54
        Me.lbl_labor.Text = "Labor"
        '
        'txb_labor
        '
        Me.txb_labor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_labor.Location = New System.Drawing.Point(702, 513)
        Me.txb_labor.Name = "txb_labor"
        Me.txb_labor.Size = New System.Drawing.Size(321, 29)
        Me.txb_labor.TabIndex = 53
        '
        'lbl_makebuy
        '
        Me.lbl_makebuy.AutoSize = True
        Me.lbl_makebuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_makebuy.Location = New System.Drawing.Point(550, 478)
        Me.lbl_makebuy.Name = "lbl_makebuy"
        Me.lbl_makebuy.Size = New System.Drawing.Size(93, 24)
        Me.lbl_makebuy.TabIndex = 52
        Me.lbl_makebuy.Text = "Make/Buy"
        '
        'lbl_supplierid
        '
        Me.lbl_supplierid.AutoSize = True
        Me.lbl_supplierid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_supplierid.Location = New System.Drawing.Point(550, 443)
        Me.lbl_supplierid.Name = "lbl_supplierid"
        Me.lbl_supplierid.Size = New System.Drawing.Size(97, 24)
        Me.lbl_supplierid.TabIndex = 51
        Me.lbl_supplierid.Text = "SupplierID"
        '
        'txb_supplierid
        '
        Me.txb_supplierid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_supplierid.Location = New System.Drawing.Point(702, 443)
        Me.txb_supplierid.Name = "txb_supplierid"
        Me.txb_supplierid.Size = New System.Drawing.Size(321, 29)
        Me.txb_supplierid.TabIndex = 50
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(550, 408)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(53, 24)
        Me.lbl_price.TabIndex = 49
        Me.lbl_price.Text = "Price"
        '
        'txb_price
        '
        Me.txb_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_price.Location = New System.Drawing.Point(702, 408)
        Me.txb_price.Name = "txb_price"
        Me.txb_price.Size = New System.Drawing.Size(321, 29)
        Me.txb_price.TabIndex = 48
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(550, 373)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(78, 24)
        Me.lbl_quantity.TabIndex = 47
        Me.lbl_quantity.Text = "Quantity"
        '
        'txb_quantity
        '
        Me.txb_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_quantity.Location = New System.Drawing.Point(702, 373)
        Me.txb_quantity.Name = "txb_quantity"
        Me.txb_quantity.Size = New System.Drawing.Size(321, 29)
        Me.txb_quantity.TabIndex = 46
        '
        'lbl_drawingno
        '
        Me.lbl_drawingno.AutoSize = True
        Me.lbl_drawingno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_drawingno.Location = New System.Drawing.Point(550, 338)
        Me.lbl_drawingno.Name = "lbl_drawingno"
        Me.lbl_drawingno.Size = New System.Drawing.Size(109, 24)
        Me.lbl_drawingno.TabIndex = 45
        Me.lbl_drawingno.Text = "Drawing No"
        '
        'txb_drawingno
        '
        Me.txb_drawingno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_drawingno.Location = New System.Drawing.Point(702, 338)
        Me.txb_drawingno.Name = "txb_drawingno"
        Me.txb_drawingno.Size = New System.Drawing.Size(321, 29)
        Me.txb_drawingno.TabIndex = 44
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_description.Location = New System.Drawing.Point(550, 303)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(104, 24)
        Me.lbl_description.TabIndex = 43
        Me.lbl_description.Text = "Description"
        '
        'txb_description
        '
        Me.txb_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_description.Location = New System.Drawing.Point(702, 303)
        Me.txb_description.Name = "txb_description"
        Me.txb_description.Size = New System.Drawing.Size(321, 29)
        Me.txb_description.TabIndex = 42
        '
        'lbl_partno
        '
        Me.lbl_partno.AutoSize = True
        Me.lbl_partno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partno.Location = New System.Drawing.Point(550, 268)
        Me.lbl_partno.Name = "lbl_partno"
        Me.lbl_partno.Size = New System.Drawing.Size(72, 24)
        Me.lbl_partno.TabIndex = 41
        Me.lbl_partno.Text = "Part No"
        '
        'txb_partno
        '
        Me.txb_partno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_partno.Location = New System.Drawing.Point(702, 268)
        Me.txb_partno.Name = "txb_partno"
        Me.txb_partno.Size = New System.Drawing.Size(321, 29)
        Me.txb_partno.TabIndex = 40
        '
        'lbl_parentpartno
        '
        Me.lbl_parentpartno.AutoSize = True
        Me.lbl_parentpartno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_parentpartno.Location = New System.Drawing.Point(550, 159)
        Me.lbl_parentpartno.Name = "lbl_parentpartno"
        Me.lbl_parentpartno.Size = New System.Drawing.Size(72, 24)
        Me.lbl_parentpartno.TabIndex = 61
        Me.lbl_parentpartno.Text = "Part No"
        '
        'txb_parentpartno
        '
        Me.txb_parentpartno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_parentpartno.Location = New System.Drawing.Point(702, 159)
        Me.txb_parentpartno.Name = "txb_parentpartno"
        Me.txb_parentpartno.Size = New System.Drawing.Size(321, 29)
        Me.txb_parentpartno.TabIndex = 60
        '
        'lbl_parentdescription
        '
        Me.lbl_parentdescription.AutoSize = True
        Me.lbl_parentdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_parentdescription.Location = New System.Drawing.Point(550, 194)
        Me.lbl_parentdescription.Name = "lbl_parentdescription"
        Me.lbl_parentdescription.Size = New System.Drawing.Size(104, 24)
        Me.lbl_parentdescription.TabIndex = 63
        Me.lbl_parentdescription.Text = "Description"
        '
        'txb_parentdescription
        '
        Me.txb_parentdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_parentdescription.Location = New System.Drawing.Point(702, 194)
        Me.txb_parentdescription.Name = "txb_parentdescription"
        Me.txb_parentdescription.Size = New System.Drawing.Size(321, 29)
        Me.txb_parentdescription.TabIndex = 62
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.GrayText
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(529, 112)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(542, 124)
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'lbl_parentassembly
        '
        Me.lbl_parentassembly.AutoSize = True
        Me.lbl_parentassembly.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_parentassembly.Location = New System.Drawing.Point(722, 123)
        Me.lbl_parentassembly.Name = "lbl_parentassembly"
        Me.lbl_parentassembly.Size = New System.Drawing.Size(151, 24)
        Me.lbl_parentassembly.TabIndex = 65
        Me.lbl_parentassembly.Text = "Parent Assembly"
        '
        'btn_return
        '
        Me.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_return.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(1359, 658)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(228, 54)
        Me.btn_return.TabIndex = 70
        Me.btn_return.Text = "Return"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(246, 658)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(228, 54)
        Me.btn_edit.TabIndex = 69
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(1125, 658)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(228, 54)
        Me.btn_delete.TabIndex = 68
        Me.btn_delete.Text = "<< Delete "
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(12, 658)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(228, 54)
        Me.btn_add.TabIndex = 67
        Me.btn_add.Text = "Add  >>"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(713, 658)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(228, 54)
        Me.btn_update.TabIndex = 66
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'lbx_subassylist
        '
        Me.lbx_subassylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_subassylist.FormattingEnabled = True
        Me.lbx_subassylist.ItemHeight = 24
        Me.lbx_subassylist.Location = New System.Drawing.Point(1125, 112)
        Me.lbx_subassylist.Name = "lbx_subassylist"
        Me.lbx_subassylist.Size = New System.Drawing.Size(457, 532)
        Me.lbx_subassylist.TabIndex = 71
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(529, 242)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(542, 402)
        Me.PictureBox3.TabIndex = 72
        Me.PictureBox3.TabStop = False
        '
        'lbl_partslistheader
        '
        Me.lbl_partslistheader.AutoSize = True
        Me.lbl_partslistheader.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_partslistheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partslistheader.Location = New System.Drawing.Point(12, 72)
        Me.lbl_partslistheader.Name = "lbl_partslistheader"
        Me.lbl_partslistheader.Size = New System.Drawing.Size(111, 29)
        Me.lbl_partslistheader.TabIndex = 73
        Me.lbl_partslistheader.Text = "Parts List"
        '
        'lbl_subassemblyheader
        '
        Me.lbl_subassemblyheader.AutoSize = True
        Me.lbl_subassemblyheader.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_subassemblyheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subassemblyheader.Location = New System.Drawing.Point(1120, 72)
        Me.lbl_subassemblyheader.Name = "lbl_subassemblyheader"
        Me.lbl_subassemblyheader.Size = New System.Drawing.Size(227, 29)
        Me.lbl_subassemblyheader.TabIndex = 74
        Me.lbl_subassemblyheader.Text = "Sub Assembly Parts"
        '
        'EditSubAssembly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1598, 730)
        Me.Controls.Add(Me.lbl_subassemblyheader)
        Me.Controls.Add(Me.lbl_partslistheader)
        Me.Controls.Add(Me.lbx_subassylist)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_parentassembly)
        Me.Controls.Add(Me.lbl_parentdescription)
        Me.Controls.Add(Me.txb_parentdescription)
        Me.Controls.Add(Me.lbl_parentpartno)
        Me.Controls.Add(Me.txb_parentpartno)
        Me.Controls.Add(Me.lbx_makebuy)
        Me.Controls.Add(Me.lbx_machinetype)
        Me.Controls.Add(Me.lbl_subassemblies)
        Me.Controls.Add(Me.txb_subassemblies)
        Me.Controls.Add(Me.lbl_machinetype)
        Me.Controls.Add(Me.lbl_labor)
        Me.Controls.Add(Me.txb_labor)
        Me.Controls.Add(Me.lbl_makebuy)
        Me.Controls.Add(Me.lbl_supplierid)
        Me.Controls.Add(Me.txb_supplierid)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.txb_price)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.txb_quantity)
        Me.Controls.Add(Me.lbl_drawingno)
        Me.Controls.Add(Me.txb_drawingno)
        Me.Controls.Add(Me.lbl_description)
        Me.Controls.Add(Me.txb_description)
        Me.Controls.Add(Me.lbl_partno)
        Me.Controls.Add(Me.txb_partno)
        Me.Controls.Add(Me.lbx_partlist)
        Me.Controls.Add(Me.lbl_loginheading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "EditSubAssembly"
        Me.Text = "EditSubAssembly"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_loginheading As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbx_partlist As ListBox
    Friend WithEvents lbx_makebuy As ListBox
    Friend WithEvents lbx_machinetype As ListBox
    Friend WithEvents lbl_subassemblies As Label
    Friend WithEvents txb_subassemblies As TextBox
    Friend WithEvents lbl_machinetype As Label
    Friend WithEvents lbl_labor As Label
    Friend WithEvents txb_labor As TextBox
    Friend WithEvents lbl_makebuy As Label
    Friend WithEvents lbl_supplierid As Label
    Friend WithEvents txb_supplierid As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents txb_price As TextBox
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents txb_quantity As TextBox
    Friend WithEvents lbl_drawingno As Label
    Friend WithEvents txb_drawingno As TextBox
    Friend WithEvents lbl_description As Label
    Friend WithEvents txb_description As TextBox
    Friend WithEvents lbl_partno As Label
    Friend WithEvents txb_partno As TextBox
    Friend WithEvents lbl_parentpartno As Label
    Friend WithEvents txb_parentpartno As TextBox
    Friend WithEvents lbl_parentdescription As Label
    Friend WithEvents txb_parentdescription As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_parentassembly As Label
    Friend WithEvents btn_return As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents lbx_subassylist As ListBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lbl_partslistheader As Label
    Friend WithEvents lbl_subassemblyheader As Label
End Class
