﻿Public Class VCertificadosPonerseAlDia

    Dim certificadosAlDia As CertificadosAlDia = New CertificadosAlDia
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'LOAD
    Private Sub VCertificados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Panel3.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.CertificadosAlDiaButtonLimpiar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.CertificadosAlDiaButtonSumarAlAcumulado.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    ''New -----

    Private Sub CertificadosAlDiaButtonConsultar_Click(sender As Object, e As EventArgs) Handles CertificadosAlDiaButtonConsultar.Click
        certificadosAlDia.consultar()
    End Sub

    Private Sub CertificadosAlDiaTextboxCedulaNumAsociado_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles CertificadosAlDiaTextboxCedulaNumAsociado.KeyPress
        'TextBoxSociosConsultarAsociado.PasswordChar = "*"
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call CertificadosAlDiaButtonConsultar_Click(sender, e)
        End If
    End Sub

    Private Sub CertificadosAlDiaButtonLimpiar_Click(sender As Object, e As EventArgs) Handles CertificadosAlDiaButtonLimpiar.Click
        certificadosAlDia.limpiar()
    End Sub

    Private Sub CertificadosAlDiaTextBoxMontoSumar_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosAlDiaTextBoxMontoSumar.KeyPress
        Me.CertificadosAlDiaTextBoxMontoSumar.MaxLength = 5
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosAlDiaButtonSumarAlAcumulado_Click(sender As Object, e As EventArgs) Handles CertificadosAlDiaButtonSumarAlAcumulado.Click
        certificadosAlDia.actualizarSumarAlAcumAnteriorXSocio()
    End Sub
End Class