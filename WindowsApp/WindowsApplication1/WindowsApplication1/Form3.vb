Public Class Form3
    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub CuerposDirectivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuerposDirectivosToolStripMenuItem.Click
        F_infocuerpodirectivos.Show()
    End Sub
End Class