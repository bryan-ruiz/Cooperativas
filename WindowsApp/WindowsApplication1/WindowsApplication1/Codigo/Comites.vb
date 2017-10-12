Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Comites

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Public Sub escribirDatos(ByVal valores As List(Of ComiteClase), ByVal pdfDoc As iTextSharp.text.Document, ByVal writer As iTextSharp.text.pdf.PdfWriter)

        If valores.Count = 0 Then
            pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            pdfDoc.Add(New Paragraph("************ No se poseen datos del comité ******************"))
            Return
        End If

        Dim contador As Integer = 0
        Dim conta As Integer = 0

        While contador < valores.Count
            If conta = 3 Then
                pdfDoc.NewPage()
                encabezado.encabezado(writer, pdfDoc)
                conta = 0
            End If

            conta = conta + 1
            pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            pdfDoc.Add(New Paragraph("Cargo:   " + valores(contador).tipo))
            pdfDoc.Add(New Paragraph("Nombre completo:  " + valores(contador).nombreCompleto))
            pdfDoc.Add(New Paragraph("Cédula:  " + valores(contador).cedual))
            pdfDoc.Add(New Paragraph("Ocupación:  " + valores(contador).ocupacion))
            pdfDoc.Add(New Paragraph("Menor: " + valores(contador).menor))
            pdfDoc.Add(New Paragraph("Fecha rige:  " + valores(contador).fechaRige))
            pdfDoc.Add(New Paragraph("Fecha vence: " + valores(contador).fechaVence))
            contador = contador + 1
        End While

    End Sub

    Public Sub generarReporteDeComites()
        Try
            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reporteComites.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)
            Dim valores As List(Of ComiteClase)

            BD.ConectarBD()
            valores = BD.obtenerDatosdeUnComite("Consejo de administración")
            pdfDoc.Add(New Paragraph("                                           COMITÉ CONSEJO DE ADMINISTRACIÓN "))
            escribirDatos(valores, pdfDoc, pdfWrite)
            valores = BD.obtenerDatosdeUnComite("Vigilancia")
            pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            pdfDoc.Add(New Paragraph("                                              COMITÉ DE VIGILANCIA "))
            escribirDatos(valores, pdfDoc, pdfWrite)
            valores = BD.obtenerDatosdeUnComite("Asesor")
            pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            pdfDoc.Add(New Paragraph("                                              COMITÉ DE ASESOR "))
            escribirDatos(valores, pdfDoc, pdfWrite)
            valores = BD.obtenerDatosdeUnComite("Ahorro")
            pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            pdfDoc.Add(New Paragraph("                                              COMITÉ DE AHORRO "))
            escribirDatos(valores, pdfDoc, pdfWrite)
            valores = BD.obtenerDatosdeUnComite("Educación Bienestar Social")
            pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            pdfDoc.Add(New Paragraph("                                    COMITÉ DE EDUCACIÓN Y BIENESTAR SOCIAL "))
            escribirDatos(valores, pdfDoc, pdfWrite)
            BD.CerrarConexion()

            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
        End Try
    End Sub

    Public Sub limpiar()

        VComites.TextBoxComitesPresidente.Text = ""
        VComites.TextBoxTipo_comitePresidente.Text = ""
        VComites.TextBoxComiteMenorPresi.Text = ""
        VComites.DateTimePickerFechaRige_ComitePresidente.Text = ""
        VComites.DateTimePickerFechaVence_ComitePresidente.Text = ""
        VComites.TextBoxID_ComitePresidente.Text = ""
        VComites.TextBoxComitesVicepresidente.Text = ""
        VComites.TextBoxTipo_ComiteVicePresidente.Text = ""
        VComites.TextBoxComiteMenorViceP.Text = ""
        VComites.DateTimePickerFechaRige_ComiteVicePresidente.Text = ""
        VComites.DateTimePickerFechaVence_ComiteVicePresidente.Text = ""
        VComites.TextBoxID_ComiteVicePresidente.Text = ""
        VComites.TextBoxComitesSecretaria.Text = ""
        VComites.TextBoxTipo_ComiteSecretaria.Text = ""
        VComites.TextBoxComiteMenorSec.Text = ""
        VComites.DateTimePickerFechaRige_ComiteSecretaria.Text = ""
        VComites.DateTimePickerFechaVence_ComiteSecretaria.Text = ""
        VComites.TextBoxID_ComiteSecretaria.Text = ""
        VComites.TextBoxComitesVocal1.Text = ""
        VComites.TextBoxTipo_ComiteVocal1.Text = ""
        VComites.TextBoxComiteMenorVoc1.Text = ""
        VComites.DateTimePickerFechaRige_ComiteVocal1.Text = ""
        VComites.DateTimePickerFechaVence_ComiteVocal1.Text = ""
        VComites.TextBoxID_ComiteVocal1.Text = ""
        VComites.TextBoxComitesVocal2.Text = ""
        VComites.TextBoxTipo_ComiteVocal2.Text = ""
        VComites.TextBoxComiteMenorVoc2.Text = ""
        VComites.DateTimePickerFechaRige_ComiteVocal2.Text = ""
        VComites.DateTimePickerFechaVence_ComiteVocal2.Text = ""
        VComites.TextBoxID_ComiteVocal2.Text = ""
        VComites.TextBoxComitesSuplente1.Text = ""
        VComites.TextBoxTipo_ComiteSuplente1.Text = ""
        VComites.TextBoxComiteMenorSupl1.Text = ""
        VComites.DateTimePickerFechaRige_ComiteSuplente1.Text = ""
        VComites.DateTimePickerFechaVence_ComiteSuplente1.Text = ""
        VComites.TextBoxID_ComiteSuplente1.Text = ""
        VComites.TextBoxComitesSuplente2.Text = ""
        VComites.TextBoxTipo_ComiteSuplente2.Text = ""
        VComites.TextBoxComiteMenorSupl2.Text = ""
        VComites.DateTimePickerFechaRige_ComiteSuplente2.Text = ""
        VComites.DateTimePickerFechaVence_ComiteSuplente2.Text = ""
        VComites.TextBoxID_ComiteSuplente2.Text = ""
    End Sub


    Public Sub actualizarComiteF()
        Dim tipoConsejo As String = VComites.ComboBoxComitesNombre.Text
        Dim nombreCompleto As String
        Dim ocupacion As String
        Dim menor As String
        Dim fechaRige As String
        Dim fechaVence As String
        Dim cedula As String

        If VComites.ComboBoxComitesNombre.Text.Contains("Selecione") Then
            MessageBox.Show("Debe seleccionar un nombre de comité", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else


            Try
                BD.ConectarBD()

                nombreCompleto = VComites.TextBoxComitesPresidente.Text
                ocupacion = VComites.TextBoxTipo_comitePresidente.Text
                menor = VComites.TextBoxComiteMenorPresi.Text
                fechaRige = VComites.DateTimePickerFechaRige_ComitePresidente.Text
                fechaVence = VComites.DateTimePickerFechaVence_ComitePresidente.Text
                cedula = VComites.TextBoxID_ComitePresidente.Text
                BD.actualizarComite(nombreCompleto, ocupacion, menor, fechaRige, fechaVence, cedula, tipoConsejo, "presidente")

                nombreCompleto = VComites.TextBoxComitesVicepresidente.Text
                ocupacion = VComites.TextBoxTipo_ComiteVicePresidente.Text
                menor = VComites.TextBoxComiteMenorViceP.Text
                fechaRige = VComites.DateTimePickerFechaRige_ComiteVicePresidente.Text
                fechaVence = VComites.DateTimePickerFechaVence_ComiteVicePresidente.Text
                cedula = VComites.TextBoxID_ComiteVicePresidente.Text
                BD.actualizarComite(nombreCompleto, ocupacion, menor, fechaRige, fechaVence, cedula, tipoConsejo, "vicePresidente")

                nombreCompleto = VComites.TextBoxComitesSecretaria.Text
                ocupacion = VComites.TextBoxTipo_ComiteSecretaria.Text
                menor = VComites.TextBoxComiteMenorSec.Text
                fechaRige = VComites.DateTimePickerFechaRige_ComiteSecretaria.Text
                fechaVence = VComites.DateTimePickerFechaVence_ComiteSecretaria.Text
                cedula = VComites.TextBoxID_ComiteSecretaria.Text
                BD.actualizarComite(nombreCompleto, ocupacion, menor, fechaRige, fechaVence, cedula, tipoConsejo, "secretaria")

                nombreCompleto = VComites.TextBoxComitesVocal1.Text
                ocupacion = VComites.TextBoxTipo_ComiteVocal1.Text
                menor = VComites.TextBoxComiteMenorVoc1.Text
                fechaRige = VComites.DateTimePickerFechaRige_ComiteVocal1.Text
                fechaVence = VComites.DateTimePickerFechaVence_ComiteVocal1.Text
                cedula = VComites.TextBoxID_ComiteVocal1.Text
                BD.actualizarComite(nombreCompleto, ocupacion, menor, fechaRige, fechaVence, cedula, tipoConsejo, "vocal1")

                nombreCompleto = VComites.TextBoxComitesVocal2.Text
                ocupacion = VComites.TextBoxTipo_ComiteVocal2.Text
                menor = VComites.TextBoxComiteMenorVoc2.Text
                fechaRige = VComites.DateTimePickerFechaRige_ComiteVocal2.Text
                fechaVence = VComites.DateTimePickerFechaVence_ComiteVocal2.Text
                cedula = VComites.TextBoxID_ComiteVocal2.Text
                BD.actualizarComite(nombreCompleto, ocupacion, menor, fechaRige, fechaVence, cedula, tipoConsejo, "vocal2")

                nombreCompleto = VComites.TextBoxComitesSuplente1.Text
                ocupacion = VComites.TextBoxTipo_ComiteSuplente1.Text
                menor = VComites.TextBoxComiteMenorSupl1.Text
                fechaRige = VComites.DateTimePickerFechaRige_ComiteSuplente1.Text
                fechaVence = VComites.DateTimePickerFechaVence_ComiteSuplente1.Text
                cedula = VComites.TextBoxID_ComiteSuplente1.Text
                BD.actualizarComite(nombreCompleto, ocupacion, menor, fechaRige, fechaVence, cedula, tipoConsejo, "suplente1")

                nombreCompleto = VComites.TextBoxComitesSuplente2.Text
                ocupacion = VComites.TextBoxTipo_ComiteSuplente2.Text
                menor = VComites.TextBoxComiteMenorSupl2.Text
                fechaRige = VComites.DateTimePickerFechaRige_ComiteSuplente2.Text
                fechaVence = VComites.DateTimePickerFechaVence_ComiteSuplente2.Text
                cedula = VComites.TextBoxID_ComiteSuplente2.Text
                BD.actualizarComite(nombreCompleto, ocupacion, menor, fechaRige, fechaVence, cedula, tipoConsejo, "suplente2")

                BD.CerrarConexion()
                MessageBox.Show(variablesGlobales.datosActualizadosConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorActualizandoDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        End If


    End Sub

    'Llena los campos con los datos de la consulta
    Public Sub llenarDatos(ByVal valores As List(Of ComiteClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            If valores(conta).tipo = "presidente" Then
                VComites.TextBoxComitesPresidente.Text = valores(conta).nombreCompleto
                VComites.TextBoxTipo_comitePresidente.Text = valores(conta).ocupacion
                VComites.TextBoxComiteMenorPresi.Text = valores(conta).menor
                VComites.DateTimePickerFechaRige_ComitePresidente.Text = valores(conta).fechaRige
                VComites.DateTimePickerFechaVence_ComitePresidente.Text = valores(conta).fechaVence
                VComites.TextBoxID_ComitePresidente.Text = valores(conta).cedual

            ElseIf valores(conta).tipo = "vicePresidente" Then
                VComites.TextBoxComitesVicepresidente.Text = valores(conta).nombreCompleto
                VComites.TextBoxTipo_ComiteVicePresidente.Text = valores(conta).ocupacion
                VComites.TextBoxComiteMenorViceP.Text = valores(conta).menor
                VComites.DateTimePickerFechaRige_ComiteVicePresidente.Text = valores(conta).fechaRige
                VComites.DateTimePickerFechaVence_ComiteVicePresidente.Text = valores(conta).fechaVence
                VComites.TextBoxID_ComiteVicePresidente.Text = valores(conta).cedual

            ElseIf valores(conta).tipo = "secretaria" Then
                VComites.TextBoxComitesSecretaria.Text = valores(conta).nombreCompleto
                VComites.TextBoxTipo_ComiteSecretaria.Text = valores(conta).ocupacion
                VComites.TextBoxComiteMenorSec.Text = valores(conta).menor
                VComites.DateTimePickerFechaRige_ComiteSecretaria.Text = valores(conta).fechaRige
                VComites.DateTimePickerFechaVence_ComiteSecretaria.Text = valores(conta).fechaVence
                VComites.TextBoxID_ComiteSecretaria.Text = valores(conta).cedual

            ElseIf valores(conta).tipo = "vocal1" Then
                VComites.TextBoxComitesVocal1.Text = valores(conta).nombreCompleto
                VComites.TextBoxTipo_ComiteVocal1.Text = valores(conta).ocupacion
                VComites.TextBoxComiteMenorVoc1.Text = valores(conta).menor
                VComites.DateTimePickerFechaRige_ComiteVocal1.Text = valores(conta).fechaRige
                VComites.DateTimePickerFechaVence_ComiteVocal1.Text = valores(conta).fechaVence
                VComites.TextBoxID_ComiteVocal1.Text = valores(conta).cedual

            ElseIf valores(conta).tipo = "vocal2" Then
                VComites.TextBoxComitesVocal2.Text = valores(conta).nombreCompleto
                VComites.TextBoxTipo_ComiteVocal2.Text = valores(conta).ocupacion
                VComites.TextBoxComiteMenorVoc2.Text = valores(conta).menor
                VComites.DateTimePickerFechaRige_ComiteVocal2.Text = valores(conta).fechaRige
                VComites.DateTimePickerFechaVence_ComiteVocal2.Text = valores(conta).fechaVence
                VComites.TextBoxID_ComiteVocal2.Text = valores(conta).cedual

            ElseIf valores(conta).tipo = "suplente1" Then
                VComites.TextBoxComitesSuplente1.Text = valores(conta).nombreCompleto
                VComites.TextBoxTipo_ComiteSuplente1.Text = valores(conta).ocupacion
                VComites.TextBoxComiteMenorSupl1.Text = valores(conta).menor
                VComites.DateTimePickerFechaRige_ComiteSuplente1.Text = valores(conta).fechaRige
                VComites.DateTimePickerFechaVence_ComiteSuplente1.Text = valores(conta).fechaVence
                VComites.TextBoxID_ComiteSuplente1.Text = valores(conta).cedual

            ElseIf valores(conta).tipo = "suplente2" Then
                VComites.TextBoxComitesSuplente2.Text = valores(conta).nombreCompleto
                VComites.TextBoxTipo_ComiteSuplente2.Text = valores(conta).ocupacion
                VComites.TextBoxComiteMenorSupl2.Text = valores(conta).menor
                VComites.DateTimePickerFechaRige_ComiteSuplente2.Text = valores(conta).fechaRige
                VComites.DateTimePickerFechaVence_ComiteSuplente2.Text = valores(conta).fechaVence
                VComites.TextBoxID_ComiteSuplente2.Text = valores(conta).cedual
            End If
            conta = conta + 1
        End While
    End Sub

    Public Sub consultar(ByVal nombreComite As String)
        Dim valores As List(Of ComiteClase)

        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeUnComite(nombreComite)

            If valores.Count <> 0 Then
                llenarDatos(valores)
            End If

            BD.CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
        End Try

    End Sub

    Public Sub buscar(ByVal tipo As String)
        Dim valores As List(Of String)
        Dim cedula As String = ""

        If tipo = "presidente" Then
            cedula = VComites.TextBoxID_ComitePresidente.Text
        ElseIf tipo = "vicePresidente" Then
            cedula = VComites.TextBoxID_ComiteVicePresidente.Text
        ElseIf tipo = "secretaria" Then
            cedula = VComites.TextBoxID_ComiteSecretaria.Text
        ElseIf tipo = "vocal1" Then
            cedula = VComites.TextBoxID_ComiteVocal1.Text
        ElseIf tipo = "vocal2" Then
            cedula = VComites.TextBoxID_ComiteVocal2.Text
        ElseIf tipo = "suplente1" Then
            cedula = VComites.TextBoxID_ComiteSuplente1.Text
        ElseIf tipo = "suplente2" Then
            cedula = VComites.TextBoxID_ComiteSuplente2.Text
        End If

        If (cedula = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                valores = BD.buscarSocio(cedula)
                If valores.Count <> 0 And tipo = "presidente" Then
                    VComites.TextBoxComitesPresidente.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    VComites.TextBoxTipo_comitePresidente.Text = valores.Item(12)
                    VComites.TextBoxComiteMenorPresi.Text = valores.Item(18)
                ElseIf valores.Count <> 0 And tipo = "vicePresidente" Then
                    VComites.TextBoxComitesVicepresidente.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    VComites.TextBoxTipo_ComiteVicePresidente.Text = valores.Item(12)
                    VComites.TextBoxComiteMenorViceP.Text = valores.Item(18)
                ElseIf valores.Count <> 0 And tipo = "secretaria" Then
                    VComites.TextBoxComitesSecretaria.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    VComites.TextBoxTipo_ComiteSecretaria.Text = valores.Item(12)
                    VComites.TextBoxComiteMenorSec.Text = valores.Item(18)
                ElseIf valores.Count <> 0 And tipo = "vocal1" Then
                    VComites.TextBoxComitesVocal1.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    VComites.TextBoxTipo_ComiteVocal1.Text = valores.Item(12)
                    VComites.TextBoxComiteMenorVoc1.Text = valores.Item(18)
                ElseIf valores.Count <> 0 And tipo = "vocal2" Then
                    VComites.TextBoxComitesVocal2.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    VComites.TextBoxTipo_ComiteVocal2.Text = valores.Item(12)
                    VComites.TextBoxComiteMenorVoc2.Text = valores.Item(18)
                ElseIf valores.Count <> 0 And tipo = "suplente1" Then
                    VComites.TextBoxComitesSuplente1.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    VComites.TextBoxTipo_ComiteSuplente1.Text = valores.Item(12)
                    VComites.TextBoxComiteMenorSupl1.Text = valores.Item(18)
                ElseIf valores.Count <> 0 And tipo = "suplente2" Then
                    VComites.TextBoxComitesSuplente2.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    VComites.TextBoxTipo_ComiteSuplente2.Text = valores.Item(12)
                    VComites.TextBoxComiteMenorSupl2.Text = valores.Item(18)
                Else
                    MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                End If

                BD.CerrarConexion()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
            End Try
        End If
    End Sub


End Class
