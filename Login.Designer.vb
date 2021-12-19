<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txb_username = New System.Windows.Forms.TextBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_loginheading = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txb_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txb_username
        '
        Me.txb_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_username.Location = New System.Drawing.Point(228, 90)
        Me.txb_username.Name = "txb_username"
        Me.txb_username.Size = New System.Drawing.Size(254, 44)
        Me.txb_username.TabIndex = 0
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(58, 93)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(164, 37)
        Me.lbl_username.TabIndex = 1
        Me.lbl_username.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(798, 56)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_loginheading
        '
        Me.lbl_loginheading.AutoSize = True
        Me.lbl_loginheading.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_loginheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loginheading.Location = New System.Drawing.Point(208, 9)
        Me.lbl_loginheading.Name = "lbl_loginheading"
        Me.lbl_loginheading.Size = New System.Drawing.Size(360, 37)
        Me.lbl_loginheading.TabIndex = 3
        Me.lbl_loginheading.Text = "MRP Dashboard - Login"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(58, 143)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(158, 37)
        Me.lbl_password.TabIndex = 5
        Me.lbl_password.Text = "Password"
        '
        'txb_password
        '
        Me.txb_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_password.Location = New System.Drawing.Point(228, 140)
        Me.txb_password.Name = "txb_password"
        Me.txb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txb_password.Size = New System.Drawing.Size(254, 44)
        Me.txb_password.TabIndex = 4
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(228, 199)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(254, 54)
        Me.btn_login.TabIndex = 6
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.txb_password)
        Me.Controls.Add(Me.lbl_loginheading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.txb_username)
        Me.Name = "Login"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txb_username As TextBox
    Friend WithEvents lbl_username As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_loginheading As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txb_password As TextBox
    Friend WithEvents btn_login As Button
End Class
