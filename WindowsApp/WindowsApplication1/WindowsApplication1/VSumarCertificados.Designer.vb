<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VSumarCertificados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VSumarCertificados))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CertificadosButtonCerrarPeriodo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(52, 83)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(466, 167)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Al presionar el botón sumar, se realizará la suma de los distintos certificados a" &
    "cumulandolo en su total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sumar certificados"
        '
        'CertificadosButtonCerrarPeriodo
        '
        Me.CertificadosButtonCerrarPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CertificadosButtonCerrarPeriodo.ForeColor = System.Drawing.Color.White
        Me.CertificadosButtonCerrarPeriodo.Image = Global.WindowsApplication1.My.Resources.Resources.addwhite3
        Me.CertificadosButtonCerrarPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CertificadosButtonCerrarPeriodo.Location = New System.Drawing.Point(170, 292)
        Me.CertificadosButtonCerrarPeriodo.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CertificadosButtonCerrarPeriodo.Name = "CertificadosButtonCerrarPeriodo"
        Me.CertificadosButtonCerrarPeriodo.Size = New System.Drawing.Size(187, 44)
        Me.CertificadosButtonCerrarPeriodo.TabIndex = 58
        Me.CertificadosButtonCerrarPeriodo.Text = "Sumar "
        Me.CertificadosButtonCerrarPeriodo.UseVisualStyleBackColor = True
        '
        'VSumarCertificados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 379)
        Me.Controls.Add(Me.CertificadosButtonCerrarPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VSumarCertificados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CertificadosButtonCerrarPeriodo As Button
End Class
