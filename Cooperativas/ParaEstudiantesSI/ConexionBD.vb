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
                MessageBox.Show("entrs activos 23")
                SQL = "SELECT SOCIOS.* FROM [SOCIOS] WHERE ((estado) = 'Activo')"
            Else
                MessageBox.Show("entrs activos 24")
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
                           ByVal genero As String, ByVal estado As String, ByVal fechaRetiro As Date, notasRetiro As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar, en este caso es insertar'
            SQL = "INSERT INTO [SOCIOS]" &
           "(cedula, numAsociado, nombre, primerApellido, segundoApellido, fechaNacimiento, telefono, cuotaMatricula, responsable, beneficiario, fechaIngreso, seccion, ocupacionEspecialidad, direccion, genero, estado, fechaRetiro, notasRetiro)" &
            "VALUES ('" + cedula + "', '" + numAsociado + "', '" + nombre + "', '" + apellidoUno + "', '" + apellidoDos + "', '" + fechaNacimiento + "', '" + telefono + "', '" + cuota + "' , '" + responsable + "', '" + beneficiario + "', '" + fechaIngreso + "',
            '" + seccion + "', '" + especialidad + "', '" + direccion + "', '" + genero + "', '" + estado + "', '" + fechaRetiro + "', '" + notasRetiro + "')"
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
    Function actualizarSocio(ByVal cedula As String, ByVal numAsociado As String, ByVal nombre As String, ByVal primerApellido As String, ByVal segundoApellido As String, ByVal fechaNacimiento As Date, ByVal telefono As String, ByVal cuotaMatricula As String, ByVal responsable As String, ByVal beneficiario As String, ByVal fechaIngreso As Date, ByVal seccion As String, ByVal ocupacionEspecialidad As String, ByVal direccion As String, ByVal genero As String, ByVal estado As String, ByVal fechaRetiro As Date, notasRetiro As String) As Integer
        Dim res As Integer = 0
        Try
            'Declaramos el query que queremos ejecutar, en este caso es insertar'
            SQL = "UPDATE [SOCIOS] SET numAsociado = '" & numAsociado & "', " & "nombre = '" & nombre & "', " & "primerApellido = '" & primerApellido & "',  " & "segundoApellido = '" & segundoApellido & "', " & "fechaNacimiento = '" & fechaNacimiento & "', " & "telefono = '" & telefono & "', " & "cuotaMatricula = '" & cuotaMatricula & "', " & "responsable = '" & responsable & "',   " & "beneficiario = '" & beneficiario & "',  " & "fechaIngreso = '" & fechaIngreso & "', " & "seccion = '" & seccion & "',  " & "ocupacionEspecialidad = '" & ocupacionEspecialidad & "', " & "direccion = '" & direccion & "',  " & "genero = '" & genero & "',  " & "estado = '" & estado & "',  " & "fechaRetiro = '" & fechaRetiro & "', " & "notasRetiro = '" & notasRetiro & "' WHERE ((cedula) = '" & cedula & "')"
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


End Class