Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class CertificadosEntradas

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Public Sub limpiar()
        VCertificadosEntradas.CertificadosEntradasTextboxFacturaRecibos.Text = ""
        VCertificadosEntradas.CertificadosEntradasTexboxCliente.Text = ""
        VCertificadosEntradas.CertificadosEntradasDescripcion.Text = ""
        VCertificadosEntradas.CertificadosEntradasCantidad.Text = ""
        VCertificadosEntradas.CertificadosEntradasPrecioUnitario.Text = ""
        VCertificadosEntradas.CertificadosEntradasTotal.Text = ""
    End Sub

    Public Sub calcularTotal()
        Try
            Dim cantidad As Integer = Integer.Parse(VCertificadosEntradas.CertificadosEntradasCantidad.Text)
            Dim precioUnitario As Integer = Integer.Parse(VCertificadosEntradas.CertificadosEntradasPrecioUnitario.Text)

            Dim resultado As Integer = cantidad * precioUnitario
            'Format ¢ 1,000.00
            '¢ + Dim stringTotal As String = resultado.ToString("N")

            VCertificadosEntradas.CertificadosEntradasTotal.Text = resultado

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Sub insertarCertificadoEntrada()

        Dim valores As Integer

        Dim fecha As String = VCertificadosEntradas.CertificadosEntradasFecha.Text
        Dim factura As String = VCertificadosEntradas.CertificadosEntradasTextboxFacturaRecibos.Text
        Dim cliente As String = VCertificadosEntradas.CertificadosEntradasTexboxCliente.Text
        Dim descripcion As String = VCertificadosEntradas.CertificadosEntradasDescripcion.Text
        Dim cantidad As String = VCertificadosEntradas.CertificadosEntradasCantidad.Text
        Dim precioUnitario As String = VCertificadosEntradas.CertificadosEntradasPrecioUnitario.Text
        Dim total As String = VCertificadosEntradas.CertificadosEntradasTotal.Text
        Dim codCuenta As String = VCertificadosEntradas.CertificadosEntradasCodigoDeCuenta.Text
        Dim facturaReciboYaExiste As Integer = 0

        If (factura = "" Or cliente = "" Or descripcion = "" Or cantidad = "" Or precioUnitario = "" Or total = "" Or codCuenta = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (total.Equals("0")) Then
            MessageBox.Show(variablesGlobales.errorTotalEnCero, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
            Return
        End If

        Try
            Integer.Parse(cantidad)
            Integer.Parse(precioUnitario)
            Integer.Parse(total)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End Try

        'Validar que no existen facturas con el mismo ID en el Sistema
        facturaReciboYaExiste = validarNoExistenFacturasRepetidasCertificadosEntradas(factura)
        If facturaReciboYaExiste <> 0 Then
            MessageBox.Show(variablesGlobales.errorFacturaOReciboExiste, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            VCertificadosEntradas.CertificadosEntradasTextboxFacturaRecibos.Text = ""
            VCertificadosEntradas.CertificadosEntradasTextboxFacturaRecibos.Select()
            Return
        End If

        Try
            BD.ConectarBD()
            valores = BD.insertarCertificadosEntradas(fecha, cliente, descripcion, cantidad, precioUnitario, total, codCuenta, factura)
            If valores <> 0 Then
                limpiar()
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try

    End Sub

    'Valida que no exista la factura en la tabla 
    Function validarNoExistenFacturasRepetidasCertificadosEntradas(ByVal factura As String) As Integer
        Dim facturasRepetidas As List(Of String)
        Dim cantidad As Integer = 0

        Try
            BD.ConectarBD()

            facturasRepetidas = BD.obtenerCertificadosEntradasPorFactura(factura)
            cantidad = facturasRepetidas.Count

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + "" + ex.Message)
        End Try
        Return cantidad
    End Function

    'Reporte Aportaciones
    Public Sub generarReporteAportaciones()
        Try
            Dim valores As List(Of AportacionesClase)
            Dim totalAcumAnterior As String
            Dim totalPeriodoActual As String
            Dim saldoGlobal As Integer = 0

            BD.ConectarBD()

            'Consulta Datos
            valores = BD.obtenerDatosdeReporteAportaciones()
            totalAcumAnterior = (BD.obtenerAportacionesAcumuladoAnterior()).Item(0)
            totalPeriodoActual = (BD.obtenerAportacionesTotal()).Item(0)
            saldoGlobal = Integer.Parse(totalAcumAnterior) + Integer.Parse(totalPeriodoActual)

            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)

            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & variablesGlobales.reporteDeAportaciones, FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)
            Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)
            Dim FontEncabezadoFechas = FontFactory.GetFont("Arial", 9, Font.NORMAL)

            '/////// Encabezado //////////
            ' pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("                                                                                                Reporte de Aportaciones ", FontEncabezadoFechas))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))



            Dim table As PdfPTable = New PdfPTable(8)

            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            Dim intTblWidth() As Integer = {7, 10, 7, 7, 7, 7, 7, 7}
            table.SetWidths(intTblWidth)

            '' PARA ENCABEZADO DEL REPORTE - COLUMNAS
            Dim numAsociadoR As PdfPCell = New PdfPCell(New Phrase("N° Asociado", FontStype))
            numAsociadoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            numAsociadoR.Colspan = 1
            numAsociadoR.HorizontalAlignment = 1

            Dim nombreR As PdfPCell = New PdfPCell(New Phrase("Nombre Completo", FontStype))
            nombreR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            nombreR.Colspan = 2
            nombreR.HorizontalAlignment = 1

            Dim cedulaR As PdfPCell = New PdfPCell(New Phrase("N° Identificación", FontStype))
            cedulaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            cedulaR.Colspan = 1
            cedulaR.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

            Dim calidadR As PdfPCell = New PdfPCell(New Phrase("Calidad", FontStype))
            calidadR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            calidadR.Colspan = 1
            calidadR.HorizontalAlignment = 1

            Dim estadoR As PdfPCell = New PdfPCell(New Phrase("Estado", FontStype))
            estadoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            estadoR.Colspan = 1
            estadoR.HorizontalAlignment = 1

            Dim acumAnteriorR As PdfPCell = New PdfPCell(New Phrase("Acum Anterior", FontStype))
            acumAnteriorR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            acumAnteriorR.Colspan = 1
            acumAnteriorR.HorizontalAlignment = 1

            Dim periodoActualR As PdfPCell = New PdfPCell(New Phrase("Periodo Actual", FontStype))
            periodoActualR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            periodoActualR.Colspan = 1
            periodoActualR.HorizontalAlignment = 1


            table.AddCell(numAsociadoR)
            table.AddCell(nombreR)
            table.AddCell(cedulaR)
            table.AddCell(calidadR)
            table.AddCell(estadoR)
            table.AddCell(acumAnteriorR)
            table.AddCell(periodoActualR)

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

                ' MessageBox.Show("valores num asociado es " + valores(conta).numAsoc)

                Dim numAsociadoT As PdfPCell = New PdfPCell(New Phrase(valores(contador).numAsoc, FontStype2))
                numAsociadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                numAsociadoT.Colspan = 1
                numAsociadoT.HorizontalAlignment = 1

                Dim nombreTotal As String = valores(contador).nombre + " " + valores(contador).primerApellido + " " + valores(contador).segundoApellido
                Dim nombreT As PdfPCell = New PdfPCell(New Phrase(nombreTotal, FontStype2))
                nombreT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                nombreT.Colspan = 2
                nombreT.HorizontalAlignment = 1

                Dim cedulaTotalT As PdfPCell = New PdfPCell(New Phrase(valores(contador).cedula, FontStype2))
                cedulaTotalT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                cedulaTotalT.Colspan = 1
                cedulaTotalT.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

                Dim calidadT As PdfPCell = New PdfPCell(New Phrase(valores(contador).tipoAsociado, FontStype2))
                calidadT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                calidadT.Colspan = 1
                calidadT.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

                Dim estadoT As PdfPCell = New PdfPCell(New Phrase(valores(contador).estado, FontStype2))
                estadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                estadoT.Colspan = 1
                estadoT.HorizontalAlignment = 1

                'Acum
                Dim acumAnteriorT As Integer = Convert.ToInt32(valores(contador).acumAnterior)
                Dim stringTotal As String = acumAnteriorT.ToString("N")
                Dim acumT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringTotal, FontStype2))
                acumT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                acumT.Colspan = 1
                acumT.HorizontalAlignment = 1

                'Total del periodo actual
                Dim periodoActualT As Integer = Convert.ToInt32(valores(contador).periodoActual)
                Dim stringTotal2 As String = periodoActualT.ToString("N")
                Dim periodoT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringTotal2, FontStype2))
                periodoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                periodoT.Colspan = 1
                periodoT.HorizontalAlignment = 1

                table.AddCell(numAsociadoT)
                table.AddCell(nombreT)
                table.AddCell(cedulaTotalT)
                table.AddCell(calidadT)
                table.AddCell(estadoT)
                table.AddCell(acumT)
                table.AddCell(periodoT)

                contador = contador + 1
            End While

            Dim FontStype4 = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.BLACK)
            Dim FontStypeSubTotales = FontFactory.GetFont("Arial", 8, Font.BOLD, BaseColor.BLACK)
            Dim FontStypeSaldoBlanco = FontFactory.GetFont("Arial", 8, Font.BOLD, BaseColor.WHITE)

            Dim tableSaldoAcumAnterior As PdfPTable = New PdfPTable(8)
            Dim tableSaldoPeriodoActual As PdfPTable = New PdfPTable(8)
            Dim tableSaldoGeneral As PdfPTable = New PdfPTable(8)

            'Saldo Acum Anterior
            Dim saldoAcumAnteriorR As PdfPCell = New PdfPCell(New Phrase("Saldo Acum Anterior: ", FontStypeSaldoBlanco))
            saldoAcumAnteriorR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            saldoAcumAnteriorR.Colspan = 6
            saldoAcumAnteriorR.HorizontalAlignment = 1

            'Saldo Acum Anterior
            Dim stringAcum1 As String = Integer.Parse(totalAcumAnterior).ToString("N")
            Dim saldoAcumAnteriorT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringAcum1, FontStypeSubTotales))
            saldoAcumAnteriorT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            saldoAcumAnteriorT.Colspan = 2
            saldoAcumAnteriorT.HorizontalAlignment = 1

            'Saldo Acum Periodo actual
            Dim saldoPeriodoActualR As PdfPCell = New PdfPCell(New Phrase("Saldo Periodo Actual: ", FontStypeSaldoBlanco))
            saldoPeriodoActualR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            saldoPeriodoActualR.Colspan = 6
            saldoPeriodoActualR.HorizontalAlignment = 1

            'Saldo Acum Periodo actual
            Dim stringPeriodoActual1 As String = Integer.Parse(totalPeriodoActual).ToString("N")
            Dim saldoPeriodoActualT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringPeriodoActual1, FontStypeSubTotales))
            saldoPeriodoActualT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            saldoPeriodoActualT.Colspan = 2
            saldoPeriodoActualT.HorizontalAlignment = 1

            'Saldo Total (suma de acum anterior + periodo actual)
            Dim saldoTotalR As PdfPCell = New PdfPCell(New Phrase("Saldo Total: ", FontStypeSaldoBlanco))
            saldoTotalR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            saldoTotalR.Colspan = 6
            saldoTotalR.HorizontalAlignment = 1

            'Saldo Acum Periodo actual
            Dim saldoTotalT2 As String = saldoGlobal.ToString("N")
            Dim saldoTotalT As PdfPCell = New PdfPCell(New Phrase("¢ " + saldoTotalT2, FontStypeSubTotales))
            saldoTotalT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            saldoTotalT.Colspan = 2
            saldoTotalT.HorizontalAlignment = 1





            tableSaldoAcumAnterior.AddCell(saldoAcumAnteriorR)
            tableSaldoAcumAnterior.AddCell(saldoAcumAnteriorT)
            tableSaldoPeriodoActual.AddCell(saldoPeriodoActualR)
            tableSaldoPeriodoActual.AddCell(saldoPeriodoActualT)
            tableSaldoGeneral.AddCell(saldoTotalR)
            tableSaldoGeneral.AddCell(saldoTotalT)

            pdfDoc.Add(table)
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(tableSaldoAcumAnterior)
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(tableSaldoPeriodoActual)
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(tableSaldoGeneral)
            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & variablesGlobales.reporteDeAportaciones, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            MessageBox.Show(variablesGlobales.favorCerrarAdobeReader)
        End Try
    End Sub


End Class
