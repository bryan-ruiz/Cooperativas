Public Class AportacionesClase

    Public numAsoc As String
    Public nombre As String
    Public primerApellido As String
    Public segundoApellido As String
    Public cedula As String
    Public tipoAsociado As String
    Public estado As String
    Public acumAnterior As Integer
    Public periodoActual As Integer

    Public Sub aportacionesClaseCostructor(ByVal numAsocp As String, ByVal nombrep As String, ByVal primerApellidop As String, ByVal segundoApellidop As String,
                          ByVal cedulap As String, ByVal tipoAsociadop As String, ByVal estadop As String, ByVal acumAnteriorp As Integer, ByVal periodoActualp As Integer)

        numAsoc = numAsocp
        nombre = nombrep
        primerApellido = primerApellidop
        segundoApellido = segundoApellidop
        cedula = cedulap
        tipoAsociado = tipoAsociadop
        estado = estadop
        acumAnterior = acumAnteriorp
        periodoActual = periodoActualp

    End Sub

End Class