Public Class VIngresosReporte

    Dim ingreso As Ingreso = New Ingreso
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub Button_IngresosReporteIngresos_Click(sender As Object, e As EventArgs) Handles Button_IngresosReporteIngresos.Click
        ingreso.generarReporteIngresosNuevo()
        Me.Close()
    End Sub

    Private Sub VIngresosReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_IngresosReporteIngresos.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

End Class