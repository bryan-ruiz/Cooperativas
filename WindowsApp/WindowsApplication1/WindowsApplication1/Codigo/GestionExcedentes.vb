Public Class GestionExcedentes

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim Reserva As Reservas = New Reservas


    Public Sub sumarAlAcumuladoLlamado()
        Dim valores, valorEnCertificado As Int32
        Dim cedulaNumAsociado As String = VGestionDeExcedentes.GestionExcTextboxCedulaNumAsociado.Text
        Dim excedenteDeUsuario As String = VGestionDeExcedentes.GestionExcTextboxExcCorrespondiente.Text
        If (cedulaNumAsociado = "" Or excedenteDeUsuario = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                Dim ubicacionEstado As String = "En Acumulado"
                Dim cantidad As Integer = Integer.Parse(excedenteDeUsuario)

                BD.ConectarBD()
                valores = BD.retirarExcedente(cedulaNumAsociado, ubicacionEstado)
                valorEnCertificado = BD.sumarAcumuladoAnterior(cedulaNumAsociado, cantidad)
                If valores <> 0 And valorEnCertificado <> 0 Then
                    MessageBox.Show(variablesGlobales.retiradoExcedenteExitoso, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(variablesGlobales.errorActualizandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                limpiar()
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
    End Sub

    'sumar excedentes de un usuario a reservas ediucacion social y bienestar social.
    Public Sub sumarAReservasLlamado()
        Dim valores, valorDeConsultaEducacion, valorConsultaBienestarSoc As Int32
        Dim cedulaNumAsociado As String = VGestionDeExcedentes.GestionExcTextboxCedulaNumAsociado.Text
        Dim excedenteDeUsuario As String = VGestionDeExcedentes.GestionExcTextboxExcCorrespondiente.Text
        If (cedulaNumAsociado = "" Or excedenteDeUsuario = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                Dim ubicacionEstado As String = "En Reservas"
                Dim cantidad As Integer = Integer.Parse(excedenteDeUsuario)
                Dim cincuentaPorciento As Integer = cantidad / 2

                BD.ConectarBD()
                valorConsultaBienestarSoc = Reserva.actualizarMontoEnBase(cincuentaPorciento, "bienestarSocial")
                valorDeConsultaEducacion = Reserva.actualizarMontoEnBase(cincuentaPorciento, "educacion")
                valores = BD.retirarExcedente(cedulaNumAsociado, ubicacionEstado)
                If valores <> 0 And valorDeConsultaEducacion <> 0 And valorConsultaBienestarSoc <> 0 Then
                    MessageBox.Show(variablesGlobales.retiradoExcedenteExitoso, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(variablesGlobales.errorActualizandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                limpiar()
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
    End Sub



    'Retirar excedentes de un usuario
    Public Sub retirarExcedentesLlamado()
        Dim valores As Int32
        Dim cedulaNumAsociado As String = VGestionDeExcedentes.GestionExcTextboxCedulaNumAsociado.Text
        If (cedulaNumAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                Dim ubicacionEstado As String = "Retirado"
                valores = BD.retirarExcedente(cedulaNumAsociado, ubicacionEstado)
                If valores <> 0 Then
                    MessageBox.Show(variablesGlobales.retiradoExcedenteExitoso, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(variablesGlobales.errorActualizandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                limpiar()
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
    End Sub

    'consulta un asociado por ced o numAsociado en la tabla de Excedentes en Tránsito
    Public Sub consultar()

        Dim valores As List(Of String)

        'Textfield para consultar por ced o num asociado
        Dim cedulaNumAsociado As String = VGestionDeExcedentes.GestionExcTextboxCedulaNumAsociado.Text

        If (cedulaNumAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
        Else
            Try
                BD.ConectarBD()

                valores = BD.consultarAsociadoCedOrNumAsociadoEnTablaExcedenteEnTransito(cedulaNumAsociado)

                If valores.Count <> 0 Then

                    VGestionDeExcedentes.GestionExcTextboxNumAsociado.Text = valores.Item(1)
                    VGestionDeExcedentes.GestionExcTextboxCed.Text = valores.Item(2)
                    VGestionDeExcedentes.GestionExcTextboxNombre.Text = valores.Item(3) + " " + valores.Item(4) + " " + valores.Item(5)
                    VGestionDeExcedentes.GestionExcTextboxExcCorrespondiente.Text = valores.Item(6)
                    VGestionDeExcedentes.GestionExcTextboxStatus.Text = valores.Item(7)

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
        VGestionDeExcedentes.GestionExcTextboxCedulaNumAsociado.Text = ""
        VGestionDeExcedentes.GestionExcTextboxNumAsociado.Text = ""
        VGestionDeExcedentes.GestionExcTextboxCed.Text = ""
        VGestionDeExcedentes.GestionExcTextboxNombre.Text = ""
        VGestionDeExcedentes.GestionExcTextboxExcCorrespondiente.Text = ""
        VGestionDeExcedentes.GestionExcTextboxStatus.Text = ""
    End Sub

End Class
