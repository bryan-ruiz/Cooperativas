Imports System.Data.OleDb
Imports System.IO

Public Class VBusquedaXNombre

    Dim cerrarPeriodo As Reservas = New Reservas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source =" & "C:/BD/BDConsultasMed.mdb;Jet OLEDB:Database Password=C454gr154;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable = New DataTable()
    Dim motivoConsulta As MotivoConsulta = New MotivoConsulta



    'RETRIEVE FROM DB
    Public Sub Retrieve(ByVal cedula As String)
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

    '############### codigo listview ########################


    Public Sub Add(cedula As String, fecha As Date, valor As String, motivo As String)
        If (cedula = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaNula, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            motivoConsulta.limpiar()
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

                ' MotivoConsultaTextboxValorConsulta.Text = ""
                '  MotivoConsultaTextboxMotivoConsulta.Text = ""
            End If

            con.Close()

            'Retrieve(MotivoConsultaTextboxCed.Text)
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


    '#######################################################################################



    Private Sub VMotivoConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

        Me.MotivoConsultaButtonBuscar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        ' Me.MotivoConsultaButtonBuscarXNombre.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

        Me.MotivoConsultaTextboxConsultarCedula.Select()
        'SET LISTVIEW PROPERTIES
        ListView1.View = View.Details
        'CONSTRUCT COLUMNS
        ListView1.Columns.Add("Fecha", 100)
        ListView1.Columns.Add("Valor", 100)
        ListView1.Columns.Add("Motivo", 2000)

        Populate("aaron", "ruiz", "b")
        Populate("luis", "etc", "ab")
        'to auto size width colum 
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.DoubleClick

    End Sub



    Private Sub MotivoConsultaButtonBuscar_Click(sender As Object, e As EventArgs) Handles MotivoConsultaButtonBuscar.Click
        motivoConsulta.consultarMotivoConsultaXCedula()
    End Sub

    Private Sub MotivoConsultaButtonLimpiar_Click(sender As Object, e As EventArgs)
        motivoConsulta.limpiar()
    End Sub

    'para borrar
    'Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs)
    'Try
    'Dim motivo As String = ListView1.SelectedItems(0).SubItems(2).Text
    'MsgBox("Seleccionó : " & motivo)
    'Delete(name)
    ''http://camposha.info/source/vb-net-ms-access-listview-insert-select-update-delete
    'Catch ex As Exception
    'End Try
    'End Sub

    Private Sub MotivoConsultaTextboxConsultarCedula_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles MotivoConsultaTextboxConsultarCedula.KeyPress
        'TextBoxSociosConsultarAsociado.PasswordChar = "*"
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call MotivoConsultaButtonBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub PacientesButtonAbrirExpediente_Click(sender As Object, e As EventArgs)
        VImagenes.Show()
    End Sub

    'Boton Agregar
    Private Sub MotivoConsultaButtonAgregar_Click(sender As Object, e As EventArgs)

        ' Add(cedula, fecha, valor, motivo)

    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Try
            Dim motivo As String = ListView1.SelectedItems(0).SubItems(1).Text
            MsgBox("Seleccionó : " & motivo)
            'Delete(name)
            ''http://camposha.info/source/vb-net-ms-access-listview-insert-select-update-delete
        Catch ex As Exception
        End Try

    End Sub
End Class