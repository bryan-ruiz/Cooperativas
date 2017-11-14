Public Class VInformeEconomico

    Dim informeEconomico As InformeEconomico = New InformeEconomico

    Private Sub InformeButtonGenerarInforme_Click(sender As Object, e As EventArgs) Handles InformeButtonGenerarInforme.Click
        informeEconomico.generarInformeEconomico()
        Print.Show()
    End Sub

End Class