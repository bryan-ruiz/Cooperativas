<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VConfiguracionCodigoCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VConfiguracionCodigoCuenta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_ConfiguracionCuentaDescripcion = New System.Windows.Forms.TextBox()
        Me.Button_ConfiguracionInsertarCodigoCuenta = New System.Windows.Forms.Button()
        Me.Button_ConfiguracionEliminarCodigoCuenta = New System.Windows.Forms.Button()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton_ConfiguracionProyectoProductivoSI = New System.Windows.Forms.RadioButton()
        Me.RadioButton_ConfiguracionProyectoProductivoNO = New System.Windows.Forms.RadioButton()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ConfiguracionRadioButtonIngresos = New System.Windows.Forms.RadioButton()
        Me.ConfigurationRadioButtonGasto = New System.Windows.Forms.RadioButton()
        Me.ComboBox_CreacionCodCtaEntrada = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_CreacionCodCtaSalida = New System.Windows.Forms.ComboBox()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(130, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gestión de Codigos de Cuentas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(113, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripción de la cuenta a Crear o Eliminar"
        '
        'TextBox_ConfiguracionCuentaDescripcion
        '
        Me.TextBox_ConfiguracionCuentaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ConfiguracionCuentaDescripcion.Location = New System.Drawing.Point(118, 322)
        Me.TextBox_ConfiguracionCuentaDescripcion.Multiline = True
        Me.TextBox_ConfiguracionCuentaDescripcion.Name = "TextBox_ConfiguracionCuentaDescripcion"
        Me.TextBox_ConfiguracionCuentaDescripcion.Size = New System.Drawing.Size(275, 29)
        Me.TextBox_ConfiguracionCuentaDescripcion.TabIndex = 5
        '
        'Button_ConfiguracionInsertarCodigoCuenta
        '
        Me.Button_ConfiguracionInsertarCodigoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ConfiguracionInsertarCodigoCuenta.Location = New System.Drawing.Point(117, 543)
        Me.Button_ConfiguracionInsertarCodigoCuenta.Name = "Button_ConfiguracionInsertarCodigoCuenta"
        Me.Button_ConfiguracionInsertarCodigoCuenta.Size = New System.Drawing.Size(122, 36)
        Me.Button_ConfiguracionInsertarCodigoCuenta.TabIndex = 21
        Me.Button_ConfiguracionInsertarCodigoCuenta.Text = "Crear Cuenta"
        Me.Button_ConfiguracionInsertarCodigoCuenta.UseVisualStyleBackColor = True
        '
        'Button_ConfiguracionEliminarCodigoCuenta
        '
        Me.Button_ConfiguracionEliminarCodigoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ConfiguracionEliminarCodigoCuenta.Location = New System.Drawing.Point(276, 543)
        Me.Button_ConfiguracionEliminarCodigoCuenta.Name = "Button_ConfiguracionEliminarCodigoCuenta"
        Me.Button_ConfiguracionEliminarCodigoCuenta.Size = New System.Drawing.Size(123, 36)
        Me.Button_ConfiguracionEliminarCodigoCuenta.TabIndex = 22
        Me.Button_ConfiguracionEliminarCodigoCuenta.Text = "Eliminar Cuenta"
        Me.Button_ConfiguracionEliminarCodigoCuenta.UseVisualStyleBackColor = True
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label138.ForeColor = System.Drawing.Color.White
        Me.Label138.Location = New System.Drawing.Point(116, 431)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(142, 19)
        Me.Label138.TabIndex = 163
        Me.Label138.Text = "Proyecto Productivo:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RadioButton_ConfiguracionProyectoProductivoSI)
        Me.Panel3.Controls.Add(Me.RadioButton_ConfiguracionProyectoProductivoNO)
        Me.Panel3.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(120, 453)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(178, 34)
        Me.Panel3.TabIndex = 162
        '
        'RadioButton_ConfiguracionProyectoProductivoSI
        '
        Me.RadioButton_ConfiguracionProyectoProductivoSI.AutoSize = True
        Me.RadioButton_ConfiguracionProyectoProductivoSI.Checked = True
        Me.RadioButton_ConfiguracionProyectoProductivoSI.Location = New System.Drawing.Point(14, 5)
        Me.RadioButton_ConfiguracionProyectoProductivoSI.Name = "RadioButton_ConfiguracionProyectoProductivoSI"
        Me.RadioButton_ConfiguracionProyectoProductivoSI.Size = New System.Drawing.Size(41, 23)
        Me.RadioButton_ConfiguracionProyectoProductivoSI.TabIndex = 141
        Me.RadioButton_ConfiguracionProyectoProductivoSI.TabStop = True
        Me.RadioButton_ConfiguracionProyectoProductivoSI.Text = "Si"
        Me.RadioButton_ConfiguracionProyectoProductivoSI.UseVisualStyleBackColor = True
        '
        'RadioButton_ConfiguracionProyectoProductivoNO
        '
        Me.RadioButton_ConfiguracionProyectoProductivoNO.AutoSize = True
        Me.RadioButton_ConfiguracionProyectoProductivoNO.Location = New System.Drawing.Point(96, 5)
        Me.RadioButton_ConfiguracionProyectoProductivoNO.Name = "RadioButton_ConfiguracionProyectoProductivoNO"
        Me.RadioButton_ConfiguracionProyectoProductivoNO.Size = New System.Drawing.Size(45, 23)
        Me.RadioButton_ConfiguracionProyectoProductivoNO.TabIndex = 142
        Me.RadioButton_ConfiguracionProyectoProductivoNO.Text = "No"
        Me.RadioButton_ConfiguracionProyectoProductivoNO.UseVisualStyleBackColor = True
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label139.ForeColor = System.Drawing.Color.White
        Me.Label139.Location = New System.Drawing.Point(115, 363)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(41, 19)
        Me.Label139.TabIndex = 161
        Me.Label139.Text = "Tipo:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ConfiguracionRadioButtonIngresos)
        Me.Panel4.Controls.Add(Me.ConfigurationRadioButtonGasto)
        Me.Panel4.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(119, 385)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(178, 34)
        Me.Panel4.TabIndex = 160
        '
        'ConfiguracionRadioButtonIngresos
        '
        Me.ConfiguracionRadioButtonIngresos.AutoSize = True
        Me.ConfiguracionRadioButtonIngresos.Checked = True
        Me.ConfiguracionRadioButtonIngresos.Location = New System.Drawing.Point(12, 5)
        Me.ConfiguracionRadioButtonIngresos.Name = "ConfiguracionRadioButtonIngresos"
        Me.ConfiguracionRadioButtonIngresos.Size = New System.Drawing.Size(78, 23)
        Me.ConfiguracionRadioButtonIngresos.TabIndex = 141
        Me.ConfiguracionRadioButtonIngresos.TabStop = True
        Me.ConfiguracionRadioButtonIngresos.Text = "Ingreso"
        Me.ConfiguracionRadioButtonIngresos.UseVisualStyleBackColor = True
        '
        'ConfigurationRadioButtonGasto
        '
        Me.ConfigurationRadioButtonGasto.AutoSize = True
        Me.ConfigurationRadioButtonGasto.Location = New System.Drawing.Point(96, 5)
        Me.ConfigurationRadioButtonGasto.Name = "ConfigurationRadioButtonGasto"
        Me.ConfigurationRadioButtonGasto.Size = New System.Drawing.Size(65, 23)
        Me.ConfigurationRadioButtonGasto.TabIndex = 142
        Me.ConfigurationRadioButtonGasto.Text = "Gasto"
        Me.ConfigurationRadioButtonGasto.UseVisualStyleBackColor = True
        '
        'ComboBox_CreacionCodCtaEntrada
        '
        Me.ComboBox_CreacionCodCtaEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_CreacionCodCtaEntrada.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_CreacionCodCtaEntrada.FormattingEnabled = True
        Me.ComboBox_CreacionCodCtaEntrada.Location = New System.Drawing.Point(118, 143)
        Me.ComboBox_CreacionCodCtaEntrada.Name = "ComboBox_CreacionCodCtaEntrada"
        Me.ComboBox_CreacionCodCtaEntrada.Size = New System.Drawing.Size(275, 27)
        Me.ComboBox_CreacionCodCtaEntrada.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(115, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 19)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Entradas existentes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(115, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 19)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "Salidas existentes"
        '
        'ComboBox_CreacionCodCtaSalida
        '
        Me.ComboBox_CreacionCodCtaSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_CreacionCodCtaSalida.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_CreacionCodCtaSalida.FormattingEnabled = True
        Me.ComboBox_CreacionCodCtaSalida.Location = New System.Drawing.Point(119, 212)
        Me.ComboBox_CreacionCodCtaSalida.Name = "ComboBox_CreacionCodCtaSalida"
        Me.ComboBox_CreacionCodCtaSalida.Size = New System.Drawing.Size(275, 27)
        Me.ComboBox_CreacionCodCtaSalida.TabIndex = 166
        '
        'VConfiguracionCodigoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(518, 677)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox_CreacionCodCtaSalida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox_CreacionCodCtaEntrada)
        Me.Controls.Add(Me.Label138)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label139)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button_ConfiguracionEliminarCodigoCuenta)
        Me.Controls.Add(Me.Button_ConfiguracionInsertarCodigoCuenta)
        Me.Controls.Add(Me.TextBox_ConfiguracionCuentaDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VConfiguracionCodigoCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Códigos de Cuentas"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_ConfiguracionCuentaDescripcion As TextBox
    Friend WithEvents Button_ConfiguracionInsertarCodigoCuenta As Button
    Friend WithEvents Button_ConfiguracionEliminarCodigoCuenta As Button
    Friend WithEvents Label138 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RadioButton_ConfiguracionProyectoProductivoSI As RadioButton
    Friend WithEvents RadioButton_ConfiguracionProyectoProductivoNO As RadioButton
    Friend WithEvents Label139 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ConfiguracionRadioButtonIngresos As RadioButton
    Friend WithEvents ConfigurationRadioButtonGasto As RadioButton
    Friend WithEvents ComboBox_CreacionCodCtaEntrada As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_CreacionCodCtaSalida As ComboBox
End Class
