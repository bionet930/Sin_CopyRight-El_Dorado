Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices

Imports System.Text
Imports System.Security.Cryptography




Public Class formlogin
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        Dim conexion As MySqlConnection = New MySqlConnection()
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion



        Try
            conexion.ConnectionString = "server=localhost; user id= 'prueba' ; password='prueba';database = eldorado"
            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando.CommandText = "SELECT * FROM tblempleados WHERE NombreEmpl='" + txtnombre.Text + "' AND PassEmpl = (AES_encrypt('" + txtpass.Text + "', 'AES'))"

        Dim r As MySqlDataReader

        r = comando.ExecuteReader

        If r.HasRows <> False Then
            r.Read()
            MsgBox(r.GetString("NombreEmpl") + " Bienvenido")
            panelsupprincipal.Show()
        Else
            MsgBox("Error Datos Incorrectos")
        End If

    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnmaxim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmaxim.Click
        btnmaxim.Visible = False
        btnrestaura.Visible = True
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnrestaura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestaura.Click
        btnrestaura.Visible = False
        btnmaxim.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnminm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnminm.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub panelsuplogin_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelsuplogin.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnaboutus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaboutus.Click
        MsgBox("Sin Copyright ©" & vbNewLine & "" & vbNewLine & "Escuela Superior Catalina Harriague de Castaños" & vbNewLine & "" & vbNewLine & "[ESP] Integrantes:" & vbNewLine & "Hugo Muñoz" & vbNewLine & "Pablo Dominguez" & vbNewLine & "Ismael Dutra" & vbNewLine & "" & vbNewLine & "Gracias por usar nuestros servicios." & vbNewLine & "" & vbNewLine & "[ENG] Members:" & vbNewLine & "Hugo Muñoz" & vbNewLine & "Pablo Dominguez" & vbNewLine & "Ismael Dutra" & vbNewLine & "" & vbNewLine & "Thanks for using our services.", , "About us")
    End Sub

    Private Sub formlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
