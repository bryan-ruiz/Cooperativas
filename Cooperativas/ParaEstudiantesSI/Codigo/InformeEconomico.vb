Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class InformeEconomico

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim table As PdfPTable = New PdfPTable(6)

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
            generarInformeTabla()
            'ingresosTotales("Ingreso", "Si", fechaDesde, fechaHasta)
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

    Public Sub generarInformeTabla()
        Try
            'Exporting to PDF
            Dim folderPath As String = "C:\Reportes\"
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(folderPath & "reporteInformeEconomico.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)


            'Dim valores As List(Of String)

            ' BD.ConectarBD()


            'valores = BD.obtenerDatosdeUnComite("Consejo de administración")
            Dim tipoIngreso1 As String = "tipo ingreso1"
            Dim valor1 As String = "100"
            Dim tipoIngreso2 As String = "tipo ingreso2"
            Dim valor2 As String = "500"


            table.AddCell("Col 1 Row 1")
            table.AddCell("Col 2 Row 1")
            table.AddCell("Col 3 Row 1")
            table.AddCell("Col 1 Row 2")
            table.AddCell("Col 2 Row 2")

            pdfDoc.Add(New Paragraph(" XXX sample XXX"))
            pdfDoc.Add(table)



            'BD.CerrarConexion()

            pdfDoc.Close()
            MessageBox.Show("Reporte generado con éxito en C:/Reportes/")
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
        End Try
    End Sub


End Class
