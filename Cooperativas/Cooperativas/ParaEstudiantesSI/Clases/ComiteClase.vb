Public Class ComiteClase
    Public tipoConsejo As String
    Public nombreCompleto As String
    Public ocupacion As String
    Public menor As String
    Public fechaRige As DateTime
    Public fechaVence As DateTime
    Public cedual As String
    Public tipo As String

    Public Sub comiteClaseCostructor(ByVal tipoConsejop As String, ByVal nombreCompletop As String,
                                    ByVal ocupacionp As String, ByVal menorp As String,
                                    ByVal fechaRigep As DateTime, ByVal fechaVencep As DateTime,
                                    ByVal cedulap As String, ByVal tipop As String)
        tipoConsejo = tipoConsejop
        nombreCompleto = nombreCompletop
        ocupacion = ocupacionp
        menor = menorp
        fechaRige = fechaRigep
        fechaVence = fechaVencep
        cedual = cedulap
        tipo = tipop
    End Sub



End Class
