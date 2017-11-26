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
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If

    End Sub

    'Función que tiene la lógica para generar los datos requeridos para el informe económico
    Public Sub generarInformeTabla()

        Dim fechaDesde As Date = VInformeEconomico.InformeDateTimePickerDesde.Value.ToString("dd/MM/yyyy")
        Dim fechaHasta As Date = VInformeEconomico.InformeDateTimePickerHasta.Value.ToString("dd/MM/yyyy")

        'MsgBox("1entrando a ingresos...")
        'INGRESOS
        Dim totalIngresos As List(Of String) = ingresosTotales("Ingreso", "Si", fechaDesde, fechaHasta)
        'MsgBox("2paso ingresos ")
        Dim subTotalIngresos As List(Of String) = obtenerSubTotalIngresos("Ingreso", "Si", fechaDesde, fechaHasta)
        'MsgBox("3paso sub-ingresos")
        'OTROS INGRESOS
        Dim totalOtrosIngresos As List(Of String) = ingresosTotales("Ingreso", "No", fechaDesde, fechaHasta)
        'MsgBox("4paso otros ingresos ")
        Dim subTotalOtrosIngresos As List(Of String) = obtenerSubTotalIngresos("Ingreso", "No", fechaDesde, fechaHasta)
        'MsgBox("5paso sub-otros ingresos")

        'GASTOS
        'MsgBox("6entrando a gastos...")
        Dim totalGastos As List(Of String) = gastosTotales("Gasto", "Si", fechaDesde, fechaHasta)
        'MsgBox("7paso total gastos")
        Dim subTotalGastos As List(Of String) = obtenerSubTotalGastos("Gasto", "Si", fechaDesde, fechaHasta)
        'OTROS GASTOS
        'MsgBox("8paso sub total gastos")
        Dim totalOtrosGastos As List(Of String) = gastosTotales("Gasto", "No", fechaDesde, fechaHasta)
        'MsgBox("9paso total otros gastos")
        Dim subTotalOtrosGastos As List(Of String) = obtenerSubTotalGastos("Gasto", "No", fechaDesde, fechaHasta)
        'MsgBox("10paso sub-total otros gastos")

        'Valores de Reservas
        Dim valoresReserva As List(Of ConfiguracionClase) = consultarValoresConfiguracion()
        'MsgBox("11paso sub-total otros gastos")

        'Afiliaciones
        Dim totalAfiliaciones As List(Of String) = obtenerTotalAfiliaciones(fechaDesde, fechaHasta)
        'MsgBox("12paso total afiliaciones")

        'Aportaciones o Certificados - Acum
        Dim totalAportacionesAcum As List(Of String) = obtenerAportacionesAcumuladoAnterior()
        'MsgBox("13paso sub-total otros gastos")
        'Aportaciones o Certificados - Total
        Dim totalAportacionesTotal As List(Of String) = obtenerAportacionesTotal()
        'MsgBox("14paso sub-total otros gastos")

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

            'Color de celdas
            Dim FontEncabezadoFechas = FontFactory.GetFont("Arial", 10, Font.NORMAL)
            Dim FontStyleWhite = FontFactory.GetFont("Arial", 10, Font.BOLDITALIC, BaseColor.WHITE)
            Dim FontStypeLineas = FontFactory.GetFont("Arial", 10, Font.NORMAL, BaseColor.BLACK)
            Dim FontStypeSubTotales = FontFactory.GetFont("Arial", 10, Font.BOLD, BaseColor.BLACK)

            Dim cellIngresos As PdfPCell = New PdfPCell(New Phrase("Ingresos o Entradas (Proyecto Productivo)", FontStyleWhite))
            cellIngresos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorInformeEconomicoIngresos))  ' verde "#99FF33"
            cellIngresos.Colspan = 2
            cellIngresos.HorizontalAlignment = 1 '//0=Left, 1=Centre, 2=Right

            Dim cellSubTotalIngresos As PdfPCell = New PdfPCell(New Phrase("SubTotal Ingresos", FontStypeSubTotales))
            cellSubTotalIngresos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            cellSubTotalIngresos.Colspan = 1
            cellSubTotalIngresos.HorizontalAlignment = 1

            Dim cellOtrosIngresos As PdfPCell = New PdfPCell(New Phrase("Otros Ingresos", FontStyleWhite))
            cellOtrosIngresos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorInformeEconomicoIngresos))
            cellOtrosIngresos.Colspan = 2
            cellOtrosIngresos.HorizontalAlignment = 1

            Dim cellSubTotalOtrosIngresos As PdfPCell = New PdfPCell(New Phrase("SubTotal Otros Ingresos", FontStypeSubTotales))
            cellSubTotalOtrosIngresos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            cellSubTotalOtrosIngresos.Colspan = 1
            cellSubTotalOtrosIngresos.HorizontalAlignment = 1

            Dim cellTotalNetoIngresos As PdfPCell = New PdfPCell(New Phrase("Total Ingresos", FontStyleWhite))
            cellTotalNetoIngresos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorInformeEconomicoIngresos))
            cellTotalNetoIngresos.Colspan = 1
            cellTotalNetoIngresos.HorizontalAlignment = 1

            'Gastos
            Dim cellGastos As PdfPCell = New PdfPCell(New Phrase("Egresos o Salidas (Proyecto productivo)", FontStyleWhite))
            cellGastos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorInformeEconomicoGastoss)) ' Egresos FFC000
            cellGastos.Colspan = 2
            cellGastos.HorizontalAlignment = 1

            Dim cellSubTotalGastos As PdfPCell = New PdfPCell(New Phrase("SubTotal Egresos", FontStypeSubTotales))
            cellSubTotalGastos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            cellSubTotalGastos.Colspan = 1
            cellSubTotalGastos.HorizontalAlignment = 1

            Dim cellOtrosGastos As PdfPCell = New PdfPCell(New Phrase("Otros Egresos", FontStyleWhite))
            cellOtrosGastos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorInformeEconomicoGastoss))
            cellOtrosGastos.Colspan = 2
            cellOtrosGastos.HorizontalAlignment = 1

            Dim cellSubTotalOtrosGastos As PdfPCell = New PdfPCell(New Phrase("SubTotal Otros Egresos", FontStypeSubTotales))
            cellSubTotalOtrosGastos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            cellSubTotalOtrosGastos.Colspan = 1
            cellSubTotalOtrosGastos.HorizontalAlignment = 1

            Dim cellTotalNetoGastos As PdfPCell = New PdfPCell(New Phrase("Total Egresos", FontStyleWhite))
            cellTotalNetoGastos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorInformeEconomicoGastoss))
            cellTotalNetoGastos.Colspan = 1
            cellTotalNetoGastos.HorizontalAlignment = 1

            Dim cellTotalNetoFondosEnCaja As PdfPCell = New PdfPCell(New Phrase("Fondos en Caja", FontStyleWhite))
            cellTotalNetoFondosEnCaja.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorInformeEconomicoExcedentes))
            cellTotalNetoFondosEnCaja.Colspan = 1
            cellTotalNetoFondosEnCaja.HorizontalAlignment = 1

            Dim cellExcedentes As PdfPCell = New PdfPCell(New Phrase("Excedentes", FontStyleWhite))
            cellExcedentes.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorInformeEconomicoExcedentes))
            cellExcedentes.Colspan = 2
            cellExcedentes.HorizontalAlignment = 1

            Dim cellExcedentesBrutos As PdfPCell = New PdfPCell(New Phrase("Excedentes Brutos(Proyecto productivo)", FontStyleWhite))
            cellExcedentesBrutos.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorInformeEconomicoExcedentes)) '"#8EA9DB" excedentes
            cellExcedentesBrutos.Colspan = 1
            cellExcedentesBrutos.HorizontalAlignment = 1

            Dim cellLegal As PdfPCell = New PdfPCell(New Phrase("Reserva Legal (" + valoresReserva(0).legal + "%)", FontStypeLineas))
            cellLegal.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            cellLegal.Colspan = 1
            cellLegal.HorizontalAlignment = 1

            Dim cellEducacion As PdfPCell = New PdfPCell(New Phrase("Reserva Educación (" + valoresReserva(0).educacion + "%)", FontStypeLineas))
            cellEducacion.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            cellEducacion.Colspan = 1
            cellEducacion.HorizontalAlignment = 1

            Dim cellBienestarSocial As PdfPCell = New PdfPCell(New Phrase("Bienestar Social (" + valoresReserva(0).bienestarSocial + "%)", FontStypeLineas))
            cellBienestarSocial.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            cellBienestarSocial.Colspan = 1
            cellBienestarSocial.HorizontalAlignment = 1

            Dim cellInstitucional As PdfPCell = New PdfPCell(New Phrase("Institucional (" + valoresReserva(0).institucional + "%)", FontStypeLineas))
            cellInstitucional.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            cellInstitucional.Colspan = 1
            cellInstitucional.HorizontalAlignment = 1

            Dim cellPatrimonial As PdfPCell = New PdfPCell(New Phrase("Reserva Patrimonial (" + valoresReserva(0).patrimonial + "%)", FontStypeLineas))
            cellPatrimonial.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            cellPatrimonial.Colspan = 1
            cellPatrimonial.HorizontalAlignment = 1

            Dim cellTotalReservas As PdfPCell = New PdfPCell(New Phrase("Total Reservas", FontStyleWhite))
            cellTotalReservas.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorInformeEconomicoExcedentes))
            cellTotalReservas.Colspan = 1
            cellTotalReservas.HorizontalAlignment = 1

            Dim cellExcedentesNetosDistribuibles As PdfPCell = New PdfPCell(New Phrase("Excedentes Netos Distribuibles", FontStyleWhite))
            cellExcedentesNetosDistribuibles.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorInformeEconomicoIngresos))
            cellExcedentesNetosDistribuibles.Colspan = 1
            cellExcedentesNetosDistribuibles.HorizontalAlignment = 1

            Dim divisor As PdfPCell = New PdfPCell(New Phrase(" "))
            divisor.Colspan = 2

            'Ingresos ---------------------------------------------------

            table.AddCell(cellIngresos)

            Dim i As Integer = 1
            For Each value In totalIngresos
                'table.AddCell(value)

                If (i Mod 2 = 0) Then
                    'PARES - NUMERO DE INGRESOS
                    Dim parN As Integer = Convert.ToInt32(value)
                    Dim parT As String = parN.ToString("N")
                    Dim parTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + parT, FontStypeLineas))
                    parTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    parTT.Colspan = 1
                    parTT.HorizontalAlignment = 0

                    table.AddCell(parTT)
                Else
                    ' IMPARES - CUENTAS DE INGRESOS
                    Dim imparT As PdfPCell = New PdfPCell(New Phrase(value, FontStypeLineas))
                    imparT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    imparT.Colspan = 1
                    imparT.HorizontalAlignment = 1

                    table.AddCell(imparT)
                End If

                i = i + 1
            Next

            'subTotal Ingresos ------------------------------------------

            table.AddCell(cellSubTotalIngresos)

            Dim subTotalIngresosN As Integer = Convert.ToInt32(subTotalIngresos.Item(0))
            Dim subTotalIngresosT As String = subTotalIngresosN.ToString("N")

            Dim subTotalIngresosTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + subTotalIngresosT, FontStypeSubTotales))
            subTotalIngresosTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            subTotalIngresosTT.Colspan = 1
            subTotalIngresosTT.HorizontalAlignment = 0

            table.AddCell(subTotalIngresosTT)
            'For Each value In subTotalIngresos
            'table.AddCell(value)
            'Next

            '///// DIV /////
            table.AddCell(divisor)

            'Otros Ingresos -----------------------------------------

            table.AddCell(cellOtrosIngresos)

            Dim contaOtrosIngresos As Integer = 1
            For Each value In totalOtrosIngresos
                'table.AddCell(value)

                If (contaOtrosIngresos Mod 2 = 0) Then
                    'PARES - NUMERO DE OTROS INGRESOS
                    Dim parN As Integer = Convert.ToInt32(value)
                    Dim parT As String = parN.ToString("N")
                    Dim parTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + parT, FontStypeLineas))
                    parTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    parTT.Colspan = 1
                    parTT.HorizontalAlignment = 0

                    table.AddCell(parTT)
                Else
                    ' IMPARES - CUENTAS DE OTROS INGRESOS
                    Dim imparT As PdfPCell = New PdfPCell(New Phrase(value, FontStypeLineas))
                    imparT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    imparT.Colspan = 1
                    imparT.HorizontalAlignment = 1

                    table.AddCell(imparT)
                End If

                contaOtrosIngresos = contaOtrosIngresos + 1
            Next

            ' For Each value In totalOtrosIngresos
            'table.AddCell(value)
            'Next

            'APORTACIONES -----------------------------------------

            Dim aportacionesT As PdfPCell = New PdfPCell(New Phrase("Aportaciones", FontStypeLineas))
            aportacionesT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas)) '"#8EA9DB" excedentes
            aportacionesT.Colspan = 1
            aportacionesT.HorizontalAlignment = 1

            table.AddCell(aportacionesT)

            'table.AddCell("Aportaciones")
            Dim subTotalAportaciones As Integer = Integer.Parse(totalAportacionesAcum.Item(0)) + Integer.Parse(totalAportacionesTotal.Item(0))
            'table.AddCell(Convert.ToString(subTotalAportaciones))

            Dim aportacionesN As Integer = Convert.ToInt32(subTotalAportaciones)
            Dim montoAportacionesT As String = aportacionesN.ToString("N")
            Dim montoAportacionesTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + montoAportacionesT, FontStypeLineas))
            montoAportacionesTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            montoAportacionesTT.Colspan = 1
            montoAportacionesTT.HorizontalAlignment = 0

            table.AddCell(montoAportacionesTT)


            'AFILIACIONES -----------------------------------------

            Dim afiliacionesT As PdfPCell = New PdfPCell(New Phrase("Afiliaciones", FontStypeLineas))
            afiliacionesT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas)) '"#8EA9DB" excedentes
            afiliacionesT.Colspan = 1
            afiliacionesT.HorizontalAlignment = 1

            table.AddCell(afiliacionesT)

            'table.AddCell("Afiliaciones")
            Dim subTotalAfiliaciones As Integer = Integer.Parse(totalAfiliaciones.Item(0))
            'table.AddCell(Convert.ToString(subTotalAfiliaciones))

            Dim afiliacionesN As Integer = Convert.ToInt32(subTotalAfiliaciones)
            Dim montoAfiliacionesT As String = afiliacionesN.ToString("N")
            Dim montoAfiliacionesTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + montoAfiliacionesT, FontStypeLineas))
            montoAfiliacionesTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            montoAfiliacionesTT.Colspan = 1
            montoAfiliacionesTT.HorizontalAlignment = 0

            table.AddCell(montoAfiliacionesTT)

            ' OTROS INGRESOS ----------------------------------------

            table.AddCell(cellSubTotalOtrosIngresos)
            Dim subTotalOtrosIngresosInt As Integer = Integer.Parse(subTotalOtrosIngresos.Item(0)) + subTotalAportaciones + subTotalAfiliaciones
            'table.AddCell(Convert.ToString(subTotalOtrosIngresosInt))

            Dim subTotalOtrosIngresosN As Integer = Convert.ToInt32(subTotalOtrosIngresosInt)
            Dim subTotalOtrosIngresosT As String = subTotalOtrosIngresosN.ToString("N")
            Dim subTotalOtrosIngresosTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + subTotalOtrosIngresosT, FontStypeSubTotales))
            subTotalOtrosIngresosTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            subTotalOtrosIngresosTT.Colspan = 1
            subTotalOtrosIngresosTT.HorizontalAlignment = 0

            table.AddCell(subTotalOtrosIngresosTT)

            ' TOTAL NETO INGRESOS ------------------------------------------

            '///// DIV /////
            table.AddCell(divisor)

            table.AddCell(cellTotalNetoIngresos)
            Dim subTotalIngresosInt As Integer = Integer.Parse(subTotalIngresos.Item(0))
            'Dim subTotalOtrosIngresosInt As Integer = Integer.Parse(subTotalOtrosIngresos.Item(0)) + subTotalAportaciones + subTotalAfiliaciones
            Dim sumaTotalIngresos = subTotalIngresosInt + subTotalOtrosIngresosInt
            'table.AddCell(Convert.ToString(sumaTotalIngresos))

            Dim totalNetoIngresosN As Integer = Convert.ToInt32(sumaTotalIngresos)
            Dim totalNetoIngresosT As String = totalNetoIngresosN.ToString("N")
            Dim totalNetoIngresosTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + totalNetoIngresosT, FontStypeSubTotales))
            totalNetoIngresosTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            totalNetoIngresosTT.Colspan = 1
            totalNetoIngresosTT.HorizontalAlignment = 0

            table.AddCell(totalNetoIngresosTT)

            '///// DIV /////
            table.AddCell(divisor)



            ' GASTOS  ---------------------------------------------------------

            table.AddCell(cellGastos)
            ' For Each value In totalGastos
            'table.AddCell(value)
            'Next

            Dim contaGastos As Integer = 1

            For Each value In totalGastos

                ' MsgBox("value in totalGastos es :" & vbCrLf & value)

                If (contaGastos Mod 2 = 0) Then
                    'PARES - NUMERO DE INGRESOS

                    Dim parN As Integer = Convert.ToInt32(value)
                    Dim parT As String = parN.ToString("N")
                    Dim parTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + parT, FontStypeLineas))
                    parTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    parTT.Colspan = 1
                    parTT.HorizontalAlignment = 0

                    table.AddCell(parTT)
                Else
                    ' IMPARES - CUENTAS DE INGRESOS
                    Dim imparT As PdfPCell = New PdfPCell(New Phrase(value, FontStypeLineas))
                    imparT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    imparT.Colspan = 1
                    imparT.HorizontalAlignment = 1

                    table.AddCell(imparT)
                End If

                contaGastos = contaGastos + 1
            Next

            ' SUB TOTAL GASTOS  ------------------------------------------

            table.AddCell(cellSubTotalGastos)
            'For Each value In subTotalGastos
            'table.AddCell(value)
            'Next
            Dim subTotalGastosN As Integer = Convert.ToInt32(subTotalGastos.Item(0))
            Dim subTotalGastosT As String = subTotalGastosN.ToString("N")
            Dim subTotalGastosTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + subTotalGastosT, FontStypeSubTotales))
            subTotalGastosTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            subTotalGastosTT.Colspan = 1
            subTotalGastosTT.HorizontalAlignment = 0

            table.AddCell(subTotalGastosTT)

            '///// DIV /////
            table.AddCell(divisor)

            'Otros Gastos -----------------------------------------------------------------
            table.AddCell(cellOtrosGastos)

            ' For Each value In totalOtrosGastos
            'table.AddCell(value)
            'Next

            Dim contaOtrosGastos As Integer = 1

            For Each value In totalOtrosGastos

                If (contaOtrosGastos Mod 2 = 0) Then
                    'PARES - NUMERO DE INGRESOS
                    Dim parN As Integer = Convert.ToInt32(value)
                    Dim parT As String = parN.ToString("N")
                    Dim parTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + parT, FontStypeLineas))
                    parTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    parTT.Colspan = 1
                    parTT.HorizontalAlignment = 0

                    table.AddCell(parTT)
                Else
                    ' IMPARES - CUENTAS DE INGRESOS
                    Dim imparT As PdfPCell = New PdfPCell(New Phrase(value, FontStypeLineas))
                    imparT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    imparT.Colspan = 1
                    imparT.HorizontalAlignment = 1

                    table.AddCell(imparT)
                End If

                contaOtrosGastos = contaOtrosGastos + 1
            Next

            ' SUB TOTAL OTROS EGRESOS ------------------------------------------------------------

            table.AddCell(cellSubTotalOtrosGastos)
            'For Each value In subTotalOtrosGastos
            'table.AddCell(value)
            'Next

            Dim subTotalOtrosGastosN As Integer = Convert.ToInt32(subTotalOtrosGastos.Item(0))
            Dim subTotalOtrosGastosT As String = subTotalOtrosGastosN.ToString("N")
            Dim subTotalOtrosGastosTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + subTotalOtrosGastosT, FontStypeSubTotales))
            subTotalOtrosGastosTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            subTotalOtrosGastosTT.Colspan = 1
            subTotalOtrosGastosTT.HorizontalAlignment = 0

            table.AddCell(subTotalOtrosGastosTT)

            '///// DIV /////
            table.AddCell(divisor)

            ' TOTAL NETO GASTOS -----------------------------------------------------------------

            table.AddCell(cellTotalNetoGastos)

            Dim subTotalGastosInt As Integer = Integer.Parse(subTotalGastos.Item(0))
            Dim subTotalOtrosGastosInt As Integer = Integer.Parse(subTotalOtrosGastos.Item(0))
            Dim sumaTotalGastos = subTotalGastosInt + subTotalOtrosGastosInt

            'table.AddCell(Convert.ToString(sumaTotalGastos))

            Dim totalNetoGastosT As String = sumaTotalGastos.ToString("N")
            Dim totalNetoGastosTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + totalNetoGastosT, FontStypeSubTotales))
            totalNetoGastosTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            totalNetoGastosTT.Colspan = 1
            totalNetoGastosTT.HorizontalAlignment = 0

            table.AddCell(totalNetoGastosTT)

            '///// DIV /////
            table.AddCell(divisor)

            ' FONDOS EN CAJA -------------------------------------------------------------

            table.AddCell(cellTotalNetoFondosEnCaja)
            Dim fondosEnCaja As Integer = Integer.Parse(sumaTotalIngresos) - Integer.Parse(sumaTotalGastos)
            'table.AddCell(Convert.ToString(fondosEnCaja))

            Dim fondosEnCajaT As String = fondosEnCaja.ToString("N")
            Dim fondosEnCajaTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + fondosEnCajaT, FontStypeSubTotales))
            fondosEnCajaTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            fondosEnCajaTT.Colspan = 1
            fondosEnCajaTT.HorizontalAlignment = 0

            table.AddCell(fondosEnCajaTT)


            ' PARA AGREGAR INGRESOS Y GASTOS EN UNA PAGINA

            '/////// Encabezado //////////
            pdfDoc.Add(New Paragraph("                                                 Informe Económico del " + fechaDesde + " al " + fechaHasta, FontEncabezadoFechas))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))

            pdfDoc.Add(table)
            pdfDoc.NewPage()
            encabezado.encabezado(pdfWrite, pdfDoc)
            table.DeleteBodyRows()

            ' EXCEDENTES EN LA SIGUIENTE PAGINA

            '// EXCEDENTES //
            table.AddCell(cellExcedentes)

            '///// DIV /////
            table.AddCell(divisor)

            table.AddCell(cellExcedentesBrutos)
            Dim excedentesBrutos As Integer = Integer.Parse(subTotalIngresos.Item(0)) - Integer.Parse(subTotalGastos.Item(0))
            'table.AddCell(Convert.ToString(excedentesBrutos))

            Dim exedentesBrutosT As String = excedentesBrutos.ToString("N")
            Dim exedentesBrutosTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + exedentesBrutosT, FontStypeSubTotales))
            exedentesBrutosTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            exedentesBrutosTT.Colspan = 1
            exedentesBrutosTT.HorizontalAlignment = 0

            table.AddCell(exedentesBrutosTT)

            '///// DIV /////
            table.AddCell(divisor)

            ' - RESERVAS DEL SISTEMA ---------------------------------------------------------

            ' LEGAL

            table.AddCell(cellLegal)
            Dim sumaLegal As Integer = (excedentesBrutos * valoresReserva(0).legal) / 100
            'table.AddCell(Convert.ToString(sumaLegal))

            Dim sumaLegalT As String = sumaLegal.ToString("N")
            Dim sumaLegalTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + sumaLegalT, FontStypeLineas))
            sumaLegalTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            sumaLegalTT.Colspan = 1
            sumaLegalTT.HorizontalAlignment = 0

            table.AddCell(sumaLegalTT)

            ' EDUCACION 

            table.AddCell(cellEducacion)
            Dim sumaEducacion As Integer = (excedentesBrutos * valoresReserva(0).educacion) / 100
            'table.AddCell(Convert.ToString(sumaEducacion))

            Dim sumaEducacionT As String = sumaEducacion.ToString("N")
            Dim sumaEducacionTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + sumaEducacionT, FontStypeLineas))
            sumaEducacionTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            sumaEducacionTT.Colspan = 1
            sumaEducacionTT.HorizontalAlignment = 0

            table.AddCell(sumaEducacionTT)

            ' BIENESTAR SOCIAL

            table.AddCell(cellBienestarSocial)
            Dim sumaBSocial As Integer = (excedentesBrutos * valoresReserva(0).bienestarSocial) / 100
            'table.AddCell(Convert.ToString(sumaBSocial))

            Dim sumaBSocialT As String = sumaBSocial.ToString("N")
            Dim sumaBSocialTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + sumaBSocialT, FontStypeLineas))
            sumaBSocialTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            sumaBSocialTT.Colspan = 1
            sumaBSocialTT.HorizontalAlignment = 0

            table.AddCell(sumaBSocialTT)

            ' BIENESTAR INSTITUCIONAL

            table.AddCell(cellInstitucional)
            Dim sumaInstitucional As Integer = (excedentesBrutos * valoresReserva(0).institucional) / 100
            'table.AddCell(Convert.ToString(sumaInstitucional))

            Dim sumaInstitucionalT As String = sumaInstitucional.ToString("N")
            Dim sumaInstitucionalTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + sumaInstitucionalT, FontStypeLineas))
            sumaInstitucionalTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            sumaInstitucionalTT.Colspan = 1
            sumaInstitucionalTT.HorizontalAlignment = 0

            table.AddCell(sumaInstitucionalTT)

            ' PATRIMONIAL

            table.AddCell(cellPatrimonial)
            Dim sumaPatrimonial As Integer = (excedentesBrutos * valoresReserva(0).patrimonial) / 100
            'table.AddCell(Convert.ToString(sumaPatrimonial))

            Dim sumaPatrimonialT As String = sumaPatrimonial.ToString("N")
            Dim sumaPatrimonialTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + sumaPatrimonialT, FontStypeLineas))
            sumaPatrimonialTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            sumaPatrimonialTT.Colspan = 1
            sumaPatrimonialTT.HorizontalAlignment = 0

            table.AddCell(sumaPatrimonialTT)


            '///// DIV /////
            table.AddCell(divisor)

            table.AddCell(cellTotalReservas)
            Dim sumaTotalReservas As Integer = sumaLegal + sumaEducacion + sumaBSocial + sumaInstitucional + sumaPatrimonial
            'table.AddCell(Convert.ToString(sumaTotalReservas))
            Dim sumaTotalReservasT As String = sumaTotalReservas.ToString("N")
            Dim sumaTotalReservasTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + sumaTotalReservasT, FontStypeSubTotales))
            sumaTotalReservasTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            sumaTotalReservasTT.Colspan = 1
            sumaTotalReservasTT.HorizontalAlignment = 0

            table.AddCell(sumaTotalReservasTT)

            '///// DIV /////
            table.AddCell(divisor)

            table.AddCell(cellExcedentesNetosDistribuibles)

            Dim sumaExcedentesNetosDistribuibles As Integer = excedentesBrutos - sumaTotalReservas
            'table.AddCell(Convert.ToString(sumaExcedentesNetosDistribuibles))
            Dim sumaExcedentesNetosDistribuiblesT As String = sumaExcedentesNetosDistribuibles.ToString("N")
            Dim sumaExcedentesNetosDistribuiblesTT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + sumaExcedentesNetosDistribuiblesT, FontStypeSubTotales))
            sumaExcedentesNetosDistribuiblesTT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            sumaExcedentesNetosDistribuiblesTT.Colspan = 1
            sumaExcedentesNetosDistribuiblesTT.HorizontalAlignment = 0

            table.AddCell(sumaExcedentesNetosDistribuiblesTT)

            'Agrega todos los valores consultados al documento
            pdfDoc.Add(table)

            'pdfDoc.Add(table)
            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & "reporteInformeEconomico.pdf", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    'Consulta todos los ingresos por tipo de proyecto productivo y genera un informe
    Public Function ingresosTotales(ByVal ingresoOGasto As String, ByVal esProyProductivo As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date)

        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"-", "0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico
        Try
            BD.ConectarBD()
            valores = BD.obtenerInformeIngresosTotales(ingresoOGasto, esProyProductivo, "#" + fechaDesde + "#", "#" + fechaHasta + "#")
            If valores.Count <> 0 Then
                Return valores
            Else
                'MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return list
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try
    End Function

    'Consulta todos los gastos por tipo de proyecto productivo y genera un informe
    Public Function gastosTotales(ByVal ingresoOGasto As String, ByVal esProyProductivo As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date)

        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"-", "0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico
        Try
            BD.ConectarBD()
            valores = BD.obtenerInformeGastosTotales(ingresoOGasto, esProyProductivo, "#" + fechaDesde + "#", "#" + fechaHasta + "#")

            If valores.Count <> 0 Then
                Return valores
            Else
                Return list
                'MessageBox.Show("valores ingresooGasto son" & list.Item(0))

            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try
    End Function

    'Consulta subtotal de ingresos
    Public Function obtenerSubTotalIngresos(ByVal ingresoOGasto As String, ByVal proyectoProd As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date)

        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico
        Try
            BD.ConectarBD()
            valores = BD.obtenerSubTotalIngresos(ingresoOGasto, proyectoProd, "#" + fechaDesde + "#", "#" + fechaHasta + "#")
            If valores.Count <> 0 Then
                Return valores
            Else
                'MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return list
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try
    End Function

    'Consulta subtotal de gastos
    Public Function obtenerSubTotalGastos(ByVal ingresoOGasto As String, ByVal proyectoProd As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date)
        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico

        Try
            BD.ConectarBD()
            valores = BD.obtenerSubTotalGastos(ingresoOGasto, proyectoProd, "#" + fechaDesde + "#", "#" + fechaHasta + "#")
            'MessageBox.Show(vbCr + "valores count es: " + valores.Count.ToString)
            If valores.Count <> 0 Then
                '   MessageBox.Show(vbCr + " vamos a retornar valores ")
                Return valores
            Else
                'MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                '  MessageBox.Show(vbCr + " vamos a retornar list list item 0 es : " + list.Item(0).ToString + "  xxxx  ")
                Return list
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
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
                MessageBox.Show("No existen datos en la sección de Configuración", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return ""
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try
    End Function

    'total afiliaciones o matricula
    Public Function obtenerTotalAfiliaciones(ByVal fechaDesde As Date, ByVal fechaHasta As Date)
        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico
        Try
            BD.ConectarBD()
            valores = BD.obtenerTotalAfiliaciones("#" + fechaDesde + "#", "#" + fechaHasta + "#")
            If valores.Count <> 0 Then
                Return valores
            Else
                'MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return list
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try
    End Function

    Public Function obtenerAportacionesAcumuladoAnterior()
        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico

        Try
            BD.ConectarBD()
            valores = BD.obtenerAportacionesAcumuladoAnterior()
            If valores.Count <> 0 Then
                Return valores
            Else
                'MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return list
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try
    End Function

    'Total certificados o aportaciones
    Public Function obtenerAportacionesTotal()
        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico
        Try
            BD.ConectarBD()
            valores = BD.obtenerAportacionesTotal()
            If valores.Count <> 0 Then
                Return valores
            Else
                ' MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return List
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try
    End Function

End Class
