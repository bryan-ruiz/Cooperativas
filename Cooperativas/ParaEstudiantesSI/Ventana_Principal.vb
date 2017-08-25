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
        MessageBox.Show("No tiene licencia para eliminar usuarios. Contacte al administrador del Sistema.")
        'If Singleton.rol = "Colaborador" Then
        'MessageBox.Show("Se requiere tener permiso de Administrador para realizar acción.")
        'Else
        'usuarios.eliminar()
        'End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles ButtonUsuariosInsertar.Click
        MessageBox.Show("No tiene licencia para crear usuarios. Contacte al administrador del Sistema.")

        'If Singleton.rol = "Colaborador" Then
        'MessageBox.Show("Se requiere tener permiso de Administrador para realizar acción.")
        'Else
        'usuarios.insertar()
        'End If
    End Sub

    '//////////////////////////
    '///////  CERTIFICADOS ////
    '//////////////////////////

    Private Sub CertificadosButtonConsultar_Click(sender As Object, e As EventArgs) Handles CertificadosButtonConsultar.Click
        certificados.consultar()
    End Sub

    Private Sub CertificadosButtonGuardar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CertificadosButtonComprobante_Click(sender As Object, e As EventArgs) Handles CertificadosButtonComprobante.Click

    End Sub

    Private Sub CertificadosButtonCerrarPeriodo_Click(sender As Object, e As EventArgs) Handles CertificadosButtonCerrarPeriodo.Click
        certificados.cerrarCertificado()
    End Sub

    Private Sub CertificadosButtonSalir_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSalir.Click
        Me.Close()
        Ventana_Acceso.Close()
    End Sub

    '//////////////////////////
    '///////  CONFIGURACION //////////
    '//////////////////////////


    Private Sub ConfigurationButtonConsultar_Click(sender As Object, e As EventArgs) Handles ConfigurationButtonConsultar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show("Se requiere tener permiso de Administrador para realizar acción.")
        Else
            configuracion.consultar()
        End If
    End Sub

    Private Sub ConfigurationButtonActualizar_Click(sender As Object, e As EventArgs) Handles ConfigurationButtonActualizar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show("Se requiere tener permiso de Administrador para realizar acción.")
        Else
            configuracion.actualizar()
        End If

    End Sub

    Private Sub Button_ConfiguracionInsertarCodigoCuenta_Click(sender As Object, e As EventArgs) Handles Button_ConfiguracionInsertarCodigoCuenta.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show("Se requiere tener permiso de Administrador para realizar acción.")
        Else
            configuracion.insertarCuenta()
            ingreso.obtenerDatosSeleccionarCuenta()
            gasto.obtenerDatosSeleccionarCuenta()
        End If

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
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show("Se requiere tener permiso de Administrador para realizar acción.")
        Else
            configuracion.eliminarCuenta()
            ingreso.obtenerDatosSeleccionarCuenta()
            gasto.obtenerDatosSeleccionarCuenta()
        End If

    End Sub

    'Valida la fecha límite
    Private Function validarFecha(ByVal fecha As DateTime) As Boolean
        Dim value As Boolean = False
        Dim GETDATE As DateTime = DateTime.Today

        If fecha.CompareTo(GETDATE) > 0 Then
            value = False
        End If
        If fecha.CompareTo(GETDATE) < 0 Then
            value = True
        End If

        Return value

    End Function

    Private Sub CertificadosButtonSaveTracto1_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto1.Click
        Dim fecha As DateTime = Me.CertificadosDateTimePickerFecha1.Value

        If validarFecha(fecha) Then
            MessageBox.Show("No se puede ingresar el Tracto debido a que la fecha límite es menor a la fecha actual")
        Else
            certificados.editarTracto("1")
            certificados.sumarTractosEnCertificados()
        End If
    End Sub

    Private Sub CertificadosButtonSaveTracto2_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto2.Click
        Dim fecha As DateTime = Me.CertificadosDateTimePickerFecha2.Value

        If validarFecha(fecha) Then
            MessageBox.Show("No se puede ingresar el Tracto debido a que la fecha límite es menor a la fecha actual")
        Else
            certificados.editarTracto("2")
            certificados.sumarTractosEnCertificados()
        End If
    End Sub

    Private Sub CertificadosButtonSaveTracto3_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto3.Click
        Dim fecha As DateTime = Me.CertificadosDateTimePickerFecha3.Value

        If validarFecha(fecha) Then
            MessageBox.Show("No se puede ingresar el Tracto debido a que la fecha límite es menor a la fecha actual")
        Else
            certificados.editarTracto("3")
            certificados.sumarTractosEnCertificados()
        End If
    End Sub

    Private Sub CertificadosButtonSaveTracto4_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto4.Click
        Dim fecha As DateTime = Me.CertificadosDateTimePickerFecha4.Value

        If validarFecha(fecha) Then
            MessageBox.Show("No se puede ingresar el Tracto debido a que la fecha límite es menor a la fecha actual")
        Else
            certificados.editarTracto("4")
            certificados.sumarTractosEnCertificados()
        End If
    End Sub

    Private Sub CertificadosButtonSaveTracto5_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto5.Click
        Dim fecha As DateTime = Me.CertificadosDateTimePickerFecha5.Value

        If validarFecha(fecha) Then
            MessageBox.Show("No se puede ingresar el Tracto debido a que la fecha límite es menor a la fecha actual")
        Else
            certificados.editarTracto("5")
            certificados.sumarTractosEnCertificados()
        End If
    End Sub

    Private Sub CertificadosButtonSaveTracto6_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto6.Click
        Dim fecha As DateTime = Me.CertificadosDateTimePickerFecha6.Value

        If validarFecha(fecha) Then
            MessageBox.Show("No se puede ingresar el Tracto debido a que la fecha límite es menor a la fecha actual")
        Else
            certificados.editarTracto("6")
            certificados.sumarTractosEnCertificados()
        End If
    End Sub

    Private Sub CertificadosButtonSaveTracto7_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto7.Click
        Dim fecha As DateTime = Me.CertificadosDateTimePickerFecha7.Value

        If validarFecha(fecha) Then
            MessageBox.Show("No se puede ingresar el Tracto debido a que la fecha límite es menor a la fecha actual")
        Else
            certificados.editarTracto("7")
            certificados.sumarTractosEnCertificados()
        End If
    End Sub

    Private Sub CertificadosButtonSaveTracto8_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto8.Click
        Dim fecha As DateTime = Me.CertificadosDateTimePickerFecha8.Value

        If validarFecha(fecha) Then
            MessageBox.Show("No se puede ingresar el Tracto debido a que la fecha límite es menor a la fecha actual")
        Else
            certificados.editarTracto("8")
            certificados.sumarTractosEnCertificados()
        End If
    End Sub

    Private Sub CertificadosButtonSaveTracto9_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto9.Click
        Dim fecha As DateTime = Me.CertificadosDateTimePickerFecha9.Value

        If validarFecha(fecha) Then
            MessageBox.Show("No se puede ingresar el Tracto debido a que la fecha límite es menor a la fecha actual")
        Else
            certificados.editarTracto("9")
            certificados.sumarTractosEnCertificados()
        End If
    End Sub

    Private Sub CertificadosButtonSaveTracto10_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto10.Click
        Dim fecha As DateTime = Me.CertificadosDateTimePickerFecha10.Value

        If validarFecha(fecha) Then
            MessageBox.Show("No se puede ingresar el Tracto debido a que la fecha límite es menor a la fecha actual")
        Else
            certificados.editarTracto("10")
            certificados.sumarTractosEnCertificados()
        End If
    End Sub


    '//////////////////////////
    '///////  INFORME ECONÓMICO //////////
    '//////////////////////////

    Private Sub InformeButtonGenerarInforme_Click(sender As Object, e As EventArgs) Handles InformeButtonGenerarInforme.Click

    End Sub
End Class


