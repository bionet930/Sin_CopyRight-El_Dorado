
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
        dgvEmpleados.DataSource = consulta.mostrarEnTabla("Select  Id_Empleado, NombreEmpl,EdadEmpl,TelefonoEmpl,DireccionEmpl,ImagenEmpl,CarnetEmpl from tblEmpleados;")




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistroempl.Click
        registroempl.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
        conexion.Close()
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click


        txtEdad.Text = DateDiff(DateInterval.Year, dtpNacimiento.Value, Date.Now)

        consulta.consultaSinRetorno("INSERT INTO tblEmpleados (NombreEmpl,EdadEmpl,TelefonoEmpl,DireccionEmpl,ImagenEmpl,CarnetEmpl,PassEmpl) Values ('" & txtNombre.Text &
                                    "', " & txtEdad.Text & ", '" & txtTelefono.Text & "','" & txtDireccion.Text & "', '" & txtImagen.Text &
                                    "','" & txtCarnet.Text & "','" & txtPass.Text & "'  );")

        If consulta.resultado = 1 Then
            MsgBox("Ingresado correctamente", vbOKOnly + vbDefaultButton2, "Mensaje")
            dgvEmpleados.DataSource = consulta.mostrarEnTabla("Select  Id_Empleado, NombreEmpl,EdadEmpl,TelefonoEmpl,DireccionEmpl,ImagenEmpl,CarnetEmpl from tblEmpleados;")
        End If

        txtId.Text = ""
        txtNombre.Text = ""
        txtEdad.Text = ""
        txtcarnet.Text = ""
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


        MsgBox("se debe agregar campo visible boolean (1/0) y las delete pasan a hacer una consulta que altera el visible. las consultas posteriores se deben hacer con esa condicion")
    End Sub


    Private Sub btnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagen.Click

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

        txtImagen.Text = ""
        avatar.Image.Dispose()
        avatar.Image = Nothing
        MsgBox("Imagen borrada")
    End Sub

    Private Sub panelprincipal_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelprincipal.Paint

    End Sub
End Class
