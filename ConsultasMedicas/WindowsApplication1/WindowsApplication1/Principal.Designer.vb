<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComitésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónCooperativaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeSACToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionUsuariosToolStripMenuItem, Me.IngresosToolStripMenuItem, Me.ComitésToolStripMenuItem, Me.CertificadosToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(912, 43)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionUsuariosToolStripMenuItem
        '
        Me.GestionUsuariosToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.asociado66
        Me.GestionUsuariosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GestionUsuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GestionUsuariosToolStripMenuItem.Name = "GestionUsuariosToolStripMenuItem"
        Me.GestionUsuariosToolStripMenuItem.Size = New System.Drawing.Size(113, 39)
        Me.GestionUsuariosToolStripMenuItem.Text = "  Pacientes "
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.MC41
        Me.IngresosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IngresosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(151, 39)
        Me.IngresosToolStripMenuItem.Text = "  Motivo Consulta "
        '
        'ComitésToolStripMenuItem
        '
        Me.ComitésToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.folder2
        Me.ComitésToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ComitésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ComitésToolStripMenuItem.Name = "ComitésToolStripMenuItem"
        Me.ComitésToolStripMenuItem.Size = New System.Drawing.Size(125, 39)
        Me.ComitésToolStripMenuItem.Text = "  Expedientes "
        '
        'CertificadosToolStripMenuItem
        '
        Me.CertificadosToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.chancho1
        Me.CertificadosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CertificadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CertificadosToolStripMenuItem.Name = "CertificadosToolStripMenuItem"
        Me.CertificadosToolStripMenuItem.Size = New System.Drawing.Size(119, 39)
        Me.CertificadosToolStripMenuItem.Text = "  Caja Chica "
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformaciónCooperativaToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.settings1pp
        Me.ConfiguraciónToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConfiguraciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(142, 39)
        Me.ConfiguraciónToolStripMenuItem.Text = "  Configuración  "
        '
        'InformaciónCooperativaToolStripMenuItem
        '
        Me.InformaciónCooperativaToolStripMenuItem.Name = "InformaciónCooperativaToolStripMenuItem"
        Me.InformaciónCooperativaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.InformaciónCooperativaToolStripMenuItem.Text = "Información General"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeSACToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.acercade55
        Me.AcercaDeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AcercaDeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(112, 39)
        Me.AcercaDeToolStripMenuItem.Text = "  Acerca de"
        '
        'AcercaDeSACToolStripMenuItem
        '
        Me.AcercaDeSACToolStripMenuItem.Name = "AcercaDeSACToolStripMenuItem"
        Me.AcercaDeSACToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.AcercaDeSACToolStripMenuItem.Text = "Acerca de Consultas Médicas"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(382, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(530, 57)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Sistema de Consultas Médicas"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Mistral", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(467, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(544, 84)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Dr. Joaquin Urbina Lópezdemeza                  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           "
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Mistral", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(479, 448)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(487, 84)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Cirujano Vascular Periférico                " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           "
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.DocImage1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(912, 584)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas Médicas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComitésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CertificadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents IngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaciónCooperativaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeSACToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
