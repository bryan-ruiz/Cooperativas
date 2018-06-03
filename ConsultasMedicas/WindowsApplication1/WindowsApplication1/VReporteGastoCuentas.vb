Public Class VReporteGastoCuentas
    Dim gaston As Gastos = New Gastos
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Private Sub VGastosCuentasReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_GastosCuentasReporte_aceptar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    Private Sub Button_GastosCuentasReporte_aceptar_Click(sender As Object, e As EventArgs) Handles Button_GastosCuentasReporte_aceptar.Click
        gaston.generarReporteCuentaGastos()

        Me.Close()
    End Sub
End Class