Public Class VConfiguracionInformacionCooperativa

    Dim configuracionInformacion As Configuracion = New Configuracion
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales


    'Carga los datos de la info de la coope
    Private Sub VConfiguracionInformacionCooperativa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configuracionInformacion.consultarInformacionCooperativa()

        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonConfiguracionInformacionModificar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

    End Sub


    'Modificar Informacion Cooperativa
    Private Sub ButtonConfiguracionInformacionModificar_Click(sender As Object, e As EventArgs) Handles ButtonConfiguracionInformacionModificar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            configuracionInformacion.actualizarInformacionCooperativa()
        End If
    End Sub

End Class