Public Class VInformeEconomico

    Dim informeEconomico As InformeEconomico = New InformeEconomico
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub InformeButtonGenerarInforme_Click(sender As Object, e As EventArgs) Handles InformeButtonGenerarInforme.Click
        informeEconomico.generarInformeEconomico()
        Print.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub VInformeEconomico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.InformeButtonGenerarInforme.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub
End Class