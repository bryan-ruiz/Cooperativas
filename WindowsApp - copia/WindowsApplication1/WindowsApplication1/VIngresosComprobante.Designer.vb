<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VIngresosComprobante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VIngresosComprobante))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox_IngresosClienteRE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_IngresosDescripcionRE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_IngresosCantidadRE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_IngresosPrecioUnitarioRE = New System.Windows.Forms.TextBox()
        Me.Button_IngresosCalcularTotalRE = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_IngresosTotalRE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_IngresosCodigCuentaRE = New System.Windows.Forms.ComboBox()
        Me.TextBox_IngresosFacturaRecibosRE = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button_IngresosImprimirReciboRE = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1247, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'TextBox_IngresosClienteRE
        '
        Me.TextBox_IngresosClienteRE.Location = New System.Drawing.Point(141, 68)
        Me.TextBox_IngresosClienteRE.Multiline = True
        Me.TextBox_IngresosClienteRE.Name = "TextBox_IngresosClienteRE"
        Me.TextBox_IngresosClienteRE.Size = New System.Drawing.Size(222, 20)
        Me.TextBox_IngresosClienteRE.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(623, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Descripción"
        '
        'TextBox_IngresosDescripcionRE
        '
        Me.TextBox_IngresosDescripcionRE.Location = New System.Drawing.Point(556, 69)
        Me.TextBox_IngresosDescripcionRE.Name = "TextBox_IngresosDescripcionRE"
        Me.TextBox_IngresosDescripcionRE.Size = New System.Drawing.Size(262, 20)
        Me.TextBox_IngresosDescripcionRE.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(807, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cantidad"
        '
        'TextBox_IngresosCantidadRE
        '
        Me.TextBox_IngresosCantidadRE.Location = New System.Drawing.Point(824, 68)
        Me.TextBox_IngresosCantidadRE.Name = "TextBox_IngresosCantidadRE"
        Me.TextBox_IngresosCantidadRE.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_IngresosCantidadRE.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(879, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Precio Unitario"
        '
        'TextBox_IngresosPrecioUnitarioRE
        '
        Me.TextBox_IngresosPrecioUnitarioRE.Location = New System.Drawing.Point(905, 67)
        Me.TextBox_IngresosPrecioUnitarioRE.Name = "TextBox_IngresosPrecioUnitarioRE"
        Me.TextBox_IngresosPrecioUnitarioRE.Size = New System.Drawing.Size(93, 20)
        Me.TextBox_IngresosPrecioUnitarioRE.TabIndex = 7
        '
        'Button_IngresosCalcularTotalRE
        '
        Me.Button_IngresosCalcularTotalRE.Location = New System.Drawing.Point(1005, 64)
        Me.Button_IngresosCalcularTotalRE.Name = "Button_IngresosCalcularTotalRE"
        Me.Button_IngresosCalcularTotalRE.Size = New System.Drawing.Size(80, 23)
        Me.Button_IngresosCalcularTotalRE.TabIndex = 8
        Me.Button_IngresosCalcularTotalRE.Text = "Calcular Total"
        Me.Button_IngresosCalcularTotalRE.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(1196, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Total"
        '
        'TextBox_IngresosTotalRE
        '
        Me.TextBox_IngresosTotalRE.Enabled = False
        Me.TextBox_IngresosTotalRE.Location = New System.Drawing.Point(1091, 67)
        Me.TextBox_IngresosTotalRE.Name = "TextBox_IngresosTotalRE"
        Me.TextBox_IngresosTotalRE.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_IngresosTotalRE.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(370, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Codigo de Cuenta"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(518, 62)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(160, 22)
        Me.Label18.TabIndex = 138
        Me.Label18.Text = "Recibo de Entradas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox_IngresosCodigCuentaRE)
        Me.GroupBox2.Controls.Add(Me.TextBox_IngresosFacturaRecibosRE)
        Me.GroupBox2.Controls.Add(Me.TextBox_IngresosClienteRE)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox_IngresosDescripcionRE)
        Me.GroupBox2.Controls.Add(Me.TextBox_IngresosCantidadRE)
        Me.GroupBox2.Controls.Add(Me.TextBox_IngresosPrecioUnitarioRE)
        Me.GroupBox2.Controls.Add(Me.TextBox_IngresosTotalRE)
        Me.GroupBox2.Controls.Add(Me.Button_IngresosCalcularTotalRE)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1214, 109)
        Me.GroupBox2.TabIndex = 140
        Me.GroupBox2.TabStop = False
        '
        'ComboBox_IngresosCodigCuentaRE
        '
        Me.ComboBox_IngresosCodigCuentaRE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_IngresosCodigCuentaRE.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_IngresosCodigCuentaRE.FormattingEnabled = True
        Me.ComboBox_IngresosCodigCuentaRE.Location = New System.Drawing.Point(369, 64)
        Me.ComboBox_IngresosCodigCuentaRE.Name = "ComboBox_IngresosCodigCuentaRE"
        Me.ComboBox_IngresosCodigCuentaRE.Size = New System.Drawing.Size(181, 27)
        Me.ComboBox_IngresosCodigCuentaRE.TabIndex = 4
        '
        'TextBox_IngresosFacturaRecibosRE
        '
        Me.TextBox_IngresosFacturaRecibosRE.Location = New System.Drawing.Point(23, 68)
        Me.TextBox_IngresosFacturaRecibosRE.Name = "TextBox_IngresosFacturaRecibosRE"
        Me.TextBox_IngresosFacturaRecibosRE.Size = New System.Drawing.Size(112, 20)
        Me.TextBox_IngresosFacturaRecibosRE.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1168, 37)
        Me.GroupBox3.TabIndex = 141
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(1098, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(199, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Cliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(6, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "N° Factura"
        '
        'Button_IngresosImprimirReciboRE
        '
        Me.Button_IngresosImprimirReciboRE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_IngresosImprimirReciboRE.Location = New System.Drawing.Point(539, 283)
        Me.Button_IngresosImprimirReciboRE.Name = "Button_IngresosImprimirReciboRE"
        Me.Button_IngresosImprimirReciboRE.Size = New System.Drawing.Size(128, 28)
        Me.Button_IngresosImprimirReciboRE.TabIndex = 30
        Me.Button_IngresosImprimirReciboRE.Text = "Imprimir Recibo"
        Me.Button_IngresosImprimirReciboRE.UseVisualStyleBackColor = True
        '
        'VIngresosComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1247, 368)
        Me.Controls.Add(Me.Button_IngresosImprimirReciboRE)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VIngresosComprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo de Entrada"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TextBox_IngresosClienteRE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_IngresosDescripcionRE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_IngresosCantidadRE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_IngresosPrecioUnitarioRE As TextBox
    Friend WithEvents Button_IngresosCalcularTotalRE As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_IngresosTotalRE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox_IngresosCodigCuentaRE As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button_IngresosImprimirReciboRE As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_IngresosFacturaRecibosRE As TextBox
End Class
