Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Configuracion
    Dim BD As ConexionBD = New ConexionBD

    Public Sub consultar()
        Dim valores As List(Of ConfiguracionClase)
        Dim periodo As String = Ventana_Principal.ConfiguracionTextBoxPeriodo.Text

        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeConfiguration(periodo)

            ''Dim valores As List(Of String) = BD.consultarSocioPorCedula(cedula)            
            If valores.Count <> 0 Then
                '''llenarDatos(valores)
            End If
            'Muy importante cerrar conexion despues de cada consulta'
            'Cierro conexion'
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
            'MessageBox.Show("ocurrio el siguiente error:" + ex.ToString())
        End Try

    End Sub

End Class
