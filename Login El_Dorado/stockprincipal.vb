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
        inhabilitarBotones()
        limpiarTex()
        llenarProveedores()
        consulta.establecerConexion()
        inabilitarTextos()
        actualizarTabla()


    End Sub


    Private Sub btnstockprincipal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstockprincipal.Click
        'mostrarlosdatos()

        'modificar stock, actualizar precios de costo, venta y descuentos si existen


        Dim fila As DataGridViewRow = dgvDatostock.CurrentRow

        btnActualizarStock.Visible = True

        btnIngresar.Visible = False
        btnModificar.Visible = False
        btnEliminar.Visible = False
        btnstockprincipal.Visible = False


        Try

            If dgvDatostock.SelectedCells.Count <> 0 Then

            End If


            txtIdmercaderia.Text = dgvDatostock.SelectedCells(0).Value.ToString

            txtIdmercaderia.Text = fila.Cells(0).Value.ToString
            txtNombre.Text = fila.Cells(1).Value.ToString
            txtPrecioCosto.Text = fila.Cells(2).Value.ToString
            txtPrecioVenta.Text = fila.Cells(3).Value.ToString
            txtStock.Text = fila.Cells(5).Value
            txtDescuento.Text = fila.Cells(6).Value.ToString


            'desabilitar
            txtIdmercaderia.Enabled = False
            txtNombre.Enabled = False
            txtPrecioCosto.Text = fila.Cells(2).Value.ToString
            txtPrecioVenta.Text = fila.Cells(3).Value.ToString
            txtStock.Text = fila.Cells(5).Value
            txtDescuento.Text = fila.Cells(6).Value.ToString





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Sub limpiarTex()
        txtIdmercaderia.Clear()
        txtNombre.Clear()
        txtImagen.Clear()
        txtPrecioCosto.Clear()
        txtPrecioVenta.Clear()
        txtImagen.Text = ""
        cmdProveedores.Text = ""
        txtStock.Clear()
        txtDescuento.Clear()


    End Sub

    Sub inabilitarTextos()

        txtIdmercaderia.Enabled = False
        txtNombre.Enabled = False
        txtImagen.Enabled = False
        txtPrecioCosto.Enabled = False
        txtPrecioVenta.Enabled = False
        txtImagen.Text = ""
        cmdProveedores.Enabled = False
        txtStock.Enabled = False
        txtDescuento.Enabled = False

    End Sub
    Sub habilitarTextos()

        txtIdmercaderia.Enabled = True
        txtNombre.Enabled = True
        txtImagen.Enabled = True
        txtPrecioCosto.Enabled = True
        txtPrecioVenta.Enabled = True
        txtImagen.Text = ""
        cmdProveedores.Enabled = True
        txtStock.Enabled = True
        txtDescuento.Enabled = True

    End Sub

    Sub inhabilitarBotones()

        btnIngresar.Visible = False
        btnModificar.Visible = False
        btnEliminar.Visible = False
        btnstockprincipal.Visible = False

    End Sub

    Sub habilitarBotones()

        btnIngresar.Visible = True
        btnModificar.Visible = True
        btnEliminar.Visible = True
        btnstockprincipal.Visible = True

    End Sub


    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click


        Try

            consulta.consultaSinRetorno("INSERT INTO tblMercaderia(id_Mercaderia ,NombreMerc, Imagen, PrecioCosto, PrecioVenta,id_Prov, Stock, Descuento, EstadoMerc) VALUES ('" & txtIdmercaderia.Text & "','" & txtNombre.Text & "', '" & txtImagen.Text & "','" & txtPrecioCosto.Text & "', '" & txtPrecioVenta.Text & "','" & cmdProveedores.Text & "', '" & txtStock.Text & "', '" & txtDescuento.Text & "','1')")

            MsgBox("Datos Guardado")

            txtIdmercaderia.Text = ""
            txtNombre.Text = ""
            txtImagen.Text = ""
            txtPrecioCosto.Text = ""
            txtPrecioVenta.Text = ""
            cmdProveedores.Text = ""
            txtStock.Text = ""
            txtDescuento.Text = ""

        Catch ex As Exception
            MsgBox("Error al Guardar los Datos")
        End Try



        limpiarTex()
        btnIngresarProducto.Visible = True
        btnIngresar.Visible = False
        btnModificar.Visible = False
        btnEliminar.Visible = False
        btnstockprincipal.Visible = False






    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click


        Dim fila As DataGridViewRow = dgvDatostock.CurrentRow

        If dgvDatostock.SelectedCells.Count <> 0 Then


        End If

        Dim si As Byte


        'modificar datos de un Cliente
        si = MsgBox("Desea Modificar registro?", MsgBoxStyle.YesNo, "Eliminar")

        If si = 6 Then
            consulta.consultaSinRetorno("UPDATE `tblmercaderia` SET `NombreMerc`='" & txtNombre.Text & "',`PrecioCosto`='" & txtPrecioCosto.Text & "',`PrecioVenta`= '" & txtPrecioVenta.Text & "',`id_Prov`= '" & cmdProveedores.Text & "' ,`Stock`='" & txtStock.Text & "',`Descuento`='" & txtDescuento.Text & "' WHERE id_Mercaderia=   '" & txtIdmercaderia.Text & "' ")

            MsgBox("Se Modifico registro", MsgBoxStyle.OkOnly, "Rgsitro Modificado")
            dgvDatostock.DataSource = consulta.mostrarEnTabla("SELECT `id_Mercaderia`, `NombreMerc`, `PrecioCosto`, `PrecioVenta`, `id_Prov`, `Stock`, `Descuento` FROM `tblmercaderia` ;")

        End If

        limpiarTex()

    End Sub


    Private Sub btnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagen.Click

        'se deja para en un futuro agregar funciones de ingreso de imagen si el cliente lo desea 

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

        Me.Close()
        conex.Close()
        conexion.Close()
        panelsupprincipal.Show()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click


        Dim si As Byte

        si = MsgBox("Desea Eliminar registro?", MsgBoxStyle.YesNo, "Eliminar")


        If si = 6 Then
            consulta.consultaSinRetorno("UPDATE `tblmercaderia` SET `EstadoMerc`= 0 WHERE id_Mercaderia = '" & dgvDatostock.CurrentRow.Index.ToString & "'")

            Dim loFila As DataGridViewRow = Me.dgvDatostock.CurrentRow()
            dgvDatostock.Rows.Remove(loFila)

            MsgBox("Se elimino registro", MsgBoxStyle.OkOnly, "Regsitro Eliminado")




        End If


    End Sub

    Private Sub dgvDatostock_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatostock.CellClick

        Dim fila As DataGridViewRow = dgvDatostock.CurrentRow

        habilitarBotones()
        habilitarTextos()



        Try

            If dgvDatostock.SelectedCells.Count <> 0 Then

            End If


            txtIdmercaderia.Text = dgvDatostock.SelectedCells(0).Value.ToString

            txtIdmercaderia.Text = fila.Cells(0).Value.ToString
            txtNombre.Text = fila.Cells(1).Value.ToString
            txtPrecioCosto.Text = fila.Cells(2).Value.ToString
            txtPrecioVenta.Text = fila.Cells(3).Value.ToString
            cmdProveedores.Text = fila.Cells(4).Value.ToString
            txtStock.Text = fila.Cells(5).Value
            txtDescuento.Text = fila.Cells(6).Value.ToString


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarStock.Click
        Dim si As Byte

        limpiarTex()


        si = MsgBox("Desea Modificar registro?", MsgBoxStyle.YesNo, "Modificar")

        If si = 6 Then
            consulta.consultaSinRetorno("UPDATE `tblmercaderia` SET `PrecioCosto`='" & txtPrecioCosto.Text & "',`PrecioVenta`= '" & txtPrecioVenta.Text & "' ,`Stock`='" & txtStock.Text & "',`Descuento`='" & txtDescuento.Text & "' WHERE id_Mercaderia=   '" & txtIdmercaderia.Text & "' ")

        End If



        MsgBox("Se Modifico registro", MsgBoxStyle.OkOnly, "Rgsitro Modificado")


        actualizarTabla()

        btnActualizarStock.Visible = False

        btnIngresar.Visible = True
        btnModificar.Visible = True
        btnEliminar.Visible = True
        btnstockprincipal.Visible = True


        txtNombre.Enabled = True




    End Sub

    Private Sub btnIngresarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarProducto.Click



        Try

            consulta.consultaSinRetorno("INSERT INTO tblmercaderia(id_Mercaderia,NombreMerc,Imagen,PrecioCosto,PrecioVenta,id_Prov,Stock,Descuento,EstadoMerc) Values (" & txtIdmercaderia.Text &
                                        ",'" & txtNombre.Text &
                                        "','" & txtImagen.Text &
                                        "','" & txtPrecioCosto.Text &
                                        "','" & txtPrecioVenta.Text &
                                        "','" & cmdProveedores.Text &
                                        "','" & txtStock.Text &
                                        "','" & txtDescuento.Text & "','1');")

            If consulta.resultado = 1 Then
                MsgBox("Ingresado correctamente", vbOKOnly + vbDefaultButton2, "Mensaje")


                actualizarTabla()

            End If

            limpiarTex()

            Dim errores As String = ""

        Catch ex As Exception
            '
            MsgBox("El Producto ya se encuentra Registrado" + vbCrLf + ex.Message)
        End Try

        btnIngresarProducto.Visible = False

        btnIngresar.Visible = True
        btnModificar.Visible = True
        btnEliminar.Visible = True
        btnstockprincipal.Visible = True

        limpiarTex()





    End Sub

    Sub actualizarTabla()
        '**
        dgvDatostock.DataSource = consulta.mostrarEnTabla("Select  id_Mercaderia,NombreMerc,PrecioCosto, PrecioVenta, id_Prov, Stock,Descuento from tblmercaderia where `EstadoMerc`= 1  ;")
    End Sub

  
End Class

