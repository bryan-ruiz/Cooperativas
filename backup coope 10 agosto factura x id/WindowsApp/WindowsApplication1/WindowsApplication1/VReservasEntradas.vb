Public Class VReservasEntradas

    Dim reservasEntradas As ReservasEntradas = New ReservasEntradas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'LOAD 
    Private Sub VIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.CertificadosEntradasAgregarEntrada.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        reservasEntradas.obtenerDatosSeleccionarReserva()
        Me.CertificadosEntradasTextboxFacturaRecibos.Select()
    End Sub

    Private Sub CertificadosEntradasCantidad_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosEntradasCantidad.KeyPress
        Me.CertificadosEntradasCantidad.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosEntradasPrecioUnitario_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosEntradasPrecioUnitario.KeyPress
        Me.CertificadosEntradasPrecioUnitario.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosEntradasTotal_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosEntradasTotal.KeyPress
        Me.CertificadosEntradasTotal.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosEntradasCalcularTotal_Click(sender As Object, e As EventArgs) Handles CertificadosEntradasCalcularTotal.Click
        reservasEntradas.calcularTotal()
    End Sub

    Private Sub CertificadosEntradasAgregarEntrada_Click(sender As Object, e As EventArgs) Handles CertificadosEntradasAgregarEntrada.Click
        reservasEntradas.insertarReservaEntrada()
    End Sub


    'Private Sub ReporteDeAportacionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '   certificadoEntrada.generarReporteAportaciones()
    '  Print.Show()
    ' Print.abrirReporte(variablesGlobales.pathReporteAportaciones)
    'Me.Close()
    'End Sub

    'Private Sub ReporteDeSaldosDeAportacionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '   certificadoEntrada.generarReporteSaldosDeAportaciones()
    '  Print.Show()
    ' Print.abrirReporte(variablesGlobales.pathreporteDeSaldosDeAportaciones)
    'Me.Close()
    'End Sub
End Class