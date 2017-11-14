Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Usuarios

    Dim BD As ConexionBD = New ConexionBD
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'Insertar Usuario
    Public Sub insertar()
        Dim rol As String = ""
        Dim usuario As String = VGestionAsociados.TextBoxUsuariosUsuario.Text
        Dim contrasena As String = VGestionAsociados.TextBoxUsuariosContrasena.Text
        Dim permisos As String = variablesGlobales.licenciaPermisos
        'Para el rol
        If (VGestionAsociados.RadioButtonUsuariosAdmin.Checked = True) Then
            rol = "Admin"
        Else
            rol = "Colaborador"
        End If

        If (usuario = "" Or contrasena = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                Dim insertado As Integer = BD.insertarUsuario(rol, usuario, contrasena, permisos)

                If insertado = 1 Then
                    MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    limpiar()
                Else
                    MessageBox.Show(variablesGlobales.errorIngresandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    limpiar()
                End If
                'Muy importante cerrar conexion despues de cada consulta'
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message())
            End Try
        End If
    End Sub

    'Buscar Usuario
    Public Sub buscar()
        Dim usuario As String = VSignIn.TextBoxlogin.Text
        Dim contrasena As String = VSignIn.TextBoxContraseña.Text
        Dim singleton As Singleton = Singleton.Instance()
        If (usuario = "" Or contrasena = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            Try
                BD.ConectarBD()
                Dim insertado As List(Of String) = BD.buscarUsuario(usuario, contrasena)

                If insertado.Count = 0 Then
                    limpiar()
                Else
                    singleton.llenarConInformacion(insertado(0), insertado(2), insertado(1), insertado(3))
                    limpiar()
                End If

                BD.CerrarConexion()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message())
            End Try
        End If
    End Sub

    'login Usuario
    Public Sub login()
        Dim permisoNuevo As String
        Try
            BD.ConectarBD()
            permisoNuevo = Convert.ToInt32(Singleton.permisos) - 1
            BD.loginNuevo(Convert.ToString(permisoNuevo), Singleton.usuario)

            BD.CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(variablesGlobales.errorDe + ex.Message())
        End Try
    End Sub

    'Eliminar Usuario
    Public Sub eliminar()
        Dim usuario As String = VGestionAsociados.TextBoxUsuariosUsuario.Text

        If (usuario = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios)
        Else
            Try
                BD.ConectarBD()
                Dim insertado As Integer = BD.eliminarUsuario(usuario)

                If insertado = 1 Then
                    MessageBox.Show(variablesGlobales.datosEliminadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    limpiar()
                Else
                    MessageBox.Show(variablesGlobales.errorEliminandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    limpiar()
                End If

                BD.CerrarConexion()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message())
            End Try
        End If
    End Sub

    Public Sub limpiar()
        VGestionAsociados.TextBoxUsuariosUsuario.Text = ""
        VGestionAsociados.TextBoxUsuariosContrasena.Text = ""
    End Sub

End Class
