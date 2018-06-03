Public Class SaldoAportacionesClase

    Public fecha As String
    Public facturaRecibo As String
    Public codigoCuenta As String
    Public total As String

    Public Sub SaldoAportacionesClaseConstructor(ByVal fechap As DateTime, ByVal facturaRecibop As String, ByVal codigoCuentap As String, ByVal totalp As String)
        fecha = fechap
        facturaRecibo = facturaRecibop
        codigoCuenta = codigoCuentap
        total = totalp
    End Sub

End Class
