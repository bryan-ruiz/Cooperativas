Public Class VIngresosComprobante

    Dim ingresoRecibo As IngresoRecibo = New IngresoRecibo

    'LOAD - cod cta data
    Private Sub VIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ingresoRecibo.obtenerDatosSeleccionarCuentaRecibo()
    End Sub

    'Imprimir comprobante
    Private Sub Button_IngresosInsertar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_IngresosInsertar2_Click(sender As Object, e As EventArgs)
        ingreso.insertarIngreso2()
    End Sub

    Private Sub Button_IngresosInsertar3_Click(sender As Object, e As EventArgs) Handles Button_IngresosImprimirReciboRE.Click
        ingresoRecibo.generarReporteIngresosRecibo()
    End Sub

    'BUTTON CALCULAR
    Private Sub Button_IngresosCalcularTotal_Click(sender As Object, e As EventArgs) Handles Button_IngresosCalcularTotalRE.Click
        Ingreso.calcular()
    End Sub

    Private Sub Button_IngresosCalcularTotal2_Click(sender As Object, e As EventArgs)
        ingreso.calcular2()
    End Sub

    Private Sub Button_IngresosCalcularTotal3_Click(sender As Object, e As EventArgs)
        ingreso.calcular3()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Principal.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    'CANTIDAD
    Private Sub TextBox_IngresosCantidad_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosCantidadRE.KeyPress
        Me.TextBox_IngresosCantidadRE.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosCantidad2_TextChanged(sender As Object, e As KeyPressEventArgs)
        Me.TextBox_IngresosCantidad2.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosCantidad3_TextChanged(sender As Object, e As KeyPressEventArgs)
        Me.TextBox_IngresosCantidad3.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'PRECIO UNITARIO
    Private Sub TextBox_IngresosPrecioUnitario_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosPrecioUnitarioRE.KeyPress
        Me.TextBox_IngresosPrecioUnitarioRE.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosPrecioUnitario2_TextChanged(sender As Object, e As KeyPressEventArgs)
        Me.TextBox_IngresosPrecioUnitario2.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosPrecioUnitario3_TextChanged(sender As Object, e As KeyPressEventArgs)
        Me.TextBox_IngresosPrecioUnitario3.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'TOTAL
    Private Sub TextBox_IngresosTotal_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosTotalRE.KeyPress
        Me.TextBox_IngresosTotalRE.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosTotal2_TextChanged(sender As Object, e As KeyPressEventArgs)
        Me.TextBox_IngresosTotal2.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosTotal3_TextChanged(sender As Object, e As KeyPressEventArgs)
        Me.TextBox_IngresosTotal3.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


End Class