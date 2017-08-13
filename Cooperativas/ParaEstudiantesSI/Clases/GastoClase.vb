Public Class GastoClase
    Public fecha As DateTime
    Public facturaRecibo As String
    Public proveedor As String
    Public descripcripcion As String
    Public cantidad As String
    Public precioUnitario As String
    Public total As String
    Public codCuenta As String

    Public Sub ingresoClaseCostructor(ByVal fechap As DateTime,
                                     ByVal proveedorP As String,
                                     ByVal descripcripcionp As String,
                                     ByVal cantidadp As String,
                                     ByVal precioUnitariop As String,
                                     ByVal totalp As String,
                                     ByVal codCuentap As String,
                                     ByVal facturaRecibop As String)
        fecha = fechap
        facturaRecibo = facturaRecibop
        proveedor = proveedorP
        descripcripcion = descripcripcionp
        cantidad = cantidadp
        precioUnitario = precioUnitariop
        total = totalp
        codCuenta = codCuentap
    End Sub
End Class
