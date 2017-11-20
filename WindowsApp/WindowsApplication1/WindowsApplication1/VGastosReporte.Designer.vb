<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VGastosReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VGastosReporte))
        Me.ButtonGastosReporte = New System.Windows.Forms.Button()
        Me.DateTimePicker_GastosFechaF = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker_GastosFechaI = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonGastosReporte
        '
        Me.ButtonGastosReporte.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonGastosReporte.ForeColor = System.Drawing.Color.White
        Me.ButtonGastosReporte.Location = New System.Drawing.Point(244, 262)
        Me.ButtonGastosReporte.Name = "ButtonGastosReporte"
        Me.ButtonGastosReporte.Size = New System.Drawing.Size(196, 52)
        Me.ButtonGastosReporte.TabIndex = 38
        Me.ButtonGastosReporte.Text = "Generar"
        Me.ButtonGastosReporte.UseVisualStyleBackColor = True
        '
        'DateTimePicker_GastosFechaF
        '
        Me.DateTimePicker_GastosFechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_GastosFechaF.Location = New System.Drawing.Point(244, 183)
        Me.DateTimePicker_GastosFechaF.Name = "DateTimePicker_GastosFechaF"
        Me.DateTimePicker_GastosFechaF.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker_GastosFechaF.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.Location = New System.Drawing.Point(-44, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Hasta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(-44, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Desde"
        '
        'DateTimePicker_GastosFechaI
        '
        Me.DateTimePicker_GastosFechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_GastosFechaI.Location = New System.Drawing.Point(244, 152)
        Me.DateTimePicker_GastosFechaI.Name = "DateTimePicker_GastosFechaI"
        Me.DateTimePicker_GastosFechaI.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker_GastosFechaI.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(183, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(180, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Desde"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 93)
        Me.Panel1.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(221, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 29)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Reporte de Salidas"
        '
        'VGastosReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(666, 377)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonGastosReporte)
        Me.Controls.Add(Me.DateTimePicker_GastosFechaF)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker_GastosFechaI)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VGastosReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Salidas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonGastosReporte As Button
    Friend WithEvents DateTimePicker_GastosFechaF As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker_GastosFechaI As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
