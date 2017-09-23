Public Class Principal
    Private Sub GestionUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripMenuItem.Click
        Asociados.Show()
    End Sub

    Private Sub ComitésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComitésToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub CertificadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificadosToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub FechasCertificadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechasCertificadosToolStripMenuItem.Click
        F_fechalimitecertic.Show()
    End Sub

    Private Sub CodigosDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodigosDeCuentasToolStripMenuItem.Click
        F_codcuentas.Show()
    End Sub

    Private Sub PorcentajesReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorcentajesReservasToolStripMenuItem.Click
        F_porcereservas.Show()
    End Sub

    Private Sub InformaciónCooperativaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónCooperativaToolStripMenuItem.Click
        F_infocoopes.Show()
    End Sub

    Private Sub GestiónDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeUsuariosToolStripMenuItem.Click
        F_adminusuarios.Show()
    End Sub


End Class
