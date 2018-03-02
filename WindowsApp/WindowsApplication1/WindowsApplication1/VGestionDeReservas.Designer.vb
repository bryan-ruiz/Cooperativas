<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VGestionDeReservas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_reservasGestion = New System.Windows.Forms.ComboBox()
        Me.TextBox_ReservasGestionMonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_ReservasInsertar = New System.Windows.Forms.Button()
        Me.Button_ReservasDisminuir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 93)
        Me.Panel1.TabIndex = 150
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(209, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(249, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Gestión de Reservas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(158, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 171
        Me.Label4.Text = "Reservas"
        '
        'ComboBox_reservasGestion
        '
        Me.ComboBox_reservasGestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_reservasGestion.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_reservasGestion.FormattingEnabled = True
        Me.ComboBox_reservasGestion.Location = New System.Drawing.Point(212, 165)
        Me.ComboBox_reservasGestion.Name = "ComboBox_reservasGestion"
        Me.ComboBox_reservasGestion.Size = New System.Drawing.Size(275, 27)
        Me.ComboBox_reservasGestion.TabIndex = 170
        '
        'TextBox_ReservasGestionMonto
        '
        Me.TextBox_ReservasGestionMonto.CausesValidation = False
        Me.TextBox_ReservasGestionMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ReservasGestionMonto.Location = New System.Drawing.Point(212, 262)
        Me.TextBox_ReservasGestionMonto.Multiline = True
        Me.TextBox_ReservasGestionMonto.Name = "TextBox_ReservasGestionMonto"
        Me.TextBox_ReservasGestionMonto.Size = New System.Drawing.Size(275, 29)
        Me.TextBox_ReservasGestionMonto.TabIndex = 169
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(158, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "Monto"
        '
        'Button_ReservasInsertar
        '
        Me.Button_ReservasInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button_ReservasInsertar.ForeColor = System.Drawing.Color.White
        Me.Button_ReservasInsertar.Location = New System.Drawing.Point(132, 371)
        Me.Button_ReservasInsertar.Name = "Button_ReservasInsertar"
        Me.Button_ReservasInsertar.Size = New System.Drawing.Size(144, 44)
        Me.Button_ReservasInsertar.TabIndex = 172
        Me.Button_ReservasInsertar.Text = "Insertar"
        Me.Button_ReservasInsertar.UseVisualStyleBackColor = True
        '
        'Button_ReservasDisminuir
        '
        Me.Button_ReservasDisminuir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button_ReservasDisminuir.ForeColor = System.Drawing.Color.White
        Me.Button_ReservasDisminuir.Location = New System.Drawing.Point(382, 371)
        Me.Button_ReservasDisminuir.Name = "Button_ReservasDisminuir"
        Me.Button_ReservasDisminuir.Size = New System.Drawing.Size(144, 44)
        Me.Button_ReservasDisminuir.TabIndex = 173
        Me.Button_ReservasDisminuir.Text = "Disminuir"
        Me.Button_ReservasDisminuir.UseVisualStyleBackColor = True
        '
        'VGestionDeReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 457)
        Me.Controls.Add(Me.Button_ReservasDisminuir)
        Me.Controls.Add(Me.Button_ReservasInsertar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox_reservasGestion)
        Me.Controls.Add(Me.TextBox_ReservasGestionMonto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "VGestionDeReservas"
        Me.Text = "VGestionDeReservas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_reservasGestion As ComboBox
    Friend WithEvents TextBox_ReservasGestionMonto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_ReservasInsertar As Button
    Friend WithEvents Button_ReservasDisminuir As Button
End Class
