﻿
'Clase para los mensajes del sistema
Public Class MensajesGlobales

    Public folderPath As String = "C:\Reportes\"
    Public mensajeCedulaONumAsociado As String = "Debe ingresar la cédula o el número de asociado a consultar"
    Public mensajeDebeIngresarCodigoODescriptionDeCuenta As String = "Debe ingresar el codigo y/o descripción de la cuenta"
    Public mensajeCedulaFormato As String = "La cédula debe llevar el formato X-XXXX-XXXX"

    Public noExistenDatos As String = "No se encontraron datos en el sistema"
    Public noDebenHaberCamposVacios As String = "No deben haber campos vacíos!"
    Public reporteGeneradoConExito As String = "Reporte generado con éxito en C:/Reportes/"
    Public permisosDeAdminRequeridos As String = "Se requieren permisos de Administrador para realizar la acción"

    Public datosIngresadosConExito As String = "Datos ingresados con éxito!"
    Public datosActualizadosConExito As String = "Datos actualizados con éxito!"
    Public datosEliminadosConExito As String = "Datos eliminados con éxito!"

    Public errorFechaLimiteMenorActual As String = "Error, la fecha límite es menor a la actual"
    Public errorIngresandoDatos As String = "Error al ingresar los datos en el sistema"
    Public errorActualizandoDatos As String = "Error al actualizar los datos en el sistema"
    Public errorEliminandoDatos As String = "Error al eliminar los datos en el sistema"
    Public errorDe As String = "Error de: "
    Public errorDatosNoNumericos As String = "Error, debe ingresar datos numéricos"

    Public licenciaCaducada As String = "Su licencia ha caducado, contacte al Administrador del Sistema"
    Public nombreUsuarioOContrasenaIncorrecto As String = "El nombre de usuario o contraseña es incorrecto"

End Class
