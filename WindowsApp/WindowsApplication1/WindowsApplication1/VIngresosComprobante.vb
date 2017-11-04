Public Class VIngresosComprobante

    Dim ingresoRecibo As IngresoRecibo = New IngresoRecibo


    'LOAD - cod cta data
    Private Sub VIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ingresoRecibo.obtenerDatosSeleccionarCuentaRecibo()
    End Sub

    'Imprimir comprobante
    Private Sub Button_IngresosInsertar_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub TextBox_IngresosTotal_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosTotalRE.KeyPress
        Me.TextBox_IngresosTotalRE.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosPrecioUnitarioRE_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosPrecioUnitarioRE.KeyPress
        Me.TextBox_IngresosPrecioUnitarioRE.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_IngresosCantidadRE_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox_IngresosCantidadRE.KeyPress
        Me.TextBox_IngresosCantidadRE.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button_IngresosImprimirReciboRE_Click(sender As Object, e As EventArgs) Handles Button_IngresosImprimirReciboRE.Click
        'IMPRIMIR RECIBO DE ENTRADAS


    End Sub
End Class