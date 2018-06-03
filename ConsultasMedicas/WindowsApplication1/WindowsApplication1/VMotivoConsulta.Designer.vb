<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VMotivoConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VMotivoConsulta))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MotivoConsultaButtonBuscarXNombre = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.MotivoConsultaTextboxConsultarCedula = New System.Windows.Forms.TextBox()
        Me.MotivoConsultaButtonBuscar = New System.Windows.Forms.Button()
        Me.MotivoConsultaButtonLimpiar = New System.Windows.Forms.Button()
        Me.MotivoConsultaTextboxMotivoConsulta = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MotivoConsultaDateTimeFecha = New System.Windows.Forms.DateTimePicker()
        Me.MotivoConsultaTextboxValorConsulta = New System.Windows.Forms.TextBox()
        Me.MotivoConsultaTextboxCed = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MotivoConsultaTextboxNombreYApellidos = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.MotivoConsultaButtonAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonBorrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1247, 24)
        Me.MenuStrip1.TabIndex = 148
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1248, 93)
        Me.Panel1.TabIndex = 149
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(522, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Motivo Consulta"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonBorrar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.MotivoConsultaButtonBuscarXNombre)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.MotivoConsultaTextboxConsultarCedula)
        Me.GroupBox1.Controls.Add(Me.MotivoConsultaButtonBuscar)
        Me.GroupBox1.Controls.Add(Me.MotivoConsultaButtonLimpiar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(13, 134)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(310, 579)
        Me.GroupBox1.TabIndex = 159
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(146, 416)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 44)
        Me.Button1.TabIndex = 166
        Me.Button1.Text = "cargar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MotivoConsultaButtonBuscarXNombre
        '
        Me.MotivoConsultaButtonBuscarXNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MotivoConsultaButtonBuscarXNombre.ForeColor = System.Drawing.Color.White
        Me.MotivoConsultaButtonBuscarXNombre.Image = Global.WindowsApplication1.My.Resources.Resources.search9
        Me.MotivoConsultaButtonBuscarXNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MotivoConsultaButtonBuscarXNombre.Location = New System.Drawing.Point(39, 140)
        Me.MotivoConsultaButtonBuscarXNombre.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MotivoConsultaButtonBuscarXNombre.Name = "MotivoConsultaButtonBuscarXNombre"
        Me.MotivoConsultaButtonBuscarXNombre.Size = New System.Drawing.Size(199, 44)
        Me.MotivoConsultaButtonBuscarXNombre.TabIndex = 66
        Me.MotivoConsultaButtonBuscarXNombre.Text = " Buscar por Nombre"
        Me.MotivoConsultaButtonBuscarXNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MotivoConsultaButtonBuscarXNombre.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(17, 42)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(221, 16)
        Me.Label22.TabIndex = 65
        Me.Label22.Text = "Buscar por Cédula (x-xxxx-xxxx):"
        '
        'MotivoConsultaTextboxConsultarCedula
        '
        Me.MotivoConsultaTextboxConsultarCedula.Location = New System.Drawing.Point(16, 69)
        Me.MotivoConsultaTextboxConsultarCedula.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MotivoConsultaTextboxConsultarCedula.Name = "MotivoConsultaTextboxConsultarCedula"
        Me.MotivoConsultaTextboxConsultarCedula.Size = New System.Drawing.Size(222, 22)
        Me.MotivoConsultaTextboxConsultarCedula.TabIndex = 1
        '
        'MotivoConsultaButtonBuscar
        '
        Me.MotivoConsultaButtonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MotivoConsultaButtonBuscar.ForeColor = System.Drawing.Color.White
        Me.MotivoConsultaButtonBuscar.Image = Global.WindowsApplication1.My.Resources.Resources.find81
        Me.MotivoConsultaButtonBuscar.Location = New System.Drawing.Point(244, 59)
        Me.MotivoConsultaButtonBuscar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MotivoConsultaButtonBuscar.Name = "MotivoConsultaButtonBuscar"
        Me.MotivoConsultaButtonBuscar.Size = New System.Drawing.Size(58, 43)
        Me.MotivoConsultaButtonBuscar.TabIndex = 2
        Me.MotivoConsultaButtonBuscar.UseVisualStyleBackColor = True
        '
        'MotivoConsultaButtonLimpiar
        '
        Me.MotivoConsultaButtonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MotivoConsultaButtonLimpiar.ForeColor = System.Drawing.Color.White
        Me.MotivoConsultaButtonLimpiar.Image = Global.WindowsApplication1.My.Resources.Resources.cleanlast2
        Me.MotivoConsultaButtonLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MotivoConsultaButtonLimpiar.Location = New System.Drawing.Point(39, 216)
        Me.MotivoConsultaButtonLimpiar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MotivoConsultaButtonLimpiar.Name = "MotivoConsultaButtonLimpiar"
        Me.MotivoConsultaButtonLimpiar.Size = New System.Drawing.Size(199, 44)
        Me.MotivoConsultaButtonLimpiar.TabIndex = 5
        Me.MotivoConsultaButtonLimpiar.Text = "Limpiar Campos"
        Me.MotivoConsultaButtonLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MotivoConsultaButtonLimpiar.UseVisualStyleBackColor = True
        '
        'MotivoConsultaTextboxMotivoConsulta
        '
        Me.MotivoConsultaTextboxMotivoConsulta.Location = New System.Drawing.Point(634, 233)
        Me.MotivoConsultaTextboxMotivoConsulta.Multiline = True
        Me.MotivoConsultaTextboxMotivoConsulta.Name = "MotivoConsultaTextboxMotivoConsulta"
        Me.MotivoConsultaTextboxMotivoConsulta.Size = New System.Drawing.Size(453, 59)
        Me.MotivoConsultaTextboxMotivoConsulta.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(391, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(831, 37)
        Me.GroupBox3.TabIndex = 141
        Me.GroupBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(416, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Motivo de la Consulta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(119, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "¢ Valor Consulta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fecha"
        '
        'MotivoConsultaDateTimeFecha
        '
        Me.MotivoConsultaDateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MotivoConsultaDateTimeFecha.Location = New System.Drawing.Point(391, 243)
        Me.MotivoConsultaDateTimeFecha.Name = "MotivoConsultaDateTimeFecha"
        Me.MotivoConsultaDateTimeFecha.Size = New System.Drawing.Size(102, 20)
        Me.MotivoConsultaDateTimeFecha.TabIndex = 1
        '
        'MotivoConsultaTextboxValorConsulta
        '
        Me.MotivoConsultaTextboxValorConsulta.Location = New System.Drawing.Point(499, 243)
        Me.MotivoConsultaTextboxValorConsulta.Name = "MotivoConsultaTextboxValorConsulta"
        Me.MotivoConsultaTextboxValorConsulta.Size = New System.Drawing.Size(129, 20)
        Me.MotivoConsultaTextboxValorConsulta.TabIndex = 2
        '
        'MotivoConsultaTextboxCed
        '
        Me.MotivoConsultaTextboxCed.Location = New System.Drawing.Point(76, 14)
        Me.MotivoConsultaTextboxCed.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MotivoConsultaTextboxCed.Name = "MotivoConsultaTextboxCed"
        Me.MotivoConsultaTextboxCed.Size = New System.Drawing.Size(161, 20)
        Me.MotivoConsultaTextboxCed.TabIndex = 164
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.MotivoConsultaTextboxCed)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.MotivoConsultaTextboxNombreYApellidos)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(391, 134)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(831, 41)
        Me.GroupBox4.TabIndex = 162
        Me.GroupBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(26, 16)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Cédula"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(262, 16)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 15)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Nombre y Apellidos"
        '
        'MotivoConsultaTextboxNombreYApellidos
        '
        Me.MotivoConsultaTextboxNombreYApellidos.Enabled = False
        Me.MotivoConsultaTextboxNombreYApellidos.Location = New System.Drawing.Point(379, 14)
        Me.MotivoConsultaTextboxNombreYApellidos.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MotivoConsultaTextboxNombreYApellidos.Name = "MotivoConsultaTextboxNombreYApellidos"
        Me.MotivoConsultaTextboxNombreYApellidos.Size = New System.Drawing.Size(349, 20)
        Me.MotivoConsultaTextboxNombreYApellidos.TabIndex = 161
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(330, 325)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(907, 389)
        Me.ListView1.TabIndex = 163
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'MotivoConsultaButtonAgregar
        '
        Me.MotivoConsultaButtonAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MotivoConsultaButtonAgregar.ForeColor = System.Drawing.Color.White
        Me.MotivoConsultaButtonAgregar.Image = Global.WindowsApplication1.My.Resources.Resources.addwhite2
        Me.MotivoConsultaButtonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MotivoConsultaButtonAgregar.Location = New System.Drawing.Point(1097, 243)
        Me.MotivoConsultaButtonAgregar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MotivoConsultaButtonAgregar.Name = "MotivoConsultaButtonAgregar"
        Me.MotivoConsultaButtonAgregar.Size = New System.Drawing.Size(125, 40)
        Me.MotivoConsultaButtonAgregar.TabIndex = 164
        Me.MotivoConsultaButtonAgregar.Text = "Agregar"
        Me.MotivoConsultaButtonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MotivoConsultaButtonAgregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(393, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Historial:"
        '
        'ButtonBorrar
        '
        Me.ButtonBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonBorrar.ForeColor = System.Drawing.Color.White
        Me.ButtonBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBorrar.Location = New System.Drawing.Point(146, 362)
        Me.ButtonBorrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ButtonBorrar.Name = "ButtonBorrar"
        Me.ButtonBorrar.Size = New System.Drawing.Size(129, 44)
        Me.ButtonBorrar.TabIndex = 167
        Me.ButtonBorrar.Text = "borrar"
        Me.ButtonBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBorrar.UseVisualStyleBackColor = True
        '
        'VMotivoConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 726)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MotivoConsultaButtonAgregar)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.MotivoConsultaTextboxMotivoConsulta)
        Me.Controls.Add(Me.MotivoConsultaTextboxValorConsulta)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MotivoConsultaDateTimeFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VMotivoConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas Médicas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MotivoConsultaButtonBuscarXNombre As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents MotivoConsultaTextboxConsultarCedula As TextBox
    Friend WithEvents MotivoConsultaButtonBuscar As Button
    Friend WithEvents MotivoConsultaButtonLimpiar As Button
    Friend WithEvents MotivoConsultaTextboxValorConsulta As TextBox
    Friend WithEvents MotivoConsultaTextboxMotivoConsulta As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MotivoConsultaDateTimeFecha As DateTimePicker
    Friend WithEvents MotivoConsultaTextboxCed As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MotivoConsultaTextboxNombreYApellidos As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents MotivoConsultaButtonAgregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonBorrar As Button
End Class
