Public Class VCertificados

    Dim certificados As Certificados = New Certificados
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub CertificadosButtonConsultar_Click(sender As Object, e As EventArgs) Handles CertificadosButtonConsultar.Click
        certificados.consultar()
    End Sub

    Private Sub CertificadosButtonCerrarPeriodo_Click(sender As Object, e As EventArgs) Handles CertificadosButtonCerrarPeriodo.Click
        certificados.cerrarCertificado()
    End Sub

    Private Sub CertificadosButtonLimpiar_Click(sender As Object, e As EventArgs) Handles CertificadosButtonLimpiar.Click
        certificados.limpiar()
    End Sub

    Private Sub CertificadosButtonSaveTracto1_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto1.Click
        certificados.validarTracto("1", Me.CertificadosDateTimePickerFecha1.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto2_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto2.Click
        certificados.validarTracto("2", Me.CertificadosDateTimePickerFecha2.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto3_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto3.Click
        certificados.validarTracto("3", Me.CertificadosDateTimePickerFecha3.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto4_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto4.Click
        certificados.validarTracto("4", Me.CertificadosDateTimePickerFecha4.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto5_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto5.Click
        certificados.validarTracto("5", Me.CertificadosDateTimePickerFecha5.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto6_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto6.Click
        certificados.validarTracto("6", Me.CertificadosDateTimePickerFecha6.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto7_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto7.Click
        certificados.validarTracto("7", Me.CertificadosDateTimePickerFecha7.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto8_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto8.Click
        certificados.validarTracto("8", Me.CertificadosDateTimePickerFecha8.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto9_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto9.Click
        certificados.validarTracto("9", Me.CertificadosDateTimePickerFecha9.Value)
    End Sub

    Private Sub CertificadosButtonSaveTracto10_Click(sender As Object, e As EventArgs) Handles CertificadosButtonSaveTracto10.Click
        certificados.validarTracto("10", Me.CertificadosDateTimePickerFecha10.Value)
    End Sub

    Private Sub CrearReporteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub CertificadosTextboxTracto1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosTextboxTracto1.KeyPress
        Me.CertificadosTextboxTracto1.MaxLength = 3
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosTextboxTracto2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosTextboxTracto2.KeyPress
        Me.CertificadosTextboxTracto2.MaxLength = 3
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosTextboxTracto3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosTextboxTracto3.KeyPress
        Me.CertificadosTextboxTracto3.MaxLength = 3
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosTextboxTracto4_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosTextboxTracto4.KeyPress
        Me.CertificadosTextboxTracto4.MaxLength = 3
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosTextboxTracto5_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosTextboxTracto5.KeyPress
        Me.CertificadosTextboxTracto5.MaxLength = 3
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosTextboxTracto6_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosTextboxTracto6.KeyPress
        Me.CertificadosTextboxTracto6.MaxLength = 3
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosTextboxTracto7_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosTextboxTracto7.KeyPress
        Me.CertificadosTextboxTracto7.MaxLength = 3
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosTextboxTracto8_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosTextboxTracto8.KeyPress
        Me.CertificadosTextboxTracto8.MaxLength = 3
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosTextboxTracto9_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosTextboxTracto9.KeyPress
        Me.CertificadosTextboxTracto9.MaxLength = 3
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CertificadosTextboxTracto10_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CertificadosTextboxTracto10.KeyPress
        Me.CertificadosTextboxTracto10.MaxLength = 3
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub VCertificados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        certificados.consultarFechasLimite()

        Me.Panel3.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.CertificadosButtonCerrarPeriodo.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.CertificadosButtonLimpiar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

    End Sub

    Private Sub ImprimirComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirComprobanteToolStripMenuItem.Click
        certificados.imprimirComprobanteCertificadosNew()
    End Sub


    Private Sub CertificadosTextboxCedulaNumAsociado_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles CertificadosTextboxCedulaNumAsociado.KeyPress
        'TextBoxSociosConsultarAsociado.PasswordChar = "*"
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call CertificadosButtonConsultar_Click(sender, e)
        End If
    End Sub
End Class