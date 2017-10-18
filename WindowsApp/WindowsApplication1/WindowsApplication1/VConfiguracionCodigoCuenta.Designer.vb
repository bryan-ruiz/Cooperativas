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
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(57, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Creación de Codigos de Cuentas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(66, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripción de la cuenta"
        '
        'TextBox_ConfiguracionCuentaDescripcion
        '
        Me.TextBox_ConfiguracionCuentaDescripcion.Location = New System.Drawing.Point(70, 170)
        Me.TextBox_ConfiguracionCuentaDescripcion.Multiline = True
        Me.TextBox_ConfiguracionCuentaDescripcion.Name = "TextBox_ConfiguracionCuentaDescripcion"
        Me.TextBox_ConfiguracionCuentaDescripcion.Size = New System.Drawing.Size(275, 29)
        Me.TextBox_ConfiguracionCuentaDescripcion.TabIndex = 5
        '
        'Button_ConfiguracionInsertarCodigoCuenta
        '
        Me.Button_ConfiguracionInsertarCodigoCuenta.Location = New System.Drawing.Point(70, 471)
        Me.Button_ConfiguracionInsertarCodigoCuenta.Name = "Button_ConfiguracionInsertarCodigoCuenta"
        Me.Button_ConfiguracionInsertarCodigoCuenta.Size = New System.Drawing.Size(101, 34)
        Me.Button_ConfiguracionInsertarCodigoCuenta.TabIndex = 21
        Me.Button_ConfiguracionInsertarCodigoCuenta.Text = "Insertar Codigo"
        Me.Button_ConfiguracionInsertarCodigoCuenta.UseVisualStyleBackColor = True
        '
        'Button_ConfiguracionEliminarCodigoCuenta
        '
        Me.Button_ConfiguracionEliminarCodigoCuenta.Location = New System.Drawing.Point(234, 471)
        Me.Button_ConfiguracionEliminarCodigoCuenta.Name = "Button_ConfiguracionEliminarCodigoCuenta"
        Me.Button_ConfiguracionEliminarCodigoCuenta.Size = New System.Drawing.Size(102, 34)
        Me.Button_ConfiguracionEliminarCodigoCuenta.TabIndex = 22
        Me.Button_ConfiguracionEliminarCodigoCuenta.Text = "Borrar Codigo"
        Me.Button_ConfiguracionEliminarCodigoCuenta.UseVisualStyleBackColor = True
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label138.ForeColor = System.Drawing.Color.White
        Me.Label138.Location = New System.Drawing.Point(71, 328)
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
        Me.Panel3.Location = New System.Drawing.Point(70, 365)
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
        Me.Label139.Location = New System.Drawing.Point(66, 232)
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
        Me.Panel4.Location = New System.Drawing.Point(70, 270)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(178, 34)
        Me.Panel4.TabIndex = 160
        '
        'ConfiguracionRadioButtonIngresos
        '
        Me.ConfiguracionRadioButtonIngresos.AutoSize = True
        Me.ConfiguracionRadioButtonIngresos.Checked = True
        Me.ConfiguracionRadioButtonIngresos.Location = New System.Drawing.Point(12, 3)
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
        'VConfiguracionCodigoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(419, 581)
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
        Me.Text = "Crear Codigos de Cuentas"
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
End Class
