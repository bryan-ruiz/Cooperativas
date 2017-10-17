<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VGestionAsociados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxUsuariosUsuario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonUsuariosEliminar = New System.Windows.Forms.Button()
        Me.ButtonUsuariosInsertar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUsuariosContrasena = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButtonUsuariosColaborador = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUsuariosAdmin = New System.Windows.Forms.RadioButton()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxUsuariosUsuario
        '
        Me.TextBoxUsuariosUsuario.Location = New System.Drawing.Point(55, 162)
        Me.TextBoxUsuariosUsuario.Name = "TextBoxUsuariosUsuario"
        Me.TextBoxUsuariosUsuario.Size = New System.Drawing.Size(318, 20)
        Me.TextBoxUsuariosUsuario.TabIndex = 76
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(51, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 19)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Usuario del Sistema"
        '
        'ButtonUsuariosEliminar
        '
        Me.ButtonUsuariosEliminar.Location = New System.Drawing.Point(252, 378)
        Me.ButtonUsuariosEliminar.Name = "ButtonUsuariosEliminar"
        Me.ButtonUsuariosEliminar.Size = New System.Drawing.Size(121, 34)
        Me.ButtonUsuariosEliminar.TabIndex = 72
        Me.ButtonUsuariosEliminar.Text = "Eliminar Colaborador"
        Me.ButtonUsuariosEliminar.UseVisualStyleBackColor = True
        '
        'ButtonUsuariosInsertar
        '
        Me.ButtonUsuariosInsertar.Location = New System.Drawing.Point(55, 378)
        Me.ButtonUsuariosInsertar.Name = "ButtonUsuariosInsertar"
        Me.ButtonUsuariosInsertar.Size = New System.Drawing.Size(122, 34)
        Me.ButtonUsuariosInsertar.TabIndex = 71
        Me.ButtonUsuariosInsertar.Text = "Insertar Colaborador"
        Me.ButtonUsuariosInsertar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(60, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 23)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Información de los Usuarios del Sistema"
        '
        'TextBoxUsuariosContrasena
        '
        Me.TextBoxUsuariosContrasena.Location = New System.Drawing.Point(55, 228)
        Me.TextBoxUsuariosContrasena.Name = "TextBoxUsuariosContrasena"
        Me.TextBoxUsuariosContrasena.Size = New System.Drawing.Size(318, 20)
        Me.TextBoxUsuariosContrasena.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(51, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 19)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Contraseña del Sistema"
        '
        'RadioButtonUsuariosColaborador
        '
        Me.RadioButtonUsuariosColaborador.AutoSize = True
        Me.RadioButtonUsuariosColaborador.Checked = True
        Me.RadioButtonUsuariosColaborador.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.RadioButtonUsuariosColaborador.ForeColor = System.Drawing.Color.White
        Me.RadioButtonUsuariosColaborador.Location = New System.Drawing.Point(139, 298)
        Me.RadioButtonUsuariosColaborador.Name = "RadioButtonUsuariosColaborador"
        Me.RadioButtonUsuariosColaborador.Size = New System.Drawing.Size(104, 23)
        Me.RadioButtonUsuariosColaborador.TabIndex = 88
        Me.RadioButtonUsuariosColaborador.TabStop = True
        Me.RadioButtonUsuariosColaborador.Text = "Colaborador"
        Me.RadioButtonUsuariosColaborador.UseVisualStyleBackColor = True
        '
        'RadioButtonUsuariosAdmin
        '
        Me.RadioButtonUsuariosAdmin.AutoSize = True
        Me.RadioButtonUsuariosAdmin.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.RadioButtonUsuariosAdmin.ForeColor = System.Drawing.Color.White
        Me.RadioButtonUsuariosAdmin.Location = New System.Drawing.Point(60, 298)
        Me.RadioButtonUsuariosAdmin.Name = "RadioButtonUsuariosAdmin"
        Me.RadioButtonUsuariosAdmin.Size = New System.Drawing.Size(66, 23)
        Me.RadioButtonUsuariosAdmin.TabIndex = 87
        Me.RadioButtonUsuariosAdmin.Text = "Admin"
        Me.RadioButtonUsuariosAdmin.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(56, 273)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(33, 19)
        Me.Label31.TabIndex = 86
        Me.Label31.Text = "Rol:"
        '
        'VGestionAsociados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(419, 485)
        Me.Controls.Add(Me.RadioButtonUsuariosColaborador)
        Me.Controls.Add(Me.RadioButtonUsuariosAdmin)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.TextBoxUsuariosContrasena)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxUsuariosUsuario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonUsuariosEliminar)
        Me.Controls.Add(Me.ButtonUsuariosInsertar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VGestionAsociados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios del Sistema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxUsuariosUsuario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonUsuariosEliminar As Button
    Friend WithEvents ButtonUsuariosInsertar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUsuariosContrasena As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButtonUsuariosColaborador As RadioButton
    Friend WithEvents RadioButtonUsuariosAdmin As RadioButton
    Friend WithEvents Label31 As Label
End Class
