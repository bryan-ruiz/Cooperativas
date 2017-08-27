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
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonPrintAbrirPDF
        '
        Me.ButtonPrintAbrirPDF.BackgroundImage = Global.Cooperativas.My.Resources.Resources.btn2
        resources.ApplyResources(Me.ButtonPrintAbrirPDF, "ButtonPrintAbrirPDF")
        Me.ButtonPrintAbrirPDF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ButtonPrintAbrirPDF.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonPrintAbrirPDF.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintAbrirPDF.Name = "ButtonPrintAbrirPDF"
        Me.ButtonPrintAbrirPDF.UseVisualStyleBackColor = True
        '
        'ButtonPrintSalir
        '
        Me.ButtonPrintSalir.BackgroundImage = Global.Cooperativas.My.Resources.Resources.btn2
        resources.ApplyResources(Me.ButtonPrintSalir, "ButtonPrintSalir")
        Me.ButtonPrintSalir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ButtonPrintSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonPrintSalir.ForeColor = System.Drawing.Color.White
        Me.ButtonPrintSalir.Name = "ButtonPrintSalir"
        Me.ButtonPrintSalir.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AxAcroPDF1
        '
        resources.ApplyResources(Me.AxAcroPDF1, "AxAcroPDF1")
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'Print
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.ButtonPrintAbrirPDF)
        Me.Controls.Add(Me.ButtonPrintSalir)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "Print"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonPrintAbrirPDF As Button
    Friend WithEvents ButtonPrintSalir As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    '-----------------------------------Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
End Class
