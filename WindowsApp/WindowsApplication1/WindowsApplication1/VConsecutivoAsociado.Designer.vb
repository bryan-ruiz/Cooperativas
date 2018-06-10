<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VConsecutivoAsociado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VConsecutivoAsociado))
        Me.ButtonConsecutivoAsociadosGuardar = New System.Windows.Forms.Button()
        Me.ConsecutivoAsociadosTextboxConsecutivo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ConsecutivoAsociadosTextboxAno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonConsecutivoAsociadosGuardar
        '
        Me.ButtonConsecutivoAsociadosGuardar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonConsecutivoAsociadosGuardar.ForeColor = System.Drawing.Color.White
        Me.ButtonConsecutivoAsociadosGuardar.Location = New System.Drawing.Point(232, 361)
        Me.ButtonConsecutivoAsociadosGuardar.Name = "ButtonConsecutivoAsociadosGuardar"
        Me.ButtonConsecutivoAsociadosGuardar.Size = New System.Drawing.Size(196, 52)
        Me.ButtonConsecutivoAsociadosGuardar.TabIndex = 57
        Me.ButtonConsecutivoAsociadosGuardar.Text = "Guardar"
        Me.ButtonConsecutivoAsociadosGuardar.UseVisualStyleBackColor = True
        '
        'ConsecutivoAsociadosTextboxConsecutivo
        '
        Me.ConsecutivoAsociadosTextboxConsecutivo.Location = New System.Drawing.Point(168, 232)
        Me.ConsecutivoAsociadosTextboxConsecutivo.Name = "ConsecutivoAsociadosTextboxConsecutivo"
        Me.ConsecutivoAsociadosTextboxConsecutivo.Size = New System.Drawing.Size(318, 20)
        Me.ConsecutivoAsociadosTextboxConsecutivo.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(124, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(417, 19)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "El num de Asociado se forma con el consecutivo seguido del año."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 93)
        Me.Panel1.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(163, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(319, 29)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Consecutivo de Asociados"
        '
        'ConsecutivoAsociadosTextboxAno
        '
        Me.ConsecutivoAsociadosTextboxAno.Location = New System.Drawing.Point(168, 304)
        Me.ConsecutivoAsociadosTextboxAno.Name = "ConsecutivoAsociadosTextboxAno"
        Me.ConsecutivoAsociadosTextboxAno.Size = New System.Drawing.Size(318, 20)
        Me.ConsecutivoAsociadosTextboxAno.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(168, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 19)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Año:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(168, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Consecutivo:"
        '
        'VConsecutivoAsociado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 445)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConsecutivoAsociadosTextboxAno)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonConsecutivoAsociadosGuardar)
        Me.Controls.Add(Me.ConsecutivoAsociadosTextboxConsecutivo)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VConsecutivoAsociado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonConsecutivoAsociadosGuardar As Button
    Friend WithEvents ConsecutivoAsociadosTextboxConsecutivo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents ConsecutivoAsociadosTextboxAno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
