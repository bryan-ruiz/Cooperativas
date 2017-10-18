<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VGastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VGastos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_GastosCodCuenta = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_GastosDescripcion = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosCantidad = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosTotal = New System.Windows.Forms.TextBox()
        Me.Button_GastosCalcular = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_GastosFacturaRecibo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker_GastosFecha = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_GastosProveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button_GastosAgregar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeEcónomicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox_GastosCodCuenta)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox_GastosDescripcion)
        Me.GroupBox2.Controls.Add(Me.TextBox_GastosCantidad)
        Me.GroupBox2.Controls.Add(Me.TextBox_GastosPrecioUnitario)
        Me.GroupBox2.Controls.Add(Me.TextBox_GastosTotal)
        Me.GroupBox2.Controls.Add(Me.Button_GastosCalcular)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1227, 116)
        Me.GroupBox2.TabIndex = 145
        Me.GroupBox2.TabStop = False
        '
        'ComboBox_GastosCodCuenta
        '
        Me.ComboBox_GastosCodCuenta.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_GastosCodCuenta.FormattingEnabled = True
        Me.ComboBox_GastosCodCuenta.Location = New System.Drawing.Point(11, 60)
        Me.ComboBox_GastosCodCuenta.Name = "ComboBox_GastosCodCuenta"
        Me.ComboBox_GastosCodCuenta.Size = New System.Drawing.Size(232, 27)
        Me.ComboBox_GastosCodCuenta.TabIndex = 142
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1215, 37)
        Me.GroupBox3.TabIndex = 141
        Me.GroupBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(244, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Codigo de Cuenta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(380, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Descripción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(1052, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(794, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Precio Unitario"
        '
        'TextBox_GastosDescripcion
        '
        Me.TextBox_GastosDescripcion.Location = New System.Drawing.Point(389, 62)
        Me.TextBox_GastosDescripcion.Name = "TextBox_GastosDescripcion"
        Me.TextBox_GastosDescripcion.Size = New System.Drawing.Size(396, 20)
        Me.TextBox_GastosDescripcion.TabIndex = 9
        '
        'TextBox_GastosCantidad
        '
        Me.TextBox_GastosCantidad.Location = New System.Drawing.Point(253, 62)
        Me.TextBox_GastosCantidad.Name = "TextBox_GastosCantidad"
        Me.TextBox_GastosCantidad.Size = New System.Drawing.Size(116, 20)
        Me.TextBox_GastosCantidad.TabIndex = 11
        '
        'TextBox_GastosPrecioUnitario
        '
        Me.TextBox_GastosPrecioUnitario.Location = New System.Drawing.Point(803, 62)
        Me.TextBox_GastosPrecioUnitario.Name = "TextBox_GastosPrecioUnitario"
        Me.TextBox_GastosPrecioUnitario.Size = New System.Drawing.Size(143, 20)
        Me.TextBox_GastosPrecioUnitario.TabIndex = 13
        '
        'TextBox_GastosTotal
        '
        Me.TextBox_GastosTotal.Location = New System.Drawing.Point(1055, 62)
        Me.TextBox_GastosTotal.Name = "TextBox_GastosTotal"
        Me.TextBox_GastosTotal.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_GastosTotal.TabIndex = 16
        '
        'Button_GastosCalcular
        '
        Me.Button_GastosCalcular.Location = New System.Drawing.Point(963, 62)
        Me.Button_GastosCalcular.Name = "Button_GastosCalcular"
        Me.Button_GastosCalcular.Size = New System.Drawing.Size(80, 20)
        Me.Button_GastosCalcular.TabIndex = 15
        Me.Button_GastosCalcular.Text = "Calcular Total"
        Me.Button_GastosCalcular.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox_GastosFacturaRecibo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_GastosFecha)
        Me.GroupBox1.Controls.Add(Me.TextBox_GastosProveedor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1227, 95)
        Me.GroupBox1.TabIndex = 144
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(23, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "N° Factura o N° Recibo"
        '
        'TextBox_GastosFacturaRecibo
        '
        Me.TextBox_GastosFacturaRecibo.Location = New System.Drawing.Point(198, 15)
        Me.TextBox_GastosFacturaRecibo.Name = "TextBox_GastosFacturaRecibo"
        Me.TextBox_GastosFacturaRecibo.Size = New System.Drawing.Size(199, 20)
        Me.TextBox_GastosFacturaRecibo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(23, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha Factura o Recibo"
        '
        'DateTimePicker_GastosFecha
        '
        Me.DateTimePicker_GastosFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_GastosFecha.Location = New System.Drawing.Point(198, 49)
        Me.DateTimePicker_GastosFecha.Name = "DateTimePicker_GastosFecha"
        Me.DateTimePicker_GastosFecha.Size = New System.Drawing.Size(199, 20)
        Me.DateTimePicker_GastosFecha.TabIndex = 5
        '
        'TextBox_GastosProveedor
        '
        Me.TextBox_GastosProveedor.Location = New System.Drawing.Point(472, 19)
        Me.TextBox_GastosProveedor.Multiline = True
        Me.TextBox_GastosProveedor.Name = "TextBox_GastosProveedor"
        Me.TextBox_GastosProveedor.Size = New System.Drawing.Size(411, 50)
        Me.TextBox_GastosProveedor.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(414, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cliente "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(533, 40)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(187, 22)
        Me.Label18.TabIndex = 143
        Me.Label18.Text = "Información de Salidas"
        '
        'Button_GastosAgregar
        '
        Me.Button_GastosAgregar.Location = New System.Drawing.Point(552, 331)
        Me.Button_GastosAgregar.Name = "Button_GastosAgregar"
        Me.Button_GastosAgregar.Size = New System.Drawing.Size(141, 27)
        Me.Button_GastosAgregar.TabIndex = 142
        Me.Button_GastosAgregar.Text = "Agregar Salidas"
        Me.Button_GastosAgregar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.InformaciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1279, 24)
        Me.MenuStrip1.TabIndex = 147
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.SalirToolStripMenuItem.Text = "Principal"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearReporteToolStripMenuItem, Me.InformeEcónomicoToolStripMenuItem})
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'CrearReporteToolStripMenuItem
        '
        Me.CrearReporteToolStripMenuItem.Name = "CrearReporteToolStripMenuItem"
        Me.CrearReporteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CrearReporteToolStripMenuItem.Text = "Crear Reporte"
        '
        'InformeEcónomicoToolStripMenuItem
        '
        Me.InformeEcónomicoToolStripMenuItem.Name = "InformeEcónomicoToolStripMenuItem"
        Me.InformeEcónomicoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.InformeEcónomicoToolStripMenuItem.Text = "Informe Económico"
        '
        'InformaciónToolStripMenuItem
        '
        Me.InformaciónToolStripMenuItem.Name = "InformaciónToolStripMenuItem"
        Me.InformaciónToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.InformaciónToolStripMenuItem.Text = "Información"
        '
        'VGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1279, 591)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button_GastosAgregar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salidas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_GastosDescripcion As TextBox
    Friend WithEvents TextBox_GastosCantidad As TextBox
    Friend WithEvents TextBox_GastosPrecioUnitario As TextBox
    Friend WithEvents TextBox_GastosTotal As TextBox
    Friend WithEvents Button_GastosCalcular As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_GastosFacturaRecibo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker_GastosFecha As DateTimePicker
    Friend WithEvents TextBox_GastosProveedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Button_GastosAgregar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeEcónomicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox_GastosCodCuenta As ComboBox
End Class
