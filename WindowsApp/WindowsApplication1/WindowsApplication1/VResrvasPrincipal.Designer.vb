<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VResrvasPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VResrvasPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FechasLímiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReservasButtonGenerarInforme = New System.Windows.Forms.Button()
        Me.ReservasDateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.ReservasDateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FechasLímiteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(646, 24)
        Me.MenuStrip1.TabIndex = 148
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FechasLímiteToolStripMenuItem
        '
        Me.FechasLímiteToolStripMenuItem.Name = "FechasLímiteToolStripMenuItem"
        Me.FechasLímiteToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.FechasLímiteToolStripMenuItem.Text = "Fechas Límite"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 93)
        Me.Panel1.TabIndex = 149
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(209, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Cierre del Periodo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(163, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(159, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Desde"
        '
        'ReservasButtonGenerarInforme
        '
        Me.ReservasButtonGenerarInforme.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservasButtonGenerarInforme.ForeColor = System.Drawing.Color.White
        Me.ReservasButtonGenerarInforme.Location = New System.Drawing.Point(223, 260)
        Me.ReservasButtonGenerarInforme.Name = "ReservasButtonGenerarInforme"
        Me.ReservasButtonGenerarInforme.Size = New System.Drawing.Size(196, 52)
        Me.ReservasButtonGenerarInforme.TabIndex = 152
        Me.ReservasButtonGenerarInforme.Text = "Generar"
        Me.ReservasButtonGenerarInforme.UseVisualStyleBackColor = True
        '
        'ReservasDateTimePickerHasta
        '
        Me.ReservasDateTimePickerHasta.Enabled = False
        Me.ReservasDateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReservasDateTimePickerHasta.Location = New System.Drawing.Point(223, 192)
        Me.ReservasDateTimePickerHasta.Name = "ReservasDateTimePickerHasta"
        Me.ReservasDateTimePickerHasta.Size = New System.Drawing.Size(196, 20)
        Me.ReservasDateTimePickerHasta.TabIndex = 151
        '
        'ReservasDateTimePickerDesde
        '
        Me.ReservasDateTimePickerDesde.Enabled = False
        Me.ReservasDateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReservasDateTimePickerDesde.Location = New System.Drawing.Point(223, 161)
        Me.ReservasDateTimePickerDesde.Name = "ReservasDateTimePickerDesde"
        Me.ReservasDateTimePickerDesde.Size = New System.Drawing.Size(196, 20)
        Me.ReservasDateTimePickerDesde.TabIndex = 150
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 155
        '
        'VResrvasPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 386)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReservasButtonGenerarInforme)
        Me.Controls.Add(Me.ReservasDateTimePickerHasta)
        Me.Controls.Add(Me.ReservasDateTimePickerDesde)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VResrvasPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ReservasButtonGenerarInforme As Button
    Friend WithEvents ReservasDateTimePickerHasta As DateTimePicker
    Friend WithEvents ReservasDateTimePickerDesde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents FechasLímiteToolStripMenuItem As ToolStripMenuItem
End Class
