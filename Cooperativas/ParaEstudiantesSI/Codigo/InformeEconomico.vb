Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class InformeEconomico

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim BD As ConexionBD = New ConexionBD

    Dim subTotalIngresosProyectoProductivo As String
    Dim subTotalGastosProyectoProductivo As String
    Dim subTotalOtrosIngresos As String
    Dim subTotalOtrosGastos As String


    Public Sub generarInformeEconomico()
        Dim fechaDesde As Date = Ventana_Principal.InformeDateTimePickerDesde.Value.ToString("dd/MM/yyyy")
        Dim fechaHasta As Date = Ventana_Principal.InformeDateTimePickerHasta.Value.ToString("dd/MM/yyyy")

        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            ingresosTotales("Ingreso", "Si", fechaDesde, fechaHasta)
            'ingresosTotales("Ingreso", "No", fechaDesde, fechaHasta)
        End If
    End Sub

    'Consulta todos los ingresos y gastos por tipo de proyecto productivo y genera un informe
    Public Sub ingresosTotales(ByVal ingresoOGasto As String, ByVal esProyProductivo As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date)
        Dim valores As List(Of String)
        Try
            BD.ConectarBD()
            valores = BD.obtenerInformeIngresosOGasto(ingresoOGasto, esProyProductivo, "#" + fechaDesde + "#", "#" + fechaHasta + "#")
            If valores.Count <> 0 Then
                'llenarDatos(valores)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos)
                'limpiar()
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
        End Try
    End Sub


End Class
