<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VLicencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VLicencias))
        Me.LicenciasButtonRenovar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LicenciasTextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.LabelWait = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LicenciasButtonRenovar
        '
        Me.LicenciasButtonRenovar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LicenciasButtonRenovar.ForeColor = System.Drawing.Color.White
        Me.LicenciasButtonRenovar.Location = New System.Drawing.Point(244, 262)
        Me.LicenciasButtonRenovar.Name = "LicenciasButtonRenovar"
        Me.LicenciasButtonRenovar.Size = New System.Drawing.Size(196, 52)
        Me.LicenciasButtonRenovar.TabIndex = 38
        Me.LicenciasButtonRenovar.Text = "Renovar"
        Me.LicenciasButtonRenovar.UseVisualStyleBackColor = True
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
        Me.Label3.Location = New System.Drawing.Point(291, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 29)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Licencias"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(165, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Ingrese el código para renovar las licencias en el Sistema."
        '
        'LicenciasTextBoxCodigo
        '
        Me.LicenciasTextBoxCodigo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenciasTextBoxCodigo.Location = New System.Drawing.Point(189, 180)
        Me.LicenciasTextBoxCodigo.Name = "LicenciasTextBoxCodigo"
        Me.LicenciasTextBoxCodigo.Size = New System.Drawing.Size(321, 22)
        Me.LicenciasTextBoxCodigo.TabIndex = 51
        '
        'LabelWait
        '
        Me.LabelWait.AutoSize = True
        Me.LabelWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWait.ForeColor = System.Drawing.Color.Red
        Me.LabelWait.Location = New System.Drawing.Point(185, 345)
        Me.LabelWait.Name = "LabelWait"
        Me.LabelWait.Size = New System.Drawing.Size(50, 24)
        Me.LabelWait.TabIndex = 52
        Me.LabelWait.Text = "        "
        '
        'VLicencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(666, 390)
        Me.Controls.Add(Me.LabelWait)
        Me.Controls.Add(Me.LicenciasTextBoxCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LicenciasButtonRenovar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VLicencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LicenciasButtonRenovar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LicenciasTextBoxCodigo As TextBox
    Friend WithEvents LabelWait As Label
End Class
