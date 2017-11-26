Public Class VReporteMorosidad

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim certificados As Certificados = New Certificados

    Private Sub VReporteMorosidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonReporteMorosidad.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    Private Sub TextBoxMorosidad_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxMorosidad.KeyPress
        Me.TextBoxMorosidad.MaxLength = 4
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ButtonReporteMorosidad_Click(sender As Object, e As EventArgs) Handles ButtonReporteMorosidad.Click
        certificados.generarReporteMorosidadAsociadosActivos()
        Print.Show()
    End Sub


End Class