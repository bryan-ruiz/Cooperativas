Imports System.Data.OleDb
Imports System.IO

Public Class VBusquedaIngresoXProveedor

    Dim configuracionReservas As Configuracion = New Configuracion
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source =" & "C:/BD/CoopeBD.mdb;Jet OLEDB:Database Password=C454gr154;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable = New DataTable()


    Dim LVItems As New List(Of ListViewItem)

    'Load
    Private Sub VConfiguracionPorcentajeReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
            TextboxIngresosBuscarXProveedor.Select()

            ListView1.Clear() 'Limpiamos el ListView
            ListView1.View = View.Details 'Tipo de vista
            ListView1.FullRowSelect = True 'Al seleccionar un elemento, seleccionar la línea completa
            ListView1.GridLines = True 'Mostrar las líneas de la cuadrícula
            ListView1.LabelEdit = False 'No permitir la edición automática del texto
            ListView1.MultiSelect = False 'Permitir múltiple selección
            ListView1.HideSelection = False 'Para que al perder el foco, se siga viendo el que está seleccionado
            ListView1.ShowGroups = False 'Listado NO Agrupado

            'Ahora agregamos las columnas nuevas - Indicando el nombre de la columna, el ancho y la aliniacion
            ListView1.Columns.Add("Fecha", 250, HorizontalAlignment.Left)
            ListView1.Columns.Add("N° Factura o Recibo", 250, HorizontalAlignment.Left)
            ListView1.Columns.Add("Proveedor", 250, HorizontalAlignment.Left)
            ListView1.Columns.Add("Código de Cuenta", 250, HorizontalAlignment.Left)
            ListView1.Columns.Add("Descripción", 250, HorizontalAlignment.Left)
            ListView1.Columns.Add("Cantidad", 250, HorizontalAlignment.Left)
            ListView1.Columns.Add("Precio Unitario", 250, HorizontalAlignment.Left)
            ListView1.Columns.Add("Total", 250, HorizontalAlignment.Left)

            'To fill the listview
            Retrieve()

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try

    End Sub

    'RETRIEVE FROM DB
    Public Sub Retrieve()
        ListView1.Items.Clear()
        'SQL STMT
        Dim sql As String = "SELECT INGRESOS.fecha, INGRESOS.reciboFactura, INGRESOS.cliente, INGRESOS.codigoDeCuenta, INGRESOS.descripcion, INGRESOS.cantidad, INGRESOS.precioUnitario, INGRESOS.total
                                FROM [INGRESOS] "
        'WHERE SOCIOS.estado = 'Activo' ORDER BY SOCIOS.nombre"'& "WHERE SOCIOS.cedula = ('" + cedula + "')"
        cmd = New OleDbCommand(sql, con)
        'OPEN CON,RETRIEVE,FILL LISTVIEW
        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(dt)
            'FILL
            For Each row In dt.Rows
                Populate(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7))
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
    Private Sub Populate(fecha As String, factura As String, proveedor As String, codigoCuenta As String, descripcion As String, cantidad As String, precioUnitario As String, total As String)
        'ROW ARRAY
        Dim row As String() = New String() {fecha, factura, proveedor, codigoCuenta, descripcion, cantidad, precioUnitario, total}
        Dim item As New ListViewItem(row)
        ListView1.Items.Add(item)
        LVItems.Add(item)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        'para adjuntar a la vista de Ingresos
        Try
            Dim fecha As String = ListView1.SelectedItems(0).SubItems(0).Text
            Dim factura As String = ListView1.SelectedItems(0).SubItems(1).Text
            Dim proveedor As String = ListView1.SelectedItems(0).SubItems(2).Text
            Dim codigoCuenta As String = ListView1.SelectedItems(0).SubItems(3).Text
            Dim descripcion As String = ListView1.SelectedItems(0).SubItems(4).Text
            Dim cantidad As String = ListView1.SelectedItems(0).SubItems(5).Text
            Dim precioUnitario As String = ListView1.SelectedItems(0).SubItems(6).Text
            Dim total As String = ListView1.SelectedItems(0).SubItems(7).Text

            ' MsgBox("Seleccionó : " & numAsociado & " " & nombre & " " & primerApellido & " " & segundoApellido)
            'Delete(name)
            ''http://camposha.info/source/vb-net-ms-access-listview-insert-select-update-deleteMM

            'Para llenar la información en asociado con el num de asociado
            Me.Close()

            VIngresoInformacion.DateTimePicker_IngresosInformacion_fecha.Value.ToString("dd/MM/yyyy")
            VIngresoInformacion.DateTimePicker_IngresosInformacion_fecha.Value = fecha
            VIngresoInformacion.TextBox_IngresosInformacion_Factura.Text = factura
            VIngresoInformacion.TextBox_IngresosInformacion_Proveedor.Text = proveedor
            VIngresoInformacion.ComboBox_IngresosInformacion.Items.Clear()
            VIngresoInformacion.ComboBox_IngresosInformacion.Items.Add(codigoCuenta)
            VIngresoInformacion.ComboBox_IngresosInformacion.SelectedIndex = 0
            VIngresoInformacion.TextBox_IngresosInformacion_Descripcion.Text = descripcion
            VIngresoInformacion.TextBox_IngresosInformacion_Cantidad.Text = cantidad
            VIngresoInformacion.TextBox_IngresosInformacion_PrecioUnit.Text = precioUnitario
            VIngresoInformacion.TextBox_IngresosInformacion_Total.Text = total

            'VIngresoInformacion.IngresosInformacionInputID.Text = factura
            'Call VIngresoInformacion.IngresosInformacionBotonBuscar_Click(sender, e)
            VIngresoInformacion.IngresosInformacionInputID.Text = ""
            TextboxIngresosBuscarXProveedor.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BusquedaXNombreTextboxConsultarCedula_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextboxIngresosBuscarXProveedor.TextChanged

        ListView1.BeginUpdate()
        If TextboxIngresosBuscarXProveedor.Text.Trim <> "" Then
            Dim MatchedItems As New List(Of ListViewItem)
            For Each itm As ListViewItem In LVItems
                If itm.SubItems(2).Text.ToLower.StartsWith(TextboxIngresosBuscarXProveedor.Text.Trim.ToLower) Then MatchedItems.Add(itm)
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