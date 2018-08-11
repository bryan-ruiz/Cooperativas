Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class EncabezadoClase
    Dim BD As ConexionBD = New ConexionBD
    Dim valores As IList(Of ConfiguracionClase)
    Dim errorDatos As Boolean = False

    Public Sub consultarDatos()
        Try
            errorDatos = False
            BD.ConectarBD()
            valores = BD.obtenerDatosdeConfiguration()
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("ocurrio un error en base de datos configuración:" + ex.Message())
            errorDatos = True
            Return
        End Try
    End Sub

    Public Sub encabezado(ByVal writer As iTextSharp.text.pdf.PdfWriter, ByVal document As iTextSharp.text.Document)
        Dim oImagen As iTextSharp.text.Image
        Dim cbPie As PdfContentByte
        Dim cbEncabezado As PdfContentByte
        If errorDatos = True Then
            MessageBox.Show("ocurrio un error en base de datos configuración")
            Return
        End If
        '-----------------------------------------------------------------------------------------
        ' DEFINICIÓN DEL OBJETO PdfContentByte PARA EL ENCABEZADO
        '-----------------------------------------------------------------------------------------
        cbEncabezado = writer.DirectContent
        With cbEncabezado
            .BeginText()
            .SetFontAndSize(FontFactory.GetFont(FontFactory.TIMES_BOLD, iTextSharp.text.Font.NORMAL, iTextSharp.text.Font.NORMAL).BaseFont, 12)
            '.SetColorFill(iTextSharp.text.BaseColor.BLACK)
            .SetColorFill(iTextSharp.text.BaseColor.DARK_GRAY)
            .ShowTextAligned(PdfContentByte.ALIGN_CENTER, valores(0).cooperativa, 290, 770, 0) 'nombre de la coope

            .SetFontAndSize(FontFactory.GetFont(FontFactory.TIMES_BOLD, iTextSharp.text.Font.NORMAL, iTextSharp.text.Font.NORMAL).BaseFont, 9)

            .ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Ced Jurídica: " + valores(0).cedulaJuridica, 290, 755, 0)
            .ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Tel: " + valores(0).telefono, 290, 745, 0)
            .ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"), 290, 735, 0)
            .EndText()
        End With
        '-----------------------------------------------------------------------------------------
        ' DEFINICIÓN DEL OBJETO PdfContentByte PARA EL PIE DE PAGINA
        '-----------------------------------------------------------------------------------------
        cbPie = writer.DirectContent
        cbPie.BeginText()
        cbPie.SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont, 8)
        cbPie.SetColorFill(iTextSharp.text.BaseColor.BLACK)
        cbPie.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Página: " & writer.PageNumber, 540, 25, 0)
        cbPie.EndText()
        '-----------------------------------------------------------------------------------------
        ' LOGOS DEL DOCUMENTO
        '-----------------------------------------------------------------------------------------




        '//para hacer PUBLISH
        'oImagen = iTextSharp.text.Image.GetInstance(My.Application.Info.DirectoryPath & "\Resources\MEP_Logo.png")

        '// PARA TRABAJAR PROYECTO EN PC LOCAL
        oImagen = iTextSharp.text.Image.GetInstance("..\..\Imagen\MEP_Logo.png")



        oImagen.SetAbsolutePosition(28, 737)
        'Ajuste porcentual de la imagen
        oImagen.ScalePercent(50)
        'Se agrega la imagen al documento
        document.Add(oImagen)

        Dim contador As Integer = 0
        While contador < 5
            document.Add(New Paragraph(" "))
            contador = contador + 1
        End While
        'document.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
    End Sub
End Class
