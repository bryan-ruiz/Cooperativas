Public Class CertificadosEntradas

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Public Sub limpiar()
        VCertificadosEntradas.CertificadosEntradasTextboxFacturaRecibos.Text = ""
        VCertificadosEntradas.CertificadosEntradasTexboxCliente.Text = ""
        VCertificadosEntradas.CertificadosEntradasDescripcion.Text = ""
        VCertificadosEntradas.CertificadosEntradasCantidad.Text = ""
        VCertificadosEntradas.CertificadosEntradasPrecioUnitario.Text = ""
        VCertificadosEntradas.CertificadosEntradasTotal.Text = ""
    End Sub

    Public Sub calcularTotal()
        Try
            Dim cantidad As Integer = Integer.Parse(VCertificadosEntradas.CertificadosEntradasCantidad.Text)
            Dim precioUnitario As Integer = Integer.Parse(VCertificadosEntradas.CertificadosEntradasPrecioUnitario.Text)

            Dim resultado As Integer = cantidad * precioUnitario
            'Format ¢ 1,000.00
            '¢ + Dim stringTotal As String = resultado.ToString("N")

            VCertificadosEntradas.CertificadosEntradasTotal.Text = resultado

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Sub insertarCertificadoEntrada()

        Dim valores As Integer

        Dim fecha As String = VCertificadosEntradas.CertificadosEntradasFecha.Text
        Dim factura As String = VCertificadosEntradas.CertificadosEntradasTextboxFacturaRecibos.Text
        Dim cliente As String = VCertificadosEntradas.CertificadosEntradasTexboxCliente.Text
        Dim descripcion As String = VCertificadosEntradas.CertificadosEntradasDescripcion.Text
        Dim cantidad As String = VCertificadosEntradas.CertificadosEntradasCantidad.Text
        Dim precioUnitario As String = VCertificadosEntradas.CertificadosEntradasPrecioUnitario.Text
        Dim total As String = VCertificadosEntradas.CertificadosEntradasTotal.Text
        Dim codCuenta As String = VCertificadosEntradas.CertificadosEntradasCodigoDeCuenta.Text
        Dim facturaReciboYaExiste As Integer = 0

        If (factura = "" Or cliente = "" Or descripcion = "" Or cantidad = "" Or precioUnitario = "" Or total = "" Or codCuenta = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        If (total.Equals("0")) Then
            MessageBox.Show(variablesGlobales.errorTotalEnCero, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
            Return
        End If

        Try
            Integer.Parse(cantidad)
            Integer.Parse(precioUnitario)
            Integer.Parse(total)
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End Try

        'Validar que no existen facturas con el mismo ID en el Sistema
        facturaReciboYaExiste = validarNoExistenFacturasRepetidasCertificadosEntradas(factura)
        If facturaReciboYaExiste <> 0 Then
            MessageBox.Show(variablesGlobales.errorFacturaOReciboExiste, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            VCertificadosEntradas.CertificadosEntradasTextboxFacturaRecibos.Text = ""
            VCertificadosEntradas.CertificadosEntradasTextboxFacturaRecibos.Select()
            Return
        End If

        Try
            BD.ConectarBD()
            valores = BD.insertarCertificadosEntradas(fecha, cliente, descripcion, cantidad, precioUnitario, total, codCuenta, factura)
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

    'Valida que no exista la factura en la tabla 
    Function validarNoExistenFacturasRepetidasCertificadosEntradas(ByVal factura As String) As Integer
        Dim facturasRepetidas As List(Of String)
        Dim cantidad As Integer = 0

        Try
            BD.ConectarBD()

            facturasRepetidas = BD.obtenerCertificadosEntradasPorFactura(factura)
            cantidad = facturasRepetidas.Count

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + "" + ex.Message)
        End Try
        Return cantidad
    End Function


End Class
