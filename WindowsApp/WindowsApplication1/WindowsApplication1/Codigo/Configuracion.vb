Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Configuracion
    Dim BD As ConexionBD = New ConexionBD
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim estado As Boolean = True
    Dim encabezado As EncabezadoClase = New EncabezadoClase

    Public Sub obtenerDatosSeleccionarCuentaGastosEIngresos()
        Dim valores As List(Of CuentaClase)
        Try
            BD.ConectarBD()
            valores = BD.consultarCuentas()
            If valores.Count <> 0 Then
                estado = True
                VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaEntrada.Items.Clear()
                VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaSalida.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While valores.Count > contador
                    If valores(contador).tipo = "Gasto" Then
                        VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaSalida.Items.Add(valores(contador).codDescripcion)
                        conta += 1
                    End If

                    If valores(contador).tipo = "Ingreso" Then
                        VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaEntrada.Items.Add(valores(contador).codDescripcion)
                        conta += 1
                    End If

                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False

                    VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaEntrada.Items.Clear()
                    VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaEntrada.Items.Add("No se poseen cuentas")

                    VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaSalida.Items.Clear()
                    VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaSalida.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False

                VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaSalida.Items.Clear()
                VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaSalida.Items.Add("No se poseen cuentas")

                VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaEntrada.Items.Clear()
                VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaEntrada.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub insertarCuenta()

        Dim valores As Integer
        Dim id As String = VConfiguracionCodigoCuenta.TextBox_ConfiguracionCuentaDescripcion.Text
        Dim tipo As String
        Dim proyecto_Productivo As String

        If (id = "") Then
            MessageBox.Show(variablesGlobales.mensajeDebeIngresarCodigoODescriptionDeCuenta, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If

        If (VConfiguracionCodigoCuenta.ConfiguracionRadioButtonIngresos.Checked = True) Then
            tipo = VConfiguracionCodigoCuenta.ConfiguracionRadioButtonIngresos.Text
        Else
            tipo = VConfiguracionCodigoCuenta.ConfigurationRadioButtonGasto.Text
        End If

        If (VConfiguracionCodigoCuenta.RadioButton_ConfiguracionProyectoProductivoSI.Checked = True) Then
            proyecto_Productivo = VConfiguracionCodigoCuenta.RadioButton_ConfiguracionProyectoProductivoSI.Text
        Else
            proyecto_Productivo = VConfiguracionCodigoCuenta.RadioButton_ConfiguracionProyectoProductivoNO.Text
        End If

        Try
            BD.ConectarBD()
            valores = BD.insertarCuenta(id, tipo, proyecto_Productivo)
            If valores <> 0 Then
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            'MessageBox.Show("El nombre de la Cuenta ya existe!")
        End Try
    End Sub


    Public Sub modificarCuenta()
        Dim valores As Integer
        Dim idAnt As String = ""
        Dim idCuentaE As String = VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaEntrada.Text
        Dim idCuentaS As String = VConfiguracionCodigoCuenta.ComboBox_CreacionCodCtaSalida.Text
        Dim idNuev As String = VConfiguracionCodigoCuenta.TextBox_ConfiguracionCuentaDescripcion.Text
        Dim tipo As String
        Dim proyecto_Productivo As String

        If (idCuentaS = "") Then
            idAnt = idCuentaE
        End If

        If (idCuentaE = "") Then
            idAnt = idCuentaS
        End If

        If (idNuev = "") Then
            MessageBox.Show(variablesGlobales.mensajeDebeIngresarCodigoODescriptionDeCuenta, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If

        If (VConfiguracionCodigoCuenta.ConfiguracionRadioButtonIngresos.Checked = True) Then
            tipo = VConfiguracionCodigoCuenta.ConfiguracionRadioButtonIngresos.Text
        Else
            tipo = VConfiguracionCodigoCuenta.ConfigurationRadioButtonGasto.Text
        End If

        If (VConfiguracionCodigoCuenta.RadioButton_ConfiguracionProyectoProductivoSI.Checked = True) Then
            proyecto_Productivo = VConfiguracionCodigoCuenta.RadioButton_ConfiguracionProyectoProductivoSI.Text
        Else
            proyecto_Productivo = VConfiguracionCodigoCuenta.RadioButton_ConfiguracionProyectoProductivoNO.Text
        End If

        Try
            BD.ConectarBD()
            valores = BD.modificarCuentaBD(idAnt, idNuev, tipo, proyecto_Productivo)
            If valores <> 0 Then
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("error: " + ex.Message)
        End Try
    End Sub

    Public Sub obtenerDatosCodCuenta()
        Dim valores As New List(Of String)
        Dim InputID As String = VConfiguracionCodigoCuenta.TextBox_ConfiguracionCuentaDescripcion.Text

        If (InputID = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
        Else
            Try
                BD.ConectarBD()

                valores = BD.obtenerCuentaBD(InputID)
                If valores.Count = 0 Then
                    MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    limpiar()

                Else
                    If valores.Item(0).Equals("Ingreso") Then
                        VConfiguracionCodigoCuenta.ConfiguracionRadioButtonIngresos.Checked = True
                        VConfiguracionCodigoCuenta.ConfigurationRadioButtonGasto.Checked = False
                    Else
                        VConfiguracionCodigoCuenta.ConfiguracionRadioButtonIngresos.Checked = False
                        VConfiguracionCodigoCuenta.ConfigurationRadioButtonGasto.Checked = True
                    End If
                    If valores.Item(1).Equals("Si") Then
                        VConfiguracionCodigoCuenta.RadioButton_ConfiguracionProyectoProductivoSI.Checked = True
                        VConfiguracionCodigoCuenta.RadioButton_ConfiguracionProyectoProductivoNO.Checked = False
                    Else
                        VConfiguracionCodigoCuenta.RadioButton_ConfiguracionProyectoProductivoSI.Checked = False
                        VConfiguracionCodigoCuenta.RadioButton_ConfiguracionProyectoProductivoNO.Checked = True
                    End If
                End If

                BD.CerrarConexion()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)

            End Try
        End If
    End Sub

    Public Sub eliminarCuenta()

        Dim valores As Integer
        Dim id As String = VConfiguracionCodigoCuenta.TextBox_ConfiguracionCuentaDescripcion.Text

        If (id = "") Then
            MessageBox.Show(variablesGlobales.mensajeDebeIngresarCodigoODescriptionDeCuenta, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If

        Try
            BD.ConectarBD()
            valores = BD.eliminarCuenta(id)

            If valores <> 0 Then
                MessageBox.Show(variablesGlobales.datosEliminadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub


    'Consulta todos los datos de la tabla de Configuración'
    Public Sub consultar()
        Dim valores As List(Of ConfiguracionClase)
        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeConfiguration()
            If valores.Count <> 0 Then
                llenarDatos(valores)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                limpiar()
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub


    'Consulta todos los datos de la tabla de Configuración para la sección de Informacion de la Coope'
    Public Sub consultarInformacionCooperativa()
        Dim valores As List(Of ConfiguracionClase)
        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeConfiguration()
            If valores.Count <> 0 Then
                llenarDatosInformacionCooperativa(valores)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                limpiar()
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub


    'Consulta todos los datos de la tabla de Configuración para la sección de Informacion de la Coope'
    Public Sub consultarPorcentajeReservas()
        Dim valores As List(Of ConfiguracionClase)
        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeConfiguration()
            If valores.Count <> 0 Then
                llenarDatosPorcentajeReserva(valores)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                limpiar()
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    'Consulta todos los datos de la tabla de Configuración para la sección de Informacion de la Coope'
    Public Sub consultarFechasLimite()
        Dim valores As List(Of ConfiguracionClase)
        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeConfiguration()
            If valores.Count <> 0 Then
                llenarDatosFechasLimite(valores)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                limpiar()
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub


    'Limpia los campos'
    Public Sub limpiar()
        VConfiguracionInformacionCooperativa.ConfiguracionTextBoxPeriodo.Text = ""
    End Sub

    'Llena los campos con los datos de la consulta
    Public Sub llenarDatosInformacionCooperativa(ByVal valores As List(Of ConfiguracionClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            VConfiguracionInformacionCooperativa.ConfiguracionTextBoxPeriodo.Text = valores(conta).periodo
            VConfiguracionInformacionCooperativa.ConfiguracionTextBoxCooperativa.Text = valores(conta).cooperativa
            VConfiguracionInformacionCooperativa.ConfiguracionTextBoxCedulaJuridica.Text = valores(conta).cedulaJuridica
            VConfiguracionInformacionCooperativa.ConfiguracionTextBoxTelefono.Text = valores(conta).telefono

            conta = conta + 1
        End While
    End Sub

    'Llena los campos con los datos de la consulta
    Public Sub llenarDatosPorcentajeReserva(ByVal valores As List(Of ConfiguracionClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            VConfiguracionPorcentajeReservas.ConfiguracionTextBoxLegal.Text = valores(conta).legal
            VConfiguracionPorcentajeReservas.ConfiguracionTextBoxEducacion.Text = valores(conta).educacion
            VConfiguracionPorcentajeReservas.ConfiguracionTextBoxBienestarSocial.Text = valores(conta).bienestarSocial
            VConfiguracionPorcentajeReservas.ConfiguracionTextBoxInstitucional.Text = valores(conta).institucional
            VConfiguracionPorcentajeReservas.ConfiguracionTextBoxPatrimonial.Text = valores(conta).patrimonial

            conta = conta + 1
        End While
    End Sub

    'Llena los campos con los datos de la consulta
    Public Sub llenarDatosFechasLimite(ByVal valores As List(Of ConfiguracionClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha1.Value = Date.Parse(valores(conta).fechaLimite1)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha2.Value = Date.Parse(valores(conta).fechaLimite2)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha3.Value = Date.Parse(valores(conta).fechaLimite3)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha4.Value = Date.Parse(valores(conta).fechaLimite4)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha5.Value = Date.Parse(valores(conta).fechaLimite5)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha6.Value = Date.Parse(valores(conta).fechaLimite6)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha7.Value = Date.Parse(valores(conta).fechaLimite7)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha8.Value = Date.Parse(valores(conta).fechaLimite8)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha9.Value = Date.Parse(valores(conta).fechaLimite9)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha10.Value = Date.Parse(valores(conta).fechaLimite10)

            conta = conta + 1
        End While
    End Sub

    'Llena los campos con los datos de la consulta
    Public Sub llenarDatos(ByVal valores As List(Of ConfiguracionClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            VConfiguracionInformacionCooperativa.ConfiguracionTextBoxPeriodo.Text = valores(conta).periodo
            VConfiguracionInformacionCooperativa.ConfiguracionTextBoxCooperativa.Text = valores(conta).cooperativa
            VConfiguracionInformacionCooperativa.ConfiguracionTextBoxCedulaJuridica.Text = valores(conta).cedulaJuridica
            VConfiguracionInformacionCooperativa.ConfiguracionTextBoxTelefono.Text = valores(conta).telefono

            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha1.Value = Date.Parse(valores(conta).fechaLimite1)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha2.Value = Date.Parse(valores(conta).fechaLimite2)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha3.Value = Date.Parse(valores(conta).fechaLimite3)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha4.Value = Date.Parse(valores(conta).fechaLimite4)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha5.Value = Date.Parse(valores(conta).fechaLimite5)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha6.Value = Date.Parse(valores(conta).fechaLimite6)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha7.Value = Date.Parse(valores(conta).fechaLimite7)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha8.Value = Date.Parse(valores(conta).fechaLimite8)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha9.Value = Date.Parse(valores(conta).fechaLimite9)
            VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha10.Value = Date.Parse(valores(conta).fechaLimite10)

            VConfiguracionPorcentajeReservas.ConfiguracionTextBoxLegal.Text = valores(conta).legal
            VConfiguracionPorcentajeReservas.ConfiguracionTextBoxEducacion.Text = valores(conta).educacion
            VConfiguracionPorcentajeReservas.ConfiguracionTextBoxBienestarSocial.Text = valores(conta).bienestarSocial
            VConfiguracionPorcentajeReservas.ConfiguracionTextBoxInstitucional.Text = valores(conta).institucional
            VConfiguracionPorcentajeReservas.ConfiguracionTextBoxPatrimonial.Text = valores(conta).patrimonial

            conta = conta + 1
        End While
    End Sub

    'Actualiza todos los datos en la tabla de Configuracion'
    Public Sub actualizar()
        Dim periodo As String = VConfiguracionInformacionCooperativa.ConfiguracionTextBoxPeriodo.Text
        Dim cooperativa As String = VConfiguracionInformacionCooperativa.ConfiguracionTextBoxCooperativa.Text
        Dim cedulaJuridica As String = VConfiguracionInformacionCooperativa.ConfiguracionTextBoxCedulaJuridica.Text
        Dim telefono As String = VConfiguracionInformacionCooperativa.ConfiguracionTextBoxTelefono.Text
        Dim fecha1 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha1.Value.ToString("dd/MM/yyyy")
        Dim fecha2 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha2.Value.ToString("dd/MM/yyyy")
        Dim fecha3 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha3.Value.ToString("dd/MM/yyyy")
        Dim fecha4 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha4.Value.ToString("dd/MM/yyyy")
        Dim fecha5 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha5.Value.ToString("dd/MM/yyyy")
        Dim fecha6 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha6.Value.ToString("dd/MM/yyyy")
        Dim fecha7 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha7.Value.ToString("dd/MM/yyyy")
        Dim fecha8 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha8.Value.ToString("dd/MM/yyyy")
        Dim fecha9 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha9.Value.ToString("dd/MM/yyyy")
        Dim fecha10 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha10.Value.ToString("dd/MM/yyyy")
        Dim legal As String = VConfiguracionPorcentajeReservas.ConfiguracionTextBoxLegal.Text
        Dim educacion As String = VConfiguracionPorcentajeReservas.ConfiguracionTextBoxEducacion.Text
        Dim bienestarSocial As String = VConfiguracionPorcentajeReservas.ConfiguracionTextBoxBienestarSocial.Text
        Dim institucional As String = VConfiguracionPorcentajeReservas.ConfiguracionTextBoxInstitucional.Text
        Dim patrimonial As String = VConfiguracionPorcentajeReservas.ConfiguracionTextBoxPatrimonial.Text

        If (periodo = "" Or cooperativa = "" Or cedulaJuridica = "" Or legal = "" Or educacion = "" Or bienestarSocial = "" Or institucional = "" Or patrimonial = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                Dim modificado = BD.actualizarConfiguracion(periodo, cooperativa, cedulaJuridica, telefono, fecha1, fecha2, fecha3, fecha4, fecha5,
                                                            fecha6, fecha7, fecha8, fecha9, fecha10, legal, educacion, bienestarSocial, institucional, patrimonial)
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

    'Actualiza todos los datos en la tabla de Configuracion relacionados a la info de la coope
    Public Sub actualizarInformacionCooperativa()
        Dim periodo As String = VConfiguracionInformacionCooperativa.ConfiguracionTextBoxPeriodo.Text
        Dim cooperativa As String = VConfiguracionInformacionCooperativa.ConfiguracionTextBoxCooperativa.Text
        Dim cedulaJuridica As String = VConfiguracionInformacionCooperativa.ConfiguracionTextBoxCedulaJuridica.Text
        Dim telefono As String = VConfiguracionInformacionCooperativa.ConfiguracionTextBoxTelefono.Text


        If (periodo = "" Or cooperativa = "" Or cedulaJuridica = "" Or telefono = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                Dim modificado = BD.actualizarConfiguracionInformacionCooperativa(periodo, cooperativa, cedulaJuridica, telefono)
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

    'Actualiza todos los datos en la tabla de Configuracion relacionados a las reservas
    Public Sub actualizarPorcentajeReservas()

        Dim legal As String = VConfiguracionPorcentajeReservas.ConfiguracionTextBoxLegal.Text
        Dim educacion As String = VConfiguracionPorcentajeReservas.ConfiguracionTextBoxEducacion.Text
        Dim bienestarSocial As String = VConfiguracionPorcentajeReservas.ConfiguracionTextBoxBienestarSocial.Text
        Dim institucional As String = VConfiguracionPorcentajeReservas.ConfiguracionTextBoxInstitucional.Text
        Dim patrimonial As String = VConfiguracionPorcentajeReservas.ConfiguracionTextBoxPatrimonial.Text

        If (legal = "" Or educacion = "" Or bienestarSocial = "" Or institucional = "" Or patrimonial = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                Dim modificado = BD.actualizarConfiguracionPorcentajeReservas(legal, educacion, bienestarSocial, institucional, patrimonial)
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

    'Actualiza todos los datos en la tabla de Configuracion'
    Public Sub actualizarFechasLimite()

        Dim fecha1 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha1.Value.ToString("dd/MM/yyyy")
        Dim fecha2 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha2.Value.ToString("dd/MM/yyyy")
        Dim fecha3 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha3.Value.ToString("dd/MM/yyyy")
        Dim fecha4 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha4.Value.ToString("dd/MM/yyyy")
        Dim fecha5 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha5.Value.ToString("dd/MM/yyyy")
        Dim fecha6 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha6.Value.ToString("dd/MM/yyyy")
        Dim fecha7 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha7.Value.ToString("dd/MM/yyyy")
        Dim fecha8 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha8.Value.ToString("dd/MM/yyyy")
        Dim fecha9 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha9.Value.ToString("dd/MM/yyyy")
        Dim fecha10 As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha10.Value.ToString("dd/MM/yyyy")

        Try
            BD.ConectarBD()
            Dim modificado = BD.actualizarConfiguracionFechasLimite(fecha1, fecha2, fecha3, fecha4, fecha5, fecha6, fecha7, fecha8, fecha9, fecha10)
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

    Public Sub generarReporteCodCuenta()
        Dim totalEntradas As Integer = 0
        Try
            Dim valores As List(Of CuentaClase)
            BD.ConectarBD()
            valores = BD.consultarCuentas()
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)
            Dim nombreReporte As String = "reporteCuentas.pdf"
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & nombreReporte, FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)

            Dim table As PdfPTable = New PdfPTable(3)

            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            Dim intTblWidth() As Integer = {10, 10, 10}
            table.SetWidths(intTblWidth)

            '/////// Titulo //////////
            Dim FontStype3 = FontFactory.GetFont("Arial", 8, Font.BOLD, BaseColor.BLACK)
            pdfDoc.Add(New Paragraph("                                                                                                           Reporte de Cuentas", FontStype3))
            pdfDoc.Add(New Paragraph(" "))

            '' PARA ENCABEZADO DEL REPORTE - COLUMNAS

            Dim codCuenta As PdfPCell = New PdfPCell(New Phrase("Código de cuenta", FontStype))
            codCuenta.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            codCuenta.Colspan = 1
            codCuenta.HorizontalAlignment = 1

            Dim proyProdCuenta As PdfPCell = New PdfPCell(New Phrase("Proyecto productivo", FontStype))
            proyProdCuenta.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            proyProdCuenta.Colspan = 1
            proyProdCuenta.HorizontalAlignment = 1

            Dim tipoCuenta As PdfPCell = New PdfPCell(New Phrase("Tipo", FontStype))
            tipoCuenta.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            tipoCuenta.Colspan = 1
            tipoCuenta.HorizontalAlignment = 1

            table.AddCell(codCuenta)
            table.AddCell(proyProdCuenta)
            table.AddCell(tipoCuenta)

            Dim contador As Integer = 0
            Dim conta As Integer = 0
            While contador < valores.Count
                If conta = 50 Then
                    pdfDoc.Add(table)
                    pdfDoc.NewPage()
                    encabezado.encabezado(pdfWrite, pdfDoc)
                    table.DeleteBodyRows()
                    conta = 0
                End If

                conta = conta + 1

                Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)

                Dim codDesc As PdfPCell = New PdfPCell(New Phrase(valores(contador).codDescripcion, FontStype2))
                codDesc.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                codDesc.Colspan = 1
                codDesc.HorizontalAlignment = 1

                Dim proyProd As PdfPCell = New PdfPCell(New Phrase(valores(contador).proyectoProductivo, FontStype2))
                proyProd.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                proyProd.Colspan = 1
                proyProd.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

                Dim tipo As PdfPCell = New PdfPCell(New Phrase(valores(contador).tipo, FontStype2))
                tipo.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                tipo.Colspan = 1
                tipo.HorizontalAlignment = 1

                table.AddCell(codDesc)
                table.AddCell(proyProd)
                table.AddCell(tipo)

                contador = contador + 1
            End While

            pdfDoc.Add(table)
            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & nombreReporte, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try
    End Sub
End Class
