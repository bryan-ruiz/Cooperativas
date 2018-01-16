<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VIngresoInformacion
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
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeSaldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeEcónomicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_IngresosCalcular = New System.Windows.Forms.Button()
        Me.IngresosInformacionBotonBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IngresosInformacionInputID = New System.Windows.Forms.TextBox()
        Me.IngresosInformacionBotonModificar = New System.Windows.Forms.Button()
        Me.IngresosInformacionBotonEliminar = New System.Windows.Forms.Button()
        Me.ComboBox_IngresosInformacion = New System.Windows.Forms.ComboBox()
        Me.TextBox_IngresosInformacion_Factura = New System.Windows.Forms.TextBox()
        Me.TextBox_IngresosInformacion_Proveedor = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox_IngresosInformacion_Descripcion = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_IngresosInformacion_fecha = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_IngresosInformacion_Cantidad = New System.Windows.Forms.TextBox()
        Me.TextBox_IngresosInformacion_PrecioUnit = New System.Windows.Forms.TextBox()
        Me.TextBox_IngresosInformacion_Total = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.InformaciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1269, 24)
        Me.MenuStrip1.TabIndex = 148
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem1})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearReporteToolStripMenuItem, Me.ReporteDeSaldosToolStripMenuItem, Me.InformeEcónomicoToolStripMenuItem})
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'CrearReporteToolStripMenuItem
        '
        Me.CrearReporteToolStripMenuItem.Name = "CrearReporteToolStripMenuItem"
        Me.CrearReporteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CrearReporteToolStripMenuItem.Text = "Reporte de Salidas"
        '
        'ReporteDeSaldosToolStripMenuItem
        '
        Me.ReporteDeSaldosToolStripMenuItem.Name = "ReporteDeSaldosToolStripMenuItem"
        Me.ReporteDeSaldosToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ReporteDeSaldosToolStripMenuItem.Text = "Reporte de Saldos"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1268, 73)
        Me.Panel1.TabIndex = 152
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(465, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 29)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Información de Entradas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_IngresosCalcular)
        Me.GroupBox3.Controls.Add(Me.IngresosInformacionBotonBuscar)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.IngresosInformacionInputID)
        Me.GroupBox3.Controls.Add(Me.IngresosInformacionBotonModificar)
        Me.GroupBox3.Controls.Add(Me.IngresosInformacionBotonEliminar)
        Me.GroupBox3.Controls.Add(Me.ComboBox_IngresosInformacion)
        Me.GroupBox3.Controls.Add(Me.TextBox_IngresosInformacion_Factura)
        Me.GroupBox3.Controls.Add(Me.TextBox_IngresosInformacion_Proveedor)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox_IngresosInformacion_Descripcion)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_IngresosInformacion_fecha)
        Me.GroupBox3.Controls.Add(Me.TextBox_IngresosInformacion_Cantidad)
        Me.GroupBox3.Controls.Add(Me.TextBox_IngresosInformacion_PrecioUnit)
        Me.GroupBox3.Controls.Add(Me.TextBox_IngresosInformacion_Total)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1400, 269)
        Me.GroupBox3.TabIndex = 153
        Me.GroupBox3.TabStop = False
        '
        'Button_IngresosCalcular
        '
        Me.Button_IngresosCalcular.Location = New System.Drawing.Point(1072, 142)
        Me.Button_IngresosCalcular.Name = "Button_IngresosCalcular"
        Me.Button_IngresosCalcular.Size = New System.Drawing.Size(80, 23)
        Me.Button_IngresosCalcular.TabIndex = 146
        Me.Button_IngresosCalcular.Text = "Calcular Total"
        Me.Button_IngresosCalcular.UseVisualStyleBackColor = True
        '
        'IngresosInformacionBotonBuscar
        '
        Me.IngresosInformacionBotonBuscar.Location = New System.Drawing.Point(782, 18)
        Me.IngresosInformacionBotonBuscar.Name = "IngresosInformacionBotonBuscar"
        Me.IngresosInformacionBotonBuscar.Size = New System.Drawing.Size(77, 41)
        Me.IngresosInformacionBotonBuscar.TabIndex = 145
        Me.IngresosInformacionBotonBuscar.Text = "Buscar"
        Me.IngresosInformacionBotonBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(360, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Digite el numero de factura"
        '
        'IngresosInformacionInputID
        '
        Me.IngresosInformacionInputID.Location = New System.Drawing.Point(533, 29)
        Me.IngresosInformacionInputID.Multiline = True
        Me.IngresosInformacionInputID.Name = "IngresosInformacionInputID"
        Me.IngresosInformacionInputID.Size = New System.Drawing.Size(222, 20)
        Me.IngresosInformacionInputID.TabIndex = 144
        '
        'IngresosInformacionBotonModificar
        '
        Me.IngresosInformacionBotonModificar.Location = New System.Drawing.Point(564, 212)
        Me.IngresosInformacionBotonModificar.Name = "IngresosInformacionBotonModificar"
        Me.IngresosInformacionBotonModificar.Size = New System.Drawing.Size(155, 41)
        Me.IngresosInformacionBotonModificar.TabIndex = 143
        Me.IngresosInformacionBotonModificar.Text = "Modificar"
        Me.IngresosInformacionBotonModificar.UseVisualStyleBackColor = True
        '
        'IngresosInformacionBotonEliminar
        '
        Me.IngresosInformacionBotonEliminar.Location = New System.Drawing.Point(380, 212)
        Me.IngresosInformacionBotonEliminar.Name = "IngresosInformacionBotonEliminar"
        Me.IngresosInformacionBotonEliminar.Size = New System.Drawing.Size(155, 41)
        Me.IngresosInformacionBotonEliminar.TabIndex = 142
        Me.IngresosInformacionBotonEliminar.Text = "Eliminar"
        Me.IngresosInformacionBotonEliminar.UseVisualStyleBackColor = True
        '
        'ComboBox_IngresosInformacion
        '
        Me.ComboBox_IngresosInformacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_IngresosInformacion.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_IngresosInformacion.FormattingEnabled = True
        Me.ComboBox_IngresosInformacion.Location = New System.Drawing.Point(460, 142)
        Me.ComboBox_IngresosInformacion.Name = "ComboBox_IngresosInformacion"
        Me.ComboBox_IngresosInformacion.Size = New System.Drawing.Size(181, 27)
        Me.ComboBox_IngresosInformacion.TabIndex = 4
        '
        'TextBox_IngresosInformacion_Factura
        '
        Me.TextBox_IngresosInformacion_Factura.Location = New System.Drawing.Point(114, 146)
        Me.TextBox_IngresosInformacion_Factura.Name = "TextBox_IngresosInformacion_Factura"
        Me.TextBox_IngresosInformacion_Factura.Size = New System.Drawing.Size(112, 20)
        Me.TextBox_IngresosInformacion_Factura.TabIndex = 2
        '
        'TextBox_IngresosInformacion_Proveedor
        '
        Me.TextBox_IngresosInformacion_Proveedor.Location = New System.Drawing.Point(232, 146)
        Me.TextBox_IngresosInformacion_Proveedor.Multiline = True
        Me.TextBox_IngresosInformacion_Proveedor.Name = "TextBox_IngresosInformacion_Proveedor"
        Me.TextBox_IngresosInformacion_Proveedor.Size = New System.Drawing.Size(222, 20)
        Me.TextBox_IngresosInformacion_Proveedor.TabIndex = 3
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
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(6, 97)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1252, 37)
        Me.GroupBox5.TabIndex = 141
        Me.GroupBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
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
        Me.Label5.ForeColor = System.Drawing.Color.Black
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
        Me.Label6.ForeColor = System.Drawing.Color.Black
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
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(895, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
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
        Me.Label17.ForeColor = System.Drawing.Color.Black
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
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(1187, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 16)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Total"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(975, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 16)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Precio Unitario"
        '
        'TextBox_IngresosInformacion_Descripcion
        '
        Me.TextBox_IngresosInformacion_Descripcion.Location = New System.Drawing.Point(647, 146)
        Me.TextBox_IngresosInformacion_Descripcion.Name = "TextBox_IngresosInformacion_Descripcion"
        Me.TextBox_IngresosInformacion_Descripcion.Size = New System.Drawing.Size(250, 20)
        Me.TextBox_IngresosInformacion_Descripcion.TabIndex = 5
        '
        'DateTimePicker_IngresosInformacion_fecha
        '
        Me.DateTimePicker_IngresosInformacion_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_IngresosInformacion_fecha.Location = New System.Drawing.Point(7, 146)
        Me.DateTimePicker_IngresosInformacion_fecha.Name = "DateTimePicker_IngresosInformacion_fecha"
        Me.DateTimePicker_IngresosInformacion_fecha.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker_IngresosInformacion_fecha.TabIndex = 1
        '
        'TextBox_IngresosInformacion_Cantidad
        '
        Me.TextBox_IngresosInformacion_Cantidad.Location = New System.Drawing.Point(903, 145)
        Me.TextBox_IngresosInformacion_Cantidad.Name = "TextBox_IngresosInformacion_Cantidad"
        Me.TextBox_IngresosInformacion_Cantidad.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_IngresosInformacion_Cantidad.TabIndex = 6
        '
        'TextBox_IngresosInformacion_PrecioUnit
        '
        Me.TextBox_IngresosInformacion_PrecioUnit.Location = New System.Drawing.Point(984, 145)
        Me.TextBox_IngresosInformacion_PrecioUnit.Name = "TextBox_IngresosInformacion_PrecioUnit"
        Me.TextBox_IngresosInformacion_PrecioUnit.Size = New System.Drawing.Size(82, 20)
        Me.TextBox_IngresosInformacion_PrecioUnit.TabIndex = 7
        '
        'TextBox_IngresosInformacion_Total
        '
        Me.TextBox_IngresosInformacion_Total.Enabled = False
        Me.TextBox_IngresosInformacion_Total.Location = New System.Drawing.Point(1158, 140)
        Me.TextBox_IngresosInformacion_Total.Name = "TextBox_IngresosInformacion_Total"
        Me.TextBox_IngresosInformacion_Total.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_IngresosInformacion_Total.TabIndex = 9
        '
        'VIngresoInformacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 415)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "VIngresoInformacion"
        Me.Text = "VIngresoInformacion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeSaldosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeEcónomicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button_IngresosCalcular As Button
    Friend WithEvents IngresosInformacionBotonBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents IngresosInformacionInputID As TextBox
    Friend WithEvents IngresosInformacionBotonModificar As Button
    Friend WithEvents IngresosInformacionBotonEliminar As Button
    Friend WithEvents ComboBox_IngresosInformacion As ComboBox
    Friend WithEvents TextBox_IngresosInformacion_Factura As TextBox
    Friend WithEvents TextBox_IngresosInformacion_Proveedor As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox_IngresosInformacion_Descripcion As TextBox
    Friend WithEvents DateTimePicker_IngresosInformacion_fecha As DateTimePicker
    Friend WithEvents TextBox_IngresosInformacion_Cantidad As TextBox
    Friend WithEvents TextBox_IngresosInformacion_PrecioUnit As TextBox
    Friend WithEvents TextBox_IngresosInformacion_Total As TextBox
End Class
