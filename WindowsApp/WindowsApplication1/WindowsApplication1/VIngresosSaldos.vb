Public Class VIngresosSaldos

    Dim saldos As Saldos = New Saldos
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub Button_IngresosReporteIngresos_Click(sender As Object, e As EventArgs) Handles Button_ReporteSaldos.Click
        saldos.generarReporteSaldosNuevo()
        Print.Show()
        Me.Close()
    End Sub

    Private Sub VIngresosSaldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_ReporteSaldos.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

End Class