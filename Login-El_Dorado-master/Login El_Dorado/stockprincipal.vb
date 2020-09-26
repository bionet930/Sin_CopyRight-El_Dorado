Imports MySql.Data.MySqlClient


Public Class stockprincipal
    Dim conex As New MySqlConnection("data source=localhost;user id=prueba; password=prueba;database=eldorado")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand

    Private Sub btnstockprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstockprincipal.Click
        Call mostrarlosdatos()
    End Sub

    Private Sub mostrarlosdatos()
        Try
            sql = "SELECT * FROM tblmercaderia"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            datosstock.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datosstock_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datosstock.RowEnter
        sql = datosstock.Rows(e.RowIndex).Cells(2).Value.ToString
    End Sub

    Private Sub stockprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class