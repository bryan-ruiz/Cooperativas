Public Class CuentaClase
    Public codDescripcion As String
    Public tipo As String
    Public proyectoProductivo As String
    Public Sub cuentaClaseCostructor(ByVal codDescripcionp As String,
                                    ByVal tipop As String,
                                     ByVal proyectoProductivop As String)
        codDescripcion = codDescripcionp
        tipo = tipop
        proyectoProductivo = proyectoProductivop
    End Sub
End Class
