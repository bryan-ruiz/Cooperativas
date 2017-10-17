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
                    MessageBox.Show(variablesGlobales.errorDe + ex.ToString)

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
                    MessageBox.Show(variablesGlobales.errorDe + ex.ToString)

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
                    Dim insertado As Integer = BD.insertarSocio(cedula + "-" + cedula2 + "-" + cedula3, numAsociado, nombre, apellidoUno, apellidoDos, fechaNacimiento, telefono + telefono2, cuota, responsable, beneficiario,
                                                                fechaIngreso, seccion, especialidad, direccion, genero, estado, fechaRetiro, notasRetiro, menor)

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

        If (cedula = "" Or numAsociado = "" Or nombre = "" Or apellidoUno = "" Or apellidoDos = "" Or telefono = "" Or telefono2 = "" Or cuota = "" Or responsable = "" Or beneficiario = "" Or seccion = "" Or especialidad = "" Or direccion = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                Dim modificado = BD.actualizarSocio(cedulaTotal, numAsociado, nombre, apellidoUno, apellidoDos, fechaNacimiento, telefonoTotal, cuota, responsable, beneficiario, fechaIngreso, seccion, especialidad,
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
                MessageBox.Show(variablesGlobales.errorDe + ex.ToString())
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
            MessageBox.Show(variablesGlobales.errorDe + ex.ToString)
        End Try
    End Sub

End Class
