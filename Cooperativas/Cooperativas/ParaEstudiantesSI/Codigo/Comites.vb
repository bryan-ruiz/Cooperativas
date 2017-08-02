Public Class Comites
    Dim BD As ConexionBD = New ConexionBD

    Public Sub buscar(ByVal tipo As String)
        Dim valores As List(Of String)
        Dim cedula As String = ""

        If tipo = "presidente" Then
            cedula = Ventana_Principal.TextBoxID_ComitePresidente.Text
        ElseIf tipo = "vicePresidente" Then
            cedula = Ventana_Principal.TextBoxID_ComiteVicePresidente.Text
        ElseIf tipo = "secretaria" Then
            cedula = Ventana_Principal.TextBoxID_ComiteSecretaria.Text
        ElseIf tipo = "vocal1" Then
            cedula = Ventana_Principal.TextBoxID_ComiteVocal1.Text
        ElseIf tipo = "vocal2" Then
            cedula = Ventana_Principal.TextBoxID_ComiteVocal2.Text
        ElseIf tipo = "suplente1" Then
            cedula = Ventana_Principal.TextBoxID_ComiteSuplente1.Text
        ElseIf tipo = "suplente2" Then
            cedula = Ventana_Principal.TextBoxID_ComiteSuplente1.Text
        End If

        If (cedula = "") Then
            MessageBox.Show("Debe ingresar la cédula o el número de asociado para consultar")
        Else
            Try
                BD.ConectarBD()
                valores = BD.buscarSocio(cedula)
                If valores.Count <> 0 And tipo = "presidente" Then
                    Ventana_Principal.TextBoxComitesPresidente.Text = valores.Item(2) + valores.Item(3) + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_comitePresidente.Text = valores.Item(12)
                ElseIf valores.Count <> 0 And tipo = "vicePresidente" Then
                    Ventana_Principal.TextBoxComitesVicepresidente.Text = valores.Item(2) + valores.Item(3) + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_ComiteVicePresidente.Text = valores.Item(12)
                ElseIf valores.Count <> 0 And tipo = "secretaria" Then
                    Ventana_Principal.TextBoxComitesSecretaria.Text = valores.Item(2) + valores.Item(3) + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_ComiteSecretaria.Text = valores.Item(12)
                ElseIf valores.Count <> 0 And tipo = "vocal1" Then
                    Ventana_Principal.TextBoxComitesVocal1.Text = valores.Item(2) + valores.Item(3) + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_ComiteVocal1.Text = valores.Item(12)
                ElseIf valores.Count <> 0 And tipo = "vocal2" Then
                    Ventana_Principal.TextBoxComitesVocal2.Text = valores.Item(2) + valores.Item(3) + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_ComiteVocal2.Text = valores.Item(12)
                ElseIf valores.Count <> 0 And tipo = "suplente1" Then
                    Ventana_Principal.TextBoxComitesSuplente1.Text = valores.Item(2) + valores.Item(3) + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_ComiteSuplente1.Text = valores.Item(12)
                ElseIf valores.Count <> 0 And tipo = "suplente2" Then
                    Ventana_Principal.TextBoxComitesSuplente2.Text = valores.Item(2) + valores.Item(3) + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_ComiteSuplente2.Text = valores.Item(12)
                Else
                    MessageBox.Show("El Socio no se encuentra registrado")
                End If
                'Muy importante cerrar conexion despues de cada consulta'
                'Cierro conexion'
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show("Error de: " + ex.ToString)
                'MessageBox.Show("ocurrio el siguiente error:" + ex.ToString())
            End Try
        End If
    End Sub

End Class
