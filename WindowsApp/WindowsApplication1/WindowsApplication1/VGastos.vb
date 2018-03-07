Public Class VGastos

    Dim gasto As Gastos = New Gastos
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'LOAD
    Private Sub VGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gasto.obtenerDatosSeleccionarCuenta()
        gasto.obtenerDatosSeleccionarCuenta2()
        gasto.obtenerDatosSeleccionarCuenta3()

        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_GastosAgregar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_GastosAgregar2.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_GastosAgregar3.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    Private Sub CrearReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearReporteToolStripMenuItem.Click
        VGastosReporte.Show()
    End Sub

    Private Sub InformeEcónomicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeEcónomicoToolStripMenuItem.Click
        VInformeEconomico.Show()
    End Sub

    Private Sub Button_GastosCalcular_Click(sender As Object, e As EventArgs)
        gasto.calcular()
    End Sub

    Private Sub TextBox_GastosCantidad_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_GastosCantidad.KeyPress, TextBox_GastosCantidad.TextChanged
        Me.TextBox_GastosCantidad.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_GastosCantidad2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_GastosCantidad2.KeyPress
        Me.TextBox_GastosCantidad2.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_GastosCantidad3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_GastosCantidad3.KeyPress
        Me.TextBox_GastosCantidad3.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_GastosPrecioUnitario_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_GastosPrecioUnitario.KeyPress
        Me.TextBox_GastosPrecioUnitario.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_GastosPrecioUnitario2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_GastosPrecioUnitario2.KeyPress
        Me.TextBox_GastosPrecioUnitario2.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_GastosPrecioUnitario3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_GastosPrecioUnitario3.KeyPress
        Me.TextBox_GastosPrecioUnitario3.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_GastosTotal_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_GastosTotal.KeyPress
        Me.TextBox_GastosTotal.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_GastosTotal2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_GastosTotal2.KeyPress
        Me.TextBox_GastosTotal2.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_GastosTotal3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_GastosTotal3.KeyPress
        Me.TextBox_GastosTotal3.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button_GastosAgregar_Click_1(sender As Object, e As EventArgs) Handles Button_GastosAgregar.Click
        gasto.insertarGasto()
    End Sub

    Private Sub Button_GastosAgregar2_Click(sender As Object, e As EventArgs) Handles Button_GastosAgregar2.Click
        gasto.insertarGasto2()
    End Sub

    Private Sub Button_GastosAgregar3_Click(sender As Object, e As EventArgs) Handles Button_GastosAgregar3.Click
        gasto.insertarGasto3()
    End Sub

    Private Sub Button_GastosCalcular_Click_1(sender As Object, e As EventArgs) Handles Button_GastosCalcular.Click
        gasto.calcular()
    End Sub

    Private Sub Button_GastosCalcular2_Click(sender As Object, e As EventArgs) Handles Button_GastosCalcular2.Click
        gasto.calcular2()
    End Sub

    Private Sub Button_GastosCalcular3_Click(sender As Object, e As EventArgs) Handles Button_GastosCalcular3.Click
        gasto.calcular3()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ReporteDeSaldosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeSaldosToolStripMenuItem.Click
        VIngresosSaldos.Show()
    End Sub

    Private Sub InformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónToolStripMenuItem.Click
        VGastosInformacion.Show()
    End Sub

    Private Sub TotalesCódigoDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalesCódigoDeCuentasToolStripMenuItem.Click
        VReporteGastoCuentas.Show()
    End Sub

    Private Sub TextBox_GastosCantidad_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class