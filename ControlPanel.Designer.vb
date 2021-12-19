<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_loginheading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_manageparts = New System.Windows.Forms.Button()
        Me.btn_managemachines = New System.Windows.Forms.Button()
        Me.lbl_loggedinuser = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_loginheading
        '
        Me.lbl_loginheading.AutoSize = True
        Me.lbl_loginheading.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_loginheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loginheading.Location = New System.Drawing.Point(151, 9)
        Me.lbl_loginheading.Name = "lbl_loginheading"
        Me.lbl_loginheading.Size = New System.Drawing.Size(475, 37)
        Me.lbl_loginheading.TabIndex = 5
        Me.lbl_loginheading.Text = "MRP Dashboard - Control Panel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(798, 56)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btn_manageparts
        '
        Me.btn_manageparts.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageparts.Location = New System.Drawing.Point(12, 93)
        Me.btn_manageparts.Name = "btn_manageparts"
        Me.btn_manageparts.Size = New System.Drawing.Size(288, 54)
        Me.btn_manageparts.TabIndex = 7
        Me.btn_manageparts.Text = "Manage Parts"
        Me.btn_manageparts.UseVisualStyleBackColor = True
        '
        'btn_managemachines
        '
        Me.btn_managemachines.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_managemachines.Location = New System.Drawing.Point(12, 153)
        Me.btn_managemachines.Name = "btn_managemachines"
        Me.btn_managemachines.Size = New System.Drawing.Size(288, 54)
        Me.btn_managemachines.TabIndex = 8
        Me.btn_managemachines.Text = "Manage Machines"
        Me.btn_managemachines.UseVisualStyleBackColor = True
        '
        'lbl_loggedinuser
        '
        Me.lbl_loggedinuser.AutoSize = True
        Me.lbl_loggedinuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loggedinuser.Location = New System.Drawing.Point(12, 74)
        Me.lbl_loggedinuser.Name = "lbl_loggedinuser"
        Me.lbl_loggedinuser.Size = New System.Drawing.Size(49, 16)
        Me.lbl_loggedinuser.TabIndex = 9
        Me.lbl_loggedinuser.Text = "Label1"
        '
        'ControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_loggedinuser)
        Me.Controls.Add(Me.btn_managemachines)
        Me.Controls.Add(Me.btn_manageparts)
        Me.Controls.Add(Me.lbl_loginheading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ControlPanel"
        Me.Text = "ControlPanel"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_loginheading As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_manageparts As Button
    Friend WithEvents btn_managemachines As Button
    Friend WithEvents lbl_loggedinuser As Label
End Class
