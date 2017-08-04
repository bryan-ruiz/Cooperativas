Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Socios
    Dim BD As ConexionBD = New ConexionBD

    Public Sub consultar()
        Dim valores As List(Of String)
        Dim cedula As String = Ventana_Principal.TextBoxSociosCedula.Text
        Dim numAsociado As String = Ventana_Principal.TextBoxSociosNumAsociado.Text

        If (cedula <> "" And numAsociado <> "") Then
            MessageBox.Show("Debe ingresar la cédula o el número de asociado para consultar pero no ambos")
            limpiar()
            Return
        End If

        If (Ventana_Principal.TextBoxSociosCedula.Text = "" And Ventana_Principal.TextBoxSociosNumAsociado.Text = "") Then
            MessageBox.Show("Debe ingresar la cédula o el número de asociado para consultar")
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
                    MessageBox.Show("El Socio no se encuentra registrado")
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
            MessageBox.Show("No pueden haber campos vacíos!")
        Else
            Try
                BD.ConectarBD()
                Dim insertado As Integer = BD.insertarSocio(cedula, numAsociado, nombre, apellidoUno, apellidoDos, fechaNacimiento, telefono, cuota, responsable, beneficiario, fechaIngreso, seccion, especialidad,
                                                            direccion, genero, estado, fechaRetiro, notasRetiro, menor)

                If insertado = 1 Then
                    MessageBox.Show("Socio ingresado con éxito!")
                    limpiar()
                Else
                    MessageBox.Show("Error al ingresar el Socio")
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
            MessageBox.Show("No pueden haber campos vacíos!")
        Else
            Try
                BD.ConectarBD()
                Dim modificado = BD.actualizarSocio(cedula, numAsociado, nombre, apellidoUno, apellidoDos, fechaNacimiento, telefono, cuota, responsable, beneficiario, fechaIngreso, seccion, especialidad,
                                                    direccion, genero, estado, fechaRetiro, notasRetiro, menor)
                If modificado = 1 Then
                    MessageBox.Show("Socio actualizado con éxito!")
                    limpiar()
                Else
                    MessageBox.Show("Error al actualizar la información del Socio")
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


    Public Sub encabezadoPDF(ByVal writer As iTextSharp.text.pdf.PdfWriter, ByVal document As iTextSharp.text.Document)
        Dim oImagen As iTextSharp.text.Image
        Dim cbPie As PdfContentByte
        Dim cbEncabezado As PdfContentByte

        '-----------------------------------------------------------------------------------------
        ' DEFINICIÓN DEL OBJETO PdfContentByte PARA EL ENCABEZADO
        '-----------------------------------------------------------------------------------------
        cbEncabezado = writer.DirectContent
        With cbEncabezado
            .BeginText()
            .SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA_BOLD, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont, 8)
            .SetColorFill(iTextSharp.text.BaseColor.BLACK)
            .ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Cooperativa", 290, 760, 0)
            .ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Tel: 22345445", 290, 750, 0)
            .ShowTextAligned(PdfContentByte.ALIGN_CENTER, "correo: coope@gmail.com", 290, 740, 0)
            .EndText()
        End With
        '-----------------------------------------------------------------------------------------
        ' DEFINICIÓN DEL OBJETO PdfContentByte PARA EL PIE DE PAGINA
        '-----------------------------------------------------------------------------------------
        cbPie = writer.DirectContent
        cbPie.BeginText()
        cbPie.SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont, 10)
        cbPie.SetColorFill(iTextSharp.text.BaseColor.BLACK)
        cbPie.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Página: " & writer.PageNumber, 540, 25, 0)
        cbPie.EndText()
        '-----------------------------------------------------------------------------------------
        ' LOGOS DEL DOCUMENTO
        '-----------------------------------------------------------------------------------------
        oImagen = iTextSharp.text.Image.GetInstance("..\..\Imagen\coopePrueba.jpg")
        oImagen.SetAbsolutePosition(28, 737)
        oImagen.ScalePercent(20)                 'Ajuste porcentual de la imagen
        document.Add(oImagen)                    'Se agrega la imagen al documento

        Dim contador As Integer = 0
        While contador < 4
            document.Add(New Paragraph(" "))
            contador = contador + 1
        End While
        document.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
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
            Dim folderPath As String = "C:\Reportes\reporteSocios.pdf"
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(folderPath & "reporteSocios.pdf", FileMode.Create))
            pdfDoc.Open()
            encabezadoPDF(pdfWrite, pdfDoc)

            Dim contador As Integer = 0
            Dim conta As Integer = 0
            While contador < valores.Count
                If conta = 2 Then
                    pdfDoc.NewPage()
                    conta = 0
                End If
                conta = conta + 1
                pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
                pdfDoc.Add(New Paragraph("Cédula:   " + valores(contador).cedula))
                pdfDoc.Add(New Paragraph("Num. Asociado:    " + valores(contador).numAsoc))
                pdfDoc.Add(New Paragraph("Nombre completo:  " + valores(contador).nombre + " " + valores(contador).primerApellido + " " + valores(contador).segundoApellido))
                pdfDoc.Add(New Paragraph("Fecha de nacimiento:  " + valores(contador).fechaNacimineto))
                pdfDoc.Add(New Paragraph("Teléfono: " + valores(contador).telefono))
                pdfDoc.Add(New Paragraph("Responsable:  " + valores(contador).responsable))
                pdfDoc.Add(New Paragraph("Beneficiario: " + valores(contador).beneficiario))
                pdfDoc.Add(New Paragraph("Fecha de ingreso: " + valores(contador).fechaIngreso))
                pdfDoc.Add(New Paragraph("Sección:  " + valores(contador).seccion))
                pdfDoc.Add(New Paragraph("Ocupación/Especialidad:   " + valores(contador).ocupacionEspecialidad))
                pdfDoc.Add(New Paragraph("Dirección:    " + valores(contador).direccion))
                pdfDoc.Add(New Paragraph("Género:   " + valores(contador).genero))
                pdfDoc.Add(New Paragraph("Estado:   " + valores(contador).estado))
                pdfDoc.Add(New Paragraph("Cuota de matrícula:   " + valores(contador).cuotaMatricula))
                contador = contador + 1
            End While
            pdfDoc.Close()
            MessageBox.Show("Reporte generado con éxito en C:/Reportes/")
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
        End Try
    End Sub


    'Genera un reporte de de matrícula en PDF'
    Public Sub generarReporteDeMatricula()
        'Exporting to PDF
        Dim folderPath As String = "C:\Reportes\"
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        Dim pdfDoc As New Document()
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(folderPath & "reporteMatricula.pdf", FileMode.Create))
        pdfDoc.Open()
        pdfDoc.Add(New Paragraph("matricula"))
        pdfDoc.NewPage()
        pdfDoc.Add(New Paragraph("pag 2 texto"))
        pdfDoc.Close()
        MessageBox.Show("Reporte generado con éxito en C:/Reportes/")
    End Sub

End Class
