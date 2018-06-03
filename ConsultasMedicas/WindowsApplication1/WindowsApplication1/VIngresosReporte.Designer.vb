<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VIngresosReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VIngresosReporte))
        Me.Button_IngresosReporteIngresos = New System.Windows.Forms.Button()
        Me.DateTimePicker_IngresosFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker_IngresosFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_IngresosReporteIngresos
        '
        Me.Button_IngresosReporteIngresos.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button_IngresosReporteIngresos.ForeColor = System.Drawing.Color.White
        Me.Button_IngresosReporteIngresos.Location = New System.Drawing.Point(247, 259)
        Me.Button_IngresosReporteIngresos.Name = "Button_IngresosReporteIngresos"
        Me.Button_IngresosReporteIngresos.Size = New System.Drawing.Size(196, 52)
        Me.Button_IngresosReporteIngresos.TabIndex = 32
        Me.Button_IngresosReporteIngresos.Text = "Generar"
        Me.Button_IngresosReporteIngresos.UseVisualStyleBackColor = True
        '
        'DateTimePicker_IngresosFechaFinal
        '
        Me.DateTimePicker_IngresosFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_IngresosFechaFinal.Location = New System.Drawing.Point(247, 179)
        Me.DateTimePicker_IngresosFechaFinal.Name = "DateTimePicker_IngresosFechaFinal"
        Me.DateTimePicker_IngresosFechaFinal.Size = New System.Drawing.Size(198, 20)
        Me.DateTimePicker_IngresosFechaFinal.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(179, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Hasta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(175, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Desde"
        '
        'DateTimePicker_IngresosFechaInicio
        '
        Me.DateTimePicker_IngresosFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_IngresosFechaInicio.Location = New System.Drawing.Point(247, 148)
        Me.DateTimePicker_IngresosFechaInicio.Name = "DateTimePicker_IngresosFechaInicio"
        Me.DateTimePicker_IngresosFechaInicio.Size = New System.Drawing.Size(198, 20)
        Me.DateTimePicker_IngresosFechaInicio.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 93)
        Me.Panel1.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(223, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(247, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Reporte de Entradas"
        '
        'VIngresosReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 381)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_IngresosReporteIngresos)
        Me.Controls.Add(Me.DateTimePicker_IngresosFechaFinal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker_IngresosFechaInicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VIngresosReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_IngresosReporteIngresos As Button
    Friend WithEvents DateTimePicker_IngresosFechaFinal As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker_IngresosFechaInicio As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
End Class
