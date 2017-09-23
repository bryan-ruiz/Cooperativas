Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Certificados

    Dim BD As ConexionBD = New ConexionBD
    Dim estado As Boolean = True
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Public Sub consultar()

        Dim valores As List(Of String)
        Dim cedulaOnumAsociado As String = Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text

        If (cedulaOnumAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
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
                    MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text = ""
                End If

                BD.CerrarConexion()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
            End Try
        End If
    End Sub

    'Cierra el periodo para Certificados
    Public Sub cerrarCertificado()

        Dim monto As String = "0"
        Dim cedula As String = Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text

        Try
            BD.ConectarBD()
            Dim hecho As Integer = BD.sumarTractosEnCertificados(cedula)

            If hecho = 0 Then
                BD.cerrarCertificado(cedula, hecho, monto)
            Else
                MessageBox.Show(variablesGlobales.datosActualizadosConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

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
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
        End Try
    End Sub

    'sumar tractos
    Public Sub sumarTractosEnCertificados()
        Dim cedula As String = Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text

        Try
            BD.ConectarBD()
            Dim hecho As Integer = BD.sumarTractosEnCertificados(cedula)

            If hecho = 0 Then
                Ventana_Principal.CertificadosTextboxTotalPeriodo.Text = hecho
            Else
                Ventana_Principal.CertificadosTextboxTotalPeriodo.Text = hecho
                hecho = BD.totalEnCertificado(cedula, CStr(hecho))
                If hecho = 0 Then
                    MessageBox.Show(variablesGlobales.errorActualizandoDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
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
                MessageBox.Show(variablesGlobales.errorActualizandoDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.datosActualizadosConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
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
                MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
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

    'Valida la fecha límite
    Private Function validarFecha(ByVal fecha As DateTime) As Boolean
        Dim value As Boolean = False
        Dim GETDATE As DateTime = DateTime.Today

        If fecha.CompareTo(GETDATE) > 0 Then
            value = False
        End If
        If fecha.CompareTo(GETDATE) < 0 Then
            value = True
        End If

        Return value

    End Function

    'Valida la fecha del tracto y llama a actualizar tracto
    Public Sub validarTracto(ByVal numTracto As String, ByVal fecha As DateTime)
        If validarFecha(fecha) Then
            MessageBox.Show(variablesGlobales.errorFechaLimiteMenorActual, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Else
            editarTracto(numTracto)
            sumarTractosEnCertificados()
        End If
    End Sub

    Public Sub limpiar()
        Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text = ""
        Ventana_Principal.CertificadosTextboxNombre.Text = ""
        Ventana_Principal.CertificadosTextboxPrimerApellido.Text = ""
        Ventana_Principal.CertificadosTextboxSegundoApellido.Text = ""
        Ventana_Principal.CertificadosTextboxTracto1.Text = ""
        Ventana_Principal.CertificadosTextboxTracto2.Text = ""
        Ventana_Principal.CertificadosTextboxTracto3.Text = ""
        Ventana_Principal.CertificadosTextboxTracto4.Text = ""
        Ventana_Principal.CertificadosTextboxTracto5.Text = ""
        Ventana_Principal.CertificadosTextboxTracto6.Text = ""
        Ventana_Principal.CertificadosTextboxTracto7.Text = ""
        Ventana_Principal.CertificadosTextboxTracto8.Text = ""
        Ventana_Principal.CertificadosTextboxTracto9.Text = ""
        Ventana_Principal.CertificadosTextboxTracto10.Text = ""
        Ventana_Principal.CertificadosTextboxAcumAnterior.Text = ""
        Ventana_Principal.CertificadosTextboxTotalPeriodo.Text = ""
    End Sub

    'Genera un reporte con los datos de aportaciones actuales de un socio
    Public Sub comprobante()
        Dim cedulaOnumAsociado As String = Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text
        Dim nombre As String = Ventana_Principal.CertificadosTextboxNombre.Text
        Dim primerApellido As String = Ventana_Principal.CertificadosTextboxPrimerApellido.Text
        Dim segundoApellido As String = Ventana_Principal.CertificadosTextboxSegundoApellido.Text
        Dim tracto1 As String = Ventana_Principal.CertificadosTextboxTracto1.Text
        Dim tracto2 As String = Ventana_Principal.CertificadosTextboxTracto2.Text
        Dim tracto3 As String = Ventana_Principal.CertificadosTextboxTracto3.Text
        Dim tracto4 As String = Ventana_Principal.CertificadosTextboxTracto4.Text
        Dim tracto5 As String = Ventana_Principal.CertificadosTextboxTracto5.Text
        Dim tracto6 As String = Ventana_Principal.CertificadosTextboxTracto6.Text
        Dim tracto7 As String = Ventana_Principal.CertificadosTextboxTracto7.Text
        Dim tracto8 As String = Ventana_Principal.CertificadosTextboxTracto8.Text
        Dim tracto9 As String = Ventana_Principal.CertificadosTextboxTracto9.Text
        Dim tracto10 As String = Ventana_Principal.CertificadosTextboxTracto10.Text
        Dim acum As String = Ventana_Principal.CertificadosTextboxAcumAnterior.Text
        Dim total As String = Ventana_Principal.CertificadosTextboxTotalPeriodo.Text


        If (cedulaOnumAsociado = "" Or nombre = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                If Not Directory.Exists(variablesGlobales.folderPath) Then
                    Directory.CreateDirectory(variablesGlobales.folderPath)
                End If

                Dim pdfDoc As New Document()
                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "comprobanteCertificados.pdf", FileMode.Create))

                pdfDoc.Open()

                encabezado.consultarDatos()
                encabezado.encabezado(pdfWrite, pdfDoc)
                Dim FontStype = FontFactory.GetFont("Arial", 9, Font.NORMAL)

                pdfDoc.Add(New Paragraph("                                                                 Comprobante de Aportaciones ", FontStype))
                pdfDoc.Add(New Paragraph(""))
                pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
                pdfDoc.Add(New Paragraph(" "))
                pdfDoc.Add(New Paragraph(" "))

                pdfDoc.Add(New Paragraph("Cédula o Num de Asociado:   " + cedulaOnumAsociado, FontStype))
                pdfDoc.Add(New Paragraph("Nombre completo:  " + nombre + " " + primerApellido + " " + segundoApellido, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #1:  " + tracto1, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #2:  " + tracto2, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #3:  " + tracto3, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #4:  " + tracto4, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #5:  " + tracto5, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #6:  " + tracto6, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #7:  " + tracto7, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #8:  " + tracto8, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #9:  " + tracto9, FontStype))
                pdfDoc.Add(New Paragraph("Tracto #10:  " + tracto10, FontStype))
                pdfDoc.Add(New Paragraph("Total del Periodo:  " + total, FontStype))
                pdfDoc.Add(New Paragraph("Acumulado Anterior:  " + acum, FontStype))

                pdfDoc.Close()

                MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Print.Show()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
            End Try
        End If

    End Sub


End Class
