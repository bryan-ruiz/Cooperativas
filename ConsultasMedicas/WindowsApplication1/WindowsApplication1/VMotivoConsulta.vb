Imports System.Data.OleDb
Imports System.IO

Public Class VMotivoConsulta

    Dim cerrarPeriodo As Reservas = New Reservas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source =" & "C:/BD/BDConsultasMed.mdb;Jet OLEDB:Database Password=C454gr154;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable = New DataTable()


    Private Sub VMotivoConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.MotivoConsultaButtonAgregar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.MotivoConsultaButtonBuscar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.MotivoConsultaButtonBuscarXNombre.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.MotivoConsultaButtonLimpiar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

        'SET LISTVIEW PROPERTIES
        ListView1.View = View.Details
        'CONSTRUCT COLUMNS
        ListView1.Columns.Add("Fecha", 100)
        ListView1.Columns.Add("Valor", 100)
        ListView1.Columns.Add("Motivo", 2000)

        'to auto size width colum 
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    '############### codigo listview ########################

    'Boton Agregar
    Private Sub MotivoConsultaButtonAgregar_Click(sender As Object, e As EventArgs) Handles MotivoConsultaButtonAgregar.Click
        Dim cedula As String = MotivoConsultaTextboxCed.Text
        Dim fecha As Date = MotivoConsultaDateTimeFecha.Value.ToString("dd/MM/yyyy")
        Dim valor As String = MotivoConsultaTextboxValorConsulta.Text
        Dim motivo As String = MotivoConsultaTextboxMotivoConsulta.Text

        Add(cedula, fecha, valor, motivo)

    End Sub

    Private Sub Add(cedula As String, fecha As Date, valor As String, motivo As String)
        If (cedula = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaNula, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If
        If (valor = "" Or motivo = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If


        'SQL STMT
        Dim sql As String = "INSERT INTO MOTIVO_CONSULTA(cedula, fecha, valor, motivo) VALUES(@myCedula, @myFecha, @myValor, @myMotivo)"
        cmd = New OleDbCommand(sql, con)

        'PARAMETERS
        cmd.Parameters.AddWithValue("@myCedula", cedula)
        cmd.Parameters.AddWithValue("@myFecha", fecha)
        cmd.Parameters.AddWithValue("@myValor", valor)
        cmd.Parameters.AddWithValue("@myMotivo", motivo)

        'OPEN CON,EXECUTE,CLOSE CON
        Try
            con.Open()

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show(variablesGlobales.datosIngresadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                MotivoConsultaTextboxValorConsulta.Text = ""
                MotivoConsultaTextboxMotivoConsulta.Text = ""
            End If

            con.Close()

            Retrieve(MotivoConsultaTextboxCed.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    'POPULATE OUR LISTVIEW
    Private Sub Populate(name As String, position As String, team As String)
        'ROW ARRAY
        Dim row As String() = New String() {name, position, team}
        Dim item As New ListViewItem(row)
        ListView1.Items.Add(item)
    End Sub

    'RETRIEVE FROM DB
    Private Sub Retrieve(ByVal cedula As String)
        ListView1.Items.Clear()
        'SQL STMT
        Dim sql As String = "SELECT MOTIVO_CONSULTA.fecha, MOTIVO_CONSULTA.valor, MOTIVO_CONSULTA.motivo 
                                FROM [MOTIVO_CONSULTA]" &
                                "WHERE cedula = ('" + cedula + "')"

        cmd = New OleDbCommand(sql, con)

        'OPEN CON,RETRIEVE,FILL LISTVIEW
        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(dt)

            'FILL
            For Each row In dt.Rows
                'Populate(row(1), row(2), row(3))
                Populate(row(0), row(1), row(2))
            Next

            'CLEAR DT
            dt.Rows.Clear()
            con.Close()

            'to auto size width colum 
            ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)


        Catch ex As Exception
            MsgBox("Error : " & ex.ToString)
            con.Close()
        End Try

    End Sub


    Private Sub MotivoConsultaButtonBuscar_Click(sender As Object, e As EventArgs) Handles MotivoConsultaButtonBuscar.Click
        'Buscar x cedula de paciente
        'etc

        'carga la info desde la BD para un paciente
        Dim cedula As String = MotivoConsultaTextboxCed.Text
        If (cedula = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaNula, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If

        Retrieve(MotivoConsultaTextboxCed.Text)
    End Sub

    Private Sub MotivoConsultaButtonLimpiar_Click(sender As Object, e As EventArgs) Handles MotivoConsultaButtonLimpiar.Click
        ListView1.Items.Clear()
        limpiar()
    End Sub

    Public Sub limpiar()
        'limpia el listview
        ListView1.Items.Clear()
        'limpia textfields
        MotivoConsultaTextboxCed.Text = ""
        MotivoConsultaTextboxNombreYApellidos.Text = ""
        MotivoConsultaTextboxConsultarCedula.Text = ""
        'etc
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Retrieve(MotivoConsultaTextboxCed.Text)
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        Try
            Dim motivo As String = ListView1.SelectedItems(0).SubItems(2).Text
            MsgBox("Seleccionó : " & motivo)
            'Delete(name)
            'http://camposha.info/source/vb-net-ms-access-listview-insert-select-update-delete
        Catch ex As Exception

        End Try

    End Sub
End Class