Public Class CuotaAdmision

    Dim BD As ConexionBD = New ConexionBD
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'Consulta todos los datos de la tabla de Cuota Admision
    Public Sub consultarInformacionAdmision()
        Dim valores As List(Of CuotaAdmisionClase)
        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeCuotaAdmision()
            If valores.Count <> 0 Then
                llenarDatos(valores)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    'Llena los campos con los datos de la consulta
    Public Sub llenarDatos(ByVal valores As List(Of CuotaAdmisionClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            VConfiguracionCuotaAdmision.ConfiguracionTextBoxCuotaAdmision.Text = valores(conta).cuota.ToString
            conta = conta + 1
        End While
    End Sub

    'Actualiza todos los datos en la tabla 
    Public Sub actualizarDatosDeCuotaAdmision()
        Dim cuota As Integer = Convert.ToInt16(VConfiguracionCuotaAdmision.ConfiguracionTextBoxCuotaAdmision.Text)

        Try
            BD.ConectarBD()
            Dim modificado = BD.actualizarConfiguracionCuotaAdmision(cuota)
            If modificado = 1 Then
                MessageBox.Show(variablesGlobales.datosActualizadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorActualizandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    'Consulta la cuota
    Public Sub consultarCuotaAdmision()
        Dim datos As List(Of CuotaAdmisionClase)
        Try
            BD.ConectarBD()
            datos = BD.obtenerDatosdeCuotaAdmision()
            If datos.Count <> 0 Then
                llenarDatosEnAsociados(datos)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    'Llena los campos con los datos de la consulta
    Public Sub llenarDatosEnAsociados(ByVal valores As List(Of CuotaAdmisionClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            VAsociados.TextBoxSociosEdad.Text = valores(conta).cuota.ToString
            conta = conta + 1
        End While
    End Sub

End Class
