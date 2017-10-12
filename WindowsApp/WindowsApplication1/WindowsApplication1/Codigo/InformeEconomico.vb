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
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                generarInformeTabla()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
            End Try
        End If

    End Sub

    'Función que tiene la lógica para generar los datos requeridos para el informe económico
    Public Sub generarInformeTabla()

        Dim fechaDesde As Date = VInformeEconomico.InformeDateTimePickerDesde.Value.ToString("dd/MM/yyyy")
        Dim fechaHasta As Date = VInformeEconomico.InformeDateTimePickerHasta.Value.ToString("dd/MM/yyyy")
        'INGRESOS
        Dim totalIngresos As List(Of String) = ingresosTotales("Ingreso", "Si", fechaDesde, fechaHasta)
        Dim subTotalIngresos As List(Of String) = obtenerSubTotalIngresos("Ingreso", "Si", fechaDesde, fechaHasta)
        'OTROS INGRESOS
        Dim totalOtrosIngresos As List(Of String) = ingresosTotales("Ingreso", "No", fechaDesde, fechaHasta)
        Dim subTotalOtrosIngresos As List(Of String) = obtenerSubTotalIngresos("Ingreso", "No", fechaDesde, fechaHasta)
        'GASTOS
        Dim totalGastos As List(Of String) = gastosTotales("Gasto", "Si", fechaDesde, fechaHasta)
        Dim subTotalGastos As List(Of String) = obtenerSubTotalGastos("Gasto", "Si", fechaDesde, fechaHasta)
        'OTROS GASTOS
        Dim totalOtrosGastos As List(Of String) = gastosTotales("Gasto", "No", fechaDesde, fechaHasta)
        Dim subTotalOtrosGastos As List(Of String) = obtenerSubTotalGastos("Gasto", "No", fechaDesde, fechaHasta)
        'Valores de Reservas
        Dim valoresReserva As List(Of ConfiguracionClase) = consultarValoresConfiguracion()
        'Afiliaciones
        Dim totalAfiliaciones As List(Of String) = obtenerTotalAfiliaciones(fechaDesde, fechaHasta)
        'Aportaciones o Certificados - Acum
        Dim totalAportacionesAcum As List(Of String) = obtenerAportacionesAcumuladoAnterior()
        'Aportaciones o Certificados - Total
        Dim totalAportacionesTotal As List(Of String) = obtenerAportacionesTotal()

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

            Dim cellIngresos As PdfPCell = New PdfPCell(New Phrase("Ingresos o Entradas (Proyecto Productivo)"))
            cellIngresos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#99FF33"))
            cellIngresos.Colspan = 2
            cellIngresos.HorizontalAlignment = 0 '//0=Left, 1=Centre, 2=Right

            Dim cellSubTotalIngresos As PdfPCell = New PdfPCell(New Phrase("SubTotal Ingresos"))
            cellSubTotalIngresos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#99FF33"))
            cellSubTotalIngresos.Colspan = 1
            cellSubTotalIngresos.HorizontalAlignment = 0

            Dim cellOtrosIngresos As PdfPCell = New PdfPCell(New Phrase("Otros Ingresos"))
            cellOtrosIngresos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#99FF33"))
            cellOtrosIngresos.Colspan = 2
            cellOtrosIngresos.HorizontalAlignment = 0

            Dim cellSubTotalOtrosIngresos As PdfPCell = New PdfPCell(New Phrase("SubTotal Otros Ingresos"))
            cellSubTotalOtrosIngresos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#99FF33"))
            cellSubTotalOtrosIngresos.Colspan = 1
            cellSubTotalOtrosIngresos.HorizontalAlignment = 0

            Dim cellTotalNetoIngresos As PdfPCell = New PdfPCell(New Phrase("TOTAL INGRESOS"))
            cellTotalNetoIngresos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#99FF33"))
            cellTotalNetoIngresos.Colspan = 1
            cellTotalNetoIngresos.HorizontalAlignment = 0

            'Gastos
            Dim cellGastos As PdfPCell = New PdfPCell(New Phrase("Egresos o Salidas (Proyecto productivo)"))
            cellGastos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#FFC000"))
            cellGastos.Colspan = 2
            cellGastos.HorizontalAlignment = 0

            Dim cellSubTotalGastos As PdfPCell = New PdfPCell(New Phrase("SubTotal Egresos"))
            cellSubTotalGastos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#FFC000"))
            cellSubTotalGastos.Colspan = 1
            cellSubTotalGastos.HorizontalAlignment = 0

            Dim cellOtrosGastos As PdfPCell = New PdfPCell(New Phrase("Otros Egresos"))
            cellOtrosGastos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#FFC000"))
            cellOtrosGastos.Colspan = 2
            cellOtrosGastos.HorizontalAlignment = 0

            Dim cellSubTotalOtrosGastos As PdfPCell = New PdfPCell(New Phrase("SubTotal Otros Egresos"))
            cellSubTotalOtrosGastos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#FFC000"))
            cellSubTotalOtrosGastos.Colspan = 1
            cellSubTotalOtrosGastos.HorizontalAlignment = 0

            Dim cellTotalNetoGastos As PdfPCell = New PdfPCell(New Phrase("TOTAL EGRESOS"))
            cellTotalNetoGastos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#FFC000"))
            cellTotalNetoGastos.Colspan = 1
            cellTotalNetoGastos.HorizontalAlignment = 0

            Dim cellTotalNetoFondosEnCaja As PdfPCell = New PdfPCell(New Phrase("FONDOS EN CAJA"))
            cellTotalNetoFondosEnCaja.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#FFC000"))
            cellTotalNetoFondosEnCaja.Colspan = 1
            cellTotalNetoFondosEnCaja.HorizontalAlignment = 0

            Dim cellExcedentes As PdfPCell = New PdfPCell(New Phrase("Excedentes"))
            cellExcedentes.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#8EA9DB"))
            cellExcedentes.Colspan = 2
            cellExcedentes.HorizontalAlignment = 0

            Dim cellExcedentesBrutos As PdfPCell = New PdfPCell(New Phrase("Excedentes Brutos(Proyecto productivo)"))
            cellExcedentesBrutos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#8EA9DB"))
            cellExcedentesBrutos.Colspan = 1
            cellExcedentesBrutos.HorizontalAlignment = 0

            Dim cellLegal As PdfPCell = New PdfPCell(New Phrase("Reserva Legal (" + valoresReserva(0).legal + "%)"))
            cellLegal.Colspan = 1
            cellLegal.HorizontalAlignment = 0

            Dim cellEducacion As PdfPCell = New PdfPCell(New Phrase("Reserva Educación (" + valoresReserva(0).educacion + "%)"))
            cellEducacion.Colspan = 1
            cellEducacion.HorizontalAlignment = 0

            Dim cellBienestarSocial As PdfPCell = New PdfPCell(New Phrase("Bienestar Social (" + valoresReserva(0).bienestarSocial + "%)"))
            cellBienestarSocial.Colspan = 1
            cellBienestarSocial.HorizontalAlignment = 0

            Dim cellInstitucional As PdfPCell = New PdfPCell(New Phrase("Institucional (" + valoresReserva(0).institucional + "%)"))
            cellInstitucional.Colspan = 1
            cellInstitucional.HorizontalAlignment = 0

            Dim cellPatrimonial As PdfPCell = New PdfPCell(New Phrase("Reserva Patrimonial (" + valoresReserva(0).patrimonial + "%)"))
            cellPatrimonial.Colspan = 1
            cellPatrimonial.HorizontalAlignment = 0

            Dim cellTotalReservas As PdfPCell = New PdfPCell(New Phrase("Total Reservas"))
            cellTotalReservas.Colspan = 1
            cellTotalReservas.HorizontalAlignment = 0

            Dim cellExcedentesNetosDistribuibles As PdfPCell = New PdfPCell(New Phrase("Excedentes Netos Distribuibles"))
            cellExcedentesNetosDistribuibles.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml("#8EA9DB"))
            cellExcedentesNetosDistribuibles.Colspan = 1
            cellExcedentesNetosDistribuibles.HorizontalAlignment = 0

            Dim divisor As PdfPCell = New PdfPCell(New Phrase(" "))
            divisor.Colspan = 2

            'Ingresos
            table.AddCell(cellIngresos)
            For Each value In totalIngresos
                table.AddCell(value)
            Next
            table.AddCell(cellSubTotalIngresos)
            For Each value In subTotalIngresos
                table.AddCell(value)
            Next

            '///// DIV /////
            table.AddCell(divisor)

            'Otros Ingresos
            table.AddCell(cellOtrosIngresos)
            For Each value In totalOtrosIngresos
                table.AddCell(value)
            Next

            table.AddCell("Aportaciones")
            Dim subTotalAportaciones As Integer = Integer.Parse(totalAportacionesAcum.Item(0)) + Integer.Parse(totalAportacionesTotal.Item(0))
            table.AddCell(Convert.ToString(subTotalAportaciones))

            table.AddCell("Afiliaciones")
            Dim subTotalAfiliaciones As Integer = Integer.Parse(totalAfiliaciones.Item(0))
            table.AddCell(Convert.ToString(subTotalAfiliaciones))


            table.AddCell(cellSubTotalOtrosIngresos)
            Dim subTotalOtrosIngresosInt As Integer = Integer.Parse(subTotalOtrosIngresos.Item(0)) + subTotalAportaciones + subTotalAfiliaciones
            table.AddCell(Convert.ToString(subTotalOtrosIngresosInt))


            '///// DIV /////
            table.AddCell(divisor)

            table.AddCell(cellTotalNetoIngresos)
            Dim subTotalIngresosInt As Integer = Integer.Parse(subTotalIngresos.Item(0))
            'Dim subTotalOtrosIngresosInt As Integer = Integer.Parse(subTotalOtrosIngresos.Item(0)) + subTotalAportaciones + subTotalAfiliaciones
            Dim sumaTotalIngresos = subTotalIngresosInt + subTotalOtrosIngresosInt
            table.AddCell(Convert.ToString(sumaTotalIngresos))

            '///// DIV /////
            table.AddCell(divisor)


            'Gastos
            table.AddCell(cellGastos)
            For Each value In totalGastos
                table.AddCell(value)
            Next
            table.AddCell(cellSubTotalGastos)
            For Each value In subTotalGastos
                table.AddCell(value)
            Next

            '///// DIV /////
            table.AddCell(divisor)

            'Otros Gastos
            table.AddCell(cellOtrosGastos)
            For Each value In totalOtrosGastos
                table.AddCell(value)
            Next
            table.AddCell(cellSubTotalOtrosGastos)
            For Each value In subTotalOtrosGastos
                table.AddCell(value)
            Next

            '///// DIV /////
            table.AddCell(divisor)

            table.AddCell(cellTotalNetoGastos)
            Dim subTotalGastosInt As Integer = Integer.Parse(subTotalGastos.Item(0))
            Dim subTotalOtrosGastosInt As Integer = Integer.Parse(subTotalOtrosGastos.Item(0))
            Dim sumaTotalGastos = subTotalGastosInt + subTotalOtrosGastosInt
            table.AddCell(Convert.ToString(sumaTotalGastos))

            '///// DIV /////
            table.AddCell(divisor)

            table.AddCell(cellTotalNetoFondosEnCaja)
            Dim fondosEnCaja As Integer = Integer.Parse(sumaTotalIngresos) - Integer.Parse(sumaTotalGastos)
            table.AddCell(Convert.ToString(fondosEnCaja))

            '///// DIV /////
            table.AddCell(divisor)

            '// EXCEDENTES //
            table.AddCell(cellExcedentes)

            '///// DIV /////
            table.AddCell(divisor)

            table.AddCell(cellExcedentesBrutos)
            Dim excedentesBrutos As Integer = Integer.Parse(subTotalIngresos.Item(0)) - Integer.Parse(subTotalGastos.Item(0))
            table.AddCell(Convert.ToString(excedentesBrutos))

            '///// DIV /////
            table.AddCell(divisor)

            table.AddCell(cellLegal)
            Dim sumaLegal As Integer = (excedentesBrutos * valoresReserva(0).legal) / 100
            table.AddCell(Convert.ToString(sumaLegal))

            table.AddCell(cellEducacion)
            Dim sumaEducacion As Integer = (excedentesBrutos * valoresReserva(0).educacion) / 100
            table.AddCell(Convert.ToString(sumaEducacion))

            table.AddCell(cellBienestarSocial)
            Dim sumaBSocial As Integer = (excedentesBrutos * valoresReserva(0).bienestarSocial) / 100
            table.AddCell(Convert.ToString(sumaBSocial))

            table.AddCell(cellInstitucional)
            Dim sumaInstitucional As Integer = (excedentesBrutos * valoresReserva(0).institucional) / 100
            table.AddCell(Convert.ToString(sumaInstitucional))

            table.AddCell(cellPatrimonial)
            Dim sumaPatrimonial As Integer = (excedentesBrutos * valoresReserva(0).patrimonial) / 100
            table.AddCell(Convert.ToString(sumaPatrimonial))

            '///// DIV /////
            table.AddCell(divisor)

            table.AddCell(cellTotalReservas)
            Dim sumaTotalReservas As Integer = sumaLegal + sumaEducacion + sumaBSocial + sumaInstitucional + sumaPatrimonial
            table.AddCell(Convert.ToString(sumaTotalReservas))

            '///// DIV /////
            table.AddCell(divisor)

            table.AddCell(cellExcedentesNetosDistribuibles)
            Dim sumaExcedentesNetosDistribuibles As Integer = excedentesBrutos - sumaTotalReservas
            table.AddCell(Convert.ToString(sumaExcedentesNetosDistribuibles))

            '/////// Encabezado //////////

            Dim FontStype = FontFactory.GetFont("Arial", 12, Font.NORMAL)
            pdfDoc.Add(New Paragraph("                                            Informe Económico del " + fechaDesde + " al " + fechaHasta, FontStype))
            pdfDoc.Add(New Paragraph(""))
            pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))

            'Agrega todos los valores consultados al documento
            pdfDoc.Add(table)
            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
        End Try
    End Sub

    'Consulta todos los ingresos por tipo de proyecto productivo y genera un informe
    Public Function ingresosTotales(ByVal ingresoOGasto As String, ByVal esProyProductivo As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date)

        Dim valores As List(Of String)
        Try
            BD.ConectarBD()
            valores = BD.obtenerInformeIngresosTotales(ingresoOGasto, esProyProductivo, "#" + fechaDesde + "#", "#" + fechaHasta + "#")
            If valores.Count <> 0 Then
                Return valores
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return ""
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
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
                Return valores
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return ""
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
            Return ""
        End Try
    End Function

    'Consulta subtotal de ingresos
    Public Function obtenerSubTotalIngresos(ByVal ingresoOGasto As String, ByVal proyectoProd As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date)

        Dim valores As List(Of String)
        Try
            BD.ConectarBD()
            valores = BD.obtenerSubTotalIngresos(ingresoOGasto, proyectoProd, "#" + fechaDesde + "#", "#" + fechaHasta + "#")
            If valores.Count <> 0 Then
                Return valores
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return ""
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
            Return ""
        End Try
    End Function

    'Consulta subtotal de gastos
    Public Function obtenerSubTotalGastos(ByVal ingresoOGasto As String, ByVal proyectoProd As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date)

        Dim valores As List(Of String)
        Try
            BD.ConectarBD()
            valores = BD.obtenerSubTotalGastos(ingresoOGasto, proyectoProd, "#" + fechaDesde + "#", "#" + fechaHasta + "#")
            If valores.Count <> 0 Then
                Return valores
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return ""
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
            Return ""
        End Try
    End Function

    'Consulta todos los datos de la tabla de Configuración'
    Public Function consultarValoresConfiguracion()
        Dim valores As List(Of ConfiguracionClase)
        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeConfiguration()
            If valores.Count <> 0 Then
                Return valores
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return ""
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
            Return ""
        End Try
    End Function

    'total afiliaciones o matricula
    Public Function obtenerTotalAfiliaciones(ByVal fechaDesde As Date, ByVal fechaHasta As Date)
        Dim valores As List(Of String)
        Try
            BD.ConectarBD()
            valores = BD.obtenerTotalAfiliaciones("#" + fechaDesde + "#", "#" + fechaHasta + "#")
            If valores.Count <> 0 Then
                Return valores
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return ""
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
            Return ""
        End Try
    End Function

    Public Function obtenerAportacionesAcumuladoAnterior()
        Dim valores As List(Of String)
        Try
            BD.ConectarBD()
            valores = BD.obtenerAportacionesAcumuladoAnterior()
            If valores.Count <> 0 Then
                Return valores
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return ""
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
            Return ""
        End Try
    End Function

    'Total certificados o aportaciones
    Public Function obtenerAportacionesTotal()
        Dim valores As List(Of String)
        Try
            BD.ConectarBD()
            valores = BD.obtenerAportacionesTotal()
            If valores.Count <> 0 Then
                Return valores
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return ""
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
            Return ""
        End Try
    End Function

End Class
