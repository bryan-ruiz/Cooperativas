<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VConfiguracionCuotaAdmision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VConfiguracionCuotaAdmision))
        Me.ButtonConfiguracionCuotaAdmisionGuardar = New System.Windows.Forms.Button()
        Me.ConfiguracionTextBoxCuotaAdmision = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonConfiguracionCuotaAdmisionGuardar
        '
        Me.ButtonConfiguracionCuotaAdmisionGuardar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonConfiguracionCuotaAdmisionGuardar.ForeColor = System.Drawing.Color.White
        Me.ButtonConfiguracionCuotaAdmisionGuardar.Location = New System.Drawing.Point(231, 242)
        Me.ButtonConfiguracionCuotaAdmisionGuardar.Name = "ButtonConfiguracionCuotaAdmisionGuardar"
        Me.ButtonConfiguracionCuotaAdmisionGuardar.Size = New System.Drawing.Size(196, 52)
        Me.ButtonConfiguracionCuotaAdmisionGuardar.TabIndex = 57
        Me.ButtonConfiguracionCuotaAdmisionGuardar.Text = "Guardar"
        Me.ButtonConfiguracionCuotaAdmisionGuardar.UseVisualStyleBackColor = True
        '
        'ConfiguracionTextBoxCuotaAdmision
        '
        Me.ConfiguracionTextBoxCuotaAdmision.Location = New System.Drawing.Point(178, 165)
        Me.ConfiguracionTextBoxCuotaAdmision.Name = "ConfiguracionTextBoxCuotaAdmision"
        Me.ConfiguracionTextBoxCuotaAdmision.Size = New System.Drawing.Size(318, 20)
        Me.ConfiguracionTextBoxCuotaAdmision.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(178, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 19)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Cuota de Admisión:"
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
        Me.Label6.Location = New System.Drawing.Point(226, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 29)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Cuota de Admisión"
        '
        'VConfiguracionCuotaAdmision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(665, 357)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonConfiguracionCuotaAdmisionGuardar)
        Me.Controls.Add(Me.ConfiguracionTextBoxCuotaAdmision)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VConfiguracionCuotaAdmision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonConfiguracionCuotaAdmisionGuardar As Button
    Friend WithEvents ConfiguracionTextBoxCuotaAdmision As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class
