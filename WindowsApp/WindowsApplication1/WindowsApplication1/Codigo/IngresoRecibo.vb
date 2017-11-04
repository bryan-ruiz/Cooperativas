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
            Dim cantidad As Integer = Integer.Parse(VIngresos.TextBox_IngresosCantidad.Text)
            Dim precioUnitario As Integer = Integer.Parse(VIngresos.TextBox_IngresosPrecioUnitario.Text)

            VIngresos.TextBox_IngresosTotal.Text = cantidad * precioUnitario

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
        kkk
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
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
        End Try

    End Sub

End Class
