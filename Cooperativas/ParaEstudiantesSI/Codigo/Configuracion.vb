Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Configuracion
    Dim BD As ConexionBD = New ConexionBD

    Public Sub insertarCuenta()
        Dim valores As Integer
        Dim id As String = Ventana_Principal.TextBox_ConfiguracionCuentaDescripcion.Text
        Dim tipo As String
        Dim proyecto_Productivo As String

        If (id = "") Then
            MessageBox.Show("Debe ingresar el codigo y descripción de la cuenta")
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
                MessageBox.Show("Se ha realizado exitosamente")
            Else
                MessageBox.Show("Error al insertar cuenta")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
            'MessageBox.Show("ocurrio el siguiente error:" + ex.ToString())
        End Try
    End Sub

    Public Sub eliminarCuenta()
        Dim valores As Integer
        Dim id As String = Ventana_Principal.TextBox_ConfiguracionCuentaDescripcion.Text
        If (id = "") Then
            MessageBox.Show("Debe ingresar el codigo y descripción de la cuenta")
        End If

        Try
            BD.ConectarBD()
            valores = BD.eliminarCuenta(id)
            If valores <> 0 Then
                MessageBox.Show("Se ha realizado exitosamente")
            Else
                MessageBox.Show("Error: no se encontró la cuenta")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
            'MessageBox.Show("ocurrio el siguiente error:" + ex.ToString())
        End Try
    End Sub

    Public Sub consultar()
        Dim valores As List(Of ConfiguracionClase)
        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeConfiguration()
            If valores.Count <> 0 Then
                llenarDatos(valores)
            Else
                MessageBox.Show("El Periodo a consultar no existe")
                limpiar()
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
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

End Class
