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
        dgvClientes.DataSource = consulta.mostrarEnTabla("Select  * from tblclientes;")



    End Sub

  
    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click




        consulta.consultaSinRetorno("INSERT INTO tblclientes(id_Cliente,NombreCli,DomicilioCli,TelefonoCli,SaldoCli,PagoCli) Values (" & txtId.Text &
                                    ",'" & txtNombre.Text &
                                    "','" & txtDireccion.Text &
                                    "','" & txtTelefono.Text &
                                    "','" & txtSado.Text &
                                    "','" & txtPago.Text & "');")

        If consulta.resultado = 1 Then
            MsgBox("Ingresado correctamente", vbOKOnly + vbDefaultButton2, "Mensaje")
            dgvClientes.DataSource = consulta.mostrarEnTabla("Select * from tblclientes")
        End If

        txtId.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtSado.Text = ""
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
End Class