Public Class MotivoConsultaClase

    Public cedula As String
    Public fecha As DateTime
    Public valor As String
    Public motivo As String

    Public Sub motivoConsultaClaseConstructor(ByVal cedulap As String, ByVal fechap As DateTime, ByVal valorp As String, ByVal motivop As String)

        cedula = cedulap
        fecha = fechap
        valor = valorp
        motivo = motivop
    End Sub

End Class
