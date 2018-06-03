<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VGestionDeReservas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_reservasGestion = New System.Windows.Forms.ComboBox()
        Me.TextBox_ReservasGestionMontoActual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldosDeReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcumuladoEnReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(1, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 93)
        Me.Panel1.TabIndex = 150
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(201, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(249, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Gestión de Reservas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(184, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 171
        Me.Label4.Text = "Reserva:"
        '
        'ComboBox_reservasGestion
        '
        Me.ComboBox_reservasGestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_reservasGestion.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_reservasGestion.FormattingEnabled = True
        Me.ComboBox_reservasGestion.Location = New System.Drawing.Point(181, 221)
        Me.ComboBox_reservasGestion.Name = "ComboBox_reservasGestion"
        Me.ComboBox_reservasGestion.Size = New System.Drawing.Size(275, 27)
        Me.ComboBox_reservasGestion.TabIndex = 170
        '
        'TextBox_ReservasGestionMontoActual
        '
        Me.TextBox_ReservasGestionMontoActual.CausesValidation = False
        Me.TextBox_ReservasGestionMontoActual.Enabled = False
        Me.TextBox_ReservasGestionMontoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ReservasGestionMontoActual.Location = New System.Drawing.Point(181, 316)
        Me.TextBox_ReservasGestionMontoActual.Multiline = True
        Me.TextBox_ReservasGestionMontoActual.Name = "TextBox_ReservasGestionMontoActual"
        Me.TextBox_ReservasGestionMontoActual.Size = New System.Drawing.Size(275, 29)
        Me.TextBox_ReservasGestionMontoActual.TabIndex = 176
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(184, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Monto Actual: "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradasToolStripMenuItem, Me.SalidasToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(647, 24)
        Me.MenuStrip1.TabIndex = 177
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.EntradasToolStripMenuItem.Text = "Entradas"
        '
        'SalidasToolStripMenuItem
        '
        Me.SalidasToolStripMenuItem.Name = "SalidasToolStripMenuItem"
        Me.SalidasToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.SalidasToolStripMenuItem.Text = "Salidas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaldosDeReservasToolStripMenuItem, Me.AcumuladoEnReservasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'SaldosDeReservasToolStripMenuItem
        '
        Me.SaldosDeReservasToolStripMenuItem.Name = "SaldosDeReservasToolStripMenuItem"
        Me.SaldosDeReservasToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SaldosDeReservasToolStripMenuItem.Text = "Reporte - Saldos de Reservas"
        '
        'AcumuladoEnReservasToolStripMenuItem
        '
        Me.AcumuladoEnReservasToolStripMenuItem.Name = "AcumuladoEnReservasToolStripMenuItem"
        Me.AcumuladoEnReservasToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.AcumuladoEnReservasToolStripMenuItem.Text = "Reporte - Total Acumulado"
        '
        'VGestionDeReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(646, 468)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox_ReservasGestionMontoActual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox_reservasGestion)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "VGestionDeReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_reservasGestion As ComboBox
    Friend WithEvents TextBox_ReservasGestionMontoActual As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaldosDeReservasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcumuladoEnReservasToolStripMenuItem As ToolStripMenuItem
End Class
