<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VBusquedaXNombre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VBusquedaXNombre))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.MotivoConsultaTextboxConsultarCedula = New System.Windows.Forms.TextBox()
        Me.MotivoConsultaButtonBuscar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(911, 24)
        Me.MenuStrip1.TabIndex = 148
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(911, 93)
        Me.Panel1.TabIndex = 149
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(320, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(272, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Búsqueda por Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 155
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(377, 143)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(130, 16)
        Me.Label22.TabIndex = 65
        Me.Label22.Text = "Buscar por Nombre"
        '
        'MotivoConsultaTextboxConsultarCedula
        '
        Me.MotivoConsultaTextboxConsultarCedula.Location = New System.Drawing.Point(325, 164)
        Me.MotivoConsultaTextboxConsultarCedula.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MotivoConsultaTextboxConsultarCedula.Name = "MotivoConsultaTextboxConsultarCedula"
        Me.MotivoConsultaTextboxConsultarCedula.Size = New System.Drawing.Size(222, 20)
        Me.MotivoConsultaTextboxConsultarCedula.TabIndex = 1
        '
        'MotivoConsultaButtonBuscar
        '
        Me.MotivoConsultaButtonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MotivoConsultaButtonBuscar.ForeColor = System.Drawing.Color.White
        Me.MotivoConsultaButtonBuscar.Image = Global.WindowsApplication1.My.Resources.Resources.find81
        Me.MotivoConsultaButtonBuscar.Location = New System.Drawing.Point(553, 151)
        Me.MotivoConsultaButtonBuscar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MotivoConsultaButtonBuscar.Name = "MotivoConsultaButtonBuscar"
        Me.MotivoConsultaButtonBuscar.Size = New System.Drawing.Size(58, 43)
        Me.MotivoConsultaButtonBuscar.TabIndex = 2
        Me.MotivoConsultaButtonBuscar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(185, 216)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(536, 362)
        Me.ListView1.TabIndex = 163
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(182, 590)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(236, 15)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "Nota: utilice double click para seleccionar."
        '
        'VBusquedaXNombre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 628)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MotivoConsultaButtonBuscar)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.MotivoConsultaTextboxConsultarCedula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VBusquedaXNombre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas Médicas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label22 As Label
    Friend WithEvents MotivoConsultaTextboxConsultarCedula As TextBox
    Friend WithEvents MotivoConsultaButtonBuscar As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label7 As Label
End Class
