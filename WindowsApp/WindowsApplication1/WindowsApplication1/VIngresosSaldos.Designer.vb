<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VIngresosSaldos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VIngresosSaldos))
        Me.Button_ReporteSaldos = New System.Windows.Forms.Button()
        Me.DateTimePicker_SaldosFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker_SaldosFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_ReporteSaldos
        '
        Me.Button_ReporteSaldos.Location = New System.Drawing.Point(162, 185)
        Me.Button_ReporteSaldos.Name = "Button_ReporteSaldos"
        Me.Button_ReporteSaldos.Size = New System.Drawing.Size(92, 28)
        Me.Button_ReporteSaldos.TabIndex = 32
        Me.Button_ReporteSaldos.Text = "Generar"
        Me.Button_ReporteSaldos.UseVisualStyleBackColor = True
        '
        'DateTimePicker_SaldosFechaFinal
        '
        Me.DateTimePicker_SaldosFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_SaldosFechaFinal.Location = New System.Drawing.Point(124, 125)
        Me.DateTimePicker_SaldosFechaFinal.Name = "DateTimePicker_SaldosFechaFinal"
        Me.DateTimePicker_SaldosFechaFinal.Size = New System.Drawing.Size(214, 20)
        Me.DateTimePicker_SaldosFechaFinal.TabIndex = 31
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
        'DateTimePicker_SaldosFechaInicio
        '
        Me.DateTimePicker_SaldosFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_SaldosFechaInicio.Location = New System.Drawing.Point(124, 94)
        Me.DateTimePicker_SaldosFechaInicio.Name = "DateTimePicker_SaldosFechaInicio"
        Me.DateTimePicker_SaldosFechaInicio.Size = New System.Drawing.Size(214, 20)
        Me.DateTimePicker_SaldosFechaInicio.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(121, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Generar Reporte de Saldos"
        '
        'VIngresosSaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(426, 278)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_ReporteSaldos)
        Me.Controls.Add(Me.DateTimePicker_SaldosFechaFinal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker_SaldosFechaInicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VIngresosSaldos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Entradas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_ReporteSaldos As Button
    Friend WithEvents DateTimePicker_SaldosFechaFinal As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker_SaldosFechaInicio As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
