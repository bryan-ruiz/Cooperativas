
'Clase para los mensajes del sistema
Public Class MensajesGlobales


    'Mensaje Generado con Éxito
    Public reporteGeneradoConExito As String = "Reporte generado con éxito en C:/Reportes/"

    'Crea el folder si no existe
    Public folderPath As String = "C:\Reportes\"

    'ASOCIADOS
    Public pathReporteAsociadosActivos As String = "C:\Reportes\reporte_Asociados_Activos.pdf"
    Public pathReporteAsociadosTodos As String = "C:\Reportes\reporte_Asociados_Todos.pdf"
    Public pathReporteAsociadosExcedenteCorrespondiente As String = "C:\Reportes\reporte_Excedentes_Correspondientes.pdf"
    Public pathReporteAsociadosXSeccion As String = "C:\Reportes\reporte_Asociados_Por_Seccion.pdf"
    Public pathReciboAdmisionAsociado As String = "C:\Reportes\recibo_de_Admision.pdf"

    'COMITÉS
    Public pathReporteCuerposDirectivos As String = "C:\Reportes\reporte_Cuerpos_Directivos.pdf"

    'CERTIFICADOS
    Public pathReporteCertificadosMorosidad As String = "C:\Reportes\reporte_Morosidad.pdf"
    Public pathReporteCertificadosPagosAldia As String = "C:\Reportes\reporte_Pago_Al_Dia.pdf"
    Public pathReporteCertificadosTodosLosPagos As String = "C:\Reportes\reporte_Todos_Los_Pagos.pdf"
    Public pathReporteCertificadosRecibo As String = "C:\Reportes\reporte_Recibo_Certificados.pdf"
    Public pathReporteCertificadosReciboAlDia As String = "C:\Reportes\reporte_Recibo_Certificados_Al_Dia_.pdf"

    'ENTRADAS
    Public pathReporteEntradas As String = "C:\Reportes\reporte_Entradas.pdf"
    Public pathReporteSaldos As String = "C:\Reportes\reporte_De_Saldos.pdf"
    Public pathReporteInformeEconomico As String = "C:\Reportes\reporte_Informe_Economico.pdf"
    Public pathReporteCuentasEntradas As String = "C:\Reportes\reporte_Cuentas_Entradas.pdf"

    'SALIDAS
    Public pathReporteSalidas As String = "C:\Reportes\reporte_Salidas.pdf"
    Public pathReporteCuentasSalidas As String = "C:\Reportes\reporte_Cuentas_Salidas.pdf"

    'GESTIÓN DE RESERVAS
    Public pathReporteSaldosReserva As String = "C:\Reportes\reporte_De_Saldos_De_Reservas.pdf"
    Public pathReporteDeAcumuladoReservas As String = "C:\Reportes\reporte_Acumulado_Reservas.pdf"

    'GESTIÓN DE EXCEDENTES
    Public pathReporteExcedenteEnTransito As String = "C:\Reportes\reporte_Excedentes_En_Transito.pdf"

    'GESTIÓN DE CERTIFICADOS
    Public pathReporteCertificadoEnTransito As String = "C:\Reportes\reporte_Certificados_En_Transito.pdf"



    Public pathReporteAportaciones As String = "C:\Reportes\reporte_De_Aportaciones.pdf"
    Public pathreporteDeSaldosDeAportaciones As String = "C:\Reportes\reporte_De_Saldos_De_Aportaciones.pdf"


    Public favorCerrarAdobeReader As String = "Favor cerrar Adobe Reader en caso de estar abierto y volver a generar el reporte. "
    Public reporteReservas As String = "reporte_Reservas.pdf"
    Public reporteDeSaldosDeAportaciones As String = "reporte_De_Saldos_De_Aportaciones.pdf"




    Public mensajeNoDejarEspaciosVacios As String = "No deben haber campos vacíos!"
    Public reporteSinDatos As String = "No se encontraron datos dentro del reporte"
    Public seHaAcumuladoConExito As String = "Se ha acumulado con éxito"
    Public enQueVentanaEstoy As String = "ninguna"
    Public mensajePdfAbierto As String = "No se puede generar el reporte porque el PDF se encuentra abierto"
    Public mensajePendienteRequerido As String = "Para realizar la acción el estado debe ser: Pendiente"
    Public mensajeCedulaONumAsociado As String = "Debe ingresar la cédula o el número de asociado a consultar"
    Public mensajeDebeIngresarCodigoODescriptionDeCuenta As String = "Debe ingresar el código y/o descripción de la cuenta"
    Public mensajeCedulaFormato As String = "La cédula debe llevar el formato X-XXXX-XXXX"
    Public noExistenDatos As String = "No se encontraron datos en el sistema"
    Public noDebenHaberCamposVacios As String = "No deben haber campos vacíos!"
    Public permisosDeAdminRequeridos As String = "Se requieren permisos de Administrador para realizar la acción"
    Public permisosDeSuperAdminRequeridos As String = "Se requieren permisos de Super Admin para realizar la acción"

    'Mensajes Éxito
    Public retiradoExcedenteExitoso As String = "Se ha retirado el excedente con éxito"
    Public datosIngresadosConExito As String = "Éxito al ingresar Datos!"
    Public datosActualizadosConExito As String = "Éxito al actualizar Datos!"
    Public datosEliminadosConExito As String = "Éxito al eliminar Datos!"
    Public tractosSumadosConExitoParaTodosAsociados As String = "Éxito al sumar los Tractos para todos los Asociados!"

    'Mensajes Error
    Public errorFechaLimiteMenorActual As String = "La fecha actual es mayor a la fecha límite para agregar el Certificado"
    Public errorIngresandoDatos As String = "Error al ingresar los datos en el sistema"
    Public errorActualizandoDatos As String = "Error al actualizar los datos en el sistema"
    Public errorEliminandoDatos As String = "Error al eliminar los datos en el sistema"
    Public errorDe As String = "Error de: "
    Public errorDatosNoNumericos As String = "Error, debe ingresar datos numéricos"
    Public errorTotalEnCero As String = "Error ingresando datos, el Total debe ser mayor a 0"
    Public errorMontoCertificados As String = "Error ingresando datos, el Monto no debe ser mayor al establecido"
    Public errorMontoCertificadosMayorMil As String = "Error ingresando datos, el Total del Periodo no debe ser mayor al establecido"
    Public errorExistenDatosPendientes As String = "Error, no se puede Cerrar el Periodo si existen estados Pendientes en tránsito."
    Public errorFacturaOReciboExiste As String = "Error, la factura o recibo ya se encuentra en el Sistema, favor ingrese una nueva."
    Public errorNumAsociadoExiste As String = "Error, el Número de Asociado ya se encuentra en el Sistema, favor ingrese uno nuevo."
    Public errorNumCedulaExiste As String = "Error, el Número de Cédula ya se encuentra en el Sistema, favor ingrese uno nuevo."
    Public errorAsociadoEnEstadoRetirado As String = "Error, el Asociado se encuentra en estado Retirado, no se puede realizar esta acción. "
    Public errorAsociadoEnEstadoActivo As String = "Error, el Asociado se encuentra en estado Activo, no se puede realizar esta acción. "
    Public errorMontoMayorAlSaldoAportaciones As String = "Error, el monto de la Salida debe ser menor o igual al Saldo Total de las Aportaciones. "
    Public errorMontoMayorAlSaldoTotalDeReserva As String = "Error, el monto de la Salida debe ser menor o igual al Saldo Total de la Reserva Seleccionada. "
    Public errorCodigoCuentaExiste As String = "Error, el Código de Cuenta ya se encuentra en el Sistema, favor ingrese uno nuevo."

    'Consecutivo para recibos
    Public numReciboAsociados As Integer = 1
    Public numReciboCertificados As Integer = 1
    Public numReciboEntradas As Integer = 1


    'Colores para los reportes
    Public colorEncabezado As String = "#0489B1" 'Header de reportes - azul
    Public colorLineas As String = "#D8D8D8" ' color líneas del reporte - gris
    Public colorInformeEconomicoIngresos As String = "#239B56"
    Public colorInformeEconomicoGastoss As String = "#CB4335"   '"#CA6F1E"
    Public colorInformeEconomicoExcedentes As String = "#2E86C1"
    Public colorVerdePositivo As String = "#A9DFBF"
    Public colorRojoNegativo As String = "#F5B7B1"
    Public colorDisenoVerde As String = "#2ABCA7"
    Public colorDisenoMorado As String = "#616497"
    Public colorDisenoCeleste As String = "#01A9DB" 'azul oscuro "#0E5589"  celeste '"#15B3D4"
    Public colorDisenoTurquesa As String = "#47B1B9"
    Public colorDisenoVerdeAgua As String = "#93CE97"
    Public colorDisenoPrincipalAzul As String = "#0E5589"

    'Licencia
    Public licenciasRenovadas As String = "La Licencia se ha renovado con éxito!, favor vuelva a iniciar sesión."
    Public errorRenovandoLicencia As String = "Licencia inválida, para mayor información contacte con el Administrador"
    Public licenciaPermisos = "300"
    Public licenciaCaducada As String = "Su licencia ha caducado, contacte al Administrador del Sistema"
    Public nombreUsuarioOContrasenaIncorrecto As String = "El nombre de usuario o contraseña es incorrecto"

End Class
