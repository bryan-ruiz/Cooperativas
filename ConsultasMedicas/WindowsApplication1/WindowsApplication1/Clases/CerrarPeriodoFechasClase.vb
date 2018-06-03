Public Class CerrarPeriodoFechasClase

    Public fechaDesde As DateTime
    Public fechaHasta As DateTime

    Public Sub cerrarPeriodoFechasConstructor(ByVal fechaDesdep As DateTime, ByVal fechaHastap As DateTime)
        fechaDesde = fechaDesdep
        fechaHasta = fechaHastap
    End Sub

End Class