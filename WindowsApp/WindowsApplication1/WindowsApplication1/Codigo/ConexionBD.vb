'Importamos las librerias que usaremos para el manejo de la conexión'
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class ConexionBD
    'Declaro las variables de control
    Dim objConexion As OleDbConnection 'Permite hacer una conexion'
    Dim objAdap1 As OleDbDataAdapter 'Lo utilizaremos ejecutar consultas'
    Dim objAdap2 As OleDbDataAdapter 'Lo utilizaremos ejecutar consultas'
    Dim conectadoBD As Boolean = False 'Nos indica si estamos conectados a la BD, inicia como falso'
    Public SQL As String 'Se utiliza para escribir el Query que se quiere ejecutar'
    'Iniciar Conexion'
    Sub ConectarBD()
        Try
            'WORKING WITHOUT PASSWORD ON THE DATA BASE
            'objConexion = New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=" & "C:/BD/CoopeBD.mdb")

            'WORKING WITH PASSWORD ON THE DATA BASE
            objConexion = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source =" & "C:/BD/CoopeBD.mdb;Jet OLEDB:Database Password=C454gr154;")

            'objConexion = New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=" & My.Application.Info.DirectoryPath & "/BD.mdb")

            'Abro la conexion'
            objConexion.Open()
            'Valido que se esta conectado'
            conectadoBD = True

        Catch ex As Exception
            conectadoBD = False
            MessageBox.Show("Error: " & vbCrLf & ex.Message) 'before ex.ToString

            'Console.WriteLine(vbCrLf & "Message ---" & vbCrLf & ex.Message)
            'Console.WriteLine(vbCrLf & "HelpLink ---" & vbCrLf & ex.HelpLink)
            'Console.WriteLine(vbCrLf & "Source ---" & vbCrLf & ex.Source)
            'Console.WriteLine(vbCrLf & "StackTrace ---" & vbCrLf & ex.StackTrace)
            'Console.WriteLine(vbCrLf & "TargetSite ---" & vbCrLf & ex.TargetSite.ToString())

        End Try
    End Sub

    'Cierra la conexion a la BD'
    'Parametros: ninguno'
    'Resultado esperado: La conexion es finalizada'
    Sub CerrarConexion()
        Try
            objConexion.Close()
            conectadoBD = False
        Catch ex As Exception
            MessageBox.Show("Se presentó la siguiente exepción: " & ex.Message)
        End Try
    End Sub


    'Inserta un usuario  
    Function insertarUsuario(ByVal rol As String, ByVal usuario As String, ByVal contrasena As String, ByVal permisos As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar, en este caso es insertar'
            SQL = "INSERT INTO [USUARIOS]" &
           "(Usuario, Rol, Contrasena, Permisos)" &
            "VALUES ('" + usuario + "', '" + rol + "', '" + contrasena + "', '" + permisos + "')"
            'Comando para ejecutar el query'
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try
        Return res
    End Function


    'Aumentar veces login usuario  
    Function loginNuevo(ByVal permisos As String, ByVal usuario As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar, en este caso es insertar'
            SQL = "UPDATE [USUARIOS] SET Permisos = '" & permisos & "' WHERE ((Usuario) = '" & usuario & "')"
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try
        Return res
    End Function

    'Eliminar un usuario  
    Function eliminarUsuario(ByVal usuario As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar, en este caso es eliminar'

            SQL = "DELETE FROM [USUARIOS]" &
            "WHERE Usuario = ('" + usuario + "')"
            'Comando para ejecutar el query'
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try
        Return res
    End Function

    'Buscar un usuario  
    Function buscarUsuario(ByVal usuario As String, ByVal contrasena As String) As List(Of String)
        Dim MyList As New List(Of String)
        Try
            'Declaramos el query que queremos ejecutar, en este caso es eliminar'

            SQL = "Select USUARIOS.* FROM [USUARIOS]" &
            "WHERE Usuario = ('" + usuario + "') AND Contrasena = ('" + contrasena + "')"
            'Comando para ejecutar el query'
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1
                        'MsgBox(String.Concat(" ", reader(conta)))
                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try
        Return MyList
    End Function



    'Selecciona todos los campos de un Socio por número de cédula
    Function consultarSocioPorCedula(ByVal cedula As String) As List(Of String)
        Dim MyList As New List(Of String)
        Try
            SQL = "SELECT SOCIOS.* FROM [SOCIOS] WHERE ((cedula) = '" & cedula & "')"
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1
                        'MsgBox(String.Concat(" ", reader(conta)))
                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    '///////////////// CERTIFICADOS ///////////////////

    'Selecciona cedula, num asociado y datos de los certificados por Asociado
    Function consultarAsociadoCedOrNum(ByVal cedulaONumAsociado As String) As List(Of String)
        Dim MyList As New List(Of String)
        Try
            SQL = "SELECT SOCIOS.*
                    FROM [SOCIOS]
                    WHERE ((SOCIOS.cedula) = '" & cedulaONumAsociado & "' or (SOCIOS.numAsociado)= '" & cedulaONumAsociado & "') "

            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1
                        'MsgBox(String.Concat(" ", reader(conta)))
                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList

    End Function

    Function obtenerDatosReporteDeSocios(ByVal tipoReporte As String) As List(Of SocioClase)
        Dim MyList As New List(Of SocioClase)
        Try
            If tipoReporte = "Activos" Then
                SQL = "SELECT SOCIOS.* FROM [SOCIOS] WHERE ((estado) = 'Activo')"
            Else
                SQL = "SELECT SOCIOS.* FROM [SOCIOS]"
            End If

            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim nuevosocio As SocioClase = New SocioClase
                    nuevosocio.socioClaseCostructor(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                                                    reader.GetString(3), reader.GetString(4), reader.GetDateTime(5),
                                                    reader.GetString(6), reader.GetString(7), reader.GetString(8),
                                                    reader.GetString(9), reader.GetDateTime(10), reader.GetString(11),
                                                    reader.GetString(12), reader.GetString(13), reader.GetString(14),
                                                    reader.GetString(15), reader.GetDateTime(16), reader.GetString(17))
                    MyList.Add(nuevosocio)
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de que madre: " + ex.Message)
        End Try
        Return MyList
    End Function


    'Selecciona todos los campos de un Socio por número de socio
    Function consultarSocioPorNumAsociado(ByVal numAsociado As String) As List(Of String)
        Dim MyList As New List(Of String)
        Try
            SQL = "SELECT SOCIOS.* FROM [SOCIOS] WHERE ((numAsociado) = '" & numAsociado & "')"
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1
                        'MsgBox(String.Concat(" ", reader(conta)))
                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList

    End Function

    'Inserta un Socio
    Function insertarSocio(ByVal cedula As String, ByVal numAsociado As String, ByVal nombre As String, ByVal apellidoUno As String, ByVal apellidoDos As String, ByVal fechaNacimiento As Date, ByVal telefono As String,
                           ByVal cuota As String, ByVal responsable As String, ByVal beneficiario As String, ByVal fechaIngreso As Date, ByVal seccion As String, ByVal especialidad As String, ByVal direccion As String,
                           ByVal genero As String, ByVal estado As String, ByVal fechaRetiro As Date, notasRetiro As String,
                           ByVal menor As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar, en este caso es insertar'
            SQL = "INSERT INTO [SOCIOS]" &
           "(cedula, numAsociado, nombre, primerApellido, segundoApellido, fechaNacimiento, telefono, cuotaMatricula, responsable, beneficiario, fechaIngreso, seccion, ocupacionEspecialidad, direccion, genero, estado, fechaRetiro, notasRetiro,menor)" &
            "VALUES ('" + cedula + "', '" + numAsociado + "', '" + nombre + "', '" + apellidoUno + "', '" + apellidoDos + "', '" + fechaNacimiento + "', '" + telefono + "', '" + cuota + "' , '" + responsable + "', '" + beneficiario + "', '" + fechaIngreso + "',
            '" + seccion + "', '" + especialidad + "', '" + direccion + "', '" + genero + "', '" + estado + "', '" + fechaRetiro + "', '" + notasRetiro + "', '" + menor + "')"
            'Comando para ejecutar el query'
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            'MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.ToString)
        End Try

        Return res
    End Function

    'Inserta un Certificado X Socio
    Function insertarCertificadoXSocio(ByVal cedulaAsociado As String, ByVal numAsociado As String, ByVal tracto1 As String, ByVal tracto2 As String, ByVal tracto3 As String,
                                       ByVal tracto4 As String, ByVal tracto5 As String, ByVal tracto6 As String, ByVal tracto7 As String, ByVal tracto8 As String, ByVal tracto9 As String, ByVal tracto10 As String,
                                       acumuladoAnterior As String, ByVal total As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar, en este caso es insertar'
            SQL = "INSERT INTO [CERTIFICADOS]" &
           "(cedulaAsociado, numAsociado, tracto1, tracto2, tracto3, tracto4, tracto5, tracto6, tracto7, tracto8, tracto9, tracto10, acumuladoAnterior, total)" &
            "VALUES ('" + cedulaAsociado + "', '" + numAsociado + "', '" + tracto1 + "', '" + tracto2 + "', '" + tracto3 + "', '" + tracto4 + "', '" + tracto5 + "', '" + tracto6 + "' ,
            '" + tracto7 + "', '" + tracto8 + "', '" + tracto9 + "', '" + tracto10 + "', '" + acumuladoAnterior + "', '" + total + "')"
            'Comando para ejecutar el query'
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try

        Return res
    End Function

    'Actualiza la info del Socio
    Function actualizarSocio(ByVal cedula As String, ByVal numAsociado As String, ByVal nombre As String, ByVal primerApellido As String,
                             ByVal segundoApellido As String, ByVal fechaNacimiento As Date, ByVal telefono As String,
                             ByVal cuotaMatricula As String, ByVal responsable As String, ByVal beneficiario As String,
                             ByVal fechaIngreso As Date, ByVal seccion As String, ByVal ocupacionEspecialidad As String,
                             ByVal direccion As String, ByVal genero As String, ByVal estado As String, ByVal fechaRetiro As Date,
                             notasRetiro As String, menor As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar, en este caso es insertar'
            SQL = "UPDATE [SOCIOS] SET numAsociado = '" & numAsociado & "', " & "menor = '" & menor & "', " & "nombre = '" & nombre & "', " & "primerApellido = '" & primerApellido & "',
" & "segundoApellido = '" & segundoApellido & "', " & "fechaNacimiento = '" & fechaNacimiento & "', " & "telefono = '" & telefono & "', " & "cuotaMatricula = '" & cuotaMatricula & "',
" & "responsable = '" & responsable & "',   " & "beneficiario = '" & beneficiario & "',  " & "fechaIngreso = '" & fechaIngreso & "', " & "seccion = '" & seccion & "', 
" & "ocupacionEspecialidad = '" & ocupacionEspecialidad & "', " & "direccion = '" & direccion & "',  " & "genero = '" & genero & "',  " & "estado = '" & estado & "',  
" & "fechaRetiro = '" & fechaRetiro & "', " & "notasRetiro = '" & notasRetiro & "' WHERE ((cedula) = '" & cedula & "')"
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try

        Return res
    End Function


    Function eliminar_relacion(ByVal cod As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar
            SQL = "DELETE FROM [Relacion_Laboral] WHERE ((Cod_trabajador) = '" & cod & "')"
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR, Se presentó la siguiente exepción:" & ex.Message())
        End Try
        Return res
    End Function

    'selecciona todos los campos de un socio por numero de cedula o de asociado
    Function buscarSocio(ByVal id As String) As List(Of String)
        Dim MyList As New List(Of String)
        Try
            SQL = "SELECT SOCIOS.* FROM [SOCIOS] WHERE ((cedula) = '" & id & "' or (numAsociado)= '" & id & "')"
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1
                        'MsgBox(String.Concat(" ", reader(conta)))
                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    'FUNCIONES DE COMITE EN BASE DE DATOS
    Function obtenerDatosdeUnComite(ByVal idComite As String) As List(Of ComiteClase)
        Dim MyList As New List(Of ComiteClase)
        Try
            SQL = "SELECT CONSEJOS.* FROM [CONSEJOS] WHERE ((tipoConsejo)= '" & idComite & "')"
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim nuevosocio As ComiteClase = New ComiteClase
                    Try
                        nuevosocio.comiteClaseCostructor(reader.GetString(1), reader.GetString(2), reader.GetString(3),
                                                    reader.GetString(4), reader.GetDateTime(5), reader.GetDateTime(6),
                                                    reader.GetString(7), reader.GetString(8))
                        MyList.Add(nuevosocio)
                    Catch ex As Exception

                    End Try

                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la base de datos: " + ex.Message)
        End Try
        Return MyList
    End Function

    ''Para poder actualizar a un comité
    Function actualizarComite(ByVal nombreCompleto As String, ByVal ocupacion As String, ByVal menor As String, ByVal fechaRige As Date, ByVal fechaVence As Date, ByVal cedula As String,
                              ByVal tipoConsejo As String, ByVal puesto As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar
            SQL = "UPDATE [CONSEJOS] SET nombreCompleto = '" & nombreCompleto & "', " & "ocpacion = '" & ocupacion & "', " & "menor = '" & menor & "', " & "fechaRige = '" & fechaRige & "',  
" & "fechaVence = '" & fechaVence & "', " & "cedula = '" & cedula & "' WHERE ((tipoConsejo) = '" & tipoConsejo & "' and (tipo) = '" & puesto & "' )"
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try

        Return res
    End Function

    '/////////////////////////////// CONFIGURACION /////////////////////////////////

    Function obtenerDatosdeConfiguration() As List(Of ConfiguracionClase)
        Dim MyList As New List(Of ConfiguracionClase)
        Try
            SQL = "SELECT CONFIGURACION.* FROM [CONFIGURACION]"
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim nuevaConfiguracion As ConfiguracionClase = New ConfiguracionClase
                    Try
                        nuevaConfiguracion.configuracionClaseCostructor(reader.GetString(1), reader.GetString(2), reader.GetString(3),
                                                    reader.GetString(4), reader.GetDateTime(5), reader.GetDateTime(6),
                                                    reader.GetDateTime(7), reader.GetDateTime(8), reader.GetDateTime(9),
                                                    reader.GetDateTime(10), reader.GetDateTime(11), reader.GetDateTime(12),
                                                    reader.GetDateTime(13), reader.GetDateTime(14), reader.GetString(15),
                                                    reader.GetString(16), reader.GetString(17), reader.GetString(18), reader.GetString(19))
                        MyList.Add(nuevaConfiguracion)
                    Catch ex As Exception
                        MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
                    End Try
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la base de datos: " + ex.Message)
        End Try
        Return MyList
    End Function

    'Actualiza la info de Configuracion
    Function actualizarConfiguracion(ByVal periodo As String, ByVal cooperativa As String, ByVal cedulaJuridica As String, ByVal telefono As String,
                                     ByVal fecha1 As Date, ByVal fecha2 As Date, ByVal fecha3 As Date, ByVal fech4 As Date, ByVal fecha5 As Date,
                                     ByVal fecha6 As Date, ByVal fecha7 As Date, ByVal fecha8 As Date, ByVal fecha9 As Date, ByVal fecha10 As Date,
                                     ByVal legal As String, ByVal educacion As String, ByVal bienestarSocial As String,
                                     ByVal institucional As String, ByVal patrimonial As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar
            SQL = "UPDATE [CONFIGURACION] SET periodo = '" & periodo & "', " & "cooperativa = '" & cooperativa & "', " & "cedulaJuridica = '" & cedulaJuridica & "',
    " & "telefono = '" & telefono & "',  " & "fechaLimite1 = '" & fecha1 & "', " & "fechaLimite2 = '" & fecha2 & "', " & "fechaLimite3 = '" & fecha3 & "', " & "fechaLimite4 = '" & fech4 & "',
" & "fechaLimite5 = '" & fecha5 & "',   " & "fechaLimite6 = '" & fecha6 & "',  " & "fechaLimite7 = '" & fecha7 & "', " & "fechaLimite8 = '" & fecha8 & "',  " & "fechaLimite9 = '" & fecha9 & "',
" & "fechaLimite10 = '" & fecha10 & "',  " & "legal = '" & legal & "',  " & "educacion = '" & educacion & "',  " & "bienestarSocial = '" & bienestarSocial & "',
" & "Institucional = '" & institucional & "', " & "Patrimonial = '" & patrimonial & "' "
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try

        Return res
    End Function

    'Actualiza la info de Configuracion
    Function actualizarConfiguracionInformacionCooperativa(ByVal periodo As String, ByVal cooperativa As String, ByVal cedulaJuridica As String, ByVal telefono As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar
            SQL = "UPDATE [CONFIGURACION] SET periodo = '" & periodo & "', " & "cooperativa = '" & cooperativa & "', " & "cedulaJuridica = '" & cedulaJuridica & "', " & "telefono = '" & telefono & "' "
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try

        Return res
    End Function


    'Actualiza la info de Configuracion porcentaje de reservas
    Function actualizarConfiguracionPorcentajeReservas(ByVal legal As String, ByVal educacion As String, ByVal bienestarSocial As String, ByVal institucional As String, ByVal patrimonial As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar
            SQL = "UPDATE [CONFIGURACION] SET legal = '" & legal & "',  " & "educacion = '" & educacion & "',  " & "bienestarSocial = '" & bienestarSocial & "', " & "Institucional = '" & institucional & "', " & "Patrimonial = '" & patrimonial & "' "
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try

        Return res
    End Function

    'Actualiza la info de Configuracion
    Function actualizarConfiguracionFechasLimite(ByVal fecha1 As Date, ByVal fecha2 As Date, ByVal fecha3 As Date, ByVal fech4 As Date, ByVal fecha5 As Date,
                                     ByVal fecha6 As Date, ByVal fecha7 As Date, ByVal fecha8 As Date, ByVal fecha9 As Date, ByVal fecha10 As Date) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar
            SQL = "UPDATE [CONFIGURACION] SET fechaLimite1 = '" & fecha1 & "', " & "fechaLimite2 = '" & fecha2 & "', " & "fechaLimite3 = '" & fecha3 & "', " & "fechaLimite4 = '" & fech4 & "',
" & "fechaLimite5 = '" & fecha5 & "',   " & "fechaLimite6 = '" & fecha6 & "',  " & "fechaLimite7 = '" & fecha7 & "', " & "fechaLimite8 = '" & fecha8 & "',  " & "fechaLimite9 = '" & fecha9 & "',
" & "fechaLimite10 = '" & fecha10 & "' "
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try

        Return res
    End Function



    ''/////////////////////////////////////////////////////////////////////
    '''                 CUENTAS

    Function eliminarCuenta(ByVal cod_Descripcion As String) As Integer
        Dim res As Integer = 0
        Try
            SQL = "DELETE FROM [CUENTAS] WHERE ((cod_Descripcion) = '" & cod_Descripcion & "')"
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try
        Return res
    End Function

    Function insertarCuenta(ByVal cod_Descripcion As String, ByVal tipo As String,
                           ByVal proyecto_Productivo As String) As Integer
        Dim res As Integer = 0
        Try
            SQL = "INSERT INTO [CUENTAS]" &
           "(cod_Descripcion,tipo, proyecto_Productivo)" &
            "VALUES ('" + cod_Descripcion + "', '" + tipo + "', '" + proyecto_Productivo + "')"
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: La cuenta ya existe en el sistema!", " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
        Return res
    End Function

    ''/////////////////////////////////////////////////////////////////////
    '''                 INGRESOS

    Function obtenerIngresos(ByVal fechaI As String, ByVal fechaF As String) As List(Of IngresoClase)
        Dim MyList As New List(Of IngresoClase)
        Try
            SQL = "SELECT fecha,cliente,descripcion,cantidad,precioUnitario,total,codigoDeCuenta,reciboFactura FROM [INGRESOS]"

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Try
                        Dim nuevaCuenta As IngresoClase = New IngresoClase
                        nuevaCuenta.ingresoClaseCostructor(reader.GetDateTime(0),
                                                           reader.GetString(1), reader.GetString(2),
                                                           reader.GetString(3), reader.GetString(4),
                                                           reader.GetString(5), reader.GetString(6),
                                                           reader.GetString(7))
                        If nuevaCuenta.fecha >= fechaI And nuevaCuenta.fecha <= fechaF Then
                            MyList.Add(nuevaCuenta)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
                    End Try
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try
        Return MyList
    End Function

    Function insertarIngresos(ByVal fechap As DateTime,
                             ByVal clientep As String,
                             ByVal descripcripcionp As String,
                             ByVal cantidadp As String,
                             ByVal precioUnitariop As String,
                             ByVal totalp As String,
                             ByVal codCuentap As String,
                             ByVal facturaRecibop As String) As Integer
        Dim res As Integer = 0
        Try
            SQL = "INSERT INTO [INGRESOS]" &
           "(fecha,cliente, descripcion,cantidad,precioUnitario,total,codigoDeCuenta,reciboFactura)" &
            "VALUES ('" + fechap + "', '" + clientep + "', '" +
            descripcripcionp + "', " + cantidadp + ", " +
            precioUnitariop + ", " + totalp + ", '" +
            codCuentap + "', '" + facturaRecibop + "')"
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try
        Return res
    End Function


    ''/////////////////////////////////////////////////////////////////////
    '''                 GASTOS

    Function obtenerGastos(ByVal fechaI As String, ByVal fechaF As String) As List(Of GastoClase)
        Dim MyList As New List(Of GastoClase)
        Try
            SQL = "SELECT fecha, proveedor, descripcion, cantidad, precioUnitario, total, codigoDeCuenta, reciboFactura FROM [GASTOS]"

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Try
                        Dim nuevaCuenta As GastoClase = New GastoClase
                        nuevaCuenta.gastoClaseCostructor(reader.GetDateTime(0),
                                                           reader.GetString(1), reader.GetString(2),
                                                           reader.GetString(3), reader.GetString(4),
                                                           reader.GetString(5), reader.GetString(6),
                                                           reader.GetString(7))
                        If nuevaCuenta.fecha >= fechaI And nuevaCuenta.fecha <= fechaF Then
                            MyList.Add(nuevaCuenta)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
                    End Try
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try
        Return MyList
    End Function

    Function insertarGastos(ByVal fechap As DateTime,
                             ByVal clientep As String,
                             ByVal descripcripcionp As String,
                             ByVal cantidadp As String,
                             ByVal precioUnitariop As String,
                             ByVal totalp As String,
                             ByVal codCuentap As String,
                             ByVal facturaRecibop As String) As Integer
        Dim res As Integer = 0
        Try
            SQL = "INSERT INTO [GASTOS]" &
           "(fecha, proveedor, descripcion, cantidad, precioUnitario, total, codigoDeCuenta, reciboFactura)" &
            "VALUES ('" + fechap + "', '" + clientep + "', '" +
            descripcripcionp + "', " + cantidadp + ", " +
            precioUnitariop + ", " + totalp + ", '" +
            codCuentap + "', '" + facturaRecibop + "')"
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try
        Return res
    End Function


    ''//////////////////////////////////////////////////////////////////

    Function consultarCuentas() As List(Of CuentaClase)
        Dim MyList As New List(Of CuentaClase)
        Try
            SQL = "SELECT CUENTAS.* FROM [CUENTAS]"
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Try
                        Dim nuevaCuenta As CuentaClase = New CuentaClase
                        nuevaCuenta.cuentaClaseCostructor(reader.GetString(1),
                                                          reader.GetString(2),
                                                          reader.GetString(3))
                        MyList.Add(nuevaCuenta)
                    Catch ex As Exception
                        MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
                    End Try
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try
        Return MyList
    End Function

    '///////////////// CERTIFICADOS ///////////////////

    'Selecciona cedula, num asociado y datos de los certificados por Asociado
    Function consultarCertificadoXSocio(ByVal cedulaONumAsociado As String) As List(Of String)
        Dim MyList As New List(Of String)
        Try
            SQL = "SELECT SOCIOS.nombre, SOCIOS.primerApellido, SOCIOS.segundoApellido, CERTIFICADOS.*
                    FROM [SOCIOS],[CERTIFICADOS] 
                    WHERE ((SOCIOS.cedula) = '" & cedulaONumAsociado & "' or (SOCIOS.numAsociado)= '" & cedulaONumAsociado & "') 
                    AND (CERTIFICADOS.cedulaAsociado = SOCIOS.cedula)"

            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1
                        'MsgBox(String.Concat(" ", reader(conta)))
                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList

    End Function

    'Actualiza un tracto de certificados
    Function actualizarTracto(ByVal tracto As String, ByVal cedula As String, ByVal monto As String) As Integer
        Dim res As Integer = 0
        Try
            If tracto = "1" Then
                SQL = "UPDATE [CERTIFICADOS] SET tracto1 = '" & monto & "' WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"

            ElseIf tracto = "2" Then
                SQL = "UPDATE [CERTIFICADOS] Set tracto2 = '" & monto & "' WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"

            ElseIf tracto = "3" Then
                SQL = "UPDATE [CERTIFICADOS] SET tracto3 = '" & monto & "' WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"

            ElseIf tracto = "4" Then
                SQL = "UPDATE [CERTIFICADOS] SET tracto4 = '" & monto & "' WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"

            ElseIf tracto = "5" Then
                SQL = "UPDATE [CERTIFICADOS] SET tracto5 = '" & monto & "' WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"

            ElseIf tracto = "6" Then
                SQL = "UPDATE [CERTIFICADOS] SET tracto6 = '" & monto & "' WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"

            ElseIf tracto = "7" Then
                SQL = "UPDATE [CERTIFICADOS] SET tracto7 = '" & monto & "' WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"

            ElseIf tracto = "8" Then
                SQL = "UPDATE [CERTIFICADOS] SET tracto8 = '" & monto & "' WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"

            ElseIf tracto = "9" Then
                SQL = "UPDATE [CERTIFICADOS] SET tracto9 = '" & monto & "' WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"

            ElseIf tracto = "10" Then
                SQL = "UPDATE [CERTIFICADOS] SET tracto10 = '" & monto & "' WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"
            End If

            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.Message)
        End Try

        Return res
    End Function


    'Selecciona cedula, num asociado y datos de los certificados por Asociado
    Function totalEnCertificado(ByVal cedula As String, ByVal monto As String) As Integer
        Dim MyList As Integer = 0
        Try
            SQL = "UPDATE [CERTIFICADOS] SET total = '" & monto & "' WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"

            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                MyList = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try
        Return MyList
    End Function

    'Selecciona cedula, num asociado y datos de los certificados por Asociado
    Function sumarTractosEnCertificados(ByVal cedula As String) As Integer
        Dim MyList As Integer = 0
        Try
            SQL = "SELECT CERTIFICADOS.*  FROM [CERTIFICADOS] 
                    WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"

            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer
                    For conta = 3 To reader.FieldCount - 3
                        MyList += reader(conta)
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try
        Return MyList
    End Function

    'Selecciona cedula, num asociado y datos de los certificados por Asociado
    Function cerrarCertificado(ByVal cedula As String, ByVal montoTotalViejo As String, ByVal monto As String) As Integer
        Dim MyList As Integer = 0
        Try
            SQL = "UPDATE [CERTIFICADOS] SET acumuladoAnterior = '" & montoTotalViejo & "', 
" & "tracto1 = '" & monto & "', " & "tracto2 = '" & monto & "', " & "tracto3 = '" & monto & "',
" & "tracto4 = '" & monto & "', " & "tracto5 = '" & monto & "', " & "tracto6 = '" & monto & "', 
" & "tracto7 = '" & monto & "', " & "tracto8 = '" & monto & "',   " & "tracto9 = '" & monto & "',  " & "tracto10 = '" & monto & "', 
" & "total = '" & monto & "' WHERE ((cedulaAsociado) = '" & cedula & "' or (numAsociado)= '" & cedula & "')"

            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                MyList = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try
        Return MyList
    End Function

    'Obtiene los ingresos o gastos por proyecto productivo
    Function obtenerInformeIngresosTotales(ByVal ingresoOGasto As String, ByVal proyectoProductivo As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date) As List(Of String)
        Dim MyList As New List(Of String)
        Try
            SQL = "SELECT INGRESOS.codigoDeCuenta, Sum(INGRESOS.total) As suma 
                    FROM INGRESOS, CUENTAS 
                    WHERE(((INGRESOS.codigoDeCuenta) = [CUENTAS].[cod_Descripcion]) 
                        And ((CUENTAS.tipo) = '" & ingresoOGasto & "') 
                        And ((CUENTAS.proyecto_Productivo) = '" & proyectoProductivo & "'))
                        And INGRESOS.fecha BETWEEN Format( #" & fechaDesde & "#, 'mm/dd/yyyy') And Format( #" & fechaHasta & "#, 'mm/dd/yyyy')
                    GROUP BY INGRESOS.codigoDeCuenta;"

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        'MsgBox(String.Concat(" ", reader(conta)))

                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    Function obtenerDatosdeSaldosXFechas(ByVal fechaDesde As Date, ByVal fechaHasta As Date) As List(Of SaldoClase)
        Dim MyList As New List(Of SaldoClase)
        Try
            'MsgBox("ENTRANDO A FECHAS...")

            SQL = "SELECT INGRESOS.fecha, INGRESOS.codigoDeCuenta, INGRESOS.total 
                    FROM [INGRESOS] 
                    WHERE INGRESOS.fecha BETWEEN Format( #" & fechaDesde & "#, 'mm/dd/yyyy') And Format( #" & fechaHasta & "#, 'mm/dd/yyyy')
                    UNION SELECT GASTOS.fecha, GASTOS.codigoDeCuenta, GASTOS.total
                    FROM [GASTOS]
                    WHERE GASTOS.fecha BETWEEN Format( #" & fechaDesde & "#, 'mm/dd/yyyy') And Format( #" & fechaHasta & "#, 'mm/dd/yyyy')
                    ORDER BY fecha "

            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim saldo As SaldoClase = New SaldoClase
                    'MsgBox("ENTRANDO AL WHILE...")
                    'MsgBox("reader 0 is : " + reader.GetDateTime(0))
                    'MsgBox("reader 1 is : " + reader.GetString(1))
                    'MsgBox("reader 2 is : " + reader.GetString(2))
                    Try
                        saldo.saldoClaseCostructor(reader.GetDateTime(0), reader.GetString(1), reader.GetString(2))
                        MyList.Add(saldo)

                        ' MsgBox("IMPRIME : " + saldo.codigoCuenta + " xxx " + saldo.total + "xxx" + saldo.fecha)

                    Catch ex As Exception

                    End Try
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la base de datos: " + ex.Message)
        End Try
        Return MyList
    End Function

    'Obtiene los gastos por proyecto productivo
    Function obtenerInformeGastosTotales(ByVal ingresoOGasto As String, ByVal proyectoProductivo As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date) As List(Of String)
        Dim MyList As New List(Of String)
        Try
            SQL = "SELECT GASTOS.codigoDeCuenta, Sum(GASTOS.total) As suma 
                    FROM GASTOS, CUENTAS 
                    WHERE(((GASTOS.codigoDeCuenta) = [CUENTAS].[cod_Descripcion]) 
                        And ((CUENTAS.tipo) = '" & ingresoOGasto & "') 
                        And ((CUENTAS.proyecto_Productivo) = '" & proyectoProductivo & "'))
                        And GASTOS.fecha BETWEEN Format( #" & fechaDesde & "#, 'mm/dd/yyyy') And Format( #" & fechaHasta & "#, 'mm/dd/yyyy')
                    GROUP BY GASTOS.codigoDeCuenta;"

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        'MsgBox(String.Concat(" ", reader(conta)))

                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    'Obtiene el subtotal de ingresos para proy prod o no
    Function obtenerSubTotalIngresos(ByVal ingresoOGasto As String, ByVal esProyectoProductivo As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date) As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = "SELECT Sum(INGRESOS.total) As suma
                    FROM INGRESOS, CUENTAS
                    WHERE INGRESOS.codigoDeCuenta = CUENTAS.cod_Descripcion 
                        AND CUENTAS.tipo = '" & ingresoOGasto & "' 
                        AND CUENTAS.proyecto_Productivo = '" & esProyectoProductivo & "'
                        AND INGRESOS.fecha BETWEEN Format( #" & fechaDesde & "#, 'mm/dd/yyyy') And Format( #" & fechaHasta & "#, 'mm/dd/yyyy') "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        'MsgBox(String.Concat(" ", reader(conta)))

                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    'Obtiene el subtotal de ingresos para proy prod o no
    Function obtenerSubTotalGastos(ByVal ingresoOGasto As String, ByVal esProyectoProductivo As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date) As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = "SELECT Sum(GASTOS.total) As suma 
                    FROM GASTOS, CUENTAS
                    WHERE GASTOS.codigoDeCuenta = CUENTAS.cod_Descripcion 
                        AND CUENTAS.tipo = '" & ingresoOGasto & "' 
                        AND CUENTAS.proyecto_Productivo = '" & esProyectoProductivo & "'
                        AND GASTOS.fecha BETWEEN Format( #" & fechaDesde & "#, 'mm/dd/yyyy') And Format( #" & fechaHasta & "#, 'mm/dd/yyyy') "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        If IsDBNull(reader(conta)) Then
                            ' MessageBox.Show("dato es null")
                            MyList.Add("0")
                        Else
                            ' MessageBox.Show("hay datos")
                            MyList.Add(reader(conta))
                        End If


                        'MsgBox(String.Concat(" ", reader(conta)))

                        'MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    Function obtenerTotalAfiliaciones(ByVal fechaDesde As Date, ByVal fechaHasta As Date) As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = "SELECT Sum(SOCIOS.cuotaMatricula) As suma 
                    FROM SOCIOS
                    WHERE SOCIOS.fechaIngreso BETWEEN Format( #" & fechaDesde & "#, 'mm/dd/yyyy') And Format( #" & fechaHasta & "#, 'mm/dd/yyyy') "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        'MsgBox(String.Concat(" ", reader(conta)))
                        If IsDBNull(reader(conta)) Then
                            ' MessageBox.Show("dato es null")
                            MyList.Add("0")
                        Else
                            ' MessageBox.Show("hay datos")
                            MyList.Add(reader(conta))
                        End If


                        'MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    Function obtenerAportacionesAcumuladoAnterior() As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = " SELECT Sum(CERTIFICADOS.acumuladoAnterior) As acum 
                    FROM CERTIFICADOS "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        'MsgBox(String.Concat(" ", reader(conta)))
                        If IsDBNull(reader(conta)) Then
                            ' MessageBox.Show("dato es null")
                            MyList.Add("0")
                        Else
                            ' MessageBox.Show("hay datos")
                            MyList.Add(reader(conta))
                        End If


                        ' MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    Function obtenerCodigoCuentaIngresos() As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = " SELECT INGRESOS.codigoDeCuenta
                    FROM INGRESOS
                    GROUP BY codigoDeCuenta "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        ' MsgBox(String.Concat("ingresosXXX ", reader(conta)))

                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    Function obtenerCodigoCuentaGastos() As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = " SELECT GASTOS.codigoDeCuenta
                    FROM GASTOS
                    GROUP BY codigoDeCuenta "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        '  MsgBox(String.Concat("Gastos son: ", reader(conta)))

                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function


    Function obtenerAportacionesTotal() As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = " SELECT Sum(CERTIFICADOS.total) As total 
                                FROM CERTIFICADOS "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        'MsgBox(String.Concat(" ", reader(conta)))
                        If IsDBNull(reader(conta)) Then
                            ' MessageBox.Show("dato es null")
                            MyList.Add("0")
                        Else
                            ' MessageBox.Show("hay datos")
                            MyList.Add(reader(conta))
                        End If


                        'MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    'SALDO ANTERIOR DE INGRESOS
    Function obtenerSaldoTotalAnteriorDeIngresos(ByVal fechaInicial As Date) As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = " SELECT Sum(INGRESOS.total) As total 
                    FROM INGRESOS
                    WHERE INGRESOS.fecha <  Format( #" & fechaInicial & "#, 'mm/dd/yyyy')"

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    ' MsgBox("entro al while ingresos")

                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        If IsDBNull(reader(conta)) Then
                            ' MessageBox.Show("dato es null")
                            MyList.Add(String.Empty)
                        Else
                            ' MessageBox.Show("hay datos")
                            MyList.Add(reader(conta))
                        End If


                        'MsgBox(String.Concat(" ", reader(conta)))

                        ' MyList.Add(reader(conta))
                    Next conta
                End While
                'MsgBox("fin al while ingresos")
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    'SALDO ANTERIOR DE GASTOS
    Function obtenerSaldoTotalAnteriorDeGastos(ByVal fechaInicial As Date) As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = " SELECT Sum(GASTOS.total) As total 
                    FROM GASTOS
                    WHERE GASTOS.fecha <  Format( #" & fechaInicial & "#, 'mm/dd/yyyy')"

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    ' MsgBox("entro al while gastos")

                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        If IsDBNull(reader(conta)) Then
                            'MessageBox.Show("dato es null")
                            MyList.Add(String.Empty)
                        Else
                            ' MessageBox.Show("hay datos")
                            MyList.Add(reader(conta))
                        End If

                        'MsgBox(String.Concat(" ", reader(conta)))
                        'MyList.Add(reader(conta))
                    Next conta
                End While
                'MsgBox("salio al while gastos")
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function


    'obtiene el num del tipo de recibo 
    Function obtenerReciboXTipo(ByVal tipoRecibo As String) As List(Of String)
        Dim MyList As New List(Of String)
        Try
            If (tipoRecibo = "ingreso") Then
                SQL = " SELECT RECIBOS.numReciboIngreso FROM RECIBOS"
            End If
            If (tipoRecibo = "asociado") Then
                SQL = " SELECT RECIBOS.numReciboAsociado FROM RECIBOS"
            End If
            If (tipoRecibo = "certificado") Then
                SQL = " SELECT RECIBOS.numReciboCertificado FROM RECIBOS"
            End If

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()

                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1
                        'MsgBox(String.Concat(" ", reader(conta)))
                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()

            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try
        Return MyList
    End Function

    Function actualizarReciboXTipo(ByVal tipoRecibo As String, ByVal numero As Integer) As Integer
        Dim MyList As Integer = 0
        Try
            If (tipoRecibo = "ingreso") Then
                SQL = "UPDATE [RECIBOS] SET numReciboIngreso = '" & numero & "' "
            End If
            If (tipoRecibo = "asociado") Then
                SQL = "UPDATE [RECIBOS] SET numReciboAsociado = '" & numero & "' "
            End If
            If (tipoRecibo = "certificado") Then
                SQL = "UPDATE [RECIBOS] SET numReciboCertificado = '" & numero & "' "
            End If

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                MyList = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try
        Return MyList
    End Function

    Function borrarTablaAsociados() As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = " DELETE * FROM SOCIOS "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        'MsgBox(String.Concat(" ", reader(conta)))

                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    Function borrarTablaCertificados() As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = " DELETE * FROM CERTIFICADOS "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        'MsgBox(String.Concat(" ", reader(conta)))

                        MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    ' reporte exc corresp acum ant x socio
    Function obtenerCertificadoXSocioAcumAnterior(ByVal cedula As String) As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = " SELECT Sum(CERTIFICADOS.acumuladoAnterior) As acum 
                    FROM CERTIFICADOS, SOCIOS
                    WHERE (SOCIOS.cedula = '" & cedula & "' )
                    AND (SOCIOS.estado = 'Activo')
                    AND (CERTIFICADOS.cedulaAsociado = SOCIOS.cedula)  "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        'MsgBox(String.Concat(" ", reader(conta)))
                        If IsDBNull(reader(conta)) Then
                            ' MessageBox.Show("dato es null")
                            MyList.Add("0")
                        Else
                            ' MessageBox.Show("hay datos")
                            MyList.Add(reader(conta))
                        End If


                        ' MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function


    ' exc corresp x socio
    Function obtenerCertificadoXSocioTotal(ByVal cedula As String) As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = " SELECT Sum(CERTIFICADOS.total) As total 
                    FROM CERTIFICADOS, SOCIOS
                    WHERE (SOCIOS.cedula = '" & cedula & "' )
                    AND (SOCIOS.estado = 'Activo')
                    AND (CERTIFICADOS.cedulaAsociado = SOCIOS.cedula)  "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        'MsgBox(String.Concat(" ", reader(conta)))
                        If IsDBNull(reader(conta)) Then
                            ' MessageBox.Show("dato es null")
                            MyList.Add("0")
                        Else
                            ' MessageBox.Show("hay datos")
                            MyList.Add(reader(conta))
                        End If


                        'MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function


    Function obtenerCertificadoTodosAcumAnterior() As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = " SELECT Sum(CERTIFICADOS.acumuladoAnterior) As acum 
                    FROM CERTIFICADOS, SOCIOS
                    WHERE SOCIOS.estado = 'Activo'
                    AND SOCIOS.cedula = CERTIFICADOS.cedulaAsociado "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        'MsgBox(String.Concat(" ", reader(conta)))
                        If IsDBNull(reader(conta)) Then
                            ' MessageBox.Show("dato es null")
                            MyList.Add("0")
                        Else
                            ' MessageBox.Show("hay datos")
                            MyList.Add(reader(conta))
                        End If


                        ' MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function

    Function obtenerCertificadoTodosTotal() As List(Of String)
        Dim MyList As New List(Of String)

        Try
            SQL = " SELECT Sum(CERTIFICADOS.total) As total 
                    FROM CERTIFICADOS, SOCIOS
                    WHERE SOCIOS.estado = 'Activo'
                    AND SOCIOS.cedula = CERTIFICADOS.cedulaAsociado "

            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    Dim conta As Integer = 0
                    For conta = 0 To reader.FieldCount - 1

                        'MsgBox(String.Concat(" ", reader(conta)))
                        If IsDBNull(reader(conta)) Then
                            ' MessageBox.Show("dato es null")
                            MyList.Add("0")
                        Else
                            ' MessageBox.Show("hay datos")
                            MyList.Add(reader(conta))
                        End If


                        'MyList.Add(reader(conta))
                    Next conta
                End While
                reader.Close()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.Message)
        End Try

        Return MyList
    End Function


End Class
