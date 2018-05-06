Public Class VReportesTodos

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'LOAD 
    Private Sub VIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

End Class