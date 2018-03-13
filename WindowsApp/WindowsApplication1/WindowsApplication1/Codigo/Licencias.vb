
Public Class Licencias

    Dim BD As ConexionBD = New ConexionBD
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales


    'inserta "cantidadCodigos" licencias en la base de datos con estaod 1 (activa) (nota son licencias random)
    Public Sub insertarLicenciasEnBD()

        Dim obj As New Random()
        Dim posibles As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim longitud As Integer = posibles.Length
        Dim letra As Char

        'largo de la cadena
        Dim longitudnuevacadena As Integer = 9
        'codigo final de la cadena
        Dim codigo As String = ""

        'cantidad de veces que se ingresará en la BD
        Dim cantidadCodigos As Integer = 3

        For cantidad As Integer = 0 To cantidadCodigos - 1

            For i As Integer = 0 To longitudnuevacadena - 1
                letra = posibles(obj.[Next](longitud))
                codigo += letra.ToString()
            Next

            'print codigo
            ' MessageBox.Show("Codigo de Licenica es : " + codigo)

            'AQUI METER EL CODIGO EN LA BD
            insertarLicencia(codigo, "1") ' se inserta el código y el estado 1 que representa activa

            'Reseteo largo de cadena
            codigo = ""

        Next

        'validar licencia, cambiar estado de 1 a 0 (inactiva) y setear los usuarios a 300 entradas.  
        '

    End Sub

    'Insertar Licencias nuevas 
    Private Sub insertarLicencia(ByVal codigo As String, ByVal estado As String)
        Try

            BD.ConectarBD()

            Dim insertado As Integer = 0
            insertado = BD.insertarLicencia(codigo, estado)
            'If (insertado = 1) Then
            'MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            'Else
            'MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            'End If

            BD.CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    'Actualiza el estado de la licencia
    Public Sub actualizarEstadoLicencia(ByVal codigo As String, ByVal estado As String)
        Try

            BD.ConectarBD()

            Dim insertado As Integer = 0
            insertado = BD.actualizarEstadoLicencia(codigo, estado)
            If (insertado = 1) Then
                MessageBox.Show(variablesGlobales.licenciasRenovadas, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(variablesGlobales.errorRenovandoLicencia, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            BD.CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

    End Sub


    'Valida que la Licencia exista en la base de datos
    Public Function consultarLicenciaEnBD(ByVal codigo As String)
        Dim valores As List(Of String)
        Dim list As New List(Of String)(New String() {"0"}) ' Cuando no hay valores, es porque es nulo, retornamos la lista para imprimir en el informe económico
        Dim result As List(Of String)

        Try
            BD.ConectarBD()
            valores = BD.consultarLicencia(codigo)
            If valores.Count <> 0 Then
                result = valores
            Else
                'MessageBox.Show(variablesGlobales.noExistenDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                result = list
            End If
            '  MsgBox("cerrando conexion a BD...")

            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message)

        End Try

        Return result

    End Function




End Class




