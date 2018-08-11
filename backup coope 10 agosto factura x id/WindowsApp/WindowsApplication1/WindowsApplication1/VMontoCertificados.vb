Public Class VMontoCertificados
    Dim configuracion As Configuracion = New Configuracion
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub VGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configuracion.obtenerMontoCertificados()
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonMontoCertificado.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    Private Sub ButtonMontoCertificado_Click(sender As Object, e As EventArgs) Handles ButtonMontoCertificado.Click
        configuracion.actualizarMontoCertificados()
    End Sub
End Class