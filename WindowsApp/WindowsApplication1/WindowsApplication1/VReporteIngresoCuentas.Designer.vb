<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VReporteIngresoCuentas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_IngresoCuentasReporte_aceptar = New System.Windows.Forms.Button()
        Me.DateTimePicker_IngresoCuentasReporte_ff = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_IngresoCuentasReporte_fi = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(2, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 93)
        Me.Panel1.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(138, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(381, 29)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Reporte de Ingresos de Cuentas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(185, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(182, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Desde"
        '
        'Button_IngresoCuentasReporte_aceptar
        '
        Me.Button_IngresoCuentasReporte_aceptar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button_IngresoCuentasReporte_aceptar.ForeColor = System.Drawing.Color.White
        Me.Button_IngresoCuentasReporte_aceptar.Location = New System.Drawing.Point(246, 266)
        Me.Button_IngresoCuentasReporte_aceptar.Name = "Button_IngresoCuentasReporte_aceptar"
        Me.Button_IngresoCuentasReporte_aceptar.Size = New System.Drawing.Size(196, 52)
        Me.Button_IngresoCuentasReporte_aceptar.TabIndex = 52
        Me.Button_IngresoCuentasReporte_aceptar.Text = "Generar"
        Me.Button_IngresoCuentasReporte_aceptar.UseVisualStyleBackColor = True
        '
        'DateTimePicker_IngresoCuentasReporte_ff
        '
        Me.DateTimePicker_IngresoCuentasReporte_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_IngresoCuentasReporte_ff.Location = New System.Drawing.Point(246, 187)
        Me.DateTimePicker_IngresoCuentasReporte_ff.Name = "DateTimePicker_IngresoCuentasReporte_ff"
        Me.DateTimePicker_IngresoCuentasReporte_ff.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker_IngresoCuentasReporte_ff.TabIndex = 51
        '
        'DateTimePicker_IngresoCuentasReporte_fi
        '
        Me.DateTimePicker_IngresoCuentasReporte_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_IngresoCuentasReporte_fi.Location = New System.Drawing.Point(246, 156)
        Me.DateTimePicker_IngresoCuentasReporte_fi.Name = "DateTimePicker_IngresoCuentasReporte_fi"
        Me.DateTimePicker_IngresoCuentasReporte_fi.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker_IngresoCuentasReporte_fi.TabIndex = 50
        '
        'VReporteIngresoCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 445)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_IngresoCuentasReporte_aceptar)
        Me.Controls.Add(Me.DateTimePicker_IngresoCuentasReporte_ff)
        Me.Controls.Add(Me.DateTimePicker_IngresoCuentasReporte_fi)
        Me.Name = "VReporteIngresoCuentas"
        Me.Text = "VReporteIngresoCuentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_IngresoCuentasReporte_aceptar As Button
    Friend WithEvents DateTimePicker_IngresoCuentasReporte_ff As DateTimePicker
    Friend WithEvents DateTimePicker_IngresoCuentasReporte_fi As DateTimePicker
End Class
