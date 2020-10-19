<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientesprincipal
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.avatar = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSado = New System.Windows.Forms.TextBox()
        Me.txtImagen = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.ofdClientes = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnIngresar)
        Me.GroupBox4.Controls.Add(Me.btnEliminar)
        Me.GroupBox4.Controls.Add(Me.btnNuevo)
        Me.GroupBox4.Controls.Add(Me.btnCerrar)
        Me.GroupBox4.Location = New System.Drawing.Point(340, 241)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 158)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Botones"
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(17, 31)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(161, 23)
        Me.btnIngresar.TabIndex = 6
        Me.btnIngresar.Text = "&Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(17, 60)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(161, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(17, 94)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(161, 23)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "&Actualizar"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(17, 123)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(161, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.avatar)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.btnImagen)
        Me.GroupBox3.Location = New System.Drawing.Point(340, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 208)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones Foto"
        '
        'avatar
        '
        Me.avatar.Location = New System.Drawing.Point(50, 25)
        Me.avatar.Name = "avatar"
        Me.avatar.Size = New System.Drawing.Size(112, 135)
        Me.avatar.TabIndex = 12
        Me.avatar.TabStop = False
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(113, 166)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(89, 36)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Eliminar Imagen"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btnImagen
        '
        Me.btnImagen.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagen.Location = New System.Drawing.Point(6, 166)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(89, 36)
        Me.btnImagen.TabIndex = 7
        Me.btnImagen.Text = "Seleccionar Imagen"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSado)
        Me.GroupBox2.Controls.Add(Me.txtImagen)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtPago)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtId)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 359)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Clientes"
        '
        'txtSado
        '
        Me.txtSado.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSado.Location = New System.Drawing.Point(139, 166)
        Me.txtSado.Name = "txtSado"
        Me.txtSado.Size = New System.Drawing.Size(76, 22)
        Me.txtSado.TabIndex = 31
        '
        'txtImagen
        '
        Me.txtImagen.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagen.Location = New System.Drawing.Point(140, 240)
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.Size = New System.Drawing.Size(148, 22)
        Me.txtImagen.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 14)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "variable imagen"
        '
        'txtPago
        '
        Me.txtPago.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.Location = New System.Drawing.Point(139, 205)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(148, 22)
        Me.txtPago.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(54, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 14)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 14)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Saldo"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(140, 101)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(148, 22)
        Me.txtDireccion.TabIndex = 21
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(139, 129)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(138, 22)
        Me.txtTelefono.TabIndex = 20
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(140, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(141, 22)
        Me.txtNombre.TabIndex = 18
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(140, 45)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(141, 22)
        Me.txtId.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 14)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 14)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 14)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre y Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 14)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID-Clientes"
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(95, 419)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(528, 150)
        Me.dgvClientes.TabIndex = 19
        '
        'ofdClientes
        '
        Me.ofdClientes.FileName = "OpenFileDialog1"
        '
        'clientesprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 474)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "clientesprincipal"
        Me.Text = "clientesprincipal"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents avatar As System.Windows.Forms.PictureBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnImagen As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSado As System.Windows.Forms.TextBox
    Friend WithEvents txtImagen As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPago As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents ofdClientes As System.Windows.Forms.OpenFileDialog
End Class
