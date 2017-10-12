Public Class VGastos

    Dim gasto As Gastos = New Gastos

    Private Sub CrearReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearReporteToolStripMenuItem.Click
        VGastosReporte.Show()
    End Sub

    Private Sub InformeEcónomicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeEcónomicoToolStripMenuItem.Click
        VInformeEconomico.Show()
    End Sub

    Private Sub Button_GastosAgregar_Click(sender As Object, e As EventArgs) Handles Button_GastosAgregar.Click
        gasto.insertarGasto()
    End Sub

    Private Sub Button_GastosCalcular_Click(sender As Object, e As EventArgs) Handles Button_GastosCalcular.Click
        gasto.calcular()
    End Sub

End Class