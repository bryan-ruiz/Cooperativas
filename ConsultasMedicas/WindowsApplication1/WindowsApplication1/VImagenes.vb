Imports System.Data.OleDb
Imports System.IO

Public Class VImagenes

    Dim cerrarPeriodo As Reservas = New Reservas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales


    Private Sub VReservasPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ImagenesButtonBrowse.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        cargarImageXDefecto()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ImagenesButtonBrowse_Click(sender As Object, e As EventArgs) Handles ImagenesButtonBrowse.Click
        Dim img As String

        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "C:\"
        ' openFileDialog1.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png "
        openFileDialog1.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) | *.* "
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True
        openFileDialog1.FileName = ""

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then

                    ImagenesTextboxPath.Text = ""

                    img = openFileDialog1.FileName
                    PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)


                    ImagenesTextboxPath.Text = openFileDialog1.FileName

                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub


    Private Sub ImagenesTextboxPath_TextChanged(sender As Object, e As EventArgs) Handles ImagenesTextboxPath.TextChanged

    End Sub



    Private Sub ImagenesButtonGuardar_Click(sender As Object, e As EventArgs) Handles ImagenesButtonGuardar.Click
        Try
            If Not Directory.Exists(variablesGlobales.folderPathImages) Then
                Directory.CreateDirectory(variablesGlobales.folderPathImages)
            End If
            Dim root As String = "C:\"
            Dim file As String = "data.png" ' path folder
            Dim filename As String = System.IO.Path.Combine(root & file)
            'Carga el picture box con la imagen
            ' PictureBox1.Image = Image.FromFile(filename)

            Dim root2 As String = "C:\BD\"
            Dim file2 As String = "noImage.png" ' path folder
            Dim filename2 As String = System.IO.Path.Combine(root2 & file2)
            'Carga el picture box con la imagen
            PictureBox1.Image = Image.FromFile(filename2)


            'Para copiar una imagen "desde , hasta"
            FileCopy(root & file, variablesGlobales.folderPathImages & file)
            ' MsgBox("Imagen copiada!")
        Catch ex As Exception
            MsgBox("Error de: " & ex.Message)
        End Try

    End Sub

    Private Sub cargarImageXDefecto()
        Try
            If Not Directory.Exists(variablesGlobales.folderPathImages) Then
                Directory.CreateDirectory(variablesGlobales.folderPathImages)
            End If

            Dim root2 As String = "C:\BD\"
            Dim file2 As String = "noImage.jpg" ' path folder
            Dim filename2 As String = System.IO.Path.Combine(root2 & file2)
            'Carga el picture box con la imagen
            PictureBox1.Image = Image.FromFile(filename2)

        Catch ex As Exception
            MsgBox("Error de: " & ex.Message)
        End Try
    End Sub

End Class