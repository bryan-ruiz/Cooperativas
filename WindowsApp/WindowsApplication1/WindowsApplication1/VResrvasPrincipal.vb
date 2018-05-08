Public Class VResrvasPrincipal

    Dim cerrarPeriodo As Reservas = New Reservas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub VReservasPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ReservasButtonGenerarInforme.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        'Para obtener las fechas desde la tabla de "Cerrar Periodo Fechas"
        cerrarPeriodo.consultarFechasLimiteCerrarPeriodo()

    End Sub

    Private Sub ReservasButtonGenerarInforme_Click(sender As Object, e As EventArgs) Handles ReservasButtonGenerarInforme.Click
        cerrarPeriodo.cerrarPeriodo()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FechasLímiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechasLímiteToolStripMenuItem.Click
        VCerrarPeriodoFechasLimite.Show()
    End Sub
End Class