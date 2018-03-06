Public Class VResrvasPrincipal
    Dim Reserva As Reservas = New Reservas

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub VReservasPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ReservasButtonGenerarInforme.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    Private Sub GestionDeReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeReservasToolStripMenuItem.Click
        VGestionDeReservas.Show()
    End Sub

    Private Sub ReservasButtonGenerarInforme_Click(sender As Object, e As EventArgs) Handles ReservasButtonGenerarInforme.Click
        Reserva.cerrarPeriodo()
    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        Reserva.crearReporteReservas()
        Print.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub
End Class