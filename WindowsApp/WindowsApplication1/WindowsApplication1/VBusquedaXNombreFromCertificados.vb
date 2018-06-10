Imports System.Data.OleDb
Imports System.IO

Public Class VBusquedaXNombreFromCertificados

    Dim configuracionReservas As Configuracion = New Configuracion
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source =" & "C:/BD/CoopeBD.mdb;Jet OLEDB:Database Password=C454gr154;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable = New DataTable()
    Dim LVItems As New List(Of ListViewItem)

    Private Sub VBusquedaXNombreFromCertificados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
            BusquedaXNombreTextboxConsultarCedula.Select()

            ListView1.Clear() 'Limpiamos el ListView
            ListView1.View = View.Details 'Tipo de vista
            ListView1.FullRowSelect = True 'Al seleccionar un elemento, seleccionar la línea completa
            ListView1.GridLines = True 'Mostrar las líneas de la cuadrícula
            ListView1.LabelEdit = False 'No permitir la edición automática del texto
            ListView1.MultiSelect = False 'Permitir múltiple selección
            ListView1.HideSelection = False 'Para que al perder el foco, se siga viendo el que está seleccionado
            ListView1.ShowGroups = False 'Listado NO Agrupado

            'Ahora agregamos las columnas nuevas - Indicando el nombre de la columna, el ancho y la aliniacion
            ListView1.Columns.Add("# Asociado", 250, HorizontalAlignment.Left)
            ListView1.Columns.Add("Nombre", 250, HorizontalAlignment.Left)
            ListView1.Columns.Add("Primer Apellido", 250, HorizontalAlignment.Left)
            ListView1.Columns.Add("Segundo Apellido", 250, HorizontalAlignment.Left)

            'To fill the listview
            RetrieveCertificados()

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try

    End Sub

    'RETRIEVE FROM DB
    Public Sub RetrieveCertificados()
        ListView1.Items.Clear()
        'SQL STMT
        Dim sql As String = "SELECT SOCIOS.numASociado, SOCIOS.nombre, SOCIOS.primerApellido, SOCIOS.segundoApellido 
                                FROM [SOCIOS]
                                WHERE SOCIOS.estado = 'Activo' 
                                ORDER BY SOCIOS.nombre"
        ' WHERE SOCIOS.estado = 'Activo' 

        '& "WHERE SOCIOS.cedula = ('" + cedula + "')"


        cmd = New OleDbCommand(sql, con)

        'OPEN CON,RETRIEVE,FILL LISTVIEW
        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(dt)

            'FILL
            For Each row In dt.Rows
                'Populate(row(1), row(2), row(3))
                Populate(row(0), row(1), row(2), row(3))

            Next

            'CLEAR DT
            dt.Rows.Clear()
            con.Close()

            'to auto size width colum 
            ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)


        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
            con.Close()
        End Try

    End Sub

    'POPULATE
    Private Sub Populate(numAsociado As String, nombre As String, primerApellido As String, segundoApellido As String)
        'ROW ARRAY
        Dim row As String() = New String() {numAsociado, nombre, primerApellido, segundoApellido}
        Dim item As New ListViewItem(row)
        ListView1.Items.Add(item)
        LVItems.Add(item)

    End Sub



    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        'para adjuntar a la vista de Asociados
        Try
            Dim numAsociado As String = ListView1.SelectedItems(0).SubItems(0).Text
            Dim nombre As String = ListView1.SelectedItems(0).SubItems(1).Text
            Dim primerApellido As String = ListView1.SelectedItems(0).SubItems(2).Text
            Dim segundoApellido As String = ListView1.SelectedItems(0).SubItems(3).Text
            ' MsgBox("Seleccionó : " & numAsociado & " " & nombre & " " & primerApellido & " " & segundoApellido)
            'Delete(name)
            ''http://camposha.info/source/vb-net-ms-access-listview-insert-select-update-deleteMM

            'Para llenar la información en asociado con el num de asociado
            Me.Close()
            'VAsociados.TextBoxSociosConsultarAsociado.Text = numAsociado
            VCertificados.CertificadosTextboxCedulaNumAsociado.Text = numAsociado
            'Call VAsociados.ButtonAsociadosBuscar_Click(sender, e)
            Call VCertificados.CertificadosButtonConsultar_Click(sender, e)

            BusquedaXNombreTextboxConsultarCedula.Text = ""
        Catch ex As Exception
        End Try


    End Sub



    Private Sub BusquedaXNombreTextboxConsultarCedula_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BusquedaXNombreTextboxConsultarCedula.TextChanged

        ListView1.BeginUpdate()
        If BusquedaXNombreTextboxConsultarCedula.Text.Trim <> "" Then
            Dim MatchedItems As New List(Of ListViewItem)
            For Each itm As ListViewItem In LVItems
                If itm.SubItems(1).Text.ToLower.StartsWith(BusquedaXNombreTextboxConsultarCedula.Text.Trim.ToLower) Then MatchedItems.Add(itm)
            Next
            If MatchedItems.Count > 0 Then
                ListView1.Items.Clear()
                ListView1.Items.AddRange(MatchedItems.ToArray)
            End If
        Else
            ListView1.Items.Clear()
            ListView1.Items.AddRange(LVItems.ToArray)
        End If

        ListView1.EndUpdate()

    End Sub

End Class