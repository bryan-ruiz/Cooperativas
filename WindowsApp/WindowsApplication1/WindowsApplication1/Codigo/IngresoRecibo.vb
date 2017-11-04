Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Globalization

Public Class IngresoRecibo

    Dim BD As ConexionBD = New ConexionBD
    Dim estado As Boolean = True
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales


    Public Sub calcularRecibo()
        Try
            Dim cantidad As Integer = Integer.Parse(VIngresosComprobante.TextBox_IngresosCantidadRE.Text)
            Dim precioUnitario As Integer = Integer.Parse(VIngresosComprobante.TextBox_IngresosPrecioUnitario.Text)

            VIngresosComprobante.TextBox_IngresosTotal.Text = cantidad * precioUnitario

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub


    Public Sub obtenerDatosSeleccionarCuentaRecibo()
        Dim valores As List(Of CuentaClase)
        Dim codCuenta As String = VIngresosComprobante.ComboBox_IngresosCodigCuentaRE.Text
        Try
            BD.ConectarBD()
            valores = BD.consultarCuentas()
            If valores.Count <> 0 Then
                estado = True
                VIngresosComprobante.ComboBox_IngresosCodigCuenta.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While valores.Count > contador
                    If valores(contador).tipo = "Ingreso" Then
                        VIngresosComprobante.ComboBox_IngresosCodigCuenta.Items.Add(valores(contador).codDescripcion)
                        conta += 1
                    End If
                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False
                    VIngresosComprobante.ComboBox_IngresosCodigCuenta.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False
                VIngresosComprobante.ComboBox_IngresosCodigCuenta.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
        End Try
    End Sub


    Public Sub limpiarRecibo()
        VIngresosComprobante.TextBox_IngresosFacturaRecibos.Text = ""
        gggg
    End Sub



    Public Sub generarReporteIngresosRecibo()

        Dim valores As Integer

        Dim factura As String = VIngresosComprobante.TextBox_IngresosFacturaRecibosRE.Text
        Dim cliente As String = VIngresosComprobante.TextBox_IngresosClienteRE.Text
        Dim descripcion As String = VIngresosComprobante.TextBox_IngresosDescripcionRE.Text
        Dim cantidad As String = VIngresosComprobante.TextBox_IngresosCantidadRE.Text
        Dim precioUnitario As String = VIngresosComprobante.TextBox_IngresosPrecioUnitarioRE.Text
        Dim total As String = VIngresosComprobante.TextBox_IngresosTotalRE.Text
        Dim codCuenta As String = VIngresosComprobante.ComboBox_IngresosCodigCuentaRE.Text

        If (factura = "" Or cliente = "" Or descripcion = "" Or cantidad = "" Or precioUnitario = "" Or total = "" Or codCuenta = "" Or estado = False) Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        Try

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reciboDeEntrada.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)


            '/////// Encabezado //////////
            Dim FontStype3 = FontFactory.GetFont("Arial", 8, Font.BOLD, BaseColor.BLACK)
            pdfDoc.Add(New Paragraph("                                                                                                        N° Recibo " + Convert.ToString(variablesGlobales.numReciboEntradas), FontStype3))
            pdfDoc.Add(New Paragraph(" "))

            Dim FontStype = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.WHITE)

            Dim table As PdfPTable = New PdfPTable(7)

            Dim descripcionR As PdfPCell = New PdfPCell(New Phrase("N° Factura: ", FontStype))
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

            Dim totalR As PdfPCell = New PdfPCell(New Phrase("Total: ", FontStype))
            totalR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            totalR.Colspan = 1
            totalR.HorizontalAlignment = 1


            Dim FontStype2 = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.BLACK)

            Dim descripcionT As PdfPCell = New PdfPCell(New Phrase("Recibo de matrícula", FontStype2))
            descripcionT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            descripcionT.Colspan = 1
            descripcionT.HorizontalAlignment = 1
            'descripcionT.FixedHeight = 50.0F

            Dim numAsociadoT As PdfPCell = New PdfPCell(New Phrase(numAsociado, FontStype2))
            numAsociadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            numAsociadoT.Colspan = 1
            numAsociadoT.HorizontalAlignment = 1

            Dim nombreTotal As String = nombre + " " + apellidoUno + " " + apellidoDos
            Dim nombreT As PdfPCell = New PdfPCell(New Phrase(nombreTotal, FontStype2))
            nombreT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            nombreT.Colspan = 2
            nombreT.HorizontalAlignment = 1

            Dim subTotalInt As Integer = Convert.ToInt32(cuota)
            Dim totalT As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt.ToString("N"), FontStype2))
            totalT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            totalT.Colspan = 1
            totalT.HorizontalAlignment = 1

            table.AddCell(descripcionR)
            table.AddCell(numAsociadoR)
            table.AddCell(nombreR)
            table.AddCell(totalR)

            table.AddCell(descripcionT)
            table.AddCell(numAsociadoT)
            table.AddCell(nombreT)
            table.AddCell(totalT)

            pdfDoc.Add(table)

            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))


            pdfDoc.Add(New Paragraph("                        Firma del Asociado: _________________________________________", FontStype3))
            pdfDoc.Add(New Paragraph(" "))


            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            variablesGlobales.numReciboEntradas = variablesGlobales.numReciboEntradas + 1

            Print.Show()

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
        End Try

    End Sub

End Class
