<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Print
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.ButtonPrintAbrirPDF = New System.Windows.Forms.Button()
        Me.ButtonPrintSalir = New System.Windows.Forms.Button()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(1029, 721)
        Me.AxAcroPDF1.TabIndex = 4
        '
        'ButtonPrintAbrirPDF
        '
        Me.ButtonPrintAbrirPDF.BackColor = System.Drawing.Color.SeaGreen
        Me.ButtonPrintAbrirPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonPrintAbrirPDF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ButtonPrintAbrirPDF.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonPrintAbrirPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonPrintAbrirPDF.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintAbrirPDF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonPrintAbrirPDF.Location = New System.Drawing.Point(351, 48)
        Me.ButtonPrintAbrirPDF.Name = "ButtonPrintAbrirPDF"
        Me.ButtonPrintAbrirPDF.Size = New System.Drawing.Size(157, 52)
        Me.ButtonPrintAbrirPDF.TabIndex = 3
        Me.ButtonPrintAbrirPDF.Text = "Abrir PDF"
        Me.ButtonPrintAbrirPDF.UseVisualStyleBackColor = False
        '
        'ButtonPrintSalir
        '
        Me.ButtonPrintSalir.BackColor = System.Drawing.Color.IndianRed
        Me.ButtonPrintSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonPrintSalir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ButtonPrintSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonPrintSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonPrintSalir.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonPrintSalir.Location = New System.Drawing.Point(533, 48)
        Me.ButtonPrintSalir.Name = "ButtonPrintSalir"
        Me.ButtonPrintSalir.Size = New System.Drawing.Size(157, 52)
        Me.ButtonPrintSalir.TabIndex = 4
        Me.ButtonPrintSalir.Text = "Salir"
        Me.ButtonPrintSalir.UseVisualStyleBackColor = False
        '
        'Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1029, 721)
        Me.Controls.Add(Me.ButtonPrintSalir)
        Me.Controls.Add(Me.ButtonPrintAbrirPDF)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Print"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents ButtonPrintAbrirPDF As Button
    Friend WithEvents ButtonPrintSalir As Button
    '-----------------------------------Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
End Class
