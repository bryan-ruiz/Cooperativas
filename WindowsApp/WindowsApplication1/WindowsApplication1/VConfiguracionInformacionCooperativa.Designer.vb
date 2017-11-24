<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VConfiguracionInformacionCooperativa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VConfiguracionInformacionCooperativa))
        Me.ConfiguracionTextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ConfiguracionTextBoxCedulaJuridica = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonConfiguracionInformacionModificar = New System.Windows.Forms.Button()
        Me.ConfiguracionTextBoxPeriodo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ConfiguracionTextBoxCooperativa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConfiguracionTextBoxTelefono
        '
        Me.ConfiguracionTextBoxTelefono.Location = New System.Drawing.Point(180, 348)
        Me.ConfiguracionTextBoxTelefono.Name = "ConfiguracionTextBoxTelefono"
        Me.ConfiguracionTextBoxTelefono.Size = New System.Drawing.Size(318, 20)
        Me.ConfiguracionTextBoxTelefono.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(177, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 19)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Teléfono"
        '
        'ConfiguracionTextBoxCedulaJuridica
        '
        Me.ConfiguracionTextBoxCedulaJuridica.Location = New System.Drawing.Point(180, 288)
        Me.ConfiguracionTextBoxCedulaJuridica.Name = "ConfiguracionTextBoxCedulaJuridica"
        Me.ConfiguracionTextBoxCedulaJuridica.Size = New System.Drawing.Size(318, 20)
        Me.ConfiguracionTextBoxCedulaJuridica.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(176, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Cédula Jurídica"
        '
        'ButtonConfiguracionInformacionModificar
        '
        Me.ButtonConfiguracionInformacionModificar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonConfiguracionInformacionModificar.ForeColor = System.Drawing.Color.White
        Me.ButtonConfiguracionInformacionModificar.Location = New System.Drawing.Point(245, 430)
        Me.ButtonConfiguracionInformacionModificar.Name = "ButtonConfiguracionInformacionModificar"
        Me.ButtonConfiguracionInformacionModificar.Size = New System.Drawing.Size(196, 52)
        Me.ButtonConfiguracionInformacionModificar.TabIndex = 57
        Me.ButtonConfiguracionInformacionModificar.Text = "Guardar"
        Me.ButtonConfiguracionInformacionModificar.UseVisualStyleBackColor = True
        '
        'ConfiguracionTextBoxPeriodo
        '
        Me.ConfiguracionTextBoxPeriodo.Location = New System.Drawing.Point(180, 165)
        Me.ConfiguracionTextBoxPeriodo.Name = "ConfiguracionTextBoxPeriodo"
        Me.ConfiguracionTextBoxPeriodo.Size = New System.Drawing.Size(318, 20)
        Me.ConfiguracionTextBoxPeriodo.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(180, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Periodo Fiscal"
        '
        'ConfiguracionTextBoxCooperativa
        '
        Me.ConfiguracionTextBoxCooperativa.Location = New System.Drawing.Point(180, 227)
        Me.ConfiguracionTextBoxCooperativa.Name = "ConfiguracionTextBoxCooperativa"
        Me.ConfiguracionTextBoxCooperativa.Size = New System.Drawing.Size(318, 20)
        Me.ConfiguracionTextBoxCooperativa.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(176, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Nombre de la Cooperativa"
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
        Me.Label6.Location = New System.Drawing.Point(144, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(358, 29)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Información de la Cooperativa"
        '
        'VConfiguracionInformacionCooperativa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(665, 523)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ConfiguracionTextBoxTelefono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ConfiguracionTextBoxCedulaJuridica)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ButtonConfiguracionInformacionModificar)
        Me.Controls.Add(Me.ConfiguracionTextBoxPeriodo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ConfiguracionTextBoxCooperativa)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VConfiguracionInformacionCooperativa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfiguracionTextBoxTelefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ConfiguracionTextBoxCedulaJuridica As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonConfiguracionInformacionModificar As Button
    Friend WithEvents ConfiguracionTextBoxPeriodo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ConfiguracionTextBoxCooperativa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class
