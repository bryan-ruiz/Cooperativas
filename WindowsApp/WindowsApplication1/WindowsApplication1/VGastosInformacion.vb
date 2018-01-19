﻿Public Class VGastosInformacion
    Dim gasto As Gastos = New Gastos
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales


    Private Sub VGastosInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.GastosInformacionBotonBuscar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_GastoInformacionBotonEliminar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_GastoInformacionBotonModificar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
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

    Private Sub TextBox_GastosCantidad_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_GastosInformacion_Cantidad.KeyPress
        Me.TextBox_GastosInformacion_Cantidad.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_GastosPrecioUnitario_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_GastosInformacion_PrecioUnit.KeyPress
        Me.TextBox_GastosInformacion_PrecioUnit.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class