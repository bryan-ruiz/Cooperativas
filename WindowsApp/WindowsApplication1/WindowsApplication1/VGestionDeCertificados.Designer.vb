<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VGestionDeCertificados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VGestionDeCertificados))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GestionCertificadoButtonSumarReservas = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GestionCertificadoButtonNoRetirarAcum = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GestionCertificadoButtonRetirarAcum = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GestionCertificadoTextboxAcumuladoActual = New System.Windows.Forms.TextBox()
        Me.GestionCertificadoTextboxStatus = New System.Windows.Forms.TextBox()
        Me.GestionCertificadoTextboxCed = New System.Windows.Forms.TextBox()
        Me.GestionCertificadoTextboxNumAsociado = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GestionCertificadoTextboxNombreCompleto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GestionCertificadoTextboxCedulaNumAsociado = New System.Windows.Forms.TextBox()
        Me.GestionCertificadoButtonConsultar = New System.Windows.Forms.Button()
        Me.GestionCertificadoButtonLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificadosEnEstadoPendienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificadosEnEstadoReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeCertificadosRetiradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeTodosLosEstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechasLímiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MontosMáximosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionCertificadoButtonLiquidar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1224, 93)
        Me.Panel1.TabIndex = 150
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(428, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(419, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Gestión de Certificados en Tránsito"
        '
        'GestionCertificadoButtonSumarReservas
        '
        Me.GestionCertificadoButtonSumarReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GestionCertificadoButtonSumarReservas.ForeColor = System.Drawing.Color.White
        Me.GestionCertificadoButtonSumarReservas.Location = New System.Drawing.Point(452, 197)
        Me.GestionCertificadoButtonSumarReservas.Name = "GestionCertificadoButtonSumarReservas"
        Me.GestionCertificadoButtonSumarReservas.Size = New System.Drawing.Size(192, 44)
        Me.GestionCertificadoButtonSumarReservas.TabIndex = 173
        Me.GestionCertificadoButtonSumarReservas.Text = "Sumar a Reservas"
        Me.GestionCertificadoButtonSumarReservas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GestionCertificadoButtonLiquidar)
        Me.GroupBox2.Controls.Add(Me.GestionCertificadoButtonNoRetirarAcum)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.GestionCertificadoButtonRetirarAcum)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.GestionCertificadoTextboxAcumuladoActual)
        Me.GroupBox2.Controls.Add(Me.GestionCertificadoButtonSumarReservas)
        Me.GroupBox2.Controls.Add(Me.GestionCertificadoTextboxStatus)
        Me.GroupBox2.Controls.Add(Me.GestionCertificadoTextboxCed)
        Me.GroupBox2.Controls.Add(Me.GestionCertificadoTextboxNumAsociado)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GestionCertificadoTextboxNombreCompleto)
        Me.GroupBox2.Location = New System.Drawing.Point(300, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(915, 287)
        Me.GroupBox2.TabIndex = 176
        Me.GroupBox2.TabStop = False
        '
        'GestionCertificadoButtonNoRetirarAcum
        '
        Me.GestionCertificadoButtonNoRetirarAcum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GestionCertificadoButtonNoRetirarAcum.ForeColor = System.Drawing.Color.White
        Me.GestionCertificadoButtonNoRetirarAcum.Location = New System.Drawing.Point(15, 197)
        Me.GestionCertificadoButtonNoRetirarAcum.Name = "GestionCertificadoButtonNoRetirarAcum"
        Me.GestionCertificadoButtonNoRetirarAcum.Size = New System.Drawing.Size(197, 44)
        Me.GestionCertificadoButtonNoRetirarAcum.TabIndex = 179
        Me.GestionCertificadoButtonNoRetirarAcum.Text = "No Retirar Acumulado"
        Me.GestionCertificadoButtonNoRetirarAcum.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(582, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 15)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "¢"
        '
        'GestionCertificadoButtonRetirarAcum
        '
        Me.GestionCertificadoButtonRetirarAcum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GestionCertificadoButtonRetirarAcum.ForeColor = System.Drawing.Color.White
        Me.GestionCertificadoButtonRetirarAcum.Location = New System.Drawing.Point(234, 197)
        Me.GestionCertificadoButtonRetirarAcum.Name = "GestionCertificadoButtonRetirarAcum"
        Me.GestionCertificadoButtonRetirarAcum.Size = New System.Drawing.Size(194, 44)
        Me.GestionCertificadoButtonRetirarAcum.TabIndex = 175
        Me.GestionCertificadoButtonRetirarAcum.Text = "Retirar Acumulado"
        Me.GestionCertificadoButtonRetirarAcum.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(79, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(726, 16)
        Me.Label2.TabIndex = 178
        Me.Label2.Text = "Al realizar el Cierre del Periodo se generan excedentes en tránsito, seleccione u" &
    "na opción para cambiar el estado actual."
        '
        'GestionCertificadoTextboxAcumuladoActual
        '
        Me.GestionCertificadoTextboxAcumuladoActual.Enabled = False
        Me.GestionCertificadoTextboxAcumuladoActual.Location = New System.Drawing.Point(599, 82)
        Me.GestionCertificadoTextboxAcumuladoActual.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionCertificadoTextboxAcumuladoActual.Multiline = True
        Me.GestionCertificadoTextboxAcumuladoActual.Name = "GestionCertificadoTextboxAcumuladoActual"
        Me.GestionCertificadoTextboxAcumuladoActual.Size = New System.Drawing.Size(122, 20)
        Me.GestionCertificadoTextboxAcumuladoActual.TabIndex = 140
        '
        'GestionCertificadoTextboxStatus
        '
        Me.GestionCertificadoTextboxStatus.Enabled = False
        Me.GestionCertificadoTextboxStatus.Location = New System.Drawing.Point(725, 82)
        Me.GestionCertificadoTextboxStatus.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionCertificadoTextboxStatus.Multiline = True
        Me.GestionCertificadoTextboxStatus.Name = "GestionCertificadoTextboxStatus"
        Me.GestionCertificadoTextboxStatus.Size = New System.Drawing.Size(144, 20)
        Me.GestionCertificadoTextboxStatus.TabIndex = 139
        '
        'GestionCertificadoTextboxCed
        '
        Me.GestionCertificadoTextboxCed.Enabled = False
        Me.GestionCertificadoTextboxCed.Location = New System.Drawing.Point(154, 82)
        Me.GestionCertificadoTextboxCed.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionCertificadoTextboxCed.Name = "GestionCertificadoTextboxCed"
        Me.GestionCertificadoTextboxCed.Size = New System.Drawing.Size(144, 20)
        Me.GestionCertificadoTextboxCed.TabIndex = 138
        '
        'GestionCertificadoTextboxNumAsociado
        '
        Me.GestionCertificadoTextboxNumAsociado.Enabled = False
        Me.GestionCertificadoTextboxNumAsociado.Location = New System.Drawing.Point(6, 82)
        Me.GestionCertificadoTextboxNumAsociado.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionCertificadoTextboxNumAsociado.Name = "GestionCertificadoTextboxNumAsociado"
        Me.GestionCertificadoTextboxNumAsociado.Size = New System.Drawing.Size(144, 20)
        Me.GestionCertificadoTextboxNumAsociado.TabIndex = 124
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(6, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(863, 41)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(611, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 30)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "  Acumulado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      Actual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(749, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Estado Actual:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(195, 16)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Cédula"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(352, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 15)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Nombre y Apellidos Completos"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(19, 16)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 15)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "Número Asociado"
        '
        'GestionCertificadoTextboxNombreCompleto
        '
        Me.GestionCertificadoTextboxNombreCompleto.Enabled = False
        Me.GestionCertificadoTextboxNombreCompleto.Location = New System.Drawing.Point(302, 82)
        Me.GestionCertificadoTextboxNombreCompleto.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionCertificadoTextboxNombreCompleto.Name = "GestionCertificadoTextboxNombreCompleto"
        Me.GestionCertificadoTextboxNombreCompleto.Size = New System.Drawing.Size(275, 20)
        Me.GestionCertificadoTextboxNombreCompleto.TabIndex = 63
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.GestionCertificadoTextboxCedulaNumAsociado)
        Me.GroupBox1.Controls.Add(Me.GestionCertificadoButtonConsultar)
        Me.GroupBox1.Controls.Add(Me.GestionCertificadoButtonLimpiar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 289)
        Me.GroupBox1.TabIndex = 175
        Me.GroupBox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(8, 49)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(203, 15)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "Cédula (x-xxxx-xxxx) / # Asociado:"
        '
        'GestionCertificadoTextboxCedulaNumAsociado
        '
        Me.GestionCertificadoTextboxCedulaNumAsociado.Location = New System.Drawing.Point(9, 77)
        Me.GestionCertificadoTextboxCedulaNumAsociado.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionCertificadoTextboxCedulaNumAsociado.Name = "GestionCertificadoTextboxCedulaNumAsociado"
        Me.GestionCertificadoTextboxCedulaNumAsociado.Size = New System.Drawing.Size(203, 22)
        Me.GestionCertificadoTextboxCedulaNumAsociado.TabIndex = 54
        '
        'GestionCertificadoButtonConsultar
        '
        Me.GestionCertificadoButtonConsultar.Image = Global.WindowsApplication1.My.Resources.Resources.find81
        Me.GestionCertificadoButtonConsultar.Location = New System.Drawing.Point(219, 67)
        Me.GestionCertificadoButtonConsultar.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionCertificadoButtonConsultar.Name = "GestionCertificadoButtonConsultar"
        Me.GestionCertificadoButtonConsultar.Size = New System.Drawing.Size(55, 38)
        Me.GestionCertificadoButtonConsultar.TabIndex = 55
        Me.GestionCertificadoButtonConsultar.UseVisualStyleBackColor = True
        '
        'GestionCertificadoButtonLimpiar
        '
        Me.GestionCertificadoButtonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GestionCertificadoButtonLimpiar.ForeColor = System.Drawing.Color.White
        Me.GestionCertificadoButtonLimpiar.Image = Global.WindowsApplication1.My.Resources.Resources.cleanlast2
        Me.GestionCertificadoButtonLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GestionCertificadoButtonLimpiar.Location = New System.Drawing.Point(43, 199)
        Me.GestionCertificadoButtonLimpiar.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionCertificadoButtonLimpiar.Name = "GestionCertificadoButtonLimpiar"
        Me.GestionCertificadoButtonLimpiar.Size = New System.Drawing.Size(187, 44)
        Me.GestionCertificadoButtonLimpiar.TabIndex = 58
        Me.GestionCertificadoButtonLimpiar.Text = "Limpiar Campos"
        Me.GestionCertificadoButtonLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GestionCertificadoButtonLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 480)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(592, 16)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "Nota: Al sumar el acumulado a Reservas, se asigna un 50% a Educación y 50% a Bien" &
    "estar Social"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem, Me.FechasLímiteToolStripMenuItem, Me.MontosMáximosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1225, 24)
        Me.MenuStrip1.TabIndex = 180
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CertificadosEnEstadoPendienteToolStripMenuItem, Me.CertificadosEnEstadoReservasToolStripMenuItem, Me.ReporteDeCertificadosRetiradosToolStripMenuItem, Me.ReporteDeTodosLosEstadosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'CertificadosEnEstadoPendienteToolStripMenuItem
        '
        Me.CertificadosEnEstadoPendienteToolStripMenuItem.Name = "CertificadosEnEstadoPendienteToolStripMenuItem"
        Me.CertificadosEnEstadoPendienteToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.CertificadosEnEstadoPendienteToolStripMenuItem.Text = "Reporte de certificados - Pendientes"
        '
        'CertificadosEnEstadoReservasToolStripMenuItem
        '
        Me.CertificadosEnEstadoReservasToolStripMenuItem.Name = "CertificadosEnEstadoReservasToolStripMenuItem"
        Me.CertificadosEnEstadoReservasToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.CertificadosEnEstadoReservasToolStripMenuItem.Text = "Reporte de certificados - en Reservas"
        '
        'ReporteDeCertificadosRetiradosToolStripMenuItem
        '
        Me.ReporteDeCertificadosRetiradosToolStripMenuItem.Name = "ReporteDeCertificadosRetiradosToolStripMenuItem"
        Me.ReporteDeCertificadosRetiradosToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.ReporteDeCertificadosRetiradosToolStripMenuItem.Text = "Reporte de certificados - Retirados"
        '
        'ReporteDeTodosLosEstadosToolStripMenuItem
        '
        Me.ReporteDeTodosLosEstadosToolStripMenuItem.Name = "ReporteDeTodosLosEstadosToolStripMenuItem"
        Me.ReporteDeTodosLosEstadosToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.ReporteDeTodosLosEstadosToolStripMenuItem.Text = "Reporte de Todos los Estados"
        '
        'FechasLímiteToolStripMenuItem
        '
        Me.FechasLímiteToolStripMenuItem.Name = "FechasLímiteToolStripMenuItem"
        Me.FechasLímiteToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.FechasLímiteToolStripMenuItem.Text = "Fechas Límite"
        '
        'MontosMáximosToolStripMenuItem
        '
        Me.MontosMáximosToolStripMenuItem.Name = "MontosMáximosToolStripMenuItem"
        Me.MontosMáximosToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.MontosMáximosToolStripMenuItem.Text = "Montos Máximos"
        '
        'GestionCertificadoButtonLiquidar
        '
        Me.GestionCertificadoButtonLiquidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GestionCertificadoButtonLiquidar.ForeColor = System.Drawing.Color.White
        Me.GestionCertificadoButtonLiquidar.Location = New System.Drawing.Point(671, 197)
        Me.GestionCertificadoButtonLiquidar.Name = "GestionCertificadoButtonLiquidar"
        Me.GestionCertificadoButtonLiquidar.Size = New System.Drawing.Size(192, 44)
        Me.GestionCertificadoButtonLiquidar.TabIndex = 180
        Me.GestionCertificadoButtonLiquidar.Text = "Liquidar"
        Me.GestionCertificadoButtonLiquidar.UseVisualStyleBackColor = True
        '
        'VGestionDeCertificados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1225, 505)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "VGestionDeCertificados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents GestionCertificadoButtonSumarReservas As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GestionCertificadoTextboxStatus As TextBox
    Friend WithEvents GestionCertificadoTextboxCed As TextBox
    Friend WithEvents GestionCertificadoTextboxNumAsociado As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents GestionCertificadoTextboxNombreCompleto As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents GestionCertificadoTextboxCedulaNumAsociado As TextBox
    Friend WithEvents GestionCertificadoButtonConsultar As Button
    Friend WithEvents GestionCertificadoButtonLimpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GestionCertificadoTextboxAcumuladoActual As TextBox
    Friend WithEvents GestionCertificadoButtonRetirarAcum As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CertificadosEnEstadoPendienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CertificadosEnEstadoReservasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeTodosLosEstadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FechasLímiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MontosMáximosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeCertificadosRetiradosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionCertificadoButtonNoRetirarAcum As Button
    Friend WithEvents GestionCertificadoButtonLiquidar As Button
End Class
