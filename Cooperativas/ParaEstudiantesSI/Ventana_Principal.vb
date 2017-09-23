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
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim informeEconomico As InformeEconomico = New InformeEconomico


    '//////////////////////////
    '///////  SOCIOS //////////
    '//////////////////////////

    Private Sub ButtonSociosConsultar_Click(sender As Object, e As EventArgs)
        socios.consultar()
    End Sub

    Private Sub ButtonSociosInsertar_Click(sender As Object, e As EventArgs)
        socios.insertar()
    End Sub

    Private Sub ButtonSociosModificar_Click(sender As Object, e As EventArgs)
        socios.actualizar()
    End Sub

    Private Sub SociosButtonLimpiar_Click(sender As Object, e As EventArgs) Handles SociosButtonLimpiar.Click
        socios.limpiar()
    End Sub

    'Reporte de Socios (Activos o Todos (activos más inactivos))
    Private Sub ButtonSociosReporteDeSocios_Click(sender As Object, e As EventArgs)
        socios.generarReporteDeSocios()
        Print.Show()
    End Sub

    Private Sub ButtonSociosSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
        Ventana_Acceso.Close()
    End Sub

    Private Sub RadioButtonSociosRetirado_CheckedChanged(sender As Object, e As EventArgs)
        mostrarOcultarCamposRetiro(True)
    End Sub

    Private Sub RadioButtonSociosActivo_CheckedChanged(sender As Object, e As EventArgs)
        mostrarOcultarCamposRetiro(False)
    End Sub

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

    Private Sub ButtonModificar_InformacionAccidente_Click(sender As Object, e As EventArgs) Handles ButtonModificar_InformacionAccidente.Click
        comites.actualizarComiteF()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        comites.generarReporteDeComites()
        Print.Show()
    End Sub


    '//////////////////////////
    '///////  USUARIOS //////////
    '//////////////////////////

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonUsuariosEliminar.Click

        'TEMPORAL PARA LA VERSION BETA
        MessageBox.Show("No tiene licencia para realizar la acción. Contacte al Administrador del Sistema.")

        'If Singleton.rol = "Colaborador" Then
        'MessageBox.Show("Se requiere tener permiso de Administrador para realizar acción.")
        'Else
        'usuarios.eliminar()
        'End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles ButtonUsuariosInsertar.Click

        'TEMPORAL PARA LA VERSION BETA
        MessageBox.Show("No tiene licencia para realizar la acción. Contacte al Administrador del Sistema.")

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

    Private Sub CertificadosButtonComprobante_Click(sender As Object, e As EventArgs) Handles CertificadosButtonComprobante.Click
        certificados.comprobante()
    End Sub

    Private Sub CertificadosButtonCerrarPeriodo_Click(sender As Object, e As EventArgs) Handles CertificadosButtonCerrarPeriodo.Click
        certificados.cerrarCertificado()
    End Sub

    Private Sub CertificadosButtonLimpiar_Click(sender As Object, e As EventArgs) Handles CertificadosButtonLimpiar.Click
        certificados.limpiar()
    End Sub


    '//////////////////////////
    '///////  CONFIGURACION ///
    '//////////////////////////

    Private Sub ConfigurationButtonConsultar_Click(sender As Object, e As EventArgs) Handles ConfigurationButtonConsultar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            configuracion.consultar()
        End If
    End Sub

    Private Sub ConfigurationButtonActualizar_Click(sender As Object, e As EventArgs) Handles ConfigurationButtonActualizar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            configuracion.actualizar()
        End If

    End Sub

    Private Sub Button_ConfiguracionInsertarCodigoCuenta_Click(sender As Object, e As EventArgs) Handles Button_ConfiguracionInsertarCodigoCuenta.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            configuracion.insertarCuenta()
            ingreso.obtenerDatosSeleccionarCuenta()
            gasto.obtenerDatosSeleccionarCuenta()
        End If

    End Sub

    Private Sub Button_ConfiguracionEliminarCodigoCuenta_Click(sender As Object, e As EventArgs) Handles Button_ConfiguracionEliminarCodigoCuenta.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            configuracion.eliminarCuenta()
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

    '// Evento para salir del sistema, cierra las 2 ventanas abiertas
    Private Sub salirAPP(sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.Closing
        Dim result As DialogResult = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Ventana_Acceso.Close()
            Me.Close()
        End If
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

    Private Sub CertificadosButtonSaveTracto1_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto1.Click
        certificados.validarTracto("1", Me.CertificadosDateTimePickerFecha1.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto2_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto2.Click
        certificados.validarTracto("2", Me.CertificadosDateTimePickerFecha2.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto3_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto3.Click
        certificados.validarTracto("3", Me.CertificadosDateTimePickerFecha3.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto4_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto4.Click
        certificados.validarTracto("4", Me.CertificadosDateTimePickerFecha4.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto5_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto5.Click
        certificados.validarTracto("5", Me.CertificadosDateTimePickerFecha5.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto6_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto6.Click
        certificados.validarTracto("6", Me.CertificadosDateTimePickerFecha6.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto7_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto7.Click
        certificados.validarTracto("7", Me.CertificadosDateTimePickerFecha7.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto8_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto8.Click
        certificados.validarTracto("8", Me.CertificadosDateTimePickerFecha8.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto9_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto9.Click
        certificados.validarTracto("9", Me.CertificadosDateTimePickerFecha9.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto10_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto10.Click
        certificados.validarTracto("10", Me.CertificadosDateTimePickerFecha10.Value)
    End Sub


    '///////////////////////////////
    '///////  INFORME ECONÓMICO ////
    '///////////////////////////////

    Private Sub InformeButtonGenerarInforme_Click(sender As Object, e As EventArgs) Handles InformeButtonGenerarInforme.Click
        informeEconomico.generarInformeEconomico()
        Print.Show()
    End Sub

    Private Sub ComboBoxComitesNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxComitesNombre.SelectedIndexChanged
        comites.limpiar()
        comites.consultar(ComboBoxComitesNombre.Text)
    End Sub

    Private Sub TextBoxSociosCedula_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosCedula.KeyPress
        Me.TextBoxSociosCedula.MaxLength = 1
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosCedula2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosCedula2.KeyPress
        Me.TextBoxSociosCedula2.MaxLength = 4
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosCedula3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosCedula3.KeyPress
        Me.TextBoxSociosCedula3.MaxLength = 4
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosNumAsociado_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosNumAsociado.KeyPress
        'Valida que sólo ingrese números en el field
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosTelefono_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosTelefono.KeyPress
        Me.TextBoxSociosCedula3.MaxLength = 4
        'Valida que sólo ingrese números en el field
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
