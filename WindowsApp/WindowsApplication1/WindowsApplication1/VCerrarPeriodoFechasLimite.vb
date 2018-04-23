Public Class VCerrarPeriodoFechasLimite

    Dim cerrarPeriodo As Reservas = New Reservas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim certificados As Certificados = New Certificados

    Private Sub VCerrarPeriodoFechasLimite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load
        cerrarPeriodo.consultarFechasCierreP()

        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonCerrarPeriodoFechasGuardar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

    End Sub

    Private Sub ButtonCerrarPeriodoFechasGuardar_Click(sender As Object, e As EventArgs) Handles ButtonCerrarPeriodoFechasGuardar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            cerrarPeriodo.actualizarCerrarPeriodoFechas()
            cerrarPeriodo.consultarFechasLimiteCerrarPeriodo()
        End If

        Me.Close()
    End Sub

End Class