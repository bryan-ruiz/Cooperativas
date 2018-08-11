Public Class VIngresoInformacion
    Dim ingreso As Ingreso = New Ingreso
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub VIngresosInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.IngresosInformacionBotonBuscar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_IngresosInformacionBotonEliminar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_IngresosInformacionBotonModificar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonIngresoInformacionBuscarXProveedor.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

        Me.IngresosInformacionInputID.Select()


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

    Private Sub IngresosInformacionInputID_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles IngresosInformacionInputID.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                Call IngresosInformacionBotonBuscar_Click(sender, e)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub IngresosInformacionBotonBuscar_Click(sender As Object, e As EventArgs) Handles IngresosInformacionBotonBuscar.Click
        Dim IngresoInformacionInputID As String = Me.IngresosInformacionInputID.Text
        ingreso.buscarIngreso(IngresoInformacionInputID)
    End Sub

    Private Sub ButtonIngresoInformacionBuscarXProveedor_Click(sender As Object, e As EventArgs) Handles ButtonIngresoInformacionBuscarXProveedor.Click
        VBusquedaIngresoXProveedor.Show()
    End Sub
End Class