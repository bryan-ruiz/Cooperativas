﻿Public Class VGestionDeCertificados

    Dim Reserva As Reservas = New Reservas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim gestionCertificados As GestionCertificados = New GestionCertificados

    Private Sub VGestionDeReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.GestionCertificadoButtonLimpiar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.GestionCertificadoButtonRetirarAcum.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.GestionCertificadoButtonSumarReservas.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

    End Sub

    Private Sub FechasLímiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechasLímiteToolStripMenuItem.Click
        VConfiguracionFechasLimite.Show()
    End Sub

    Private Sub MontosMáximosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MontosMáximosToolStripMenuItem.Click
        VMontoCertificados.Show()
    End Sub

    Private Sub GestionCertificadoButtonConsultar_Click(sender As Object, e As EventArgs) Handles GestionCertificadoButtonConsultar.Click
        gestionCertificados.consultar()
    End Sub

    'para cuando presiona Enter en el Textfield de cedula num asociado
    Private Sub GestionCertificadoTextboxCedulaNumAsociado_TextChanged(sender As Object, e As KeyPressEventArgs) Handles GestionCertificadoTextboxCedulaNumAsociado.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call GestionCertificadoButtonConsultar_Click(sender, e)
        End If
    End Sub

    Private Sub GestionCertificadoButtonRetirarAcum_Click(sender As Object, e As EventArgs) Handles GestionCertificadoButtonRetirarAcum.Click
        gestionCertificados.retirarAcumuladoCertLlamado()
        Me.Close()
        VGastos.Show()

    End Sub

    Private Sub GestionCertificadoButtonSumarReservas_Click(sender As Object, e As EventArgs) Handles GestionCertificadoButtonSumarReservas.Click
        gestionCertificados.sumarEnReservasoCertLlamado()
        Me.Close()
        VGastos.Show()
    End Sub

    Private Sub CertificadosEnEstadoPendienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificadosEnEstadoPendienteToolStripMenuItem.Click
        gestionCertificados.reporteCertificadosEnTransito("Pendiente")
        Print.Show()
    End Sub

    Private Sub CertificadosEnEstadoReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificadosEnEstadoReservasToolStripMenuItem.Click
        gestionCertificados.reporteCertificadosEnTransito("En Reservas")
        Print.Show()
    End Sub

    Private Sub ReporteDeCertificadosRetiradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCertificadosRetiradosToolStripMenuItem.Click
        gestionCertificados.reporteCertificadosEnTransito("Retirado")
        Print.Show()
    End Sub

    Private Sub ReporteDeTodosLosEstadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeTodosLosEstadosToolStripMenuItem.Click
        gestionCertificados.reporteCertificadosEnTransito("Todos")
        Print.Show()
    End Sub
End Class