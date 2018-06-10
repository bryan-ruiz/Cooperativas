<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VSignIn
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VSignIn))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBoxlogin = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonLicencia = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.Location = New System.Drawing.Point(-44, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Hasta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(-44, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Desde"
        '
        'ButtonIngresar
        '
        Me.ButtonIngresar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonIngresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIngresar.ForeColor = System.Drawing.Color.White
        Me.ButtonIngresar.Image = Global.WindowsApplication1.My.Resources.Resources.login3
        Me.ButtonIngresar.Location = New System.Drawing.Point(94, 394)
        Me.ButtonIngresar.Name = "ButtonIngresar"
        Me.ButtonIngresar.Size = New System.Drawing.Size(292, 47)
        Me.ButtonIngresar.TabIndex = 133
        Me.ButtonIngresar.Text = "Ingresar"
        Me.ButtonIngresar.UseVisualStyleBackColor = False
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxContraseña.Location = New System.Drawing.Point(94, 340)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.Size = New System.Drawing.Size(292, 22)
        Me.TextBoxContraseña.TabIndex = 132
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(91, 319)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 16)
        Me.Label26.TabIndex = 135
        Me.Label26.Text = "Contraseña: "
        '
        'TextBoxlogin
        '
        Me.TextBoxlogin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxlogin.Location = New System.Drawing.Point(94, 284)
        Me.TextBoxlogin.Name = "TextBoxlogin"
        Me.TextBoxlogin.Size = New System.Drawing.Size(293, 22)
        Me.TextBoxlogin.TabIndex = 131
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(91, 263)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 16)
        Me.Label27.TabIndex = 134
        Me.Label27.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(132, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(496, 39)
        Me.Label3.TabIndex = 148
        Me.Label3.Text = "Sistema  de Administración Cooperativista"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.LogoTransparente
        Me.PictureBox1.Location = New System.Drawing.Point(326, 106)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 147
        Me.PictureBox1.TabStop = False
        '
        'ButtonLicencia
        '
        Me.ButtonLicencia.BackColor = System.Drawing.Color.Transparent
        Me.ButtonLicencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonLicencia.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ButtonLicencia.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonLicencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLicencia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLicencia.ForeColor = System.Drawing.Color.White
        Me.ButtonLicencia.Image = Global.WindowsApplication1.My.Resources.Resources.lock4
        Me.ButtonLicencia.Location = New System.Drawing.Point(3, 538)
        Me.ButtonLicencia.Name = "ButtonLicencia"
        Me.ButtonLicencia.Size = New System.Drawing.Size(42, 37)
        Me.ButtonLicencia.TabIndex = 149
        Me.ButtonLicencia.UseVisualStyleBackColor = False
        '
        'VSignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.login3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(779, 577)
        Me.Controls.Add(Me.ButtonLicencia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TextBoxlogin)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VSignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBoxlogin As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonLicencia As Button
End Class
