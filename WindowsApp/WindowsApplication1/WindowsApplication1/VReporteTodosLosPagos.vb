Public Class VReporteTodosLosPagos
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim certificados As Certificados = New Certificados

    Private Sub VReporteTodosLosPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonReporteTodosLosPagos.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.TextBoxTodosLosPagos.Select()
    End Sub

    Private Sub TextBoxTodosLosPagos_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxTodosLosPagos.KeyPress
        Me.TextBoxTodosLosPagos.MaxLength = 4
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub ButtonReporteTodosLosPagos_Click(sender As Object, e As EventArgs) Handles ButtonReporteTodosLosPagos.Click
        Me.labelWait.Text = "Generando Reporte, por favor espere..."
        certificados.generarReporteTodosLosPAgos()
        Me.labelWait.Text = ""
        Me.Close()
    End Sub
End Class