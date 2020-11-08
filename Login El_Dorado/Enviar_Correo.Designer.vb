<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enviar_Correo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtEmisor = New System.Windows.Forms.TextBox()
        Me.txtReceptor = New System.Windows.Forms.TextBox()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.rtbMensaje = New System.Windows.Forms.RichTextBox()
        Me.btnenviarcorreo = New System.Windows.Forms.Button()
        Me.btncerrarcorreo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEmisor
        '
        Me.txtEmisor.Location = New System.Drawing.Point(219, 51)
        Me.txtEmisor.Name = "txtEmisor"
        Me.txtEmisor.Size = New System.Drawing.Size(162, 20)
        Me.txtEmisor.TabIndex = 0
        Me.txtEmisor.Text = "soporte.sincopyright@gmail.com"
        '
        'txtReceptor
        '
        Me.txtReceptor.Location = New System.Drawing.Point(219, 100)
        Me.txtReceptor.Name = "txtReceptor"
        Me.txtReceptor.Size = New System.Drawing.Size(162, 20)
        Me.txtReceptor.TabIndex = 1
        Me.txtReceptor.Text = "contacto@sincopyright.net"
        '
        'txtAsunto
        '
        Me.txtAsunto.Location = New System.Drawing.Point(219, 148)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(162, 20)
        Me.txtAsunto.TabIndex = 2
        Me.txtAsunto.Text = "Error en el Programa"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(577, 51)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(135, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Text = "Sincopyright.2020"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'rtbMensaje
        '
        Me.rtbMensaje.Location = New System.Drawing.Point(127, 234)
        Me.rtbMensaje.Name = "rtbMensaje"
        Me.rtbMensaje.Size = New System.Drawing.Size(619, 233)
        Me.rtbMensaje.TabIndex = 4
        Me.rtbMensaje.Text = ""
        '
        'btnenviarcorreo
        '
        Me.btnenviarcorreo.Location = New System.Drawing.Point(186, 509)
        Me.btnenviarcorreo.Name = "btnenviarcorreo"
        Me.btnenviarcorreo.Size = New System.Drawing.Size(75, 23)
        Me.btnenviarcorreo.TabIndex = 5
        Me.btnenviarcorreo.Text = "Enviar"
        Me.btnenviarcorreo.UseVisualStyleBackColor = True
        '
        'btncerrarcorreo
        '
        Me.btncerrarcorreo.Location = New System.Drawing.Point(574, 509)
        Me.btncerrarcorreo.Name = "btncerrarcorreo"
        Me.btncerrarcorreo.Size = New System.Drawing.Size(75, 23)
        Me.btncerrarcorreo.TabIndex = 6
        Me.btncerrarcorreo.Text = "Cerrar"
        Me.btncerrarcorreo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "PARA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ASUNTO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(461, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CONTRASEÑA:"
        '
        'Enviar_Correo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 609)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncerrarcorreo)
        Me.Controls.Add(Me.btnenviarcorreo)
        Me.Controls.Add(Me.rtbMensaje)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.txtReceptor)
        Me.Controls.Add(Me.txtEmisor)
        Me.Name = "Enviar_Correo"
        Me.Text = "Enviar_Correo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmisor As System.Windows.Forms.TextBox
    Friend WithEvents txtReceptor As System.Windows.Forms.TextBox
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents rtbMensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents btnenviarcorreo As System.Windows.Forms.Button
    Friend WithEvents btncerrarcorreo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
