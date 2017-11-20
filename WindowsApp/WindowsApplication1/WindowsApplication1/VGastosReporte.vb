Public Class VGastosReporte

    Dim gasto As Gastos = New Gastos
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub ButtonGastosReporte_Click(sender As Object, e As EventArgs) Handles ButtonGastosReporte.Click
        gasto.generarReporteGastosNuevo()
        Print.Show()
    End Sub

    Private Sub VGastosReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonGastosReporte.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub
End Class