Public Class VConsecutivoAsociado

    Dim configuracionInformacion As Configuracion = New Configuracion
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim consecutivoAsociado As ConsecutivoAsociado = New ConsecutivoAsociado

    'Carga los datos de la info de la coope
    Private Sub VConfiguracionInformacionCooperativa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consecutivoAsociado.consultarInformacionConsecutivo()
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonConsecutivoAsociadosGuardar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    'Modificar Informacion Cooperativa
    Private Sub ButtonConfiguracionInformacionModificar_Click(sender As Object, e As EventArgs) Handles ButtonConsecutivoAsociadosGuardar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else

            consecutivoAsociado.guardarConsecutivo()
            consecutivoAsociado.consultarInformacionConsecutivo()

        End If
        Me.Close()
    End Sub

    Private Sub ConsecutivoAsociadosTextboxConsecutivo_TextChanged(sender As Object, e As EventArgs) Handles ConsecutivoAsociadosTextboxConsecutivo.TextChanged

    End Sub
End Class