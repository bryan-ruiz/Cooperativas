Public Class VCerrarPeriodoFechasLimite

    Dim cerrarPeriodo As Reservas = New Reservas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim certificados As Certificados = New Certificados


    Private Sub VConfiguracionFechasLimite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load
        cerrarPeriodo.consultarFechasLimiteCerrarPeriodo()

        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonConfiguracionFechasGuardar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

    End Sub


    Private Sub ButtonConfiguracionFechasGuardar_Click(sender As Object, e As EventArgs) Handles ButtonConfiguracionFechasGuardar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            cerrarPeriodo.actualizarCerrarPeriodoFechas()
            certificados.consultarFechasLimite()
        End If
        Me.Close()
    End Sub


End Class