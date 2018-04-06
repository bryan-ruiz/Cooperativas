Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Saldos

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'Genera un reporte de los Socios en PDF'
    Public Sub generarReporteSaldosNuevo()

        Dim fechaInicial As Date = VIngresosSaldos.DateTimePicker_SaldosFechaInicio.Value.ToString("dd/MM/yyyy")
        Dim fechaFinal As Date = VIngresosSaldos.DateTimePicker_SaldosFechaFinal.Value.ToString("dd/MM/yyyy")

        Try
            Dim valores As List(Of SaldoClase)
            Dim codigosCuentaIngresos As List(Of String)
            Dim codigosCuentaGastos As List(Of String)
            Dim saldoAnteriorIngresos As String
            Dim saldoAnteriorGastos As String
            Dim saldoGlobal As Integer = 0
            Dim saldoAnterior As Integer = 0

            BD.ConectarBD()

            valores = BD.obtenerDatosdeSaldosXFechas(fechaInicial, fechaFinal)
            codigosCuentaIngresos = BD.obtenerCodigoCuentaIngresos()
            codigosCuentaGastos = BD.obtenerCodigoCuentaGastos()

            saldoAnteriorIngresos = (BD.obtenerSaldoTotalAnteriorDeIngresos(fechaInicial)).Item(0)
            saldoAnteriorGastos = (BD.obtenerSaldoTotalAnteriorDeGastos(fechaInicial)).Item(0)

            If (saldoAnteriorIngresos = "") Then
                saldoAnteriorIngresos = "0"
            End If

            If (saldoAnteriorGastos = "") Then
                saldoAnteriorGastos = "0"
            End If


            saldoGlobal = Integer.Parse(saldoAnteriorIngresos) - Integer.Parse(saldoAnteriorGastos) ' se modifica en el while
            saldoAnterior = saldoGlobal ' no se modifica

            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)

            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & variablesGlobales.reporteDeSaldos, FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)
            Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)
            Dim FontEncabezadoFechas = FontFactory.GetFont("Arial", 9, Font.NORMAL)

            Dim table As PdfPTable = New PdfPTable(6)

            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            ' Dim intTblWidth() As Integer = {7, 12, 12, 10, 9, 8, 7, 7, 7, 8}
            'table.SetWidths(intTblWidth)

            '' PARA ENCABEZADO DEL REPORTE - COLUMNAS



            Dim fechaR As PdfPCell = New PdfPCell(New Phrase("Fecha", FontStype))
            fechaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            fechaR.Colspan = 1
            fechaR.HorizontalAlignment = 1

            Dim facturaR As PdfPCell = New PdfPCell(New Phrase("N° Factura o Recibo", FontStype))
            facturaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            facturaR.Colspan = 1
            facturaR.HorizontalAlignment = 1

            Dim codigoCuentaR As PdfPCell = New PdfPCell(New Phrase("Código de Cuenta", FontStype))
            codigoCuentaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            codigoCuentaR.Colspan = 1
            codigoCuentaR.HorizontalAlignment = 1

            Dim entradasR As PdfPCell = New PdfPCell(New Phrase("Entradas", FontStype))
            entradasR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            entradasR.Colspan = 1
            entradasR.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right


            Dim salidasR As PdfPCell = New PdfPCell(New Phrase("Salidas", FontStype))
            salidasR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            salidasR.Colspan = 1
            salidasR.HorizontalAlignment = 1

            Dim saldoR As PdfPCell = New PdfPCell(New Phrase("Saldo", FontStype))
            saldoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            saldoR.Colspan = 1
            saldoR.HorizontalAlignment = 1

            table.AddCell(fechaR)
            table.AddCell(facturaR)
            table.AddCell(codigoCuentaR)
            table.AddCell(entradasR)
            table.AddCell(salidasR)
            table.AddCell(saldoR)

            Dim contador As Integer = 0
            Dim conta As Integer = 0
            While contador < valores.Count
                If conta = 50 Then
                    pdfDoc.Add(table)
                    pdfDoc.NewPage()
                    encabezado.encabezado(pdfWrite, pdfDoc)
                    table.DeleteBodyRows()

                    conta = 0
                End If
                conta = conta + 1

                'fecha
                Dim fechaT As PdfPCell = New PdfPCell(New Phrase(valores(contador).fecha, FontStype2))
                fechaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                fechaT.Colspan = 1
                fechaT.HorizontalAlignment = 1

                'factura o recibo
                Dim facturaT As PdfPCell = New PdfPCell(New Phrase(valores(contador).facturaRecibo, FontStype2))
                facturaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                facturaT.Colspan = 1
                facturaT.HorizontalAlignment = 1

                'codigo cta
                Dim codigoCuentaT As PdfPCell = New PdfPCell(New Phrase(valores(contador).codigoCuenta, FontStype2))
                codigoCuentaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                codigoCuentaT.Colspan = 1
                codigoCuentaT.HorizontalAlignment = 1

                'Entradas
                Dim totalEntradas As Integer = Convert.ToInt32(valores(contador).total)
                Dim stringTotal As String = totalEntradas.ToString("N")
                Dim entradasT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringTotal, FontStype2))
                entradasT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                entradasT.Colspan = 1
                entradasT.HorizontalAlignment = 1

                'Salidas
                Dim totalSalidas As Integer = Convert.ToInt32(valores(contador).total)
                Dim stringTotal2 As String = totalEntradas.ToString("N")
                Dim salidasT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringTotal2, FontStype2))
                salidasT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                salidasT.Colspan = 1
                salidasT.HorizontalAlignment = 1

                Dim celdaNula As PdfPCell = New PdfPCell(New Phrase("", FontStype2))
                celdaNula.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                celdaNula.Colspan = 1
                celdaNula.HorizontalAlignment = 1

                table.AddCell(fechaT)
                table.AddCell(facturaT)
                table.AddCell(codigoCuentaT)

                If Not codigosCuentaIngresos.Contains(valores(contador).codigoCuenta) Then
                    table.AddCell(celdaNula) ' para entradas
                    table.AddCell(salidasT)
                    saldoGlobal = saldoGlobal - valores(contador).total
                Else
                    table.AddCell(entradasT)
                    table.AddCell(celdaNula) 'para salidas
                    saldoGlobal = saldoGlobal + valores(contador).total
                End If

                'Saldo
                Dim totalSaldo As Integer = saldoGlobal
                Dim stringTotalGeneral As String = totalSaldo.ToString("N")
                Dim saldoT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringTotalGeneral, FontStype2))
                saldoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                saldoT.Colspan = 1
                saldoT.HorizontalAlignment = 1

                table.AddCell(saldoT)

                contador = contador + 1
            End While

            Dim tableSaldoTotal As PdfPTable = New PdfPTable(5)
            Dim tableSaldoAnterior As PdfPTable = New PdfPTable(5)

            Dim FontStypeSaldoBlanco = FontFactory.GetFont("Arial", 8, Font.BOLD, BaseColor.WHITE)

            'PARA TOTAL GENERAL
            Dim saldoGeneralR As PdfPCell = New PdfPCell(New Phrase("Saldo Total: ", FontStypeSaldoBlanco))
            saldoGeneralR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            saldoGeneralR.Colspan = 3
            saldoGeneralR.HorizontalAlignment = 1

            Dim FontStype4 = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.BLACK)
            Dim FontStypeSubTotales = FontFactory.GetFont("Arial", 8, Font.BOLD, BaseColor.BLACK)

            'Saldo total
            Dim stringTotal5 As String = saldoGlobal.ToString("N")

            Dim saldoGeneralT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringTotal5, FontStypeSubTotales))
            saldoGeneralT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            saldoGeneralT.Colspan = 2
            saldoGeneralT.HorizontalAlignment = 1



            'SALDO ANTERIOR
            Dim saldoAnteriorR As PdfPCell = New PdfPCell(New Phrase("Saldo Anterior: ", FontStypeSaldoBlanco))
            saldoAnteriorR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            saldoAnteriorR.Colspan = 3
            saldoAnteriorR.HorizontalAlignment = 1
            'Saldo anterior
            Dim stringTotal6 As String = saldoAnterior.ToString("N")
            Dim saldoAnteriorT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringTotal6, FontStypeSubTotales))
            saldoAnteriorT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            saldoAnteriorT.Colspan = 2
            saldoAnteriorT.HorizontalAlignment = 1


            '/////// Encabezado //////////
            pdfDoc.Add(New Paragraph("                                                                               Reporte de Saldos del " + fechaInicial + " al " + fechaFinal, FontEncabezadoFechas))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))

            tableSaldoTotal.AddCell(saldoGeneralR)
            tableSaldoTotal.AddCell(saldoGeneralT)
            tableSaldoAnterior.AddCell(saldoAnteriorR)
            tableSaldoAnterior.AddCell(saldoAnteriorT)

            pdfDoc.Add(tableSaldoAnterior)
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(table)
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(tableSaldoTotal)
            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & variablesGlobales.reporteDeSaldos, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try
    End Sub


End Class
