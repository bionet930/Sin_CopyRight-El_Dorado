Imports MySql.Data.MySqlClient


Public Class stockprincipal
    Dim conex As New MySqlConnection("data source=localhost;user id=prueba; password=prueba;database=eldorado")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim consulta As ConexionPablo = New ConexionPablo()


    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public adt As MySqlDataAdapter
    Public ds As DataSet

    Dim conexion As New MySqlConnection()

    Dim posicion As Integer


    Private Sub btnstockprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call mostrarlosdatos()
    End Sub


    Sub llenarProveedores()

        cmdProveedores.DataSource = consulta.mostrarEnTabla("select * from tblproveedores;")
        cmdProveedores.DisplayMember = "Id Proveedor"
        cmdProveedores.ValueMember = "id_Prov"
    End Sub



    Private Sub mostrarlosdatos()
        Try
            sql = "SELECT * FROM tblmercaderia"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgvDatostock.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datosstock_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatostock.RowEnter
        sql = dgvDatostock.Rows(e.RowIndex).Cells(2).Value.ToString

    End Sub

    Private Sub stockprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        llenarProveedores()
        consulta.establecerConexion()
        dgvDatostock.DataSource = consulta.mostrarEnTabla("Select  * from tblmercaderia;")



        MsgBox("carga y conecta")
    End Sub


    Private Sub btnstockprincipal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstockprincipal.Click
        mostrarlosdatos()

    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click



        consulta.consultaSinRetorno("INSERT INTO tblmercaderia(id_Mercaderia,NombreMerc,Imagen,PrecioCosto,PrecioVenta,id_Prov,Stock,Descuento) Values (" & txtIdmercaderia.Text &
                                    ",'" & txtNombre.Text &
                                    "','" & txtImagen.Text &
                                    "','" & txtPrecioCosto.Text &
                                    "','" & txtPrecioVenta.Text &
                                    "','" & cmdProveedores.Text &
                                    "','" & txtStock.Text &
                                    "','" & txtDescuento.Text & "');")

        If consulta.resultado = 1 Then
            MsgBox("Ingresado correctamente", vbOKOnly + vbDefaultButton2, "Mensaje")
            dgvDatostock.DataSource = consulta.mostrarEnTabla("Select  id_Mercaderia,NombreMerc,Imagen,PrecioCosto, PrecioVenta, id_Prov, Stock,Descuento from tblmercaderia;")
        End If

        txtIdmercaderia.Text = ""
        txtNombre.Text = ""
        txtImagen.Text = ""
        txtPrecioCosto.Text = ""
        txtPrecioVenta.Text = ""
        txtImagen.Text = ""


        Dim errores As String = ""

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

    End Sub

    Private Sub btnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagen.Click

        ofdStock.Title = "Seleccione una imagen"
        ofdStock.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|GIF|*.gif"

        Dim eleccion As Integer = ofdStock.ShowDialog(Me)

        If eleccion = DialogResult.OK Then
            avatar.Image = System.Drawing.Image.FromFile(ofdStock.FileName)
            avatar.SizeMode = PictureBoxSizeMode.StretchImage
            txtImagen.Text = ofdStock.FileName
        End If

    End Sub

  
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Me.Hide()


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        ''UPDATE `tblmercaderia` SET `EstadoMerc`= 0 WHERE  
        'consulta.consultaSinRetorno("UPDATE `tblmercaderia` SET `Stock`= Stock - '" & nudCantidad.Value & "';")
        'MsgBox("se borro stock", vbOKOnly + vbDefaultButton2, "Mensaje")

        Dim si As Byte

        si = MsgBox("Desea Eliminar registro?", MsgBoxStyle.YesNo, "Eliminar")


        If si = 6 Then
            consulta.consultaSinRetorno("UPDATE `tblmercaderia` SET `EstadoMerc`= 0 WHERE `id_Mercaderia = '" & dgvDatostock.CurrentRow.Index.ToString & "'")

            Dim loFila As DataGridViewRow = Me.dgvDatostock.CurrentRow()
            dgvDatostock.Rows.Remove(loFila)

            MsgBox("Se elimino registro", MsgBoxStyle.OkOnly, "Rgsitro Eliminado")

        End If


    End Sub
End Class

