<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VInformeEconomico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VInformeEconomico))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InformeButtonGenerarInforme = New System.Windows.Forms.Button()
        Me.InformeDateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.InformeDateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
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
        'InformeButtonGenerarInforme
        '
        Me.InformeButtonGenerarInforme.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformeButtonGenerarInforme.ForeColor = System.Drawing.Color.White
        Me.InformeButtonGenerarInforme.Location = New System.Drawing.Point(256, 261)
        Me.InformeButtonGenerarInforme.Name = "InformeButtonGenerarInforme"
        Me.InformeButtonGenerarInforme.Size = New System.Drawing.Size(196, 52)
        Me.InformeButtonGenerarInforme.TabIndex = 44
        Me.InformeButtonGenerarInforme.Text = "Generar"
        Me.InformeButtonGenerarInforme.UseVisualStyleBackColor = True
        '
        'InformeDateTimePickerHasta
        '
        Me.InformeDateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.InformeDateTimePickerHasta.Location = New System.Drawing.Point(256, 180)
        Me.InformeDateTimePickerHasta.Name = "InformeDateTimePickerHasta"
        Me.InformeDateTimePickerHasta.Size = New System.Drawing.Size(196, 20)
        Me.InformeDateTimePickerHasta.TabIndex = 43
        '
        'InformeDateTimePickerDesde
        '
        Me.InformeDateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.InformeDateTimePickerDesde.Location = New System.Drawing.Point(256, 149)
        Me.InformeDateTimePickerDesde.Name = "InformeDateTimePickerDesde"
        Me.InformeDateTimePickerDesde.Size = New System.Drawing.Size(196, 20)
        Me.InformeDateTimePickerDesde.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(171, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(335, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Reporte Informe Económico"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 93)
        Me.Panel1.TabIndex = 47
        '
        'VInformeEconomico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 381)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.InformeButtonGenerarInforme)
        Me.Controls.Add(Me.InformeDateTimePickerHasta)
        Me.Controls.Add(Me.InformeDateTimePickerDesde)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VInformeEconomico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InformeButtonGenerarInforme As Button
    Friend WithEvents InformeDateTimePickerHasta As DateTimePicker
    Friend WithEvents InformeDateTimePickerDesde As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
End Class
