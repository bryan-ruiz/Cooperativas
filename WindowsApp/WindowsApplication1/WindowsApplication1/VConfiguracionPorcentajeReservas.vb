Public Class VConfiguracionPorcentajeReservas

    Dim configuracionReservas As Configuracion = New Configuracion
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales


    Private Sub VConfiguracionPorcentajeReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load
        configuracionReservas.consultarPorcentajeReservas()
    End Sub


    Private Sub ButtonConfiguracionReservasModificar_Click(sender As Object, e As EventArgs) Handles ButtonConfiguracionReservasModificar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            configuracionReservas.actualizarPorcentajeReservas()
        End If
    End Sub


End Class