Public Class VConfiguracionCodigoCuenta

    Dim ingreso As Ingreso = New Ingreso
    Dim gasto As Gastos = New Gastos
    Dim configuracionCodigoCuenta As Configuracion = New Configuracion
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub VConfiguracionCodigoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_ConfiguracionInsertarCodigoCuenta.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_ConfiguracionEliminarCodigoCuenta.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

        configuracionCodigoCuenta.obtenerDatosSeleccionarCuentaGastosEIngresos()

    End Sub

    Private Sub Button_ConfiguracionInsertarCodigoCuenta_Click(sender As Object, e As EventArgs) Handles Button_ConfiguracionInsertarCodigoCuenta.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            configuracionCodigoCuenta.insertarCuenta()
            ingreso.obtenerDatosSeleccionarCuenta()
            gasto.obtenerDatosSeleccionarCuenta()
            configuracionCodigoCuenta.obtenerDatosSeleccionarCuentaGastosEIngresos()
            TextBox_ConfiguracionCuentaDescripcion.Text = ""
        End If
    End Sub

    Private Sub Button_ConfiguracionEliminarCodigoCuenta_Click(sender As Object, e As EventArgs) Handles Button_ConfiguracionEliminarCodigoCuenta.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            configuracionCodigoCuenta.eliminarCuenta()
            ingreso.obtenerDatosSeleccionarCuenta()
            gasto.obtenerDatosSeleccionarCuenta()
            configuracionCodigoCuenta.obtenerDatosSeleccionarCuentaGastosEIngresos()
            TextBox_ConfiguracionCuentaDescripcion.Text = ""
        End If
    End Sub

    Private Sub ComboBox_CreacionCodCtaEntrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_CreacionCodCtaEntrada.SelectedIndexChanged
        TextBox_ConfiguracionCuentaDescripcion.Text = ComboBox_CreacionCodCtaEntrada.Text
        configuracionCodigoCuenta.obtenerDatosCodCuenta()
    End Sub

    Private Sub ComboBox_CreacionCodCtaSalida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_CreacionCodCtaSalida.SelectedIndexChanged
        TextBox_ConfiguracionCuentaDescripcion.Text = ComboBox_CreacionCodCtaSalida.Text
        configuracionCodigoCuenta.obtenerDatosCodCuenta()
    End Sub

    Private Sub button_VConfiguracionCodCuenta_Modificar_Click(sender As Object, e As EventArgs) Handles button_VConfiguracionCodCuenta_Modificar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            configuracionCodigoCuenta.modificarCuenta()
            ingreso.obtenerDatosSeleccionarCuenta()
            gasto.obtenerDatosSeleccionarCuenta()
            configuracionCodigoCuenta.obtenerDatosSeleccionarCuentaGastosEIngresos()
            TextBox_ConfiguracionCuentaDescripcion.Text = ""
        End If
    End Sub

    Private Sub Button_ConfiguracionReportesCodigoCuenta_Click(sender As Object, e As EventArgs) Handles Button_ConfiguracionReportesCodigoCuenta.Click
        configuracionCodigoCuenta.generarReporteCodCuenta()
        Print.Show()
    End Sub

    Private Sub CrearReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearReporteToolStripMenuItem.Click

    End Sub

    Private Sub ReporteDeSaldosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeSaldosToolStripMenuItem.Click

    End Sub
End Class



