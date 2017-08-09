﻿'Importamos las librerias que usaremos para el manejo de la conexión'
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
            'Establezco la conexion con la BD'
            '& My.Application.Info.DirectoryPath &, representa la direccion donde se encuentra el proyecto'
            objConexion = New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=" & "C:/BD/CoopeBD.mdb")
            'objConexion = New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=" & My.Application.Info.DirectoryPath & "/BD.mdb")
            'Abro la conexion'
            objConexion.Open()
            'Valido que se esta conectado'
            conectadoBD = True
        Catch ex As Exception
            conectadoBD = False
            MessageBox.Show("Se presentó la siguiente exepción: " & ex.ToString)
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
            MessageBox.Show("Se presentó la siguiente exepción: " & ex.ToString)
        End Try
    End Sub

    'Inserta un Socio  
    Function insertarUsuario(ByVal rol As String, ByVal usuario As String, ByVal contrasena As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar, en este caso es insertar'
            SQL = "INSERT INTO [USUARIOS]" &
           "(Usuario, Rol, Contrasena)" &
            "VALUES ('" + usuario + "', '" + rol + "', '" + contrasena + "')"
            'Comando para ejecutar el query'
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.ToString)
        End Try
        Return res
    End Function

    'Inserta un Socio  
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
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.ToString)
        End Try
        Return res
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
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.ToString)
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
            SQL = "UPDATE [SOCIOS] SET numAsociado = '" & numAsociado & "', " & "menor = '" & menor & "', " & "nombre = '" & nombre & "', " & "primerApellido = '" & primerApellido & "',  " & "segundoApellido = '" & segundoApellido & "', " & "fechaNacimiento = '" & fechaNacimiento & "', " & "telefono = '" & telefono & "', " & "cuotaMatricula = '" & cuotaMatricula & "', " & "responsable = '" & responsable & "',   " & "beneficiario = '" & beneficiario & "',  " & "fechaIngreso = '" & fechaIngreso & "', " & "seccion = '" & seccion & "',  " & "ocupacionEspecialidad = '" & ocupacionEspecialidad & "', " & "direccion = '" & direccion & "',  " & "genero = '" & genero & "',  " & "estado = '" & estado & "',  " & "fechaRetiro = '" & fechaRetiro & "', " & "notasRetiro = '" & notasRetiro & "' WHERE ((cedula) = '" & cedula & "')"
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.ToString)
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
    Function actualizarComite(ByVal nombreCompleto As String, ByVal ocupacion As String,
                             ByVal menor As String, ByVal fechaRige As Date,
                             ByVal fechaVence As Date, ByVal cedula As String,
                              ByVal tipoConsejo As String, ByVal puesto As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar, en este caso es insertar'
            SQL = "UPDATE [CONSEJOS] SET nombreCompleto = '" & nombreCompleto & "', " & "ocpacion = '" & ocupacion & "', " & "menor = '" & menor & "', " & "fechaRige = '" & fechaRige & "',  " & "fechaVence = '" & fechaVence & "', " & "cedula = '" & cedula & "' WHERE ((tipoConsejo) = '" & tipoConsejo & "' and (tipo) = '" & puesto & "' )"
            'pregunto antes si estoy conectado a la base de datos'
            If conectadoBD = True Then
                Dim command As New OleDbCommand(SQL, objConexion)
                res = command.ExecuteNonQuery()
            Else
                MessageBox.Show("No hay conexión con la base de datos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.ToString)
        End Try

        Return res
    End Function

    'FUNCIONES DE COMITE EN BASE DE DATOS
    Function obtenerDatosdeConfiguration(ByVal periodo As String) As List(Of ConfiguracionClase)
        Dim MyList As New List(Of ConfiguracionClase)
        Try
            SQL = "SELECT CONFIGURACION.* FROM [CONFIGURACION] WHERE ((periodo) = '" & periodo & "')"
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
                                                    reader.GetDateTime(13), reader.GetDateTime(14))
                        MyList.Add(nuevaConfiguracion)
                    Catch ex As Exception
                        MessageBox.Show("Error, Se presentó la siguiente exepción:" & ex.ToString)
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

End Class