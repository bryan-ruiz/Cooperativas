Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Socios

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'consulta un asociado
    Public Sub consultar()

        Dim valores As List(Of String)
        Dim cedula As String = Asociados.TextBoxSociosCedula.Text
        Dim cedula2 As String = Asociados.TextBoxSociosCedula2.Text
        Dim cedula3 As String = Asociados.TextBoxSociosCedula3.Text
        Dim numAsociado As String = Asociados.TextBoxSociosNumAsociado.Text
        Dim cedulaTotal As String = cedula + "-" + cedula2 + "-" + cedula3

        If (cedula2.Length < 4 Or cedula3.Length < 4) Then
            MessageBox.Show(variablesGlobales.mensajeCedulaFormato, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
        Else
            If (cedula = "" Or cedula2 = "" Or cedula3 = "" And numAsociado = "") Then
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

                        Asociados.TextBoxSociosCedula.Text = parts(0)
                        Asociados.TextBoxSociosCedula2.Text = parts(1)
                        Asociados.TextBoxSociosCedula3.Text = parts(2)
                        Asociados.TextBoxSociosNumAsociado.Text = valores(1)
                        Asociados.TextBoxSociosNombre.Text = valores.Item(2)
                        Asociados.TextBoxSocios1erApellido.Text = valores.Item(3)
                        Asociados.TextBoxSocios2doApellido.Text = valores.Item(4)
                        Asociados.DateTimeSociosFechaNacimiento.Value = Date.Parse(valores.Item(5))

                        Dim tel As String = valores(6)
                        Dim telefonos As String() = tel.Split(New Char() {"-"c})
                        Asociados.TextBoxSociosTelefono.Text = telefonos(0)
                        Asociados.TextBoxSociosTelefono2.Text = telefonos(1)

                        Asociados.TextBoxSociosCuotaMatricula.Text = valores.Item(7)
                        Asociados.TextBoxSociosResponsable.Text = valores.Item(8)
                        Asociados.TextBoxSociosBeneficiario.Text = valores.Item(9)
                        Asociados.DateTimeSociosFechaIngreso.Value = Date.Parse(valores.Item(10))
                        Asociados.TextBoxSociosSeccion.Text = valores.Item(11)
                        Asociados.TextBoxSociosOcupacionEspecialidad.Text = valores.Item(12)
                        Asociados.TextBoxSociosDireccion.Text = valores.Item(13)

                        'Para Genero
                        If valores.Item(14).Equals("Masculino") Then
                            Asociados.RadioButtonSociosMasculino.Checked = True
                            Asociados.RadioButtonSociosFemenino.Checked = False
                        End If
                        If valores.Item(14).Equals("Femenino") Then
                            Asociados.RadioButtonSociosFemenino.Checked = True
                            Asociados.RadioButtonSociosMasculino.Checked = False
                        End If
                        'Para Estado
                        If valores.Item(15).Equals("Activo") Then
                            Asociados.RadioButtonSociosActivo.Checked = True
                            Asociados.RadioButtonSociosRetirado.Checked = False
                        End If
                        If valores.Item(15).Equals("Retirado") Then
                            Asociados.RadioButtonSociosActivo.Checked = False
                            Asociados.RadioButtonSociosRetirado.Checked = True
                        End If
                        If valores.Item(18).Equals("No") Then
                            Asociados.RadioButtonSociosMenorNo.Checked = True
                            Asociados.RadioButtonSociosMenorSi.Checked = False
                        End If
                        If valores.Item(18).Equals("Si") Then
                            Asociados.RadioButtonSociosMenorSi.Checked = True
                            Asociados.RadioButtonSociosMenorNo.Checked = False
                        End If
                        Asociados.DateTimeSociosFechaRetiro.Value = Date.Parse(valores.Item(16))
                        Asociados.TextBoxSociosNotasRetiro.Text = valores.Item(17)

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
        Dim cedula As String = Asociados.TextBoxSociosCedula.Text
        Dim cedula2 As String = Asociados.TextBoxSociosCedula2.Text
        Dim cedula3 As String = Asociados.TextBoxSociosCedula3.Text
        Dim numAsociado As String = Asociados.TextBoxSociosNumAsociado.Text
        Dim nombre As String = Asociados.TextBoxSociosNombre.Text
        Dim apellidoUno As String = Asociados.TextBoxSocios1erApellido.Text
        Dim apellidoDos As String = Asociados.TextBoxSocios2doApellido.Text
        Dim fechaNacimiento As Date = Asociados.DateTimeSociosFechaNacimiento.Value.ToString("dd/MM/yyyy")
        Dim telefono As String = Asociados.TextBoxSociosTelefono.Text
        Dim telefono2 As String = Asociados.TextBoxSociosTelefono2.Text
        Dim cuota As String = Asociados.TextBoxSociosCuotaMatricula.Text
        Dim responsable As String = Asociados.TextBoxSociosResponsable.Text
        Dim beneficiario As String = Asociados.TextBoxSociosBeneficiario.Text
        Dim fechaIngreso As Date = Asociados.DateTimeSociosFechaIngreso.Value.ToString("dd/MM/yyyy")
        Dim seccion As String = Asociados.TextBoxSociosSeccion.Text
        Dim especialidad As String = Asociados.TextBoxSociosOcupacionEspecialidad.Text
        Dim direccion As String = Asociados.TextBoxSociosDireccion.Text
        Dim genero As String = ""
        Dim estado As String = ""
        Dim fechaRetiro As Date = Asociados.DateTimeSociosFechaRetiro.Value.ToString("dd/MM/yyyy")
        Dim notasRetiro As String = Asociados.TextBoxSociosNotasRetiro.Text
        Dim menor As String = ""

        'Para el genero
        If (Asociados.RadioButtonSociosMasculino.Checked = True) Then
            genero = Asociados.RadioButtonSociosMasculino.Text
        Else
            genero = Asociados.RadioButtonSociosFemenino.Text
        End If

        'Para ver si es menor
        If (Asociados.RadioButtonSociosMenorNo.Checked = True) Then
            menor = Asociados.RadioButtonSociosMenorNo.Text
        Else
            menor = Asociados.RadioButtonSociosMenorSi.Text
        End If
        'Para el estado
        If (Asociados.RadioButtonSociosActivo.Checked = True) Then
            estado = Asociados.RadioButtonSociosActivo.Text
        Else
            estado = Asociados.RadioButtonSociosRetirado.Text
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
        Dim cedula As String = Asociados.TextBoxSociosCedula.Text
        Dim numAsociado As String = Asociados.TextBoxSociosNumAsociado.Text
        Dim nombre As String = Asociados.TextBoxSociosNombre.Text
        Dim apellidoUno As String = Asociados.TextBoxSocios1erApellido.Text
        Dim apellidoDos As String = Asociados.TextBoxSocios2doApellido.Text
        Dim fechaNacimiento As Date = Asociados.DateTimeSociosFechaNacimiento.Value.ToString("dd/MM/yyyy")
        Dim telefono As String = Asociados.TextBoxSociosTelefono.Text
        Dim cuota As String = Asociados.TextBoxSociosCuotaMatricula.Text
        Dim responsable As String = Asociados.TextBoxSociosResponsable.Text
        Dim beneficiario As String = Asociados.TextBoxSociosBeneficiario.Text
        Dim fechaIngreso As Date = Asociados.DateTimeSociosFechaIngreso.Value.ToString("dd/MM/yyyy")
        Dim seccion As String = Asociados.TextBoxSociosSeccion.Text
        Dim especialidad As String = Asociados.TextBoxSociosOcupacionEspecialidad.Text
        Dim direccion As String = Asociados.TextBoxSociosDireccion.Text
        Dim genero As String = ""
        Dim estado As String = ""
        Dim menor As String = ""
        Dim fechaRetiro As Date = Asociados.DateTimeSociosFechaRetiro.Value.ToString("dd/MM/yyyy")
        Dim notasRetiro As String = Asociados.TextBoxSociosNotasRetiro.Text

        'Para el genero
        If (Asociados.RadioButtonSociosMasculino.Checked = True) Then
            genero = Asociados.RadioButtonSociosMasculino.Text
        Else
            genero = Asociados.RadioButtonSociosFemenino.Text
        End If
        'Para ver si es menor
        If (Asociados.RadioButtonSociosMenorNo.Checked = True) Then
            menor = Asociados.RadioButtonSociosMenorNo.Text
        Else
            menor = Asociados.RadioButtonSociosMenorSi.Text
        End If
        'Para el estado
        If (Asociados.RadioButtonSociosActivo.Checked = True) Then
            estado = Asociados.RadioButtonSociosActivo.Text
        Else
            estado = Asociados.RadioButtonSociosRetirado.Text
        End If

        If (cedula = "" Or numAsociado = "" Or nombre = "" Or apellidoUno = "" Or apellidoDos = "" Or telefono = "" Or cuota = "" Or responsable = "" Or beneficiario = "" Or seccion = "" Or especialidad = "" Or direccion = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                Dim modificado = BD.actualizarSocio(cedula, numAsociado, nombre, apellidoUno, apellidoDos, fechaNacimiento, telefono, cuota, responsable, beneficiario, fechaIngreso, seccion, especialidad,
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
        Asociados.TextBoxSociosCedula.Text = ""
        Asociados.TextBoxSociosCedula2.Text = ""
        Asociados.TextBoxSociosCedula3.Text = ""
        Asociados.TextBoxSociosNumAsociado.Text = ""
        Asociados.TextBoxSociosNombre.Text = ""
        Asociados.TextBoxSocios1erApellido.Text = ""
        Asociados.TextBoxSocios2doApellido.Text = ""
        Asociados.TextBoxSociosTelefono.Text = ""
        Asociados.TextBoxSociosTelefono2.Text = ""
        Asociados.TextBoxSociosCuotaMatricula.Text = ""
        Asociados.TextBoxSociosResponsable.Text = ""
        Asociados.TextBoxSociosBeneficiario.Text = ""
        Asociados.TextBoxSociosSeccion.Text = ""
        Asociados.TextBoxSociosOcupacionEspecialidad.Text = ""
        Asociados.TextBoxSociosDireccion.Text = ""
        Asociados.TextBoxSociosNotasRetiro.Text = ""
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
