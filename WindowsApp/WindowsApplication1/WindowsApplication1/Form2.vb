Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized, Para maximizar la pantalla'

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Button4.Visible = True
        TextBox1.Enabled = True
        Button3.Visible = False
        Label19.Visible = False
        TextBox14.Visible = False
        limpiarCampos(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Visible = True
        Label19.Visible = True
        TextBox14.Visible = True
        TextBox1.Enabled = False
        Button4.Visible = False
        limpiarCampos(Me)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Ingreso Exitoso")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Actualización Exitosa")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        limpiarCampos(Me)
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            TextBox6.Enabled = True
            DateTimePicker1.Enabled = True
        End If
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            TextBox6.Enabled = False
            DateTimePicker1.Enabled = False
        End If
    End Sub
    Private Sub RegistroDeAsociadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeAsociadosToolStripMenuItem.Click
        F_infogestionusuarios.Show()
    End Sub
End Class