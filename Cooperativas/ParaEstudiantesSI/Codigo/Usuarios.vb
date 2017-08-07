Imports itextsharp.text
Imports itextsharp.text.pdf
Imports System.IO

Public Class Usuarios
    Dim BD As ConexionBD = New ConexionBD
    'Insertar Usuario
    Public Sub insertar()
        Dim rol As String = ""
        Dim usuario As String = Ventana_Principal.TextBoxUsuariosUsuario.Text
        Dim contrasena As String = Ventana_Principal.TextBoxUsuariosContrasena.Text

        'Para el rol
        If (Ventana_Principal.RadioButtonUsuariosAdmin.Checked = True) Then
            rol = "Admin"
        Else
            rol = "Colaborador"
        End If

        If (usuario = "" Or contrasena = "") Then
            MessageBox.Show("No pueden haber campos vacíos!")
        Else
            Try
                BD.ConectarBD()
                Dim insertado As Integer = BD.insertarUsuario(rol, usuario, contrasena)

                If insertado = 1 Then
                    MessageBox.Show("Usuario ingresado con éxito!")
                    limpiar()
                Else
                    MessageBox.Show("Error al ingresar el Usuario")
                    limpiar()
                End If
                'Muy importante cerrar conexion despues de cada consulta'
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show("ocurrio el siguiente error:" + ex.ToString())
            End Try
        End If
    End Sub

    'Eliminar Usuario
    Public Sub eliminar()
        Dim usuario As String = Ventana_Principal.TextBoxUsuariosUsuario.Text

        If (usuario = "") Then
            MessageBox.Show("No pueden haber campos vacíos!")
        Else
            Try
                BD.ConectarBD()
                Dim insertado As Integer = BD.eliminarUsuario(usuario)

                If insertado = 1 Then
                    MessageBox.Show("Usuario eliminado con éxito!")
                    limpiar()
                Else
                    MessageBox.Show("Error al eliminar el Usuario")
                    limpiar()
                End If
                'Muy importante cerrar conexion despues de cada consulta'
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show("ocurrio el siguiente error:" + ex.ToString())
            End Try
        End If
    End Sub

    Public Sub limpiar()
        Ventana_Principal.TextBoxUsuariosUsuario.Text = ""
        Ventana_Principal.TextBoxUsuariosContrasena.Text = ""
    End Sub

End Class
