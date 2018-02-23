Public Class AcumuladoClase

    Public cedula As String
    Public numAsoc As String
    Public nombre As String
    Public primerApellido As String
    Public segundoApellido As String
    Public acumuladoAnterior As String

    Public Sub acumuladoClaseCostructor(ByVal cedulap As String, ByVal numAsocp As String, ByVal nombrep As String,
                          ByVal primerApellidop As String, ByVal segundoApellidop As String, ByVal acumuladoAnteriorp As String)

        nombre = nombrep
        numAsoc = numAsocp
        cedula = cedulap
        primerApellido = primerApellidop
        segundoApellido = segundoApellidop
        acumuladoAnterior = acumuladoAnteriorp


    End Sub
End Class
