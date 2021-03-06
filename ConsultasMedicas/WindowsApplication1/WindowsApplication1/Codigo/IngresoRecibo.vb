﻿Imports iTextSharp.text
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
            Dim precioUnitario As Integer = Integer.Parse(VIngresosComprobante.TextBox_IngresosPrecioUnitarioRE.Text)

            VIngresosComprobante.TextBox_IngresosTotalRE.Text = cantidad * precioUnitario

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
                VIngresosComprobante.ComboBox_IngresosCodigCuentaRE.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While valores.Count > contador
                    If valores(contador).tipo = "Ingreso" Then
                        VIngresosComprobante.ComboBox_IngresosCodigCuentaRE.Items.Add(valores(contador).codDescripcion)
                        conta += 1
                    End If
                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False
                    VIngresosComprobante.ComboBox_IngresosCodigCuentaRE.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False
                VIngresosComprobante.ComboBox_IngresosCodigCuentaRE.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    'limpiar
    Public Sub limpiarRecibo()
        VIngresosComprobante.TextBox_IngresosFacturaRecibosRE.Text = ""
        VIngresosComprobante.TextBox_IngresosClienteRE.Text = ""
        VIngresosComprobante.TextBox_IngresosDescripcionRE.Text = ""
        VIngresosComprobante.TextBox_IngresosCantidadRE.Text = ""
        VIngresosComprobante.TextBox_IngresosPrecioUnitarioRE.Text = ""
        VIngresosComprobante.TextBox_IngresosTotalRE.Text = ""
    End Sub

    'REPORTE INGRESOS RECIBO
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
            BD.ConectarBD()
            variablesGlobales.numReciboEntradas = Convert.ToInt32(BD.obtenerReciboXTipo("ingreso").Item(0))

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reciboDeEntradas.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            '/////// Encabezado //////////
            Dim FontStype3 = FontFactory.GetFont("Arial", 8, Font.BOLD, BaseColor.BLACK)
            pdfDoc.Add(New Paragraph("                                                                                                        N° Recibo " + Convert.ToString(variablesGlobales.numReciboEntradas), FontStype3))
            pdfDoc.Add(New Paragraph(" "))

            Dim FontStype = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.WHITE)
            Dim table As PdfPTable = New PdfPTable(9)

            Dim facturaR As PdfPCell = New PdfPCell(New Phrase("N° Factura: ", FontStype))
            facturaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            facturaR.Colspan = 1
            facturaR.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

            Dim clienteR As PdfPCell = New PdfPCell(New Phrase("Cliente: ", FontStype))
            clienteR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            clienteR.Colspan = 2
            clienteR.HorizontalAlignment = 1

            Dim codigoCuentaR As PdfPCell = New PdfPCell(New Phrase("Código Cuenta: ", FontStype))
            codigoCuentaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            codigoCuentaR.Colspan = 2
            codigoCuentaR.HorizontalAlignment = 1

            Dim descripcionR As PdfPCell = New PdfPCell(New Phrase("Descripción: ", FontStype))
            descripcionR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            descripcionR.Colspan = 2
            descripcionR.HorizontalAlignment = 1

            Dim totalR As PdfPCell = New PdfPCell(New Phrase("Total: ", FontStype))
            totalR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            totalR.Colspan = 2
            totalR.HorizontalAlignment = 1

            Dim FontStype2 = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.BLACK)

            Dim facturaT As PdfPCell = New PdfPCell(New Phrase(factura, FontStype2))
            facturaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            facturaT.Colspan = 1
            facturaT.HorizontalAlignment = 1

            Dim clienteT As PdfPCell = New PdfPCell(New Phrase(cliente, FontStype2))
            clienteT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            clienteT.Colspan = 2
            clienteT.HorizontalAlignment = 1

            Dim codigoCuentaT As PdfPCell = New PdfPCell(New Phrase(codCuenta, FontStype2))
            codigoCuentaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            codigoCuentaT.Colspan = 2
            codigoCuentaT.HorizontalAlignment = 1

            Dim descripcionT As PdfPCell = New PdfPCell(New Phrase(descripcion, FontStype2))
            descripcionT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            descripcionT.Colspan = 2
            descripcionT.HorizontalAlignment = 1

            Dim subTotalInt As Integer = Convert.ToInt32(total)
            Dim totalT As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt.ToString("N"), FontStype2))
            totalT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            totalT.Colspan = 2
            totalT.HorizontalAlignment = 1

            table.AddCell(facturaR)
            table.AddCell(clienteR)
            table.AddCell(codigoCuentaR)
            table.AddCell(descripcionR)
            table.AddCell(totalR)

            table.AddCell(facturaT)
            table.AddCell(clienteT)
            table.AddCell(codigoCuentaT)
            table.AddCell(descripcionT)
            table.AddCell(totalT)

            pdfDoc.Add(table)

            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))


            pdfDoc.Add(New Paragraph("                        Firma del Asociado: _________________________________________", FontStype3))
            pdfDoc.Add(New Paragraph(" "))


            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & "reciboDeEntradas.pdf", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            'Incrementa el num recibo ingreso en la BD
            BD.actualizarReciboXTipo("ingreso", variablesGlobales.numReciboEntradas + 1)

            Print.Show()

            limpiarRecibo()

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try

    End Sub

End Class
