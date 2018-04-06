Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Gastos
    Dim BD As ConexionBD = New ConexionBD
    Dim estado As Boolean = True
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'Calcula cantidad * precioUnitario
    Public Sub calcularInfo()
        Try
            Dim cantidad As Integer = Integer.Parse(VGastosInformacion.TextBox_GastosInformacion_Cantidad.Text)
            Dim precioUnitario As Integer = Integer.Parse(VGastosInformacion.TextBox_GastosInformacion_PrecioUnit.Text)
            VGastosInformacion.TextBox_GastosInformacion_Total.Text = cantidad * precioUnitario
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Sub calcular()
        Try
            Dim cantidad As Integer = Integer.Parse(VGastos.TextBox_GastosCantidad.Text)
            Dim precioUnitario As Integer = Integer.Parse(VGastos.TextBox_GastosPrecioUnitario.Text)
            VGastos.TextBox_GastosTotal.Text = cantidad * precioUnitario
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Sub calcular2()
        Try
            Dim cantidad As Integer = Integer.Parse(VGastos.TextBox_GastosCantidad2.Text)
            Dim precioUnitario As Integer = Integer.Parse(VGastos.TextBox_GastosPrecioUnitario2.Text)
            VGastos.TextBox_GastosTotal2.Text = cantidad * precioUnitario
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Sub calcular3()
        Try
            Dim cantidad As Integer = Integer.Parse(VGastos.TextBox_GastosCantidad3.Text)
            Dim precioUnitario As Integer = Integer.Parse(VGastos.TextBox_GastosPrecioUnitario3.Text)
            VGastos.TextBox_GastosTotal3.Text = cantidad * precioUnitario
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Sub generarReporteCuentaGastos()
        Dim fechaInicial As Date = VReporteGastoCuentas.DateTimePicker_GastosCuentasReporte_fi.Value.ToString("dd/MM/yyyy")
        Dim fechaFinal As Date = VReporteGastoCuentas.DateTimePicker_GastosCuentasReporte_ff.Value.ToString("dd/MM/yyyy")
        Dim totalEntradas As Integer = 0
        Try
            Dim valores As List(Of String)
            BD.ConectarBD()
            valores = BD.obtenerGastosCuenta(fechaInicial, fechaFinal)
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reporteCuentaSalidas.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            '/////// Encabezado //////////
            Dim FontStype3 = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.BLACK)
            pdfDoc.Add(New Paragraph("                                                                                      Gastos en Cuentas desde: " + fechaInicial + " al " + fechaFinal, FontStype3))
            pdfDoc.Add(New Paragraph(" "))


            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)

            Dim table As PdfPTable = New PdfPTable(3)

            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            Dim intTblWidth() As Integer = {10, 8, 8}
            table.SetWidths(intTblWidth)

            '' PARA ENCABEZADO DEL REPORTE - COLUMNAS

            Dim codigoctaR As PdfPCell = New PdfPCell(New Phrase("Código de cuenta", FontStype))
            codigoctaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            codigoctaR.Colspan = 2
            codigoctaR.HorizontalAlignment = 1

            Dim totalR As PdfPCell = New PdfPCell(New Phrase("Total", FontStype))
            totalR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            totalR.Colspan = 1
            totalR.HorizontalAlignment = 1

            table.AddCell(codigoctaR)
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

                Dim codigoctaT As PdfPCell = New PdfPCell(New Phrase(valores(contador), FontStype2))
                codigoctaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                codigoctaT.Colspan = 2
                codigoctaT.HorizontalAlignment = 1
                contador = contador + 1

                Dim totalT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + valores(contador), FontStype2))
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

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & "reporteCuentasSalidas.pdf", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try
    End Sub


    Public Sub obtenerDatosSeleccionarCuenta()
        Dim valores As List(Of CuentaClase)
        Try
            BD.ConectarBD()
            valores = BD.consultarCuentas()
            If valores.Count <> 0 Then
                estado = True
                VGastos.ComboBox_GastosCodCuenta.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While valores.Count > contador
                    If valores(contador).tipo = "Gasto" Then
                        VGastos.ComboBox_GastosCodCuenta.Items.Add(valores(contador).codDescripcion)
                        conta += 1
                    End If
                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False
                    VGastos.ComboBox_GastosCodCuenta.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False
                VGastos.ComboBox_GastosCodCuenta.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub obtenerDatosSeleccionarCuenta2()
        Dim valores As List(Of CuentaClase)
        Try
            BD.ConectarBD()
            valores = BD.consultarCuentas()
            If valores.Count <> 0 Then
                estado = True
                VGastos.ComboBox_GastosCodCuenta2.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While valores.Count > contador
                    If valores(contador).tipo = "Gasto" Then
                        VGastos.ComboBox_GastosCodCuenta2.Items.Add(valores(contador).codDescripcion)
                        conta += 1
                    End If
                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False
                    VGastos.ComboBox_GastosCodCuenta2.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False
                VGastos.ComboBox_GastosCodCuenta2.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub obtenerDatosSeleccionarCuenta3()
        Dim valores As List(Of CuentaClase)
        Try
            BD.ConectarBD()
            valores = BD.consultarCuentas()
            If valores.Count <> 0 Then
                estado = True
                VGastos.ComboBox_GastosCodCuenta3.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While valores.Count > contador
                    If valores(contador).tipo = "Gasto" Then
                        VGastos.ComboBox_GastosCodCuenta3.Items.Add(valores(contador).codDescripcion)
                        conta += 1
                    End If
                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False
                    VGastos.ComboBox_GastosCodCuenta3.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False
                VGastos.ComboBox_GastosCodCuenta3.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        VGastos.TextBox_GastosFacturaRecibo.Text = ""
        VGastos.TextBox_GastosProveedor.Text = ""
        VGastos.TextBox_GastosDescripcion.Text = ""
        VGastos.TextBox_GastosCantidad.Text = ""
        VGastos.TextBox_GastosPrecioUnitario.Text = ""
        VGastos.TextBox_GastosTotal.Text = ""
    End Sub

    Public Sub limpiar2()
        VGastos.TextBox_GastosFacturaRecibo2.Text = ""
        VGastos.TextBox_GastosProveedor2.Text = ""
        VGastos.TextBox_GastosDescripcion2.Text = ""
        VGastos.TextBox_GastosCantidad2.Text = ""
        VGastos.TextBox_GastosPrecioUnitario2.Text = ""
        VGastos.TextBox_GastosTotal2.Text = ""
    End Sub

    Public Sub limpiar4()
        VGastosInformacion.TextBox_GastosInformacion_Cantidad.Text = ""
        VGastosInformacion.TextBox_GastosInformacion_Descripcion.Text = ""
        VGastosInformacion.TextBox_GastosInformacion_Factura.Text = ""
        VGastosInformacion.TextBox_GastosInformacion_PrecioUnit.Text = ""
        VGastosInformacion.TextBox_GastosInformacion_Proveedor.Text = ""
        VGastosInformacion.TextBox_GastosInformacion_Total.Text = ""
    End Sub

    Public Sub limpiar3()
        VGastos.TextBox_GastosFacturaRecibo3.Text = ""
        VGastos.TextBox_GastosProveedor3.Text = ""
        VGastos.TextBox_GastosDescripcion3.Text = ""
        VGastos.TextBox_GastosCantidad3.Text = ""
        VGastos.TextBox_GastosPrecioUnitario3.Text = ""
        VGastos.TextBox_GastosTotal3.Text = ""
    End Sub

    'Valida que no exista la factura en la tabla Gastos
    Function validarNoExistenFacturasRepetidasGastos(ByVal factura As String) As Integer
        Dim facturasRepetidasGastos As List(Of String)
        Dim cantidad As Integer = 0

        Try
            BD.ConectarBD()

            facturasRepetidasGastos = BD.obtenerGastosPorFactura(factura)
            cantidad = facturasRepetidasGastos.Count

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + "" + ex.ToString)
        End Try
        Return cantidad
    End Function


    Public Sub insertarGasto()

        Dim valores As Integer
        Dim fecha As String = VGastos.DateTimePicker_GastosFecha.Text
        Dim factura As String = VGastos.TextBox_GastosFacturaRecibo.Text
        Dim cliente As String = VGastos.TextBox_GastosProveedor.Text
        Dim descripcion As String = VGastos.TextBox_GastosDescripcion.Text
        Dim cantidad As String = VGastos.TextBox_GastosCantidad.Text
        Dim precioUnitario As String = VGastos.TextBox_GastosPrecioUnitario.Text
        Dim total As String = VGastos.TextBox_GastosTotal.Text
        Dim codCuenta As String = VGastos.ComboBox_GastosCodCuenta.Text
        Dim facturaReciboYaExiste As Integer = 0

        If (factura = "" Or cliente = "" Or descripcion = "" Or total = "" Or codCuenta = "" Or estado = False) Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (total.Equals("0")) Then
            MessageBox.Show(variablesGlobales.errorTotalEnCero, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
            Return
        End If


        Try
            Integer.Parse(total)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End Try

        'Validar que no existen facturas con el mismo ID en el Sistema
        facturaReciboYaExiste = validarNoExistenFacturasRepetidasGastos(factura)
        If facturaReciboYaExiste <> 0 Then
            MessageBox.Show(variablesGlobales.errorFacturaOReciboExiste, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            VGastos.TextBox_GastosFacturaRecibo.Text = ""
            VGastos.TextBox_GastosFacturaRecibo.Select()
            Return
        End If

        Try
            BD.ConectarBD()

            valores = BD.insertarGastos(fecha, cliente, descripcion, cantidad, precioUnitario, total, codCuenta, factura)
            If valores <> 0 Then
                limpiar()
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub insertarGasto2()

        Dim valores As Integer
        Dim fecha As String = VGastos.DateTimePicker_GastosFecha2.Text
        Dim factura As String = VGastos.TextBox_GastosFacturaRecibo2.Text
        Dim cliente As String = VGastos.TextBox_GastosProveedor2.Text
        Dim descripcion As String = VGastos.TextBox_GastosDescripcion2.Text
        Dim cantidad As String = VGastos.TextBox_GastosCantidad2.Text
        Dim precioUnitario As String = VGastos.TextBox_GastosPrecioUnitario2.Text
        Dim total As String = VGastos.TextBox_GastosTotal2.Text
        Dim codCuenta As String = VGastos.ComboBox_GastosCodCuenta2.Text
        Dim facturaReciboYaExiste As Integer = 0

        If (factura = "" Or cliente = "" Or descripcion = "" Or total = "" Or codCuenta = "" Or estado = False) Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (total.Equals("0")) Then
            MessageBox.Show(variablesGlobales.errorTotalEnCero, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar2()
            Return
        End If

        Try
            Integer.Parse(total)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End Try

        'Validar que no existen facturas con el mismo ID en el Sistema
        facturaReciboYaExiste = validarNoExistenFacturasRepetidasGastos(factura)
        If facturaReciboYaExiste <> 0 Then
            MessageBox.Show(variablesGlobales.errorFacturaOReciboExiste, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            VGastos.TextBox_GastosFacturaRecibo2.Text = ""
            VGastos.TextBox_GastosFacturaRecibo2.Select()
            Return
        End If

        Try
            BD.ConectarBD()
            valores = BD.insertarGastos(fecha, cliente, descripcion, cantidad, precioUnitario, total, codCuenta, factura)
            If valores <> 0 Then
                limpiar2()
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub buscarGasto()
        Dim valores As New List(Of String)
        Dim GastosInformacionInputID As String = VGastosInformacion.GastosInformacionInputID.Text

        If (GastosInformacionInputID = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
        Else
            Try
                BD.ConectarBD()

                valores = BD.obtenerGastosPorFactura(GastosInformacionInputID)

                If valores.Count = 0 Then
                    MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    limpiar()

                Else
                    VGastosInformacion.DateTimePicker_GastosInformacion_fecha.Text = Date.Parse(valores.Item(0))
                    VGastosInformacion.TextBox_GastosInformacion_Factura.Text = valores.Item(1)
                    VGastosInformacion.TextBox_GastosInformacion_Proveedor.Text = valores.Item(2)
                    VGastosInformacion.ComboBox_GastosInformacion.Items.Add(valores.Item(3))
                    VGastosInformacion.ComboBox_GastosInformacion.SelectedIndex = 0
                    VGastosInformacion.TextBox_GastosInformacion_Descripcion.Text = valores.Item(4)
                    VGastosInformacion.TextBox_GastosInformacion_Cantidad.Text = valores.Item(5)
                    VGastosInformacion.TextBox_GastosInformacion_PrecioUnit.Text = valores.Item(6)
                    VGastosInformacion.TextBox_GastosInformacion_Total.Text = valores.Item(7)
                End If

                BD.CerrarConexion()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)

            End Try
        End If
    End Sub

    Public Sub modificarGasto()
        Dim valores As Integer
        Dim fecha As String = VGastosInformacion.DateTimePicker_GastosInformacion_fecha.Text
        Dim factura As String = VGastosInformacion.TextBox_GastosInformacion_Factura.Text
        Dim cliente As String = VGastosInformacion.TextBox_GastosInformacion_Proveedor.Text
        Dim descripcion As String = VGastosInformacion.TextBox_GastosInformacion_Descripcion.Text
        Dim cantidad As String = VGastosInformacion.TextBox_GastosInformacion_Cantidad.Text
        Dim precioUnitario As String = VGastosInformacion.TextBox_GastosInformacion_PrecioUnit.Text
        Dim total As String = VGastosInformacion.TextBox_GastosInformacion_Total.Text
        Dim codCuenta As String = VGastosInformacion.ComboBox_GastosInformacion.Text

        If (factura = "" Or cliente = "" Or descripcion = "" Or total = "" Or codCuenta = "" Or estado = False) Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (total.Equals("0")) Then
            MessageBox.Show(variablesGlobales.errorTotalEnCero, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar4()
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
            valores = BD.actualizarGasto(fecha, cliente, descripcion, cantidad, precioUnitario, total, codCuenta, factura)
            If valores <> 0 Then
                limpiar4()
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub eliminarGasto()
        Dim factura As String = VGastosInformacion.TextBox_GastosInformacion_Factura.Text
        Dim valores As Integer
        If (factura = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If
        Try
            BD.ConectarBD()
            valores = BD.eliminarFacturaGastos(factura)
            If valores <> 0 Then
                limpiar4()
                MessageBox.Show(variablesGlobales.datosEliminadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub insertarGasto3()
        Dim valores As Integer
        Dim fecha As String = VGastos.DateTimePicker_GastosFecha3.Text
        Dim factura As String = VGastos.TextBox_GastosFacturaRecibo3.Text
        Dim cliente As String = VGastos.TextBox_GastosProveedor3.Text
        Dim descripcion As String = VGastos.TextBox_GastosDescripcion3.Text
        Dim cantidad As String = VGastos.TextBox_GastosCantidad3.Text
        Dim precioUnitario As String = VGastos.TextBox_GastosPrecioUnitario3.Text
        Dim total As String = VGastos.TextBox_GastosTotal3.Text
        Dim codCuenta As String = VGastos.ComboBox_GastosCodCuenta3.Text
        Dim facturaReciboYaExiste As Integer = 0

        If (factura = "" Or cliente = "" Or descripcion = "" Or total = "" Or codCuenta = "" Or estado = False) Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (total.Equals("0")) Then
            MessageBox.Show(variablesGlobales.errorTotalEnCero, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar3()
            Return
        End If

        Try
            Integer.Parse(total)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End Try

        'Validar que no existen facturas con el mismo ID en el Sistema
        facturaReciboYaExiste = validarNoExistenFacturasRepetidasGastos(factura)
        If facturaReciboYaExiste <> 0 Then
            MessageBox.Show(variablesGlobales.errorFacturaOReciboExiste, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            VGastos.TextBox_GastosFacturaRecibo3.Text = ""
            VGastos.TextBox_GastosFacturaRecibo3.Select()
            Return
        End If

        Try
            BD.ConectarBD()
            valores = BD.insertarGastos(fecha, cliente, descripcion, cantidad, precioUnitario, total, codCuenta, factura)
            If valores <> 0 Then
                limpiar3()
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Private Sub generarReporteGastos()
        Dim fechaInicial As String = VGastosReporte.DateTimePicker_GastosFechaI.Text
        Dim fechaFinal As String = VGastosReporte.DateTimePicker_GastosFechaF.Text
        Try
            Dim valores As List(Of GastoClase)
            BD.ConectarBD()
            valores = BD.obtenerGastos(fechaInicial, fechaFinal)
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reporteGastos.pdf", FileMode.Create))
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
                pdfDoc.Add(New Paragraph("Proveedor:    " + valores(contador).proveedor))
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
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    Public Sub generarReporteGastosNuevo()
        Dim fechaInicial As String = VGastosReporte.DateTimePicker_GastosFechaI.Text
        Dim fechaFinal As String = VGastosReporte.DateTimePicker_GastosFechaF.Text
        Dim totalEntradas As Integer = 0
        Try
            Dim valores As List(Of GastoClase)
            BD.ConectarBD()
            valores = BD.obtenerGastos(fechaInicial, fechaFinal)
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reporteSalidas.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            '/////// Encabezado //////////
            Dim FontStype3 = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.BLACK)
            pdfDoc.Add(New Paragraph("                                                                                      Salidas del " + fechaInicial + " al " + fechaFinal, FontStype3))
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

                Dim clienteT As PdfPCell = New PdfPCell(New Phrase(valores(contador).proveedor, FontStype2))
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

            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & "reporteSalidas.pdf", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try
    End Sub
End Class