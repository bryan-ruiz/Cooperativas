Public Class VLicencias

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim certificados As Certificados = New Certificados

    Private Sub VReporteMorosidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.LicenciasButtonRenovar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.LicenciasTextBoxCodigo.Select()
    End Sub

End Class