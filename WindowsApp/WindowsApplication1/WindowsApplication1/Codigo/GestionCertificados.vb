Public Class GestionCertificados

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Public Sub sumarEnReservasoCertLlamado()
        Dim valores, valoresCert As Integer
        'Textfield para consultar por ced o num asociado
        Dim cedulaNumAsociado As String = VGestionDeCertificados.GestionCertificadoTextboxCed.Text
        If (cedulaNumAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                valores = BD.retirarCertificadoEnTransito(cedulaNumAsociado, "En Reservas")
                valoresCert = BD.actualizarAcumuladoDeCertificado(cedulaNumAsociado, 0)
                If valores <> 0 And valoresCert <> 0 Then
                    MessageBox.Show(variablesGlobales.seHaAcumuladoConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
        limpiar()
    End Sub

    Public Sub retirarAcumuladoCertLlamado()
        Dim valores, valoresCert As Integer
        'Textfield para consultar por ced o num asociado
        Dim cedulaNumAsociado As String = VGestionDeCertificados.GestionCertificadoTextboxCed.Text
        If (cedulaNumAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                valores = BD.retirarCertificadoEnTransito(cedulaNumAsociado, "En Acumulado")
                valoresCert = BD.actualizarAcumuladoDeCertificado(cedulaNumAsociado, 0)
                If valores <> 0 And valoresCert <> 0 Then
                    MessageBox.Show(variablesGlobales.seHaAcumuladoConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
        limpiar()
    End Sub

    'consulta un asociado por ced o numAsociado en la tabla de Excedentes en Tránsito
    Public Sub consultar()

            Dim valores As List(Of String)

        'Textfield para consultar por ced o num asociado
        Dim cedulaNumAsociado As String = VGestionDeCertificados.GestionCertificadoTextboxCedulaNumAsociado.Text

        If (cedulaNumAsociado = "") Then
                MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                limpiar()
            Else
                Try
                    BD.ConectarBD()

                valores = BD.consultarAsociadoCedOrNumAsociadoEnTablaCertificadoEnTransito(cedulaNumAsociado)

                If valores.Count <> 0 Then

                    VGestionDeCertificados.GestionCertificadoTextboxNumAsociado.Text = valores.Item(1)
                    VGestionDeCertificados.GestionCertificadoTextboxCed.Text = valores.Item(2)
                    VGestionDeCertificados.GestionCertificadoTextboxNombreCompleto.Text = valores.Item(3) + " " + valores.Item(4) + " " + valores.Item(5)
                    VGestionDeCertificados.GestionCertificadoTextboxAcumuladoActual.Text = valores.Item(6)
                    VGestionDeCertificados.GestionCertificadoTextboxStatus.Text = valores.Item(7)

                Else
                        MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        limpiar()
                    End If

                    BD.CerrarConexion()

                Catch ex As Exception
                    MessageBox.Show(variablesGlobales.errorDe + ex.Message)

                End Try
            End If

        End Sub

        Public Sub limpiar()
        VGestionDeCertificados.GestionCertificadoTextboxCedulaNumAsociado.Text = ""
        VGestionDeCertificados.GestionCertificadoTextboxNumAsociado.Text = ""
        VGestionDeCertificados.GestionCertificadoTextboxCed.Text = ""
        VGestionDeCertificados.GestionCertificadoTextboxNombreCompleto.Text = ""
        VGestionDeCertificados.GestionCertificadoTextboxAcumuladoActual.Text = ""
        VGestionDeCertificados.GestionCertificadoTextboxStatus.Text = ""
    End Sub

    End Class
