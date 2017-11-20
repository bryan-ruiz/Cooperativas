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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VGestionAsociados))
        Me.TextBoxUsuariosUsuario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonUsuariosEliminar = New System.Windows.Forms.Button()
        Me.ButtonUsuariosInsertar = New System.Windows.Forms.Button()
        Me.TextBoxUsuariosContrasena = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButtonUsuariosColaborador = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUsuariosAdmin = New System.Windows.Forms.RadioButton()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxUsuariosUsuario
        '
        Me.TextBoxUsuariosUsuario.Location = New System.Drawing.Point(173, 165)
        Me.TextBoxUsuariosUsuario.Name = "TextBoxUsuariosUsuario"
        Me.TextBoxUsuariosUsuario.Size = New System.Drawing.Size(318, 20)
        Me.TextBoxUsuariosUsuario.TabIndex = 76
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(172, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 19)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Nombre de Usuario"
        '
        'ButtonUsuariosEliminar
        '
        Me.ButtonUsuariosEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUsuariosEliminar.ForeColor = System.Drawing.Color.White
        Me.ButtonUsuariosEliminar.Location = New System.Drawing.Point(346, 370)
        Me.ButtonUsuariosEliminar.Name = "ButtonUsuariosEliminar"
        Me.ButtonUsuariosEliminar.Size = New System.Drawing.Size(144, 44)
        Me.ButtonUsuariosEliminar.TabIndex = 72
        Me.ButtonUsuariosEliminar.Text = "Eliminar"
        Me.ButtonUsuariosEliminar.UseVisualStyleBackColor = True
        '
        'ButtonUsuariosInsertar
        '
        Me.ButtonUsuariosInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUsuariosInsertar.ForeColor = System.Drawing.Color.White
        Me.ButtonUsuariosInsertar.Location = New System.Drawing.Point(173, 370)
        Me.ButtonUsuariosInsertar.Name = "ButtonUsuariosInsertar"
        Me.ButtonUsuariosInsertar.Size = New System.Drawing.Size(144, 44)
        Me.ButtonUsuariosInsertar.TabIndex = 71
        Me.ButtonUsuariosInsertar.Text = "Insertar"
        Me.ButtonUsuariosInsertar.UseVisualStyleBackColor = True
        '
        'TextBoxUsuariosContrasena
        '
        Me.TextBoxUsuariosContrasena.Location = New System.Drawing.Point(173, 231)
        Me.TextBoxUsuariosContrasena.Name = "TextBoxUsuariosContrasena"
        Me.TextBoxUsuariosContrasena.Size = New System.Drawing.Size(318, 20)
        Me.TextBoxUsuariosContrasena.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(173, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Contraseña"
        '
        'RadioButtonUsuariosColaborador
        '
        Me.RadioButtonUsuariosColaborador.AutoSize = True
        Me.RadioButtonUsuariosColaborador.Checked = True
        Me.RadioButtonUsuariosColaborador.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.RadioButtonUsuariosColaborador.ForeColor = System.Drawing.Color.Black
        Me.RadioButtonUsuariosColaborador.Location = New System.Drawing.Point(257, 300)
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
        Me.RadioButtonUsuariosAdmin.ForeColor = System.Drawing.Color.Black
        Me.RadioButtonUsuariosAdmin.Location = New System.Drawing.Point(178, 300)
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
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(174, 276)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(33, 19)
        Me.Label31.TabIndex = 86
        Me.Label31.Text = "Rol:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 93)
        Me.Panel1.TabIndex = 89
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(197, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(247, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Gestión de Usuarios"
        '
        'VGestionAsociados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(665, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadioButtonUsuariosColaborador)
        Me.Controls.Add(Me.RadioButtonUsuariosAdmin)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.TextBoxUsuariosContrasena)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxUsuariosUsuario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonUsuariosEliminar)
        Me.Controls.Add(Me.ButtonUsuariosInsertar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VGestionAsociados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxUsuariosUsuario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonUsuariosEliminar As Button
    Friend WithEvents ButtonUsuariosInsertar As Button
    Friend WithEvents TextBoxUsuariosContrasena As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButtonUsuariosColaborador As RadioButton
    Friend WithEvents RadioButtonUsuariosAdmin As RadioButton
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
End Class
