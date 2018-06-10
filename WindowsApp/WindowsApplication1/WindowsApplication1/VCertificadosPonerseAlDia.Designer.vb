<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VCertificadosPonerseAlDia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VCertificadosPonerseAlDia))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ComprobanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirComprobanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonAsociadosBuscarXNombre = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CertificadosAlDiaTextboxCedulaNumAsociado = New System.Windows.Forms.TextBox()
        Me.CertificadosAlDiaButtonConsultar = New System.Windows.Forms.Button()
        Me.CertificadosAlDiaButtonLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CertificadosAlDiaTextBoxMontoSumar = New System.Windows.Forms.TextBox()
        Me.CertificadosAlDiaButtonSumarAlAcumulado = New System.Windows.Forms.Button()
        Me.CertificadosAlDiaTextboxTotalPeriodo = New System.Windows.Forms.TextBox()
        Me.CertificadosAlDiaTextboxAcumAnterior = New System.Windows.Forms.TextBox()
        Me.CertificadosAlDiaTextboxCed = New System.Windows.Forms.TextBox()
        Me.CertificadosAlDiaTextboxNumAsociado = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CertificadosAlDiaTextboxNombre = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprobanteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1300, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ComprobanteToolStripMenuItem
        '
        Me.ComprobanteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirComprobanteToolStripMenuItem})
        Me.ComprobanteToolStripMenuItem.Name = "ComprobanteToolStripMenuItem"
        Me.ComprobanteToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ComprobanteToolStripMenuItem.Text = "Comprobante"
        '
        'ImprimirComprobanteToolStripMenuItem
        '
        Me.ImprimirComprobanteToolStripMenuItem.Name = "ImprimirComprobanteToolStripMenuItem"
        Me.ImprimirComprobanteToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ImprimirComprobanteToolStripMenuItem.Text = "Imprimir recibo del Acumulado Anterior"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonAsociadosBuscarXNombre)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.CertificadosAlDiaTextboxCedulaNumAsociado)
        Me.GroupBox1.Controls.Add(Me.CertificadosAlDiaButtonConsultar)
        Me.GroupBox1.Controls.Add(Me.CertificadosAlDiaButtonLimpiar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 407)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'ButtonAsociadosBuscarXNombre
        '
        Me.ButtonAsociadosBuscarXNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonAsociadosBuscarXNombre.ForeColor = System.Drawing.Color.White
        Me.ButtonAsociadosBuscarXNombre.Image = Global.WindowsApplication1.My.Resources.Resources.search9
        Me.ButtonAsociadosBuscarXNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAsociadosBuscarXNombre.Location = New System.Drawing.Point(13, 143)
        Me.ButtonAsociadosBuscarXNombre.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ButtonAsociadosBuscarXNombre.Name = "ButtonAsociadosBuscarXNombre"
        Me.ButtonAsociadosBuscarXNombre.Size = New System.Drawing.Size(199, 44)
        Me.ButtonAsociadosBuscarXNombre.TabIndex = 68
        Me.ButtonAsociadosBuscarXNombre.Text = "Buscar por Nombre"
        Me.ButtonAsociadosBuscarXNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAsociadosBuscarXNombre.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(7, 44)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(203, 15)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "Cédula (x-xxxx-xxxx) / # Asociado:"
        '
        'CertificadosAlDiaTextboxCedulaNumAsociado
        '
        Me.CertificadosAlDiaTextboxCedulaNumAsociado.Location = New System.Drawing.Point(9, 74)
        Me.CertificadosAlDiaTextboxCedulaNumAsociado.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CertificadosAlDiaTextboxCedulaNumAsociado.Name = "CertificadosAlDiaTextboxCedulaNumAsociado"
        Me.CertificadosAlDiaTextboxCedulaNumAsociado.Size = New System.Drawing.Size(203, 22)
        Me.CertificadosAlDiaTextboxCedulaNumAsociado.TabIndex = 54
        '
        'CertificadosAlDiaButtonConsultar
        '
        Me.CertificadosAlDiaButtonConsultar.Image = Global.WindowsApplication1.My.Resources.Resources.find81
        Me.CertificadosAlDiaButtonConsultar.Location = New System.Drawing.Point(216, 68)
        Me.CertificadosAlDiaButtonConsultar.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CertificadosAlDiaButtonConsultar.Name = "CertificadosAlDiaButtonConsultar"
        Me.CertificadosAlDiaButtonConsultar.Size = New System.Drawing.Size(55, 38)
        Me.CertificadosAlDiaButtonConsultar.TabIndex = 55
        Me.CertificadosAlDiaButtonConsultar.UseVisualStyleBackColor = True
        '
        'CertificadosAlDiaButtonLimpiar
        '
        Me.CertificadosAlDiaButtonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CertificadosAlDiaButtonLimpiar.ForeColor = System.Drawing.Color.White
        Me.CertificadosAlDiaButtonLimpiar.Image = Global.WindowsApplication1.My.Resources.Resources.cleanlast2
        Me.CertificadosAlDiaButtonLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CertificadosAlDiaButtonLimpiar.Location = New System.Drawing.Point(13, 226)
        Me.CertificadosAlDiaButtonLimpiar.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CertificadosAlDiaButtonLimpiar.Name = "CertificadosAlDiaButtonLimpiar"
        Me.CertificadosAlDiaButtonLimpiar.Size = New System.Drawing.Size(199, 44)
        Me.CertificadosAlDiaButtonLimpiar.TabIndex = 58
        Me.CertificadosAlDiaButtonLimpiar.Text = "Limpiar Campos"
        Me.CertificadosAlDiaButtonLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CertificadosAlDiaButtonLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CertificadosAlDiaTextBoxMontoSumar)
        Me.GroupBox2.Controls.Add(Me.CertificadosAlDiaButtonSumarAlAcumulado)
        Me.GroupBox2.Controls.Add(Me.CertificadosAlDiaTextboxTotalPeriodo)
        Me.GroupBox2.Controls.Add(Me.CertificadosAlDiaTextboxAcumAnterior)
        Me.GroupBox2.Controls.Add(Me.CertificadosAlDiaTextboxCed)
        Me.GroupBox2.Controls.Add(Me.CertificadosAlDiaTextboxNumAsociado)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.CertificadosAlDiaTextboxNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(314, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(964, 305)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(223, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Monto a Sumar:"
        '
        'CertificadosAlDiaTextBoxMontoSumar
        '
        Me.CertificadosAlDiaTextBoxMontoSumar.Location = New System.Drawing.Point(323, 158)
        Me.CertificadosAlDiaTextBoxMontoSumar.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CertificadosAlDiaTextBoxMontoSumar.Name = "CertificadosAlDiaTextBoxMontoSumar"
        Me.CertificadosAlDiaTextBoxMontoSumar.Size = New System.Drawing.Size(187, 20)
        Me.CertificadosAlDiaTextBoxMontoSumar.TabIndex = 67
        '
        'CertificadosAlDiaButtonSumarAlAcumulado
        '
        Me.CertificadosAlDiaButtonSumarAlAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CertificadosAlDiaButtonSumarAlAcumulado.ForeColor = System.Drawing.Color.White
        Me.CertificadosAlDiaButtonSumarAlAcumulado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CertificadosAlDiaButtonSumarAlAcumulado.Location = New System.Drawing.Point(323, 217)
        Me.CertificadosAlDiaButtonSumarAlAcumulado.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CertificadosAlDiaButtonSumarAlAcumulado.Name = "CertificadosAlDiaButtonSumarAlAcumulado"
        Me.CertificadosAlDiaButtonSumarAlAcumulado.Size = New System.Drawing.Size(187, 44)
        Me.CertificadosAlDiaButtonSumarAlAcumulado.TabIndex = 141
        Me.CertificadosAlDiaButtonSumarAlAcumulado.Text = "Sumar Al Acumulado"
        Me.CertificadosAlDiaButtonSumarAlAcumulado.UseVisualStyleBackColor = True
        '
        'CertificadosAlDiaTextboxTotalPeriodo
        '
        Me.CertificadosAlDiaTextboxTotalPeriodo.Enabled = False
        Me.CertificadosAlDiaTextboxTotalPeriodo.Location = New System.Drawing.Point(782, 64)
        Me.CertificadosAlDiaTextboxTotalPeriodo.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CertificadosAlDiaTextboxTotalPeriodo.Name = "CertificadosAlDiaTextboxTotalPeriodo"
        Me.CertificadosAlDiaTextboxTotalPeriodo.Size = New System.Drawing.Size(144, 20)
        Me.CertificadosAlDiaTextboxTotalPeriodo.TabIndex = 140
        '
        'CertificadosAlDiaTextboxAcumAnterior
        '
        Me.CertificadosAlDiaTextboxAcumAnterior.Enabled = False
        Me.CertificadosAlDiaTextboxAcumAnterior.Location = New System.Drawing.Point(625, 64)
        Me.CertificadosAlDiaTextboxAcumAnterior.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CertificadosAlDiaTextboxAcumAnterior.Multiline = True
        Me.CertificadosAlDiaTextboxAcumAnterior.Name = "CertificadosAlDiaTextboxAcumAnterior"
        Me.CertificadosAlDiaTextboxAcumAnterior.Size = New System.Drawing.Size(144, 20)
        Me.CertificadosAlDiaTextboxAcumAnterior.TabIndex = 139
        '
        'CertificadosAlDiaTextboxCed
        '
        Me.CertificadosAlDiaTextboxCed.Enabled = False
        Me.CertificadosAlDiaTextboxCed.Location = New System.Drawing.Point(165, 65)
        Me.CertificadosAlDiaTextboxCed.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CertificadosAlDiaTextboxCed.Name = "CertificadosAlDiaTextboxCed"
        Me.CertificadosAlDiaTextboxCed.Size = New System.Drawing.Size(144, 20)
        Me.CertificadosAlDiaTextboxCed.TabIndex = 138
        '
        'CertificadosAlDiaTextboxNumAsociado
        '
        Me.CertificadosAlDiaTextboxNumAsociado.Enabled = False
        Me.CertificadosAlDiaTextboxNumAsociado.Location = New System.Drawing.Point(6, 64)
        Me.CertificadosAlDiaTextboxNumAsociado.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CertificadosAlDiaTextboxNumAsociado.Name = "CertificadosAlDiaTextboxNumAsociado"
        Me.CertificadosAlDiaTextboxNumAsociado.Size = New System.Drawing.Size(144, 20)
        Me.CertificadosAlDiaTextboxNumAsociado.TabIndex = 124
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(920, 41)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(777, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 15)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Total del Periodo Actual"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(632, 8)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 30)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Aporte Acumulado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   años anteriores"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(210, 16)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Cédula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(380, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Nombre y Apellidos Completos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 15)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Número Asociado"
        '
        'CertificadosAlDiaTextboxNombre
        '
        Me.CertificadosAlDiaTextboxNombre.Enabled = False
        Me.CertificadosAlDiaTextboxNombre.Location = New System.Drawing.Point(323, 64)
        Me.CertificadosAlDiaTextboxNombre.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CertificadosAlDiaTextboxNombre.Name = "CertificadosAlDiaTextboxNombre"
        Me.CertificadosAlDiaTextboxNombre.Size = New System.Drawing.Size(289, 20)
        Me.CertificadosAlDiaTextboxNombre.TabIndex = 63
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Location = New System.Drawing.Point(0, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1285, 93)
        Me.Panel3.TabIndex = 180
        '
        'Label31
        '
        Me.Label31.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(474, 31)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(349, 29)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "Poner al día las Aportaciones"
        '
        'VCertificadosPonerseAlDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 542)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VCertificadosPonerseAlDia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CertificadosAlDiaButtonLimpiar As Button
    Friend WithEvents CertificadosAlDiaButtonConsultar As Button
    Friend WithEvents CertificadosAlDiaTextboxCedulaNumAsociado As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CertificadosAlDiaTextboxNumAsociado As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CertificadosAlDiaTextboxNombre As TextBox
    Friend WithEvents CertificadosAlDiaTextboxTotalPeriodo As TextBox
    Friend WithEvents CertificadosAlDiaTextboxAcumAnterior As TextBox
    Friend WithEvents CertificadosAlDiaTextboxCed As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CertificadosAlDiaTextBoxMontoSumar As TextBox
    Friend WithEvents CertificadosAlDiaButtonSumarAlAcumulado As Button
    Friend WithEvents ComprobanteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirComprobanteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonAsociadosBuscarXNombre As Button
End Class
