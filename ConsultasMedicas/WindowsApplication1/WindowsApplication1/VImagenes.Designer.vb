<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VImagenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VImagenes))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ImagenesButtonBrowse = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ImagenesTextboxPath = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImagenesButtonGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(934, 24)
        Me.MenuStrip1.TabIndex = 148
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 93)
        Me.Panel1.TabIndex = 149
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(331, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(262, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Archivos del Paciente"
        '
        'ImagenesButtonBrowse
        '
        Me.ImagenesButtonBrowse.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImagenesButtonBrowse.ForeColor = System.Drawing.Color.White
        Me.ImagenesButtonBrowse.Location = New System.Drawing.Point(268, 582)
        Me.ImagenesButtonBrowse.Name = "ImagenesButtonBrowse"
        Me.ImagenesButtonBrowse.Size = New System.Drawing.Size(196, 52)
        Me.ImagenesButtonBrowse.TabIndex = 152
        Me.ImagenesButtonBrowse.Text = "Buscar"
        Me.ImagenesButtonBrowse.UseVisualStyleBackColor = True
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
        'ImagenesTextboxPath
        '
        Me.ImagenesTextboxPath.Enabled = False
        Me.ImagenesTextboxPath.Location = New System.Drawing.Point(215, 536)
        Me.ImagenesTextboxPath.Name = "ImagenesTextboxPath"
        Me.ImagenesTextboxPath.Size = New System.Drawing.Size(531, 20)
        Me.ImagenesTextboxPath.TabIndex = 157
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(176, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(570, 389)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 156
        Me.PictureBox1.TabStop = False
        '
        'ImagenesButtonGuardar
        '
        Me.ImagenesButtonGuardar.Enabled = False
        Me.ImagenesButtonGuardar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImagenesButtonGuardar.ForeColor = System.Drawing.Color.White
        Me.ImagenesButtonGuardar.Location = New System.Drawing.Point(476, 582)
        Me.ImagenesButtonGuardar.Name = "ImagenesButtonGuardar"
        Me.ImagenesButtonGuardar.Size = New System.Drawing.Size(196, 52)
        Me.ImagenesButtonGuardar.TabIndex = 158
        Me.ImagenesButtonGuardar.Text = "Guardar"
        Me.ImagenesButtonGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 539)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Path:"
        '
        'VImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 656)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImagenesButtonGuardar)
        Me.Controls.Add(Me.ImagenesTextboxPath)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ImagenesButtonBrowse)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VImagenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas Médicas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents ImagenesButtonBrowse As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImagenesTextboxPath As TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ImagenesButtonGuardar As Button
    Friend WithEvents Label1 As Label
End Class
