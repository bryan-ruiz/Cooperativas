Public Class SaldoClase

    Public fecha As String
    Public codigoCuenta As String
    Public total As String

    Public Sub saldoClaseCostructor(ByVal fechap As DateTime,
                                    ByVal codigoCuentap As String,
                                    ByVal totalp As String)
        fecha = fechap
        codigoCuenta = codigoCuentap
        total = totalp
    End Sub

End Class
