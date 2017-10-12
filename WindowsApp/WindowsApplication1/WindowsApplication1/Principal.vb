﻿Public Class Principal
    Private Sub GestionUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripMenuItem.Click
        Asociados.Show()
    End Sub

    Private Sub ComitésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComitésToolStripMenuItem.Click
        VComites.Show()
    End Sub

    Private Sub CertificadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificadosToolStripMenuItem.Click
        VCertificados.Show()
    End Sub

    Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click
        VIngresos.Show()
    End Sub

    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem.Click
        VGastos.Show()
    End Sub

    Private Sub FechasCertificadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechasCertificadosToolStripMenuItem.Click
        VConfiguracionFechasLimite.Show()
    End Sub

    Private Sub CodigosDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodigosDeCuentasToolStripMenuItem.Click
        VConfiguracionCodigoCuenta.Show()
    End Sub

    Private Sub PorcentajesReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorcentajesReservasToolStripMenuItem.Click
        VConfiguracionPorcentajeReservas.Show()
    End Sub

    Private Sub InformaciónCooperativaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónCooperativaToolStripMenuItem.Click
        VConfiguracionInformacionCooperativa.Show()
    End Sub

    Private Sub GestiónDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeUsuariosToolStripMenuItem.Click
        F_adminusuarios.Show()
    End Sub


End Class
