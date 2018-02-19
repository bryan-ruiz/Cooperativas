Public Class VReportePAagosAlDia
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim certificados As Certificados = New Certificados

    Private Sub VReportePAgosAlDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonReportePagosAlDia.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.TextBoxPagosAlDia.Select()
    End Sub

    Private Sub TextBoxPagosAlDia_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxPagosAlDia.KeyPress
        Me.TextBoxPagosAlDia.MaxLength = 4
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ButtonReportePagosAlDia_Click(sender As Object, e As EventArgs) Handles ButtonReportePagosAlDia.Click
        Me.labelWait.Text = "Generando Reporte, por favor espere..."
        certificados.generarReportePagosAldia()
        Me.labelWait.Text = ""
        Print.Show()
        Me.Close()
    End Sub
End Class