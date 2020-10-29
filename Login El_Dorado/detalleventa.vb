Imports MySql.Data.MySqlClient
Public Class detalleventa

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
    Dim idProducto As Integer





    Private Sub detalleventa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consulta.establecerConexion()
        dgstock.DataSource = consulta.mostrarEnTabla(" select id_Mercaderia,NombreMerc,PrecioVenta,Descuento from tblmercaderia;")


        MsgBox("carga y conecta")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        lblProducto.Text = dgstock.CurrentRow.Cells.Item(0).Value.ToString
        ventasprincipal.txtIdmercaderia.Text = lblProducto.Text.ToString





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        idProducto = dgstock.CurrentRow.Cells.Item(0).Value.ToString
        Me.Close()
    End Sub

    Private Sub dgstock_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgstock.CellContentClick

        idProducto = dgstock.CurrentRow.Cells.Item(0).Value.ToString
    End Sub
End Class