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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeEcónomicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_GastosAgregar3 = New System.Windows.Forms.Button()
        Me.ComboBox_GastosCodCuenta3 = New System.Windows.Forms.ComboBox()
        Me.TextBox_GastosFacturaRecibo3 = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosProveedor3 = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosDescripcion3 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_GastosFecha3 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_GastosCantidad3 = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosPrecioUnitario3 = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosTotal3 = New System.Windows.Forms.TextBox()
        Me.Button_GastosCalcular3 = New System.Windows.Forms.Button()
        Me.Button_GastosAgregar2 = New System.Windows.Forms.Button()
        Me.ComboBox_GastosCodCuenta2 = New System.Windows.Forms.ComboBox()
        Me.TextBox_GastosFacturaRecibo2 = New System.Windows.Forms.TextBox()
        Me.Button_GastosAgregar = New System.Windows.Forms.Button()
        Me.TextBox_GastosProveedor2 = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosDescripcion2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_GastosFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_GastosCantidad2 = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosPrecioUnitario2 = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosTotal2 = New System.Windows.Forms.TextBox()
        Me.Button_GastosCalcular2 = New System.Windows.Forms.Button()
        Me.ComboBox_GastosCodCuenta = New System.Windows.Forms.ComboBox()
        Me.TextBox_GastosFacturaRecibo = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosProveedor = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox_GastosDescripcion = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_GastosFecha = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_GastosCantidad = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosTotal = New System.Windows.Forms.TextBox()
        Me.Button_GastosCalcular = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(615, 63)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(187, 22)
        Me.Label18.TabIndex = 143
        Me.Label18.Text = "Información de Salidas"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.InformaciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1393, 24)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_GastosAgregar3)
        Me.GroupBox3.Controls.Add(Me.ComboBox_GastosCodCuenta3)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosFacturaRecibo3)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosProveedor3)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosDescripcion3)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_GastosFecha3)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosCantidad3)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosPrecioUnitario3)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosTotal3)
        Me.GroupBox3.Controls.Add(Me.Button_GastosCalcular3)
        Me.GroupBox3.Controls.Add(Me.Button_GastosAgregar2)
        Me.GroupBox3.Controls.Add(Me.ComboBox_GastosCodCuenta2)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosFacturaRecibo2)
        Me.GroupBox3.Controls.Add(Me.Button_GastosAgregar)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosProveedor2)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosDescripcion2)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_GastosFecha2)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosCantidad2)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosPrecioUnitario2)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosTotal2)
        Me.GroupBox3.Controls.Add(Me.Button_GastosCalcular2)
        Me.GroupBox3.Controls.Add(Me.ComboBox_GastosCodCuenta)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosFacturaRecibo)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosProveedor)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosDescripcion)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_GastosFecha)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosCantidad)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosPrecioUnitario)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosTotal)
        Me.GroupBox3.Controls.Add(Me.Button_GastosCalcular)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1384, 241)
        Me.GroupBox3.TabIndex = 148
        Me.GroupBox3.TabStop = False
        '
        'Button_GastosAgregar3
        '
        Me.Button_GastosAgregar3.Location = New System.Drawing.Point(1276, 148)
        Me.Button_GastosAgregar3.Name = "Button_GastosAgregar3"
        Me.Button_GastosAgregar3.Size = New System.Drawing.Size(93, 27)
        Me.Button_GastosAgregar3.TabIndex = 30
        Me.Button_GastosAgregar3.Text = "Agregar Salidas"
        Me.Button_GastosAgregar3.UseVisualStyleBackColor = True
        '
        'ComboBox_GastosCodCuenta3
        '
        Me.ComboBox_GastosCodCuenta3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_GastosCodCuenta3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_GastosCodCuenta3.FormattingEnabled = True
        Me.ComboBox_GastosCodCuenta3.Location = New System.Drawing.Point(461, 149)
        Me.ComboBox_GastosCodCuenta3.Name = "ComboBox_GastosCodCuenta3"
        Me.ComboBox_GastosCodCuenta3.Size = New System.Drawing.Size(181, 27)
        Me.ComboBox_GastosCodCuenta3.TabIndex = 24
        '
        'TextBox_GastosFacturaRecibo3
        '
        Me.TextBox_GastosFacturaRecibo3.Location = New System.Drawing.Point(115, 153)
        Me.TextBox_GastosFacturaRecibo3.Name = "TextBox_GastosFacturaRecibo3"
        Me.TextBox_GastosFacturaRecibo3.Size = New System.Drawing.Size(112, 20)
        Me.TextBox_GastosFacturaRecibo3.TabIndex = 22
        '
        'TextBox_GastosProveedor3
        '
        Me.TextBox_GastosProveedor3.Location = New System.Drawing.Point(233, 153)
        Me.TextBox_GastosProveedor3.Multiline = True
        Me.TextBox_GastosProveedor3.Name = "TextBox_GastosProveedor3"
        Me.TextBox_GastosProveedor3.Size = New System.Drawing.Size(222, 20)
        Me.TextBox_GastosProveedor3.TabIndex = 23
        '
        'TextBox_GastosDescripcion3
        '
        Me.TextBox_GastosDescripcion3.Location = New System.Drawing.Point(648, 153)
        Me.TextBox_GastosDescripcion3.Name = "TextBox_GastosDescripcion3"
        Me.TextBox_GastosDescripcion3.Size = New System.Drawing.Size(262, 20)
        Me.TextBox_GastosDescripcion3.TabIndex = 25
        '
        'DateTimePicker_GastosFecha3
        '
        Me.DateTimePicker_GastosFecha3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_GastosFecha3.Location = New System.Drawing.Point(8, 153)
        Me.DateTimePicker_GastosFecha3.Name = "DateTimePicker_GastosFecha3"
        Me.DateTimePicker_GastosFecha3.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker_GastosFecha3.TabIndex = 21
        '
        'TextBox_GastosCantidad3
        '
        Me.TextBox_GastosCantidad3.Location = New System.Drawing.Point(916, 152)
        Me.TextBox_GastosCantidad3.Name = "TextBox_GastosCantidad3"
        Me.TextBox_GastosCantidad3.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_GastosCantidad3.TabIndex = 26
        '
        'TextBox_GastosPrecioUnitario3
        '
        Me.TextBox_GastosPrecioUnitario3.Location = New System.Drawing.Point(997, 152)
        Me.TextBox_GastosPrecioUnitario3.Name = "TextBox_GastosPrecioUnitario3"
        Me.TextBox_GastosPrecioUnitario3.Size = New System.Drawing.Size(82, 20)
        Me.TextBox_GastosPrecioUnitario3.TabIndex = 27
        '
        'TextBox_GastosTotal3
        '
        Me.TextBox_GastosTotal3.Enabled = False
        Me.TextBox_GastosTotal3.Location = New System.Drawing.Point(1171, 153)
        Me.TextBox_GastosTotal3.Name = "TextBox_GastosTotal3"
        Me.TextBox_GastosTotal3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_GastosTotal3.TabIndex = 29
        '
        'Button_GastosCalcular3
        '
        Me.Button_GastosCalcular3.Location = New System.Drawing.Point(1085, 150)
        Me.Button_GastosCalcular3.Name = "Button_GastosCalcular3"
        Me.Button_GastosCalcular3.Size = New System.Drawing.Size(80, 23)
        Me.Button_GastosCalcular3.TabIndex = 28
        Me.Button_GastosCalcular3.Text = "Calcular Total"
        Me.Button_GastosCalcular3.UseVisualStyleBackColor = True
        '
        'Button_GastosAgregar2
        '
        Me.Button_GastosAgregar2.Location = New System.Drawing.Point(1276, 105)
        Me.Button_GastosAgregar2.Name = "Button_GastosAgregar2"
        Me.Button_GastosAgregar2.Size = New System.Drawing.Size(93, 27)
        Me.Button_GastosAgregar2.TabIndex = 20
        Me.Button_GastosAgregar2.Text = "Agregar Salidas"
        Me.Button_GastosAgregar2.UseVisualStyleBackColor = True
        '
        'ComboBox_GastosCodCuenta2
        '
        Me.ComboBox_GastosCodCuenta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_GastosCodCuenta2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_GastosCodCuenta2.FormattingEnabled = True
        Me.ComboBox_GastosCodCuenta2.Location = New System.Drawing.Point(461, 106)
        Me.ComboBox_GastosCodCuenta2.Name = "ComboBox_GastosCodCuenta2"
        Me.ComboBox_GastosCodCuenta2.Size = New System.Drawing.Size(181, 27)
        Me.ComboBox_GastosCodCuenta2.TabIndex = 14
        '
        'TextBox_GastosFacturaRecibo2
        '
        Me.TextBox_GastosFacturaRecibo2.Location = New System.Drawing.Point(115, 110)
        Me.TextBox_GastosFacturaRecibo2.Name = "TextBox_GastosFacturaRecibo2"
        Me.TextBox_GastosFacturaRecibo2.Size = New System.Drawing.Size(112, 20)
        Me.TextBox_GastosFacturaRecibo2.TabIndex = 12
        '
        'Button_GastosAgregar
        '
        Me.Button_GastosAgregar.Location = New System.Drawing.Point(1276, 64)
        Me.Button_GastosAgregar.Name = "Button_GastosAgregar"
        Me.Button_GastosAgregar.Size = New System.Drawing.Size(93, 27)
        Me.Button_GastosAgregar.TabIndex = 10
        Me.Button_GastosAgregar.Text = "Agregar Salidas"
        Me.Button_GastosAgregar.UseVisualStyleBackColor = True
        '
        'TextBox_GastosProveedor2
        '
        Me.TextBox_GastosProveedor2.Location = New System.Drawing.Point(233, 110)
        Me.TextBox_GastosProveedor2.Multiline = True
        Me.TextBox_GastosProveedor2.Name = "TextBox_GastosProveedor2"
        Me.TextBox_GastosProveedor2.Size = New System.Drawing.Size(222, 20)
        Me.TextBox_GastosProveedor2.TabIndex = 13
        '
        'TextBox_GastosDescripcion2
        '
        Me.TextBox_GastosDescripcion2.Location = New System.Drawing.Point(648, 110)
        Me.TextBox_GastosDescripcion2.Name = "TextBox_GastosDescripcion2"
        Me.TextBox_GastosDescripcion2.Size = New System.Drawing.Size(262, 20)
        Me.TextBox_GastosDescripcion2.TabIndex = 15
        '
        'DateTimePicker_GastosFecha2
        '
        Me.DateTimePicker_GastosFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_GastosFecha2.Location = New System.Drawing.Point(8, 110)
        Me.DateTimePicker_GastosFecha2.Name = "DateTimePicker_GastosFecha2"
        Me.DateTimePicker_GastosFecha2.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker_GastosFecha2.TabIndex = 11
        '
        'TextBox_GastosCantidad2
        '
        Me.TextBox_GastosCantidad2.Location = New System.Drawing.Point(916, 109)
        Me.TextBox_GastosCantidad2.Name = "TextBox_GastosCantidad2"
        Me.TextBox_GastosCantidad2.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_GastosCantidad2.TabIndex = 16
        '
        'TextBox_GastosPrecioUnitario2
        '
        Me.TextBox_GastosPrecioUnitario2.Location = New System.Drawing.Point(997, 109)
        Me.TextBox_GastosPrecioUnitario2.Name = "TextBox_GastosPrecioUnitario2"
        Me.TextBox_GastosPrecioUnitario2.Size = New System.Drawing.Size(82, 20)
        Me.TextBox_GastosPrecioUnitario2.TabIndex = 17
        '
        'TextBox_GastosTotal2
        '
        Me.TextBox_GastosTotal2.Enabled = False
        Me.TextBox_GastosTotal2.Location = New System.Drawing.Point(1171, 110)
        Me.TextBox_GastosTotal2.Name = "TextBox_GastosTotal2"
        Me.TextBox_GastosTotal2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_GastosTotal2.TabIndex = 19
        '
        'Button_GastosCalcular2
        '
        Me.Button_GastosCalcular2.Location = New System.Drawing.Point(1085, 107)
        Me.Button_GastosCalcular2.Name = "Button_GastosCalcular2"
        Me.Button_GastosCalcular2.Size = New System.Drawing.Size(80, 23)
        Me.Button_GastosCalcular2.TabIndex = 18
        Me.Button_GastosCalcular2.Text = "Calcular Total"
        Me.Button_GastosCalcular2.UseVisualStyleBackColor = True
        '
        'ComboBox_GastosCodCuenta
        '
        Me.ComboBox_GastosCodCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_GastosCodCuenta.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_GastosCodCuenta.FormattingEnabled = True
        Me.ComboBox_GastosCodCuenta.Location = New System.Drawing.Point(460, 63)
        Me.ComboBox_GastosCodCuenta.Name = "ComboBox_GastosCodCuenta"
        Me.ComboBox_GastosCodCuenta.Size = New System.Drawing.Size(181, 27)
        Me.ComboBox_GastosCodCuenta.TabIndex = 4
        '
        'TextBox_GastosFacturaRecibo
        '
        Me.TextBox_GastosFacturaRecibo.Location = New System.Drawing.Point(114, 67)
        Me.TextBox_GastosFacturaRecibo.Name = "TextBox_GastosFacturaRecibo"
        Me.TextBox_GastosFacturaRecibo.Size = New System.Drawing.Size(112, 20)
        Me.TextBox_GastosFacturaRecibo.TabIndex = 2
        '
        'TextBox_GastosProveedor
        '
        Me.TextBox_GastosProveedor.Location = New System.Drawing.Point(232, 67)
        Me.TextBox_GastosProveedor.Multiline = True
        Me.TextBox_GastosProveedor.Name = "TextBox_GastosProveedor"
        Me.TextBox_GastosProveedor.Size = New System.Drawing.Size(222, 20)
        Me.TextBox_GastosProveedor.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1265, 37)
        Me.GroupBox5.TabIndex = 141
        Me.GroupBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(298, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(103, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "N° Factura o Recibo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(26, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(906, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(488, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Codigo de Cuenta"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(725, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 16)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Descripción"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(1199, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 16)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Total"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(985, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 16)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Precio Unitario"
        '
        'TextBox_GastosDescripcion
        '
        Me.TextBox_GastosDescripcion.Location = New System.Drawing.Point(647, 67)
        Me.TextBox_GastosDescripcion.Name = "TextBox_GastosDescripcion"
        Me.TextBox_GastosDescripcion.Size = New System.Drawing.Size(262, 20)
        Me.TextBox_GastosDescripcion.TabIndex = 5
        '
        'DateTimePicker_GastosFecha
        '
        Me.DateTimePicker_GastosFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_GastosFecha.Location = New System.Drawing.Point(7, 67)
        Me.DateTimePicker_GastosFecha.Name = "DateTimePicker_GastosFecha"
        Me.DateTimePicker_GastosFecha.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker_GastosFecha.TabIndex = 1
        '
        'TextBox_GastosCantidad
        '
        Me.TextBox_GastosCantidad.Location = New System.Drawing.Point(915, 66)
        Me.TextBox_GastosCantidad.Name = "TextBox_GastosCantidad"
        Me.TextBox_GastosCantidad.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_GastosCantidad.TabIndex = 6
        '
        'TextBox_GastosPrecioUnitario
        '
        Me.TextBox_GastosPrecioUnitario.Location = New System.Drawing.Point(996, 66)
        Me.TextBox_GastosPrecioUnitario.Name = "TextBox_GastosPrecioUnitario"
        Me.TextBox_GastosPrecioUnitario.Size = New System.Drawing.Size(82, 20)
        Me.TextBox_GastosPrecioUnitario.TabIndex = 7
        '
        'TextBox_GastosTotal
        '
        Me.TextBox_GastosTotal.Enabled = False
        Me.TextBox_GastosTotal.Location = New System.Drawing.Point(1170, 67)
        Me.TextBox_GastosTotal.Name = "TextBox_GastosTotal"
        Me.TextBox_GastosTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_GastosTotal.TabIndex = 9
        '
        'Button_GastosCalcular
        '
        Me.Button_GastosCalcular.Location = New System.Drawing.Point(1084, 64)
        Me.Button_GastosCalcular.Name = "Button_GastosCalcular"
        Me.Button_GastosCalcular.Size = New System.Drawing.Size(80, 23)
        Me.Button_GastosCalcular.TabIndex = 8
        Me.Button_GastosCalcular.Text = "Calcular Total"
        Me.Button_GastosCalcular.UseVisualStyleBackColor = True
        '
        'VGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1393, 472)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label18)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salidas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label18 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeEcónomicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button_GastosAgregar3 As Button
    Friend WithEvents ComboBox_GastosCodCuenta3 As ComboBox
    Friend WithEvents TextBox_GastosFacturaRecibo3 As TextBox
    Friend WithEvents TextBox_GastosProveedor3 As TextBox
    Friend WithEvents TextBox_GastosDescripcion3 As TextBox
    Friend WithEvents DateTimePicker_GastosFecha3 As DateTimePicker
    Friend WithEvents TextBox_GastosCantidad3 As TextBox
    Friend WithEvents TextBox_GastosPrecioUnitario3 As TextBox
    Friend WithEvents TextBox_GastosTotal3 As TextBox
    Friend WithEvents Button_GastosCalcular3 As Button
    Friend WithEvents Button_GastosAgregar2 As Button
    Friend WithEvents ComboBox_GastosCodCuenta2 As ComboBox
    Friend WithEvents TextBox_GastosFacturaRecibo2 As TextBox
    Friend WithEvents Button_GastosAgregar As Button
    Friend WithEvents TextBox_GastosProveedor2 As TextBox
    Friend WithEvents TextBox_GastosDescripcion2 As TextBox
    Friend WithEvents DateTimePicker_GastosFecha2 As DateTimePicker
    Friend WithEvents TextBox_GastosCantidad2 As TextBox
    Friend WithEvents TextBox_GastosPrecioUnitario2 As TextBox
    Friend WithEvents TextBox_GastosTotal2 As TextBox
    Friend WithEvents Button_GastosCalcular2 As Button
    Friend WithEvents ComboBox_GastosCodCuenta As ComboBox
    Friend WithEvents TextBox_GastosFacturaRecibo As TextBox
    Friend WithEvents TextBox_GastosProveedor As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox_GastosDescripcion As TextBox
    Friend WithEvents DateTimePicker_GastosFecha As DateTimePicker
    Friend WithEvents TextBox_GastosCantidad As TextBox
    Friend WithEvents TextBox_GastosPrecioUnitario As TextBox
    Friend WithEvents TextBox_GastosTotal As TextBox
    Friend WithEvents Button_GastosCalcular As Button
End Class
