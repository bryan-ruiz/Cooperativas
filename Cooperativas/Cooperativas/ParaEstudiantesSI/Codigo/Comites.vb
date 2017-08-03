Public Class Comites
    Dim BD As ConexionBD = New ConexionBD

    Public Sub limpiar()
        Ventana_Principal.TextBoxComitesPresidente.Text = ""
        Ventana_Principal.TextBoxTipo_comitePresidente.Text = ""
        Ventana_Principal.TextBoxComiteMenorPresi.Text = ""
        Ventana_Principal.DateTimePickerFechaRige_ComitePresidente.Text = ""
        Ventana_Principal.DateTimePickerFechaVence_ComitePresidente.Text = ""
        Ventana_Principal.TextBoxID_ComitePresidente.Text = ""
        Ventana_Principal.TextBoxComitesVicepresidente.Text = ""
        Ventana_Principal.TextBoxTipo_ComiteVicePresidente.Text = ""
        Ventana_Principal.TextBoxComiteMenorViceP.Text = ""
        Ventana_Principal.DateTimePickerFechaRige_ComiteVicePresidente.Text = ""
        Ventana_Principal.DateTimePickerFechaVence_ComiteVicePresidente.Text = ""
        Ventana_Principal.TextBoxID_ComiteVicePresidente.Text = ""
        Ventana_Principal.TextBoxComitesSecretaria.Text = ""
        Ventana_Principal.TextBoxTipo_ComiteSecretaria.Text = ""
        Ventana_Principal.TextBoxComiteMenorSec.Text = ""
        Ventana_Principal.DateTimePickerFechaRige_ComiteSecretaria.Text = ""
        Ventana_Principal.DateTimePickerFechaVence_ComiteSecretaria.Text = ""
        Ventana_Principal.TextBoxID_ComiteSecretaria.Text = ""
        Ventana_Principal.TextBoxComitesVocal1.Text = ""
        Ventana_Principal.TextBoxTipo_ComiteVocal1.Text = ""
        Ventana_Principal.TextBoxComiteMenorVoc1.Text = ""
        Ventana_Principal.DateTimePickerFechaRige_ComiteVocal1.Text = ""
        Ventana_Principal.DateTimePickerFechaVence_ComiteVocal1.Text = ""
        Ventana_Principal.TextBoxID_ComiteVocal1.Text = ""
        Ventana_Principal.TextBoxComitesVocal2.Text = ""
        Ventana_Principal.TextBoxTipo_ComiteVocal2.Text = ""
        Ventana_Principal.TextBoxComiteMenorVoc2.Text = ""
        Ventana_Principal.DateTimePickerFechaRige_ComiteVocal2.Text = ""
        Ventana_Principal.DateTimePickerFechaVence_ComiteVocal2.Text = ""
        Ventana_Principal.TextBoxID_ComiteVocal2.Text = ""
        Ventana_Principal.TextBoxComitesSuplente1.Text = ""
        Ventana_Principal.TextBoxTipo_ComiteSuplente1.Text = ""
        Ventana_Principal.TextBoxComiteMenorSupl1.Text = ""
        Ventana_Principal.DateTimePickerFechaRige_ComiteSuplente1.Text = ""
        Ventana_Principal.DateTimePickerFechaVence_ComiteSuplente1.Text = ""
        Ventana_Principal.TextBoxID_ComiteSuplente1.Text = ""
        Ventana_Principal.TextBoxComitesSuplente2.Text = ""
        Ventana_Principal.TextBoxTipo_ComiteSuplente2.Text = ""
        Ventana_Principal.TextBoxComiteMenorSupl2.Text = ""
        Ventana_Principal.DateTimePickerFechaRige_ComiteSuplente2.Text = ""
        Ventana_Principal.DateTimePickerFechaVence_ComiteSuplente2.Text = ""
        Ventana_Principal.TextBoxID_ComiteSuplente2.Text = ""
    End Sub

    Public Sub llenarDatos(ByVal valores As List(Of ComiteClase))
        Dim conta As Integer = 0
        While conta < valores.Count
            If valores(conta).tipo = "presidente" Then
                Ventana_Principal.TextBoxComitesPresidente.Text = valores(conta).nombreCompleto
                Ventana_Principal.TextBoxTipo_comitePresidente.Text = valores(conta).ocupacion
                Ventana_Principal.TextBoxComiteMenorPresi.Text = valores(conta).menor
                Ventana_Principal.DateTimePickerFechaRige_ComitePresidente.Text = valores(conta).fechaRige
                Ventana_Principal.DateTimePickerFechaVence_ComitePresidente.Text = valores(conta).fechaVence
                Ventana_Principal.TextBoxID_ComitePresidente.Text = valores(conta).cedual

            ElseIf valores(conta).tipo = "vicePresidente" Then
                Ventana_Principal.TextBoxComitesVicepresidente.Text = valores(conta).nombreCompleto
                Ventana_Principal.TextBoxTipo_ComiteVicePresidente.Text = valores(conta).ocupacion
                Ventana_Principal.TextBoxComiteMenorViceP.Text = valores(conta).menor
                Ventana_Principal.DateTimePickerFechaRige_ComiteVicePresidente.Text = valores(conta).fechaRige
                Ventana_Principal.DateTimePickerFechaVence_ComiteVicePresidente.Text = valores(conta).fechaVence
                Ventana_Principal.TextBoxID_ComiteVicePresidente.Text = valores(conta).cedual

            ElseIf valores(conta).tipo = "secretaria" Then
                Ventana_Principal.TextBoxComitesSecretaria.Text = valores(conta).nombreCompleto
                Ventana_Principal.TextBoxTipo_ComiteSecretaria.Text = valores(conta).ocupacion
                Ventana_Principal.TextBoxComiteMenorSec.Text = valores(conta).menor
                Ventana_Principal.DateTimePickerFechaRige_ComiteSecretaria.Text = valores(conta).fechaRige
                Ventana_Principal.DateTimePickerFechaVence_ComiteSecretaria.Text = valores(conta).fechaVence
                Ventana_Principal.TextBoxID_ComiteSecretaria.Text = valores(conta).cedual

            ElseIf valores(conta).tipo = "vocal1" Then
                Ventana_Principal.TextBoxComitesVocal1.Text = valores(conta).nombreCompleto
                Ventana_Principal.TextBoxTipo_ComiteVocal1.Text = valores(conta).ocupacion
                Ventana_Principal.TextBoxComiteMenorVoc1.Text = valores(conta).menor
                Ventana_Principal.DateTimePickerFechaRige_ComiteVocal1.Text = valores(conta).fechaRige
                Ventana_Principal.DateTimePickerFechaVence_ComiteVocal1.Text = valores(conta).fechaVence
                Ventana_Principal.TextBoxID_ComiteVocal1.Text = valores(conta).cedual

            ElseIf valores(conta).tipo = "vocal2" Then
                Ventana_Principal.TextBoxComitesVocal2.Text = valores(conta).nombreCompleto
                Ventana_Principal.TextBoxTipo_ComiteVocal2.Text = valores(conta).ocupacion
                Ventana_Principal.TextBoxComiteMenorVoc2.Text = valores(conta).menor
                Ventana_Principal.DateTimePickerFechaRige_ComiteVocal2.Text = valores(conta).fechaRige
                Ventana_Principal.DateTimePickerFechaVence_ComiteVocal2.Text = valores(conta).fechaVence
                Ventana_Principal.TextBoxID_ComiteVocal2.Text = valores(conta).cedual

            ElseIf valores(conta).tipo = "suplente1" Then
                Ventana_Principal.TextBoxComitesSuplente1.Text = valores(conta).nombreCompleto
                Ventana_Principal.TextBoxTipo_ComiteSuplente1.Text = valores(conta).ocupacion
                Ventana_Principal.TextBoxComiteMenorSupl1.Text = valores(conta).menor
                Ventana_Principal.DateTimePickerFechaRige_ComiteSuplente1.Text = valores(conta).fechaRige
                Ventana_Principal.DateTimePickerFechaVence_ComiteSuplente1.Text = valores(conta).fechaVence
                Ventana_Principal.TextBoxID_ComiteSuplente1.Text = valores(conta).cedual

            ElseIf valores(conta).tipo = "suplente2" Then
                Ventana_Principal.TextBoxComitesSuplente2.Text = valores(conta).nombreCompleto
                Ventana_Principal.TextBoxTipo_ComiteSuplente2.Text = valores(conta).ocupacion
                Ventana_Principal.TextBoxComiteMenorSupl2.Text = valores(conta).menor
                Ventana_Principal.DateTimePickerFechaRige_ComiteSuplente2.Text = valores(conta).fechaRige
                Ventana_Principal.DateTimePickerFechaVence_ComiteSuplente2.Text = valores(conta).fechaVence
                Ventana_Principal.TextBoxID_ComiteSuplente2.Text = valores(conta).cedual
            End If
            conta = conta + 1
        End While
    End Sub

    Public Sub consultar()
        Dim valores As List(Of ComiteClase)
        Dim id As String = Ventana_Principal.ComboBoxComitesNombre.Text

        Try
            BD.ConectarBD()
            valores = BD.obtenerDatosdeUnComite(id)

            ''Dim valores As List(Of String) = BD.consultarSocioPorCedula(cedula)            
            If valores.Count <> 0 Then
                llenarDatos(valores)
            End If
            'Muy importante cerrar conexion despues de cada consulta'
            'Cierro conexion'
            BD.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error de: " + ex.ToString)
            'MessageBox.Show("ocurrio el siguiente error:" + ex.ToString())
        End Try

    End Sub

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
                    Ventana_Principal.TextBoxComitesPresidente.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_comitePresidente.Text = valores.Item(12)
                    Ventana_Principal.TextBoxComiteMenorPresi.Text = valores.Item(18)
                ElseIf valores.Count <> 0 And tipo = "vicePresidente" Then
                    Ventana_Principal.TextBoxComitesVicepresidente.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_ComiteVicePresidente.Text = valores.Item(12)
                    Ventana_Principal.TextBoxComiteMenorViceP.Text = valores.Item(18)
                ElseIf valores.Count <> 0 And tipo = "secretaria" Then
                    Ventana_Principal.TextBoxComitesSecretaria.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_ComiteSecretaria.Text = valores.Item(12)
                    Ventana_Principal.TextBoxComiteMenorSec.Text = valores.Item(18)
                ElseIf valores.Count <> 0 And tipo = "vocal1" Then
                    Ventana_Principal.TextBoxComitesVocal1.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_ComiteVocal1.Text = valores.Item(12)
                    Ventana_Principal.TextBoxComiteMenorVoc1.Text = valores.Item(18)
                ElseIf valores.Count <> 0 And tipo = "vocal2" Then
                    Ventana_Principal.TextBoxComitesVocal2.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_ComiteVocal2.Text = valores.Item(12)
                    Ventana_Principal.TextBoxComiteMenorVoc2.Text = valores.Item(18)
                ElseIf valores.Count <> 0 And tipo = "suplente1" Then
                    Ventana_Principal.TextBoxComitesSuplente1.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_ComiteSuplente1.Text = valores.Item(12)
                    Ventana_Principal.TextBoxComiteMenorSupl1.Text = valores.Item(18)
                ElseIf valores.Count <> 0 And tipo = "suplente2" Then
                    Ventana_Principal.TextBoxComitesSuplente2.Text = valores.Item(2) + " " + valores.Item(3) + " " + valores.Item(4)
                    Ventana_Principal.TextBoxTipo_ComiteSuplente2.Text = valores.Item(12)
                    Ventana_Principal.TextBoxComiteMenorSupl2.Text = valores.Item(18)
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
