Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Ingreso
    Dim BD As ConexionBD = New ConexionBD
    Dim estado As Boolean = True
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Public Sub generarReporteIngresos()
        Dim fechaInicial As String = Ventana_Principal.DateTimePicker_IngresosFechaInicio.Text
        Dim fechaFinal As String = Ventana_Principal.DateTimePicker_IngresosFechaFinal.Text
        Try
            Dim valores As List(Of IngresoClase)
            BD.ConectarBD()
            valores = BD.obtenerIngresos(fechaInicial, fechaFinal)
            BD.CerrarConexion()

            'Exporting to PDF
            Dim folderPath As String = "C:\Reportes\"
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(folderPath & "reporteIngresos.pdf", FileMode.Create))
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
            MessageBox.Show("Reporte generado con éxito en C:/Reportes/")
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
        End Try
    End Sub

    Public Sub calcular()
        Try
            Dim cantidad As Integer = Integer.Parse(Ventana_Principal.TextBox_IngresosCantidad.Text)
            Dim precioUnitario As Integer = Integer.Parse(Ventana_Principal.TextBox_IngresosPrecioUnitario.Text)
            Ventana_Principal.TextBox_IngresosTotal.Text = cantidad * precioUnitario
        Catch ex As Exception
            MessageBox.Show("Error datos no numéricos en espacios requeridos")
        End Try
    End Sub

    Public Sub obtenerDatosSeleccionarCuenta()
        Dim valores As List(Of CuentaClase)
        Dim codCuenta As String = Ventana_Principal.ComboBox_IngresosCodigCuenta.Text
        Try
            BD.ConectarBD()
            valores = BD.consultarCuentas()
            If valores.Count <> 0 Then
                estado = True
                Ventana_Principal.ComboBox_IngresosCodigCuenta.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While valores.Count > contador
                    If valores(contador).tipo = "Ingreso" Then
                        Ventana_Principal.ComboBox_IngresosCodigCuenta.Items.Add(valores(contador).codDescripcion)
                        conta += 1
                    End If
                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False
                    Ventana_Principal.ComboBox_IngresosCodigCuenta.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False
                Ventana_Principal.ComboBox_IngresosCodigCuenta.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show("Error de: " + ex.ToString)
        End Try
    End Sub

    Public Sub limpiar()
        Ventana_Principal.TextBox_IngresosFacturaRecibos.Text = ""
        Ventana_Principal.TextBox_IngresosCliente.Text = ""
        Ventana_Principal.TextBox_IngresosDescripcion.Text = ""
        Ventana_Principal.TextBox_IngresosCantidad.Text = ""
        Ventana_Principal.TextBox_IngresosPrecioUnitario.Text = ""
        Ventana_Principal.TextBox_IngresosTotal.Text = ""
    End Sub

    Public Sub insertarIngreso()
        Dim valores As Integer
        Dim fecha As String = Ventana_Principal.DateTimePicker_IngresosFecha.Text
        Dim factura As String = Ventana_Principal.TextBox_IngresosFacturaRecibos.Text
        Dim cliente As String = Ventana_Principal.TextBox_IngresosCliente.Text
        Dim descripcion As String = Ventana_Principal.TextBox_IngresosDescripcion.Text
        Dim cantidad As String = Ventana_Principal.TextBox_IngresosCantidad.Text
        Dim precioUnitario As String = Ventana_Principal.TextBox_IngresosPrecioUnitario.Text
        Dim total As String = Ventana_Principal.TextBox_IngresosTotal.Text
        Dim codCuenta As String = Ventana_Principal.ComboBox_IngresosCodigCuenta.Text

        If (factura = "" Or cliente = "" Or descripcion = "" Or cantidad = "" Or
            precioUnitario = "" Or total = "" Or codCuenta = "" Or estado = False) Then
            MessageBox.Show("Error: Espacios en blanco o datos faltantes")
            Return
        End If
        Try
            Integer.Parse(Ventana_Principal.TextBox_IngresosCantidad.Text)
            Integer.Parse(Ventana_Principal.TextBox_IngresosPrecioUnitario.Text)
            Integer.Parse(Ventana_Principal.TextBox_IngresosTotal.Text)
        Catch ex As Exception
            MessageBox.Show("Error datos no numéricos en espacios requeridos")
            Return
        End Try
        Try
            BD.ConectarBD()
            valores = BD.insertarIngresos(fecha, cliente, descripcion, cantidad,
                                          precioUnitario, total, codCuenta, factura)
            If valores <> 0 Then
                limpiar()
                MessageBox.Show("Se ha realizado exitosamente")
            Else
                MessageBox.Show("Error al insertar cuenta")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
            'MessageBox.Show("ocurrio el siguiente error:" + ex.ToString())
        End Try
    End Sub
End Class
