Public Class SocioClase
    Public cedula As String
    Public numAsoc As String
    Public nombre As String
    Public primerApellido As String
    Public segundoApellido As String
    Public fechaNacimineto As DateTime
    Public telefono As String
    Public cuotaMatricula As String
    Public responsable As String
    Public beneficiario As String
    Public fechaIngreso As DateTime
    Public seccion As String
    Public ocupacionEspecialidad As String
    Public direccion As String
    Public genero As String
    Public estado As String
    Public fechaRetiro As DateTime
    Public notasRetiro As String

    Public Sub socioClaseCostructor(ByVal cedulap As String, ByVal numAsocp As String, ByVal nombrep As String,
                          ByVal primerApellidop As String, ByVal segundoApellidop As String,
                          ByVal fechaNaciminetop As DateTime, ByVal telefonop As String, ByVal cuotaMatriculap As String,
                          ByVal responsablep As String, ByVal beneficiariop As String, ByVal fechaIngresop As DateTime,
                          ByVal seccionp As String, ByVal ocupacionEspecialidadp As String,
                          ByVal direccionp As String, ByVal generop As String, ByVal estadop As String,
                          ByVal fechaRetirop As DateTime, ByVal notasRetirop As String)
        nombre = nombrep
        numAsoc = numAsocp
        cedula = cedulap
        primerApellido = primerApellidop
        segundoApellido = segundoApellidop
        fechaNacimineto = fechaNaciminetop
        telefono = telefonop
        cuotaMatricula = cuotaMatriculap
        responsable = responsablep
        beneficiario = beneficiariop
        fechaIngreso = fechaIngresop
        seccion = seccionp
        ocupacionEspecialidad = ocupacionEspecialidadp
        direccion = direccionp
        genero = generop
        estado = estadop
        fechaRetiro = fechaRetirop
        notasRetiro = notasRetirop

    End Sub

End Class
