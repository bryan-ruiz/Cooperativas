<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VCertificadosEntradas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VCertificadosEntradas))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificadosEntradasTextboxFacturaRecibos = New System.Windows.Forms.TextBox()
        Me.CertificadosEntradasFecha = New System.Windows.Forms.DateTimePicker()
        Me.CertificadosEntradasTexboxCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CertificadosEntradasDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CertificadosEntradasCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CertificadosEntradasPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.CertificadosEntradasCalcularTotal = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CertificadosEntradasTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CertificadosEntradasAgregarEntrada = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CertificadosEntradasCodigoDeCuenta = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1408, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'CertificadosEntradasTextboxFacturaRecibos
        '
        Me.CertificadosEntradasTextboxFacturaRecibos.Location = New System.Drawing.Point(107, 67)
        Me.CertificadosEntradasTextboxFacturaRecibos.Name = "CertificadosEntradasTextboxFacturaRecibos"
        Me.CertificadosEntradasTextboxFacturaRecibos.Size = New System.Drawing.Size(123, 20)
        Me.CertificadosEntradasTextboxFacturaRecibos.TabIndex = 2
        '
        'CertificadosEntradasFecha
        '
        Me.CertificadosEntradasFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CertificadosEntradasFecha.Location = New System.Drawing.Point(0, 67)
        Me.CertificadosEntradasFecha.Name = "CertificadosEntradasFecha"
        Me.CertificadosEntradasFecha.Size = New System.Drawing.Size(102, 20)
        Me.CertificadosEntradasFecha.TabIndex = 1
        '
        'CertificadosEntradasTexboxCliente
        '
        Me.CertificadosEntradasTexboxCliente.Location = New System.Drawing.Point(236, 67)
        Me.CertificadosEntradasTexboxCliente.Multiline = True
        Me.CertificadosEntradasTexboxCliente.Name = "CertificadosEntradasTexboxCliente"
        Me.CertificadosEntradasTexboxCliente.Size = New System.Drawing.Size(211, 20)
        Me.CertificadosEntradasTexboxCliente.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(727, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Descripción"
        '
        'CertificadosEntradasDescripcion
        '
        Me.CertificadosEntradasDescripcion.Location = New System.Drawing.Point(640, 68)
        Me.CertificadosEntradasDescripcion.Name = "CertificadosEntradasDescripcion"
        Me.CertificadosEntradasDescripcion.Size = New System.Drawing.Size(251, 20)
        Me.CertificadosEntradasDescripcion.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(900, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cantidad"
        '
        'CertificadosEntradasCantidad
        '
        Me.CertificadosEntradasCantidad.Location = New System.Drawing.Point(899, 67)
        Me.CertificadosEntradasCantidad.Name = "CertificadosEntradasCantidad"
        Me.CertificadosEntradasCantidad.Size = New System.Drawing.Size(75, 20)
        Me.CertificadosEntradasCantidad.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(976, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Precio Unitario"
        '
        'CertificadosEntradasPrecioUnitario
        '
        Me.CertificadosEntradasPrecioUnitario.Location = New System.Drawing.Point(980, 66)
        Me.CertificadosEntradasPrecioUnitario.Name = "CertificadosEntradasPrecioUnitario"
        Me.CertificadosEntradasPrecioUnitario.Size = New System.Drawing.Size(82, 20)
        Me.CertificadosEntradasPrecioUnitario.TabIndex = 7
        '
        'CertificadosEntradasCalcularTotal
        '
        Me.CertificadosEntradasCalcularTotal.Location = New System.Drawing.Point(1068, 64)
        Me.CertificadosEntradasCalcularTotal.Name = "CertificadosEntradasCalcularTotal"
        Me.CertificadosEntradasCalcularTotal.Size = New System.Drawing.Size(80, 23)
        Me.CertificadosEntradasCalcularTotal.TabIndex = 8
        Me.CertificadosEntradasCalcularTotal.Text = "Calcular Total"
        Me.CertificadosEntradasCalcularTotal.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(1186, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Total"
        '
        'CertificadosEntradasTotal
        '
        Me.CertificadosEntradasTotal.Enabled = False
        Me.CertificadosEntradasTotal.Location = New System.Drawing.Point(1154, 67)
        Me.CertificadosEntradasTotal.Name = "CertificadosEntradasTotal"
        Me.CertificadosEntradasTotal.Size = New System.Drawing.Size(100, 20)
        Me.CertificadosEntradasTotal.TabIndex = 9
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
        'CertificadosEntradasAgregarEntrada
        '
        Me.CertificadosEntradasAgregarEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CertificadosEntradasAgregarEntrada.ForeColor = System.Drawing.Color.White
        Me.CertificadosEntradasAgregarEntrada.Location = New System.Drawing.Point(1261, 63)
        Me.CertificadosEntradasAgregarEntrada.Name = "CertificadosEntradasAgregarEntrada"
        Me.CertificadosEntradasAgregarEntrada.Size = New System.Drawing.Size(123, 28)
        Me.CertificadosEntradasAgregarEntrada.TabIndex = 10
        Me.CertificadosEntradasAgregarEntrada.Text = "Agregar Entrada"
        Me.CertificadosEntradasAgregarEntrada.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CertificadosEntradasAgregarEntrada.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CertificadosEntradasCodigoDeCuenta)
        Me.GroupBox2.Controls.Add(Me.CertificadosEntradasAgregarEntrada)
        Me.GroupBox2.Controls.Add(Me.CertificadosEntradasTextboxFacturaRecibos)
        Me.GroupBox2.Controls.Add(Me.CertificadosEntradasTexboxCliente)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.CertificadosEntradasDescripcion)
        Me.GroupBox2.Controls.Add(Me.CertificadosEntradasFecha)
        Me.GroupBox2.Controls.Add(Me.CertificadosEntradasCantidad)
        Me.GroupBox2.Controls.Add(Me.CertificadosEntradasPrecioUnitario)
        Me.GroupBox2.Controls.Add(Me.CertificadosEntradasTotal)
        Me.GroupBox2.Controls.Add(Me.CertificadosEntradasCalcularTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1384, 150)
        Me.GroupBox2.TabIndex = 140
        Me.GroupBox2.TabStop = False
        '
        'CertificadosEntradasCodigoDeCuenta
        '
        Me.CertificadosEntradasCodigoDeCuenta.Enabled = False
        Me.CertificadosEntradasCodigoDeCuenta.Location = New System.Drawing.Point(453, 67)
        Me.CertificadosEntradasCodigoDeCuenta.Name = "CertificadosEntradasCodigoDeCuenta"
        Me.CertificadosEntradasCodigoDeCuenta.Size = New System.Drawing.Size(181, 20)
        Me.CertificadosEntradasCodigoDeCuenta.TabIndex = 142
        Me.CertificadosEntradasCodigoDeCuenta.Text = "Entrada Aportaciones"
        Me.CertificadosEntradasCodigoDeCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(-1, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1265, 37)
        Me.GroupBox3.TabIndex = 141
        Me.GroupBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(310, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Cliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(103, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "N° Factura o Recibo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(26, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Fecha"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1408, 93)
        Me.Panel1.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(552, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 29)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Entradas de Aportaciones"
        '
        'VCertificadosEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1403, 424)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VCertificadosEntradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CertificadosEntradasTextboxFacturaRecibos As TextBox
    Friend WithEvents CertificadosEntradasFecha As DateTimePicker
    Friend WithEvents CertificadosEntradasTexboxCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CertificadosEntradasDescripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CertificadosEntradasCantidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CertificadosEntradasPrecioUnitario As TextBox
    Friend WithEvents CertificadosEntradasCalcularTotal As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents CertificadosEntradasTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CertificadosEntradasAgregarEntrada As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CertificadosEntradasCodigoDeCuenta As TextBox
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
End Class
