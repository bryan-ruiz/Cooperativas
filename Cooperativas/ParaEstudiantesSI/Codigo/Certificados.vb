Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Certificados
    Dim BD As ConexionBD = New ConexionBD
    Dim estado As Boolean = True
    Dim encabezado As EncabezadoClase = New EncabezadoClase

    Public Sub consultar()

        Dim valores As List(Of String)
        Dim cedulaOnumAsociado As String = Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text

        If (cedulaOnumAsociado = "") Then
            MessageBox.Show("Debe ingresar la Cédula o el Número de asociado para consultar")
        Else
            Try
                BD.ConectarBD()
                valores = BD.consultarCertificadoXSocio(cedulaOnumAsociado)

                If valores.Count <> 0 Then
                    Ventana_Principal.CertificadosTextboxNombre.Text = valores(0)
                    Ventana_Principal.CertificadosTextboxPrimerApellido.Text = valores(1)
                    Ventana_Principal.CertificadosTextboxSegundoApellido.Text = valores(2)
                    Ventana_Principal.CertificadosTextboxTracto1.Text = valores(6)
                    Ventana_Principal.CertificadosTextboxTracto2.Text = valores(7)
                    Ventana_Principal.CertificadosTextboxTracto3.Text = valores(8)
                    Ventana_Principal.CertificadosTextboxTracto4.Text = valores(9)
                    Ventana_Principal.CertificadosTextboxTracto5.Text = valores(10)
                    Ventana_Principal.CertificadosTextboxTracto6.Text = valores(11)
                    Ventana_Principal.CertificadosTextboxTracto7.Text = valores(12)
                    Ventana_Principal.CertificadosTextboxTracto8.Text = valores(13)
                    Ventana_Principal.CertificadosTextboxTracto9.Text = valores(14)
                    Ventana_Principal.CertificadosTextboxTracto10.Text = valores(15)
                    Ventana_Principal.CertificadosTextboxAcumAnterior.Text = valores(16)
                    Ventana_Principal.CertificadosTextboxTotalPeriodo.Text = valores(17)

                    consultarFechasLimite()

                Else
                    MessageBox.Show("El Socio no se encuentra registrado")
                    Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text = ""
                End If
                'Cierro conexion'
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show("Error de: " + ex.ToString)
            End Try
        End If
    End Sub

    'cerrar certificado
    Public Sub cerrarCertificado()
        Dim monto As String = "0"
        Dim cedula As String = Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text
        Try
            BD.ConectarBD()
            Dim hecho As Integer = BD.sumarTractosEnCertificados(cedula)
            If hecho = 0 Then
                BD.cerrarCertificado(cedula, hecho, monto)
            Else
                MessageBox.Show("Listo.")
                Ventana_Principal.CertificadosTextboxTracto1.Text = "0"
                Ventana_Principal.CertificadosTextboxTracto2.Text = "0"
                Ventana_Principal.CertificadosTextboxTracto3.Text = "0"
                Ventana_Principal.CertificadosTextboxTracto4.Text = "0"
                Ventana_Principal.CertificadosTextboxTracto5.Text = "0"
                Ventana_Principal.CertificadosTextboxTracto6.Text = "0"
                Ventana_Principal.CertificadosTextboxTracto7.Text = "0"
                Ventana_Principal.CertificadosTextboxTracto8.Text = "0"
                Ventana_Principal.CertificadosTextboxTracto9.Text = "0"
                Ventana_Principal.CertificadosTextboxTracto10.Text = "0"
                Ventana_Principal.CertificadosTextboxTotalPeriodo.Text = "0"
                Ventana_Principal.CertificadosTextboxAcumAnterior.Text = hecho
                BD.cerrarCertificado(cedula, hecho, monto)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
        End Try
    End Sub

    'sumar tractos
    Public Sub sumarTractosEnCertificados()
        Dim cedula As String = Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text
        Try
            BD.ConectarBD()
            Dim hecho As Integer = BD.sumarTractosEnCertificados(cedula)
            If hecho = 0 Then
                'MessageBox.Show("Ha ocurrido un error.")
                Ventana_Principal.CertificadosTextboxTotalPeriodo.Text = hecho
            Else
                Ventana_Principal.CertificadosTextboxTotalPeriodo.Text = hecho
                hecho = BD.totalEnCertificado(cedula, CStr(hecho))
                If hecho = 0 Then
                    MessageBox.Show("Ha ocurrido un error.")
                End If
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
        End Try
    End Sub

    'Update tracto with value "numeroTracto"
    Public Sub editarTracto(ByVal numeroTracto As String)
        Dim monto As String = ""
        Dim cedula As String = Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text

        If numeroTracto = "1" Then
            monto = Ventana_Principal.CertificadosTextboxTracto1.Text
        ElseIf numeroTracto = "2" Then
            monto = Ventana_Principal.CertificadosTextboxTracto2.Text
        ElseIf numeroTracto = "3" Then
            monto = Ventana_Principal.CertificadosTextboxTracto3.Text
        ElseIf numeroTracto = "4" Then
            monto = Ventana_Principal.CertificadosTextboxTracto4.Text
        ElseIf numeroTracto = "5" Then
            monto = Ventana_Principal.CertificadosTextboxTracto5.Text
        ElseIf numeroTracto = "6" Then
            monto = Ventana_Principal.CertificadosTextboxTracto6.Text
        ElseIf numeroTracto = "7" Then
            monto = Ventana_Principal.CertificadosTextboxTracto7.Text
        ElseIf numeroTracto = "8" Then
            monto = Ventana_Principal.CertificadosTextboxTracto8.Text
        ElseIf numeroTracto = "9" Then
            monto = Ventana_Principal.CertificadosTextboxTracto9.Text
        ElseIf numeroTracto = "10" Then
            monto = Ventana_Principal.CertificadosTextboxTracto10.Text
        End If

        Try
            BD.ConectarBD()
            Dim hecho As Integer = BD.actualizarTracto(numeroTracto, cedula, monto)
            If hecho = 0 Then
                MessageBox.Show("Ha ocurrido un error.")
            Else
                MessageBox.Show("Se ha guardado el Tracto seleccionado!")
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
        End Try
    End Sub

    'Consulta las fechas limite para pagar certificados
    Public Sub consultarFechasLimite()
        Dim fechas As List(Of ConfiguracionClase)
        Try
            BD.ConectarBD()
            fechas = BD.obtenerDatosdeConfiguration()
            If fechas.Count <> 0 Then
                llenarDatosFechaLimite(fechas)
            Else
                MessageBox.Show("El Periodo a consultar no existe")
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
        End Try
    End Sub

    'Llena los campos con los datos de la consulta
    Public Sub llenarDatosFechaLimite(ByVal valores As List(Of ConfiguracionClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            Ventana_Principal.CertificadosDateTimePickerFecha1.Value = Date.Parse(valores(conta).fechaLimite1)
            Ventana_Principal.CertificadosDateTimePickerFecha2.Value = Date.Parse(valores(conta).fechaLimite2)
            Ventana_Principal.CertificadosDateTimePickerFecha3.Value = Date.Parse(valores(conta).fechaLimite3)
            Ventana_Principal.CertificadosDateTimePickerFecha4.Value = Date.Parse(valores(conta).fechaLimite4)
            Ventana_Principal.CertificadosDateTimePickerFecha5.Value = Date.Parse(valores(conta).fechaLimite5)
            Ventana_Principal.CertificadosDateTimePickerFecha6.Value = Date.Parse(valores(conta).fechaLimite6)
            Ventana_Principal.CertificadosDateTimePickerFecha7.Value = Date.Parse(valores(conta).fechaLimite7)
            Ventana_Principal.CertificadosDateTimePickerFecha8.Value = Date.Parse(valores(conta).fechaLimite8)
            Ventana_Principal.CertificadosDateTimePickerFecha9.Value = Date.Parse(valores(conta).fechaLimite9)
            Ventana_Principal.CertificadosDateTimePickerFecha10.Value = Date.Parse(valores(conta).fechaLimite10)
            conta = conta + 1
        End While
    End Sub




End Class
