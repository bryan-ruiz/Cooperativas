Public Class VIngresos

    Dim ingreso As Ingreso = New Ingreso

    Private Sub CrearReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearReporteToolStripMenuItem.Click
        VIngresosReporte.Show()
    End Sub

    Private Sub InformeEconómicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeEconómicoToolStripMenuItem.Click
        VInformeEconomico.Show()
    End Sub

    Private Sub Button_IngresosInsertar_Click(sender As Object, e As EventArgs) Handles Button_IngresosInsertar.Click
        ingreso.insertarIngreso()
    End Sub

    Private Sub Button_IngresosCalcularTotal_Click(sender As Object, e As EventArgs) Handles Button_IngresosCalcularTotal.Click
        ingreso.calcular()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Principal.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Hide()
    End Sub
End Class