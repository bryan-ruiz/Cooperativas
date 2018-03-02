Public Class VGestionDeReservas
    Dim Reserva As Reservas = New Reservas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub VGestionDeReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_ReservasDisminuir.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_ReservasInsertar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Reserva.obtenerDatosSeleccionarReserva()
    End Sub

    Private Sub Button_ReservasInsertar_Click(sender As Object, e As EventArgs) Handles Button_ReservasInsertar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            Reserva.insertarEnReserva()
        End If
    End Sub

    Private Sub Button_ReservasDisminuir_Click(sender As Object, e As EventArgs) Handles Button_ReservasDisminuir.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            Reserva.disminuriEnReserva()
        End If
    End Sub
End Class