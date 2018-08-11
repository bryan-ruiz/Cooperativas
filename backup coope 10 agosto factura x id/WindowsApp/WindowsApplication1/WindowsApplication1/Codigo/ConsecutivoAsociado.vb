Public Class ConsecutivoAsociado

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim BD As ConexionBD = New ConexionBD

    'Guarda el consecutivo para el num de asociado
    Public Sub guardarConsecutivo()
        Dim consecutivo As String = VConsecutivoAsociado.ConsecutivoAsociadosTextboxConsecutivo.Text
        Dim ano As String = VConsecutivoAsociado.ConsecutivoAsociadosTextboxAno.Text

        If (consecutivo = "" Or ano = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                Dim modificado = BD.actualizarConsecutivoAsociado(Convert.ToInt32(consecutivo), Convert.ToInt32(ano))
                If modificado = 1 Then
                    MessageBox.Show(variablesGlobales.datosActualizadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(variablesGlobales.errorActualizandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
    End Sub

    Public Sub consultarInformacionConsecutivo()
        Dim valores As List(Of ConsecutivoAsociadoClase)
        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeConfigurationConsecutivoAsociado()
            If valores.Count <> 0 Then
                llenarDatos(valores)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                VConsecutivoAsociado.ConsecutivoAsociadosTextboxConsecutivo.Text = ""
                VConsecutivoAsociado.ConsecutivoAsociadosTextboxAno.Text = ""

            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    'Llena los campos con los datos de la consulta
    Public Sub llenarDatos(ByVal valores As List(Of ConsecutivoAsociadoClase))
        Dim conta As Integer = 0

        VAsociados.TextBoxSociosNumAsociado.Text = valores(0).consecutivo.ToString + "" + valores(0).ano.ToString

        While conta < valores.Count
            VConsecutivoAsociado.ConsecutivoAsociadosTextboxConsecutivo.Text = valores(conta).consecutivo.ToString
            VConsecutivoAsociado.ConsecutivoAsociadosTextboxAno.Text = valores(conta).ano.ToString

            conta = conta + 1
        End While
    End Sub

End Class
