Public Class VIngresoInformacion
    Dim ingreso As Ingreso = New Ingreso
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub VIngresosInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.IngresosInformacionBotonBuscar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_IngresosCalcular.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_IngresosInformacionBotonEliminar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_IngresosInformacionBotonModificar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    Private Sub IngresosInformacionBotonBuscar_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub IngresosInformacionBotonEliminar_Click(sender As Object, e As EventArgs)
        ingreso.eliminarIngresos()
    End Sub

    Private Sub IngresosInformacionBotonModificar_Click(sender As Object, e As EventArgs)
        ingreso.modificarIngresos()
    End Sub

    Private Sub Button_IngresosCalcular_Click(sender As Object, e As EventArgs) Handles Button_IngresosCalcular.Click
        ingreso.calcularInfo()
    End Sub

    Private Sub IngresosInformacionBotonBuscar_Click_1(sender As Object, e As EventArgs) Handles IngresosInformacionBotonBuscar.Click
        ingreso.buscarIngreso()
    End Sub

    Private Sub Button_IngresosInformacionBotonEliminar_Click(sender As Object, e As EventArgs) Handles Button_IngresosInformacionBotonEliminar.Click
        ingreso.eliminarIngresos()
    End Sub

    Private Sub Button_IngresosInformacionBotonModificar_Click(sender As Object, e As EventArgs) Handles Button_IngresosInformacionBotonModificar.Click
        ingreso.modificarIngresos()
    End Sub
End Class