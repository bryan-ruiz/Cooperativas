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
        valores1 = actualizarMontoEnBase(sumaBSocial, "bienestarSocial")
        valores2 = actualizarMontoEnBase(sumaInstitucional, "Institucional")
        valores3 = actualizarMontoEnBase(sumaPatrimonial, "Patrimonial")
        valores4 = actualizarMontoEnBase(sumaEducacion, "educacion")
        valores7 = actualizarMontoEnBase(sumaLegal, "legal")

        Dim cantidadAfuliaciones As Integer = afiliacionEnReserva(fechaDesde, fechaHasta)
        valores5 = actualizarMontoEnBase((cantidadAfuliaciones / 100) * 50, "educacion")
        valores6 = actualizarMontoEnBase((cantidadAfuliaciones / 100) * 50, "bienestarSocial")



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


    Public Sub crearReporteReservas()
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
        VGestionDeReservas.TextBox_ReservasGestionMonto.Text = ""
    End Sub

    Public Sub actualizarEnReserva()
        Dim valores As Integer
        Dim monto As String = VGestionDeReservas.TextBox_ReservasGestionMonto.Text
        Dim reserva As String = VGestionDeReservas.ComboBox_reservasGestion.Text
        If (monto = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If

        If (reserva = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
        Try
            valores = 0
            BD.ConectarBD()
            valores = BD.actualizarMontoEnReserva(monto, reserva)
            listaDeReservas = BD.consultarReservas()
            If valores <> 0 Then
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error en base de datos")
        End Try
    End Sub


    Public Sub disminuriEnReserva()
        Dim valores As Integer
        Dim monto As String = VGestionDeReservas.TextBox_ReservasGestionMonto.Text
        Dim reserva As String = VGestionDeReservas.ComboBox_reservasGestion.Text
        If (monto = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If

        If (reserva = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
        Try
            valores = acumuladoDeReserva(monto, reserva)
            If valores = 1 Then
                MessageBox.Show("Error monto superior al que se posee registrado en la base de datos")
                Return
            Else
                valores = 0
                BD.ConectarBD()
                valores = BD.disminuirMontoEnReserva(monto, reserva)
                listaDeReservas = BD.consultarReservas()
                If valores <> 0 Then
                    MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error en base de datos")
        End Try
    End Sub

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

    Public Sub insertarEnReserva()
        Dim valores As Integer
        Dim monto As String = VGestionDeReservas.TextBox_ReservasGestionMonto.Text
        Dim reserva As String = VGestionDeReservas.ComboBox_reservasGestion.Text
        If (monto = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
        If (reserva = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
        valores = actualizarMontoEnBase(monto, reserva)
        If valores <> 0 Then
            MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

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


    Public Sub generarReporteReservas()
        Try

            BD.ConectarBD()
            listaDeReservas = BD.consultarReservas()
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reporte_Reservas.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            '/////// Encabezado //////////
            Dim FontStype3 = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.BLACK)
            pdfDoc.Add(New Paragraph("                                                                                        Total de Acumulado en Reservas", FontStype3))
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

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & "reporte_Reservas.pdf", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message())
        End Try
    End Sub

    Public Sub llenarDatosFechasCerrarPeriodo(ByVal valores As List(Of CerrarPeriodoFechasClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            VResrvasPrincipal.ReservasDateTimePickerDesde.Value = Date.Parse(valores(conta).fechaDesde)
            VResrvasPrincipal.ReservasDateTimePickerDesde.Value = Date.Parse(valores(conta).fechaHasta)
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


    'Actualiza todos los datos en la tabla de "Cerrar Periodo Fechas"
    Public Sub actualizarCerrarPeriodoFechas()

        Dim fechaDesde As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha1.Value.ToString("dd/MM/yyyy")
        Dim fechaHasta As Date = VConfiguracionFechasLimite.ConfiguracionDateTimePickerFecha2.Value.ToString("dd/MM/yyyy")

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
