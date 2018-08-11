Public Class VAcercaDe

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub VAcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub


End Class