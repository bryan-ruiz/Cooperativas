Imports itextsharp.text
Imports itextsharp.text.pdf
Imports System.IO

Public Class Reservas

    Dim BD As ConexionBD = New ConexionBD
    Dim estado As Boolean = True
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim informeEconomico As InformeEconomico = New InformeEconomico
    Dim listaDeReservas As List(Of ReservaClase)
    Dim socios As Socios = New Socios
    Dim certificados As Certificados = New Certificados

    Public Function afiliacionEnReserva(ByVal fechaDesde As Date, ByVal fechaHasta As Date)
        Dim valores As Integer
        Try
            BD.ConectarBD()
            valores = BD.afiliacionesDeReservas("#" + fechaDesde + "#", "#" + fechaHasta + "#")
            BD.CerrarConexion()
            Return valores
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Function

    'Cierre del Periodo en rango de fechas desde - hasta
    Public Sub realizarCierrePeriodo()
        Dim valores1 As Integer
        Dim valores2 As Integer
        Dim valores3 As Integer
        Dim valores4 As Integer
        Dim valores5 As Integer
        Dim valores6 As Integer
        Dim valores7 As Integer

        Dim fechaDesde As Date = VResrvasPrincipal.ReservasDateTimePickerDesde.Value.ToString("dd/MM/yyyy")
        Dim fechaHasta As Date = VResrvasPrincipal.ReservasDateTimePickerHasta.Value.ToString("dd/MM/yyyy")

        Dim subTotalIngresos As List(Of String) = informeEconomico.obtenerSubTotalIngresos("Ingreso", "Si", fechaDesde, fechaHasta)
        Dim subTotalGastos As List(Of String) = informeEconomico.obtenerSubTotalGastos("Gasto", "Si", fechaDesde, fechaHasta)

        'MessageBox.Show("realizar cierre del periodo con fecha inicial = " + fechaDesde + " fecha final = " + fechaHasta + " ingresos si = " + subTotalIngresos.Item(0) + " gastos si " + subTotalGastos.Item(0))

        Dim valoresReserva As List(Of ConfiguracionClase) = informeEconomico.consultarValoresConfiguracion()

        Dim excedentesBrutos As Integer = Integer.Parse(subTotalIngresos.Item(0)) - Integer.Parse(subTotalGastos.Item(0))

        Dim sumaLegal As Integer = (excedentesBrutos * valoresReserva(0).legal) / 100
        Dim sumaEducacion As Integer = (excedentesBrutos * valoresReserva(0).educacion) / 100
        Dim sumaBSocial As Integer = (excedentesBrutos * valoresReserva(0).bienestarSocial) / 100
        Dim sumaInstitucional As Integer = (excedentesBrutos * valoresReserva(0).institucional) / 100
        Dim sumaPatrimonial As Integer = (excedentesBrutos * valoresReserva(0).patrimonial) / 100

        'Si es negativo se deja en 0
        If sumaLegal < 0 Then
            sumaLegal = 0
        End If

        If sumaEducacion < 0 Then
            sumaEducacion = 0
        End If

        If sumaBSocial < 0 Then
            sumaBSocial = 0
        End If

        If sumaInstitucional < 0 Then
            sumaInstitucional = 0
        End If

        If sumaPatrimonial < 0 Then
            sumaPatrimonial = 0
        End If

        'Se actualizan los montos
        valores1 = actualizarMontoEnBase(sumaBSocial, "Bienestar Social")
        valores2 = actualizarMontoEnBase(sumaInstitucional, "Institucional")
        valores3 = actualizarMontoEnBase(sumaPatrimonial, "Patrimonial")
        valores4 = actualizarMontoEnBase(sumaEducacion, "Educacion")
        valores7 = actualizarMontoEnBase(sumaLegal, "Legal")


        Dim cantidadAfuliaciones As Integer = afiliacionEnReserva(fechaDesde, fechaHasta)

        'Suma 50% de las afiliaciones en la reserva de Educacion y 50% en Bienestar Social
        valores5 = actualizarMontoEnBase((cantidadAfuliaciones / 100) * 50, "Educacion")
        valores6 = actualizarMontoEnBase((cantidadAfuliaciones / 100) * 50, "Bienestar Social")


        'Para sumar las afiliaciones en Reservas Entradas.
        Dim fecha As String = DateTime.Now.ToString("dd/MM/yyyy")
        Dim random As Integer = CInt(Math.Ceiling(Rnd() * 5000)) + 1
        Dim random2 As Integer = CInt(Math.Ceiling(Rnd() * 5000)) + 1

        BD.ConectarBD()
        Dim totalASumar As String = (cantidadAfuliaciones / 100) * 50
        BD.insertarReservasEntradas(fecha, "admin", "Suma Admisiones a Reserva Educación", "1", totalASumar, totalASumar, "Educacion", "factura " + random.ToString)
        BD.insertarReservasEntradas(fecha, "admin", "Suma Admisiones a Reserva Bienestar Social", "1", totalASumar, totalASumar, "Bienestar Social", "factura " + random2.ToString)
        BD.CerrarConexion()

        ' MessageBox.Show("Exc brutos son = " + excedentesBrutos.ToString + " " +
        '                " Reservas son: " +
        '               "Legal = " + sumaLegal.ToString +
        '             " Ed = " + sumaEducacion.ToString +
        '            " BS = " + sumaBSocial.ToString +
        '          " Inst = " + sumaInstitucional.ToString +
        '         " patri = " + sumaPatrimonial.ToString +
        '        "Afiliaciones el total entre ed y bs es = " + cantidadAfuliaciones.ToString)


        If valores1 <> 0 And valores2 <> 0 And valores3 <> 0 And valores4 <> 0 And valores7 <> 0 Then
            MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    'Total de entradas 
    Public Function obtenerReservasEntradas()
        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico

        Try
            BD.ConectarBD()
            valores = BD.obtenerReservasEntradasTotal()
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

    'Total de salidas 
    Public Function obtenerReservasSalidas()
        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico

        Try
            BD.ConectarBD()
            valores = BD.obtenerReservasSalidasTotal()
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

    'Saldos de reservas - reporte
    Public Sub generarReporteSaldosDeReservas()

        Try
            Dim valores As List(Of SaldoReservasClase)
            Dim valoresSalidas As List(Of SaldoReservasClase)
            Dim codigosCuentaIngresos As List(Of String)
            Dim codigosCuentaGastos As List(Of String)
            Dim saldoAnteriorIngresos As String
            Dim saldoAnteriorGastos As String
            Dim saldoGlobal As Integer = 0
            'Dim saldoAnterior As Integer = 0

            BD.ConectarBD()

            valores = BD.obtenerDatosSaldoDeReservasEntradas()
            valoresSalidas = BD.obtenerDatosSaldoDeReservasSalidas()
            codigosCuentaIngresos = BD.obtenerCodigoCuentaReservasEntradas()
            codigosCuentaGastos = BD.obtenerCodigoCuentaReservasSalidas()

            'Dim totalAportacionesAcum As List(Of String) = CertificadosSalidas.obtenerAportacionesAcumuladoAnterior()
            'Dim totalAportacionesTotal As List(Of String) = CertificadosSalidas.obtenerAportacionesTotal()
            Dim totalAportacionesEntradas As List(Of String) = obtenerReservasEntradas()
            Dim totalAportacionesSalidas As List(Of String) = obtenerReservasSalidas()

            ' saldoGlobal = Integer.Parse(totalAportacionesAcum.Item(0)) + Integer.Parse(totalAportacionesTotal.Item(0))
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

            'saldoAnterior = saldoGlobal ' no se modifica el saldo anterior

            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)

            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.pathReporteSaldosReserva, FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)
            Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)
            Dim FontEncabezadoFechas = FontFactory.GetFont("Arial", 9, Font.NORMAL)

            '/////// Encabezado //////////
            pdfDoc.Add(New Paragraph("                                                                                         Reporte de Saldos de Reservas", FontEncabezadoFechas))
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
                Dim stringTotal2 As String = totalSalidas.ToString("N")
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

                'Para Entradas
                If codigosCuentaIngresos.Contains(valores(contador).codigoCuenta) Then
                    table.AddCell(entradasT)
                    table.AddCell(celdaNula)
                    saldoGlobal = saldoGlobal + valores(contador).total
                End If

                'Else
                'table.AddCell(entradasT)
                'table.AddCell(celdaNula) 'para salidas
                'saldoGlobal = saldoGlobal + valores(contador).total
                'End If


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

            'New WHILE FOR SALIDAS

            Dim contador2 As Integer = 0
            Dim conta2 As Integer = 0

            While contador2 < valoresSalidas.Count
                If conta2 = 50 Then
                    pdfDoc.Add(table)
                    pdfDoc.NewPage()
                    encabezado.encabezado(pdfWrite, pdfDoc)
                    table.DeleteBodyRows()

                    conta2 = 0
                End If

                conta2 = conta2 + 1


                'fecha
                Dim fechaT As PdfPCell = New PdfPCell(New Phrase(valoresSalidas(contador2).fecha, FontStype2))
                fechaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                fechaT.Colspan = 1
                fechaT.HorizontalAlignment = 1

                'factura o recibo
                Dim facturaT As PdfPCell = New PdfPCell(New Phrase(valoresSalidas(contador2).facturaRecibo, FontStype2))
                facturaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                facturaT.Colspan = 1
                facturaT.HorizontalAlignment = 1

                'codigo cta
                Dim codigoCuentaT As PdfPCell = New PdfPCell(New Phrase(valoresSalidas(contador2).codigoCuenta, FontStype2))
                codigoCuentaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                codigoCuentaT.Colspan = 1
                codigoCuentaT.HorizontalAlignment = 1

                'Entradas
                Dim totalEntradas As Integer = Convert.ToInt32(valoresSalidas(contador2).total)
                Dim stringTotal As String = totalEntradas.ToString("N")
                Dim entradasT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringTotal, FontStype2))
                entradasT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                entradasT.Colspan = 1
                entradasT.HorizontalAlignment = 1


                table.AddCell(fechaT)
                table.AddCell(facturaT)
                table.AddCell(codigoCuentaT)

                'Salidas
                Dim totalSalidas As Integer = Convert.ToInt32(valoresSalidas(contador2).total)
                Dim stringTotal2 As String = totalSalidas.ToString("N")
                Dim salidasT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringTotal2, FontStype2))
                salidasT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                salidasT.Colspan = 1
                salidasT.HorizontalAlignment = 1

                'Nula
                Dim celdaNula As PdfPCell = New PdfPCell(New Phrase("", FontStype2))
                celdaNula.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                celdaNula.Colspan = 1
                celdaNula.HorizontalAlignment = 1


                'Para salidas
                If codigosCuentaGastos.Contains(valoresSalidas(contador2).codigoCuenta) Then
                    table.AddCell(celdaNula)
                    table.AddCell(salidasT)
                    saldoGlobal = saldoGlobal - valoresSalidas(contador2).total
                End If

                'Saldo
                Dim totalSaldo As Integer = saldoGlobal
                Dim stringTotalGeneral As String = totalSaldo.ToString("N")
                Dim saldoT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringTotalGeneral, FontStype2))
                saldoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                saldoT.Colspan = 1
                saldoT.HorizontalAlignment = 1

                table.AddCell(saldoT)

                contador2 = contador2 + 1

            End While


            Dim tableSaldoTotal As PdfPTable = New PdfPTable(5)
            ' Dim tableSaldoAnterior As PdfPTable = New PdfPTable(5)

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

            tableSaldoTotal.AddCell(saldoGeneralR)
            tableSaldoTotal.AddCell(saldoGeneralT)

            pdfDoc.Add(table)
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(tableSaldoTotal)
            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Print.Show()
            Print.abrirReporte(variablesGlobales.pathReporteSaldosReserva)

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            MessageBox.Show(variablesGlobales.favorCerrarAdobeReader)
        End Try
    End Sub

    Public Sub crearReporteAcumuladoReservas()
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                generarReporteReservas()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
    End Sub

    Function validarNoExistenPendientes() As Integer
        Dim pendienteExcedente, pendienteCertificado As List(Of String)
        Dim cantidad As Integer = 0
        Dim estado As String = "Pendiente"
        Try
            BD.ConectarBD()

            pendienteExcedente = BD.seleccionarExcedenteTreansitoEnEstadoX(estado)
            pendienteCertificado = BD.seleccionarcertificadoTreansitoEnEstadoX(estado)
            cantidad = pendienteCertificado.Count + pendienteExcedente.Count

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + "" + ex.Message)
        End Try
        Return cantidad
    End Function


    'Función principal que llama a realizar cierre periodo
    Public Sub cerrarPeriodo()

        Dim result As Integer = MessageBox.Show("¿Seguro que desea generar el Cierre del Perido con las fechas seleccionadas?", "Favor Validar Fechas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.No Then
            'nothing
        ElseIf result = DialogResult.Yes Then

            Dim cantidadDePendiente As Integer = 0

            Try
                'Validar que no existen estados "Pendiente" EXCEDENTES-EN-TRANSITO ni en CERTIFICADOS-EN-TRANSITO
                cantidadDePendiente = validarNoExistenPendientes()

                If cantidadDePendiente <> 0 Then
                    MessageBox.Show(variablesGlobales.errorExistenDatosPendientes, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return
                End If

                'Suma los tractos al Acumulado automáticamente para todos los asociados
                certificados.sumarTractosEnTotalAcumulado()
                'Hace la función de sumar Reservas
                realizarCierrePeriodo()
                'Borra la tabla de excedentes en tránsito
                borrarExcedentesEnTransito()
                'Inserta datos nuevos en la tabla excedentes en tránsito
                GenerarExcedentesEnTransito()
                'Borra la tabla de certificados en tránsito
                borrarCertificadosEnTransito()
                'Inserta datos nuevos en la tabla de certificados en tránsito
                GenerarCertificadosEnTransito()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + "" + ex.Message)
            End Try
        End If


    End Sub

    'Borra la tabla de Excedentes en Tránsito para dejarla limpia (no hacer drop table, sino delete)
    Public Sub borrarExcedentesEnTransito()
        BD.ConectarBD()
        BD.borrarTablaExcedenteEnTransito()
        BD.CerrarConexion()
    End Sub

    'Borra la tabla de Certificados en Tránsito para dejarla limpia (no hacer drop table, sino delete)
    Public Sub borrarCertificadosEnTransito()
        BD.ConectarBD()
        BD.borrarTablaCertificadoEnTransito()
        BD.CerrarConexion()
    End Sub

    'Genera un reporte de los Excedentes correspondientes para cada asociado activo'
    Public Sub GenerarExcedentesEnTransito()

        'Fechas del View de Reservas
        Dim fechaDesde As Date = VResrvasPrincipal.ReservasDateTimePickerDesde.Value.ToString("dd/MM/yyyy")
        Dim fechaHasta As Date = VResrvasPrincipal.ReservasDateTimePickerHasta.Value.ToString("dd/MM/yyyy")

        Dim subTotalIngresos As List(Of String) = informeEconomico.obtenerSubTotalIngresos("Ingreso", "Si", fechaDesde, fechaHasta)
        Dim subTotalGastos As List(Of String) = informeEconomico.obtenerSubTotalGastos("Gasto", "Si", fechaDesde, fechaHasta)

        Try
            Dim valores As List(Of SocioClase)
            BD.ConectarBD()
            valores = BD.obtenerDatosReporteDeSocios("Todos")
            BD.CerrarConexion()

            'Aportaciones o Certificados - Acum
            Dim totalAportacionesAcumTodos As List(Of String) = socios.obtenerCertificadoTodosAcumAnterior()
            'Aportaciones o Certificados - Total o Periodo
            Dim totalAportacionesTotalTodos As List(Of String) = socios.obtenerCertificadoTodosTotal()

            'Subtotal X Socio de suma de acum + periodo (total)
            Dim subTotalAportacionesTodos As Double = Integer.Parse(totalAportacionesAcumTodos.Item(0)) + Integer.Parse(totalAportacionesTotalTodos.Item(0))
            Dim excedentesBrutos As Integer = Integer.Parse(subTotalIngresos.Item(0)) - Integer.Parse(subTotalGastos.Item(0))

            If excedentesBrutos < 0 Then
                MessageBox.Show("El reporte no se ha generado, los Exc. Brutos tienen un valor negativo", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return
            End If

            If excedentesBrutos = 0 Then
                MessageBox.Show("El reporte no se ha generado, los Exc. Brutos tienen un valor de 0", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return
            End If

            'Valores de Reservas
            Dim valoresReserva As List(Of ConfiguracionClase) = socios.consultarValoresConfiguracion()

            Dim sumaLegal As Integer = (excedentesBrutos * valoresReserva(0).legal) / 100
            Dim sumaEducacion As Integer = (excedentesBrutos * valoresReserva(0).educacion) / 100
            Dim sumaBSocial As Integer = (excedentesBrutos * valoresReserva(0).bienestarSocial) / 100
            Dim sumaInstitucional As Integer = (excedentesBrutos * valoresReserva(0).institucional) / 100
            Dim sumaPatrimonial As Integer = (excedentesBrutos * valoresReserva(0).patrimonial) / 100

            Dim sumaTotalReservas As Integer = sumaLegal + sumaEducacion + sumaBSocial + sumaInstitucional + sumaPatrimonial

            Dim sumaExcedentesNetosDistribuibles As Integer = excedentesBrutos - sumaTotalReservas

            Dim contador As Integer = 0
            Dim conta As Integer = 0
            While contador < valores.Count
                If conta = 45 Then

                    conta = 0
                End If
                conta = conta + 1

                'DATOS PARA EXC CORRESPONDIENTE

                Dim cedula As String = valores(contador).cedula
                Dim nombrees As String = valores(contador).nombre

                Dim totalAportacionesAcum As List(Of String) = socios.obtenerCertificadoXSocioAcumAnterior(cedula)
                Dim totalAportacionesTotal As List(Of String) = socios.obtenerCertificadoXSocioTotal(cedula)
                Dim subTotalAportacionesXSocio As Double = Integer.Parse(totalAportacionesAcum.Item(0)) + Integer.Parse(totalAportacionesTotal.Item(0))
                Dim resultDivisionTotalSocioEntreTotalTodosLosSocios As Double = subTotalAportacionesXSocio / subTotalAportacionesTodos
                Dim totalXSocioExcDistribuible As Double = resultDivisionTotalSocioEntreTotalTodosLosSocios * sumaExcedentesNetosDistribuibles
                Dim floorXSocio As Double = Math.Floor(totalXSocioExcDistribuible)
                Dim excCorrespN As Integer = Convert.ToInt32(floorXSocio.ToString)
                Dim excCorrespNT As String = excCorrespN.ToString("N")
                'Dim excedenteCorrespT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + excCorrespNT, FontStype2))


                BD.ConectarBD()
                BD.insertarExcedenteEnTransito(Convert.ToString(valores(contador).numAsoc), Convert.ToString(valores(contador).cedula), Convert.ToString(valores(contador).nombre), Convert.ToString(valores(contador).primerApellido), Convert.ToString(valores(contador).segundoApellido), Convert.ToString(excCorrespN), Convert.ToString("Pendiente"))
                BD.CerrarConexion()

                contador = contador + 1

            End While

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    'Genera un reporte de los Certificados correspondientes para cada asociado activo'
    Public Sub GenerarCertificadosEnTransito()

        'Fechas del View de Reservas
        Dim fechaDesde As Date = VResrvasPrincipal.ReservasDateTimePickerDesde.Value.ToString("dd/MM/yyyy")
        Dim fechaHasta As Date = VResrvasPrincipal.ReservasDateTimePickerHasta.Value.ToString("dd/MM/yyyy")

        Try
            Dim valores As List(Of SocioClase)

            BD.ConectarBD()
            valores = BD.obtenerDatosReporteDeSocios("Todos")
            BD.CerrarConexion()

            Dim contador As Integer = 0
            Dim conta As Integer = 0
            While contador < valores.Count
                If conta = 45 Then

                    conta = 0
                End If
                conta = conta + 1

                'DATOS PARA ACUM X SOCIO

                Dim cedula As String = valores(contador).cedula
                Dim nombrees As String = valores(contador).nombre


                Dim totalAportacionesAcum As List(Of String) = socios.obtenerCertificadoXSocioAcumAnterior(cedula)


                Dim totalAportacionesTotal As List(Of String) = socios.obtenerCertificadoXSocioTotal(cedula)
                Dim subTotalAcumuladoXSocio As Double = Integer.Parse(totalAportacionesAcum.Item(0))
                'Dim excCorrespN As Integer = Convert.ToInt32(subTotalAcumuladoXSocio.ToString)
                'Dim excCorrespNT As String = excCorrespN.ToString("N")
                'Dim excedenteCorrespT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + excCorrespNT, FontStype2))

                BD.ConectarBD()
                BD.insertarCertificadoEnTransito(Convert.ToString(valores(contador).numAsoc), Convert.ToString(valores(contador).cedula), Convert.ToString(valores(contador).nombre), Convert.ToString(valores(contador).primerApellido), Convert.ToString(valores(contador).segundoApellido), Convert.ToString(subTotalAcumuladoXSocio), Convert.ToString("Pendiente"))
                BD.CerrarConexion()

                contador = contador + 1

            End While

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Function acumuladoDeReserva(ByVal monto As String, ByVal reserva As String) As Integer
        Dim contador As Integer = 0
        Dim montoDeReserva As Integer = CInt(monto)
        While contador < listaDeReservas.Count
            If (listaDeReservas(contador).nombre = reserva) Then
                If (montoDeReserva > listaDeReservas(contador).monto) Then
                    Return 1
                End If
            End If
            contador += 1
        End While
        Return 0
    End Function

    Public Sub acumuladoDeReservaCambiarEnTextBox()
        Dim contador As Integer = 0
        Dim nombreReservaSeleccionada As String = VGestionDeReservas.ComboBox_reservasGestion.Text
        While contador < listaDeReservas.Count
            If listaDeReservas(contador).nombre = nombreReservaSeleccionada Then
                VGestionDeReservas.TextBox_ReservasGestionMontoActual.Text = listaDeReservas(contador).monto.ToString
            End If
            contador += 1
        End While
        'VGestionDeReservas.TextBox_ReservasGestionMonto.Text = ""
    End Sub

    ' Public Sub actualizarEnReserva()
    'Dim valores As Integer
    'Dim monto As String = VGestionDeReservas.TextBox_ReservasGestionMonto.Text
    'Dim reserva As String = VGestionDeReservas.ComboBox_reservasGestion.Text
    'If (monto = "") Then
    '       MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    'End If
    '
    'If (reserva = "") Then
    '       MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    'End If
    'Try
    '       valores = 0
    '      BD.ConectarBD()
    '     valores = BD.actualizarMontoEnReserva(monto, reserva)
    '    listaDeReservas = BD.consultarReservas()
    'If valores <> 0 Then
    '           MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    'Else
    '           MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    'End If
    '       BD.CerrarConexion()
    'Catch ex As Exception
    '       MessageBox.Show("Error en base de datos")
    'End Try
    'End Sub


    'Public Sub disminuriEnReserva()
    'Dim valores As Integer
    'Dim monto As String = VGestionDeReservas.TextBox_ReservasGestionMonto.Text
    'Dim reserva As String = VGestionDeReservas.ComboBox_reservasGestion.Text
    'If (monto = "") Then
    '       MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    'End If

    'If (reserva = "") Then
    '       MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    'End If
    'Try
    '       valores = acumuladoDeReserva(monto, reserva)
    'If valores = 1 Then
    '           MessageBox.Show("Error monto superior al que se posee registrado en la base de datos")
    'Return
    'Else
    '           valores = 0
    '          BD.ConectarBD()
    '         valores = BD.disminuirMontoEnReserva(monto, reserva)
    '        listaDeReservas = BD.consultarReservas()
    'If valores <> 0 Then
    '               MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    'Else
    '               MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    'End If
    'End If
    '       BD.CerrarConexion()
    'Catch ex As Exception
    '       MessageBox.Show("Error en base de datos")
    'End Try
    'End Sub

    Function actualizarMontoEnBase(ByVal monto As String, ByVal reserva As String) As Integer
        Dim valores As Integer
        Try
            BD.ConectarBD()
            valores = BD.insertarMontoEnReserva(monto, reserva)
            listaDeReservas = BD.consultarReservas()
            BD.CerrarConexion()
            Return valores
        Catch ex As Exception
            MessageBox.Show("Error en la base de datos")
        End Try
    End Function

    'Public Sub insertarEnReserva()
    'Dim valores As Integer
    'Dim monto As String = VGestionDeReservas.TextBox_ReservasGestionMonto.Text
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

    'Consulta las Reservas
    Public Sub obtenerDatosSeleccionarReserva()
        Try
            BD.ConectarBD()
            listaDeReservas = BD.consultarReservas()
            If listaDeReservas.Count <> 0 Then
                estado = True
                VGestionDeReservas.ComboBox_reservasGestion.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While listaDeReservas.Count > contador
                    VGestionDeReservas.ComboBox_reservasGestion.Items.Add(listaDeReservas(contador).nombre)
                    conta += 1
                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False

                    VGestionDeReservas.ComboBox_reservasGestion.Items.Clear()
                    VGestionDeReservas.ComboBox_reservasGestion.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False
                VGestionDeReservas.ComboBox_reservasGestion.Items.Clear()
                VGestionDeReservas.ComboBox_reservasGestion.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub


    Private Sub generarReporteReservas()
        Try

            BD.ConectarBD()
            listaDeReservas = BD.consultarReservas()
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.pathReporteDeAcumuladoReservas, FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            '/////// Encabezado //////////
            Dim FontStype3 = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.BLACK)
            pdfDoc.Add(New Paragraph("                                                                                        Total Acumulado en Reservas", FontStype3))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))



            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)

            Dim table As PdfPTable = New PdfPTable(3)

            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            Dim intTblWidth() As Integer = {10, 8, 8}
            table.SetWidths(intTblWidth)

            '' PARA ENCABEZADO DEL REPORTE - COLUMNAS

            Dim codigoctaR As PdfPCell = New PdfPCell(New Phrase("Nombre de Reserva", FontStype))
            codigoctaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            codigoctaR.Colspan = 2
            codigoctaR.HorizontalAlignment = 1

            Dim totalR As PdfPCell = New PdfPCell(New Phrase("Total Acumulado", FontStype))
            totalR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            totalR.Colspan = 1
            totalR.HorizontalAlignment = 1

            table.AddCell(codigoctaR)
            table.AddCell(totalR)

            Dim contador As Integer = 0
            Dim conta As Integer = 0
            While contador < listaDeReservas.Count
                If conta = 50 Then
                    pdfDoc.Add(table)
                    pdfDoc.NewPage()
                    encabezado.encabezado(pdfWrite, pdfDoc)
                    table.DeleteBodyRows()
                    conta = 0
                End If

                conta = conta + 1
                Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)

                Dim codigoctaT As PdfPCell = New PdfPCell(New Phrase(listaDeReservas(contador).nombre, FontStype2))
                codigoctaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                codigoctaT.Colspan = 2
                codigoctaT.HorizontalAlignment = 1

                Dim totalT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + listaDeReservas(contador).monto.ToString, FontStype2))
                totalT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT.Colspan = 1
                totalT.HorizontalAlignment = 1

                table.AddCell(codigoctaT)
                table.AddCell(totalT)

                contador = contador + 1
            End While

            pdfDoc.Add(table)
            pdfDoc.Add(New Paragraph(" "))

            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Print.Show()
            Print.abrirReporte(variablesGlobales.pathReporteDeAcumuladoReservas)

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            MessageBox.Show(variablesGlobales.favorCerrarAdobeReader)
        End Try
    End Sub

    Public Sub llenarDatosFechasCerrarPeriodo(ByVal valores As List(Of CerrarPeriodoFechasClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            VResrvasPrincipal.ReservasDateTimePickerDesde.Value = Date.Parse(valores(conta).fechaDesde)
            VResrvasPrincipal.ReservasDateTimePickerHasta.Value = Date.Parse(valores(conta).fechaHasta)
            conta = conta + 1
        End While
    End Sub

    Public Sub llenarDatosFechasCerrarP(ByVal valores As List(Of CerrarPeriodoFechasClase))
        Dim conta As Integer = 0

        While conta < valores.Count
            VCerrarPeriodoFechasLimite.CerrarPeriodoFechasDateTimePickerFechaInicial.Value = Date.Parse(valores(conta).fechaDesde)
            VCerrarPeriodoFechasLimite.CerrarPeriodoFechasDateTimePickerFechaFinal.Value = Date.Parse(valores(conta).fechaHasta)
            conta = conta + 1
        End While

    End Sub

    'Consulta todos los datos de la tabla de Cerrar periodo fechas
    Public Sub consultarFechasLimiteCerrarPeriodo()
        Dim valores As List(Of CerrarPeriodoFechasClase)
        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeCerrarPeriodoFechas()
            If valores.Count <> 0 Then
                llenarDatosFechasCerrarPeriodo(valores)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub consultarFechasCierreP()
        Dim valores As List(Of CerrarPeriodoFechasClase)
        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeCerrarPeriodoFechas()
            If valores.Count <> 0 Then
                llenarDatosFechasCerrarP(valores)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub


    'Actualiza todos los datos en la tabla de "Cerrar Periodo Fechas"
    Public Sub actualizarCerrarPeriodoFechas()

        Dim fechaDesde As Date = VCerrarPeriodoFechasLimite.CerrarPeriodoFechasDateTimePickerFechaInicial.Value.ToString("dd/MM/yyyy")
        Dim fechaHasta As Date = VCerrarPeriodoFechasLimite.CerrarPeriodoFechasDateTimePickerFechaFinal.Value.ToString("dd/MM/yyyy")

        Try
            BD.ConectarBD()
            Dim modificado = BD.actualizarCerrarPeriodoFechas(fechaDesde, fechaHasta)
            If modificado = 1 Then
                MessageBox.Show(variablesGlobales.datosActualizadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorActualizandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try

    End Sub


End Class
