<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VIngresos
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeEconómicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox_IngresosFacturaRecibos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker_IngresosFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_IngresosCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_IngresosDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_IngresosCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_IngresosPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Button_IngresosCalcularTotal = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_IngresosTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button_IngresosInsertar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_IngresosCodigCuenta = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ComprobanteToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.InformaciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1279, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'ComprobanteToolStripMenuItem
        '
        Me.ComprobanteToolStripMenuItem.Enabled = False
        Me.ComprobanteToolStripMenuItem.Name = "ComprobanteToolStripMenuItem"
        Me.ComprobanteToolStripMenuItem.ShowShortcutKeys = False
        Me.ComprobanteToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ComprobanteToolStripMenuItem.Text = "Comprobante"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearReporteToolStripMenuItem, Me.InformeEconómicoToolStripMenuItem})
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'CrearReporteToolStripMenuItem
        '
        Me.CrearReporteToolStripMenuItem.Name = "CrearReporteToolStripMenuItem"
        Me.CrearReporteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CrearReporteToolStripMenuItem.Text = "Reporte detallado"
        '
        'InformeEconómicoToolStripMenuItem
        '
        Me.InformeEconómicoToolStripMenuItem.Name = "InformeEconómicoToolStripMenuItem"
        Me.InformeEconómicoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.InformeEconómicoToolStripMenuItem.Text = "Informe Económico"
        '
        'InformaciónToolStripMenuItem
        '
        Me.InformaciónToolStripMenuItem.Name = "InformaciónToolStripMenuItem"
        Me.InformaciónToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.InformaciónToolStripMenuItem.Text = "Información"
        '
        'TextBox_IngresosFacturaRecibos
        '
        Me.TextBox_IngresosFacturaRecibos.Location = New System.Drawing.Point(198, 15)
        Me.TextBox_IngresosFacturaRecibos.Name = "TextBox_IngresosFacturaRecibos"
        Me.TextBox_IngresosFacturaRecibos.Size = New System.Drawing.Size(199, 20)
        Me.TextBox_IngresosFacturaRecibos.TabIndex = 3
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
        'DateTimePicker_IngresosFecha
        '
        Me.DateTimePicker_IngresosFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_IngresosFecha.Location = New System.Drawing.Point(198, 49)
        Me.DateTimePicker_IngresosFecha.Name = "DateTimePicker_IngresosFecha"
        Me.DateTimePicker_IngresosFecha.Size = New System.Drawing.Size(199, 20)
        Me.DateTimePicker_IngresosFecha.TabIndex = 5
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
        'TextBox_IngresosCliente
        '
        Me.TextBox_IngresosCliente.Location = New System.Drawing.Point(472, 19)
        Me.TextBox_IngresosCliente.Multiline = True
        Me.TextBox_IngresosCliente.Name = "TextBox_IngresosCliente"
        Me.TextBox_IngresosCliente.Size = New System.Drawing.Size(411, 50)
        Me.TextBox_IngresosCliente.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(534, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Descripción"
        '
        'TextBox_IngresosDescripcion
        '
        Me.TextBox_IngresosDescripcion.Location = New System.Drawing.Point(389, 62)
        Me.TextBox_IngresosDescripcion.Name = "TextBox_IngresosDescripcion"
        Me.TextBox_IngresosDescripcion.Size = New System.Drawing.Size(396, 20)
        Me.TextBox_IngresosDescripcion.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(272, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cantidad"
        '
        'TextBox_IngresosCantidad
        '
        Me.TextBox_IngresosCantidad.Location = New System.Drawing.Point(248, 62)
        Me.TextBox_IngresosCantidad.Name = "TextBox_IngresosCantidad"
        Me.TextBox_IngresosCantidad.Size = New System.Drawing.Size(135, 20)
        Me.TextBox_IngresosCantidad.TabIndex = 11
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
        'TextBox_IngresosPrecioUnitario
        '
        Me.TextBox_IngresosPrecioUnitario.Location = New System.Drawing.Point(803, 62)
        Me.TextBox_IngresosPrecioUnitario.Name = "TextBox_IngresosPrecioUnitario"
        Me.TextBox_IngresosPrecioUnitario.Size = New System.Drawing.Size(143, 20)
        Me.TextBox_IngresosPrecioUnitario.TabIndex = 13
        '
        'Button_IngresosCalcularTotal
        '
        Me.Button_IngresosCalcularTotal.Location = New System.Drawing.Point(963, 62)
        Me.Button_IngresosCalcularTotal.Name = "Button_IngresosCalcularTotal"
        Me.Button_IngresosCalcularTotal.Size = New System.Drawing.Size(80, 20)
        Me.Button_IngresosCalcularTotal.TabIndex = 15
        Me.Button_IngresosCalcularTotal.Text = "Calcular Total"
        Me.Button_IngresosCalcularTotal.UseVisualStyleBackColor = True
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
        'TextBox_IngresosTotal
        '
        Me.TextBox_IngresosTotal.Location = New System.Drawing.Point(1055, 62)
        Me.TextBox_IngresosTotal.Name = "TextBox_IngresosTotal"
        Me.TextBox_IngresosTotal.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_IngresosTotal.TabIndex = 16
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
        'Button_IngresosInsertar
        '
        Me.Button_IngresosInsertar.Location = New System.Drawing.Point(567, 363)
        Me.Button_IngresosInsertar.Name = "Button_IngresosInsertar"
        Me.Button_IngresosInsertar.Size = New System.Drawing.Size(141, 27)
        Me.Button_IngresosInsertar.TabIndex = 20
        Me.Button_IngresosInsertar.Text = "Agregar Entradas"
        Me.Button_IngresosInsertar.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(527, 51)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(201, 22)
        Me.Label18.TabIndex = 138
        Me.Label18.Text = "Información de Entradas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox_IngresosFacturaRecibos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_IngresosFecha)
        Me.GroupBox1.Controls.Add(Me.TextBox_IngresosCliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1227, 95)
        Me.GroupBox1.TabIndex = 139
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox_IngresosCodigCuenta)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox_IngresosDescripcion)
        Me.GroupBox2.Controls.Add(Me.TextBox_IngresosCantidad)
        Me.GroupBox2.Controls.Add(Me.TextBox_IngresosPrecioUnitario)
        Me.GroupBox2.Controls.Add(Me.TextBox_IngresosTotal)
        Me.GroupBox2.Controls.Add(Me.Button_IngresosCalcularTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1227, 118)
        Me.GroupBox2.TabIndex = 140
        Me.GroupBox2.TabStop = False
        '
        'ComboBox_IngresosCodigCuenta
        '
        Me.ComboBox_IngresosCodigCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_IngresosCodigCuenta.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_IngresosCodigCuenta.FormattingEnabled = True
        Me.ComboBox_IngresosCodigCuenta.Location = New System.Drawing.Point(6, 59)
        Me.ComboBox_IngresosCodigCuenta.Name = "ComboBox_IngresosCodigCuenta"
        Me.ComboBox_IngresosCodigCuenta.Size = New System.Drawing.Size(236, 27)
        Me.ComboBox_IngresosCodigCuenta.TabIndex = 142
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
        'VIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1279, 591)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button_IngresosInsertar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "VIngresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entradas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ComprobanteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox_IngresosFacturaRecibos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker_IngresosFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_IngresosCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_IngresosDescripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_IngresosCantidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_IngresosPrecioUnitario As TextBox
    Friend WithEvents Button_IngresosCalcularTotal As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_IngresosTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button_IngresosInsertar As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents InformeEconómicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox_IngresosCodigCuenta As ComboBox
End Class
