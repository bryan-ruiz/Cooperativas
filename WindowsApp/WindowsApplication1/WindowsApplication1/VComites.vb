Public Class VComites

    Dim comites As Comites = New Comites

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Principal.Show()
    End Sub

    Private Sub CuerposDirectivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuerposDirectivosToolStripMenuItem.Click
        VInformacionCuerposDirectivos.Show()
    End Sub

    Private Sub ToolStripMenuReporteComites_Click(sender As Object, e As EventArgs) Handles ToolStripMenuReporteComites.Click
        comites.generarReporteDeComites()
        Print.Show()
    End Sub

    Private Sub ButtonVComitesGuardar_Click(sender As Object, e As EventArgs) Handles ButtonVComitesGuardar.Click
        comites.actualizarComiteF()
    End Sub

    Private Sub ButtonBuscar_asociadoPresidente_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoPresidente.Click
        comites.buscar("presidente")
    End Sub

    Private Sub ButtonBuscar_asociadoVicePresidente_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoVicePresidente.Click
        comites.buscar("vicePresidente")
    End Sub

    Private Sub ButtonBuscar_asociadoSecretaria_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoSecretaria.Click
        comites.buscar("secretaria")
    End Sub

    Private Sub ButtonBuscar_asociadoVocal1_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoVocal1.Click
        comites.buscar("vocal1")
    End Sub

    Private Sub ButtonBuscar_asociadoVocal2_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoVocal2.Click
        comites.buscar("vocal2")
    End Sub

    Private Sub ButtonBuscar_asociadoSuplente1_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoSuplente1.Click
        comites.buscar("suplente1")
    End Sub

    Private Sub ButtonBuscar_asociadoSuplente2_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoSuplente2.Click
        comites.buscar("suplente2")
    End Sub

    Private Sub ComboBoxComitesNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxComitesNombre.SelectedIndexChanged
        comites.limpiar()
        comites.consultar(ComboBoxComitesNombre.Text)
    End Sub

    Private Sub ButtonVComitesLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonVComitesLimpiar.Click
        comites.limpiar()
    End Sub

    Private Sub VComites_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class