Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class proveedoresprincipal

    Dim conexion As New MySqlConnection()
    Dim comando As New MySqlCommand()

    Private Sub proveedoresprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            conexion.ConnectionString = "server=localhost; user id= 'prueba' ; password='prueba';database = eldorado"
            conexion.Open()
            MsgBox("Conectado a la BD")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Try
            comando = New MySqlCommand("INSERT INTO tblproveedores(id_Prov,NombrePrv,TelefonoProv,EmpresaProv,RutEmpresaProv,DirEmpresaProv)" & Chr(13) &
                                       "VALUES(@id_Prov, @NombrePrv, @TelefonoProv, @EmpresaProv, @RutEmpresaProv, @DirEmpresaProv)", conexion)
            comando.Parameters.AddWithValue("@id_Prov", txtidprov.Text)
            comando.Parameters.AddWithValue("@NombrePrv", txtnombreprov.Text)
            comando.Parameters.AddWithValue("@TelefonoProv", txttelprov.Text)
            comando.Parameters.AddWithValue("@EmpresaProv", txtempresaprov.Text)
            comando.Parameters.AddWithValue("@RutEmpresaProv", txtrutprov.Text)
            comando.Parameters.AddWithValue("@DirEmpresaProv", txtdirprov.Text)
            comando.ExecuteNonQuery()
            MsgBox("Datos Guardado")

            txtidprov.Text = ""
            txtnombreprov.Text = ""
            txttelprov.Text = ""
            txtempresaprov.Text = ""
            txtrutprov.Text = ""
            txtdirprov.Text = ""

        Catch ex As Exception
            MsgBox("Error al Guardar los Datos")
        End Try

    End Sub
End Class