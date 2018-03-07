Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Reservas
    Dim BD As ConexionBD = New ConexionBD
    Dim estado As Boolean = True
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim informeEconomico As InformeEconomico = New InformeEconomico
    Dim listaDeReservas As List(Of ReservaClase)

    Public Function afiliacionEnReserva(ByVal fechaDesde As Date, ByVal fechaHasta As Date)
        Dim valores As Integer
        Try
            BD.ConectarBD()
            valores = BD.afiliacionesDeReservas("#" + fechaDesde + "#", "#" + fechaHasta + "#")
            BD.CerrarConexion()
            Return valores
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Function

    Public Sub realizarCierrePeriodo()
        Dim valores1 As Integer
        Dim valores2 As Integer
        Dim valores3 As Integer
        Dim valores4 As Integer
        Dim valores5 As Integer
        Dim valores6 As Integer

        Dim fechaDesde As Date = VResrvasPrincipal.ReservasDateTimePickerDesde.Value.ToString("dd/MM/yyyy")
        Dim fechaHasta As Date = VResrvasPrincipal.ReservasDateTimePickerHasta.Value.ToString("dd/MM/yyyy")

        Dim subTotalIngresos As List(Of String) = informeEconomico.obtenerSubTotalIngresos("Ingreso", "Si", fechaDesde, fechaHasta)
        Dim subTotalGastos As List(Of String) = informeEconomico.obtenerSubTotalGastos("Gasto", "Si", fechaDesde, fechaHasta)
        Dim valoresReserva As List(Of ConfiguracionClase) = informeEconomico.consultarValoresConfiguracion()

        Dim excedentesBrutos As Integer = Integer.Parse(subTotalIngresos.Item(0)) - Integer.Parse(subTotalGastos.Item(0))

        Dim sumaBSocial As Integer = (excedentesBrutos * valoresReserva(0).bienestarSocial) / 100
        Dim sumaInstitucional As Integer = (excedentesBrutos * valoresReserva(0).institucional) / 100
        Dim sumaPatrimonial As Integer = (excedentesBrutos * valoresReserva(0).patrimonial) / 100
        Dim sumaEducacion As Integer = (excedentesBrutos * valoresReserva(0).educacion) / 100

        valores1 = actualizarMontoEnBase(sumaBSocial, "bienestarSocial")
        valores2 = actualizarMontoEnBase(sumaInstitucional, "Institucional")
        valores3 = actualizarMontoEnBase(sumaPatrimonial, "Patrimonial")
        valores4 = actualizarMontoEnBase(sumaEducacion, "educacion")

        Dim cantidadAfuliaciones As Integer = afiliacionEnReserva(fechaDesde, fechaHasta)
        valores5 = actualizarMontoEnBase((cantidadAfuliaciones / 100) * 50, "educacion")
        valores6 = actualizarMontoEnBase((cantidadAfuliaciones / 100) * 50, "bienestarSocial")

        If valores1 <> 0 And valores2 <> 0 And valores3 <> 0 And valores4 <> 0 Then
            MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Public Sub crearReporteReservas()
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                generarReporteReservas()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
    End Sub

    Public Sub cerrarPeriodo()
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                realizarCierrePeriodo()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
    End Sub

    Function acumuladoDeReserva(ByVal monto As String, ByVal reserva As String) As Integer
        Dim contador As Integer = 0
        Dim montoDeReserva As Integer = CInt(monto)
        While contador < listaDeReservas.Count
            If (listaDeReservas(contador).nombre = reserva) Then
                If (montoDeReserva > listaDeReservas(contador).monto) Then
                    Return 1
                End If
            End If
            contador += 1
        End While
        Return 0
    End Function

    Public Sub acumuladoDeReservaCambiarEnTextBox()
        Dim contador As Integer = 0
        Dim nombreReservaSeleccionada As String = VGestionDeReservas.ComboBox_reservasGestion.Text
        While contador < listaDeReservas.Count
            If listaDeReservas(contador).nombre = nombreReservaSeleccionada Then
                VGestionDeReservas.TextBox_ReservasGestionMontoActual.Text = listaDeReservas(contador).monto.ToString
            End If
            contador += 1
        End While
        VGestionDeReservas.TextBox_ReservasGestionMonto.Text = ""
    End Sub

    Public Sub actualizarEnReserva()
        Dim valores As Integer
        Dim monto As String = VGestionDeReservas.TextBox_ReservasGestionMonto.Text
        Dim reserva As String = VGestionDeReservas.ComboBox_reservasGestion.Text
        If (monto = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If

        If (reserva = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
        Try
            valores = 0
            BD.ConectarBD()
            valores = BD.actualizarMontoEnReserva(monto, reserva)
            listaDeReservas = BD.consultarReservas()
            If valores <> 0 Then
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error en base de datos")
        End Try
    End Sub


    Public Sub disminuriEnReserva()
        Dim valores As Integer
        Dim monto As String = VGestionDeReservas.TextBox_ReservasGestionMonto.Text
        Dim reserva As String = VGestionDeReservas.ComboBox_reservasGestion.Text
        If (monto = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If

        If (reserva = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
        Try
            valores = acumuladoDeReserva(monto, reserva)
            If valores = 1 Then
                MessageBox.Show("Error monto superior al que se posee registrado en la base de datos")
                Return
            Else
                valores = 0
                BD.ConectarBD()
                valores = BD.disminuirMontoEnReserva(monto, reserva)
                listaDeReservas = BD.consultarReservas()
                If valores <> 0 Then
                    MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error en base de datos")
        End Try
    End Sub

    Function actualizarMontoEnBase(ByVal monto As String, ByVal reserva As String) As Integer
        Dim valores As Integer
        Try
            BD.ConectarBD()
            valores = BD.insertarMontoEnReserva(monto, reserva)
            listaDeReservas = BD.consultarReservas()
            BD.CerrarConexion()
            Return valores
        Catch ex As Exception
            MessageBox.Show("Error en la base de datos")
        End Try
    End Function

    Public Sub insertarEnReserva()
        Dim valores As Integer
        Dim monto As String = VGestionDeReservas.TextBox_ReservasGestionMonto.Text
        Dim reserva As String = VGestionDeReservas.ComboBox_reservasGestion.Text
        If (monto = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
        If (reserva = "") Then
            MessageBox.Show(variablesGlobales.mensajeNoDejarEspaciosVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
        valores = actualizarMontoEnBase(monto, reserva)
        MessageBox.Show(valores)
        If valores <> 0 Then
            MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub


    Public Sub obtenerDatosSeleccionarReserva()
        Try
            BD.ConectarBD()
            listaDeReservas = BD.consultarReservas()
            If listaDeReservas.Count <> 0 Then
                estado = True
                VGestionDeReservas.ComboBox_reservasGestion.Items.Clear()
                Dim contador As Integer = 0
                Dim conta As Integer = 0
                While listaDeReservas.Count > contador
                    VGestionDeReservas.ComboBox_reservasGestion.Items.Add(listaDeReservas(contador).nombre)
                    conta += 1
                    contador = contador + 1
                End While
                If conta = 0 Then
                    estado = False

                    VGestionDeReservas.ComboBox_reservasGestion.Items.Clear()
                    VGestionDeReservas.ComboBox_reservasGestion.Items.Add("No se poseen cuentas")
                End If
            Else
                estado = False
                VGestionDeReservas.ComboBox_reservasGestion.Items.Clear()
                VGestionDeReservas.ComboBox_reservasGestion.Items.Add("No se poseen cuentas")
            End If

            BD.CerrarConexion()
        Catch ex As Exception
            estado = False
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub


    Public Sub generarReporteReservas()
        Try

            BD.ConectarBD()
            listaDeReservas = BD.consultarReservas()
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reporte_Reservas.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            '/////// Encabezado //////////
            Dim FontStype3 = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.BLACK)
            pdfDoc.Add(New Paragraph("                                                                                     Total de Acumulado en Reservas", FontStype3))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))



            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)

            Dim table As PdfPTable = New PdfPTable(3)

            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            Dim intTblWidth() As Integer = {10, 8, 8}
            table.SetWidths(intTblWidth)

            '' PARA ENCABEZADO DEL REPORTE - COLUMNAS

            Dim codigoctaR As PdfPCell = New PdfPCell(New Phrase("Nombre de Reserva", FontStype))
            codigoctaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            codigoctaR.Colspan = 2
            codigoctaR.HorizontalAlignment = 1

            Dim totalR As PdfPCell = New PdfPCell(New Phrase("Total Acumulado", FontStype))
            totalR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            totalR.Colspan = 1
            totalR.HorizontalAlignment = 1

            table.AddCell(codigoctaR)
            table.AddCell(totalR)

            Dim contador As Integer = 0
            Dim conta As Integer = 0
            While contador < listaDeReservas.Count
                If conta = 50 Then
                    pdfDoc.Add(table)
                    pdfDoc.NewPage()
                    encabezado.encabezado(pdfWrite, pdfDoc)
                    table.DeleteBodyRows()
                    conta = 0
                End If

                conta = conta + 1
                Dim FontStype2 = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK)

                Dim codigoctaT As PdfPCell = New PdfPCell(New Phrase(listaDeReservas(contador).nombre, FontStype2))
                codigoctaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                codigoctaT.Colspan = 2
                codigoctaT.HorizontalAlignment = 1

                Dim totalT As PdfPCell = New PdfPCell(New Phrase(" ¢ " + listaDeReservas(contador).monto.ToString, FontStype2))
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

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito & "reporte_Reservas.pdf", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message())
        End Try
    End Sub
End Class
