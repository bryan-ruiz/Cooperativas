<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VReportePAagosAlDia
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
        Me.TextBoxPagosAlDia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonReportePagosAlDia = New System.Windows.Forms.Button()
        Me.labelWait = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxPagosAlDia
        '
        Me.TextBoxPagosAlDia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPagosAlDia.Location = New System.Drawing.Point(190, 183)
        Me.TextBoxPagosAlDia.Name = "TextBoxPagosAlDia"
        Me.TextBoxPagosAlDia.Size = New System.Drawing.Size(321, 22)
        Me.TextBoxPagosAlDia.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(166, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "A la fecha actual los Asociados deben haber cancelado el total:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 93)
        Me.Panel1.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(209, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 29)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Reporte de Pagos al día"
        '
        'ButtonReportePagosAlDia
        '
        Me.ButtonReportePagosAlDia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonReportePagosAlDia.ForeColor = System.Drawing.Color.White
        Me.ButtonReportePagosAlDia.Location = New System.Drawing.Point(245, 265)
        Me.ButtonReportePagosAlDia.Name = "ButtonReportePagosAlDia"
        Me.ButtonReportePagosAlDia.Size = New System.Drawing.Size(196, 52)
        Me.ButtonReportePagosAlDia.TabIndex = 52
        Me.ButtonReportePagosAlDia.Text = "Generar"
        Me.ButtonReportePagosAlDia.UseVisualStyleBackColor = True
        '
        'labelWait
        '
        Me.labelWait.AutoSize = True
        Me.labelWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelWait.ForeColor = System.Drawing.Color.Red
        Me.labelWait.Location = New System.Drawing.Point(242, 364)
        Me.labelWait.Name = "labelWait"
        Me.labelWait.Size = New System.Drawing.Size(21, 20)
        Me.labelWait.TabIndex = 56
        Me.labelWait.Text = "..."
        '
        'VReportePAagosAlDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 404)
        Me.Controls.Add(Me.labelWait)
        Me.Controls.Add(Me.TextBoxPagosAlDia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonReportePagosAlDia)
        Me.Name = "VReportePAagosAlDia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxPagosAlDia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonReportePagosAlDia As Button
    Friend WithEvents labelWait As Label
End Class
