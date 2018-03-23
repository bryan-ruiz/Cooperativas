Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class GestionExcedentes

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim Reserva As Reservas = New Reservas


    Public Sub reporteCertificadosEnTransito(ByVal estado As String)
        Dim totalEntradas As Integer = 0
        Try
            Dim listaExcedenteEnTransito As List(Of String)
            BD.ConectarBD()
            listaExcedenteEnTransito = BD.seleccionarExcedenteTreansitoEnEstadoX(estado)
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)
            Dim nombreReporte As String = "excedentes_En_Transito.pdf"
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
            pdfDoc.Add(New Paragraph("                                                                                                       Reporte de Excedentes en Tránsito", FontStype3))
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

            Dim excedente As PdfPCell = New PdfPCell(New Phrase("Excedente", FontStype))
            excedente.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            excedente.Colspan = 1
            excedente.HorizontalAlignment = 1

            Dim estadoAsoc As PdfPCell = New PdfPCell(New Phrase("Estado", FontStype))
            estadoAsoc.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            estadoAsoc.Colspan = 1
            estadoAsoc.HorizontalAlignment = 1

            table.AddCell(numAsoc)
            table.AddCell(cedulaAsoc)
            table.AddCell(nombreComp)
            table.AddCell(excedente)
            table.AddCell(estadoAsoc)

            Dim contador As Integer = 0
            Dim conta As Integer = 0

            If listaExcedenteEnTransito.Count = 0 Then
                MessageBox.Show(variablesGlobales.reporteSinDatos & nombreReporte, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return
            End If

            While contador < listaExcedenteEnTransito.Count
                If conta = 50 Then
                    pdfDoc.Add(table)
                    pdfDoc.NewPage()
                    encabezado.encabezado(pdfWrite, pdfDoc)
                    table.DeleteBodyRows()
                    conta = 0
                End If

                conta = conta + 1

                Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)


                Dim numAsocOb As PdfPCell = New PdfPCell(New Phrase(listaExcedenteEnTransito(contador), FontStype2))
                numAsocOb.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                numAsocOb.Colspan = 1
                numAsocOb.HorizontalAlignment = 1
                contador += 1

                Dim cedulaAsocOb As PdfPCell = New PdfPCell(New Phrase(listaExcedenteEnTransito(contador), FontStype2))
                cedulaAsocOb.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                cedulaAsocOb.Colspan = 1
                cedulaAsocOb.HorizontalAlignment = 1
                contador += 1

                Dim nombreComObt As PdfPCell = New PdfPCell(New Phrase(listaExcedenteEnTransito(contador), FontStype2))
                nombreComObt.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                nombreComObt.Colspan = 1
                nombreComObt.HorizontalAlignment = 1
                contador += 1

                Dim acumuladoOb As PdfPCell = New PdfPCell(New Phrase(" ¢ " + listaExcedenteEnTransito(contador), FontStype2))
                acumuladoOb.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                acumuladoOb.Colspan = 1
                acumuladoOb.HorizontalAlignment = 1
                contador += 1

                Dim estadoOb As PdfPCell = New PdfPCell(New Phrase(listaExcedenteEnTransito(contador), FontStype2))
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


    Public Sub sumarAlAcumuladoLlamado()
        Dim valores, valorEnCertificado As Int32
        Dim cedulaNumAsociado As String = VGestionDeExcedentes.GestionExcTextboxCedulaNumAsociado.Text
        Dim excedenteDeUsuario As String = VGestionDeExcedentes.GestionExcTextboxExcCorrespondiente.Text
        If (cedulaNumAsociado = "" Or excedenteDeUsuario = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                Dim ubicacionEstado As String = "En Acumulado"
                Dim cantidad As Integer = Integer.Parse(excedenteDeUsuario)

                BD.ConectarBD()
                valores = BD.retirarExcedente(cedulaNumAsociado, ubicacionEstado)
                valorEnCertificado = BD.sumarAcumuladoAnterior(cedulaNumAsociado, cantidad)
                If valores <> 0 And valorEnCertificado <> 0 Then
                    MessageBox.Show(variablesGlobales.retiradoExcedenteExitoso, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(variablesGlobales.errorActualizandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                limpiar()
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
    End Sub

    'sumar excedentes de un usuario a reservas ediucacion social y bienestar social.
    Public Sub sumarAReservasLlamado()
        Dim valores, valorDeConsultaEducacion, valorConsultaBienestarSoc As Int32
        Dim cedulaNumAsociado As String = VGestionDeExcedentes.GestionExcTextboxCedulaNumAsociado.Text
        Dim excedenteDeUsuario As String = VGestionDeExcedentes.GestionExcTextboxExcCorrespondiente.Text
        If (cedulaNumAsociado = "" Or excedenteDeUsuario = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                Dim ubicacionEstado As String = "En Reservas"
                Dim cantidad As Integer = Integer.Parse(excedenteDeUsuario)
                Dim cincuentaPorciento As Integer = cantidad / 2

                BD.ConectarBD()
                valorConsultaBienestarSoc = Reserva.actualizarMontoEnBase(cincuentaPorciento, "bienestarSocial")
                valorDeConsultaEducacion = Reserva.actualizarMontoEnBase(cincuentaPorciento, "educacion")
                valores = BD.retirarExcedente(cedulaNumAsociado, ubicacionEstado)
                If valores <> 0 And valorDeConsultaEducacion <> 0 And valorConsultaBienestarSoc <> 0 Then
                    MessageBox.Show(variablesGlobales.retiradoExcedenteExitoso, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(variablesGlobales.errorActualizandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                limpiar()
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
    End Sub



    'Retirar excedentes de un usuario
    Public Sub retirarExcedentesLlamado()
        Dim valores As Int32
        Dim cedulaNumAsociado As String = VGestionDeExcedentes.GestionExcTextboxCedulaNumAsociado.Text
        If (cedulaNumAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                Dim ubicacionEstado As String = "Retirado"
                valores = BD.retirarExcedente(cedulaNumAsociado, ubicacionEstado)
                If valores <> 0 Then
                    MessageBox.Show(variablesGlobales.retiradoExcedenteExitoso, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(variablesGlobales.errorActualizandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                limpiar()
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
    End Sub

    'consulta un asociado por ced o numAsociado en la tabla de Excedentes en Tránsito
    Public Sub consultar()

        Dim valores As List(Of String)

        'Textfield para consultar por ced o num asociado
        Dim cedulaNumAsociado As String = VGestionDeExcedentes.GestionExcTextboxCedulaNumAsociado.Text

        If (cedulaNumAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
        Else
            Try
                BD.ConectarBD()

                valores = BD.consultarAsociadoCedOrNumAsociadoEnTablaExcedenteEnTransito(cedulaNumAsociado)

                If valores.Count <> 0 Then

                    VGestionDeExcedentes.GestionExcTextboxNumAsociado.Text = valores.Item(1)
                    VGestionDeExcedentes.GestionExcTextboxCed.Text = valores.Item(2)
                    VGestionDeExcedentes.GestionExcTextboxNombre.Text = valores.Item(3) + " " + valores.Item(4) + " " + valores.Item(5)
                    VGestionDeExcedentes.GestionExcTextboxExcCorrespondiente.Text = valores.Item(6)
                    VGestionDeExcedentes.GestionExcTextboxStatus.Text = valores.Item(7)

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
        VGestionDeExcedentes.GestionExcTextboxCedulaNumAsociado.Text = ""
        VGestionDeExcedentes.GestionExcTextboxNumAsociado.Text = ""
        VGestionDeExcedentes.GestionExcTextboxCed.Text = ""
        VGestionDeExcedentes.GestionExcTextboxNombre.Text = ""
        VGestionDeExcedentes.GestionExcTextboxExcCorrespondiente.Text = ""
        VGestionDeExcedentes.GestionExcTextboxStatus.Text = ""
    End Sub

End Class
