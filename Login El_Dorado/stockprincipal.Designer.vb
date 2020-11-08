<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockprincipal
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
        Me.btnstock = New System.Windows.Forms.Button()
        Me.dgvDatostock = New System.Windows.Forms.DataGridView()
        Me.btnstockprincipal = New System.Windows.Forms.Button()
        Me.txtImagen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.avatar = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.ofdStock = New System.Windows.Forms.OpenFileDialog()
        Me.cmdProveedores = New System.Windows.Forms.ComboBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.txtPrecioCosto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdmercaderia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvDatostock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnstock
        '
        Me.btnstock.Location = New System.Drawing.Point(263, 13)
        Me.btnstock.Name = "btnstock"
        Me.btnstock.Size = New System.Drawing.Size(174, 54)
        Me.btnstock.TabIndex = 0
        Me.btnstock.Text = "Ver Stock"
        Me.btnstock.UseVisualStyleBackColor = True
        '
        'dgvDatostock
        '
        Me.dgvDatostock.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatostock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatostock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatostock.Location = New System.Drawing.Point(68, 420)
        Me.dgvDatostock.Name = "dgvDatostock"
        Me.dgvDatostock.Size = New System.Drawing.Size(793, 111)
        Me.dgvDatostock.TabIndex = 1
        '
        'btnstockprincipal
        '
        Me.btnstockprincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstockprincipal.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnstockprincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnstockprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnstockprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstockprincipal.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstockprincipal.Location = New System.Drawing.Point(130, 293)
        Me.btnstockprincipal.Name = "btnstockprincipal"
        Me.btnstockprincipal.Size = New System.Drawing.Size(107, 28)
        Me.btnstockprincipal.TabIndex = 3
        Me.btnstockprincipal.Text = "Ver Stock"
        Me.btnstockprincipal.UseVisualStyleBackColor = True
        '
        'txtImagen
        '
        Me.txtImagen.Location = New System.Drawing.Point(680, 59)
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.Size = New System.Drawing.Size(117, 20)
        Me.txtImagen.TabIndex = 10
        Me.txtImagen.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(596, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Imagen"
        Me.Label3.Visible = False
        '
        'btnIngresar
        '
        Me.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(341, 247)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(161, 27)
        Me.btnIngresar.TabIndex = 10
        Me.btnIngresar.Text = "&Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(341, 280)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(161, 33)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(341, 208)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(161, 33)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(341, 319)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(161, 30)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.avatar)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.btnImagen)
        Me.GroupBox3.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(317, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(204, 194)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones Foto"
        '
        'avatar
        '
        Me.avatar.Location = New System.Drawing.Point(36, 19)
        Me.avatar.Name = "avatar"
        Me.avatar.Size = New System.Drawing.Size(119, 111)
        Me.avatar.TabIndex = 12
        Me.avatar.TabStop = False
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(109, 146)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(89, 36)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Eliminar Imagen"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btnImagen
        '
        Me.btnImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImagen.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImagen.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagen.Location = New System.Drawing.Point(5, 146)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(97, 36)
        Me.btnImagen.TabIndex = 7
        Me.btnImagen.Text = "Seleccionar Imagen"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'ofdStock
        '
        Me.ofdStock.FileName = "OpenFileDialog1"
        '
        'cmdProveedores
        '
        Me.cmdProveedores.FormattingEnabled = True
        Me.cmdProveedores.Location = New System.Drawing.Point(149, 151)
        Me.cmdProveedores.Name = "cmdProveedores"
        Me.cmdProveedores.Size = New System.Drawing.Size(121, 21)
        Me.cmdProveedores.TabIndex = 30
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(149, 206)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(117, 20)
        Me.txtDescuento.TabIndex = 29
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(149, 180)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(117, 20)
        Me.txtStock.TabIndex = 28
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(149, 125)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(117, 20)
        Me.txtPrecioVenta.TabIndex = 27
        '
        'txtPrecioCosto
        '
        Me.txtPrecioCosto.Location = New System.Drawing.Point(149, 96)
        Me.txtPrecioCosto.Name = "txtPrecioCosto"
        Me.txtPrecioCosto.Size = New System.Drawing.Size(117, 20)
        Me.txtPrecioCosto.TabIndex = 26
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(149, 63)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(117, 20)
        Me.txtNombre.TabIndex = 25
        '
        'txtIdmercaderia
        '
        Me.txtIdmercaderia.Location = New System.Drawing.Point(149, 35)
        Me.txtIdmercaderia.Name = "txtIdmercaderia"
        Me.txtIdmercaderia.Size = New System.Drawing.Size(117, 20)
        Me.txtIdmercaderia.TabIndex = 24
        Me.txtIdmercaderia.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(74, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 12)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(103, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 12)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 12)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Id Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 12)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Precio Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 12)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Precio Costo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 12)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Id Mercaderia"
        '
        'stockprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(887, 557)
        Me.Controls.Add(Me.cmdProveedores)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.txtPrecioCosto)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdmercaderia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtImagen)
        Me.Controls.Add(Me.btnstockprincipal)
        Me.Controls.Add(Me.dgvDatostock)
        Me.Controls.Add(Me.Label3)
        Me.Name = "stockprincipal"
        Me.Text = " "
        CType(Me.dgvDatostock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnstock As System.Windows.Forms.Button
    Friend WithEvents dgvDatostock As System.Windows.Forms.DataGridView
    Friend WithEvents btnstockprincipal As System.Windows.Forms.Button
    Friend WithEvents txtImagen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents avatar As System.Windows.Forms.PictureBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnImagen As System.Windows.Forms.Button
    Friend WithEvents ofdStock As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIdmercaderia As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
