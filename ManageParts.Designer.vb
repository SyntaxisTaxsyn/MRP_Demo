<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageParts
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
        Me.btn_viewparts = New System.Windows.Forms.Button()
        Me.lbl_loginheading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_editparts = New System.Windows.Forms.Button()
        Me.btn_addparts = New System.Windows.Forms.Button()
        Me.btn_deleteparts = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.btn_loadpartsDB = New System.Windows.Forms.Button()
        Me.btn_savepartsDB = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_viewparts
        '
        Me.btn_viewparts.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_viewparts.Location = New System.Drawing.Point(23, 130)
        Me.btn_viewparts.Name = "btn_viewparts"
        Me.btn_viewparts.Size = New System.Drawing.Size(288, 54)
        Me.btn_viewparts.TabIndex = 10
        Me.btn_viewparts.Text = "View Parts"
        Me.btn_viewparts.UseVisualStyleBackColor = True
        '
        'lbl_loginheading
        '
        Me.lbl_loginheading.AutoSize = True
        Me.lbl_loginheading.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_loginheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loginheading.Location = New System.Drawing.Point(152, 8)
        Me.lbl_loginheading.Name = "lbl_loginheading"
        Me.lbl_loginheading.Size = New System.Drawing.Size(480, 37)
        Me.lbl_loginheading.TabIndex = 9
        Me.lbl_loginheading.Text = "MRP Dashboard - Manage Parts"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(798, 56)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btn_editparts
        '
        Me.btn_editparts.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editparts.Location = New System.Drawing.Point(23, 70)
        Me.btn_editparts.Name = "btn_editparts"
        Me.btn_editparts.Size = New System.Drawing.Size(288, 54)
        Me.btn_editparts.TabIndex = 11
        Me.btn_editparts.Text = "Edit Parts"
        Me.btn_editparts.UseVisualStyleBackColor = True
        '
        'btn_addparts
        '
        Me.btn_addparts.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addparts.Location = New System.Drawing.Point(23, 190)
        Me.btn_addparts.Name = "btn_addparts"
        Me.btn_addparts.Size = New System.Drawing.Size(288, 54)
        Me.btn_addparts.TabIndex = 12
        Me.btn_addparts.Text = "Add Parts"
        Me.btn_addparts.UseVisualStyleBackColor = True
        '
        'btn_deleteparts
        '
        Me.btn_deleteparts.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteparts.Location = New System.Drawing.Point(23, 250)
        Me.btn_deleteparts.Name = "btn_deleteparts"
        Me.btn_deleteparts.Size = New System.Drawing.Size(288, 54)
        Me.btn_deleteparts.TabIndex = 13
        Me.btn_deleteparts.Text = "Delete Parts"
        Me.btn_deleteparts.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(23, 367)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(288, 54)
        Me.btn_return.TabIndex = 14
        Me.btn_return.Text = "Return"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'btn_loadpartsDB
        '
        Me.btn_loadpartsDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_loadpartsDB.Location = New System.Drawing.Point(488, 70)
        Me.btn_loadpartsDB.Name = "btn_loadpartsDB"
        Me.btn_loadpartsDB.Size = New System.Drawing.Size(288, 54)
        Me.btn_loadpartsDB.TabIndex = 15
        Me.btn_loadpartsDB.Text = "Load Parts DB"
        Me.btn_loadpartsDB.UseVisualStyleBackColor = True
        '
        'btn_savepartsDB
        '
        Me.btn_savepartsDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_savepartsDB.Location = New System.Drawing.Point(488, 130)
        Me.btn_savepartsDB.Name = "btn_savepartsDB"
        Me.btn_savepartsDB.Size = New System.Drawing.Size(288, 54)
        Me.btn_savepartsDB.TabIndex = 16
        Me.btn_savepartsDB.Text = "Save Parts DB"
        Me.btn_savepartsDB.UseVisualStyleBackColor = True
        '
        'ManageParts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_savepartsDB)
        Me.Controls.Add(Me.btn_loadpartsDB)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_deleteparts)
        Me.Controls.Add(Me.btn_addparts)
        Me.Controls.Add(Me.btn_editparts)
        Me.Controls.Add(Me.btn_viewparts)
        Me.Controls.Add(Me.lbl_loginheading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ManageParts"
        Me.Text = "ManageParts"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_viewparts As Button
    Friend WithEvents lbl_loginheading As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_editparts As Button
    Friend WithEvents btn_addparts As Button
    Friend WithEvents btn_deleteparts As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents btn_loadpartsDB As Button
    Friend WithEvents btn_savepartsDB As Button
End Class
