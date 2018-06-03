Public Class VSumarCertificados
    Dim certificados As Certificados = New Certificados
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub VGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CertificadosButtonCerrarPeriodo.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    Private Sub CertificadosButtonCerrarPeriodo_Click(sender As Object, e As EventArgs) Handles CertificadosButtonCerrarPeriodo.Click
        certificados.sumarTractosEnTotalAcumulado()
    End Sub
End Class