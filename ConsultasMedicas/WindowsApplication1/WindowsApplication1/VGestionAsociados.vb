Public Class VGestionAsociados

    Dim usuarios As Usuarios = New Usuarios
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales


    Private Sub F_adminusuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonUsuariosInsertar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonUsuariosEliminar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub


    Private Sub ButtonUsuariosInsertar_Click(sender As Object, e As EventArgs) Handles ButtonUsuariosInsertar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show("Se requiere tener permiso de Administrador para realizar acción.")
        Else
            usuarios.insertar()
        End If
    End Sub


    Private Sub ButtonUsuariosEliminar_Click(sender As Object, e As EventArgs) Handles ButtonUsuariosEliminar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show("Se requiere tener permiso de Administrador para realizar acción.")
        Else
            usuarios.eliminar()
        End If
    End Sub

End Class



