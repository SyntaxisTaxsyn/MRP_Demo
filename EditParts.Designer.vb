<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditParts
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
        Me.components = New System.ComponentModel.Container()
        Me.lbl_loginheading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbx_partlist = New System.Windows.Forms.ListBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.txb_partno = New System.Windows.Forms.TextBox()
        Me.lbl_partno = New System.Windows.Forms.Label()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.txb_description = New System.Windows.Forms.TextBox()
        Me.lbl_drawingno = New System.Windows.Forms.Label()
        Me.txb_drawingno = New System.Windows.Forms.TextBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.txb_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txb_price = New System.Windows.Forms.TextBox()
        Me.lbl_subassemblies = New System.Windows.Forms.Label()
        Me.txb_subassemblies = New System.Windows.Forms.TextBox()
        Me.lbl_machinetype = New System.Windows.Forms.Label()
        Me.lbl_labor = New System.Windows.Forms.Label()
        Me.txb_labor = New System.Windows.Forms.TextBox()
        Me.lbl_makebuy = New System.Windows.Forms.Label()
        Me.lbl_supplierid = New System.Windows.Forms.Label()
        Me.txb_supplierid = New System.Windows.Forms.TextBox()
        Me.lbx_machinetype = New System.Windows.Forms.ListBox()
        Me.lbx_makebuy = New System.Windows.Forms.ListBox()
        Me.MachinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_loginheading
        '
        Me.lbl_loginheading.AutoSize = True
        Me.lbl_loginheading.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_loginheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loginheading.Location = New System.Drawing.Point(409, 9)
        Me.lbl_loginheading.Name = "lbl_loginheading"
        Me.lbl_loginheading.Size = New System.Drawing.Size(420, 37)
        Me.lbl_loginheading.TabIndex = 11
        Me.lbl_loginheading.Text = "MRP Dashboard - Edit Parts"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1307, 56)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lbx_partlist
        '
        Me.lbx_partlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_partlist.FormattingEnabled = True
        Me.lbx_partlist.ItemHeight = 24
        Me.lbx_partlist.Location = New System.Drawing.Point(12, 92)
        Me.lbx_partlist.Name = "lbx_partlist"
        Me.lbx_partlist.Size = New System.Drawing.Size(457, 556)
        Me.lbx_partlist.TabIndex = 12
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(67, 664)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(228, 54)
        Me.btn_update.TabIndex = 13
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(301, 664)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(228, 54)
        Me.btn_add.TabIndex = 14
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(535, 664)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(228, 54)
        Me.btn_delete.TabIndex = 15
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(769, 664)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(228, 54)
        Me.btn_edit.TabIndex = 16
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_return.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(1003, 664)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(228, 54)
        Me.btn_return.TabIndex = 17
        Me.btn_return.Text = "Return"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'txb_partno
        '
        Me.txb_partno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_partno.Location = New System.Drawing.Point(729, 115)
        Me.txb_partno.Name = "txb_partno"
        Me.txb_partno.Size = New System.Drawing.Size(321, 29)
        Me.txb_partno.TabIndex = 18
        '
        'lbl_partno
        '
        Me.lbl_partno.AutoSize = True
        Me.lbl_partno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partno.Location = New System.Drawing.Point(577, 115)
        Me.lbl_partno.Name = "lbl_partno"
        Me.lbl_partno.Size = New System.Drawing.Size(72, 24)
        Me.lbl_partno.TabIndex = 19
        Me.lbl_partno.Text = "Part No"
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_description.Location = New System.Drawing.Point(577, 150)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(104, 24)
        Me.lbl_description.TabIndex = 21
        Me.lbl_description.Text = "Description"
        '
        'txb_description
        '
        Me.txb_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_description.Location = New System.Drawing.Point(729, 150)
        Me.txb_description.Name = "txb_description"
        Me.txb_description.Size = New System.Drawing.Size(321, 29)
        Me.txb_description.TabIndex = 20
        '
        'lbl_drawingno
        '
        Me.lbl_drawingno.AutoSize = True
        Me.lbl_drawingno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_drawingno.Location = New System.Drawing.Point(577, 185)
        Me.lbl_drawingno.Name = "lbl_drawingno"
        Me.lbl_drawingno.Size = New System.Drawing.Size(109, 24)
        Me.lbl_drawingno.TabIndex = 23
        Me.lbl_drawingno.Text = "Drawing No"
        '
        'txb_drawingno
        '
        Me.txb_drawingno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_drawingno.Location = New System.Drawing.Point(729, 185)
        Me.txb_drawingno.Name = "txb_drawingno"
        Me.txb_drawingno.Size = New System.Drawing.Size(321, 29)
        Me.txb_drawingno.TabIndex = 22
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(577, 220)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(78, 24)
        Me.lbl_quantity.TabIndex = 25
        Me.lbl_quantity.Text = "Quantity"
        '
        'txb_quantity
        '
        Me.txb_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_quantity.Location = New System.Drawing.Point(729, 220)
        Me.txb_quantity.Name = "txb_quantity"
        Me.txb_quantity.Size = New System.Drawing.Size(321, 29)
        Me.txb_quantity.TabIndex = 24
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(577, 255)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(53, 24)
        Me.lbl_price.TabIndex = 27
        Me.lbl_price.Text = "Price"
        '
        'txb_price
        '
        Me.txb_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_price.Location = New System.Drawing.Point(729, 255)
        Me.txb_price.Name = "txb_price"
        Me.txb_price.Size = New System.Drawing.Size(321, 29)
        Me.txb_price.TabIndex = 26
        '
        'lbl_subassemblies
        '
        Me.lbl_subassemblies.AutoSize = True
        Me.lbl_subassemblies.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subassemblies.Location = New System.Drawing.Point(577, 430)
        Me.lbl_subassemblies.Name = "lbl_subassemblies"
        Me.lbl_subassemblies.Size = New System.Drawing.Size(146, 24)
        Me.lbl_subassemblies.TabIndex = 37
        Me.lbl_subassemblies.Text = "Sub Assemblies"
        '
        'txb_subassemblies
        '
        Me.txb_subassemblies.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_subassemblies.Location = New System.Drawing.Point(729, 430)
        Me.txb_subassemblies.Name = "txb_subassemblies"
        Me.txb_subassemblies.Size = New System.Drawing.Size(321, 29)
        Me.txb_subassemblies.TabIndex = 36
        '
        'lbl_machinetype
        '
        Me.lbl_machinetype.AutoSize = True
        Me.lbl_machinetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_machinetype.Location = New System.Drawing.Point(577, 395)
        Me.lbl_machinetype.Name = "lbl_machinetype"
        Me.lbl_machinetype.Size = New System.Drawing.Size(131, 24)
        Me.lbl_machinetype.TabIndex = 35
        Me.lbl_machinetype.Text = "Machine Type"
        '
        'lbl_labor
        '
        Me.lbl_labor.AutoSize = True
        Me.lbl_labor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_labor.Location = New System.Drawing.Point(577, 360)
        Me.lbl_labor.Name = "lbl_labor"
        Me.lbl_labor.Size = New System.Drawing.Size(58, 24)
        Me.lbl_labor.TabIndex = 33
        Me.lbl_labor.Text = "Labor"
        '
        'txb_labor
        '
        Me.txb_labor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_labor.Location = New System.Drawing.Point(729, 360)
        Me.txb_labor.Name = "txb_labor"
        Me.txb_labor.Size = New System.Drawing.Size(321, 29)
        Me.txb_labor.TabIndex = 32
        '
        'lbl_makebuy
        '
        Me.lbl_makebuy.AutoSize = True
        Me.lbl_makebuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_makebuy.Location = New System.Drawing.Point(577, 325)
        Me.lbl_makebuy.Name = "lbl_makebuy"
        Me.lbl_makebuy.Size = New System.Drawing.Size(93, 24)
        Me.lbl_makebuy.TabIndex = 31
        Me.lbl_makebuy.Text = "Make/Buy"
        '
        'lbl_supplierid
        '
        Me.lbl_supplierid.AutoSize = True
        Me.lbl_supplierid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_supplierid.Location = New System.Drawing.Point(577, 290)
        Me.lbl_supplierid.Name = "lbl_supplierid"
        Me.lbl_supplierid.Size = New System.Drawing.Size(97, 24)
        Me.lbl_supplierid.TabIndex = 29
        Me.lbl_supplierid.Text = "SupplierID"
        '
        'txb_supplierid
        '
        Me.txb_supplierid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_supplierid.Location = New System.Drawing.Point(729, 290)
        Me.txb_supplierid.Name = "txb_supplierid"
        Me.txb_supplierid.Size = New System.Drawing.Size(321, 29)
        Me.txb_supplierid.TabIndex = 28
        '
        'lbx_machinetype
        '
        Me.lbx_machinetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_machinetype.FormattingEnabled = True
        Me.lbx_machinetype.ItemHeight = 24
        Me.lbx_machinetype.Location = New System.Drawing.Point(730, 395)
        Me.lbx_machinetype.Name = "lbx_machinetype"
        Me.lbx_machinetype.Size = New System.Drawing.Size(320, 28)
        Me.lbx_machinetype.TabIndex = 38
        '
        'lbx_makebuy
        '
        Me.lbx_makebuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_makebuy.FormattingEnabled = True
        Me.lbx_makebuy.ItemHeight = 24
        Me.lbx_makebuy.Location = New System.Drawing.Point(729, 324)
        Me.lbx_makebuy.Name = "lbx_makebuy"
        Me.lbx_makebuy.Size = New System.Drawing.Size(320, 28)
        Me.lbx_makebuy.TabIndex = 39
        '
        'MachinesBindingSource
        '
        Me.MachinesBindingSource.DataSource = GetType(MRP_Demo.Machines)
        '
        'EditParts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 730)
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
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbx_partlist)
        Me.Controls.Add(Me.lbl_loginheading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "EditParts"
        Me.Text = "EditParts"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_loginheading As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbx_partlist As ListBox
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents txb_partno As TextBox
    Friend WithEvents lbl_partno As Label
    Friend WithEvents lbl_description As Label
    Friend WithEvents txb_description As TextBox
    Friend WithEvents lbl_drawingno As Label
    Friend WithEvents txb_drawingno As TextBox
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents txb_quantity As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents txb_price As TextBox
    Friend WithEvents lbl_subassemblies As Label
    Friend WithEvents txb_subassemblies As TextBox
    Friend WithEvents lbl_machinetype As Label
    Friend WithEvents lbl_labor As Label
    Friend WithEvents txb_labor As TextBox
    Friend WithEvents lbl_makebuy As Label
    Friend WithEvents lbl_supplierid As Label
    Friend WithEvents txb_supplierid As TextBox
    Friend WithEvents lbx_machinetype As ListBox
    Friend WithEvents MachinesBindingSource As BindingSource
    Friend WithEvents lbx_makebuy As ListBox
End Class
