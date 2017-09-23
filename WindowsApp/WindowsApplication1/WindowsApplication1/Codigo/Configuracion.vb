Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Configuracion
    Dim BD As ConexionBD = New ConexionBD
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Public Sub insertarCuenta()

        Dim valores As Integer
        Dim id As String = Ventana_Principal.TextBox_ConfiguracionCuentaDescripcion.Text
        Dim tipo As String
        Dim proyecto_Productivo As String

        If (id = "") Then
            MessageBox.Show(variablesGlobales.mensajeDebeIngresarCodigoODescriptionDeCuenta, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If

        If (Ventana_Principal.ConfiguracionRadioButtonIngresos.Checked = True) Then
            tipo = Ventana_Principal.ConfiguracionRadioButtonIngresos.Text
        Else
            tipo = Ventana_Principal.ConfigurationRadioButtonGasto.Text
        End If

        If (Ventana_Principal.RadioButton_ConfiguracionProyectoProductivoSI.Checked = True) Then
            proyecto_Productivo = Ventana_Principal.RadioButton_ConfiguracionProyectoProductivoSI.Text
        Else
            proyecto_Productivo = Ventana_Principal.RadioButton_ConfiguracionProyectoProductivoNO.Text
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
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
        End Try
    End Sub

    Public Sub eliminarCuenta()

        Dim valores As Integer
        Dim id As String = Ventana_Principal.TextBox_ConfiguracionCuentaDescripcion.Text

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
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
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
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
        End Try
    End Sub

    'Limpia los campos de Socios'
    Public Sub limpiar()
        Ventana_Principal.ConfiguracionTextBoxPeriodo.Text = ""
    End Sub

    'Llena los campos con los datos de la consulta
    Public Sub llenarDatos(ByVal valores As List(Of ConfiguracionClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            Ventana_Principal.ConfiguracionTextBoxPeriodo.Text = valores(conta).periodo
            Ventana_Principal.ConfiguracionTextBoxCooperativa.Text = valores(conta).cooperativa
            Ventana_Principal.ConfiguracionTextBoxCedulaJuridica.Text = valores(conta).cedulaJuridica
            Ventana_Principal.ConfiguracionTextBoxTelefono.Text = valores(conta).telefono
            Ventana_Principal.ConfiguracionDateTimePickerFecha1.Value = Date.Parse(valores(conta).fechaLimite1)
            Ventana_Principal.ConfiguracionDateTimePickerFecha2.Value = Date.Parse(valores(conta).fechaLimite2)
            Ventana_Principal.ConfiguracionDateTimePickerFecha3.Value = Date.Parse(valores(conta).fechaLimite3)
            Ventana_Principal.ConfiguracionDateTimePickerFecha4.Value = Date.Parse(valores(conta).fechaLimite4)
            Ventana_Principal.ConfiguracionDateTimePickerFecha5.Value = Date.Parse(valores(conta).fechaLimite5)
            Ventana_Principal.ConfiguracionDateTimePickerFecha6.Value = Date.Parse(valores(conta).fechaLimite6)
            Ventana_Principal.ConfiguracionDateTimePickerFecha7.Value = Date.Parse(valores(conta).fechaLimite7)
            Ventana_Principal.ConfiguracionDateTimePickerFecha8.Value = Date.Parse(valores(conta).fechaLimite8)
            Ventana_Principal.ConfiguracionDateTimePickerFecha9.Value = Date.Parse(valores(conta).fechaLimite9)
            Ventana_Principal.ConfiguracionDateTimePickerFecha10.Value = Date.Parse(valores(conta).fechaLimite10)
            Ventana_Principal.ConfiguracionTextBoxLegal.Text = valores(conta).legal
            Ventana_Principal.ConfiguracionTextBoxEducacion.Text = valores(conta).educacion
            Ventana_Principal.ConfiguracionTextBoxBienestarSocial.Text = valores(conta).bienestarSocial
            Ventana_Principal.ConfiguracionTextBoxInstitucional.Text = valores(conta).institucional
            Ventana_Principal.ConfiguracionTextBoxPatrimonial.Text = valores(conta).patrimonial

            conta = conta + 1
        End While
    End Sub

    'Actualiza todos los datos en la tabla de Configuracion'
    Public Sub actualizar()
        Dim periodo As String = Ventana_Principal.ConfiguracionTextBoxPeriodo.Text
        Dim cooperativa As String = Ventana_Principal.ConfiguracionTextBoxCooperativa.Text
        Dim cedulaJuridica As String = Ventana_Principal.ConfiguracionTextBoxCedulaJuridica.Text
        Dim telefono As String = Ventana_Principal.ConfiguracionTextBoxTelefono.Text
        Dim fecha1 As Date = Ventana_Principal.ConfiguracionDateTimePickerFecha1.Value.ToString("dd/MM/yyyy")
        Dim fecha2 As Date = Ventana_Principal.ConfiguracionDateTimePickerFecha2.Value.ToString("dd/MM/yyyy")
        Dim fecha3 As Date = Ventana_Principal.ConfiguracionDateTimePickerFecha3.Value.ToString("dd/MM/yyyy")
        Dim fecha4 As Date = Ventana_Principal.ConfiguracionDateTimePickerFecha4.Value.ToString("dd/MM/yyyy")
        Dim fecha5 As Date = Ventana_Principal.ConfiguracionDateTimePickerFecha5.Value.ToString("dd/MM/yyyy")
        Dim fecha6 As Date = Ventana_Principal.ConfiguracionDateTimePickerFecha6.Value.ToString("dd/MM/yyyy")
        Dim fecha7 As Date = Ventana_Principal.ConfiguracionDateTimePickerFecha7.Value.ToString("dd/MM/yyyy")
        Dim fecha8 As Date = Ventana_Principal.ConfiguracionDateTimePickerFecha8.Value.ToString("dd/MM/yyyy")
        Dim fecha9 As Date = Ventana_Principal.ConfiguracionDateTimePickerFecha9.Value.ToString("dd/MM/yyyy")
        Dim fecha10 As Date = Ventana_Principal.ConfiguracionDateTimePickerFecha10.Value.ToString("dd/MM/yyyy")
        Dim legal As String = Ventana_Principal.ConfiguracionTextBoxLegal.Text
        Dim educacion As String = Ventana_Principal.ConfiguracionTextBoxEducacion.Text
        Dim bienestarSocial As String = Ventana_Principal.ConfiguracionTextBoxBienestarSocial.Text
        Dim institucional As String = Ventana_Principal.ConfiguracionTextBoxInstitucional.Text
        Dim patrimonial As String = Ventana_Principal.ConfiguracionTextBoxPatrimonial.Text

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
                MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
            End Try
        End If
    End Sub

End Class
