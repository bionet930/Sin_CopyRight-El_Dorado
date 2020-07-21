<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formlogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.panelsuplogin = New System.Windows.Forms.Panel()
        Me.panelizqlogin = New System.Windows.Forms.Panel()
        Me.btnrestaura = New System.Windows.Forms.Button()
        Me.btnminm = New System.Windows.Forms.Button()
        Me.btnmaxim = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.panelsuplogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(225, 94)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(135, 20)
        Me.txtnombre.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(225, 163)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(135, 20)
        Me.txtpass.TabIndex = 3
        Me.txtpass.UseSystemPasswordChar = True
        '
        'btningresar
        '
        Me.btningresar.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresar.Location = New System.Drawing.Point(225, 238)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(135, 38)
        Me.btningresar.TabIndex = 4
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'panelsuplogin
        '
        Me.panelsuplogin.BackColor = System.Drawing.Color.Gold
        Me.panelsuplogin.Controls.Add(Me.btnrestaura)
        Me.panelsuplogin.Controls.Add(Me.btnminm)
        Me.panelsuplogin.Controls.Add(Me.btnmaxim)
        Me.panelsuplogin.Controls.Add(Me.btncerrar)
        Me.panelsuplogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelsuplogin.Location = New System.Drawing.Point(0, 0)
        Me.panelsuplogin.Name = "panelsuplogin"
        Me.panelsuplogin.Size = New System.Drawing.Size(507, 40)
        Me.panelsuplogin.TabIndex = 5
        '
        'panelizqlogin
        '
        Me.panelizqlogin.BackColor = System.Drawing.Color.MidnightBlue
        Me.panelizqlogin.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelizqlogin.Location = New System.Drawing.Point(0, 40)
        Me.panelizqlogin.Name = "panelizqlogin"
        Me.panelizqlogin.Size = New System.Drawing.Size(60, 310)
        Me.panelizqlogin.TabIndex = 6
        '
        'btnrestaura
        '
        Me.btnrestaura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnrestaura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrestaura.FlatAppearance.BorderSize = 0
        Me.btnrestaura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnrestaura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnrestaura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrestaura.Image = Global.Login_El_Dorado.My.Resources.Resources.Icono_Restaurar
        Me.btnrestaura.Location = New System.Drawing.Point(427, 0)
        Me.btnrestaura.Name = "btnrestaura"
        Me.btnrestaura.Size = New System.Drawing.Size(40, 40)
        Me.btnrestaura.TabIndex = 3
        Me.btnrestaura.UseVisualStyleBackColor = True
        Me.btnrestaura.Visible = False
        '
        'btnminm
        '
        Me.btnminm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnminm.FlatAppearance.BorderSize = 0
        Me.btnminm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnminm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnminm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminm.Image = Global.Login_El_Dorado.My.Resources.Resources.Icono_Minimizar
        Me.btnminm.Location = New System.Drawing.Point(387, 0)
        Me.btnminm.Name = "btnminm"
        Me.btnminm.Size = New System.Drawing.Size(40, 40)
        Me.btnminm.TabIndex = 2
        Me.btnminm.UseVisualStyleBackColor = True
        '
        'btnmaxim
        '
        Me.btnmaxim.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmaxim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmaxim.FlatAppearance.BorderSize = 0
        Me.btnmaxim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnmaxim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnmaxim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmaxim.Image = Global.Login_El_Dorado.My.Resources.Resources.Icono_Maximizar
        Me.btnmaxim.Location = New System.Drawing.Point(427, 0)
        Me.btnmaxim.Name = "btnmaxim"
        Me.btnmaxim.Size = New System.Drawing.Size(40, 40)
        Me.btnmaxim.TabIndex = 1
        Me.btnmaxim.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = Global.Login_El_Dorado.My.Resources.Resources.Icono_cerrar_FN
        Me.btncerrar.Location = New System.Drawing.Point(467, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(40, 40)
        Me.btncerrar.TabIndex = 0
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'formlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 350)
        Me.Controls.Add(Me.panelizqlogin)
        Me.Controls.Add(Me.panelsuplogin)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formlogin"
        Me.Text = "Lgoin Usuario"
        Me.panelsuplogin.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btningresar As System.Windows.Forms.Button
    Friend WithEvents panelsuplogin As System.Windows.Forms.Panel
    Friend WithEvents panelizqlogin As System.Windows.Forms.Panel
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents btnmaxim As System.Windows.Forms.Button
    Friend WithEvents btnminm As System.Windows.Forms.Button
    Friend WithEvents btnrestaura As System.Windows.Forms.Button

End Class
