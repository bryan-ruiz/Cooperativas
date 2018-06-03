<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VMontoCertificados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VMontoCertificados))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.MontoCertificadosTextboxPeriodo = New System.Windows.Forms.TextBox()
        Me.MontoCertificadosTextboxTracto = New System.Windows.Forms.TextBox()
        Me.ButtonMontoCertificado = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Location = New System.Drawing.Point(-3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 87)
        Me.Panel1.TabIndex = 181
        '
        'Label31
        '
        Me.Label31.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(194, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(300, 29)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "Monto de Certificaciones"
        '
        'MontoCertificadosTextboxPeriodo
        '
        Me.MontoCertificadosTextboxPeriodo.Location = New System.Drawing.Point(318, 158)
        Me.MontoCertificadosTextboxPeriodo.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MontoCertificadosTextboxPeriodo.Name = "MontoCertificadosTextboxPeriodo"
        Me.MontoCertificadosTextboxPeriodo.Size = New System.Drawing.Size(197, 20)
        Me.MontoCertificadosTextboxPeriodo.TabIndex = 182
        '
        'MontoCertificadosTextboxTracto
        '
        Me.MontoCertificadosTextboxTracto.Location = New System.Drawing.Point(318, 236)
        Me.MontoCertificadosTextboxTracto.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MontoCertificadosTextboxTracto.Name = "MontoCertificadosTextboxTracto"
        Me.MontoCertificadosTextboxTracto.Size = New System.Drawing.Size(197, 20)
        Me.MontoCertificadosTextboxTracto.TabIndex = 183
        '
        'ButtonMontoCertificado
        '
        Me.ButtonMontoCertificado.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonMontoCertificado.ForeColor = System.Drawing.Color.White
        Me.ButtonMontoCertificado.Location = New System.Drawing.Point(267, 308)
        Me.ButtonMontoCertificado.Name = "ButtonMontoCertificado"
        Me.ButtonMontoCertificado.Size = New System.Drawing.Size(196, 52)
        Me.ButtonMontoCertificado.TabIndex = 184
        Me.ButtonMontoCertificado.Text = "Actualizar"
        Me.ButtonMontoCertificado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(133, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 16)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "Máximo monto por periodo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(133, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 16)
        Me.Label1.TabIndex = 186
        Me.Label1.Text = "Máximo monto por tracto"
        '
        'VMontoCertificados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 414)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonMontoCertificado)
        Me.Controls.Add(Me.MontoCertificadosTextboxTracto)
        Me.Controls.Add(Me.MontoCertificadosTextboxPeriodo)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VMontoCertificados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents MontoCertificadosTextboxPeriodo As TextBox
    Friend WithEvents MontoCertificadosTextboxTracto As TextBox
    Friend WithEvents ButtonMontoCertificado As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
