Imports iTextSharp.text.pdf
Imports WindowsApplication1.Socios


Public Class Print

    Private Sub Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub ButtonPrintAbrirPDF_Click_1(sender As Object, e As EventArgs) Handles ButtonPrintAbrirPDF.Click
        Me.OpenFileDialog1.FileName = String.Empty
        Me.OpenFileDialog1.ShowDialog()
        AxAcroPDF1.LoadFile(Me.OpenFileDialog1.FileName)
    End Sub

    Private Sub ButtonPrintSalir_Click_1(sender As Object, e As EventArgs) Handles ButtonPrintSalir.Click
        Me.Close()
    End Sub

    Public Sub abrirReporte(ByVal nombre As String)
        Try

            AxAcroPDF1.LoadFile(nombre)
            'AxAcroPDF1.setShowToolbar(False)
            AxAcroPDF1.Enabled = True
            'AxAcroPDF1.Show()
            AxAcroPDF1.Select()

        Catch ex As Exception
            MessageBox.Show("El PDF está siendo usado por otro proceso, favor cierre Adobe Reader y vuelva a generar el reporte.")
        End Try
    End Sub

End Class