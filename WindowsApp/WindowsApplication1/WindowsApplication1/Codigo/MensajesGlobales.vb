
'Clase para los mensajes del sistema
Public Class MensajesGlobales

    Public reporteSinDatos As String = "No se encontraron datos dentro del reporte"

    Public folderPath As String = "C:\Reportes\"

    Public seHaAcumuladoConExito As String = "Se ha acumulado con éxito"
    Public enQueVentanaEstoy As String = "ninguna"

    Public retiradoExcedenteExitoso As String = "Se ha retirado el excedente con éxito"

    Public nombreReporteExcCorresp As String = "reporte_Excedentes_Correspondientes.pdf"
    Public reporteMorosidad As String = "reporte_Morosidad.pdf"
    Public reportePagoAlDia As String = "reporte_Pago_Al_Dia.pdf"
    Public reporteTodosPago As String = "reporte_Todos_Los_Pagos.pdf"
    Public reporteReservas As String = "reporte_Reservas.pdf"

    Public mensajeNoDejarEspaciosVacios As String = "No deben haber campos vacíos!"

    Public licenciaPermisos = "300"

    Public mensajePdfAbierto As String = "No se puede generar el reporte porque el PDF se encuentra abierto"

    Public mensajeCedulaONumAsociado As String = "Debe ingresar la cédula o el número de asociado a consultar"
    Public mensajeDebeIngresarCodigoODescriptionDeCuenta As String = "Debe ingresar el codigo y/o descripción de la cuenta"
    Public mensajeCedulaFormato As String = "La cédula debe llevar el formato X-XXXX-XXXX"

    Public noExistenDatos As String = "No se encontraron datos en el sistema"
    Public noDebenHaberCamposVacios As String = "No deben haber campos vacíos!"
    Public reporteGeneradoConExito As String = "Reporte generado con éxito en C:/Reportes/"
    Public permisosDeAdminRequeridos As String = "Se requieren permisos de Administrador para realizar la acción"
    Public permisosDeSuperAdminRequeridos As String = "Se requieren permisos de Super Admin para realizar la acción"

    Public datosIngresadosConExito As String = "Datos ingresados con éxito!"
    Public datosActualizadosConExito As String = "Datos actualizados con éxito!"
    Public datosEliminadosConExito As String = "Datos eliminados con éxito!"

    Public errorFechaLimiteMenorActual As String = "La fecha actual es mayor a la fecha límite para agregar el Certificado"
    Public errorIngresandoDatos As String = "Error al ingresar los datos en el sistema"
    Public errorActualizandoDatos As String = "Error al actualizar los datos en el sistema"
    Public errorEliminandoDatos As String = "Error al eliminar los datos en el sistema"
    Public errorDe As String = "Error de: "
    Public errorDatosNoNumericos As String = "Error, debe ingresar datos numéricos"
    Public errorTotalEnCero As String = "Error ingresando datos, el Total debe ser mayor a 0"
    Public errorMontoCertificados As String = "Error ingresando datos, el Monto no debe ser mayor al establecido"
    Public errorMontoCertificadosMayorMil As String = "Error ingresando datos, el Total del Periodo no debe ser mayor al establecido"
    Public errorExistenDatosPendientes As String = "Error no se puede realizar cierre porque existen datos pendientes"

    Public licenciaCaducada As String = "Su licencia ha caducado, contacte al Administrador del Sistema"
    Public nombreUsuarioOContrasenaIncorrecto As String = "El nombre de usuario o contraseña es incorrecto"

    Public colorEncabezado As String = "#0489B1" 'Header de reportes - azul
    Public colorLineas As String = "#D8D8D8" ' color líneas del reporte - gris
    Public colorInformeEconomicoIngresos As String = "#239B56"
    Public colorInformeEconomicoGastoss As String = "#CB4335"   '"#CA6F1E"
    Public colorInformeEconomicoExcedentes As String = "#2E86C1"
    Public colorVerdePositivo As String = "#A9DFBF"
    Public colorRojoNegativo As String = "#F5B7B1"

    Public numReciboAsociados As Integer = 1
    Public numReciboCertificados As Integer = 1
    Public numReciboEntradas As Integer = 1

    Public colorDisenoVerde As String = "#2ABCA7"
    Public colorDisenoMorado As String = "#616497"
    Public colorDisenoCeleste As String = "#15B3D4"
    Public colorDisenoTurquesa As String = "#47B1B9"
    Public colorDisenoVerdeAgua As String = "#93CE97"

    Public licenciasRenovadas As String = "La Licencia se ha renovado con éxito!, favor vuelva a iniciar sesión."
    Public errorRenovandoLicencia As String = "Licencia inválida, para mayor información contacte con el Administrador"


End Class
