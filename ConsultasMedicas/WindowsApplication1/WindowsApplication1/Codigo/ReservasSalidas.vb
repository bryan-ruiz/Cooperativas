Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class ReservasSalidas

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim certificadosSalidas As CertificadosSalidas = New CertificadosSalidas
    Dim estado As Boolean = True
    Dim informeEconomico As InformeEconomico = New InformeEconomico
    Dim listaDeReservas As List(Of ReservaClase)
    Dim socios As Socios = New Socios
    Dim certificados As Certificados = New Certificados
    Dim reservas As Reservas = New Reservas

    'Consulta los codigos de cuenta de Reservas
    Public Sub obtenerDatosSeleccionarReserva()
        Try
            BD.ConectarBD()
            listaDeReservas = BD.consultarReservas()
            If listaDeReservas.Count <> 0 Then
                estado = True
                VReservasSalidas.ComboBox_IngresosCodigCuenta.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While listaDeReservas.Count > contador
                    VReservasSalidas.ComboBox_IngresosCodigCuenta.Items.Add(listaDeReservas(contador).nombre)
                    conta += 1
                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False

                    VReservasSalidas.ComboBox_IngresosCodigCuenta.Items.Clear()
                    VReservasSalidas.ComboBox_IngresosCodigCuenta.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False
                VReservasSalidas.ComboBox_IngresosCodigCuenta.Items.Clear()
                VReservasSalidas.ComboBox_IngresosCodigCuenta.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        VReservasSalidas.CertificadosEntradasTextboxFacturaRecibos.Text = ""
        VReservasSalidas.CertificadosEntradasTexboxCliente.Text = ""
        VReservasSalidas.CertificadosEntradasDescripcion.Text = ""
        VReservasSalidas.CertificadosEntradasCantidad.Text = ""
        VReservasSalidas.CertificadosEntradasPrecioUnitario.Text = ""
        VReservasSalidas.CertificadosEntradasTotal.Text = ""
    End Sub

    Public Sub calcularTotal()
        Try
            Dim cantidad As Integer = Integer.Parse(VReservasSalidas.CertificadosEntradasCantidad.Text)
            Dim precioUnitario As Integer = Integer.Parse(VReservasSalidas.CertificadosEntradasPrecioUnitario.Text)

            Dim resultado As Integer = cantidad * precioUnitario
            'Format ¢ 1,000.00
            '¢ + Dim stringTotal As String = resultado.ToString("N")

            VReservasSalidas.CertificadosEntradasTotal.Text = resultado

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Sub insertarReservaSalida()

        Dim valores As Integer

        Dim fecha As String = VReservasSalidas.CertificadosEntradasFecha.Text
        Dim factura As String = VReservasSalidas.CertificadosEntradasTextboxFacturaRecibos.Text
        Dim cliente As String = VReservasSalidas.CertificadosEntradasTexboxCliente.Text
        Dim descripcion As String = VReservasSalidas.CertificadosEntradasDescripcion.Text
        Dim cantidad As String = VReservasSalidas.CertificadosEntradasCantidad.Text
        Dim precioUnitario As String = VReservasSalidas.CertificadosEntradasPrecioUnitario.Text
        Dim total As String = VReservasSalidas.CertificadosEntradasTotal.Text
        Dim codCuenta As String = VReservasSalidas.ComboBox_IngresosCodigCuenta.Text
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
        facturaReciboYaExiste = validarNoExistenFacturasRepetidasrReservasSalidas(factura)
        If facturaReciboYaExiste <> 0 Then
            MessageBox.Show(variablesGlobales.errorFacturaOReciboExiste, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            VReservasSalidas.CertificadosEntradasTextboxFacturaRecibos.Text = ""
            VReservasSalidas.CertificadosEntradasTextboxFacturaRecibos.Select()
            Return
        End If

        Try
            BD.ConectarBD()
            listaDeReservas = BD.consultarReservasXNombre(codCuenta)
            BD.CerrarConexion()

            Dim saldoReserva As Integer = Convert.ToInt32(listaDeReservas(0).monto.ToString)

            If (Integer.Parse(total) > saldoReserva) Then
                MessageBox.Show("Nota: El Saldo total de la Reserva Seleccionada es de: ¢ " + saldoReserva.ToString("N"))
                MessageBox.Show(variablesGlobales.errorMontoMayorAlSaldoTotalDeReserva, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                VCertificadosSalidas.CertificadosSalidasPrecioUnitario.Text = ""
                VCertificadosSalidas.CertificadosSalidasTotal.Text = ""
                VCertificadosSalidas.CertificadosSalidasCantidad.Text = ""
                VCertificadosSalidas.CertificadosSalidasCantidad.Select()
                Return
            End If

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try

        Try
            BD.ConectarBD()
            valores = BD.insertarReservasSalidas(fecha, cliente, descripcion, cantidad, precioUnitario, total, codCuenta, factura)
            If valores <> 0 Then
                limpiar()
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                BD.disminuirMontoEnReserva(total, codCuenta)
                reservas.obtenerDatosSeleccionarReserva()
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try

    End Sub

    'Public Sub insertarEnReserva()
    'Dim valores As Integer
    ' Dim total As String = VReservasSalidas.CertificadosEntradasTotal.Text
    'Dim reserva As String = VGestionDeReservas.ComboBox_reservasGestion.Text
    'If (monto = "") Then
    '       MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    'End If
    'If (reserva = "") Then
    '       MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    'End If
    '   valores = actualizarMontoEnBase(monto, reserva)
    'If valores <> 0 Then
    '  MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    '
    '   Else
    '      MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    ' End If
    'End Sub

    'Valida que no exista la factura en la tabla 
    Function validarNoExistenFacturasRepetidasrReservasSalidas(ByVal factura As String) As Integer
        Dim facturasRepetidas As List(Of String)
        Dim cantidad As Integer = 0

        Try
            BD.ConectarBD()

            facturasRepetidas = BD.obtenerReservasSalidasPorFactura(factura)
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

            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.pathReporteAportaciones, FileMode.Create))
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

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Print.Show()
            Print.abrirReporte(variablesGlobales.pathReporteAportaciones)

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            MessageBox.Show(variablesGlobales.favorCerrarAdobeReader)
        End Try
    End Sub


    'Saldos de aportaciones - reporte
    Public Sub generarReporteSaldosDeAportaciones()

        Try
            Dim valores As List(Of SaldoAportacionesClase)
            Dim codigosCuentaIngresos As List(Of String)
            Dim codigosCuentaGastos As List(Of String)
            Dim saldoAnteriorIngresos As String
            Dim saldoAnteriorGastos As String
            Dim saldoGlobal As Integer = 0
            Dim saldoAnterior As Integer = 0

            BD.ConectarBD()

            valores = BD.obtenerDatosSaldoDeAportaciones()
            codigosCuentaIngresos = BD.obtenerCodigoCuentaCertificadosEntradas()
            codigosCuentaGastos = BD.obtenerCodigoCuentaCertificadosSalidas()

            Dim totalAportacionesAcum As List(Of String) = certificadosSalidas.obtenerAportacionesAcumuladoAnterior()
            Dim totalAportacionesTotal As List(Of String) = certificadosSalidas.obtenerAportacionesTotal()
            Dim totalAportacionesEntradas As List(Of String) = certificadosSalidas.obtenerAportacionesEntradas()
            Dim totalAportacionesSalidas As List(Of String) = certificadosSalidas.obtenerAportacionesSalidas()

            saldoGlobal = Integer.Parse(totalAportacionesAcum.Item(0)) + Integer.Parse(totalAportacionesTotal.Item(0))
            'Integer.Parse(totalAportacionesEntradas.Item(0)) -
            'Integer.Parse(totalAportacionesSalidas.Item(0))

            saldoAnteriorIngresos = totalAportacionesEntradas.Item(0)
            saldoAnteriorGastos = totalAportacionesSalidas.Item(0)

            If (saldoAnteriorIngresos = "") Then
                saldoAnteriorIngresos = "0"
            End If

            If (saldoAnteriorGastos = "") Then
                saldoAnteriorGastos = "0"
            End If

            saldoAnterior = saldoGlobal ' no se modifica el saldo anterior

            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)

            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & variablesGlobales.reporteDeSaldosDeAportaciones, FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)
            Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)
            Dim FontEncabezadoFechas = FontFactory.GetFont("Arial", 9, Font.NORMAL)

            '/////// Encabezado //////////
            pdfDoc.Add(New Paragraph("                                                                                         Reporte de Saldos de Aportaciones", FontEncabezadoFechas))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))


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

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & variablesGlobales.reporteDeSaldosDeAportaciones, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            MessageBox.Show(variablesGlobales.favorCerrarAdobeReader)
        End Try
    End Sub

End Class
