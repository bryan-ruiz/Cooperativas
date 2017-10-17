Imports Cooperativas.Socios


Public Class Print
    Private Sub ButtonPrintAbrirPDF_Click(sender As Object, e As EventArgs) Handles ButtonPrintAbrirPDF.Click
        Me.OpenFileDialog1.FileName = String.Empty
        Me.OpenFileDialog1.ShowDialog()
        AxAcroPDF1.LoadFile(Me.OpenFileDialog1.FileName)

    End Sub

    Private Sub ButtonPrintSalir_Click(sender As Object, e As EventArgs) Handles ButtonPrintSalir.Click
        Me.Close()
    End Sub

    Private Sub Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub AxAcroPDF1_OnError(sender As Object, e As EventArgs) Handles AxAcroPDF1.OnError

    End Sub
End Class