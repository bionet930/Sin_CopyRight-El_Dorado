
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistroempl.Click
        registroempl.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
        conexion.Close()
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

        consulta.consultaSinRetorno("INSERT INTO tblEmpleados (NombreEmpl,EdadEmpl,TelefonoEmpl,DireccionEmpl,ImagenEmpl,CarnetEmpl,PassEmpl, EstadoEmpl) Values ('" & txtNombre.Text &
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
            consulta.consultaSinRetorno("UPDATE `tblempleados` SET `EstadoEmpl` = '0' WHERE `tblempleados`.`id_Empleado` = '" & dgvEmpleados.CurrentRow.Index.ToString & "'")

            Dim loFila As DataGridViewRow = Me.dgvEmpleados.CurrentRow()
            dgvEmpleados.Rows.Remove(loFila)

            MsgBox("Se elimino registro", MsgBoxStyle.OkOnly, "Rgsitro Eliminado")

        End If



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
End Class
