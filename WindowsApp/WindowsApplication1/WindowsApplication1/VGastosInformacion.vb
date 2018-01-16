Public Class VGastosInformacion
    Dim gasto As Gastos = New Gastos
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Private Sub GastosInformacionBotonBuscar_Click(sender As Object, e As EventArgs) Handles GastosInformacionBotonBuscar.Click
        gasto.buscarGasto()
    End Sub

    Private Sub Button_GastosCalcular_Click(sender As Object, e As EventArgs) Handles Button_GastosCalcular.Click
        gasto.calcularInfo()
    End Sub

    Private Sub GastosInformacionBotonEliminar_Click(sender As Object, e As EventArgs) Handles GastosInformacionBotonEliminar.Click
        gasto.eliminarGasto()
    End Sub

    Private Sub GastosInformacionBotonModificar_Click(sender As Object, e As EventArgs) Handles GastosInformacionBotonModificar.Click
        gasto.modificarGasto()
    End Sub
End Class