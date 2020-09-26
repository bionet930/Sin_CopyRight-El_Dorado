Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms


Public Class conexion
    Dim comando As New MySqlCommand


    Public conexion As MySqlConnection = New MySqlConnection("server=localhost; user id= 'prueba' ; password='prueba';database = eldorado")

    Public Sub Conectar()

        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try


    End Sub

End Class
