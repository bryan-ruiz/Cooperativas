Public Class VGastosReporte

    Dim gasto As Gastos = New Gastos

    Private Sub ButtonGastosReporte_Click(sender As Object, e As EventArgs) Handles ButtonGastosReporte.Click
        gasto.generarReporteGastos()
        Print.Show()
    End Sub

End Class