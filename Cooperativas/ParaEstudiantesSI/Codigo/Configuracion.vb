Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Configuracion
    Dim BD As ConexionBD = New ConexionBD

    Public Sub consultar()
        Dim valores As List(Of ConfiguracionClase)
        Dim periodo As String = Ventana_Principal.ConfiguracionTextBoxPeriodo.Text

        If (periodo = "") Then
            MessageBox.Show("Debe ingresar el periodo a consultar")
            limpiar()
        Else
            Try
                BD.ConectarBD()
                valores = BD.obtenerDatosdeConfiguration(periodo)
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
        End If
    End Sub

    'Limpia los campos de Socios'
    Public Sub limpiar()
        Ventana_Principal.ConfiguracionTextBoxPeriodo.Text = ""
    End Sub

    'Llena los campos con los datos de la consulta
    Public Sub llenarDatos(ByVal valores As List(Of ConfiguracionClase))
        Dim conta As Integer = 0
        While conta < valores.Count
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
            conta = conta + 1
        End While
    End Sub

End Class
