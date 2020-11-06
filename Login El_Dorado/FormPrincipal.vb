Imports System.Runtime.InteropServices
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class panelsupprincipal

    Dim da As MySqlDataAdapter
    Dim ds As DataSet


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()


    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub


    Private Sub btncerrarprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrarprincipal.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnminimprincipal.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnrestauraprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestauraprincipal.Click
        btnrestauraprincipal.Visible = False
        btnmaximprincipal.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnmaximprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmaximprincipal.Click
        btnmaximprincipal.Visible = False
        btnrestauraprincipal.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlsuperiorprinciapl.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmocultarmenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmocultarmenu.Tick
        If panelizqprincipal.Width <= 60 Then
            Me.tmocultarmenu.Enabled = False
        Else
            Me.panelizqprincipal.Width = panelizqprincipal.Width - 20
        End If
    End Sub

    Private Sub tmmostrarmenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmmostrarmenu.Tick
        If panelizqprincipal.Width >= 220 Then
            Me.tmmostrarmenu.Enabled = False
        Else
            Me.panelizqprincipal.Width = panelizqprincipal.Width + 20
        End If
    End Sub

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenuprincipal.Click
        If panelizqprincipal.Width = 220 Then
            tmocultarmenu.Enabled = True
        ElseIf panelizqprincipal.Width = 60 Then
            tmmostrarmenu.Enabled = True

        End If
    End Sub

    Private Sub Abrirformprincipal(ByVal formhijo As Object)
        If Me.panelprincipal.Controls.Count > 0 Then
            Me.panelprincipal.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.panelprincipal.Controls.Add(fh)
        Me.panelprincipal.Tag = fh
        fh.Show()


    End Sub

    Private Sub btnstockprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstockprincipal.Click
        Abrirformprincipal(New stockprincipal)
    End Sub

    Private Sub btnventasprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnventasprincipal.Click
        Abrirformprincipal(New ventasprincipal)
    End Sub

    Private Sub btnempleadosprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnempleadosprincipal.Click
        Abrirformprincipal(New empleadosprincipal)
    End Sub

    Private Sub btnclientesprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclientesprincipal.Click
        Abrirformprincipal(New clientesprincipal)
    End Sub

    Private Sub btnproveedorprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproveedorprincipal.Click
        Abrirformprincipal(New proveedoresprincipal)
    End Sub

    Private Sub panelprincipal_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelprincipal.Paint

    End Sub

    Private Sub FormPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Conexion As MySqlConnection
        Conexion = New MySqlConnection()
        Conexion.ConnectionString = "Server=localhost;Database=eldorado;Uid=prueba;Pwd=prueba;"

        Dim sqlventas As String = "SELECT * FROM tblmercaderia"
        Dim da As New MySqlDataAdapter(sqlventas, Conexion)

        Dim ds As New DataSet()
        da.Fill(ds, "tblmercaderia")

        With Stock
            .Series.Clear()
            .Series.Add("Series1")
        End With


        Stock.DataSource = ds.Tables("tblmercaderia")
        Dim series1 As Series = Stock.Series("Series1")
        series1.ChartType = SeriesChartType.Column

        series1.Name = "Stock"


        With Stock
            .Series(series1.Name).XValueMember = "NombreMerc"
            .Series(series1.Name).YValueMembers = "Stock"
            .Series(0).LabelFormat = "{#,##0}"
        End With


    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stock.Click

    End Sub

End Class