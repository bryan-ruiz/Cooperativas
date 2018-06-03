<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VGastosInformacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VGastosInformacion))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_GastoInformacionBotonModificar = New System.Windows.Forms.Button()
        Me.Button_GastoInformacionBotonEliminar = New System.Windows.Forms.Button()
        Me.GastosInformacionBotonBuscar = New System.Windows.Forms.Button()
        Me.Button_GastosCalcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GastosInformacionInputID = New System.Windows.Forms.TextBox()
        Me.ComboBox_GastosInformacion = New System.Windows.Forms.ComboBox()
        Me.TextBox_GastosInformacion_Factura = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosInformacion_Proveedor = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox_GastosInformacion_Descripcion = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_GastosInformacion_fecha = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_GastosInformacion_Cantidad = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosInformacion_PrecioUnit = New System.Windows.Forms.TextBox()
        Me.TextBox_GastosInformacion_Total = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1271, 24)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_GastoInformacionBotonModificar)
        Me.GroupBox3.Controls.Add(Me.Button_GastoInformacionBotonEliminar)
        Me.GroupBox3.Controls.Add(Me.GastosInformacionBotonBuscar)
        Me.GroupBox3.Controls.Add(Me.Button_GastosCalcular)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.GastosInformacionInputID)
        Me.GroupBox3.Controls.Add(Me.ComboBox_GastosInformacion)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosInformacion_Factura)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosInformacion_Proveedor)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosInformacion_Descripcion)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_GastosInformacion_fecha)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosInformacion_Cantidad)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosInformacion_PrecioUnit)
        Me.GroupBox3.Controls.Add(Me.TextBox_GastosInformacion_Total)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 129)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1400, 269)
        Me.GroupBox3.TabIndex = 152
        Me.GroupBox3.TabStop = False
        '
        'Button_GastoInformacionBotonModificar
        '
        Me.Button_GastoInformacionBotonModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button_GastoInformacionBotonModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button_GastoInformacionBotonModificar.ForeColor = System.Drawing.Color.White
        Me.Button_GastoInformacionBotonModificar.Location = New System.Drawing.Point(480, 203)
        Me.Button_GastoInformacionBotonModificar.Name = "Button_GastoInformacionBotonModificar"
        Me.Button_GastoInformacionBotonModificar.Size = New System.Drawing.Size(144, 44)
        Me.Button_GastoInformacionBotonModificar.TabIndex = 173
        Me.Button_GastoInformacionBotonModificar.Text = "Modificar"
        Me.Button_GastoInformacionBotonModificar.UseVisualStyleBackColor = False
        '
        'Button_GastoInformacionBotonEliminar
        '
        Me.Button_GastoInformacionBotonEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button_GastoInformacionBotonEliminar.ForeColor = System.Drawing.Color.White
        Me.Button_GastoInformacionBotonEliminar.Location = New System.Drawing.Point(657, 203)
        Me.Button_GastoInformacionBotonEliminar.Name = "Button_GastoInformacionBotonEliminar"
        Me.Button_GastoInformacionBotonEliminar.Size = New System.Drawing.Size(144, 44)
        Me.Button_GastoInformacionBotonEliminar.TabIndex = 172
        Me.Button_GastoInformacionBotonEliminar.Text = "Eliminar"
        Me.Button_GastoInformacionBotonEliminar.UseVisualStyleBackColor = True
        '
        'GastosInformacionBotonBuscar
        '
        Me.GastosInformacionBotonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GastosInformacionBotonBuscar.ForeColor = System.Drawing.Color.White
        Me.GastosInformacionBotonBuscar.Image = Global.WindowsApplication1.My.Resources.Resources.find81
        Me.GastosInformacionBotonBuscar.Location = New System.Drawing.Point(770, 16)
        Me.GastosInformacionBotonBuscar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GastosInformacionBotonBuscar.Name = "GastosInformacionBotonBuscar"
        Me.GastosInformacionBotonBuscar.Size = New System.Drawing.Size(58, 43)
        Me.GastosInformacionBotonBuscar.TabIndex = 148
        Me.GastosInformacionBotonBuscar.UseVisualStyleBackColor = True
        '
        'Button_GastosCalcular
        '
        Me.Button_GastosCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_GastosCalcular.Location = New System.Drawing.Point(1072, 142)
        Me.Button_GastosCalcular.Name = "Button_GastosCalcular"
        Me.Button_GastosCalcular.Size = New System.Drawing.Size(80, 23)
        Me.Button_GastosCalcular.TabIndex = 146
        Me.Button_GastosCalcular.Text = "Calcular Total"
        Me.Button_GastosCalcular.UseVisualStyleBackColor = True
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
        'GastosInformacionInputID
        '
        Me.GastosInformacionInputID.Location = New System.Drawing.Point(533, 29)
        Me.GastosInformacionInputID.Multiline = True
        Me.GastosInformacionInputID.Name = "GastosInformacionInputID"
        Me.GastosInformacionInputID.Size = New System.Drawing.Size(222, 20)
        Me.GastosInformacionInputID.TabIndex = 144
        '
        'ComboBox_GastosInformacion
        '
        Me.ComboBox_GastosInformacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_GastosInformacion.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_GastosInformacion.FormattingEnabled = True
        Me.ComboBox_GastosInformacion.Location = New System.Drawing.Point(460, 142)
        Me.ComboBox_GastosInformacion.Name = "ComboBox_GastosInformacion"
        Me.ComboBox_GastosInformacion.Size = New System.Drawing.Size(181, 27)
        Me.ComboBox_GastosInformacion.TabIndex = 4
        '
        'TextBox_GastosInformacion_Factura
        '
        Me.TextBox_GastosInformacion_Factura.Location = New System.Drawing.Point(114, 146)
        Me.TextBox_GastosInformacion_Factura.Name = "TextBox_GastosInformacion_Factura"
        Me.TextBox_GastosInformacion_Factura.Size = New System.Drawing.Size(112, 20)
        Me.TextBox_GastosInformacion_Factura.TabIndex = 2
        '
        'TextBox_GastosInformacion_Proveedor
        '
        Me.TextBox_GastosInformacion_Proveedor.Location = New System.Drawing.Point(232, 146)
        Me.TextBox_GastosInformacion_Proveedor.Multiline = True
        Me.TextBox_GastosInformacion_Proveedor.Name = "TextBox_GastosInformacion_Proveedor"
        Me.TextBox_GastosInformacion_Proveedor.Size = New System.Drawing.Size(222, 20)
        Me.TextBox_GastosInformacion_Proveedor.TabIndex = 3
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
        'TextBox_GastosInformacion_Descripcion
        '
        Me.TextBox_GastosInformacion_Descripcion.Location = New System.Drawing.Point(647, 146)
        Me.TextBox_GastosInformacion_Descripcion.Name = "TextBox_GastosInformacion_Descripcion"
        Me.TextBox_GastosInformacion_Descripcion.Size = New System.Drawing.Size(250, 20)
        Me.TextBox_GastosInformacion_Descripcion.TabIndex = 5
        '
        'DateTimePicker_GastosInformacion_fecha
        '
        Me.DateTimePicker_GastosInformacion_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_GastosInformacion_fecha.Location = New System.Drawing.Point(7, 146)
        Me.DateTimePicker_GastosInformacion_fecha.Name = "DateTimePicker_GastosInformacion_fecha"
        Me.DateTimePicker_GastosInformacion_fecha.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker_GastosInformacion_fecha.TabIndex = 1
        '
        'TextBox_GastosInformacion_Cantidad
        '
        Me.TextBox_GastosInformacion_Cantidad.Location = New System.Drawing.Point(903, 145)
        Me.TextBox_GastosInformacion_Cantidad.Name = "TextBox_GastosInformacion_Cantidad"
        Me.TextBox_GastosInformacion_Cantidad.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_GastosInformacion_Cantidad.TabIndex = 6
        '
        'TextBox_GastosInformacion_PrecioUnit
        '
        Me.TextBox_GastosInformacion_PrecioUnit.Location = New System.Drawing.Point(984, 145)
        Me.TextBox_GastosInformacion_PrecioUnit.Name = "TextBox_GastosInformacion_PrecioUnit"
        Me.TextBox_GastosInformacion_PrecioUnit.Size = New System.Drawing.Size(82, 20)
        Me.TextBox_GastosInformacion_PrecioUnit.TabIndex = 7
        '
        'TextBox_GastosInformacion_Total
        '
        Me.TextBox_GastosInformacion_Total.Enabled = False
        Me.TextBox_GastosInformacion_Total.Location = New System.Drawing.Point(1158, 140)
        Me.TextBox_GastosInformacion_Total.Name = "TextBox_GastosInformacion_Total"
        Me.TextBox_GastosInformacion_Total.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_GastosInformacion_Total.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1271, 93)
        Me.Panel1.TabIndex = 174
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(504, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(264, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Información de Salida"
        '
        'VGastosInformacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 437)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VGastosInformacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox_GastosInformacion As ComboBox
    Friend WithEvents TextBox_GastosInformacion_Factura As TextBox
    Friend WithEvents TextBox_GastosInformacion_Proveedor As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox_GastosInformacion_Descripcion As TextBox
    Friend WithEvents DateTimePicker_GastosInformacion_fecha As DateTimePicker
    Friend WithEvents TextBox_GastosInformacion_Cantidad As TextBox
    Friend WithEvents TextBox_GastosInformacion_PrecioUnit As TextBox
    Friend WithEvents TextBox_GastosInformacion_Total As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GastosInformacionInputID As TextBox
    Friend WithEvents Button_GastosCalcular As Button
    Friend WithEvents GastosInformacionBotonBuscar As Button
    Friend WithEvents Button_GastoInformacionBotonModificar As Button
    Friend WithEvents Button_GastoInformacionBotonEliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
End Class
