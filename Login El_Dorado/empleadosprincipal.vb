
Imports System.Data
Imports System.Data.DataRow
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class empleadosprincipal

    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public adt As MySqlDataAdapter
    Public ds As DataSet
    Dim conexion As New MySqlConnection()
    Dim comando As New MySqlCommand()
    Dim consulta As ConexionPablo = New ConexionPablo()
    Dim posicion As Integer


    Private Sub empleadosprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        consulta.establecerConexion()
        dgvEmpleados.DataSource = consulta.mostrarEnTabla("Select  Id_Empleado, NombreEmpl,EdadEmpl,TelefonoEmpl,DireccionEmpl,CarnetEmpl from tblEmpleados where EstadoEmpl = '1' ;")

    End Sub

  

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
        conexion.Close()
        panelsupprincipal.Show()

    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Dim fecha As DateTime = dtpNacimiento.Value
        Dim strf As String
        Dim fecha2 As DateTime = dtpNacimiento.Value
        Dim strf2 As String


        strf2 = Format(fecha2, "yyy-MM-dd") 'Se da formato a la fecha Carnet
        strf = Format(fecha, "yyy-MM-dd") 'Se da formato a la fecha

        txtEdad.Text = DateDiff(DateInterval.Year, dtpNacimiento.Value, Date.Now)

        ' insertar datos a la tabla

        consulta.consultaSinRetorno("INSERT INTO tblEmpleados (id_Empleado,NombreEmpl,EdadEmpl,TelefonoEmpl,DireccionEmpl,ImagenEmpl,CarnetEmpl,PassEmpl, EstadoEmpl) Values ('" & txtId.Text & "','" & txtNombre.Text &
                                    "', " & txtEdad.Text & ", '" & txtTelefono.Text & "','" & txtDireccion.Text & "', '" & txtImagen.Text &
                                    "','" & strf.ToString & "','" & txtPass.Text & "', '1' );")

        If consulta.resultado = 1 Then
            MsgBox("Ingresado correctamente", vbOKOnly + vbDefaultButton2, "Mensaje")
            dgvEmpleados.DataSource = consulta.mostrarEnTabla("Select  Id_Empleado, NombreEmpl,EdadEmpl,TelefonoEmpl,DireccionEmpl,CarnetEmpl from tblEmpleados where EstadoEmpl = '1';")
        End If

        txtId.Text = ""
        txtNombre.Text = ""
        txtEdad.Text = ""
        txtDireccion.Text = ""
        txtImagen.Text = ""
        txtPass.Text = ""
        txtTelefono.Text = ""


        Dim errores As String = ""

        If txtNombre.Text = "" Then
            errores &= "El nomnbre no puede estar vacio" & vbCrLf

        End If

        If DateDiff(DateInterval.Year, dtpNacimiento.Value, Date.Now) < 18 Then
            errores &= "La edad del empleado es menor a 18 años" & vbCrLf


        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim si As Byte


        'eliminar datos de un empleado
        si = MsgBox("Desea Eliminar registro?", MsgBoxStyle.YesNo, "Eliminar")


        If si = 6 Then
            consulta.consultaSinRetorno("UPDATE `tblempleados` SET `EstadoEmpl` = '0' WHERE `id_Empleado` = '" & txtId.Text & "'")

            Dim loFila As DataGridViewRow = Me.dgvEmpleados.CurrentRow()
            dgvEmpleados.Rows.Remove(loFila)

            MsgBox("Se elimino registro", MsgBoxStyle.OkOnly, "Rgsitro Eliminado")

        End If



         End Sub

    Sub actualizarTabla()
        '**
        dgvEmpleados.DataSource = consulta.mostrarEnTabla("Select  id_Empleado, NombreEmpl, EdadEmpl, TelefonoEmpl, DireccionEmpl, CarnetEmpl from tblempleados where `EstadoEmpl`= 1  ;")

    End Sub

    Private Sub Button1_Click()

        actualizarTabla()

    End Sub


    Private Sub btnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagen.Click

        'seleccionar imagen empleado

        opfdempleados.Title = "Seleccione una imagen"
        opfdempleados.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|GIF|*.gif"

        Dim eleccion As Integer = opfdempleados.ShowDialog(Me)

        If eleccion = DialogResult.OK Then
            avatar.Image = System.Drawing.Image.FromFile(opfdempleados.FileName)
            avatar.SizeMode = PictureBoxSizeMode.StretchImage
            txtImagen.Text = opfdempleados.FileName
        End If

    End Sub

   
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        '  Borrar Imagen

        txtImagen.Text = ""
        avatar.Image.Dispose()
        avatar.Image = Nothing
        MsgBox("Imagen borrada")
    End Sub

    Private Sub dtpNacimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpNacimiento.ValueChanged
        txtEdad.Text = DateDiff(DateInterval.Year, dtpNacimiento.Value, Date.Now)
    End Sub

   
  
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click


        Dim fila As DataGridViewRow = dgvEmpleados.CurrentRow

        If dgvEmpleados.SelectedCells.Count <> 0 Then
            'EnableBoton()
        End If

        Dim si As Byte


        'modificar datos de un Cliente
        si = MsgBox("Desea Modificar registro?", MsgBoxStyle.YesNo, "Eliminar")

        If si = 6 Then
            consulta.consultaSinRetorno("UPDATE `tblempleados` SET `NombreEmpl`='" & txtNombre.Text & "',`EdadEmpl`='" & txtEdad.Text & "',`TelefonoEmpl`='" & txtTelefono.Text & "',`DireccionEmpl`='" & txtDireccion.Text & "',`CarnetEmpl`='" & dtpCarnet.Text & "' WHERE `id_Empleado`='" & txtId.Text & "'")

            ''                                  

            MsgBox("Se Modifico registro", MsgBoxStyle.OkOnly, "Rgsitro Eliminado")
            dgvEmpleados.DataSource = consulta.mostrarEnTabla("SELECT `id_Empleado`, `NombreEmpl`, `EdadEmpl`, `TelefonoEmpl`, `DireccionEmpl`, `CarnetEmpl` FROM tblempleados WHERE `EstadoEmpl` = '1' ;")

        End If

        txtId.Text = ""
        txtNombre.Text = ""
        txtEdad.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        'txtdirprov.Text = ""


    End Sub

    Private Sub dgvEmpleados_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick

        Dim fila As DataGridViewRow = dgvEmpleados.CurrentRow

        Try

            If dgvEmpleados.SelectedCells.Count <> 0 Then

            End If


            txtId.Text = dgvEmpleados.SelectedCells(0).Value.ToString

            txtId.Text = fila.Cells(0).Value.ToString
            txtNombre.Text = fila.Cells(1).Value.ToString
            'dtpNacimiento.Text = fila.Cells(2).Value.ToString
            txtEdad.Text = fila.Cells(2).Value.ToString
            txtTelefono.Text = fila.Cells(3).Value.ToString
            txtDireccion.Text = fila.Cells(4).Value
            dtpCarnet.Text = fila.Cells(5).Value.ToString


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub dgvEmpleados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmpleados.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click

        txtId.Clear()
        txtId.Enabled = True

        txtNombre.Clear()

        txtEdad.Clear()
        txtTelefono.Clear()
        txtDireccion.Clear()

        btnIngresar.Enabled = True
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        btnCerrar.Enabled = True
        btnNuevo.Enabled = False

    End Sub
End Class
