
Public Class Enviar_Correo

    Private Sub btnenviarcorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenviarcorreo.Click

        enviarCorreo(txtEmisor.Text, txtPassword.Text, rtbMensaje.Text, txtAsunto.Text, txtReceptor.Text)

    End Sub

    Private Sub btncerrarcorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrarcorreo.Click

        Me.Close()

        panelsupprincipal.Show()


    End Sub


    Private Sub Enviar_Correo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class