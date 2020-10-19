Imports System.Data
Imports System.Data.DataRow
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class ventasprincipal

    Dim conexion As New MySqlConnection()
    Dim comando As New MySqlCommand()

    Dim consulta As ConexionPablo = New ConexionPablo()

    Dim posicion As Integer



    Private Sub ventasprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub
End Class