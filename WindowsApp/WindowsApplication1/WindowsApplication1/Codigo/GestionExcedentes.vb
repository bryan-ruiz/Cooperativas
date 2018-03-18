Public Class GestionExcedentes

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales


    'Retirar excedentes de un usuario
    Public Sub retirarExcedentesLlamado()
        Dim valores As Int32
        Dim cedulaNumAsociado As String = VGestionDeExcedentes.GestionExcTextboxCedulaNumAsociado.Text
        If (cedulaNumAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                valores = BD.retirarExcedente(cedulaNumAsociado)
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
