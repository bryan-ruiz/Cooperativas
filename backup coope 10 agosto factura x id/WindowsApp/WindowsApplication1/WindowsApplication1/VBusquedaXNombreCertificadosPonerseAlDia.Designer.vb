<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VBusquedaXNombreCertificadosPonerseAlDia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VBusquedaXNombreCertificadosPonerseAlDia))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.BusquedaXNombreTextboxConsultarCedula = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 93)
        Me.Panel1.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(217, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(272, 29)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Búsqueda por Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(107, 595)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(236, 15)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Nota: utilice double click para seleccionar."
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(110, 200)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(464, 383)
        Me.ListView1.TabIndex = 168
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(148, 149)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(108, 16)
        Me.Label22.TabIndex = 167
        Me.Label22.Text = "Buscar nombre:"
        '
        'BusquedaXNombreTextboxConsultarCedula
        '
        Me.BusquedaXNombreTextboxConsultarCedula.Location = New System.Drawing.Point(263, 149)
        Me.BusquedaXNombreTextboxConsultarCedula.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BusquedaXNombreTextboxConsultarCedula.Name = "BusquedaXNombreTextboxConsultarCedula"
        Me.BusquedaXNombreTextboxConsultarCedula.Size = New System.Drawing.Size(246, 20)
        Me.BusquedaXNombreTextboxConsultarCedula.TabIndex = 165
        '
        'VBusquedaXNombreCertificadosPonerseAlDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(692, 638)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.BusquedaXNombreTextboxConsultarCedula)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VBusquedaXNombreCertificadosPonerseAlDia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label22 As Label
    Friend WithEvents BusquedaXNombreTextboxConsultarCedula As TextBox
End Class
