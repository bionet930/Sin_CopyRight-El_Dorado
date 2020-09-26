Imports MySql.Data.MySqlClient

Module conexion

    Public conexion As New MySqlConnection("server=localhost; user id= 'prueba' ; password='prueba';database = eldorado")
    Public comando As New MySqlCommand
    Public adt As New MySqlDataAdapter
    Public ds As New DataSet
    Public lista As Byte

    Public sql As String


    Public Function cargardatos(ByVal tabla As String) As DataSet 'Funcion para cargar datos de una tabla, hay que pasarle el parametro de que tabla ver
        Try
            conexion.Open()
            sql = "SELECT * FROM " & tabla
            adt = New MySqlDataAdapter
            ds = New DataSet
            adt.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            conexion.Close()
            Return ds

        End Try
    End Function

End Module
