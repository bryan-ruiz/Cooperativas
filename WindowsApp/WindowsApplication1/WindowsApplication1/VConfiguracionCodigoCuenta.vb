Public Class VConfiguracionCodigoCuenta

    Dim ingreso As Ingreso = New Ingreso
    Dim gasto As Gastos = New Gastos
    Dim configuracionCodigoCuenta As Configuracion = New Configuracion
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub Button_ConfiguracionInsertarCodigoCuenta_Click(sender As Object, e As EventArgs) Handles Button_ConfiguracionInsertarCodigoCuenta.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            configuracionCodigoCuenta.insertarCuenta()
            ingreso.obtenerDatosSeleccionarCuenta()
            gasto.obtenerDatosSeleccionarCuenta()
        End If
    End Sub

    Private Sub Button_ConfiguracionEliminarCodigoCuenta_Click(sender As Object, e As EventArgs) Handles Button_ConfiguracionEliminarCodigoCuenta.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            configuracionCodigoCuenta.eliminarCuenta()
            ingreso.obtenerDatosSeleccionarCuenta()
            gasto.obtenerDatosSeleccionarCuenta()
        End If
    End Sub
End Class