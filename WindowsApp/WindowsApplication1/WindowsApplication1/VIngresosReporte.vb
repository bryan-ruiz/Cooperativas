Public Class VIngresosReporte

    Dim ingreso As Ingreso = New Ingreso

    Private Sub Button_IngresosReporteIngresos_Click(sender As Object, e As EventArgs) Handles Button_IngresosReporteIngresos.Click
        ingreso.generarReporteIngresos()
        Print.Show()
    End Sub

End Class