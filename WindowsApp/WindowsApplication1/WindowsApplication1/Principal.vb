Public Class Principal
    Private Sub GestionUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripMenuItem.Click
        VAsociados.Show()
    End Sub

    Private Sub ComitésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComitésToolStripMenuItem.Click
        VComites.Show()
    End Sub

    Private Sub CertificadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificadosToolStripMenuItem.Click
        VCertificados.Show()
    End Sub

    Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click
        VIngresos.Show()
    End Sub

    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem.Click
        VGastos.Show()
    End Sub

    Private Sub FechasCertificadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechasCertificadosToolStripMenuItem.Click
        VConfiguracionFechasLimite.Show()
    End Sub

    Private Sub CodigosDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodigosDeCuentasToolStripMenuItem.Click
        VConfiguracionCodigoCuenta.Show()
    End Sub

    Private Sub PorcentajesReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorcentajesReservasToolStripMenuItem.Click
        VConfiguracionPorcentajeReservas.Show()
    End Sub

    Private Sub InformaciónCooperativaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónCooperativaToolStripMenuItem.Click
        VConfiguracionInformacionCooperativa.Show()
    End Sub

    Private Sub GestiónDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeUsuariosToolStripMenuItem.Click
        'VGestionAsociados.Show()
        MessageBox.Show("Contacte al Administrador, no se tiene licencia para ingresar usuarios nuevos al sistema")
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    '// Evento para salir del sistema, cierra todas ventanas abiertas
    Private Sub salirAPP(sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.Closing
        Dim result As DialogResult = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = System.Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else

            Try
                Environment.Exit(1)

                ' VIngresos.Close()
                'VIngresosReporte.Close()
                'VGastos.Close()
                'VGastosReporte.Close()
                'VInformeEconomico.Close()
                'VGestionAsociados.Close()

                'xxxxx VConfiguracionPorcentajeReservas.Close()
                'VConfiguracionInformacionCooperativa.Close()
                'VConfiguracionFechasLimite.Close()
                'VConfiguracionCodigoCuenta.Close()
                'VInformacionCuerposDirectivos.Close()
                'VInformacionAnexoAsociados.Close()


                'VComites.Close()
                'VCertificados.Close()
                'VSignIn.Close()

                ' Me.Close()

            Catch ex As InvalidOperationException
                'nothing
            End Try
        End If
    End Sub






End Class
