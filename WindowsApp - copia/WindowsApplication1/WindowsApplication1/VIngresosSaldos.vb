Public Class VIngresosSaldos

    Dim saldos As Saldos = New Saldos

    Private Sub Button_IngresosReporteIngresos_Click(sender As Object, e As EventArgs) Handles Button_ReporteSaldos.Click
        saldos.generarReporteSaldosNuevo()
        Print.Show()
    End Sub

End Class