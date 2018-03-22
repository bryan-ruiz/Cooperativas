Public Class VLicencias

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim certificados As Certificados = New Certificados
    Dim licencias As Licencias = New Licencias

    Private Sub VReporteMorosidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.LicenciasButtonRenovar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.LicenciasTextBoxCodigo.Select()
    End Sub

    Private Sub LicenciasButtonRenovar_Click(sender As Object, e As EventArgs) Handles LicenciasButtonRenovar.Click
        'NOTA= inserta X cantidad de licencias random en el sistema, realizar sólo 1 vez para la cooperativa.
        'licencias.insertarLicenciasEnBD(100)

        Dim codigo As String = LicenciasTextBoxCodigo.Text
        licencias.validarYRenovarLicencia(codigo)

    End Sub
End Class