<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VConfiguracionCambiarPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VConfiguracionCambiarPassword))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CambiarPasswordTextboxPassword = New System.Windows.Forms.TextBox()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CambiarPasswordRadioButtonAdmin = New System.Windows.Forms.RadioButton()
        Me.CambiarPasswordRadioButtonColaborador = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CambiarPasswordButtonModificar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CambiarPasswordTextboxPasswordConfirmar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(171, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ingrese la contraseña:"
        '
        'CambiarPasswordTextboxPassword
        '
        Me.CambiarPasswordTextboxPassword.CausesValidation = False
        Me.CambiarPasswordTextboxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CambiarPasswordTextboxPassword.Location = New System.Drawing.Point(168, 278)
        Me.CambiarPasswordTextboxPassword.Multiline = True
        Me.CambiarPasswordTextboxPassword.Name = "CambiarPasswordTextboxPassword"
        Me.CambiarPasswordTextboxPassword.Size = New System.Drawing.Size(271, 29)
        Me.CambiarPasswordTextboxPassword.TabIndex = 5
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label139.ForeColor = System.Drawing.Color.Black
        Me.Label139.Location = New System.Drawing.Point(171, 163)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(153, 17)
        Me.Label139.TabIndex = 161
        Me.Label139.Text = "Seleccione el Usuario:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CambiarPasswordRadioButtonAdmin)
        Me.Panel4.Controls.Add(Me.CambiarPasswordRadioButtonColaborador)
        Me.Panel4.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(169, 187)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(271, 34)
        Me.Panel4.TabIndex = 160
        '
        'CambiarPasswordRadioButtonAdmin
        '
        Me.CambiarPasswordRadioButtonAdmin.AutoSize = True
        Me.CambiarPasswordRadioButtonAdmin.Checked = True
        Me.CambiarPasswordRadioButtonAdmin.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CambiarPasswordRadioButtonAdmin.ForeColor = System.Drawing.Color.Black
        Me.CambiarPasswordRadioButtonAdmin.Location = New System.Drawing.Point(12, 5)
        Me.CambiarPasswordRadioButtonAdmin.Name = "CambiarPasswordRadioButtonAdmin"
        Me.CambiarPasswordRadioButtonAdmin.Size = New System.Drawing.Size(67, 21)
        Me.CambiarPasswordRadioButtonAdmin.TabIndex = 141
        Me.CambiarPasswordRadioButtonAdmin.TabStop = True
        Me.CambiarPasswordRadioButtonAdmin.Text = "Admin"
        Me.CambiarPasswordRadioButtonAdmin.UseVisualStyleBackColor = True
        '
        'CambiarPasswordRadioButtonColaborador
        '
        Me.CambiarPasswordRadioButtonColaborador.AutoSize = True
        Me.CambiarPasswordRadioButtonColaborador.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CambiarPasswordRadioButtonColaborador.ForeColor = System.Drawing.Color.Black
        Me.CambiarPasswordRadioButtonColaborador.Location = New System.Drawing.Point(116, 5)
        Me.CambiarPasswordRadioButtonColaborador.Name = "CambiarPasswordRadioButtonColaborador"
        Me.CambiarPasswordRadioButtonColaborador.Size = New System.Drawing.Size(106, 21)
        Me.CambiarPasswordRadioButtonColaborador.TabIndex = 142
        Me.CambiarPasswordRadioButtonColaborador.Text = "Colaborador"
        Me.CambiarPasswordRadioButtonColaborador.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(638, 93)
        Me.Panel1.TabIndex = 168
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(164, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(289, 29)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Gestión de Contraseñas"
        '
        'CambiarPasswordButtonModificar
        '
        Me.CambiarPasswordButtonModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CambiarPasswordButtonModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CambiarPasswordButtonModificar.ForeColor = System.Drawing.Color.White
        Me.CambiarPasswordButtonModificar.Location = New System.Drawing.Point(168, 418)
        Me.CambiarPasswordButtonModificar.Name = "CambiarPasswordButtonModificar"
        Me.CambiarPasswordButtonModificar.Size = New System.Drawing.Size(271, 44)
        Me.CambiarPasswordButtonModificar.TabIndex = 169
        Me.CambiarPasswordButtonModificar.Text = "Modificar"
        Me.CambiarPasswordButtonModificar.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(630, 24)
        Me.MenuStrip1.TabIndex = 171
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CambiarPasswordTextboxPasswordConfirmar
        '
        Me.CambiarPasswordTextboxPasswordConfirmar.CausesValidation = False
        Me.CambiarPasswordTextboxPasswordConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CambiarPasswordTextboxPasswordConfirmar.Location = New System.Drawing.Point(168, 354)
        Me.CambiarPasswordTextboxPasswordConfirmar.Multiline = True
        Me.CambiarPasswordTextboxPasswordConfirmar.Name = "CambiarPasswordTextboxPasswordConfirmar"
        Me.CambiarPasswordTextboxPasswordConfirmar.Size = New System.Drawing.Size(271, 29)
        Me.CambiarPasswordTextboxPasswordConfirmar.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(171, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 17)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "Confirme la contraseña:"
        '
        'VConfiguracionCambiarPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(630, 548)
        Me.Controls.Add(Me.CambiarPasswordTextboxPasswordConfirmar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.CambiarPasswordButtonModificar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label139)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.CambiarPasswordTextboxPassword)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VConfiguracionCambiarPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents CambiarPasswordTextboxPassword As TextBox
    Friend WithEvents Label139 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CambiarPasswordRadioButtonAdmin As RadioButton
    Friend WithEvents CambiarPasswordRadioButtonColaborador As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents CambiarPasswordButtonModificar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CambiarPasswordTextboxPasswordConfirmar As TextBox
    Friend WithEvents Label1 As Label
End Class
