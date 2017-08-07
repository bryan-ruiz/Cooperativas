Imports Cooperativas.Socios


Public Class Print
    Private Sub ButtonPrintAbrirPDF_Click(sender As Object, e As EventArgs) Handles ButtonPrintAbrirPDF.Click
        Me.OpenFileDialog1.FileName = String.Empty
        Me.OpenFileDialog1.ShowDialog()
        '---Me.AxAcroPDF1.LoadFile(Me.OpenFileDialog1.FileName)

    End Sub

    Private Sub ButtonPrintSalir_Click(sender As Object, e As EventArgs) Handles ButtonPrintSalir.Click
        Me.Close()
    End Sub
End Class