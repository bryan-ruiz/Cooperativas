<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTA: Windows Form Designer requiere el procedimiento siguiente
    'No puede modificarse con Windows Form Designer.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.IngresosTableAdapter1 = New ReportsApplication1.CoopeBDDataSetTableAdapters.INGRESOSTableAdapter()
        Me.datosDeSocio = New ReportsApplication1.datosDeSocio()
        Me.SOCIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SOCIOSTableAdapter = New ReportsApplication1.datosDeSocioTableAdapters.SOCIOSTableAdapter()
        CType(Me.datosDeSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOCIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SOCIOSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(682, 386)
        Me.ReportViewer1.TabIndex = 0
        '
        'IngresosTableAdapter1
        '
        Me.IngresosTableAdapter1.ClearBeforeFill = True
        '
        'datosDeSocio
        '
        Me.datosDeSocio.DataSetName = "datosDeSocio"
        Me.datosDeSocio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SOCIOSBindingSource
        '
        Me.SOCIOSBindingSource.DataMember = "SOCIOS"
        Me.SOCIOSBindingSource.DataSource = Me.datosDeSocio
        '
        'SOCIOSTableAdapter
        '
        Me.SOCIOSTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 386)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.datosDeSocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOCIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents IngresosTableAdapter1 As CoopeBDDataSetTableAdapters.INGRESOSTableAdapter
    Friend WithEvents SOCIOSBindingSource As BindingSource
    Friend WithEvents datosDeSocio As datosDeSocio
    Friend WithEvents SOCIOSTableAdapter As datosDeSocioTableAdapters.SOCIOSTableAdapter
End Class
