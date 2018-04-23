<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VCerrarPeriodoFechasLimite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VCerrarPeriodoFechasLimite))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CerrarPeriodoFechasDateTimePickerFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CerrarPeriodoFechasDateTimePickerFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCerrarPeriodoFechasGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CerrarPeriodoFechasDateTimePickerFechaFinal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CerrarPeriodoFechasDateTimePickerFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(162, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 144)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'CerrarPeriodoFechasDateTimePickerFechaFinal
        '
        Me.CerrarPeriodoFechasDateTimePickerFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CerrarPeriodoFechasDateTimePickerFechaFinal.Location = New System.Drawing.Point(94, 75)
        Me.CerrarPeriodoFechasDateTimePickerFechaFinal.Name = "CerrarPeriodoFechasDateTimePickerFechaFinal"
        Me.CerrarPeriodoFechasDateTimePickerFechaFinal.Size = New System.Drawing.Size(200, 20)
        Me.CerrarPeriodoFechasDateTimePickerFechaFinal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(42, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasta:"
        '
        'CerrarPeriodoFechasDateTimePickerFechaInicial
        '
        Me.CerrarPeriodoFechasDateTimePickerFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CerrarPeriodoFechasDateTimePickerFechaInicial.Location = New System.Drawing.Point(94, 34)
        Me.CerrarPeriodoFechasDateTimePickerFechaInicial.Name = "CerrarPeriodoFechasDateTimePickerFechaInicial"
        Me.CerrarPeriodoFechasDateTimePickerFechaInicial.Size = New System.Drawing.Size(200, 20)
        Me.CerrarPeriodoFechasDateTimePickerFechaInicial.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desde:"
        '
        'ButtonCerrarPeriodoFechasGuardar
        '
        Me.ButtonCerrarPeriodoFechasGuardar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonCerrarPeriodoFechasGuardar.ForeColor = System.Drawing.Color.White
        Me.ButtonCerrarPeriodoFechasGuardar.Location = New System.Drawing.Point(260, 254)
        Me.ButtonCerrarPeriodoFechasGuardar.Name = "ButtonCerrarPeriodoFechasGuardar"
        Me.ButtonCerrarPeriodoFechasGuardar.Size = New System.Drawing.Size(196, 52)
        Me.ButtonCerrarPeriodoFechasGuardar.TabIndex = 21
        Me.ButtonCerrarPeriodoFechasGuardar.Text = "Guardar"
        Me.ButtonCerrarPeriodoFechasGuardar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 93)
        Me.Panel1.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(125, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(404, 29)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Fechas Límite para Cerrar Periodo"
        '
        'VCerrarPeriodoFechasLimite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 410)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonCerrarPeriodoFechasGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VCerrarPeriodoFechasLimite"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonCerrarPeriodoFechasGuardar As Button
    Friend WithEvents CerrarPeriodoFechasDateTimePickerFechaFinal As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents CerrarPeriodoFechasDateTimePickerFechaInicial As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
End Class
