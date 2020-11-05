Imports System.Data
Imports System.Data.DataRow
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class ventasprincipal

    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public adt As MySqlDataAdapter
    Public ds As DataSet

    Dim conexion As New MySqlConnection()
    Dim comando As New MySqlCommand()

    Dim consulta As ConexionPablo = New ConexionPablo()

    Dim posicion As Integer

    'Llenar combobox
    Sub llenarCliente()

        cmbClientes.DataSource = consulta.mostrarEnTabla("select * from tblclientes;")
        cmbClientes.DisplayMember = "Id Cliente"
        cmbClientes.ValueMember = "id_Cliente"
    End Sub

    Sub llenarEmpleado()

        cmbEmpleados.DataSource = consulta.mostrarEnTabla("select * from tblempleados;")
        cmbEmpleados.DisplayMember = "Id Empleado"
        cmbEmpleados.ValueMember = "id_Empleado"

    End Sub

    Private Sub ventasprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        consulta.establecerConexion()
        llenarCliente()
        llenarEmpleado()


        ' borra todos los datos de la tabla detalle venta para una nueva venta
        consulta.consultaSinRetorno("TRUNCATE TABLE DETALLEVENTA;")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        detalleventa.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        dgvVentas.DataSource = consulta.mostrarEnTabla("Select * from detalleventa")

      
    End Sub

    Private Sub txtIdmercaderia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdmercaderia.TextChanged


        Try
            dgvVentas.DataSource = consulta.mostrarEnTabla("Select id_Mercaderia,NombreMerc,Descuento,PrecioVenta from tblmercaderia where id_Mercaderia = " & txtIdmercaderia.Text & ";")
            lblNombre.Text = dgvVentas.CurrentRow.Cells.Item(1).Value.ToString
            lblPrecio.Text = dgvVentas.CurrentRow.Cells.Item(3).Value.ToString
            If lblNombre.Text = "" Then
                MsgBox("Debe ingresar algun dato. ")
                lblNombre.Text = "*"

              


            End If

        Catch ex As Exception
            MsgBox("Debe ingresar algun dato. " & ex.Message)


        End Try


          

      



        '         id_Mercaderia | int(11)     | NO   | PRI | NULL    | auto_increment |
        '| NombreMerc    | varchar(20) | YES  |     | NULL    |                |
        '| Imagen        | varchar(50) | YES  |     | NULL    |                |
        '| PrecioCosto   | double      | YES  |     | NULL    |                |
        '| PrecioVenta   | double      | NO   |     | NULL    |                |
        '| id_Prov       | int(3)      | NO   | MUL | NULL    |                |
        '| Stock         | int(5)      | YES  |     | NULL    |                |
        '| Descuento     | double      | YES  |     | NULL    |                |
        '| EstadoProv    | tinyint(4)  | YES  |     | NULL    |                |
        '| EstadoMerc    | tinyint(4)  | YES  |     | NULL    |                |
        '+---------------+-------------+------+-----+---------+----------------+



        '        If DataGridView1.Rows.Count > 0 Then
        '            For Each Fila As DataGridViewRow In DataGridView1.Rows
        '                If Not Fila Is Nothing Then
        '                    '//Puedes hacer una validación con el nombre de la columna
        '                    If Fila.Cells("Correo").Value = "paco@miemail.com" Then
        '                        'Código
        '                    End If

        '                    '//O puedes hacer una validación con el número de la columna
        '                    If Fila.Cells(1).Value = "Luna Paola" Then
        '                        'Código
        '                    End If

        '                    '//O puedes almacenar el valor en una base de datos o mostrarlo en un textbox
        '                    TextBox1.Text = Fila.Cells("Telefono").Value
        '                End If
        '            Next
        '        End If

        '        '////// CICLO FOR //////
        '        If DataGridView1.Rows.Count > 0 Then
        '            For i As Integer = 0 To DataGridView1.Rows.Count
        '                If Not DataGridView1.Rows.Item(i) Is Nothing Then
        '                    '//Puedes hacer una validación con el nombre de la columna
        '                    If DataGridView1.Rows.Item(i).Cells("NombreDeUsuario").Value = "Gaby_26" Then
        '                        'Código
        '                    End If

        '                    '//O puedes hacer una validación con el número de la columna
        '                    If DataGridView1.Rows.Item(i).Cells(2).Value = "Duarte Mendieta" Then
        '                        'Código
        '                    End If

        '                    '//O puedes almacenar el valor en una base de datos o mostrarlo en un textbox
        '                    TextBox1.Text = DataGridView1.Rows.Item(i).Cells("NombreDeUsuario").Value
        '                End If
        '            Next
        '        End If
        'view rawComoRecorrerLasFilasDeUnDatagridview.vb hosted with ❤ by GitHub
        'De esta manera, podrás ir obteniendo los valores que necesitas de cada registro y posteriormente, irlos almacenando en una base de datos, mostrarlos al usuario o crear un informe con estos datos.




    End Sub

    Private Sub btnIngresarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarProducto.Click

        Dim con As Integer = 1
        Dim fecha As DateTime = Now()
        Dim strf As String
       

        'resultado = consulta.consultaConRetorno("select `CantidadMerc` from `eldorado`.`detalleventa` ")

        'xprecio = Val(resultado) * Val(nudCantidad.Value.ToString)


        strf = Format(fecha, "yyy-MM-dd") 'Se da formato a la fecha



        consulta.consultaSinRetorno("INSERT INTO `eldorado`.`detalleventa` (`id_Mercaderia`, `id_Empleado`, `fecha`, `CantidadMerc`, `PrecioVenta`, `id_Cliente`, `NombreMerc`) VALUES ('" & txtIdmercaderia.Text &
                                    "','" & cmbEmpleados.Text &
                                    "','" & strf.ToString &
                                    "','" & nudCantidad.Value &
                                    "', '" & lblPrecio.Text &
                                    "','" & cmbClientes.Text &
                                    "','" & lblNombre.Text & "');")

        If consulta.resultado = 1 Then
            MsgBox("Ingresado correctamente", vbOKOnly + vbDefaultButton2, "Mensaje")
            dgvFactura.DataSource = consulta.mostrarEnTabla("Select id_Mercaderia,NombreMerc, CantidadMerc, PrecioVenta  from detalleventa;")
            con = con + 1
        End If

        '        ---------------+-------------+------+-----+---------+----------------+
        '| Field         | Type        | Null | Key | Default | Extra          |
        '+---------------+-------------+------+-----+---------+----------------+
        '| id_Detalle    | int(11)     | NO   | PRI | NULL    | auto_increment |
        '| id_Mercaderia | int(11)     | NO   | MUL | NULL    |                |
        '| id_Empleado   | int(11)     | NO   | MUL | NULL    |                |
        '| fecha         | date        | YES  |     | NULL    |                |
        '| CantidadMerc  | int(11)     | YES  |     | NULL    |                |
        '| PrecioVenta   | double      | YES  |     | NULL    |                |
        '| id_Cliente    | int(11)     | YES  |     | NULL    |                |
        '| NombreMerc    | varchar(20) | YES  |     | NULL    |                |
        '+---------------+----------




        'InsertKeyMode into detalleventas
        'values(id_Detalle, id_Mercaderia, id_Empleado, fecha, CantidadMerc, PrecioVenta)
        '**se cargar el data grid
        'resta del stock



        'insertar en la tabla detalleventa toda la informacio
        'despues conectar el datagrid a la tabla detalle venta
        'UnhandledExceptionMode actualizar datos de la tabla

        Me.dgvFactura.Columns(0).HeaderText = "Identificado Producto"
        Me.dgvFactura.Columns(1).HeaderText = "Nombre Producto"
        Me.dgvFactura.Columns(2).HeaderText = "Cantidad"
        Me.dgvFactura.Columns(3).HeaderText = "Precio Producto"
    End Sub

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        'borra el articulo de la tabla detalleventa
        'actualiza la tabla


        Dim si As Byte

        si = MsgBox("Desea Eliminar registro?", MsgBoxStyle.YesNo, "Eliminar")


        If si = 6 Then
            consulta.consultaSinRetorno("DELETE FROM DETALLEVENTA WHERE id_Detalle= '" & dgvFactura.CurrentRow.Index.ToString & "'")

            Dim loFila As DataGridViewRow = Me.dgvFactura.CurrentRow()
            dgvFactura.Rows.Remove(loFila)

            MsgBox("Se elimino registro", MsgBoxStyle.OkOnly, "Rgsitro Eliminado")

        End If






    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click



        Dim Total As Single
        Dim Col As Integer = Me.dgvFactura.CurrentCell.ColumnIndex
        For Each row As DataGridViewRow In Me.dgvFactura.Rows
            Total += Val(row.Cells(3).Value)
        Next
        Me.TextBox1.Text = Total.ToString

       




    End Sub

    Private Sub nudCantidad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudCantidad.ValueChanged

      

        Label8.Text = Val(lblPrecio.Text) * nudCantidad.Value



    End Sub

  
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimirfac.Click
        'impresion_factura.Show()
        verificar_venta.Show()

        For Each ROW As DataGridViewRow In dgvFactura.SelectedRows
            Dim ID As String = ROW.Cells(0).Value
            Dim Nombre As String = ROW.Cells(1).Value
            Dim Cantidad As String = ROW.Cells(2).Value
            Dim Precio As String = ROW.Cells(3).Value

            verificar_venta.dgvimprimir.Rows.Add(ID, Nombre, Cantidad, Precio)


        Next

    End Sub

    Private Sub dgvFactura_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFactura.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class