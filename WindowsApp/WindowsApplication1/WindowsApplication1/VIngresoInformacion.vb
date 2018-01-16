Public Class VIngresoInformacion
    Dim ingreso As Ingreso = New Ingreso
    Private Sub IngresosInformacionBotonBuscar_Click(sender As Object, e As EventArgs) Handles IngresosInformacionBotonBuscar.Click
        ingreso.buscarIngreso()
    End Sub

    Private Sub IngresosInformacionBotonEliminar_Click(sender As Object, e As EventArgs) Handles IngresosInformacionBotonEliminar.Click
        ingreso.eliminarIngresos()
    End Sub

    Private Sub IngresosInformacionBotonModificar_Click(sender As Object, e As EventArgs) Handles IngresosInformacionBotonModificar.Click
        ingreso.modificarIngresos()
    End Sub

    Private Sub Button_IngresosCalcular_Click(sender As Object, e As EventArgs) Handles Button_IngresosCalcular.Click
        ingreso.calcularInfo()
    End Sub
End Class