Imports Cooperativas.Socios


Public Class Ventana_Principal

    Dim BD As ConexionBD = New ConexionBD
    Dim socios As Socios = New Socios
    Dim comites As Comites = New Comites
    Dim usuarios As Usuarios = New Usuarios
    Dim ingreso As Ingreso = New Ingreso
    Dim gasto As Gastos = New Gastos
    Dim configuracion As Configuracion = New Configuracion
    Dim certificados As Certificados = New Certificados



    '//////////////////////////
    '///////  SOCIOS //////////
    '//////////////////////////

    'Consultar Socios por Cedula
    Private Sub ButtonSociosConsultar_Click(sender As Object, e As EventArgs)
        socios.consultar()
    End Sub

    'Insertar Socios
    Private Sub ButtonSociosInsertar_Click(sender As Object, e As EventArgs)
        socios.insertar()
    End Sub

    'Actualizar Socios
    Private Sub ButtonSociosModificar_Click(sender As Object, e As EventArgs)
        socios.actualizar()
    End Sub

    'Reporte de Socios (Activos o activos más inactivos)
    Private Sub ButtonSociosReporteDeSocios_Click(sender As Object, e As EventArgs)
        socios.generarReporteDeSocios()
        Print.Show()
    End Sub

    'Salir de la app
    Private Sub ButtonSociosSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
        Ventana_Acceso.Close()
    End Sub

    'Radio socio retirado
    Private Sub RadioButtonSociosRetirado_CheckedChanged(sender As Object, e As EventArgs)
        mostrarOcultarCamposRetiro(True)
    End Sub

    'Radio socio activo
    Private Sub RadioButtonSociosActivo_CheckedChanged(sender As Object, e As EventArgs)
        mostrarOcultarCamposRetiro(False)
    End Sub

    'Muestra u oculta los campos de retiro 
    Private Sub mostrarOcultarCamposRetiro(ByVal value As Boolean)
        Me.TextBoxSociosNotasRetiro.Visible = value
        Me.DateTimeSociosFechaRetiro.Visible = value
        Me.LabelSociosFechaRetiro.Visible = value
        Me.LabelSociosNotasRetiro.Visible = value
    End Sub

    Private Sub ButtonSociosConsultar_Click_1(sender As Object, e As EventArgs) Handles ButtonSociosConsultar.Click
        socios.consultar()
    End Sub

    Private Sub ButtonSociosInsertar_Click_1(sender As Object, e As EventArgs) Handles ButtonSociosInsertar.Click
        socios.insertar()
    End Sub

    Private Sub ButtonSociosModificar_Click_1(sender As Object, e As EventArgs) Handles ButtonSociosModificar.Click
        socios.actualizar()
    End Sub

    Private Sub ButtonSociosReporteDeSocios_Click_1(sender As Object, e As EventArgs) Handles ButtonSociosReporteDeSocios.Click
        socios.generarReporteDeSocios()
        Print.Show()
    End Sub

    Private Sub ButtonSociosSalir_Click_1(sender As Object, e As EventArgs) Handles ButtonSociosSalir.Click
        Me.Close()
        Ventana_Acceso.Close()
    End Sub

    Private Sub RadioButtonSociosActivo_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButtonSociosActivo.CheckedChanged
        mostrarOcultarCamposRetiro(False)
    End Sub

    Private Sub RadioButtonSociosRetirado_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButtonSociosRetirado.CheckedChanged
        mostrarOcultarCamposRetiro(True)
    End Sub


    '//////////////////////////
    '///////  COMITES //////////
    '//////////////////////////


    Private Sub ButtonBuscar_asociadoPresidente_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoPresidente.Click
        Comites.buscar("presidente")
    End Sub

    Private Sub ButtonBuscar_asociadoVicePresidente_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoVicePresidente.Click
        Comites.buscar("vicePresidente")
    End Sub

    Private Sub ButtonBuscar_asociadoSecretaria_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoSecretaria.Click
        comites.buscar("secretaria")
    End Sub

    Private Sub ButtonBuscar_asociadoVocal1_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoVocal1.Click
        comites.buscar("vocal1")
    End Sub

    Private Sub ButtonBuscar_asociadoVocal2_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoVocal2.Click
        comites.buscar("vocal2")
    End Sub

    Private Sub ButtonBuscar_asociadoSuplente1_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoSuplente1.Click
        comites.buscar("suplente1")
    End Sub

    Private Sub ButtonBuscar_asociadoSuplente2_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoSuplente2.Click
        comites.buscar("suplente2")
    End Sub

    Private Sub ButtonConsultar_InformacionAccidente_Click(sender As Object, e As EventArgs) Handles ButtonConsultar_InformacionAccidente.Click
        comites.limpiar()
        comites.consultar()
    End Sub

    Private Sub ButtonModificar_InformacionAccidente_Click(sender As Object, e As EventArgs) Handles ButtonModificar_InformacionAccidente.Click
        comites.actualizarComiteF()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        comites.generarReporteDeComites()
        Print.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Ventana_Acceso.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonUsuariosSalir.Click
        Me.Close()
        Ventana_Acceso.Close()
    End Sub

    '//////////////////////////
    '///////  USUARIOS //////////
    '//////////////////////////

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonUsuariosEliminar.Click
        usuarios.eliminar()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles ButtonUsuariosInsertar.Click
        usuarios.insertar()
    End Sub

    '//////////////////////////
    '///////  CERTIFICADOS ////
    '//////////////////////////

    Private Sub CertificadosButtonConsultar_Click(sender As Object, e As EventArgs) Handles CertificadosButtonConsultar.Click
        certificados.consultar()
    End Sub

    Private Sub CertificadosButtonGuardar_Click(sender As Object, e As EventArgs) Handles CertificadosButtonGuardar.Click

    End Sub

    Private Sub CertificadosButtonComprobante_Click(sender As Object, e As EventArgs) Handles CertificadosButtonComprobante.Click

    End Sub

    Private Sub CertificadosButtonCerrarPeriodo_Click(sender As Object, e As EventArgs) Handles CertificadosButtonCerrarPeriodo.Click

    End Sub

    Private Sub CertificadosButtonSalir_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSalir.Click
        Me.Close()
        Ventana_Acceso.Close()
    End Sub

    '//////////////////////////
    '///////  CONFIGURACION //////////
    '//////////////////////////


    Private Sub ConfigurationButtonConsultar_Click(sender As Object, e As EventArgs) Handles ConfigurationButtonConsultar.Click
        configuracion.consultar()
    End Sub

    Private Sub ConfigurationButtonActualizar_Click(sender As Object, e As EventArgs) Handles ConfigurationButtonActualizar.Click
        configuracion.actualizar()
    End Sub

    Private Sub Button_ConfiguracionInsertarCodigoCuenta_Click(sender As Object, e As EventArgs) Handles Button_ConfiguracionInsertarCodigoCuenta.Click
        configuracion.insertarCuenta()
        ingreso.obtenerDatosSeleccionarCuenta()
        gasto.obtenerDatosSeleccionarCuenta()
    End Sub

    Private Sub Button_IngresosInsertar_Click(sender As Object, e As EventArgs) Handles Button_IngresosInsertar.Click
        ingreso.insertarIngreso()
    End Sub

    Private Sub cargar(sender As Object, e As EventArgs) Handles MyBase.Load
        ingreso.obtenerDatosSeleccionarCuenta()
        gasto.obtenerDatosSeleccionarCuenta()
    End Sub

    Private Sub Button_IngresosCalcularTotal_Click(sender As Object, e As EventArgs) Handles Button_IngresosCalcularTotal.Click
        ingreso.calcular()
    End Sub

    Private Sub Button_IngresosReporteIngresos_Click(sender As Object, e As EventArgs) Handles Button_IngresosReporteIngresos.Click
        ingreso.generarReporteIngresos()
        Print.Show()
    End Sub

    Private Sub Button_GastosCalcular_Click(sender As Object, e As EventArgs) Handles Button_GastosCalcular.Click
        gasto.calcular()
    End Sub

    Private Sub Button_GastosAgregar_Click(sender As Object, e As EventArgs) Handles Button_GastosAgregar.Click
        gasto.insertarGasto()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        gasto.generarReporteGastos()
        Print.Show()
    End Sub

    Private Sub Button_ConfiguracionEliminarCodigoCuenta_Click(sender As Object, e As EventArgs) Handles Button_ConfiguracionEliminarCodigoCuenta.Click
        configuracion.eliminarCuenta()
        ingreso.obtenerDatosSeleccionarCuenta()
        gasto.obtenerDatosSeleccionarCuenta()
    End Sub

    Private Sub CertificadosButtonSaveTracto1_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto1.Click
        Dim GETDATE As DateTime = DateTime.Today
        Dim fecha As DateTime = Me.CertificadosDateTimePickerFecha1.Value
        '<>
        If fecha.CompareTo(GETDATE) < 0 Then
            MessageBox.Show("No se puede ingresar el Tracto debido a que la fecha límite es menor a la fecha actual")
        End If
    End Sub


End Class


