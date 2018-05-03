Public Class CertificadosSalidas

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Public Sub limpiar()
        VCertificadosSalidas.CertificadosSalidasTextboxFacturaRecibos.Text = ""
        VCertificadosSalidas.CertificadosSalidasTexboxCliente.Text = ""
        VCertificadosSalidas.CertificadosSalidasDescripcion.Text = ""
        VCertificadosSalidas.CertificadosSalidasCantidad.Text = ""
        VCertificadosSalidas.CertificadosSalidasPrecioUnitario.Text = ""
        VCertificadosSalidas.CertificadosSalidasTotal.Text = ""
    End Sub

    Public Sub calcularTotal()
        Try
            Dim cantidad As Integer = Integer.Parse(VCertificadosSalidas.CertificadosSalidasCantidad.Text)
            Dim precioUnitario As Integer = Integer.Parse(VCertificadosSalidas.CertificadosSalidasPrecioUnitario.Text)

            Dim resultado As Integer = cantidad * precioUnitario
            'Format ¢ 1,000.00
            '¢ + Dim stringTotal As String = resultado.ToString("N")

            VCertificadosSalidas.CertificadosSalidasTotal.Text = resultado

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDatosNoNumericos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    'Acum Anterior
    Public Function obtenerAportacionesAcumuladoAnterior()
        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico

        Try
            BD.ConectarBD()
            valores = BD.obtenerAportacionesAcumuladoAnterior()
            If valores.Count <> 0 Then
                Return valores
            Else
                'MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return list
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try
    End Function

    'Total = Periodo Actual
    Public Function obtenerAportacionesTotal()
        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico

        Try
            BD.ConectarBD()
            valores = BD.obtenerAportacionesTotal()
            If valores.Count <> 0 Then
                Return valores
            Else
                'MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return list
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try
    End Function

    'Total de entradas - aportaciones
    Public Function obtenerAportacionesEntradas()
        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico

        Try
            BD.ConectarBD()
            valores = BD.obtenerAportacionesEntradasTotal()
            If valores.Count <> 0 Then
                Return valores
            Else
                'MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return list
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try
    End Function


    'Total de salidas - aportaciones
    Public Function obtenerAportacionesSalidas()
        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico

        Try
            BD.ConectarBD()
            valores = BD.obtenerAportacionesSalidasTotal()
            If valores.Count <> 0 Then
                Return valores
            Else
                'MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Return list
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try
    End Function

    Public Sub insertarCertificadoSalida()

        Dim valores As Integer

        Dim fecha As String = VCertificadosSalidas.CertificadosSalidasFecha.Text
        Dim factura As String = VCertificadosSalidas.CertificadosSalidasTextboxFacturaRecibos.Text
        Dim cliente As String = VCertificadosSalidas.CertificadosSalidasTexboxCliente.Text
        Dim descripcion As String = VCertificadosSalidas.CertificadosSalidasDescripcion.Text
        Dim cantidad As String = VCertificadosSalidas.CertificadosSalidasCantidad.Text
        Dim precioUnitario As String = VCertificadosSalidas.CertificadosSalidasPrecioUnitario.Text
        Dim total As String = VCertificadosSalidas.CertificadosSalidasTotal.Text
        Dim codCuenta As String = VCertificadosSalidas.CertificadosSalidasCodigoDeCuenta.Text
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
        facturaReciboYaExiste = validarNoExistenFacturasRepetidasCertificadosSalidas(factura)
        If facturaReciboYaExiste <> 0 Then
            MessageBox.Show(variablesGlobales.errorFacturaOReciboExiste, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            VCertificadosSalidas.CertificadosSalidasTextboxFacturaRecibos.Text = ""
            VCertificadosSalidas.CertificadosSalidasTextboxFacturaRecibos.Select()
            Return
        End If

        'Validar que No pueda restar si el monto es mayor al Saldo Actual de aportaciones

        Dim totalAportacionesAcum As List(Of String) = obtenerAportacionesAcumuladoAnterior()
        Dim totalAportacionesTotal As List(Of String) = obtenerAportacionesTotal()
        Dim totalAportacionesEntradas As List(Of String) = obtenerAportacionesEntradas()
        Dim totalAportacionesSalidas As List(Of String) = obtenerAportacionesSalidas()

        Dim saldoTotalAportaciones As Integer = Integer.Parse(totalAportacionesAcum.Item(0)) +
                                                Integer.Parse(totalAportacionesTotal.Item(0)) +
                                                Integer.Parse(totalAportacionesEntradas.Item(0)) -
                                                Integer.Parse(totalAportacionesSalidas.Item(0))

        'MessageBox.Show("El acum es : " + totalAportacionesAcum.Item(0))
        'MessageBox.Show("El total o periodo actual es : " + totalAportacionesTotal.Item(0))
        'MessageBox.Show("El total entradas es : " + totalAportacionesEntradas.Item(0))
        'MessageBox.Show("El total salidas es : " + totalAportacionesSalidas.Item(0))

        ' Si el monto de salida es mayor al saldo total no se puede insertar la salida
        'Format ¢ 1,000.00
        '¢ + Dim stringTotal As String = resultado.ToString("N")

        If (Integer.Parse(total) > saldoTotalAportaciones) Then
            MessageBox.Show("Nota: El Saldo total de las Aportaciones es de: ¢ " + saldoTotalAportaciones.ToString("N"))
            MessageBox.Show(variablesGlobales.errorMontoMayorAlSaldoAportaciones, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            VCertificadosSalidas.CertificadosSalidasCantidad.Text = ""
            VCertificadosSalidas.CertificadosSalidasPrecioUnitario.Text = ""
            VCertificadosSalidas.CertificadosSalidasTotal.Text = ""
            VCertificadosSalidas.CertificadosSalidasCantidad.Select()
            Return
        End If

        Try
            BD.ConectarBD()
            valores = BD.insertarCertificadosSalidas(fecha, cliente, descripcion, cantidad, precioUnitario, total, codCuenta, factura)
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
    Function validarNoExistenFacturasRepetidasCertificadosSalidas(ByVal factura As String) As Integer
        Dim facturasRepetidas As List(Of String)
        Dim cantidad As Integer = 0

        Try
            BD.ConectarBD()

            facturasRepetidas = BD.obtenerCertificadosSalidasPorFactura(factura)
            cantidad = facturasRepetidas.Count

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + "" + ex.Message)
        End Try
        Return cantidad
    End Function


End Class
