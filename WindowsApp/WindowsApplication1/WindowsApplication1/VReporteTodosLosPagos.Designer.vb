<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VReporteTodosLosPagos
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
        Me.TextBoxTodosLosPagos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonReporteTodosLosPagos = New System.Windows.Forms.Button()
        Me.labelWait = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxTodosLosPagos
        '
        Me.TextBoxTodosLosPagos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTodosLosPagos.Location = New System.Drawing.Point(192, 182)
        Me.TextBoxTodosLosPagos.Name = "TextBoxTodosLosPagos"
        Me.TextBoxTodosLosPagos.Size = New System.Drawing.Size(321, 22)
        Me.TextBoxTodosLosPagos.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(168, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "A la fecha actual los Asociados deben haber cancelado el total:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
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
        Me.Label3.Location = New System.Drawing.Point(122, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(460, 29)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Reporte de Todos los pagos realizados"
        '
        'ButtonReporteTodosLosPagos
        '
        Me.ButtonReporteTodosLosPagos.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonReporteTodosLosPagos.ForeColor = System.Drawing.Color.White
        Me.ButtonReporteTodosLosPagos.Location = New System.Drawing.Point(247, 264)
        Me.ButtonReporteTodosLosPagos.Name = "ButtonReporteTodosLosPagos"
        Me.ButtonReporteTodosLosPagos.Size = New System.Drawing.Size(196, 52)
        Me.ButtonReporteTodosLosPagos.TabIndex = 52
        Me.ButtonReporteTodosLosPagos.Text = "Generar"
        Me.ButtonReporteTodosLosPagos.UseVisualStyleBackColor = True
        '
        'labelWait
        '
        Me.labelWait.AutoSize = True
        Me.labelWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelWait.ForeColor = System.Drawing.Color.Red
        Me.labelWait.Location = New System.Drawing.Point(216, 359)
        Me.labelWait.Name = "labelWait"
        Me.labelWait.Size = New System.Drawing.Size(21, 20)
        Me.labelWait.TabIndex = 57
        Me.labelWait.Text = "..."
        '
        'VReporteTodosLosPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 409)
        Me.Controls.Add(Me.labelWait)
        Me.Controls.Add(Me.TextBoxTodosLosPagos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonReporteTodosLosPagos)
        Me.Name = "VReporteTodosLosPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxTodosLosPagos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonReporteTodosLosPagos As Button
    Friend WithEvents labelWait As Label
End Class
