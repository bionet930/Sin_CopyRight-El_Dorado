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
        Me.rtbMensaje = New System.Windows.Forms.RichTextBox()
        Me.btnenviarcorreo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btncerrarcorreo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEmisor
        '
        Me.txtEmisor.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmisor.Location = New System.Drawing.Point(119, 45)
        Me.txtEmisor.Name = "txtEmisor"
        Me.txtEmisor.ReadOnly = True
        Me.txtEmisor.Size = New System.Drawing.Size(227, 20)
        Me.txtEmisor.TabIndex = 0
        Me.txtEmisor.Text = "soporte.sincopyright@gmail.com"
        '
        'txtReceptor
        '
        Me.txtReceptor.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceptor.Location = New System.Drawing.Point(117, 95)
        Me.txtReceptor.Name = "txtReceptor"
        Me.txtReceptor.ReadOnly = True
        Me.txtReceptor.Size = New System.Drawing.Size(227, 20)
        Me.txtReceptor.TabIndex = 1
        Me.txtReceptor.Text = "contacto@sincopyright.net"
        '
        'txtAsunto
        '
        Me.txtAsunto.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsunto.Location = New System.Drawing.Point(117, 147)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(227, 20)
        Me.txtAsunto.TabIndex = 2
        Me.txtAsunto.Text = "Error en el Programa"
        '
        'rtbMensaje
        '
        Me.rtbMensaje.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbMensaje.Location = New System.Drawing.Point(104, 222)
        Me.rtbMensaje.Name = "rtbMensaje"
        Me.rtbMensaje.Size = New System.Drawing.Size(628, 212)
        Me.rtbMensaje.TabIndex = 4
        Me.rtbMensaje.Text = ""
        '
        'btnenviarcorreo
        '
        Me.btnenviarcorreo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnenviarcorreo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnenviarcorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnenviarcorreo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnenviarcorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnenviarcorreo.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnenviarcorreo.Location = New System.Drawing.Point(119, 463)
        Me.btnenviarcorreo.Name = "btnenviarcorreo"
        Me.btnenviarcorreo.Size = New System.Drawing.Size(212, 44)
        Me.btnenviarcorreo.TabIndex = 5
        Me.btnenviarcorreo.Text = "Enviar"
        Me.btnenviarcorreo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "DE :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PARA :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ASUNTO :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(412, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "CONTRASEÑA :"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(550, 44)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(226, 20)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.Text = "Sincopyright.2020"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btncerrarcorreo
        '
        Me.btncerrarcorreo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrarcorreo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btncerrarcorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btncerrarcorreo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btncerrarcorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrarcorreo.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrarcorreo.Location = New System.Drawing.Point(506, 463)
        Me.btncerrarcorreo.Name = "btncerrarcorreo"
        Me.btncerrarcorreo.Size = New System.Drawing.Size(212, 44)
        Me.btncerrarcorreo.TabIndex = 11
        Me.btncerrarcorreo.Text = "Cerrar"
        Me.btncerrarcorreo.UseVisualStyleBackColor = True
        '
        'Enviar_Correo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(973, 579)
        Me.Controls.Add(Me.btncerrarcorreo)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnenviarcorreo)
        Me.Controls.Add(Me.rtbMensaje)
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
    Friend WithEvents rtbMensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents btnenviarcorreo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btncerrarcorreo As System.Windows.Forms.Button
End Class
