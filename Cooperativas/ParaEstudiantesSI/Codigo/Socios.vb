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
        Dim cedula As String = Ventana_Principal.TextBoxSociosCedula.Text
        Dim numAsociado As String = Ventana_Principal.TextBoxSociosNumAsociado.Text

        If (cedula <> "" And numAsociado <> "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado)
            limpiar()
            Return
        End If

        If (Ventana_Principal.TextBoxSociosCedula.Text = "" And Ventana_Principal.TextBoxSociosNumAsociado.Text = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaONumAsociado)
            limpiar()
        Else
            Try
                BD.ConectarBD()

                If (numAsociado = "" And cedula <> "") Then
                    valores = BD.consultarSocioPorCedula(cedula)
                End If

                If (cedula = "" And numAsociado <> "") Then
                    valores = BD.consultarSocioPorNumAsociado(numAsociado)
                End If

                ''Dim valores As List(Of String) = BD.consultarSocioPorCedula(cedula)

                If valores.Count <> 0 Then
                    Ventana_Principal.TextBoxSociosCedula.Text = valores(0)
                    Ventana_Principal.TextBoxSociosNumAsociado.Text = valores(1)
                    Ventana_Principal.TextBoxSociosNombre.Text = valores.Item(2)
                    Ventana_Principal.TextBoxSocios1erApellido.Text = valores.Item(3)
                    Ventana_Principal.TextBoxSocios2doApellido.Text = valores.Item(4)
                    Ventana_Principal.DateTimeSociosFechaNacimiento.Value = Date.Parse(valores.Item(5))
                    Ventana_Principal.TextBoxSociosTelefono.Text = valores.Item(6)
                    Ventana_Principal.TextBoxSociosCuotaMatricula.Text = valores.Item(7)
                    Ventana_Principal.TextBoxSociosResponsable.Text = valores.Item(8)
                    Ventana_Principal.TextBoxSociosBeneficiario.Text = valores.Item(9)
                    Ventana_Principal.DateTimeSociosFechaIngreso.Value = Date.Parse(valores.Item(10))
                    Ventana_Principal.TextBoxSociosSeccion.Text = valores.Item(11)
                    Ventana_Principal.TextBoxSociosOcupacionEspecialidad.Text = valores.Item(12)
                    Ventana_Principal.TextBoxSociosDireccion.Text = valores.Item(13)
                    'Para Genero
                    If valores.Item(14).Equals("Masculino") Then
                        Ventana_Principal.RadioButtonSociosMasculino.Checked = True
                        Ventana_Principal.RadioButtonSociosFemenino.Checked = False
                    End If
                    If valores.Item(14).Equals("Femenino") Then
                        Ventana_Principal.RadioButtonSociosFemenino.Checked = True
                        Ventana_Principal.RadioButtonSociosMasculino.Checked = False
                    End If
                    'Para Estado
                    If valores.Item(15).Equals("Activo") Then
                        Ventana_Principal.RadioButtonSociosActivo.Checked = True
                        Ventana_Principal.RadioButtonSociosRetirado.Checked = False
                    End If
                    If valores.Item(15).Equals("Retirado") Then
                        Ventana_Principal.RadioButtonSociosActivo.Checked = False
                        Ventana_Principal.RadioButtonSociosRetirado.Checked = True
                    End If
                    If valores.Item(18).Equals("No") Then
                        Ventana_Principal.RadioButtonSociosMenorNo.Checked = True
                        Ventana_Principal.RadioButtonSociosMenorSi.Checked = False
                    End If
                    If valores.Item(18).Equals("Si") Then
                        Ventana_Principal.RadioButtonSociosMenorSi.Checked = True
                        Ventana_Principal.RadioButtonSociosMenorNo.Checked = False
                    End If
                    Ventana_Principal.DateTimeSociosFechaRetiro.Value = Date.Parse(valores.Item(16))
                    Ventana_Principal.TextBoxSociosNotasRetiro.Text = valores.Item(17)

                Else
                    MessageBox.Show(variablesGlobales.noExistenDatos)
                    limpiar()
                End If
                'Muy importante cerrar conexion despues de cada consulta'
                'Cierro conexion'
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show("Error de: " + ex.ToString)
                'MessageBox.Show("ocurrio el siguiente error:" + ex.ToString())
            End Try
        End If
    End Sub

    'Insertar Socio
    Public Sub insertar()
        Dim cedula As String = Ventana_Principal.TextBoxSociosCedula.Text
        Dim numAsociado As String = Ventana_Principal.TextBoxSociosNumAsociado.Text
        Dim nombre As String = Ventana_Principal.TextBoxSociosNombre.Text
        Dim apellidoUno As String = Ventana_Principal.TextBoxSocios1erApellido.Text
        Dim apellidoDos As String = Ventana_Principal.TextBoxSocios2doApellido.Text
        Dim fechaNacimiento As Date = Ventana_Principal.DateTimeSociosFechaNacimiento.Value.ToString("dd/MM/yyyy")
        Dim telefono As String = Ventana_Principal.TextBoxSociosTelefono.Text
        Dim cuota As String = Ventana_Principal.TextBoxSociosCuotaMatricula.Text
        Dim responsable As String = Ventana_Principal.TextBoxSociosResponsable.Text
        Dim beneficiario As String = Ventana_Principal.TextBoxSociosBeneficiario.Text
        Dim fechaIngreso As Date = Ventana_Principal.DateTimeSociosFechaIngreso.Value.ToString("dd/MM/yyyy")
        Dim seccion As String = Ventana_Principal.TextBoxSociosSeccion.Text
        Dim especialidad As String = Ventana_Principal.TextBoxSociosOcupacionEspecialidad.Text
        Dim direccion As String = Ventana_Principal.TextBoxSociosDireccion.Text
        Dim genero As String = ""
        Dim estado As String = ""
        Dim fechaRetiro As Date = Ventana_Principal.DateTimeSociosFechaRetiro.Value.ToString("dd/MM/yyyy")
        Dim notasRetiro As String = Ventana_Principal.TextBoxSociosNotasRetiro.Text
        Dim menor As String = ""
        'Para el genero
        If (Ventana_Principal.RadioButtonSociosMasculino.Checked = True) Then
            genero = Ventana_Principal.RadioButtonSociosMasculino.Text
        Else
            genero = Ventana_Principal.RadioButtonSociosFemenino.Text
        End If

        'Para ver si es menor
        If (Ventana_Principal.RadioButtonSociosMenorNo.Checked = True) Then
            menor = Ventana_Principal.RadioButtonSociosMenorNo.Text
        Else
            menor = Ventana_Principal.RadioButtonSociosMenorSi.Text
        End If
        'Para el estado
        If (Ventana_Principal.RadioButtonSociosActivo.Checked = True) Then
            estado = Ventana_Principal.RadioButtonSociosActivo.Text
        Else
            estado = Ventana_Principal.RadioButtonSociosRetirado.Text
        End If

        If (cedula = "" Or numAsociado = "" Or nombre = "" Or apellidoUno = "" Or apellidoDos = "" Or telefono = "" Or cuota = "" Or responsable = "" Or beneficiario = "" Or seccion = "" Or especialidad = "" Or direccion = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios)
        Else
            Try
                BD.ConectarBD()
                Dim insertado As Integer = BD.insertarSocio(cedula, numAsociado, nombre, apellidoUno, apellidoDos, fechaNacimiento, telefono, cuota, responsable, beneficiario,
                                                            fechaIngreso, seccion, especialidad, direccion, genero, estado, fechaRetiro, notasRetiro, menor)

                Dim certificadoXSocio As Integer = BD.insertarCertificadoXSocio(cedula, numAsociado, "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0")

                If (insertado = 1 And certificadoXSocio = 1) Then
                    MessageBox.Show(variablesGlobales.datosIngresadosConExito, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    limpiar()
                Else
                    MessageBox.Show(variablesGlobales.errorIngresandoDatos, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    limpiar()
                End If
                'Muy importante cerrar conexion despues de cada consulta'
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show("ocurrio el siguiente error:" + ex.ToString())
            End Try
        End If
    End Sub

    'Actualizar Info de Socios'
    Public Sub actualizar()
        Dim cedula As String = Ventana_Principal.TextBoxSociosCedula.Text
        Dim numAsociado As String = Ventana_Principal.TextBoxSociosNumAsociado.Text
        Dim nombre As String = Ventana_Principal.TextBoxSociosNombre.Text
        Dim apellidoUno As String = Ventana_Principal.TextBoxSocios1erApellido.Text
        Dim apellidoDos As String = Ventana_Principal.TextBoxSocios2doApellido.Text
        Dim fechaNacimiento As Date = Ventana_Principal.DateTimeSociosFechaNacimiento.Value.ToString("dd/MM/yyyy")
        Dim telefono As String = Ventana_Principal.TextBoxSociosTelefono.Text
        Dim cuota As String = Ventana_Principal.TextBoxSociosCuotaMatricula.Text
        Dim responsable As String = Ventana_Principal.TextBoxSociosResponsable.Text
        Dim beneficiario As String = Ventana_Principal.TextBoxSociosBeneficiario.Text
        Dim fechaIngreso As Date = Ventana_Principal.DateTimeSociosFechaIngreso.Value.ToString("dd/MM/yyyy")
        Dim seccion As String = Ventana_Principal.TextBoxSociosSeccion.Text
        Dim especialidad As String = Ventana_Principal.TextBoxSociosOcupacionEspecialidad.Text
        Dim direccion As String = Ventana_Principal.TextBoxSociosDireccion.Text
        Dim genero As String = ""
        Dim estado As String = ""
        Dim menor As String = ""
        Dim fechaRetiro As Date = Ventana_Principal.DateTimeSociosFechaRetiro.Value.ToString("dd/MM/yyyy")
        Dim notasRetiro As String = Ventana_Principal.TextBoxSociosNotasRetiro.Text

        'Para el genero
        If (Ventana_Principal.RadioButtonSociosMasculino.Checked = True) Then
            genero = Ventana_Principal.RadioButtonSociosMasculino.Text
        Else
            genero = Ventana_Principal.RadioButtonSociosFemenino.Text
        End If
        'Para ver si es menor
        If (Ventana_Principal.RadioButtonSociosMenorNo.Checked = True) Then
            menor = Ventana_Principal.RadioButtonSociosMenorNo.Text
        Else
            menor = Ventana_Principal.RadioButtonSociosMenorSi.Text
        End If
        'Para el estado
        If (Ventana_Principal.RadioButtonSociosActivo.Checked = True) Then
            estado = Ventana_Principal.RadioButtonSociosActivo.Text
        Else
            estado = Ventana_Principal.RadioButtonSociosRetirado.Text
        End If

        If (cedula = "" Or numAsociado = "" Or nombre = "" Or apellidoUno = "" Or apellidoDos = "" Or telefono = "" Or cuota = "" Or responsable = "" Or beneficiario = "" Or seccion = "" Or especialidad = "" Or direccion = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios)
        Else
            Try
                BD.ConectarBD()
                Dim modificado = BD.actualizarSocio(cedula, numAsociado, nombre, apellidoUno, apellidoDos, fechaNacimiento, telefono, cuota, responsable, beneficiario, fechaIngreso, seccion, especialidad,
                                                    direccion, genero, estado, fechaRetiro, notasRetiro, menor)
                If modificado = 1 Then
                    MessageBox.Show(variablesGlobales.datosActualizadosConExito)
                    limpiar()
                Else
                    MessageBox.Show(variablesGlobales.errorActualizandoDatos)
                    limpiar()
                End If
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show("ocurrio el siguiente error:" + ex.ToString())
            End Try
        End If
    End Sub

    'Limpia los campos de Socios'
    Public Sub limpiar()
        Ventana_Principal.TextBoxSociosCedula.Text = ""
        Ventana_Principal.TextBoxSociosNumAsociado.Text = ""
        Ventana_Principal.TextBoxSociosNombre.Text = ""
        Ventana_Principal.TextBoxSocios1erApellido.Text = ""
        Ventana_Principal.TextBoxSocios2doApellido.Text = ""
        Ventana_Principal.TextBoxSociosTelefono.Text = ""
        Ventana_Principal.TextBoxSociosCuotaMatricula.Text = ""
        Ventana_Principal.TextBoxSociosResponsable.Text = ""
        Ventana_Principal.TextBoxSociosBeneficiario.Text = ""
        Ventana_Principal.TextBoxSociosSeccion.Text = ""
        Ventana_Principal.TextBoxSociosOcupacionEspecialidad.Text = ""
        Ventana_Principal.TextBoxSociosDireccion.Text = ""
        Ventana_Principal.TextBoxSociosNotasRetiro.Text = ""
    End Sub

    'Genera un reporte de los Socios en PDF'
    Public Sub generarReporteDeSocios()
        Dim tipoReporte As String = ""
        If (Ventana_Principal.RadioButtonSociosReporteTodos.Checked = True) Then
            tipoReporte = Ventana_Principal.RadioButtonSociosReporteTodos.Text
        Else
            tipoReporte = "Activos"
        End If
        Try
            Dim valores As List(Of SocioClase)
            BD.ConectarBD()
            valores = BD.obtenerDatosReporteDeSocios(tipoReporte)
            BD.CerrarConexion()

            'Exporting to PDF
            Dim folderPath As String = "C:\Reportes\"
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(folderPath & "reporteSocios.pdf", FileMode.Create))
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
            MessageBox.Show(variablesGlobales.reporteGeneradoConExito, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
        End Try
    End Sub

End Class
