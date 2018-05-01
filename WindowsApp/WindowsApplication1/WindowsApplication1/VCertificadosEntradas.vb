Public Class VCertificadosEntradas

    Dim certificadoEntrada As CertificadosEntradas = New CertificadosEntradas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'LOAD 
    Private Sub VIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.CertificadosEntradasAgregarEntrada.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

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
        certificadoEntrada.calcularTotal()
    End Sub

    Private Sub CertificadosEntradasAgregarEntrada_Click(sender As Object, e As EventArgs) Handles CertificadosEntradasAgregarEntrada.Click
        certificadoEntrada.insertarCertificadoEntrada()
    End Sub
End Class