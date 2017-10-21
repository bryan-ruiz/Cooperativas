Public Class VCertificados

    Dim certificados As Certificados = New Certificados

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
        certificados.validarTracto("1", Me.CertificadosDateTimePickerFecha1.Value)
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

    Private Sub CrearReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearReporteToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub
End Class