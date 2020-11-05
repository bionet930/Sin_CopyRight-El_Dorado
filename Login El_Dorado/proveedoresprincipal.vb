Imports System.Data
Imports System.Data.DataRow
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms


Public Class proveedoresprincipal

    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public adt As MySqlDataAdapter
    Public ds As DataSet

    Dim conexion As New MySqlConnection()
    Dim comando As New MySqlCommand()
    Dim posicion As Integer

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
        conexion.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Try
            comando = New MySqlCommand("INSERT INTO tblproveedores(id_Prov,NombrePrv,TelefonoProv,EmpresaProv,RutEmpresaProv,DirEmpresaProv,EstadoProv)" & Chr(13) &
                                       "VALUES(@id_Prov, @NombrePrv, @TelefonoProv, @EmpresaProv, @RutEmpresaProv, @DirEmpresaProv,@EstadoProv)", conexion)
            comando.Parameters.AddWithValue("@id_Prov", txtidprov.Text)
            comando.Parameters.AddWithValue("@NombrePrv", txtnombreprov.Text)
            comando.Parameters.AddWithValue("@TelefonoProv", txttelprov.Text)
            comando.Parameters.AddWithValue("@EmpresaProv", txtempresaprov.Text)
            comando.Parameters.AddWithValue("@RutEmpresaProv", txtrutprov.Text)
            comando.Parameters.AddWithValue("@DirEmpresaProv", txtdirprov.Text)
            comando.Parameters.AddWithValue("@EstadoProv", RBProvactivo.Checked)
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

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Try
            sql = "SELECT * FROM tblproveedores"
            adt = New MySqlDataAdapter(sql, conexion)
            ds = New DataSet
            adt.Fill(ds)
            lista = ds.Tables(0).Rows.Count

        Catch ex As Exception

        End Try

        posicion = posicion + 1

        If posicion < ds.Tables(0).Rows.Count Then
            cargar()
        Else
            posicion = 0
            cargar()
        End If


    End Sub


    Public Sub cargar()
        If lista <> 0 Then
            txtidprov.Text = ds.Tables(0).Rows(posicion).Item("id_Prov")
            txtnombreprov.Text = ds.Tables(0).Rows(posicion).Item("NombrePrv")
            txttelprov.Text = ds.Tables(0).Rows(posicion).Item("TelefonoProv")
            txtempresaprov.Text = ds.Tables(0).Rows(posicion).Item("EmpresaProv")
            txtrutprov.Text = ds.Tables(0).Rows(posicion).Item("RutEmpresaProv")
            txtdirprov.Text = ds.Tables(0).Rows(posicion).Item("DirEmpresaProv")
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        posicion -= 1

        If posicion > -1 Then
            cargar()
        Else
            posicion = ds.Tables(0).Rows.Count - 1
            cargar()
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        txtidprov.Text = ""
        txtnombreprov.Text = ""
        txttelprov.Text = ""
        txtempresaprov.Text = ""
        txtrutprov.Text = ""
        txtdirprov.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Try
            sql = "DELETE FROM tblproveedores WHERE id_Prov = '" & txtidprov.Text.Trim & "'"
            cmd = New MySqlCommand(sql, conexion)
            cmd.ExecuteNonQuery()
            MsgBox("Datos Borrados")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtidprov.Text = ""
        txtnombreprov.Text = ""
        txttelprov.Text = ""
        txtempresaprov.Text = ""
        txtrutprov.Text = ""
        txtdirprov.Text = ""

    End Sub

   
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

  
End Class