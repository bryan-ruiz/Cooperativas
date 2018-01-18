Public Class VGastosInformacion
    Dim gasto As Gastos = New Gastos
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales


    Private Sub VGastosInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.GastosInformacionBotonBuscar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_GastoInformacionBotonEliminar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_GastoInformacionBotonModificar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_GastosCalcular.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    Private Sub Button_GastosCalcular_Click(sender As Object, e As EventArgs) Handles Button_GastosCalcular.Click
        gasto.calcularInfo()
    End Sub


    Private Sub GastosInformacionBotonBuscar_Click(sender As Object, e As EventArgs) Handles GastosInformacionBotonBuscar.Click
        gasto.buscarGasto()
    End Sub

    Private Sub Button_GastoInformacionBotonModificar_Click(sender As Object, e As EventArgs) Handles Button_GastoInformacionBotonModificar.Click
        gasto.modificarGasto()
    End Sub

    Private Sub Button_GastoInformacionBotonEliminar_Click(sender As Object, e As EventArgs) Handles Button_GastoInformacionBotonEliminar.Click
        gasto.eliminarGasto()
    End Sub
End Class