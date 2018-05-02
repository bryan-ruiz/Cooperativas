Public Class VCertificadosSalidas

    Dim certificadoSalida As CertificadosSalidas = New CertificadosSalidas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub VCertificadosSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.CertificadosSalidasAgregarEntrada.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    Private Sub CertificadosSalidasCantidad_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosSalidasCantidad.KeyPress
        Me.CertificadosSalidasCantidad.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosSalidasCalcularTotal_Click(sender As Object, e As EventArgs) Handles CertificadosSalidasCalcularTotal.Click
        certificadoSalida.calcularTotal()
    End Sub

    Private Sub CertificadosSalidasTotal_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosSalidasTotal.KeyPress
        Me.CertificadosSalidasTotal.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosSalidasPrecioUnitario_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosSalidasPrecioUnitario.KeyPress
        Me.CertificadosSalidasPrecioUnitario.MaxLength = 12
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosSalidasAgregarEntrada_Click(sender As Object, e As EventArgs) Handles CertificadosSalidasAgregarEntrada.Click
        certificadoSalida.insertarCertificadoSalida()
    End Sub
End Class