﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VGestionDeExcedentes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VGestionDeExcedentes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GestionExcButtonSumarAReservas = New System.Windows.Forms.Button()
        Me.GestionExcButtonSumarAlAcumulado = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GestionExcButtonRetirarExcedente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GestionExcTextboxExcCorrespondiente = New System.Windows.Forms.TextBox()
        Me.GestionExcTextboxStatus = New System.Windows.Forms.TextBox()
        Me.GestionExcTextboxCed = New System.Windows.Forms.TextBox()
        Me.GestionExcTextboxNumAsociado = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GestionExcTextboxNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GestionExcTextboxCedulaNumAsociado = New System.Windows.Forms.TextBox()
        Me.GestionExcButtonConsultar = New System.Windows.Forms.Button()
        Me.GestionExcButtonLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcedentesEnEstadoPendienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcedentesEnEstadoRetiradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcedentesEnEstadoAcumuladoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcedentesEnEstadoReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeTodosLosEstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label9.Size = New System.Drawing.Size(413, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Gestión de Excedentes en Tránsito"
        '
        'GestionExcButtonSumarAReservas
        '
        Me.GestionExcButtonSumarAReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GestionExcButtonSumarAReservas.ForeColor = System.Drawing.Color.White
        Me.GestionExcButtonSumarAReservas.Location = New System.Drawing.Point(599, 197)
        Me.GestionExcButtonSumarAReservas.Name = "GestionExcButtonSumarAReservas"
        Me.GestionExcButtonSumarAReservas.Size = New System.Drawing.Size(187, 44)
        Me.GestionExcButtonSumarAReservas.TabIndex = 173
        Me.GestionExcButtonSumarAReservas.Text = "Sumar a Reservas"
        Me.GestionExcButtonSumarAReservas.UseVisualStyleBackColor = True
        '
        'GestionExcButtonSumarAlAcumulado
        '
        Me.GestionExcButtonSumarAlAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GestionExcButtonSumarAlAcumulado.ForeColor = System.Drawing.Color.White
        Me.GestionExcButtonSumarAlAcumulado.Location = New System.Drawing.Point(349, 197)
        Me.GestionExcButtonSumarAlAcumulado.Name = "GestionExcButtonSumarAlAcumulado"
        Me.GestionExcButtonSumarAlAcumulado.Size = New System.Drawing.Size(205, 44)
        Me.GestionExcButtonSumarAlAcumulado.TabIndex = 174
        Me.GestionExcButtonSumarAlAcumulado.Text = "Sumar al Acumulado"
        Me.GestionExcButtonSumarAlAcumulado.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.GestionExcButtonRetirarExcedente)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.GestionExcTextboxExcCorrespondiente)
        Me.GroupBox2.Controls.Add(Me.GestionExcButtonSumarAReservas)
        Me.GroupBox2.Controls.Add(Me.GestionExcButtonSumarAlAcumulado)
        Me.GroupBox2.Controls.Add(Me.GestionExcTextboxStatus)
        Me.GroupBox2.Controls.Add(Me.GestionExcTextboxCed)
        Me.GroupBox2.Controls.Add(Me.GestionExcTextboxNumAsociado)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GestionExcTextboxNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(300, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(915, 287)
        Me.GroupBox2.TabIndex = 176
        Me.GroupBox2.TabStop = False
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
        'GestionExcButtonRetirarExcedente
        '
        Me.GestionExcButtonRetirarExcedente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GestionExcButtonRetirarExcedente.ForeColor = System.Drawing.Color.White
        Me.GestionExcButtonRetirarExcedente.Location = New System.Drawing.Point(111, 197)
        Me.GestionExcButtonRetirarExcedente.Name = "GestionExcButtonRetirarExcedente"
        Me.GestionExcButtonRetirarExcedente.Size = New System.Drawing.Size(187, 44)
        Me.GestionExcButtonRetirarExcedente.TabIndex = 175
        Me.GestionExcButtonRetirarExcedente.Text = "Retirar Excedente"
        Me.GestionExcButtonRetirarExcedente.UseVisualStyleBackColor = True
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
        'GestionExcTextboxExcCorrespondiente
        '
        Me.GestionExcTextboxExcCorrespondiente.Enabled = False
        Me.GestionExcTextboxExcCorrespondiente.Location = New System.Drawing.Point(599, 82)
        Me.GestionExcTextboxExcCorrespondiente.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionExcTextboxExcCorrespondiente.Multiline = True
        Me.GestionExcTextboxExcCorrespondiente.Name = "GestionExcTextboxExcCorrespondiente"
        Me.GestionExcTextboxExcCorrespondiente.Size = New System.Drawing.Size(122, 20)
        Me.GestionExcTextboxExcCorrespondiente.TabIndex = 140
        '
        'GestionExcTextboxStatus
        '
        Me.GestionExcTextboxStatus.Enabled = False
        Me.GestionExcTextboxStatus.Location = New System.Drawing.Point(725, 82)
        Me.GestionExcTextboxStatus.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionExcTextboxStatus.Multiline = True
        Me.GestionExcTextboxStatus.Name = "GestionExcTextboxStatus"
        Me.GestionExcTextboxStatus.Size = New System.Drawing.Size(144, 20)
        Me.GestionExcTextboxStatus.TabIndex = 139
        '
        'GestionExcTextboxCed
        '
        Me.GestionExcTextboxCed.Enabled = False
        Me.GestionExcTextboxCed.Location = New System.Drawing.Point(154, 82)
        Me.GestionExcTextboxCed.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionExcTextboxCed.Name = "GestionExcTextboxCed"
        Me.GestionExcTextboxCed.Size = New System.Drawing.Size(144, 20)
        Me.GestionExcTextboxCed.TabIndex = 138
        '
        'GestionExcTextboxNumAsociado
        '
        Me.GestionExcTextboxNumAsociado.Enabled = False
        Me.GestionExcTextboxNumAsociado.Location = New System.Drawing.Point(6, 82)
        Me.GestionExcTextboxNumAsociado.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionExcTextboxNumAsociado.Name = "GestionExcTextboxNumAsociado"
        Me.GestionExcTextboxNumAsociado.Size = New System.Drawing.Size(144, 20)
        Me.GestionExcTextboxNumAsociado.TabIndex = 124
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
        Me.Label1.Location = New System.Drawing.Point(601, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 30)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "      Excedente " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Correspondiente"
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
        'GestionExcTextboxNombre
        '
        Me.GestionExcTextboxNombre.Enabled = False
        Me.GestionExcTextboxNombre.Location = New System.Drawing.Point(302, 82)
        Me.GestionExcTextboxNombre.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionExcTextboxNombre.Name = "GestionExcTextboxNombre"
        Me.GestionExcTextboxNombre.Size = New System.Drawing.Size(275, 20)
        Me.GestionExcTextboxNombre.TabIndex = 63
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.GestionExcTextboxCedulaNumAsociado)
        Me.GroupBox1.Controls.Add(Me.GestionExcButtonConsultar)
        Me.GroupBox1.Controls.Add(Me.GestionExcButtonLimpiar)
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
        Me.Label22.Location = New System.Drawing.Point(7, 51)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(203, 15)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "Cédula (x-xxxx-xxxx) / # Asociado:"
        '
        'GestionExcTextboxCedulaNumAsociado
        '
        Me.GestionExcTextboxCedulaNumAsociado.Location = New System.Drawing.Point(9, 74)
        Me.GestionExcTextboxCedulaNumAsociado.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionExcTextboxCedulaNumAsociado.Name = "GestionExcTextboxCedulaNumAsociado"
        Me.GestionExcTextboxCedulaNumAsociado.Size = New System.Drawing.Size(203, 22)
        Me.GestionExcTextboxCedulaNumAsociado.TabIndex = 54
        '
        'GestionExcButtonConsultar
        '
        Me.GestionExcButtonConsultar.Image = Global.WindowsApplication1.My.Resources.Resources.find81
        Me.GestionExcButtonConsultar.Location = New System.Drawing.Point(216, 68)
        Me.GestionExcButtonConsultar.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionExcButtonConsultar.Name = "GestionExcButtonConsultar"
        Me.GestionExcButtonConsultar.Size = New System.Drawing.Size(55, 38)
        Me.GestionExcButtonConsultar.TabIndex = 55
        Me.GestionExcButtonConsultar.UseVisualStyleBackColor = True
        '
        'GestionExcButtonLimpiar
        '
        Me.GestionExcButtonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GestionExcButtonLimpiar.ForeColor = System.Drawing.Color.White
        Me.GestionExcButtonLimpiar.Image = Global.WindowsApplication1.My.Resources.Resources.cleanlast2
        Me.GestionExcButtonLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GestionExcButtonLimpiar.Location = New System.Drawing.Point(25, 199)
        Me.GestionExcButtonLimpiar.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GestionExcButtonLimpiar.Name = "GestionExcButtonLimpiar"
        Me.GestionExcButtonLimpiar.Size = New System.Drawing.Size(187, 44)
        Me.GestionExcButtonLimpiar.TabIndex = 58
        Me.GestionExcButtonLimpiar.Text = "Limpiar Campos"
        Me.GestionExcButtonLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GestionExcButtonLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 480)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(588, 16)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "Nota: Al sumar el excedente a Reservas, se asigna un 50% a Educación y 50% a Bien" &
    "estar Social"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1224, 24)
        Me.MenuStrip1.TabIndex = 180
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcedentesEnEstadoPendienteToolStripMenuItem, Me.ExcedentesEnEstadoRetiradoToolStripMenuItem, Me.ExcedentesEnEstadoAcumuladoToolStripMenuItem, Me.ExcedentesEnEstadoReservasToolStripMenuItem, Me.ReporteDeTodosLosEstadosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ExcedentesEnEstadoPendienteToolStripMenuItem
        '
        Me.ExcedentesEnEstadoPendienteToolStripMenuItem.Name = "ExcedentesEnEstadoPendienteToolStripMenuItem"
        Me.ExcedentesEnEstadoPendienteToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.ExcedentesEnEstadoPendienteToolStripMenuItem.Text = "Reporte de excedentes - Pendientes"
        '
        'ExcedentesEnEstadoRetiradoToolStripMenuItem
        '
        Me.ExcedentesEnEstadoRetiradoToolStripMenuItem.Name = "ExcedentesEnEstadoRetiradoToolStripMenuItem"
        Me.ExcedentesEnEstadoRetiradoToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.ExcedentesEnEstadoRetiradoToolStripMenuItem.Text = "Reporte de excedentes - Retirados"
        '
        'ExcedentesEnEstadoAcumuladoToolStripMenuItem
        '
        Me.ExcedentesEnEstadoAcumuladoToolStripMenuItem.Name = "ExcedentesEnEstadoAcumuladoToolStripMenuItem"
        Me.ExcedentesEnEstadoAcumuladoToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.ExcedentesEnEstadoAcumuladoToolStripMenuItem.Text = "Reporte de excedentes - en Acumulado"
        '
        'ExcedentesEnEstadoReservasToolStripMenuItem
        '
        Me.ExcedentesEnEstadoReservasToolStripMenuItem.Name = "ExcedentesEnEstadoReservasToolStripMenuItem"
        Me.ExcedentesEnEstadoReservasToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.ExcedentesEnEstadoReservasToolStripMenuItem.Text = "Reporte de excedentes - en Reservas"
        '
        'ReporteDeTodosLosEstadosToolStripMenuItem
        '
        Me.ReporteDeTodosLosEstadosToolStripMenuItem.Name = "ReporteDeTodosLosEstadosToolStripMenuItem"
        Me.ReporteDeTodosLosEstadosToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.ReporteDeTodosLosEstadosToolStripMenuItem.Text = "Reporte de Todos los Estados"
        '
        'VGestionDeExcedentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 505)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "VGestionDeExcedentes"
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
    Friend WithEvents GestionExcButtonSumarAReservas As Button
    Friend WithEvents GestionExcButtonSumarAlAcumulado As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GestionExcTextboxStatus As TextBox
    Friend WithEvents GestionExcTextboxCed As TextBox
    Friend WithEvents GestionExcTextboxNumAsociado As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents GestionExcTextboxNombre As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents GestionExcTextboxCedulaNumAsociado As TextBox
    Friend WithEvents GestionExcButtonConsultar As Button
    Friend WithEvents GestionExcButtonLimpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GestionExcTextboxExcCorrespondiente As TextBox
    Friend WithEvents GestionExcButtonRetirarExcedente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcedentesEnEstadoPendienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcedentesEnEstadoRetiradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcedentesEnEstadoAcumuladoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcedentesEnEstadoReservasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeTodosLosEstadosToolStripMenuItem As ToolStripMenuItem
End Class