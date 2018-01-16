Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Globalization

Public Class Ingreso

    Dim BD As ConexionBD = New ConexionBD
    Dim estado As Boolean = True
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub generarReporteIngresos()

        Dim fechaInicial As String = VIngresosReporte.DateTimePicker_IngresosFechaInicio.Text
        Dim fechaFinal As String = VIngresosReporte.DateTimePicker_IngresosFechaFinal.Text

        Try
            Dim valores As List(Of IngresoClase)
            BD.ConectarBD()
            valores = BD.obtenerIngresos(fechaInicial, fechaFinal)
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reporteIngresos.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim contador As Integer = 0
            Dim conta As Integer = 0
            While contador < valores.Count
                If conta = 3 Then
                    pdfDoc.NewPage()
                    encabezado.encabezado(pdfWrite, pdfDoc)
                    conta = 0
                End If
                conta = conta + 1
                pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
                pdfDoc.Add(New Paragraph("Fecha:   " + valores(contador).fecha))
                pdfDoc.Add(New Paragraph("Cliente:    " + valores(contador).cliente))
                pdfDoc.Add(New Paragraph("Descripción: " + valores(contador).descripcripcion))
                pdfDoc.Add(New Paragraph("Cantidad:  " + valores(contador).cantidad))
                pdfDoc.Add(New Paragraph("Precio unitario: " + valores(contador).precioUnitario))
                pdfDoc.Add(New Paragraph("Total: " + valores(contador).total))
                pdfDoc.Add(New Paragraph("Código de cuenta:  " + valores(contador).codCuenta))
                pdfDoc.Add(New Paragraph("Recibo/Factura:   " + valores(contador).facturaRecibo))
                contador = contador + 1
            End While

            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try
    End Sub

    'NUEVO REPORTE
    Public Sub generarReporteIngresosNuevo()

        Dim fechaInicial As String = VIngresosReporte.DateTimePicker_IngresosFechaInicio.Text
        Dim fechaFinal As String = VIngresosReporte.DateTimePicker_IngresosFechaFinal.Text
        Dim totalEntradas As Integer = 0
        Try
            Dim valores As List(Of IngresoClase)
            BD.ConectarBD()
            valores = BD.obtenerIngresos(fechaInicial, fechaFinal)
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reporteEntradas.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            '/////// Encabezado //////////
            Dim FontStype3 = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.BLACK)
            pdfDoc.Add(New Paragraph("                                                                                      Entradas del " + fechaInicial + " al " + fechaFinal, FontStype3))
            pdfDoc.Add(New Paragraph(" "))


            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)

            Dim table As PdfPTable = New PdfPTable(11)

            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            Dim intTblWidth() As Integer = {9, 8, 7, 9, 9, 10, 12, 7, 7, 8, 10}
            table.SetWidths(intTblWidth)

            '' PARA ENCABEZADO DEL REPORTE - COLUMNAS

            Dim fechaR As PdfPCell = New PdfPCell(New Phrase("Fecha", FontStype))
            fechaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            fechaR.Colspan = 1
            fechaR.HorizontalAlignment = 1

            Dim facturaR As PdfPCell = New PdfPCell(New Phrase("N° Factura o Recibo", FontStype))
            facturaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            facturaR.Colspan = 1
            facturaR.HorizontalAlignment = 1

            Dim codigoctaR As PdfPCell = New PdfPCell(New Phrase("Código de cuenta", FontStype))
            codigoctaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            codigoctaR.Colspan = 2
            codigoctaR.HorizontalAlignment = 1

            Dim clienteR As PdfPCell = New PdfPCell(New Phrase("Cliente", FontStype))
            clienteR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            clienteR.Colspan = 2
            clienteR.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

            Dim descripcionR As PdfPCell = New PdfPCell(New Phrase("Descripción", FontStype))
            descripcionR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            descripcionR.Colspan = 2
            descripcionR.HorizontalAlignment = 1

            Dim cantidadR As PdfPCell = New PdfPCell(New Phrase("Cantidad", FontStype))
            cantidadR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            cantidadR.Colspan = 1
            cantidadR.HorizontalAlignment = 1

            Dim precioUnitarioR As PdfPCell = New PdfPCell(New Phrase("Precio Unitario", FontStype))
            precioUnitarioR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            precioUnitarioR.Colspan = 1
            precioUnitarioR.HorizontalAlignment = 1

            Dim totalR As PdfPCell = New PdfPCell(New Phrase("Total", FontStype))
            totalR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            totalR.Colspan = 1
            totalR.HorizontalAlignment = 1

            table.AddCell(fechaR)
            table.AddCell(facturaR)
            table.AddCell(codigoctaR)
            table.AddCell(clienteR)
            table.AddCell(descripcionR)
            table.AddCell(cantidadR)
            table.AddCell(precioUnitarioR)
            table.AddCell(totalR)

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

                Dim fechaT As PdfPCell = New PdfPCell(New Phrase(valores(contador).fecha, FontStype2))
                fechaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                fechaT.Colspan = 1
                fechaT.HorizontalAlignment = 1

                Dim facturaT As PdfPCell = New PdfPCell(New Phrase(valores(contador).facturaRecibo, FontStype2))
                facturaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                facturaT.Colspan = 1
                facturaT.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

                Dim codigoctaT As PdfPCell = New PdfPCell(New Phrase(valores(contador).codCuenta, FontStype2))
                codigoctaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                codigoctaT.Colspan = 2
                codigoctaT.HorizontalAlignment = 1

                Dim clienteT As PdfPCell = New PdfPCell(New Phrase(valores(contador).cliente, FontStype2))
                clienteT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                clienteT.Colspan = 2
                clienteT.HorizontalAlignment = 1

                Dim descripcionT As PdfPCell = New PdfPCell(New Phrase(valores(contador).descripcripcion, FontStype2))
                descripcionT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                descripcionT.Colspan = 2
                descripcionT.HorizontalAlignment = 1

                Dim cantidadT As PdfPCell = New PdfPCell(New Phrase(valores(contador).cantidad, FontStype2))
                cantidadT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                cantidadT.Colspan = 1
                cantidadT.HorizontalAlignment = 1

                Dim precioUnitarioT As PdfPCell = New PdfPCell(New Phrase(valores(contador).precioUnitario, FontStype2))
                precioUnitarioT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                precioUnitarioT.Colspan = 1
                precioUnitarioT.HorizontalAlignment = 1

                Dim subTotalInt As Integer = Convert.ToInt32(valores(contador).total)

                Dim totalT As PdfPCell = New PdfPCell(New Phrase(subTotalInt.ToString("N"), FontStype2))
                totalT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT.Colspan = 1
                totalT.HorizontalAlignment = 1

                table.AddCell(fechaT)
                table.AddCell(facturaT)
                table.AddCell(codigoctaT)
                table.AddCell(clienteT)
                table.AddCell(descripcionT)
                table.AddCell(cantidadT)
                table.AddCell(precioUnitarioT)
                table.AddCell(totalT)

                totalEntradas = totalEntradas + Convert.ToInt32(valores(contador).total)

                contador = contador + 1
            End While



            Dim table2 As PdfPTable = New PdfPTable(11)

            'PARA TOTAL GENERAL
            Dim totalGeneralR As PdfPCell = New PdfPCell(New Phrase("Total General", FontStype))
            totalGeneralR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            totalGeneralR.Colspan = 9
            totalGeneralR.HorizontalAlignment = 1

            Dim FontStype4 = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.BLACK)

            'FOR MULTICURRENCY
            Dim stringTotal As String = totalEntradas.ToString("N")

            Dim totalGeneralT As PdfPCell = New PdfPCell(New Phrase("¢ " + stringTotal, FontStype4))
            totalGeneralT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
            totalGeneralT.Colspan = 2
            totalGeneralT.HorizontalAlignment = 1

            table2.AddCell(totalGeneralR)
            table2.AddCell(totalGeneralT)

            pdfDoc.Add(table)
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(table2)


            ' pdfDoc.Add(New Paragraph("      Total: " + Convert.ToString(totalEntradas), FontStype3))
            'pdfDoc.Add(New Paragraph(" "))

            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & "reporteEntradas.pdf", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try
    End Sub

    Public Sub calcular()
        Try
            Dim cantidad As Integer = Integer.Parse(VIngresos.TextBox_IngresosCantidad.Text)
            Dim precioUnitario As Integer = Integer.Parse(VIngresos.TextBox_IngresosPrecioUnitario.Text)

            VIngresos.TextBox_IngresosTotal.Text = cantidad * precioUnitario

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Sub calcular2()
        Try
            Dim cantidad As Integer = Integer.Parse(VIngresos.TextBox_IngresosCantidad2.Text)
            Dim precioUnitario As Integer = Integer.Parse(VIngresos.TextBox_IngresosPrecioUnitario2.Text)

            VIngresos.TextBox_IngresosTotal2.Text = cantidad * precioUnitario

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Sub calcular3()
        Try
            Dim cantidad As Integer = Integer.Parse(VIngresos.TextBox_IngresosCantidad3.Text)
            Dim precioUnitario As Integer = Integer.Parse(VIngresos.TextBox_IngresosPrecioUnitario3.Text)

            VIngresos.TextBox_IngresosTotal3.Text = cantidad * precioUnitario

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Sub obtenerDatosSeleccionarCuenta()
        Dim valores As List(Of CuentaClase)
        Dim codCuenta As String = VIngresos.ComboBox_IngresosCodigCuenta.Text
        Try
            BD.ConectarBD()
            valores = BD.consultarCuentas()
            If valores.Count <> 0 Then
                estado = True
                VIngresos.ComboBox_IngresosCodigCuenta.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While valores.Count > contador
                    If valores(contador).tipo = "Ingreso" Then
                        VIngresos.ComboBox_IngresosCodigCuenta.Items.Add(valores(contador).codDescripcion)
                        conta += 1
                    End If
                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False
                    VIngresos.ComboBox_IngresosCodigCuenta.Items.Clear()
                    VIngresos.ComboBox_IngresosCodigCuenta.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False
                VIngresos.ComboBox_IngresosCodigCuenta.Items.Clear()
                VIngresos.ComboBox_IngresosCodigCuenta.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    'para el 2do combobox de codigo de cuenta de ingresos
    Public Sub obtenerDatosSeleccionarCuenta2()
        Dim valores As List(Of CuentaClase)

        Try
            BD.ConectarBD()
            valores = BD.consultarCuentas()
            If valores.Count <> 0 Then
                estado = True
                VIngresos.ComboBox_IngresosCodigCuenta2.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While valores.Count > contador
                    If valores(contador).tipo = "Ingreso" Then
                        VIngresos.ComboBox_IngresosCodigCuenta2.Items.Add(valores(contador).codDescripcion)
                        conta += 1
                    End If
                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False
                    VIngresos.ComboBox_IngresosCodigCuenta2.Items.Clear()
                    VIngresos.ComboBox_IngresosCodigCuenta2.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False
                VIngresos.ComboBox_IngresosCodigCuenta2.Items.Clear()
                VIngresos.ComboBox_IngresosCodigCuenta2.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    'para el 2do combobox de codigo de cuenta de ingresos
    Public Sub obtenerDatosSeleccionarCuenta3()
        Dim valores As List(Of CuentaClase)

        Try
            BD.ConectarBD()
            valores = BD.consultarCuentas()
            If valores.Count <> 0 Then
                estado = True
                VIngresos.ComboBox_IngresosCodigCuenta3.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While valores.Count > contador
                    If valores(contador).tipo = "Ingreso" Then
                        VIngresos.ComboBox_IngresosCodigCuenta3.Items.Add(valores(contador).codDescripcion)
                        conta += 1
                    End If
                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False
                    VIngresos.ComboBox_IngresosCodigCuenta3.Items.Clear()
                    VIngresos.ComboBox_IngresosCodigCuenta3.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False
                VIngresos.ComboBox_IngresosCodigCuenta3.Items.Clear()
                VIngresos.ComboBox_IngresosCodigCuenta3.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub limpiarInfo()
        VIngresoInformacion.TextBox_IngresosInformacion_Factura.Text = ""
        VIngresoInformacion.TextBox_IngresosInformacion_Proveedor.Text = ""
        VIngresoInformacion.TextBox_IngresosInformacion_Descripcion.Text = ""
        VIngresoInformacion.TextBox_IngresosInformacion_Cantidad.Text = ""
        VIngresoInformacion.TextBox_IngresosInformacion_PrecioUnit.Text = ""
        VIngresoInformacion.TextBox_IngresosInformacion_Total.Text = ""
    End Sub

    Public Sub limpiar()
        VIngresos.TextBox_IngresosFacturaRecibos.Text = ""
        VIngresos.TextBox_IngresosCliente.Text = ""
        VIngresos.TextBox_IngresosDescripcion.Text = ""
        VIngresos.TextBox_IngresosCantidad.Text = ""
        VIngresos.TextBox_IngresosPrecioUnitario.Text = ""
        VIngresos.TextBox_IngresosTotal.Text = ""
    End Sub

    Public Sub limpiar2()
        VIngresos.TextBox_IngresosFacturaRecibos2.Text = ""
        VIngresos.TextBox_IngresosCliente2.Text = ""
        VIngresos.TextBox_IngresosDescripcion2.Text = ""
        VIngresos.TextBox_IngresosCantidad2.Text = ""
        VIngresos.TextBox_IngresosPrecioUnitario2.Text = ""
        VIngresos.TextBox_IngresosTotal2.Text = ""
    End Sub

    Public Sub limpiar3()
        VIngresos.TextBox_IngresosFacturaRecibos3.Text = ""
        VIngresos.TextBox_IngresosCliente3.Text = ""
        VIngresos.TextBox_IngresosDescripcion3.Text = ""
        VIngresos.TextBox_IngresosCantidad3.Text = ""
        VIngresos.TextBox_IngresosPrecioUnitario3.Text = ""
        VIngresos.TextBox_IngresosTotal3.Text = ""
    End Sub
    'Inserta un ingreso asociado a una cuenta en la BD
    Public Sub insertarIngreso()

        Dim valores As Integer

        Dim fecha As String = VIngresos.DateTimePicker_IngresosFecha.Text
        Dim factura As String = VIngresos.TextBox_IngresosFacturaRecibos.Text
        Dim cliente As String = VIngresos.TextBox_IngresosCliente.Text
        Dim descripcion As String = VIngresos.TextBox_IngresosDescripcion.Text
        Dim cantidad As String = VIngresos.TextBox_IngresosCantidad.Text
        Dim precioUnitario As String = VIngresos.TextBox_IngresosPrecioUnitario.Text
        Dim total As String = VIngresos.TextBox_IngresosTotal.Text
        Dim codCuenta As String = VIngresos.ComboBox_IngresosCodigCuenta.Text

        Dim fecha2 As String = VIngresos.DateTimePicker_IngresosFecha2.Text
        Dim factura2 As String = VIngresos.TextBox_IngresosFacturaRecibos2.Text
        Dim cliente2 As String = VIngresos.TextBox_IngresosCliente2.Text
        Dim descripcion2 As String = VIngresos.TextBox_IngresosDescripcion2.Text
        Dim cantidad2 As String = VIngresos.TextBox_IngresosCantidad2.Text
        Dim precioUnitario2 As String = VIngresos.TextBox_IngresosPrecioUnitario2.Text
        Dim total2 As String = VIngresos.TextBox_IngresosTotal2.Text
        Dim codCuenta2 As String = VIngresos.ComboBox_IngresosCodigCuenta2.Text

        If (factura = "" Or cliente = "" Or descripcion = "" Or cantidad = "" Or precioUnitario = "" Or total = "" Or codCuenta = "" Or estado = False) Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (total.Equals("0")) Then
            MessageBox.Show(variablesGlobales.errorTotalEnCero, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
            Return
        End If

        Try
            Integer.Parse(VIngresos.TextBox_IngresosCantidad.Text)
            Integer.Parse(VIngresos.TextBox_IngresosPrecioUnitario.Text)
            Integer.Parse(VIngresos.TextBox_IngresosTotal.Text)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End Try

        Try
            BD.ConectarBD()
            valores = BD.insertarIngresos(fecha, cliente, descripcion, cantidad, precioUnitario, total, codCuenta, factura)
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

    'Inserta un ingreso asociado a una cuenta en la BD
    Public Sub insertarIngreso2()
        Dim valores As Integer
        Dim fecha2 As String = VIngresos.DateTimePicker_IngresosFecha2.Text
        Dim factura2 As String = VIngresos.TextBox_IngresosFacturaRecibos2.Text
        Dim cliente2 As String = VIngresos.TextBox_IngresosCliente2.Text
        Dim descripcion2 As String = VIngresos.TextBox_IngresosDescripcion2.Text
        Dim cantidad2 As String = VIngresos.TextBox_IngresosCantidad2.Text
        Dim precioUnitario2 As String = VIngresos.TextBox_IngresosPrecioUnitario2.Text
        Dim total2 As String = VIngresos.TextBox_IngresosTotal2.Text
        Dim codCuenta2 As String = VIngresos.ComboBox_IngresosCodigCuenta2.Text

        If (factura2 = "" Or cliente2 = "" Or descripcion2 = "" Or cantidad2 = "" Or precioUnitario2 = "" Or total2 = "" Or codCuenta2 = "" Or estado = False) Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (total2.Equals("0")) Then
            MessageBox.Show(variablesGlobales.errorTotalEnCero, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar2()
            Return
        End If

        Try
            Integer.Parse(VIngresos.TextBox_IngresosCantidad2.Text)
            Integer.Parse(VIngresos.TextBox_IngresosPrecioUnitario2.Text)
            Integer.Parse(VIngresos.TextBox_IngresosTotal2.Text)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End Try

        Try
            BD.ConectarBD()
            valores = BD.insertarIngresos(fecha2, cliente2, descripcion2, cantidad2, precioUnitario2, total2, codCuenta2, factura2)
            If valores <> 0 Then
                limpiar2()
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try

    End Sub

    'Inserta un ingreso asociado a una cuenta en la BD
    Public Sub insertarIngreso3()
        Dim valores As Integer
        Dim fecha3 As String = VIngresos.DateTimePicker_IngresosFecha3.Text
        Dim factura3 As String = VIngresos.TextBox_IngresosFacturaRecibos3.Text
        Dim cliente3 As String = VIngresos.TextBox_IngresosCliente3.Text
        Dim descripcion3 As String = VIngresos.TextBox_IngresosDescripcion3.Text
        Dim cantidad3 As String = VIngresos.TextBox_IngresosCantidad3.Text
        Dim precioUnitario3 As String = VIngresos.TextBox_IngresosPrecioUnitario3.Text
        Dim total3 As String = VIngresos.TextBox_IngresosTotal3.Text
        Dim codCuenta3 As String = VIngresos.ComboBox_IngresosCodigCuenta3.Text

        If (factura3 = "" Or cliente3 = "" Or descripcion3 = "" Or cantidad3 = "" Or precioUnitario3 = "" Or total3 = "" Or codCuenta3 = "" Or estado = False) Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (total3.Equals("0")) Then
            MessageBox.Show(variablesGlobales.errorTotalEnCero, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar3()
            Return
        End If

        Try
            Integer.Parse(VIngresos.TextBox_IngresosCantidad3.Text)
            Integer.Parse(VIngresos.TextBox_IngresosPrecioUnitario3.Text)
            Integer.Parse(VIngresos.TextBox_IngresosTotal3.Text)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End Try

        Try
            BD.ConectarBD()
            valores = BD.insertarIngresos(fecha3, cliente3, descripcion3, cantidad3, precioUnitario3, total3, codCuenta3, factura3)
            If valores <> 0 Then
                limpiar3()
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try

    End Sub

    Public Sub buscarIngreso()
        Dim valores As New List(Of String)
        Dim IngresoInformacionInputID As String = VIngresoInformacion.IngresosInformacionInputID.Text

        If (IngresoInformacionInputID = "") Then
            MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
        Else
            Try
                BD.ConectarBD()

                valores = BD.obtenerIngresosPorFactura(IngresoInformacionInputID)
                If valores.Count = 0 Then
                    MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    limpiar()

                Else
                    VIngresoInformacion.DateTimePicker_IngresosInformacion_fecha.Text = Date.Parse(valores.Item(0))
                    VIngresoInformacion.TextBox_IngresosInformacion_Factura.Text = valores.Item(1)
                    VIngresoInformacion.TextBox_IngresosInformacion_Proveedor.Text = valores.Item(2)
                    VIngresoInformacion.ComboBox_IngresosInformacion.Text = valores.Item(3)
                    VIngresoInformacion.ComboBox_IngresosInformacion.Items.Add(valores.Item(3))
                    VIngresoInformacion.TextBox_IngresosInformacion_Descripcion.Text = valores.Item(4)
                    VIngresoInformacion.TextBox_IngresosInformacion_Cantidad.Text = valores.Item(5)
                    VIngresoInformacion.TextBox_IngresosInformacion_PrecioUnit.Text = valores.Item(6)
                    VIngresoInformacion.TextBox_IngresosInformacion_Total.Text = valores.Item(7)
                End If

                BD.CerrarConexion()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)

            End Try
        End If
    End Sub

    Public Sub calcularInfo()
        Try
            Dim cantidad As Integer = Integer.Parse(VIngresoInformacion.TextBox_IngresosInformacion_Cantidad.Text)
            Dim precioUnitario As Integer = Integer.Parse(VIngresoInformacion.TextBox_IngresosInformacion_PrecioUnit.Text)
            VIngresoInformacion.TextBox_IngresosInformacion_Total.Text = cantidad * precioUnitario
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Sub modificarIngresos()
        Dim valores As Integer
        Dim fecha As String = VIngresoInformacion.DateTimePicker_IngresosInformacion_fecha.Text
        Dim factura As String = VIngresoInformacion.TextBox_IngresosInformacion_Factura.Text
        Dim cliente As String = VIngresoInformacion.TextBox_IngresosInformacion_Proveedor.Text
        Dim descripcion As String = VIngresoInformacion.TextBox_IngresosInformacion_Descripcion.Text
        Dim cantidad As String = VIngresoInformacion.TextBox_IngresosInformacion_Cantidad.Text
        Dim precioUnitario As String = VIngresoInformacion.TextBox_IngresosInformacion_PrecioUnit.Text
        Dim total As String = VIngresoInformacion.TextBox_IngresosInformacion_Total.Text
        Dim codCuenta As String = VIngresoInformacion.ComboBox_IngresosInformacion.Text

        If (factura = "" Or cliente = "" Or descripcion = "" Or total = "" Or codCuenta = "" Or estado = False) Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (total.Equals("0")) Then
            MessageBox.Show(variablesGlobales.errorTotalEnCero, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiarInfo()
            Return
        End If

        Try
            Integer.Parse(total)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End Try
        Try
            BD.ConectarBD()
            valores = BD.actualizarIngreso(fecha, cliente, descripcion, cantidad, precioUnitario, total, codCuenta, factura)
            MessageBox.Show(valores, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If valores <> 0 Then
                limpiarInfo()
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub eliminarIngresos()
        Dim factura As String = VIngresoInformacion.TextBox_IngresosInformacion_Factura.Text
        Dim valores As Integer
        If (factura = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If
        Try
            BD.ConectarBD()
            valores = BD.eliminarFacturaIngresos(factura)
            If valores <> 0 Then
                limpiarInfo()
                MessageBox.Show(variablesGlobales.datosEliminadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub
End Class
