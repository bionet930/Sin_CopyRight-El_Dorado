Imports System.Data
Imports System.Data.DataRow
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class clientesprincipal

    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public adt As MySqlDataAdapter
    Public ds As DataSet

    Dim conexion As New MySqlConnection()
    Dim comando As New MySqlCommand()

    Dim consulta As ConexionPablo = New ConexionPablo()

    Dim posicion As Integer



    Private Sub clientesprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        consulta.establecerConexion()
        dgvClientes.DataSource = consulta.mostrarEnTabla("SELECT `id_Cliente`, `NombreCli`, `DomicilioCli`, `TelefonoCli`, `SaldoCli`, `PagoCli` FROM `tblclientes` WHERE `EstadoClient` = 1 ;")


        'Dim fila As DataGridViewRow = dgvClientes.CurrentRow

        'If dgvClientes.SelectedCells.Count <> 0 Then
        '    EnableBoton()
        'End If


        'txtId.Text = dgvClientes.SelectedCells(0).Value.ToString

        'txtId.Text = fila.Cells(0).Value.ToString
        'txtNombre.Text = fila.Cells(1).Value.ToString
        'txtTelefono.Text = fila.Cells(2).Value.ToString
        'txtDireccion.Text = fila.Cells(3).Value.ToString
        'txtSaldo.Text = fila.Cells(4).Value.ToString
        'txtPago.Text = fila.Cells(5).Value
        ''txtImagen.Text = fila.Cells(6).Value.ToString



    End Sub

  
    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click



        consulta.consultaSinRetorno("INSERT INTO tblclientes(id_Cliente,NombreCli,DomicilioCli,TelefonoCli,SaldoCli,PagoCli) Values (" & txtId.Text &
                                    ",'" & txtNombre.Text &
                                    "','" & txtDireccion.Text &
                                    "','" & txtTelefono.Text &
                                    "','" & txtSaldo.Text &
                                    "','" & txtPago.Text & "');")

        If consulta.resultado = 1 Then
            MsgBox("Ingresado correctamente", vbOKOnly + vbDefaultButton2, "Mensaje")
            dgvClientes.DataSource = consulta.mostrarEnTabla("Select * from tblclientes")
        End If

        txtId.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtSaldo.Text = ""
        txtPago.Text = ""


        Dim errores As String = ""



    End Sub

   
    Private Sub btnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagen.Click
        ofdClientes.Title = "Seleccione una imagen"
        ofdClientes.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|GIF|*.gif"

        Dim eleccion As Integer = ofdClientes.ShowDialog(Me)

        If eleccion = DialogResult.OK Then
            avatar.Image = System.Drawing.Image.FromFile(ofdClientes.FileName)
            avatar.SizeMode = PictureBoxSizeMode.StretchImage
            txtImagen.Text = ofdClientes.FileName
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim si As Byte


        'eliminar datos de un empleado
        si = MsgBox("Desea Eliminar registro?", MsgBoxStyle.YesNo, "Eliminar")


        If si = 6 Then


            consulta.consultaSinRetorno("UPDATE `tblclientes` SET `EstadoClient`= 0 WHERE `tblclientes`.`id_Cliente` = '" & dgvClientes.CurrentRow.Index.ToString & "'")


            Dim loFila As DataGridViewRow = Me.dgvClientes.CurrentRow()
            dgvClientes.Rows.Remove(loFila)

            MsgBox("Se elimino registro", MsgBoxStyle.OkOnly, "Rgsitro Eliminado")

        End If


        txtId.Clear()
        txtId.Clear()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtSaldo.Clear()
        txtPago.Clear()


    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Sub EnableBoton()
        btnCerrar.Enabled = False
        btnIngresar.Enabled = False
        btnEliminar.Enabled = False


    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click


        Dim fila As DataGridViewRow = dgvClientes.CurrentRow

        If dgvClientes.SelectedCells.Count <> 0 Then
            'EnableBoton()
        End If

        Dim si As Byte


        'modificar datos de un Cliente
        si = MsgBox("Desea Modificar registro?", MsgBoxStyle.YesNo, "Eliminar")

        If si = 6 Then
            consulta.consultaSinRetorno("UPDATE `tblclientes` SET `NombreCli`='" & txtNombre.Text & "',`DomicilioCli`='" & txtDireccion.Text & "',`TelefonoCli`='" & txtTelefono.Text & "',`SaldoCli`='" & txtSaldo.Text & "',`PagoCli`='" & txtPago.Text & "' WHERE `id_Cliente`='" & txtId.Text & "'")
            MsgBox("Se Modifico registro", MsgBoxStyle.OkOnly, "Rgsitro Eliminado")
            dgvClientes.DataSource = consulta.mostrarEnTabla("SELECT `id_Cliente`, `NombreCli`, `DomicilioCli`, `TelefonoCli`, `SaldoCli`, `PagoCli` FROM `tblclientes` WHERE `EstadoClient` = 1 ;")
        End If





        txtId.Clear()
        txtId.Clear()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtSaldo.Clear()
        txtPago.Clear()

    End Sub

    
    Private Sub dgvClientes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        Dim fila As DataGridViewRow = dgvClientes.CurrentRow

        If dgvClientes.SelectedCells.Count <> 0 Then

        End If


        txtId.Text = dgvClientes.SelectedCells(0).Value.ToString

        txtId.Text = fila.Cells(0).Value.ToString
        txtNombre.Text = fila.Cells(1).Value.ToString
        txtDireccion.Text = fila.Cells(2).Value.ToString
        txtTelefono.Text = fila.Cells(3).Value.ToString
        txtSaldo.Text = fila.Cells(4).Value.ToString
        txtPago.Text = fila.Cells(5).Value

       

    End Sub

   
End Class