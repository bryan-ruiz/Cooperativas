Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Saldos

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'Genera un reporte de los Socios en PDF'
    Public Sub generarReporteSaldosNuevo()
        Dim fechaInicial As String = VIngresosSaldos.DateTimePicker_SaldosFechaInicio.Text
        Dim fechaFinal As String = VIngresosSaldos.DateTimePicker_SaldosFechaFinal.Text

        Try
            Dim valores As List(Of SaldoClase)
            Dim codigosCuentaIngresos As List(Of String)
            Dim codigosCuentaGastos As List(Of String)
            Dim saldoGlobal As Integer = 0

            BD.ConectarBD()

            valores = BD.obtenerDatosdeSaldosXFechas("#" + fechaInicial + "#", "#" + fechaFinal + "#")
            codigosCuentaIngresos = BD.obtenerCodigoCuentaIngresos
            codigosCuentaGastos = BD.obtenerCodigoCuentaGastos
            saldoGlobal = 10000

            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)

            Dim nombreReporteSaldos As String = "reporteSaldos.pdf"

            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & nombreReporteSaldos, FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)

            Dim table As PdfPTable = New PdfPTable(5)

            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            ' Dim intTblWidth() As Integer = {7, 12, 12, 10, 9, 8, 7, 7, 7, 8}
            'table.SetWidths(intTblWidth)

            '' PARA ENCABEZADO DEL REPORTE - COLUMNAS

            Dim fechaR As PdfPCell = New PdfPCell(New Phrase("Fecha", FontStype))
            fechaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            fechaR.Colspan = 1
            fechaR.HorizontalAlignment = 1

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

                Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)

                'fecha
                Dim fechaT As PdfPCell = New PdfPCell(New Phrase(valores(contador).fecha, FontStype2))
                fechaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                fechaT.Colspan = 1
                fechaT.HorizontalAlignment = 1

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

            pdfDoc.Add(table)
            pdfDoc.Close()
            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & nombreReporteSaldos, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
        End Try
    End Sub


End Class
