<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroempl
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
        Me.pnlsupregempl = New System.Windows.Forms.Panel()
        Me.lblregempl = New System.Windows.Forms.Label()
        Me.pnlizqregempl = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.lblnombreempl = New System.Windows.Forms.Label()
        Me.lbledadempl = New System.Windows.Forms.Label()
        Me.lbltelempl = New System.Windows.Forms.Label()
        Me.lbldirempl = New System.Windows.Forms.Label()
        Me.lblimgempl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnpassempl = New System.Windows.Forms.Button()
        Me.btnguardardatos = New System.Windows.Forms.Button()
        Me.btnsalirempl = New System.Windows.Forms.Button()
        Me.pnlsupregempl.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlsupregempl
        '
        Me.pnlsupregempl.BackColor = System.Drawing.Color.Gold
        Me.pnlsupregempl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlsupregempl.Controls.Add(Me.lblregempl)
        Me.pnlsupregempl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlsupregempl.Location = New System.Drawing.Point(0, 0)
        Me.pnlsupregempl.Name = "pnlsupregempl"
        Me.pnlsupregempl.Size = New System.Drawing.Size(337, 44)
        Me.pnlsupregempl.TabIndex = 0
        '
        'lblregempl
        '
        Me.lblregempl.AutoSize = True
        Me.lblregempl.Location = New System.Drawing.Point(80, 9)
        Me.lblregempl.Name = "lblregempl"
        Me.lblregempl.Size = New System.Drawing.Size(131, 13)
        Me.lblregempl.TabIndex = 0
        Me.lblregempl.Text = "Registro Nuevo Empleado"
        '
        'pnlizqregempl
        '
        Me.pnlizqregempl.BackColor = System.Drawing.Color.DarkBlue
        Me.pnlizqregempl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlizqregempl.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlizqregempl.Location = New System.Drawing.Point(0, 44)
        Me.pnlizqregempl.Name = "pnlizqregempl"
        Me.pnlizqregempl.Size = New System.Drawing.Size(54, 417)
        Me.pnlizqregempl.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(143, 93)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(143, 142)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(143, 192)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(143, 241)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(143, 285)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 6
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(143, 331)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 7
        '
        'lblnombreempl
        '
        Me.lblnombreempl.AutoSize = True
        Me.lblnombreempl.Location = New System.Drawing.Point(83, 96)
        Me.lblnombreempl.Name = "lblnombreempl"
        Me.lblnombreempl.Size = New System.Drawing.Size(50, 13)
        Me.lblnombreempl.TabIndex = 8
        Me.lblnombreempl.Text = "Nombre :"
        '
        'lbledadempl
        '
        Me.lbledadempl.AutoSize = True
        Me.lbledadempl.Location = New System.Drawing.Point(83, 139)
        Me.lbledadempl.Name = "lbledadempl"
        Me.lbledadempl.Size = New System.Drawing.Size(38, 13)
        Me.lbledadempl.TabIndex = 9
        Me.lbledadempl.Text = "Edad :"
        '
        'lbltelempl
        '
        Me.lbltelempl.AutoSize = True
        Me.lbltelempl.Location = New System.Drawing.Point(80, 196)
        Me.lbltelempl.Name = "lbltelempl"
        Me.lbltelempl.Size = New System.Drawing.Size(55, 13)
        Me.lbltelempl.TabIndex = 10
        Me.lbltelempl.Text = "Telefono :"
        '
        'lbldirempl
        '
        Me.lbldirempl.AutoSize = True
        Me.lbldirempl.Location = New System.Drawing.Point(80, 245)
        Me.lbldirempl.Name = "lbldirempl"
        Me.lbldirempl.Size = New System.Drawing.Size(58, 13)
        Me.lbldirempl.TabIndex = 11
        Me.lbldirempl.Text = "Dirección :"
        '
        'lblimgempl
        '
        Me.lblimgempl.AutoSize = True
        Me.lblimgempl.Location = New System.Drawing.Point(80, 289)
        Me.lblimgempl.Name = "lblimgempl"
        Me.lblimgempl.Size = New System.Drawing.Size(34, 13)
        Me.lblimgempl.TabIndex = 12
        Me.lblimgempl.Text = "Foto :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(80, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vto C. Salud :"
        '
        'btnpassempl
        '
        Me.btnpassempl.Location = New System.Drawing.Point(83, 377)
        Me.btnpassempl.Name = "btnpassempl"
        Me.btnpassempl.Size = New System.Drawing.Size(105, 23)
        Me.btnpassempl.TabIndex = 13
        Me.btnpassempl.Text = "Asignar Password"
        Me.btnpassempl.UseVisualStyleBackColor = True
        '
        'btnguardardatos
        '
        Me.btnguardardatos.Location = New System.Drawing.Point(86, 417)
        Me.btnguardardatos.Name = "btnguardardatos"
        Me.btnguardardatos.Size = New System.Drawing.Size(75, 23)
        Me.btnguardardatos.TabIndex = 14
        Me.btnguardardatos.Text = "Guardar"
        Me.btnguardardatos.UseVisualStyleBackColor = True
        '
        'btnsalirempl
        '
        Me.btnsalirempl.Location = New System.Drawing.Point(236, 416)
        Me.btnsalirempl.Name = "btnsalirempl"
        Me.btnsalirempl.Size = New System.Drawing.Size(75, 23)
        Me.btnsalirempl.TabIndex = 15
        Me.btnsalirempl.Text = "Salir"
        Me.btnsalirempl.UseVisualStyleBackColor = True
        '
        'registroempl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 461)
        Me.Controls.Add(Me.btnsalirempl)
        Me.Controls.Add(Me.btnguardardatos)
        Me.Controls.Add(Me.btnpassempl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblimgempl)
        Me.Controls.Add(Me.lbldirempl)
        Me.Controls.Add(Me.lbltelempl)
        Me.Controls.Add(Me.lbledadempl)
        Me.Controls.Add(Me.lblnombreempl)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.pnlizqregempl)
        Me.Controls.Add(Me.pnlsupregempl)
        Me.Name = "registroempl"
        Me.Text = "registroempl"
        Me.pnlsupregempl.ResumeLayout(False)
        Me.pnlsupregempl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlsupregempl As System.Windows.Forms.Panel
    Friend WithEvents lblregempl As System.Windows.Forms.Label
    Friend WithEvents pnlizqregempl As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents lblnombreempl As System.Windows.Forms.Label
    Friend WithEvents lbledadempl As System.Windows.Forms.Label
    Friend WithEvents lbltelempl As System.Windows.Forms.Label
    Friend WithEvents lbldirempl As System.Windows.Forms.Label
    Friend WithEvents lblimgempl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnpassempl As System.Windows.Forms.Button
    Friend WithEvents btnguardardatos As System.Windows.Forms.Button
    Friend WithEvents btnsalirempl As System.Windows.Forms.Button
End Class
