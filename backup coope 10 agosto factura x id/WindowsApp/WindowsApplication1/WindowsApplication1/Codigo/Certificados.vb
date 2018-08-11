Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Certificados
    Dim montoMaxPeriodo As Integer
    Dim montoMaxTracto As Integer
    Dim BD As ConexionBD = New ConexionBD
    Dim configuracion As Configuracion = New Configuracion
    Dim estado As Boolean = True
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim socios As Socios = New Socios


    Public Sub obtenerMontoCertificadosVar()
        Dim valores As List(Of ConfiguracionClase)
        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeConfiguration()
            If valores.Count <> 0 Then
                Dim contador As Integer = 0
                While valores.Count > contador
                    montoMaxPeriodo = valores(contador).montoMaxPeriodo
                    montoMaxTracto = valores(contador).montoMaxTracto
                    contador = contador + 1
                End While
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub consultar()
        obtenerMontoCertificadosVar()
        Dim valores As List(Of String)
        Dim cedulaOnumAsociado As String = VCertificados.CertificadosTextboxCedulaNumAsociado.Text

        If (cedulaOnumAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                valores = BD.consultarCertificadoXSocio(cedulaOnumAsociado)

                If valores.Count <> 0 Then
                    VCertificados.CertificadosTextboxNombre.Text = valores(0) + " " + valores(1) + " " + valores(2)
                    VCertificados.CertificadosTextboxCed.Text = valores(4)
                    VCertificados.CertificadosTextboxNumAsociado.Text = valores(5)
                    VCertificados.CertificadosTextboxTracto1.Text = valores(6)
                    VCertificados.CertificadosTextboxTracto2.Text = valores(7)
                    VCertificados.CertificadosTextboxTracto3.Text = valores(8)
                    VCertificados.CertificadosTextboxTracto4.Text = valores(9)
                    VCertificados.CertificadosTextboxTracto5.Text = valores(10)
                    VCertificados.CertificadosTextboxTracto6.Text = valores(11)
                    VCertificados.CertificadosTextboxTracto7.Text = valores(12)
                    VCertificados.CertificadosTextboxTracto8.Text = valores(13)
                    VCertificados.CertificadosTextboxTracto9.Text = valores(14)
                    VCertificados.CertificadosTextboxTracto10.Text = valores(15)
                    VCertificados.CertificadosTextboxAcumAnterior.Text = valores(16)
                    VCertificados.CertificadosTextboxTotalPeriodo.Text = valores(17)

                    consultarFechasLimite()

                Else
                    MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    VCertificados.CertificadosTextboxCedulaNumAsociado.Text = ""
                End If

                BD.CerrarConexion()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
    End Sub


    'sumar tractos en periodo total
    Public Sub sumarTractosEnTotalAcumulado()
        Try
            BD.ConectarBD()
            Dim hecho As Integer = BD.sumarTractosAlAcumuladoAnterior()
            BD.CerrarConexion()

            If hecho = 0 Then
                MessageBox.Show(variablesGlobales.errorSumandoTractosParaTodosAsociados, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.tractosSumadosConExitoParaTodosAsociados, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try

    End Sub

    'sumar tractos
    Public Sub sumarTractosEnCertificados(ByVal nuvoTotal As Integer, ByVal cedula As String)
        Try
            BD.ConectarBD()
            Dim hecho As Integer = BD.totalEnPeriodo(cedula, nuvoTotal)
            BD.CerrarConexion()

            If hecho = 0 Then
                MessageBox.Show(variablesGlobales.errorActualizandoDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Else
                VCertificados.CertificadosTextboxTotalPeriodo.Text = nuvoTotal.ToString
            End If

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try

    End Sub

    'Update tracto with value "numeroTracto"
    Public Sub editarTracto(ByVal numeroTracto As String)
        Dim monto As String = ""
        Dim cedula As String = VCertificados.CertificadosTextboxCedulaNumAsociado.Text

        If numeroTracto = "1" Then
            monto = VCertificados.CertificadosTextboxTracto1.Text
        ElseIf numeroTracto = "2" Then
            monto = VCertificados.CertificadosTextboxTracto2.Text
        ElseIf numeroTracto = "3" Then
            monto = VCertificados.CertificadosTextboxTracto3.Text
        ElseIf numeroTracto = "4" Then
            monto = VCertificados.CertificadosTextboxTracto4.Text
        ElseIf numeroTracto = "5" Then
            monto = VCertificados.CertificadosTextboxTracto5.Text
        ElseIf numeroTracto = "6" Then
            monto = VCertificados.CertificadosTextboxTracto6.Text
        ElseIf numeroTracto = "7" Then
            monto = VCertificados.CertificadosTextboxTracto7.Text
        ElseIf numeroTracto = "8" Then
            monto = VCertificados.CertificadosTextboxTracto8.Text
        ElseIf numeroTracto = "9" Then
            monto = VCertificados.CertificadosTextboxTracto9.Text
        ElseIf numeroTracto = "10" Then
            monto = VCertificados.CertificadosTextboxTracto10.Text
        End If

        Try
            BD.ConectarBD()
            Dim hecho As Integer = BD.actualizarTracto(numeroTracto, cedula, monto)
            If hecho = 0 Then
                MessageBox.Show(variablesGlobales.errorActualizandoDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.datosActualizadosConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error" + ex.Message)
        End Try
    End Sub

    'Consulta las fechas limite para pagar certificados
    Public Sub consultarFechasLimite()
        Dim fechas As List(Of ConfiguracionClase)
        Try
            BD.ConectarBD()
            fechas = BD.obtenerDatosdeConfiguration()
            If fechas.Count <> 0 Then
                llenarDatosFechaLimite(fechas)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    'Llena los campos con los datos de la consulta
    Public Sub llenarDatosFechaLimite(ByVal valores As List(Of ConfiguracionClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            VCertificados.CertificadosDateTimePickerFecha1.Value = Date.Parse(valores(conta).fechaLimite1)
            VCertificados.CertificadosDateTimePickerFecha2.Value = Date.Parse(valores(conta).fechaLimite2)
            VCertificados.CertificadosDateTimePickerFecha3.Value = Date.Parse(valores(conta).fechaLimite3)
            VCertificados.CertificadosDateTimePickerFecha4.Value = Date.Parse(valores(conta).fechaLimite4)
            VCertificados.CertificadosDateTimePickerFecha5.Value = Date.Parse(valores(conta).fechaLimite5)
            VCertificados.CertificadosDateTimePickerFecha6.Value = Date.Parse(valores(conta).fechaLimite6)
            VCertificados.CertificadosDateTimePickerFecha7.Value = Date.Parse(valores(conta).fechaLimite7)
            VCertificados.CertificadosDateTimePickerFecha8.Value = Date.Parse(valores(conta).fechaLimite8)
            VCertificados.CertificadosDateTimePickerFecha9.Value = Date.Parse(valores(conta).fechaLimite9)
            VCertificados.CertificadosDateTimePickerFecha10.Value = Date.Parse(valores(conta).fechaLimite10)
            conta = conta + 1
        End While
    End Sub

    'Valida la fecha límite
    Private Function validarFecha(ByVal fecha As DateTime) As Boolean
        Dim value As Boolean = False
        Dim GETDATE As DateTime = DateTime.Today

        If fecha.CompareTo(GETDATE) > 0 Then
            value = False
        End If
        If fecha.CompareTo(GETDATE) < 0 Then
            value = True
        End If

        Return value

    End Function


    Public Sub validarTracto(ByVal numTracto As String, ByVal fecha As DateTime)
        Dim tracto1 As String = VCertificados.CertificadosTextboxTracto1.Text
        Dim tracto2 As String = VCertificados.CertificadosTextboxTracto2.Text
        Dim tracto3 As String = VCertificados.CertificadosTextboxTracto3.Text
        Dim tracto4 As String = VCertificados.CertificadosTextboxTracto4.Text
        Dim tracto5 As String = VCertificados.CertificadosTextboxTracto5.Text
        Dim tracto6 As String = VCertificados.CertificadosTextboxTracto6.Text
        Dim tracto7 As String = VCertificados.CertificadosTextboxTracto7.Text
        Dim tracto8 As String = VCertificados.CertificadosTextboxTracto8.Text
        Dim tracto9 As String = VCertificados.CertificadosTextboxTracto9.Text
        Dim tracto10 As String = VCertificados.CertificadosTextboxTracto10.Text

        Dim cedula As String = VCertificados.CertificadosTextboxCedulaNumAsociado.Text

        BD.ConectarBD()
        Dim periodo As Integer = BD.sumarTractosEnCertificadosBD(cedula)
        BD.CerrarConexion()

        Dim monto As String = "0"

        If numTracto = "1" Then
            monto = VCertificados.CertificadosTextboxTracto1.Text
        ElseIf numTracto = "2" Then
            monto = VCertificados.CertificadosTextboxTracto2.Text
        ElseIf numTracto = "3" Then
            monto = VCertificados.CertificadosTextboxTracto3.Text
        ElseIf numTracto = "4" Then
            monto = VCertificados.CertificadosTextboxTracto4.Text
        ElseIf numTracto = "5" Then
            monto = VCertificados.CertificadosTextboxTracto5.Text
        ElseIf numTracto = "6" Then
            monto = VCertificados.CertificadosTextboxTracto6.Text
        ElseIf numTracto = "7" Then
            monto = VCertificados.CertificadosTextboxTracto7.Text
        ElseIf numTracto = "8" Then
            monto = VCertificados.CertificadosTextboxTracto8.Text
        ElseIf numTracto = "9" Then
            monto = VCertificados.CertificadosTextboxTracto9.Text
        ElseIf numTracto = "10" Then
            monto = VCertificados.CertificadosTextboxTracto10.Text
        End If

        If (cedula = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (tracto1 = "" Or tracto2 = "" Or tracto3 = "" Or tracto4 = "" Or tracto5 = "" Or tracto6 = "" Or tracto7 = "" Or tracto8 = "" Or tracto9 = "" Or tracto10) Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        Dim montoEntero As Integer = Convert.ToInt32(monto)

        If (montoEntero > montoMaxTracto) Then
            MessageBox.Show(variablesGlobales.errorMontoCertificados, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        If ((montoEntero + periodo) > montoMaxPeriodo) Then
            MessageBox.Show(variablesGlobales.errorMontoCertificadosMayorMil, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        If validarFecha(fecha) Then
            MessageBox.Show(variablesGlobales.errorFechaLimiteMenorActual, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Else

            editarTracto(numTracto)
            BD.ConectarBD()
            periodo = BD.sumarTractosEnCertificadosBD(cedula)
            BD.CerrarConexion()
            sumarTractosEnCertificados(periodo, cedula)
        End If
    End Sub

    Public Sub limpiar()
        VCertificados.CertificadosTextboxCedulaNumAsociado.Text = ""
        VCertificados.CertificadosTextboxNombre.Text = ""

        VCertificados.CertificadosTextboxTracto1.Text = ""
        VCertificados.CertificadosTextboxTracto2.Text = ""
        VCertificados.CertificadosTextboxTracto3.Text = ""
        VCertificados.CertificadosTextboxTracto4.Text = ""
        VCertificados.CertificadosTextboxTracto5.Text = ""
        VCertificados.CertificadosTextboxTracto6.Text = ""
        VCertificados.CertificadosTextboxTracto7.Text = ""
        VCertificados.CertificadosTextboxTracto8.Text = ""
        VCertificados.CertificadosTextboxTracto9.Text = ""
        VCertificados.CertificadosTextboxTracto10.Text = ""
        VCertificados.CertificadosTextboxAcumAnterior.Text = ""
        VCertificados.CertificadosTextboxTotalPeriodo.Text = ""
        VCertificados.CertificadosTextboxNumAsociado.Text = ""
        VCertificados.CertificadosTextboxCed.Text = ""
    End Sub

    'Genera un reporte con los datos de aportaciones actuales de un socio
    Public Sub comprobante()
        Dim cedulaOnumAsociado As String = VCertificados.CertificadosTextboxCedulaNumAsociado.Text
        Dim nombre As String = VCertificados.CertificadosTextboxNombre.Text

        Dim tracto1 As String = VCertificados.CertificadosTextboxTracto1.Text
        Dim tracto2 As String = VCertificados.CertificadosTextboxTracto2.Text
        Dim tracto3 As String = VCertificados.CertificadosTextboxTracto3.Text
        Dim tracto4 As String = VCertificados.CertificadosTextboxTracto4.Text
        Dim tracto5 As String = VCertificados.CertificadosTextboxTracto5.Text
        Dim tracto6 As String = VCertificados.CertificadosTextboxTracto6.Text
        Dim tracto7 As String = VCertificados.CertificadosTextboxTracto7.Text
        Dim tracto8 As String = VCertificados.CertificadosTextboxTracto8.Text
        Dim tracto9 As String = VCertificados.CertificadosTextboxTracto9.Text
        Dim tracto10 As String = VCertificados.CertificadosTextboxTracto10.Text
        Dim acum As String = VCertificados.CertificadosTextboxAcumAnterior.Text
        Dim total As String = VCertificados.CertificadosTextboxTotalPeriodo.Text


        If (cedulaOnumAsociado = "" Or nombre = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                If Not Directory.Exists(variablesGlobales.folderPath) Then
                    Directory.CreateDirectory(variablesGlobales.folderPath)
                End If

                Dim pdfDoc As New Document()
                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "comprobanteCertificados.pdf", FileMode.Create))

                pdfDoc.Open()

                encabezado.consultarDatos()
                encabezado.encabezado(pdfWrite, pdfDoc)
                Dim FontStype = FontFactory.GetFont("Arial", 9, Font.NORMAL)

                pdfDoc.Add(New Paragraph("                                                                 Comprobante de Aportaciones ", FontStype))
                pdfDoc.Add(New Paragraph(""))
                pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
                pdfDoc.Add(New Paragraph(" "))
                pdfDoc.Add(New Paragraph(" "))

                pdfDoc.Add(New Paragraph("Cédula o Num de Asociado:   " + cedulaOnumAsociado, FontStype))
                pdfDoc.Add(New Paragraph("Nombre completo:  " + nombre, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #1:  " + tracto1, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #2:  " + tracto2, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #3:  " + tracto3, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #4:  " + tracto4, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #5:  " + tracto5, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #6:  " + tracto6, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #7:  " + tracto7, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #8:  " + tracto8, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #9:  " + tracto9, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #10:  " + tracto10, FontStype))
                pdfDoc.Add(New Paragraph("Total del Periodo:  " + total, FontStype))
                pdfDoc.Add(New Paragraph("Acumulado Anterior:  " + acum, FontStype))

                pdfDoc.Close()

                MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Print.Show()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If

    End Sub

    ' Recibo o comprobante de certificados nuevo
    Public Sub imprimirComprobanteCertificadosNew()

        Dim cedulaOnumAsociado As String = VCertificados.CertificadosTextboxCedulaNumAsociado.Text
        Dim nombre As String = VCertificados.CertificadosTextboxNombre.Text
        Dim numAsociado As String = VCertificados.CertificadosTextboxNumAsociado.Text
        Dim tracto1 As String = VCertificados.CertificadosTextboxTracto1.Text
        Dim tracto2 As String = VCertificados.CertificadosTextboxTracto2.Text
        Dim tracto3 As String = VCertificados.CertificadosTextboxTracto3.Text
        Dim tracto4 As String = VCertificados.CertificadosTextboxTracto4.Text
        Dim tracto5 As String = VCertificados.CertificadosTextboxTracto5.Text
        Dim tracto6 As String = VCertificados.CertificadosTextboxTracto6.Text
        Dim tracto7 As String = VCertificados.CertificadosTextboxTracto7.Text
        Dim tracto8 As String = VCertificados.CertificadosTextboxTracto8.Text
        Dim tracto9 As String = VCertificados.CertificadosTextboxTracto9.Text
        Dim tracto10 As String = VCertificados.CertificadosTextboxTracto10.Text
        Dim acum As String = VCertificados.CertificadosTextboxAcumAnterior.Text
        Dim total As String = VCertificados.CertificadosTextboxTotalPeriodo.Text

        If (cedulaOnumAsociado = "" Or nombre = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        Else
            Try
                BD.ConectarBD()
                variablesGlobales.numReciboCertificados = Convert.ToInt32(BD.obtenerReciboXTipo("certificado").Item(0))

                If Not Directory.Exists(variablesGlobales.folderPath) Then
                    Directory.CreateDirectory(variablesGlobales.folderPath)
                End If

                Dim pdfDoc As New Document()
                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.pathReporteCertificadosRecibo, FileMode.Create))

                pdfDoc.Open()
                encabezado.consultarDatos()
                encabezado.encabezado(pdfWrite, pdfDoc)

                '/////// Encabezado //////////
                Dim FontStype3 = FontFactory.GetFont("Arial", 8, Font.BOLD, BaseColor.BLACK)
                pdfDoc.Add(New Paragraph("                                                                                                        N° Recibo C" + Convert.ToString(variablesGlobales.numReciboCertificados), FontStype3))
                pdfDoc.Add(New Paragraph(" "))

                Dim FontStype = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.WHITE)

                'para el encabezado
                Dim table2 As PdfPTable = New PdfPTable(3)

                'para certificados 1-5
                Dim table As PdfPTable = New PdfPTable(5)

                'para certificados 6-10
                Dim table3 As PdfPTable = New PdfPTable(5)

                Dim descripcionR As PdfPCell = New PdfPCell(New Phrase("Descripción: ", FontStype))
                descripcionR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                descripcionR.Colspan = 1
                descripcionR.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

                Dim numAsociadoR As PdfPCell = New PdfPCell(New Phrase("# Asociado: ", FontStype))
                numAsociadoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                numAsociadoR.Colspan = 1
                numAsociadoR.HorizontalAlignment = 1

                Dim nombreR As PdfPCell = New PdfPCell(New Phrase("Nombre Completo: ", FontStype))
                nombreR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                nombreR.Colspan = 2
                nombreR.HorizontalAlignment = 1

                Dim total1R As PdfPCell = New PdfPCell(New Phrase("1° Tracto: ", FontStype))
                total1R.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                total1R.Colspan = 1
                total1R.HorizontalAlignment = 1

                Dim total2R As PdfPCell = New PdfPCell(New Phrase("2° Tracto: ", FontStype))
                total2R.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                total2R.Colspan = 1
                total2R.HorizontalAlignment = 1

                Dim total3R As PdfPCell = New PdfPCell(New Phrase("3° Tracto: ", FontStype))
                total3R.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                total3R.Colspan = 1
                total3R.HorizontalAlignment = 1

                Dim total4R As PdfPCell = New PdfPCell(New Phrase("4° Tracto: ", FontStype))
                total4R.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                total4R.Colspan = 1
                total4R.HorizontalAlignment = 1

                Dim total5R As PdfPCell = New PdfPCell(New Phrase("5° Tracto: ", FontStype))
                total5R.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                total5R.Colspan = 1
                total5R.HorizontalAlignment = 1

                Dim total6R As PdfPCell = New PdfPCell(New Phrase("6° Tracto: ", FontStype))
                total6R.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                total6R.Colspan = 1
                total6R.HorizontalAlignment = 1

                Dim total7R As PdfPCell = New PdfPCell(New Phrase("7° Tracto: ", FontStype))
                total7R.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                total7R.Colspan = 1
                total7R.HorizontalAlignment = 1

                Dim total8R As PdfPCell = New PdfPCell(New Phrase("8° Tracto: ", FontStype))
                total8R.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                total8R.Colspan = 1
                total8R.HorizontalAlignment = 1

                Dim total9R As PdfPCell = New PdfPCell(New Phrase("9° Tracto: ", FontStype))
                total9R.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                total9R.Colspan = 1
                total9R.HorizontalAlignment = 1

                Dim total10R As PdfPCell = New PdfPCell(New Phrase("10° Tracto: ", FontStype))
                total10R.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                total10R.Colspan = 1
                total10R.HorizontalAlignment = 1


                Dim FontStype2 = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.BLACK)

                Dim descripcionT As PdfPCell = New PdfPCell(New Phrase("Recibo de Certificados", FontStype2))
                descripcionT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                descripcionT.Colspan = 1
                descripcionT.HorizontalAlignment = 1
                'descripcionT.FixedHeight = 50.0F

                Dim numAsociadoT As PdfPCell = New PdfPCell(New Phrase(numAsociado, FontStype2))
                numAsociadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                numAsociadoT.Colspan = 1
                numAsociadoT.HorizontalAlignment = 1

                Dim nombreTotal As String = nombre
                Dim nombreT As PdfPCell = New PdfPCell(New Phrase(nombreTotal, FontStype2))
                nombreT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                nombreT.Colspan = 2
                nombreT.HorizontalAlignment = 1

                Dim subTotalInt1 As Integer = Convert.ToInt32(tracto1)
                Dim totalT1 As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt1.ToString("N"), FontStype2))
                totalT1.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT1.Colspan = 1
                totalT1.HorizontalAlignment = 1

                Dim subTotalInt2 As Integer = Convert.ToInt32(tracto2)
                Dim totalT2 As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt2.ToString("N"), FontStype2))
                totalT2.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT2.Colspan = 1
                totalT2.HorizontalAlignment = 1

                Dim subTotalInt3 As Integer = Convert.ToInt32(tracto3)
                Dim totalT3 As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt3.ToString("N"), FontStype2))
                totalT3.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT3.Colspan = 1
                totalT3.HorizontalAlignment = 1

                Dim subTotalInt4 As Integer = Convert.ToInt32(tracto4)
                Dim totalT4 As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt4.ToString("N"), FontStype2))
                totalT4.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT4.Colspan = 1
                totalT4.HorizontalAlignment = 1

                Dim subTotalInt5 As Integer = Convert.ToInt32(tracto5)
                Dim totalT5 As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt5.ToString("N"), FontStype2))
                totalT5.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT5.Colspan = 1
                totalT5.HorizontalAlignment = 1

                Dim subTotalInt6 As Integer = Convert.ToInt32(tracto6)
                Dim totalT6 As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt6.ToString("N"), FontStype2))
                totalT6.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT6.Colspan = 1
                totalT6.HorizontalAlignment = 1

                Dim subTotalInt7 As Integer = Convert.ToInt32(tracto7)
                Dim totalT7 As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt7.ToString("N"), FontStype2))
                totalT7.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT7.Colspan = 1
                totalT7.HorizontalAlignment = 1

                Dim subTotalInt8 As Integer = Convert.ToInt32(tracto8)
                Dim totalT8 As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt8.ToString("N"), FontStype2))
                totalT8.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT8.Colspan = 1
                totalT8.HorizontalAlignment = 1

                Dim subTotalInt9 As Integer = Convert.ToInt32(tracto9)
                Dim totalT9 As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt9.ToString("N"), FontStype2))
                totalT9.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT9.Colspan = 1
                totalT9.HorizontalAlignment = 1

                Dim subTotalInt10 As Integer = Convert.ToInt32(tracto10)
                Dim totalT10 As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt10.ToString("N"), FontStype2))
                totalT10.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT10.Colspan = 1
                totalT10.HorizontalAlignment = 1

                table2.AddCell(descripcionR)
                table2.AddCell(numAsociadoR)
                table2.AddCell(nombreR)

                table2.AddCell(descripcionT)
                table2.AddCell(numAsociadoT)
                table2.AddCell(nombreT)

                table.AddCell(total1R)
                table.AddCell(total2R)
                table.AddCell(total3R)
                table.AddCell(total4R)
                table.AddCell(total5R)

                table3.AddCell(total6R)
                table3.AddCell(total7R)
                table3.AddCell(total8R)
                table3.AddCell(total9R)
                table3.AddCell(total10R)

                table.AddCell(totalT1)
                table.AddCell(totalT2)
                table.AddCell(totalT3)
                table.AddCell(totalT4)
                table.AddCell(totalT5)

                table3.AddCell(totalT6)
                table3.AddCell(totalT7)
                table3.AddCell(totalT8)
                table3.AddCell(totalT9)
                table3.AddCell(totalT10)

                'total cancelado hoy al seleccionar los checkbox's
                Dim totalCancelado As Integer = 0

                If VCertificados.CheckBox1.Checked = True Then
                    totalCancelado = totalCancelado + Convert.ToInt32(VCertificados.CertificadosTextboxTracto1.Text)
                End If
                If VCertificados.CheckBox2.Checked = True Then
                    totalCancelado = totalCancelado + Convert.ToInt32(VCertificados.CertificadosTextboxTracto2.Text)
                End If
                If VCertificados.CheckBox3.Checked = True Then
                    totalCancelado = totalCancelado + Convert.ToInt32(VCertificados.CertificadosTextboxTracto3.Text)
                End If
                If VCertificados.CheckBox4.Checked = True Then
                    totalCancelado = totalCancelado + Convert.ToInt32(VCertificados.CertificadosTextboxTracto4.Text)
                End If
                If VCertificados.CheckBox5.Checked = True Then
                    totalCancelado = totalCancelado + Convert.ToInt32(VCertificados.CertificadosTextboxTracto5.Text)
                End If
                If VCertificados.CheckBox6.Checked = True Then
                    totalCancelado = totalCancelado + Convert.ToInt32(VCertificados.CertificadosTextboxTracto6.Text)
                End If
                If VCertificados.CheckBox7.Checked = True Then
                    totalCancelado = totalCancelado + Convert.ToInt32(VCertificados.CertificadosTextboxTracto7.Text)
                End If
                If VCertificados.CheckBox8.Checked = True Then
                    totalCancelado = totalCancelado + Convert.ToInt32(VCertificados.CertificadosTextboxTracto8.Text)
                End If
                If VCertificados.CheckBox9.Checked = True Then
                    totalCancelado = totalCancelado + Convert.ToInt32(VCertificados.CertificadosTextboxTracto9.Text)
                End If
                If VCertificados.CheckBox10.Checked = True Then
                    totalCancelado = totalCancelado + Convert.ToInt32(VCertificados.CertificadosTextboxTracto10.Text)
                End If



                'Agrega todos los valores consultados al documento
                pdfDoc.Add(table2)
                'pdfDoc.Add(New Paragraph(" "))
                'pdfDoc.Add(New Paragraph("                        Información de los certificados pagados a la fecha", FontStype3))
                pdfDoc.Add(New Paragraph(" "))
                pdfDoc.Add(table)
                'pdfDoc.Add(New Paragraph(" "))
                pdfDoc.Add(table3)

                pdfDoc.Add(New Paragraph(" "))
                pdfDoc.Add(New Paragraph("                        Acumulado: ¢ " + acum.ToString, FontStype3))
                pdfDoc.Add(New Paragraph("                        Total del Periodo: ¢ " + total.ToString, FontStype3))
                pdfDoc.Add(New Paragraph("                        Total Cancelado Hoy: ¢ " + totalCancelado.ToString, FontStype3))

                'pdfDoc.Add(New Paragraph(" "))
                'pdfDoc.Add(New Paragraph(" "))
                pdfDoc.Add(New Paragraph(" "))


                pdfDoc.Add(New Paragraph("                        Firma del Asociado: _________________________________________", FontStype3))
                pdfDoc.Add(New Paragraph(" "))

                pdfDoc.Close()


                'Incrementa el num recibo ingreso en la BD
                BD.actualizarReciboXTipo("certificado", variablesGlobales.numReciboCertificados + 1)

                MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Print.Show()
                Print.abrirReporte(variablesGlobales.pathReporteCertificadosRecibo)
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
                MessageBox.Show(variablesGlobales.favorCerrarAdobeReader)
            End Try
        End If
    End Sub



    'Genera un reporte de los mororos'
    Public Sub generarReporteMorosidadAsociadosActivos()

        If VReporteMorosidad.TextBoxMorosidad.Text = "" Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        'total del periodo actual a consultar para verificar si es o no moroso
        Dim periodoAConsultar As Integer = Integer.Parse(VReporteMorosidad.TextBoxMorosidad.Text)


        Try
            Dim valores As List(Of SocioClase)
            BD.ConectarBD()
            'socios activos Total (columna de CERTIFICADOS)
            valores = BD.obtenerDatosReporteDeSociosActivosPeriodo("Activos")
            BD.CerrarConexion()



            'MsgBox("1...")


            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)



            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.pathReporteCertificadosMorosidad, FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)

            Dim table As PdfPTable = New PdfPTable(6)

            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            Dim intTblWidth() As Integer = {7, 12, 12, 10, 8, 8}
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

            Dim nivelR As PdfPCell = New PdfPCell(New Phrase("Nivel", FontStype))
            nivelR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            nivelR.Colspan = 1
            nivelR.HorizontalAlignment = 1

            Dim acumR As PdfPCell = New PdfPCell(New Phrase("Acum. Anterior.", FontStype))
            acumR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            acumR.Colspan = 1
            acumR.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

            Dim pagadoR As PdfPCell = New PdfPCell(New Phrase("Total Pagado", FontStype))
            pagadoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            pagadoR.Colspan = 1
            pagadoR.HorizontalAlignment = 1


            ' PARA AGREGAR INGRESOS Y GASTOS EN UNA PAGINA
            Dim FontEncabezadoFechas = FontFactory.GetFont("Arial", 7, Font.NORMAL)
            '/////// Encabezado //////////
            pdfDoc.Add(New Paragraph("                                                                                             Reporte de los Asociados que han pagado menos de ¢ " + VReporteMorosidad.TextBoxMorosidad.Text + " en el Periodo", FontEncabezadoFechas))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))


            table.AddCell(numAsociadoR)
            table.AddCell(nombreR)
            table.AddCell(nivelR)
            table.AddCell(acumR)
            table.AddCell(pagadoR)



            Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)

            Dim contador As Integer = 0
            Dim conta As Integer = 0

            '  MsgBox("valores.count es " + valores.Count.ToString)


            While contador < valores.Count
                If conta = 48 Then
                    pdfDoc.Add(table)
                    pdfDoc.NewPage()
                    encabezado.encabezado(pdfWrite, pdfDoc)
                    table.DeleteBodyRows()

                    conta = 0
                End If
                'conta = conta + 1

                Dim cedula As String = valores(contador).cedula

                'Aportaciones o Certificados - Acum
                Dim totalAportaciones As List(Of String) = socios.obtenerCertificadoXSocioAcumAnterior(cedula)

                'Subtotal X Socio de suma de acum + periodo (total)
                'Dim subTotalAportacionesXSocio As Double = Integer.Parse(totalAportacionesAcum.Item(0)) + Integer.Parse(totalAportacionesTotal.Item(0))

                Dim periodoXAsociado As Integer = Integer.Parse(totalAportaciones.Item(1))

                'MsgBox("User is : " + valores(contador).nombre)

                If (periodoXAsociado < periodoAConsultar) Then
                    ' MsgBox("COUNT IS : " + contador.ToString + "  " + valores(contador).nombre + " esta moroso, periodo total pagado del usuario es : " + periodoXAsociado.ToString)
                    Dim numAsociadoT As PdfPCell = New PdfPCell(New Phrase(valores(contador).numAsoc, FontStype2))
                    numAsociadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    numAsociadoT.Colspan = 1
                    numAsociadoT.HorizontalAlignment = 1

                    Dim nombreTotal As String = valores(contador).nombre + " " + valores(contador).primerApellido + " " + valores(contador).segundoApellido
                    Dim nombreT As PdfPCell = New PdfPCell(New Phrase(nombreTotal, FontStype2))
                    nombreT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    nombreT.Colspan = 2
                    nombreT.HorizontalAlignment = 1

                    Dim seccionT As PdfPCell = New PdfPCell(New Phrase(valores(contador).seccion, FontStype2))
                    seccionT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    seccionT.Colspan = 1
                    seccionT.HorizontalAlignment = 1

                    Dim acumT As PdfPCell = New PdfPCell(New Phrase(totalAportaciones.Item(0), FontStype2))
                    acumT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    acumT.Colspan = 1
                    acumT.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

                    Dim periodoT As PdfPCell = New PdfPCell(New Phrase(periodoXAsociado, FontStype2))
                    periodoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    periodoT.Colspan = 1
                    periodoT.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right


                    table.AddCell(numAsociadoT)
                    table.AddCell(nombreT)
                    table.AddCell(seccionT)
                    table.AddCell(acumT)
                    table.AddCell(periodoT)

                    conta = conta + 1
                End If


                ' If (valores(contador).estado.Equals("Activo")) Then
                'table.AddCell(fechaRetiroNula)
                'Else
                'table.AddCell(fechaRetiroT)
                'End If

                contador = contador + 1

            End While


            pdfDoc.Add(table)

            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Print.Show()
            Print.abrirReporte(variablesGlobales.pathReporteCertificadosMorosidad)

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            MessageBox.Show(variablesGlobales.favorCerrarAdobeReader)
        End Try
    End Sub


    'Genera un reporte de los pagos al dia'
    Public Sub generarReportePagosAldia()

        If VReportePAagosAlDia.TextBoxPagosAlDia.Text = "" Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        'total del periodo actual a consultar para verificar si es o no moroso
        Dim periodoAConsultar As Integer = Integer.Parse(VReportePAagosAlDia.TextBoxPagosAlDia.Text)


        Try
            Dim valores As List(Of SocioClase)
            BD.ConectarBD()
            valores = BD.obtenerDatosReporteDeSociosActivosPeriodo("Activos")
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)

            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.pathReporteCertificadosPagosAldia, FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)

            Dim table As PdfPTable = New PdfPTable(6)

            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            Dim intTblWidth() As Integer = {7, 12, 12, 10, 8, 8}
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

            Dim nivelR As PdfPCell = New PdfPCell(New Phrase("Nivel", FontStype))
            nivelR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            nivelR.Colspan = 1
            nivelR.HorizontalAlignment = 1

            Dim acumR As PdfPCell = New PdfPCell(New Phrase("Acum. Anterior.", FontStype))
            acumR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            acumR.Colspan = 1
            acumR.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

            Dim pagadoR As PdfPCell = New PdfPCell(New Phrase("Total Pagado", FontStype))
            pagadoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            pagadoR.Colspan = 1
            pagadoR.HorizontalAlignment = 1


            ' PARA AGREGAR INGRESOS Y GASTOS EN UNA PAGINA
            Dim FontEncabezadoFechas = FontFactory.GetFont("Arial", 7, Font.NORMAL)
            '/////// Encabezado //////////
            pdfDoc.Add(New Paragraph("                                                                                             Reporte de los Asociados que han pagado mayor o igual a ¢ " + VReportePAagosAlDia.TextBoxPagosAlDia.Text + " en el Periodo", FontEncabezadoFechas))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))


            table.AddCell(numAsociadoR)
            table.AddCell(nombreR)
            table.AddCell(nivelR)
            table.AddCell(acumR)
            table.AddCell(pagadoR)



            Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)

            Dim contador As Integer = 0
            Dim conta As Integer = 0

            While contador < valores.Count
                If conta = 45 Then
                    pdfDoc.Add(table)
                    pdfDoc.NewPage()
                    encabezado.encabezado(pdfWrite, pdfDoc)
                    table.DeleteBodyRows()

                    conta = 0
                End If
                'conta = conta + 1

                Dim cedula As String = valores(contador).cedula

                Dim totalAportaciones As List(Of String) = socios.obtenerCertificadoXSocioAcumAnterior(cedula)

                Dim periodoXAsociado As Integer = Integer.Parse(totalAportaciones.Item(1))

                If (periodoXAsociado >= periodoAConsultar) Then

                    Dim numAsociadoT As PdfPCell = New PdfPCell(New Phrase(valores(contador).numAsoc, FontStype2))
                    numAsociadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    numAsociadoT.Colspan = 1
                    numAsociadoT.HorizontalAlignment = 1

                    Dim nombreTotal As String = valores(contador).nombre + " " + valores(contador).primerApellido + " " + valores(contador).segundoApellido
                    Dim nombreT As PdfPCell = New PdfPCell(New Phrase(nombreTotal, FontStype2))
                    nombreT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    nombreT.Colspan = 2
                    nombreT.HorizontalAlignment = 1

                    Dim seccionT As PdfPCell = New PdfPCell(New Phrase(valores(contador).seccion, FontStype2))
                    seccionT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    seccionT.Colspan = 1
                    seccionT.HorizontalAlignment = 1

                    Dim acumT As PdfPCell = New PdfPCell(New Phrase(totalAportaciones.Item(0), FontStype2))
                    acumT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    acumT.Colspan = 1
                    acumT.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

                    Dim periodoT As PdfPCell = New PdfPCell(New Phrase(periodoXAsociado, FontStype2))
                    periodoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                    periodoT.Colspan = 1
                    periodoT.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right


                    table.AddCell(numAsociadoT)
                    table.AddCell(nombreT)
                    table.AddCell(seccionT)
                    table.AddCell(acumT)
                    table.AddCell(periodoT)

                    conta = conta + 1


                End If

                contador = contador + 1

            End While


            pdfDoc.Add(table)

            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Print.Show()
            Print.abrirReporte(variablesGlobales.pathReporteCertificadosPagosAldia)

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            MessageBox.Show(variablesGlobales.favorCerrarAdobeReader)
        End Try
    End Sub


    'Genera un reporte de los todos los pagos realizados por los socios'
    Public Sub generarReporteTodosLosPAgos()
        If VReporteTodosLosPagos.TextBoxTodosLosPagos.Text = "" Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If
        'total del periodo actual a consultar para verificar si es o no moroso
        Dim periodoAConsultar As Integer = Integer.Parse(VReporteTodosLosPagos.TextBoxTodosLosPagos.Text)
        Try
            Dim valores As List(Of SocioClase)
            BD.ConectarBD()
            valores = BD.obtenerDatosReporteDeSociosActivosPeriodo("Activos")
            BD.CerrarConexion()
            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If
            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.pathReporteCertificadosTodosLosPagos, FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)
            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)
            Dim table As PdfPTable = New PdfPTable(6)
            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            Dim intTblWidth() As Integer = {7, 12, 12, 10, 8, 8}
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
            Dim nivelR As PdfPCell = New PdfPCell(New Phrase("Nivel", FontStype))
            nivelR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            nivelR.Colspan = 1
            nivelR.HorizontalAlignment = 1
            Dim acumR As PdfPCell = New PdfPCell(New Phrase("Acum. Anterior.", FontStype))
            acumR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            acumR.Colspan = 1
            acumR.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right
            Dim pagadoR As PdfPCell = New PdfPCell(New Phrase("Total Pagado", FontStype))
            pagadoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            pagadoR.Colspan = 1
            pagadoR.HorizontalAlignment = 1
            ' PARA AGREGAR INGRESOS Y GASTOS EN UNA PAGINA
            Dim FontEncabezadoFechas = FontFactory.GetFont("Arial", 7, Font.NORMAL)
            '/////// Encabezado //////////
            pdfDoc.Add(New Paragraph("                                                                        Reporte de los Asociados que han o no han pagado un monto mayor o igual a ¢ " + VReporteTodosLosPagos.TextBoxTodosLosPagos.Text + " en el Periodo", FontEncabezadoFechas))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
            table.AddCell(numAsociadoR)
            table.AddCell(nombreR)
            table.AddCell(nivelR)
            table.AddCell(acumR)
            table.AddCell(pagadoR)
            Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)
            Dim contador As Integer = 0
            Dim conta As Integer = 0
            While contador < valores.Count
                If conta = 48 Then
                    pdfDoc.Add(table)
                    pdfDoc.NewPage()
                    encabezado.encabezado(pdfWrite, pdfDoc)
                    table.DeleteBodyRows()
                    conta = 0
                End If
                conta = conta + 1
                Dim cedula As String = valores(contador).cedula
                Dim totalAportaciones As List(Of String) = socios.obtenerCertificadoXSocioAcumAnterior(cedula)
                Dim periodoXAsociado As Integer = Integer.Parse(totalAportaciones.Item(1))

                Dim numAsociadoT As PdfPCell = New PdfPCell(New Phrase(valores(contador).numAsoc, FontStype2))
                numAsociadoT.Colspan = 1
                numAsociadoT.HorizontalAlignment = 1
                Dim nombreTotal As String = valores(contador).nombre + " " + valores(contador).primerApellido + " " + valores(contador).segundoApellido

                Dim nombreT As PdfPCell = New PdfPCell(New Phrase(nombreTotal, FontStype2))
                nombreT.Colspan = 2
                nombreT.HorizontalAlignment = 1

                Dim seccionT As PdfPCell = New PdfPCell(New Phrase(valores(contador).seccion, FontStype2))
                seccionT.Colspan = 1
                seccionT.HorizontalAlignment = 1

                Dim acumT As PdfPCell = New PdfPCell(New Phrase(totalAportaciones.Item(0), FontStype2))
                acumT.Colspan = 1
                acumT.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

                Dim periodoT As PdfPCell = New PdfPCell(New Phrase(periodoXAsociado, FontStype2))
                periodoT.Colspan = 1
                periodoT.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

                If (periodoXAsociado >= periodoAConsultar) Then
                    periodoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorVerdePositivo))
                    acumT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorVerdePositivo))
                    seccionT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorVerdePositivo))
                    numAsociadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorVerdePositivo))
                    nombreT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorVerdePositivo))
                Else
                    periodoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorRojoNegativo))
                    acumT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorRojoNegativo))
                    seccionT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorRojoNegativo))
                    numAsociadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorRojoNegativo))
                    nombreT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorRojoNegativo))
                End If

                table.AddCell(numAsociadoT)
                table.AddCell(nombreT)
                table.AddCell(seccionT)
                table.AddCell(acumT)
                table.AddCell(periodoT)

                contador = contador + 1
            End While
            pdfDoc.Add(table)
            pdfDoc.Close()
            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Print.Show()
            Print.abrirReporte(variablesGlobales.pathReporteCertificadosTodosLosPagos)

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            MessageBox.Show(variablesGlobales.favorCerrarAdobeReader)
        End Try
    End Sub
End Class
