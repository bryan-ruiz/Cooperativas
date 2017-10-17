Public Class VGestionAsociados

    Dim usuarios As Usuarios = New Usuarios


    Private Sub F_adminusuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub ButtonUsuariosInsertar_Click(sender As Object, e As EventArgs) Handles ButtonUsuariosInsertar.Click
        'TEMPORAL PARA LA VERSION BETA
        ''MessageBox.Show("No tiene licencia para realizar la acción. Contacte al Administrador del Sistema.")

        If Singleton.rol = "Colaborador" Then
            MessageBox.Show("Se requiere tener permiso de Administrador para realizar acción.")
        Else
            usuarios.insertar()
        End If
    End Sub


    Private Sub ButtonUsuariosEliminar_Click(sender As Object, e As EventArgs) Handles ButtonUsuariosEliminar.Click
        'TEMPORAL PARA LA VERSION BETA
        'MessageBox.Show("No tiene licencia para realizar la acción. Contacte al Administrador del Sistema.")

        If Singleton.rol = "Colaborador" Then
            MessageBox.Show("Se requiere tener permiso de Administrador para realizar acción.")
        Else
            usuarios.eliminar()
        End If
    End Sub

End Class



