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



    Dim consulta As ConexionPablo = New ConexionPablo()


    Private Sub proveedoresprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtidprov.Enabled = False

        Try
            conexion.ConnectionString = "server=localhost; user id= 'prueba' ; password='prueba';database = eldorado"
            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dtgProveedores.DataSource = consulta.mostrarEnTabla("SELECT `id_Prov`, `NombrePrv`, `TelefonoProv`, `EmpresaProv`, `RutEmpresaProv`, `DirEmpresaProv` FROM tblproveedores WHERE `EstadoProv` = '1' ;")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        conexion.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Try
           
            consulta.consultaSinRetorno("INSERT INTO tblproveedores(id_Prov ,NombrePrv, TelefonoProv, EmpresaProv, RutEmpresaProv,DirEmpresaProv,EstadoProv) VALUES ('" & txtidprov.Text & "','" & txtnombreprov.Text & "','" & txttelprov.Text & "', '" & txtempresaprov.Text & "','" & txtrutprov.Text & "', '" & txtdirprov.Text & "','1')")


            'comando.Parameters.AddWithValue("@id_Prov", txtidprov.Text)+
            'comando.Parameters.AddWithValue("@NombrePrv", txtnombreprov.Text)+
            'comando.Parameters.AddWithValue("@TelefonoProv", txttelprov.Text)+
            'comando.Parameters.AddWithValue("@EmpresaProv", txtempresaprov.Text)+
            'comando.Parameters.AddWithValue("@RutEmpresaProv", txtrutprov.Text)+
            'comando.Parameters.AddWithValue("@DirEmpresaProv", txtdirprov.Text)+
            'comando.Parameters.AddWithValue("@EstadoProv", RBProvactivo.Checked)
            'comando.ExecuteNonQuery()
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

        dtgProveedores.DataSource = consulta.mostrarEnTabla("SELECT `id_Prov`, `NombrePrv`, `TelefonoProv`, `EmpresaProv`, `RutEmpresaProv`, `DirEmpresaProv` FROM tblproveedores WHERE `EstadoProv` = '1' ;")

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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click


        Dim fila As DataGridViewRow = dtgProveedores.CurrentRow

        If dtgProveedores.SelectedCells.Count <> 0 Then
            'EnableBoton()
        End If

        Dim si As Byte


        'modificar datos de un Cliente
        si = MsgBox("Desea Modificar registro?", MsgBoxStyle.YesNo, "Eliminar")

        If si = 6 Then
            consulta.consultaSinRetorno("UPDATE `tblproveedores` SET `NombrePrv`='" & txtnombreprov.Text & "',`TelefonoProv`='" & txttelprov.Text & "',`EmpresaProv`='" & txtempresaprov.Text & "',`RutEmpresaProv`='" & txtrutprov.Text & "',`DirEmpresaProv`='" & txtidprov.Text & "' WHERE `id_Prov`='" & txtidprov.Text & "'")

            ''                                  

            MsgBox("Se Modifico registro", MsgBoxStyle.OkOnly, "Rgsitro Eliminado")
            dtgProveedores.DataSource = consulta.mostrarEnTabla("SELECT `id_Prov`, `NombrePrv`, `TelefonoProv`, `EmpresaProv`, `RutEmpresaProv`, `DirEmpresaProv` FROM tblproveedores WHERE `EstadoProv` = '1' ;")

        End If

        txtidprov.Text = ""
        txtnombreprov.Text = ""
        txttelprov.Text = ""
        txtempresaprov.Text = ""
        txtrutprov.Text = ""
        txtdirprov.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Dim si As Byte


        'eliminar datos de un empleado
        si = MsgBox("Desea Eliminar registro?", MsgBoxStyle.YesNo, "Eliminar")


        If si = 6 Then


            consulta.consultaSinRetorno("UPDATE `tblproveedores` SET `EstadoProv` = '0' WHERE `tblproveedores`.`id_Prov` = '" & dtgProveedores.CurrentRow.Index.ToString & "'")


            Dim loFila As DataGridViewRow = Me.dtgProveedores.CurrentRow()
            dtgProveedores.Rows.Remove(loFila)

            MsgBox("Se elimino registro", MsgBoxStyle.OkOnly, "Rgsitro Eliminado")
        End If



        'Try
        '    sql = "DELETE FROM tblproveedores WHERE id_Prov = '" & txtidprov.Text.Trim & "'"
        '    cmd = New MySqlCommand(sql, conexion)
        '    cmd.ExecuteNonQuery()
        '    MsgBox("Datos Borrados")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        txtidprov.Text = ""
        txtnombreprov.Text = ""
        txttelprov.Text = ""
        txtempresaprov.Text = ""
        txtrutprov.Text = ""
        txtdirprov.Text = ""

    End Sub

   
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

  
    Private Sub RBProvactivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        conexion.Close()
        panelsupprincipal.Show()
    End Sub

    Private Sub dtgProveedores_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgProveedores.CellClick


        Dim fila As DataGridViewRow = dtgProveedores.CurrentRow

        If dtgProveedores.SelectedCells.Count <> 0 Then

        End If


        txtidprov.Text = dtgProveedores.SelectedCells(0).Value.ToString

        txtidprov.Text = fila.Cells(0).Value.ToString
        txtnombreprov.Text = fila.Cells(1).Value.ToString
        txttelprov.Text = fila.Cells(2).Value.ToString
        txtempresaprov.Text = fila.Cells(3).Value.ToString
        txtrutprov.Text = fila.Cells(4).Value.ToString
        txtdirprov.Text = fila.Cells(5).Value


    End Sub

    Private Sub dtgProveedores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgProveedores.CellContentClick

    End Sub
End Class