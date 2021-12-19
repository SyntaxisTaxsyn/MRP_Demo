<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBom
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
        Me.btn_return = New System.Windows.Forms.Button()
        Me.lbl_loginheading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbl_totalcost = New System.Windows.Forms.Label()
        Me.lbl_totallabor = New System.Windows.Forms.Label()
        Me.MachinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_exportbom = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_return
        '
        Me.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_return.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(1065, 643)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(228, 54)
        Me.btn_return.TabIndex = 50
        Me.btn_return.Text = "Return"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'lbl_loginheading
        '
        Me.lbl_loginheading.AutoSize = True
        Me.lbl_loginheading.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_loginheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loginheading.Location = New System.Drawing.Point(410, 9)
        Me.lbl_loginheading.Name = "lbl_loginheading"
        Me.lbl_loginheading.Size = New System.Drawing.Size(425, 37)
        Me.lbl_loginheading.TabIndex = 49
        Me.lbl_loginheading.Text = "MRP Dashboard - View Bom"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1307, 56)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1281, 527)
        Me.DataGridView1.TabIndex = 51
        '
        'lbl_totalcost
        '
        Me.lbl_totalcost.AutoSize = True
        Me.lbl_totalcost.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_totalcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalcost.Location = New System.Drawing.Point(12, 70)
        Me.lbl_totalcost.Name = "lbl_totalcost"
        Me.lbl_totalcost.Size = New System.Drawing.Size(125, 25)
        Me.lbl_totalcost.TabIndex = 52
        Me.lbl_totalcost.Text = "Total cost - "
        '
        'lbl_totallabor
        '
        Me.lbl_totallabor.AutoSize = True
        Me.lbl_totallabor.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_totallabor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totallabor.Location = New System.Drawing.Point(273, 70)
        Me.lbl_totallabor.Name = "lbl_totallabor"
        Me.lbl_totallabor.Size = New System.Drawing.Size(145, 25)
        Me.lbl_totallabor.TabIndex = 53
        Me.lbl_totallabor.Text = "Total labour - "
        '
        'MachinesBindingSource
        '
        Me.MachinesBindingSource.DataSource = GetType(MRP_Demo.Machines)
        '
        'btn_exportbom
        '
        Me.btn_exportbom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_exportbom.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exportbom.Location = New System.Drawing.Point(12, 643)
        Me.btn_exportbom.Name = "btn_exportbom"
        Me.btn_exportbom.Size = New System.Drawing.Size(228, 54)
        Me.btn_exportbom.TabIndex = 54
        Me.btn_exportbom.Text = "Export BOM"
        Me.btn_exportbom.UseVisualStyleBackColor = True
        '
        'ViewBom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 730)
        Me.Controls.Add(Me.btn_exportbom)
        Me.Controls.Add(Me.lbl_totallabor)
        Me.Controls.Add(Me.lbl_totalcost)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.lbl_loginheading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ViewBom"
        Me.Text = "ViewBom"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_return As Button
    Friend WithEvents lbl_loginheading As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MachinesBindingSource As BindingSource
    Friend WithEvents lbl_totalcost As Label
    Friend WithEvents lbl_totallabor As Label
    Friend WithEvents btn_exportbom As Button
End Class
