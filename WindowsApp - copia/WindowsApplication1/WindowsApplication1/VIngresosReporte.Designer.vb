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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_IngresosReporteIngresos
        '
        Me.Button_IngresosReporteIngresos.Location = New System.Drawing.Point(162, 185)
        Me.Button_IngresosReporteIngresos.Name = "Button_IngresosReporteIngresos"
        Me.Button_IngresosReporteIngresos.Size = New System.Drawing.Size(92, 28)
        Me.Button_IngresosReporteIngresos.TabIndex = 32
        Me.Button_IngresosReporteIngresos.Text = "Generar"
        Me.Button_IngresosReporteIngresos.UseVisualStyleBackColor = True
        '
        'DateTimePicker_IngresosFechaFinal
        '
        Me.DateTimePicker_IngresosFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_IngresosFechaFinal.Location = New System.Drawing.Point(124, 125)
        Me.DateTimePicker_IngresosFechaFinal.Name = "DateTimePicker_IngresosFechaFinal"
        Me.DateTimePicker_IngresosFechaFinal.Size = New System.Drawing.Size(214, 20)
        Me.DateTimePicker_IngresosFechaFinal.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.Location = New System.Drawing.Point(52, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Hasta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(52, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Desde"
        '
        'DateTimePicker_IngresosFechaInicio
        '
        Me.DateTimePicker_IngresosFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_IngresosFechaInicio.Location = New System.Drawing.Point(124, 94)
        Me.DateTimePicker_IngresosFechaInicio.Name = "DateTimePicker_IngresosFechaInicio"
        Me.DateTimePicker_IngresosFechaInicio.Size = New System.Drawing.Size(214, 20)
        Me.DateTimePicker_IngresosFechaInicio.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(106, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Generar Reporte de Entradas"
        '
        'VIngresosReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(426, 278)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_IngresosReporteIngresos)
        Me.Controls.Add(Me.DateTimePicker_IngresosFechaFinal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker_IngresosFechaInicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VIngresosReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Entradas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_IngresosReporteIngresos As Button
    Friend WithEvents DateTimePicker_IngresosFechaFinal As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker_IngresosFechaInicio As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
