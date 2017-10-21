Public Class VIngresos

    Dim ingreso As Ingreso = New Ingreso

    'LOAD - cod cta data
    Private Sub VIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ingreso.obtenerDatosSeleccionarCuenta()
        ingreso.obtenerDatosSeleccionarCuenta2()
    End Sub

    Private Sub CrearReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearReporteToolStripMenuItem.Click
        VIngresosReporte.Show()
    End Sub

    Private Sub InformeEconómicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeEconómicoToolStripMenuItem.Click
        VInformeEconomico.Show()
    End Sub

    Private Sub Button_IngresosInsertar_Click(sender As Object, e As EventArgs) Handles Button_IngresosInsertar.Click
        ingreso.insertarIngreso()
    End Sub

    Private Sub Button_IngresosCalcularTotal_Click(sender As Object, e As EventArgs) Handles Button_IngresosCalcularTotal.Click
        ingreso.calcular()
    End Sub

    Private Sub Button_IngresosCalcularTotal2_Click(sender As Object, e As EventArgs) Handles Button_IngresosCalcularTotal2.Click
        ingreso.calcular2()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Principal.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Hide()
    End Sub

    Private Sub TextBox_IngresosCantidad_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosCantidad.KeyPress
        Me.TextBox_IngresosCantidad.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosCantidad2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosCantidad2.KeyPress
        Me.TextBox_IngresosCantidad2.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosPrecioUnitario_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosPrecioUnitario.KeyPress
        Me.TextBox_IngresosPrecioUnitario.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosPrecioUnitario2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosPrecioUnitario2.KeyPress
        Me.TextBox_IngresosPrecioUnitario2.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosTotal_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosTotal.KeyPress
        Me.TextBox_IngresosTotal.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosTotal2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosTotal2.KeyPress
        Me.TextBox_IngresosTotal2.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class