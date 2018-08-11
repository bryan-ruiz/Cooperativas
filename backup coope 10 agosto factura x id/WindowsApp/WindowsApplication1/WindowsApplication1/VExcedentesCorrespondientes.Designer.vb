<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VExcedentesCorrespondientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VExcedentesCorrespondientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExcedentesCorrespButtonGenerarReporteExc = New System.Windows.Forms.Button()
        Me.ExcedentesCorrespDateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.ExcedentesCorrespDateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(196, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(192, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Desde"
        '
        'ExcedentesCorrespButtonGenerarReporteExc
        '
        Me.ExcedentesCorrespButtonGenerarReporteExc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExcedentesCorrespButtonGenerarReporteExc.ForeColor = System.Drawing.Color.White
        Me.ExcedentesCorrespButtonGenerarReporteExc.Location = New System.Drawing.Point(256, 261)
        Me.ExcedentesCorrespButtonGenerarReporteExc.Name = "ExcedentesCorrespButtonGenerarReporteExc"
        Me.ExcedentesCorrespButtonGenerarReporteExc.Size = New System.Drawing.Size(196, 52)
        Me.ExcedentesCorrespButtonGenerarReporteExc.TabIndex = 44
        Me.ExcedentesCorrespButtonGenerarReporteExc.Text = "Generar"
        Me.ExcedentesCorrespButtonGenerarReporteExc.UseVisualStyleBackColor = True
        '
        'ExcedentesCorrespDateTimePickerHasta
        '
        Me.ExcedentesCorrespDateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ExcedentesCorrespDateTimePickerHasta.Location = New System.Drawing.Point(256, 180)
        Me.ExcedentesCorrespDateTimePickerHasta.Name = "ExcedentesCorrespDateTimePickerHasta"
        Me.ExcedentesCorrespDateTimePickerHasta.Size = New System.Drawing.Size(196, 20)
        Me.ExcedentesCorrespDateTimePickerHasta.TabIndex = 43
        '
        'ExcedentesCorrespDateTimePickerDesde
        '
        Me.ExcedentesCorrespDateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ExcedentesCorrespDateTimePickerDesde.Location = New System.Drawing.Point(256, 149)
        Me.ExcedentesCorrespDateTimePickerDesde.Name = "ExcedentesCorrespDateTimePickerDesde"
        Me.ExcedentesCorrespDateTimePickerDesde.Size = New System.Drawing.Size(196, 20)
        Me.ExcedentesCorrespDateTimePickerDesde.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(120, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(454, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Reporte Excedentes Correspondientes"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 93)
        Me.Panel1.TabIndex = 47
        '
        'VExcedentesCorrespondientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 381)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ExcedentesCorrespButtonGenerarReporteExc)
        Me.Controls.Add(Me.ExcedentesCorrespDateTimePickerHasta)
        Me.Controls.Add(Me.ExcedentesCorrespDateTimePickerDesde)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VExcedentesCorrespondientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ExcedentesCorrespButtonGenerarReporteExc As Button
    Friend WithEvents ExcedentesCorrespDateTimePickerHasta As DateTimePicker
    Friend WithEvents ExcedentesCorrespDateTimePickerDesde As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
End Class
