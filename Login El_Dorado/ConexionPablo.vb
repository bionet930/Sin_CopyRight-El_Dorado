Imports MySql.Data.MySqlClient
Public Class ConexionPablo

    Private conexion As New MySqlConnection("data source=localhost;user id='prueba';password='prueba';database=eldorado;port=3306;CHARSET=utf8;")
    Private adaptador As MySqlDataAdapter
    Private comando As MySqlCommand
    Private Query As Queryable
    Private dr As MySqlDataReader
    Protected ds As DataSet

    Public resultado As Byte = 0
    Public valorReturn As String = ""

    Private consultaSQL As String
    Private tabla As DataTable

    Public Sub establecerConexion()
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos. " & ex.Message)
        Finally
            conexion.Dispose()
        End Try
    End Sub



    Public Sub consultaSinRetorno(ByVal Sql As String)

        Try
            conexion.Open()
            comando = New MySqlCommand(Sql, conexion)
            comando.ExecuteNonQuery()
            resultado = 1
            conexion.Close()
        Catch ex As Exception
            resultado = 0
            MsgBox("Error al conectar con la base de datos " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


    Public Function consultaConRetorno(ByVal Sql As String) As String
        Try
            conexion.Open()
            comando = New MySqlCommand(Sql, conexion)
            valorReturn = ""
            valorReturn = comando.ExecuteScalar()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos " & ex.Message)
        Finally
            conexion.Close()
        End Try
        Return valorReturn
    End Function


    Private Function consultaReturnHideVariosValores(ByVal Sql As String) As String
        Try
            conexion.Open()
            comando = New MySqlCommand(Sql, conexion)
            dr = comando.ExecuteScalar
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos " & ex.Message)
        Finally
            conexion.Close()
        End Try
        Return valorReturn
    End Function

    Private Function insertarEnTabla(ByVal consulta As String) As DataTable
        Try
            adaptador = New MySqlDataAdapter(consulta, Me.conexion)
            Me.tabla = New DataTable
            adaptador.Fill(tabla)
            resultado = 1
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos " & ex.Message)
        Finally
            conexion.Close()
        End Try
        Return Me.tabla
    End Function


    Public Function mostrarEnTabla(ByVal consulta As String) As DataTable

        Return insertarEnTabla(consulta)
    End Function


End Class
