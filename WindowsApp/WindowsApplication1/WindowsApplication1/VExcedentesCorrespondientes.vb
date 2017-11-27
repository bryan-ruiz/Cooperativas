Public Class VExcedentesCorrespondientes

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim socio As Socios = New Socios

    Private Sub VExcedentesCorrespondientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ExcedentesCorrespButtonGenerarReporteExc.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    Private Sub ExcedentesCorrespButtonGenerarReporteExc_Click(sender As Object, e As EventArgs) Handles ExcedentesCorrespButtonGenerarReporteExc.Click
        socio.generarReporteExcedentesCorrespondientesPorAsociados()

    End Sub
End Class