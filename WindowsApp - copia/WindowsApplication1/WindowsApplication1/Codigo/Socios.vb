﻿Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Socios

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'consulta un asociado
    Public Sub consultarAsociado()

        Dim valores As List(Of String)
        Dim cedula As String = VAsociados.TextBoxSociosCedula.Text
        Dim cedula2 As String = VAsociados.TextBoxSociosCedula2.Text
        Dim cedula3 As String = VAsociados.TextBoxSociosCedula3.Text
        Dim numAsociado As String = VAsociados.TextBoxSociosNumAsociado.Text
        Dim cedulaTotal As String = cedula + "-" + cedula2 + "-" + cedula3
        Dim consultarAsociado As String = VAsociados.TextBoxSociosConsultarAsociado.Text


        If (consultarAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
            Else
                Try
                    BD.ConectarBD()

                    valores = BD.consultarAsociadoCedOrNum(consultarAsociado)

                    If valores.Count <> 0 Then

                        Dim myCedula As String = valores(0)
                        Dim parts As String() = myCedula.Split(New Char() {"-"c})
                        'Dim part As String

                        'For Each part In parts
                        'MessageBox.Show("partes de cedula son :" + part(0))
                        'Next

                        VAsociados.TextBoxSociosCedula.Text = parts(0)
                        VAsociados.TextBoxSociosCedula2.Text = parts(1)
                        VAsociados.TextBoxSociosCedula3.Text = parts(2)
                        VAsociados.TextBoxSociosNumAsociado.Text = valores(1)
                        VAsociados.TextBoxSociosNombre.Text = valores.Item(2)
                        VAsociados.TextBoxSocios1erApellido.Text = valores.Item(3)
                        VAsociados.TextBoxSocios2doApellido.Text = valores.Item(4)
                        VAsociados.DateTimeSociosFechaNacimiento.Value = Date.Parse(valores.Item(5))

                        Dim tel As String = valores(6)
                        Dim telefonos As String() = tel.Split(New Char() {"-"c})
                        VAsociados.TextBoxSociosTelefono.Text = telefonos(0)
                        VAsociados.TextBoxSociosTelefono2.Text = telefonos(1)

                        VAsociados.TextBoxSociosCuotaMatricula.Text = valores.Item(7)
                        VAsociados.TextBoxSociosResponsable.Text = valores.Item(8)
                        VAsociados.TextBoxSociosBeneficiario.Text = valores.Item(9)
                        VAsociados.DateTimeSociosFechaIngreso.Value = Date.Parse(valores.Item(10))
                    ' VAsociados.TextBoxSociosSeccion.Text = valores.Item(11)

                    Dim sec As String = valores(11)
                    Dim secciones As String() = sec.Split(New Char() {"-"c})
                    VAsociados.TextBoxSociosSeccion.Text = secciones(0)
                    VAsociados.TextBoxSociosSeccion2.Text = secciones(1)

                    VAsociados.TextBoxSociosOcupacionEspecialidad.Text = valores.Item(12)
                        VAsociados.TextBoxSociosDireccion.Text = valores.Item(13)

                        'Para Genero
                        If valores.Item(14).Equals("Masculino") Then
                            VAsociados.RadioButtonSociosMasculino.Checked = True
                            VAsociados.RadioButtonSociosFemenino.Checked = False
                        End If
                        If valores.Item(14).Equals("Femenino") Then
                            VAsociados.RadioButtonSociosFemenino.Checked = True
                            VAsociados.RadioButtonSociosMasculino.Checked = False
                        End If
                        'Para Estado
                        If valores.Item(15).Equals("Activo") Then
                            VAsociados.RadioButtonSociosActivo.Checked = True
                            VAsociados.RadioButtonSociosRetirado.Checked = False
                        End If
                        If valores.Item(15).Equals("Retirado") Then
                            VAsociados.RadioButtonSociosActivo.Checked = False
                            VAsociados.RadioButtonSociosRetirado.Checked = True
                        End If
                    If (Convert.ToString(valores.Item(18))).Equals("No") Then
                        VAsociados.RadioButtonSociosMenorNo.Checked = True
                        VAsociados.RadioButtonSociosMenorSi.Checked = False
                    End If
                    If (Convert.ToString(valores.Item(18))).Equals("Si") Then
                        VAsociados.RadioButtonSociosMenorSi.Checked = True
                        VAsociados.RadioButtonSociosMenorNo.Checked = False
                    End If
                    VAsociados.DateTimeSociosFechaRetiro.Value = Date.Parse(valores.Item(16))
                    VAsociados.TextBoxSociosNotasRetiro.Text = valores.Item(17).ToString()

                Else
                        MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        limpiar()
                    End If

                    BD.CerrarConexion()

                Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)

            End Try
            End If

    End Sub

    'consulta ' NOT BEING USED
    Public Sub consultar()

        Dim valores As List(Of String)
        Dim cedula As String = VAsociados.TextBoxSociosCedula.Text
        Dim cedula2 As String = VAsociados.TextBoxSociosCedula2.Text
        Dim cedula3 As String = VAsociados.TextBoxSociosCedula3.Text
        Dim numAsociado As String = VAsociados.TextBoxSociosNumAsociado.Text
        Dim cedulaTotal As String = cedula + "-" + cedula2 + "-" + cedula3
        Dim consultarAsociado As String = VAsociados.TextBoxSociosConsultarAsociado.Text

        If (cedula2.Length < 4 Or cedula3.Length < 4) Then
            MessageBox.Show(variablesGlobales.mensajeCedulaFormato, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
        Else
            If (consultarAsociado = "") Then
                MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                limpiar()
            Else
                Try
                    BD.ConectarBD()

                    If (numAsociado = "" And cedula <> "" And cedula2 <> "" And cedula3 <> "") Then
                        valores = BD.consultarSocioPorCedula(cedulaTotal)
                    End If

                    If (numAsociado <> "" And cedula <> "" And cedula2 <> "" And cedula3 <> "") Then
                        valores = BD.consultarSocioPorCedula(numAsociado)
                    End If

                    If (cedula = "" And cedula2 = "" And cedula3 = "" And numAsociado <> "") Then
                        valores = BD.consultarSocioPorNumAsociado(numAsociado)
                    End If

                    If valores.Count <> 0 Then

                        Dim myCedula As String = valores(0)
                        Dim parts As String() = myCedula.Split(New Char() {"-"c})
                        'Dim part As String

                        'For Each part In parts
                        'MessageBox.Show("partes de cedula son :" + part(0))
                        'Next

                        VAsociados.TextBoxSociosCedula.Text = parts(0)
                        VAsociados.TextBoxSociosCedula2.Text = parts(1)
                        VAsociados.TextBoxSociosCedula3.Text = parts(2)
                        VAsociados.TextBoxSociosNumAsociado.Text = valores(1)
                        VAsociados.TextBoxSociosNombre.Text = valores.Item(2)
                        VAsociados.TextBoxSocios1erApellido.Text = valores.Item(3)
                        VAsociados.TextBoxSocios2doApellido.Text = valores.Item(4)
                        VAsociados.DateTimeSociosFechaNacimiento.Value = Date.Parse(valores.Item(5))

                        Dim tel As String = valores(6)
                        Dim telefonos As String() = tel.Split(New Char() {"-"c})
                        VAsociados.TextBoxSociosTelefono.Text = telefonos(0)
                        VAsociados.TextBoxSociosTelefono2.Text = telefonos(1)

                        VAsociados.TextBoxSociosCuotaMatricula.Text = valores.Item(7)
                        VAsociados.TextBoxSociosResponsable.Text = valores.Item(8)
                        VAsociados.TextBoxSociosBeneficiario.Text = valores.Item(9)
                        VAsociados.DateTimeSociosFechaIngreso.Value = Date.Parse(valores.Item(10))
                        VAsociados.TextBoxSociosSeccion.Text = valores.Item(11)
                        VAsociados.TextBoxSociosOcupacionEspecialidad.Text = valores.Item(12)
                        VAsociados.TextBoxSociosDireccion.Text = valores.Item(13)

                        'Para Genero
                        If valores.Item(14).Equals("Masculino") Then
                            VAsociados.RadioButtonSociosMasculino.Checked = True
                            VAsociados.RadioButtonSociosFemenino.Checked = False
                        End If
                        If valores.Item(14).Equals("Femenino") Then
                            VAsociados.RadioButtonSociosFemenino.Checked = True
                            VAsociados.RadioButtonSociosMasculino.Checked = False
                        End If
                        'Para Estado
                        If valores.Item(15).Equals("Activo") Then
                            VAsociados.RadioButtonSociosActivo.Checked = True
                            VAsociados.RadioButtonSociosRetirado.Checked = False
                        End If
                        If valores.Item(15).Equals("Retirado") Then
                            VAsociados.RadioButtonSociosActivo.Checked = False
                            VAsociados.RadioButtonSociosRetirado.Checked = True
                        End If
                        If valores.Item(18).Equals("No") Then
                            VAsociados.RadioButtonSociosMenorNo.Checked = True
                            VAsociados.RadioButtonSociosMenorSi.Checked = False
                        End If
                        If valores.Item(18).Equals("Si") Then
                            VAsociados.RadioButtonSociosMenorSi.Checked = True
                            VAsociados.RadioButtonSociosMenorNo.Checked = False
                        End If
                        VAsociados.DateTimeSociosFechaRetiro.Value = Date.Parse(valores.Item(16))
                        VAsociados.TextBoxSociosNotasRetiro.Text = valores.Item(17)

                    Else
                        MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        limpiar()
                    End If

                    BD.CerrarConexion()

                Catch ex As Exception
                    MessageBox.Show(variablesGlobales.errorDe + ex.Message)

                End Try
            End If
        End If
    End Sub

    'Insertar Socio
    Public Sub insertar()
        Dim cedula As String = VAsociados.TextBoxSociosCedula.Text
        Dim cedula2 As String = VAsociados.TextBoxSociosCedula2.Text
        Dim cedula3 As String = VAsociados.TextBoxSociosCedula3.Text
        Dim numAsociado As String = VAsociados.TextBoxSociosNumAsociado.Text
        Dim nombre As String = VAsociados.TextBoxSociosNombre.Text
        Dim apellidoUno As String = VAsociados.TextBoxSocios1erApellido.Text
        Dim apellidoDos As String = VAsociados.TextBoxSocios2doApellido.Text
        Dim fechaNacimiento As Date = VAsociados.DateTimeSociosFechaNacimiento.Value.ToString("dd/MM/yyyy")
        Dim telefono As String = VAsociados.TextBoxSociosTelefono.Text
        Dim telefono2 As String = VAsociados.TextBoxSociosTelefono2.Text
        Dim cuota As String = VAsociados.TextBoxSociosCuotaMatricula.Text
        Dim responsable As String = VAsociados.TextBoxSociosResponsable.Text
        Dim beneficiario As String = VAsociados.TextBoxSociosBeneficiario.Text
        Dim fechaIngreso As Date = VAsociados.DateTimeSociosFechaIngreso.Value.ToString("dd/MM/yyyy")
        Dim seccion As String = VAsociados.TextBoxSociosSeccion.Text
        Dim seccion2 As String = VAsociados.TextBoxSociosSeccion2.Text
        Dim especialidad As String = VAsociados.TextBoxSociosOcupacionEspecialidad.Text
        Dim direccion As String = VAsociados.TextBoxSociosDireccion.Text
        Dim genero As String = ""
        Dim estado As String = ""
        Dim fechaRetiro As Date = VAsociados.DateTimeSociosFechaRetiro.Value.ToString("dd/MM/yyyy")
        Dim notasRetiro As String = VAsociados.TextBoxSociosNotasRetiro.Text
        Dim menor As String = ""

        'Para el genero
        If (VAsociados.RadioButtonSociosMasculino.Checked = True) Then
            genero = VAsociados.RadioButtonSociosMasculino.Text
        Else
            genero = VAsociados.RadioButtonSociosFemenino.Text
        End If

        'Para ver si es menor
        If (VAsociados.RadioButtonSociosMenorNo.Checked = True) Then
            menor = VAsociados.RadioButtonSociosMenorNo.Text
        Else
            menor = VAsociados.RadioButtonSociosMenorSi.Text
        End If
        'Para el estado
        If (VAsociados.RadioButtonSociosActivo.Checked = True) Then
            estado = VAsociados.RadioButtonSociosActivo.Text
        Else
            estado = VAsociados.RadioButtonSociosRetirado.Text
        End If

        If (cedula2.Length < 4 Or cedula3.Length < 4) Then
            MessageBox.Show(variablesGlobales.mensajeCedulaFormato, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
        Else
            If (cedula = "" Or cedula2 = "" Or cedula3 = "" Or numAsociado = "" Or nombre = "" Or apellidoUno = "" Or apellidoDos = "" Or telefono = "" Or cuota = "" Or responsable = "" Or beneficiario = "" Or seccion = "" Or especialidad = "" Or direccion = "") Then
                MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Else
                Try
                    BD.ConectarBD()
                    Dim insertado As Integer = BD.insertarSocio(cedula + "-" + cedula2 + "-" + cedula3, numAsociado, nombre, apellidoUno, apellidoDos, fechaNacimiento,
                                                                telefono + "-" + telefono2, cuota, responsable, beneficiario, fechaIngreso,
                                                                seccion + "-" + seccion2, especialidad, direccion, genero, estado, fechaRetiro, notasRetiro, menor)

                    Dim certificadoXSocio As Integer = BD.insertarCertificadoXSocio(cedula + "-" + cedula2 + "-" + cedula3, numAsociado, "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0")

                    If (insertado = 1 And certificadoXSocio = 1) Then
                        MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        limpiar()
                    Else
                        MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        limpiar()
                    End If
                    'Muy importante cerrar conexion despues de cada consulta'
                    BD.CerrarConexion()
                Catch ex As Exception
                    MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    limpiar()
                End Try
            End If
        End If
    End Sub

    'Actualizar Info de Socios'
    Public Sub actualizar()

        Dim cedula As String = VAsociados.TextBoxSociosCedula.Text
        Dim cedula2 As String = VAsociados.TextBoxSociosCedula2.Text
        Dim cedula3 As String = VAsociados.TextBoxSociosCedula3.Text
        Dim cedulaTotal As String = cedula + "-" + cedula2 + "-" + cedula3
        Dim telefono As String = VAsociados.TextBoxSociosTelefono.Text
        Dim telefono2 As String = VAsociados.TextBoxSociosTelefono2.Text
        Dim telefonoTotal As String = telefono + "-" + telefono2
        Dim numAsociado As String = VAsociados.TextBoxSociosNumAsociado.Text
        Dim nombre As String = VAsociados.TextBoxSociosNombre.Text
        Dim apellidoUno As String = VAsociados.TextBoxSocios1erApellido.Text
        Dim apellidoDos As String = VAsociados.TextBoxSocios2doApellido.Text
        Dim fechaNacimiento As Date = VAsociados.DateTimeSociosFechaNacimiento.Value.ToString("dd/MM/yyyy")
        Dim cuota As String = VAsociados.TextBoxSociosCuotaMatricula.Text
        Dim responsable As String = VAsociados.TextBoxSociosResponsable.Text
        Dim beneficiario As String = VAsociados.TextBoxSociosBeneficiario.Text
        Dim fechaIngreso As Date = VAsociados.DateTimeSociosFechaIngreso.Value.ToString("dd/MM/yyyy")
        Dim seccion As String = VAsociados.TextBoxSociosSeccion.Text
        Dim seccion2 As String = VAsociados.TextBoxSociosSeccion2.Text
        Dim seccionTotal As String = seccion + "-" + seccion2
        Dim especialidad As String = VAsociados.TextBoxSociosOcupacionEspecialidad.Text
        Dim direccion As String = VAsociados.TextBoxSociosDireccion.Text
        Dim genero As String = ""
        Dim estado As String = ""
        Dim menor As String = ""
        Dim fechaRetiro As Date = VAsociados.DateTimeSociosFechaRetiro.Value.ToString("dd/MM/yyyy")
        Dim notasRetiro As String = VAsociados.TextBoxSociosNotasRetiro.Text

        'Para el genero
        If (VAsociados.RadioButtonSociosMasculino.Checked = True) Then
            genero = VAsociados.RadioButtonSociosMasculino.Text
        Else
            genero = VAsociados.RadioButtonSociosFemenino.Text
        End If
        'Para ver si es menor
        If (VAsociados.RadioButtonSociosMenorNo.Checked = True) Then
            menor = VAsociados.RadioButtonSociosMenorNo.Text
        Else
            menor = VAsociados.RadioButtonSociosMenorSi.Text
        End If
        'Para el estado
        If (VAsociados.RadioButtonSociosActivo.Checked = True) Then
            estado = VAsociados.RadioButtonSociosActivo.Text
        Else
            estado = VAsociados.RadioButtonSociosRetirado.Text
        End If

        If (cedula = "" Or cedula2 = "" Or cedula3 = "" Or numAsociado = "" Or nombre = "" Or apellidoUno = "" Or apellidoDos = "" Or telefono = "" Or telefono2 = "" Or cuota = "" Or responsable = "" Or beneficiario = "" Or seccion = "" Or seccion2 = "" Or especialidad = "" Or direccion = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                Dim modificado = BD.actualizarSocio(cedulaTotal, numAsociado, nombre, apellidoUno, apellidoDos, fechaNacimiento, telefonoTotal, cuota, responsable, beneficiario, fechaIngreso, seccionTotal, especialidad,
                                                    direccion, genero, estado, fechaRetiro, notasRetiro, menor)
                If modificado = 1 Then
                    MessageBox.Show(variablesGlobales.datosActualizadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    limpiar()
                Else
                    MessageBox.Show(variablesGlobales.errorActualizandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    limpiar()
                End If
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message())
            End Try
        End If
    End Sub

    'Limpia los campos de Socios'
    Public Sub limpiar()
        VAsociados.TextBoxSociosCedula.Text = ""
        VAsociados.TextBoxSociosCedula2.Text = ""
        VAsociados.TextBoxSociosCedula3.Text = ""
        VAsociados.TextBoxSociosNumAsociado.Text = ""
        VAsociados.TextBoxSociosNombre.Text = ""
        VAsociados.TextBoxSocios1erApellido.Text = ""
        VAsociados.TextBoxSocios2doApellido.Text = ""
        VAsociados.TextBoxSociosTelefono.Text = ""
        VAsociados.TextBoxSociosTelefono2.Text = ""
        VAsociados.TextBoxSociosCuotaMatricula.Text = ""
        VAsociados.TextBoxSociosResponsable.Text = ""
        VAsociados.TextBoxSociosBeneficiario.Text = ""
        VAsociados.TextBoxSociosSeccion.Text = ""
        VAsociados.TextBoxSociosSeccion2.Text = ""
        VAsociados.TextBoxSociosOcupacionEspecialidad.Text = ""
        VAsociados.TextBoxSociosDireccion.Text = ""
        VAsociados.TextBoxSociosNotasRetiro.Text = ""
        VAsociados.TextBoxSociosConsultarAsociado.Text = ""
    End Sub

    'Recibe Activos o Todos, como parámetro para el tipo de reporte de asociados
    Public Sub generarReporte(ByVal tipoReport As String)
        generarReporteDeSocios(tipoReport)
    End Sub

    'Genera un reporte de los Socios en PDF'
    Private Sub generarReporteDeSocios(ByVal tipoReporte As String)
        Try
            Dim valores As List(Of SocioClase)
            BD.ConectarBD()
            valores = BD.obtenerDatosReporteDeSocios(tipoReporte)
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reporteSocios.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)
            Dim contador As Integer = 0
            Dim conta As Integer = 0
            While contador < valores.Count
                If conta = 2 Then
                    pdfDoc.NewPage()
                    encabezado.encabezado(pdfWrite, pdfDoc)
                    conta = 0
                End If
                conta = conta + 1

                Dim FontStype = FontFactory.GetFont("Arial", 9, Font.NORMAL)

                pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
                pdfDoc.Add(New Paragraph("Cédula:   " + valores(contador).cedula, FontStype))
                pdfDoc.Add(New Paragraph("Num. Asociado:    " + valores(contador).numAsoc, FontStype))
                pdfDoc.Add(New Paragraph("Nombre completo:  " + valores(contador).nombre + " " + valores(contador).primerApellido + " " + valores(contador).segundoApellido, FontStype))
                pdfDoc.Add(New Paragraph("Fecha de nacimiento:  " + valores(contador).fechaNacimineto, FontStype))
                pdfDoc.Add(New Paragraph("Teléfono: " + valores(contador).telefono, FontStype))
                pdfDoc.Add(New Paragraph("Responsable:  " + valores(contador).responsable, FontStype))
                pdfDoc.Add(New Paragraph("Beneficiario: " + valores(contador).beneficiario, FontStype))
                pdfDoc.Add(New Paragraph("Fecha de ingreso: " + valores(contador).fechaIngreso, FontStype))
                pdfDoc.Add(New Paragraph("Sección:  " + valores(contador).seccion, FontStype))
                pdfDoc.Add(New Paragraph("Ocupación/Especialidad:   " + valores(contador).ocupacionEspecialidad, FontStype))
                pdfDoc.Add(New Paragraph("Dirección:    " + valores(contador).direccion, FontStype))
                pdfDoc.Add(New Paragraph("Género:   " + valores(contador).genero, FontStype))
                pdfDoc.Add(New Paragraph("Estado:   " + valores(contador).estado, FontStype))
                pdfDoc.Add(New Paragraph("Cuota de matrícula:   " + valores(contador).cuotaMatricula, FontStype))

                contador = contador + 1

            End While

            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub

    'Genera un reporte de los Socios en PDF'
    Public Sub generarReporteDeSociosResumido(ByVal tipoReporte As String)
        Try
            Dim valores As List(Of SocioClase)
            BD.ConectarBD()
            valores = BD.obtenerDatosReporteDeSocios(tipoReporte)
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)

            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reporteAsociadosActivos.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)

            Dim table As PdfPTable = New PdfPTable(9)

            '' PARA ENCABEZADO DEL REPORTE - COLUMNAS

            Dim numAsociadoR As PdfPCell = New PdfPCell(New Phrase("N° Asociado", FontStype))
            numAsociadoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            numAsociadoR.Colspan = 1
            numAsociadoR.HorizontalAlignment = 1

            Dim nombreR As PdfPCell = New PdfPCell(New Phrase("Nombre Completo", FontStype))
            nombreR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            nombreR.Colspan = 2
            nombreR.HorizontalAlignment = 1

            Dim cedulaR As PdfPCell = New PdfPCell(New Phrase("N° Identificación", FontStype))
            cedulaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            cedulaR.Colspan = 1
            cedulaR.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

            Dim fechaIngresoR As PdfPCell = New PdfPCell(New Phrase("Fecha Ingreso", FontStype))
            fechaIngresoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            fechaIngresoR.Colspan = 1
            fechaIngresoR.HorizontalAlignment = 1

            Dim calidadR As PdfPCell = New PdfPCell(New Phrase("Calidad", FontStype))
            calidadR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            calidadR.Colspan = 1
            calidadR.HorizontalAlignment = 1

            Dim nivelR As PdfPCell = New PdfPCell(New Phrase("Nivel", FontStype))
            nivelR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            nivelR.Colspan = 1
            nivelR.HorizontalAlignment = 1

            Dim cuotaAdminR As PdfPCell = New PdfPCell(New Phrase("Cuota Admisión", FontStype))
            cuotaAdminR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            cuotaAdminR.Colspan = 1
            cuotaAdminR.HorizontalAlignment = 1

            Dim estadoR As PdfPCell = New PdfPCell(New Phrase("Estado", FontStype))
            estadoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            estadoR.Colspan = 1
            estadoR.HorizontalAlignment = 1

            Dim fechaRetiroR As PdfPCell = New PdfPCell(New Phrase("Fecha Retiro", FontStype))
            fechaRetiroR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            fechaRetiroR.Colspan = 1
            fechaRetiroR.HorizontalAlignment = 1

            table.AddCell(numAsociadoR)
            table.AddCell(nombreR)
            table.AddCell(cedulaR)
            table.AddCell(fechaIngresoR)
            table.AddCell(calidadR)
            table.AddCell(nivelR)
            table.AddCell(cuotaAdminR)
            table.AddCell(estadoR)

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

                Dim numAsociadoT As PdfPCell = New PdfPCell(New Phrase(valores(contador).numAsoc, FontStype2))
                numAsociadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                numAsociadoT.Colspan = 1
                numAsociadoT.HorizontalAlignment = 1

                Dim nombreTotal As String = valores(contador).nombre + " " + valores(contador).primerApellido + " " + valores(contador).segundoApellido
                Dim nombreT As PdfPCell = New PdfPCell(New Phrase(nombreTotal, FontStype2))
                nombreT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                nombreT.Colspan = 2
                nombreT.HorizontalAlignment = 1

                Dim cedulaTotalT As PdfPCell = New PdfPCell(New Phrase(valores(contador).cedula, FontStype2))
                cedulaTotalT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                cedulaTotalT.Colspan = 1
                cedulaTotalT.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

                Dim fechaIngresoT As PdfPCell = New PdfPCell(New Phrase(valores(contador).fechaIngreso, FontStype2))
                fechaIngresoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                fechaIngresoT.Colspan = 1
                fechaIngresoT.HorizontalAlignment = 1

                Dim calidadT As PdfPCell = New PdfPCell(New Phrase(valores(contador).ocupacionEspecialidad, FontStype2))
                calidadT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                calidadT.Colspan = 1
                calidadT.HorizontalAlignment = 1

                Dim seccionT As PdfPCell = New PdfPCell(New Phrase(valores(contador).seccion, FontStype2))
                seccionT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                seccionT.Colspan = 1
                seccionT.HorizontalAlignment = 1

                Dim cuotaT As PdfPCell = New PdfPCell(New Phrase(valores(contador).cuotaMatricula, FontStype2))
                cuotaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                cuotaT.Colspan = 1
                cuotaT.HorizontalAlignment = 1

                Dim estadoT As PdfPCell = New PdfPCell(New Phrase(valores(contador).estado, FontStype2))
                estadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                estadoT.Colspan = 1
                estadoT.HorizontalAlignment = 1

                table.AddCell(numAsociadoT)
                table.AddCell(nombreT)
                table.AddCell(cedulaTotalT)
                table.AddCell(fechaIngresoT)
                table.AddCell(calidadT)
                table.AddCell(seccionT)
                table.AddCell(cuotaT)
                table.AddCell(estadoT)

                contador = contador + 1

            End While

            pdfDoc.Add(table)

            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub


    'Genera un reporte de los Socios en PDF'
    Public Sub generarReporteDeSociosResumidoTodos(ByVal tipoReporte As String)
        Try
            Dim valores As List(Of SocioClase)
            BD.ConectarBD()
            valores = BD.obtenerDatosReporteDeSocios(tipoReporte)
            BD.CerrarConexion()

            If Not Directory.Exists(variablesGlobales.folderPath) Then
                Directory.CreateDirectory(variablesGlobales.folderPath)
            End If

            'Margin of the Doc
            Dim pdfDoc As New Document(PageSize.A4, 0, 1, 50, 1)

            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reporteTodosLosAsociados.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezado.consultarDatos()
            encabezado.encabezado(pdfWrite, pdfDoc)

            Dim FontStype = FontFactory.GetFont("Arial", 7, Font.BOLD, BaseColor.WHITE)

            Dim table As PdfPTable = New PdfPTable(10)

            'ESTABLECE TAMAÑO DE ANCHO DE COLUMNAS
            Dim intTblWidth() As Integer = {7, 12, 12, 10, 9, 8, 7, 7, 7, 8}
            table.SetWidths(intTblWidth)

            '' PARA ENCABEZADO DEL REPORTE - COLUMNAS

            Dim numAsociadoR As PdfPCell = New PdfPCell(New Phrase("N° Asociado", FontStype))
            numAsociadoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            numAsociadoR.Colspan = 1
            numAsociadoR.HorizontalAlignment = 1

            Dim nombreR As PdfPCell = New PdfPCell(New Phrase("Nombre Completo", FontStype))
            nombreR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            nombreR.Colspan = 2
            nombreR.HorizontalAlignment = 1

            Dim cedulaR As PdfPCell = New PdfPCell(New Phrase(" N° Identificación", FontStype))
            cedulaR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            cedulaR.Colspan = 1
            cedulaR.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right


            Dim fechaIngresoR As PdfPCell = New PdfPCell(New Phrase("Fecha Ingreso", FontStype))
            fechaIngresoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            fechaIngresoR.Colspan = 1
            fechaIngresoR.HorizontalAlignment = 1

            Dim calidadR As PdfPCell = New PdfPCell(New Phrase("Calidad", FontStype))
            calidadR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            calidadR.Colspan = 1
            calidadR.HorizontalAlignment = 1

            Dim nivelR As PdfPCell = New PdfPCell(New Phrase("Nivel", FontStype))
            nivelR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            nivelR.Colspan = 1
            nivelR.HorizontalAlignment = 1

            Dim cuotaAdminR As PdfPCell = New PdfPCell(New Phrase("Cuota Admisión", FontStype))
            cuotaAdminR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            cuotaAdminR.Colspan = 1
            cuotaAdminR.HorizontalAlignment = 1

            Dim estadoR As PdfPCell = New PdfPCell(New Phrase("Estado", FontStype))
            estadoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            estadoR.Colspan = 1
            estadoR.HorizontalAlignment = 1

            Dim fechaRetiroR As PdfPCell = New PdfPCell(New Phrase("Fecha Retiro", FontStype))
            fechaRetiroR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
            fechaRetiroR.Colspan = 1
            fechaRetiroR.HorizontalAlignment = 1

            table.AddCell(numAsociadoR)
            table.AddCell(nombreR)
            table.AddCell(cedulaR)
            table.AddCell(fechaIngresoR)
            table.AddCell(calidadR)
            table.AddCell(nivelR)
            table.AddCell(cuotaAdminR)
            table.AddCell(estadoR)
            table.AddCell(fechaRetiroR)

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

                Dim numAsociadoT As PdfPCell = New PdfPCell(New Phrase(valores(contador).numAsoc, FontStype2))
                numAsociadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                numAsociadoT.Colspan = 1
                numAsociadoT.HorizontalAlignment = 1

                Dim nombreTotal As String = valores(contador).nombre + " " + valores(contador).primerApellido + " " + valores(contador).segundoApellido
                Dim nombreT As PdfPCell = New PdfPCell(New Phrase(nombreTotal, FontStype2))
                nombreT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                nombreT.Colspan = 2
                nombreT.HorizontalAlignment = 1

                Dim cedulaTotalT As PdfPCell = New PdfPCell(New Phrase(valores(contador).cedula, FontStype2))
                cedulaTotalT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                cedulaTotalT.Colspan = 1
                cedulaTotalT.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

                Dim fechaIngresoT As PdfPCell = New PdfPCell(New Phrase(valores(contador).fechaIngreso, FontStype2))
                fechaIngresoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                fechaIngresoT.Colspan = 1
                fechaIngresoT.HorizontalAlignment = 1

                Dim calidadT As PdfPCell = New PdfPCell(New Phrase(valores(contador).ocupacionEspecialidad, FontStype2))
                calidadT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                calidadT.Colspan = 1
                calidadT.HorizontalAlignment = 1

                Dim seccionT As PdfPCell = New PdfPCell(New Phrase(valores(contador).seccion, FontStype2))
                seccionT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                seccionT.Colspan = 1
                seccionT.HorizontalAlignment = 1

                Dim cuotaT As PdfPCell = New PdfPCell(New Phrase(valores(contador).cuotaMatricula, FontStype2))
                cuotaT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                cuotaT.Colspan = 1
                cuotaT.HorizontalAlignment = 1

                Dim estadoT As PdfPCell = New PdfPCell(New Phrase(valores(contador).estado, FontStype2))
                estadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                estadoT.Colspan = 1
                estadoT.HorizontalAlignment = 1

                Dim fechaRetiroT As PdfPCell = New PdfPCell(New Phrase(valores(contador).fechaRetiro, FontStype2))
                fechaRetiroT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                fechaRetiroT.Colspan = 1
                fechaRetiroT.HorizontalAlignment = 1

                Dim fechaRetiroNula As PdfPCell = New PdfPCell(New Phrase("", FontStype2))
                fechaRetiroNula.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                fechaRetiroNula.Colspan = 1
                fechaRetiroNula.HorizontalAlignment = 1

                table.AddCell(numAsociadoT)
                table.AddCell(nombreT)
                table.AddCell(cedulaTotalT)
                table.AddCell(fechaIngresoT)
                table.AddCell(calidadT)
                table.AddCell(seccionT)
                table.AddCell(cuotaT)
                table.AddCell(estadoT)

                If (valores(contador).estado.Equals("Activo")) Then
                    table.AddCell(fechaRetiroNula)
                Else
                    table.AddCell(fechaRetiroT)
                End If


                contador = contador + 1



            End While

            pdfDoc.Add(table)

            pdfDoc.Close()

            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)
        End Try
    End Sub


    'Genera un recibo de la info del socio'
    Public Sub imprimirReciboActual()
        Dim cedula As String = VAsociados.TextBoxSociosCedula.Text
        Dim cedula2 As String = VAsociados.TextBoxSociosCedula2.Text
        Dim cedula3 As String = VAsociados.TextBoxSociosCedula3.Text
        Dim cedulaTotal As String = cedula + "-" + cedula2 + "-" + cedula3
        Dim telefono As String = VAsociados.TextBoxSociosTelefono.Text
        Dim telefono2 As String = VAsociados.TextBoxSociosTelefono2.Text
        Dim telefonoTotal As String = telefono + "-" + telefono2
        Dim numAsociado As String = VAsociados.TextBoxSociosNumAsociado.Text
        Dim nombre As String = VAsociados.TextBoxSociosNombre.Text
        Dim apellidoUno As String = VAsociados.TextBoxSocios1erApellido.Text
        Dim apellidoDos As String = VAsociados.TextBoxSocios2doApellido.Text
        Dim fechaNacimiento As Date = VAsociados.DateTimeSociosFechaNacimiento.Value.ToString("dd/MM/yyyy")
        Dim cuota As String = VAsociados.TextBoxSociosCuotaMatricula.Text
        Dim responsable As String = VAsociados.TextBoxSociosResponsable.Text
        Dim beneficiario As String = VAsociados.TextBoxSociosBeneficiario.Text
        Dim fechaIngreso As Date = VAsociados.DateTimeSociosFechaIngreso.Value.ToString("dd/MM/yyyy")
        Dim seccion As String = VAsociados.TextBoxSociosSeccion.Text
        Dim seccion2 As String = VAsociados.TextBoxSociosSeccion2.Text
        Dim seccionTotal As String = seccion + "-" + seccion2
        Dim especialidad As String = VAsociados.TextBoxSociosOcupacionEspecialidad.Text
        Dim direccion As String = VAsociados.TextBoxSociosDireccion.Text
        Dim genero As String = ""
        Dim estado As String = ""
        Dim menor As String = ""
        Dim fechaRetiro As Date = VAsociados.DateTimeSociosFechaRetiro.Value.ToString("dd/MM/yyyy")
        Dim notasRetiro As String = VAsociados.TextBoxSociosNotasRetiro.Text

        If (cedula = "" Or cedula2 = "" Or cedula3 = "" Or numAsociado = "" Or nombre = "" Or apellidoUno = "" Or apellidoDos = "" Or telefono = "" Or telefono2 = "" Or cuota = "" Or responsable = "" Or beneficiario = "" Or seccion = "" Or seccion2 = "" Or especialidad = "" Or direccion = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try

                BD.ConectarBD()
                variablesGlobales.numReciboAsociados = Convert.ToInt32(BD.obtenerReciboXTipo("asociado").Item(0))

                If Not Directory.Exists(variablesGlobales.folderPath) Then
                    Directory.CreateDirectory(variablesGlobales.folderPath)
                End If

                Dim pdfDoc As New Document()
                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(variablesGlobales.folderPath & "reciboAsociado.pdf", FileMode.Create))
                pdfDoc.Open()
                encabezado.consultarDatos()
                encabezado.encabezado(pdfWrite, pdfDoc)


                '/////// Encabezado //////////
                Dim FontStype3 = FontFactory.GetFont("Arial", 8, Font.BOLD, BaseColor.BLACK)
                pdfDoc.Add(New Paragraph("                                                                                                        N° Recibo " + Convert.ToString(variablesGlobales.numReciboAsociados), FontStype3))
                pdfDoc.Add(New Paragraph(" "))

                Dim FontStype = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.WHITE)

                Dim table As PdfPTable = New PdfPTable(5)

                Dim descripcionR As PdfPCell = New PdfPCell(New Phrase("Descripción: ", FontStype))
                descripcionR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                descripcionR.Colspan = 1
                descripcionR.HorizontalAlignment = 1 ' 0 left, 1 center, 2 right

                Dim numAsociadoR As PdfPCell = New PdfPCell(New Phrase("# Asociado: ", FontStype))
                numAsociadoR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                numAsociadoR.Colspan = 1
                numAsociadoR.HorizontalAlignment = 1

                Dim nombreR As PdfPCell = New PdfPCell(New Phrase("Nombre Completo: ", FontStype))
                nombreR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                nombreR.Colspan = 2
                nombreR.HorizontalAlignment = 1

                Dim totalR As PdfPCell = New PdfPCell(New Phrase("Total: ", FontStype))
                totalR.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorEncabezado))
                totalR.Colspan = 1
                totalR.HorizontalAlignment = 1


                Dim FontStype2 = FontFactory.GetFont("Arial", 9, Font.NORMAL, BaseColor.BLACK)

                Dim descripcionT As PdfPCell = New PdfPCell(New Phrase("Recibo de matrícula", FontStype2))
                descripcionT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                descripcionT.Colspan = 1
                descripcionT.HorizontalAlignment = 1
                'descripcionT.FixedHeight = 50.0F

                Dim numAsociadoT As PdfPCell = New PdfPCell(New Phrase(numAsociado, FontStype2))
                numAsociadoT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                numAsociadoT.Colspan = 1
                numAsociadoT.HorizontalAlignment = 1

                Dim nombreTotal As String = nombre + " " + apellidoUno + " " + apellidoDos
                Dim nombreT As PdfPCell = New PdfPCell(New Phrase(nombreTotal, FontStype2))
                nombreT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                nombreT.Colspan = 2
                nombreT.HorizontalAlignment = 1

                Dim subTotalInt As Integer = Convert.ToInt32(cuota)
                Dim totalT As PdfPCell = New PdfPCell(New Phrase("¢ " + subTotalInt.ToString("N"), FontStype2))
                totalT.BackgroundColor = New BaseColor(System.Drawing.ColorTranslator.FromHtml(variablesGlobales.colorLineas))
                totalT.Colspan = 1
                totalT.HorizontalAlignment = 1

                table.AddCell(descripcionR)
                table.AddCell(numAsociadoR)
                table.AddCell(nombreR)
                table.AddCell(totalR)

                table.AddCell(descripcionT)
                table.AddCell(numAsociadoT)
                table.AddCell(nombreT)
                table.AddCell(totalT)

                pdfDoc.Add(table)

                pdfDoc.Add(New Paragraph(" "))
                pdfDoc.Add(New Paragraph(" "))
                pdfDoc.Add(New Paragraph(" "))


                pdfDoc.Add(New Paragraph("                        Firma del Asociado: _________________________________________", FontStype3))
                pdfDoc.Add(New Paragraph(" "))


                pdfDoc.Close()

                MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                'Incrementa el num recibo ingreso en la BD
                BD.actualizarReciboXTipo("asociado", variablesGlobales.numReciboAsociados + 1)

                Print.Show()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)
            End Try
        End If
    End Sub
End Class