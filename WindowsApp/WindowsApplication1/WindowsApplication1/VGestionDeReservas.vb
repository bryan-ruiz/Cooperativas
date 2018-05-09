Public Class VGestionDeReservas
    Dim reserva As Reservas = New Reservas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub VGestionDeReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        reserva.obtenerDatosSeleccionarReserva()
    End Sub

    'Private Sub Button_ReservasInsertar_Click(sender As Object, e As EventArgs)
    'If Singleton.rol = "Colaborador" Then
    '       MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
    'Else
    '       reserva.insertarEnReserva()
    '      reserva.acumuladoDeReservaCambiarEnTextBox()
    'End If
    'End Sub

    'restar reserva
    'Private Sub Button_ReservasDisminuir_Click(sender As Object, e As EventArgs)
    'If Singleton.rol = "Colaborador" Then
    '       MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
    'Else
    '       reserva.disminuriEnReserva()
    '      reserva.acumuladoDeReservaCambiarEnTextBox()
    'End If
    'End Sub

    'Por el momento se va a eliminar el Actualizar reserva
    'Private Sub Button_ReservasEditar_Click(sender As Object, e As EventArgs)
    'If Singleton.rol = "Colaborador" Then
    '       MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
    'Else
    '       Reserva.actualizarEnReserva()
    '      Reserva.acumuladoDeReservaCambiarEnTextBox()
    'End If
    'End Sub

    Private Sub ComboBox_reservasGestion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_reservasGestion.SelectedIndexChanged
        reserva.acumuladoDeReservaCambiarEnTextBox()
    End Sub


    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        VReservasEntradas.Show()
    End Sub

    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem.Click
        VReservasSalidas.Show()
    End Sub

    Private Sub AcumuladoEnReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcumuladoEnReservasToolStripMenuItem.Click
        reserva.crearReporteAcumuladoReservas()
        Print.Show()
        Print.abrirReporte(variablesGlobales.pathReporteDeAcumuladoReservas)
        Me.Close()
    End Sub

    Private Sub SaldosDeReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldosDeReservasToolStripMenuItem.Click
        reserva.generarReporteSaldosDeReservas()
        Print.Show()
        Print.abrirReporte(variablesGlobales.pathReporteDeSaldosDeReservas)
        Me.Close()
    End Sub
End Class