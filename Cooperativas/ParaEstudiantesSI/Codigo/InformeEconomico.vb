Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class InformeEconomico

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase

    'Valida los permisos y genera un pdf con el Informe en un rango de fechas
    Public Sub generarInformeEconomico()
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            generarInformeTabla()
        End If
    End Sub

    'Función que tiene la lógica para generar los datos requeridos para el informe económico
    Public Sub generarInformeTabla()
        Dim fechaDesde As Date = Ventana_Principal.InformeDateTimePickerDesde.Value.ToString("dd/MM/yyyy")
        Dim fechaHasta As Date = Ventana_Principal.InformeDateTimePickerHasta.Value.ToString("dd/MM/yyyy")
        Dim subTotalIngresosProyectoProductivo As List(Of String)
        Dim subTotalOtrosIngresos As List(Of String)
        Dim subTotalGastosProyectoProductivo As List(Of String)
        Dim subTotalOtrosGastos As List(Of String)

        Try
            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reporteInformeEconomico.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim table As PdfPTable = New PdfPTable(2)

            Dim cellProyProd As PdfPCell = New PdfPCell(New Phrase("Ingresos o Entradas (Proyecto Productivo)"))
            cellProyProd.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#99FF33"))
            cellProyProd.Colspan = 2
            cellProyProd.HorizontalAlignment = 0 '//0=Left, 1=Centre, 2=Right

            Dim cellOtrosIngresos As PdfPCell = New PdfPCell(New Phrase("Otros Ingresos"))
            cellOtrosIngresos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#99FF33"))
            cellOtrosIngresos.Colspan = 2
            cellOtrosIngresos.HorizontalAlignment = 0

            Dim cellGastosProyProd As PdfPCell = New PdfPCell(New Phrase("Egresos o Salidas (Proyecto productivo)"))
            cellGastosProyProd.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#FFC000"))
            cellGastosProyProd.Colspan = 2
            cellGastosProyProd.HorizontalAlignment = 0

            Dim cellOtrosGastos As PdfPCell = New PdfPCell(New Phrase("Otros Gastos"))
            cellOtrosGastos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#FFC000"))
            cellOtrosGastos.Colspan = 2
            cellOtrosGastos.HorizontalAlignment = 0


            subTotalIngresosProyectoProductivo = ingresosTotales("Ingreso", "Si", fechaDesde, fechaHasta)
            subTotalOtrosIngresos = ingresosTotales("Ingreso", "Si", fechaDesde, fechaHasta)
            subTotalGastosProyectoProductivo = gastosTotales("Gasto", "Si", fechaDesde, fechaHasta)
            subTotalOtrosGastos = gastosTotales("Gasto", "No", fechaDesde, fechaHasta)

            'Agrego Celda del Encabezado - subTotalIngresosProyectoProductivo
            table.AddCell(cellProyProd)
            For Each value In subTotalIngresosProyectoProductivo
                'MessageBox.Show("value is : " + value)
                table.AddCell(value)
            Next

            table.AddCell(cellOtrosIngresos)
            For Each value In subTotalOtrosIngresos
                table.AddCell(value)
            Next

            table.AddCell(cellGastosProyProd)
            For Each value In subTotalGastosProyectoProductivo
                table.AddCell(value)
            Next

            table.AddCell(cellOtrosGastos)
            For Each value In subTotalOtrosGastos
                table.AddCell(value)
            Next



            table.AddCell("e")
            table.AddCell("r")
            table.AddCell("t")
            table.AddCell("y")



            Dim FontStype = FontFactory.GetFont("Arial", 12, Font.NORMAL)
            pdfDoc.Add(New Paragraph("                                                  Informe Económico del " + fechaDesde + " al " + fechaHasta, FontStype))
            pdfDoc.Add(New Paragraph(""))
            pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))

            pdfDoc.Add(table)

            'BD.CerrarConexion()

            pdfDoc.Close()
            MessageBox.Show(variablesGlobales.reporteGeneradoConExito)
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
        End Try
    End Sub

    'Consulta todos los ingresos por tipo de proyecto productivo y genera un informe
    Public Function ingresosTotales(ByVal ingresoOGasto As String, ByVal esProyProductivo As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date)

        Dim valores As List(Of String)
        Try
            BD.ConectarBD()
            valores = BD.obtenerInformeIngresosTotales(ingresoOGasto, esProyProductivo, "#" + fechaDesde + "#", "#" + fechaHasta + "#")
            If valores.Count <> 0 Then
                'llenarDatos(valores)
                Return valores
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos)
                'limpiar()
                Return ""
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
            Return ""
        End Try
    End Function

    'Consulta todos los gastos por tipo de proyecto productivo y genera un informe
    Public Function gastosTotales(ByVal ingresoOGasto As String, ByVal esProyProductivo As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date)

        Dim valores As List(Of String)
        Try
            BD.ConectarBD()
            valores = BD.obtenerInformeGastosTotales(ingresoOGasto, esProyProductivo, "#" + fechaDesde + "#", "#" + fechaHasta + "#")
            If valores.Count <> 0 Then
                'llenarDatos(valores)
                Return valores
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos)
                'limpiar()
                Return ""
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
            Return ""
        End Try
    End Function

End Class
