Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class GestionCertificados

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim Reserva As Reservas = New Reservas


    Public Sub reporteCertificadosEnTransito(ByVal estado As String)
        Dim totalEntradas As Integer = 0
        Try
            Dim listaCertificadosEnTransito As List(Of String)
            BD.ConectarBD()
            listaCertificadosEnTransito = BD.seleccionarcertificadoTreansitoEnEstadoX(estado)
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)
            Dim nombreReporte As String = "certificados_En_Transito.pdf"
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & nombreReporte, FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)

            Dim table As PdfPTable = New PdfPTable(5)

            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            Dim intTblWidth() As Integer = {3, 4, 10, 4, 4}
            table.SetWidths(intTblWidth)

            '/////// Titulo //////////
            Dim FontStype3 = FontFactory.GetFont("Arial", 8, Font.BOLD, BaseColor.BLACK)
            pdfDoc.Add(New Paragraph("                                                                                                           Reporte de Certificados en Tránsito", FontStype3))
            pdfDoc.Add(New Paragraph(" "))

            '' PARA ENCABEZADO DEL REPORTE - COLUMNAS

            Dim numAsoc As PdfPCell = New PdfPCell(New Phrase("Número de asociado", FontStype))
            numAsoc.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            numAsoc.Colspan = 1
            numAsoc.HorizontalAlignment = 1

            Dim cedulaAsoc As PdfPCell = New PdfPCell(New Phrase("Cédula", FontStype))
            cedulaAsoc.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            cedulaAsoc.Colspan = 1
            cedulaAsoc.HorizontalAlignment = 1

            Dim nombreComp As PdfPCell = New PdfPCell(New Phrase("Nombre completo", FontStype))
            nombreComp.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            nombreComp.Colspan = 1
            nombreComp.HorizontalAlignment = 1

            Dim acumulado As PdfPCell = New PdfPCell(New Phrase("Acumulado", FontStype))
            acumulado.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            acumulado.Colspan = 1
            acumulado.HorizontalAlignment = 1

            Dim estadoAsoc As PdfPCell = New PdfPCell(New Phrase("Estado", FontStype))
            estadoAsoc.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            estadoAsoc.Colspan = 1
            estadoAsoc.HorizontalAlignment = 1

            table.AddCell(numAsoc)
            table.AddCell(cedulaAsoc)
            table.AddCell(nombreComp)
            table.AddCell(acumulado)
            table.AddCell(estadoAsoc)

            Dim contador As Integer = 0
            Dim conta As Integer = 0

            If listaCertificadosEnTransito.Count = 0 Then
                MessageBox.Show(variablesGlobales.reporteSinDatos & nombreReporte, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return
            End If

            While contador < listaCertificadosEnTransito.Count
                If conta = 50 Then
                    pdfDoc.Add(table)
                    pdfDoc.NewPage()
                    encabezado.encabezado(pdfWrite, pdfDoc)
                    table.DeleteBodyRows()
                    conta = 0
                End If

                conta = conta + 1

                Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)


                Dim numAsocOb As PdfPCell = New PdfPCell(New Phrase(listaCertificadosEnTransito(contador), FontStype2))
                numAsocOb.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                numAsocOb.Colspan = 1
                numAsocOb.HorizontalAlignment = 1
                contador += 1

                Dim cedulaAsocOb As PdfPCell = New PdfPCell(New Phrase(listaCertificadosEnTransito(contador), FontStype2))
                cedulaAsocOb.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                cedulaAsocOb.Colspan = 1
                cedulaAsocOb.HorizontalAlignment = 1
                contador += 1

                Dim nombreComObt As PdfPCell = New PdfPCell(New Phrase(listaCertificadosEnTransito(contador), FontStype2))
                nombreComObt.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                nombreComObt.Colspan = 1
                nombreComObt.HorizontalAlignment = 1
                contador += 1

                Dim acumuladoOb As PdfPCell = New PdfPCell(New Phrase(" ¢ " + listaCertificadosEnTransito(contador), FontStype2))
                acumuladoOb.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                acumuladoOb.Colspan = 1
                acumuladoOb.HorizontalAlignment = 1
                contador += 1

                Dim estadoOb As PdfPCell = New PdfPCell(New Phrase(listaCertificadosEnTransito(contador), FontStype2))
                estadoOb.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                estadoOb.Colspan = 1
                estadoOb.HorizontalAlignment = 1
                contador = contador + 1

                table.AddCell(numAsocOb)
                table.AddCell(cedulaAsocOb)
                table.AddCell(nombreComObt)
                table.AddCell(acumuladoOb)
                table.AddCell(estadoOb)


            End While

            pdfDoc.Add(table)
            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & nombreReporte, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try
    End Sub



    Public Sub sumarEnReservasoCertLlamado()
        Dim valores, valoresCert, valorConsultaBienestarSoc, valorDeConsultaEducacion As Integer
        'Textfield para consultar por ced o num asociado
        Dim cedulaNumAsociado As String = VGestionDeCertificados.GestionCertificadoTextboxCed.Text
        Dim acumulado As String = VGestionDeCertificados.GestionCertificadoTextboxAcumuladoActual.Text
        Dim status As String = VGestionDeCertificados.GestionCertificadoTextboxStatus.Text

        If (cedulaNumAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (status <> "Pendiente") Then
            MessageBox.Show(variablesGlobales.mensajePendienteRequerido, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        Try
            BD.ConectarBD()
            valores = BD.retirarCertificadoEnTransito(cedulaNumAsociado, "En Reservas")
            valoresCert = BD.actualizarAcumuladoDeCertificado(cedulaNumAsociado, 0)

            Dim cantidad As Integer = Integer.Parse(acumulado)
            Dim cincuentaPorciento As Integer = cantidad / 2

            valorConsultaBienestarSoc = Reserva.actualizarMontoEnBase(cincuentaPorciento, "bienestarSocial")
            valorDeConsultaEducacion = Reserva.actualizarMontoEnBase(cincuentaPorciento, "educacion")

            If valores <> 0 And valoresCert <> 0 And valorDeConsultaEducacion <> 0 And valorConsultaBienestarSoc <> 0 Then
                MessageBox.Show(variablesGlobales.datosActualizadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try

        limpiar()
    End Sub

    Public Sub retirarAcumuladoCertLlamado()
        Dim valores, valoresCert As Integer
        'Textfield para consultar por ced o num asociado
        Dim cedulaNumAsociado As String = VGestionDeCertificados.GestionCertificadoTextboxCed.Text
        Dim status As String = VGestionDeCertificados.GestionCertificadoTextboxStatus.Text

        If (cedulaNumAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (status <> "Pendiente") Then
            MessageBox.Show(variablesGlobales.mensajePendienteRequerido, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        Try
            BD.ConectarBD()
            valores = BD.retirarCertificadoEnTransito(cedulaNumAsociado, "Retirado")
            valoresCert = BD.actualizarAcumuladoDeCertificado(cedulaNumAsociado, 0)

            If valores <> 0 And valoresCert <> 0 Then
                MessageBox.Show(variablesGlobales.datosActualizadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()

            VGestionDeCertificados.Hide()
            VGastos.Show()

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try

        limpiar()
    End Sub

    'consulta un asociado por ced o numAsociado en la tabla de Excedentes en Tránsito
    Public Sub consultar()

        Dim valores As List(Of String)

        'Textfield para consultar por ced o num asociado
        Dim cedulaNumAsociado As String = VGestionDeCertificados.GestionCertificadoTextboxCedulaNumAsociado.Text

        If (cedulaNumAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
        Else
            Try
                BD.ConectarBD()

                valores = BD.consultarAsociadoCedOrNumAsociadoEnTablaCertificadoEnTransito(cedulaNumAsociado)

                If valores.Count <> 0 Then

                    VGestionDeCertificados.GestionCertificadoTextboxNumAsociado.Text = valores.Item(1)
                    VGestionDeCertificados.GestionCertificadoTextboxCed.Text = valores.Item(2)
                    VGestionDeCertificados.GestionCertificadoTextboxNombreCompleto.Text = valores.Item(3) + " " + valores.Item(4) + " " + valores.Item(5)
                    VGestionDeCertificados.GestionCertificadoTextboxAcumuladoActual.Text = valores.Item(6)
                    VGestionDeCertificados.GestionCertificadoTextboxStatus.Text = valores.Item(7)

                Else
                    MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    limpiar()
                End If

                BD.CerrarConexion()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)

            End Try
        End If

    End Sub

    Public Sub limpiar()
        VGestionDeCertificados.GestionCertificadoTextboxCedulaNumAsociado.Text = ""
        VGestionDeCertificados.GestionCertificadoTextboxNumAsociado.Text = ""
        VGestionDeCertificados.GestionCertificadoTextboxCed.Text = ""
        VGestionDeCertificados.GestionCertificadoTextboxNombreCompleto.Text = ""
        VGestionDeCertificados.GestionCertificadoTextboxAcumuladoActual.Text = ""
        VGestionDeCertificados.GestionCertificadoTextboxStatus.Text = ""
    End Sub

End Class
