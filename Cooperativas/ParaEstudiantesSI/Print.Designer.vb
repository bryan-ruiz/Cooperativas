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
        Me.ButtonPrintAbrirPDF = New System.Windows.Forms.Button()
        Me.ButtonPrintSalir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        '---Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        '---CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonPrintAbrirPDF
        '
        Me.ButtonPrintAbrirPDF.BackgroundImage = Global.Cooperativas.My.Resources.Resources.btn2
        Me.ButtonPrintAbrirPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonPrintAbrirPDF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ButtonPrintAbrirPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintAbrirPDF.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintAbrirPDF.Location = New System.Drawing.Point(353, 5)
        Me.ButtonPrintAbrirPDF.Name = "ButtonPrintAbrirPDF"
        Me.ButtonPrintAbrirPDF.Size = New System.Drawing.Size(157, 52)
        Me.ButtonPrintAbrirPDF.TabIndex = 1
        Me.ButtonPrintAbrirPDF.Text = "Abrir PDF"
        Me.ButtonPrintAbrirPDF.UseVisualStyleBackColor = True
        '
        'ButtonPrintSalir
        '
        Me.ButtonPrintSalir.BackgroundImage = Global.Cooperativas.My.Resources.Resources.btn2
        Me.ButtonPrintSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonPrintSalir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ButtonPrintSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintSalir.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintSalir.Location = New System.Drawing.Point(516, 5)
        Me.ButtonPrintSalir.Name = "ButtonPrintSalir"
        Me.ButtonPrintSalir.Size = New System.Drawing.Size(157, 52)
        Me.ButtonPrintSalir.TabIndex = 2
        Me.ButtonPrintSalir.Text = "Salir"
        Me.ButtonPrintSalir.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AxAcroPDF1
        '
        '---Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        '---Me.AxAcroPDF1.Enabled = True
        '---Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 0)
        '---Me.AxAcroPDF1.Name = "AxAcroPDF1"
        '---Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        '---Me.AxAcroPDF1.Size = New System.Drawing.Size(1047, 693)
        '---Me.AxAcroPDF1.TabIndex = 0
        '
        'Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 693)
        Me.Controls.Add(Me.ButtonPrintSalir)
        Me.Controls.Add(Me.ButtonPrintAbrirPDF)
        '---Me.Controls.Add(Me.AxAcroPDF1)
        Me.Name = "Print"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print"
        '---CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonPrintAbrirPDF As Button
    Friend WithEvents ButtonPrintSalir As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    '---Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
End Class
