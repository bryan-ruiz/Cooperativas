Public Class VIngresoInformacion
    Dim ingreso As Ingreso = New Ingreso
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub VIngresosInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.IngresosInformacionBotonBuscar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_IngresosInformacionBotonEliminar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_IngresosInformacionBotonModificar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
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

    Private Sub TextBox_IngresoCantidad_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosInformacion_Cantidad.KeyPress
        Me.TextBox_IngresosInformacion_Cantidad.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresoPrecioUnitario_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosInformacion_PrecioUnit.KeyPress
        Me.TextBox_IngresosInformacion_PrecioUnit.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class