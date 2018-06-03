
Public Class PacienteClase

    Public cedula As String
    Public nombre As String
    Public primerApellido As String
    Public segundoApellido As String
    Public fechaNacimiento As DateTime
    Public edad As String
    Public telefonoPersonal As String
    Public telefonoTrabajo As String
    Public fechaIngreso As DateTime
    Public direccionResidencia As String
    Public direccionTrabajo As String
    Public genero As String
    Public estado As String
    Public fechaRetiro As DateTime
    Public notasRetiro As String

    Public Sub socioClaseCostructor(ByVal cedulap As String, ByVal nombrep As String, ByVal primerApellidop As String, ByVal segundoApellidop As String,
                                    ByVal fechaNacimientop As DateTime, ByVal edadp As String, ByVal telefonoPersonalp As String,
                                    ByVal telefonoTrabajop As String, ByVal fechaIngresop As DateTime, ByVal direccionResidenciap As String,
                                    ByVal direccionTrabajop As String, ByVal generop As String, ByVal estadop As String,
                                    ByVal fechaRetirop As DateTime, ByVal notasRetirop As String)
        nombre = nombrep
        cedula = cedulap
        primerApellido = primerApellidop
        segundoApellido = segundoApellidop
        fechaNacimiento = fechaNacimientop
        telefonoPersonal = telefonoPersonalp
        telefonoTrabajo = telefonoTrabajop
        fechaIngreso = fechaIngresop
        direccionResidencia = direccionResidenciap
        direccionTrabajo = direccionTrabajop
        genero = generop
        estado = estadop
        fechaRetiro = fechaRetirop
        notasRetiro = notasRetirop

    End Sub

End Class
