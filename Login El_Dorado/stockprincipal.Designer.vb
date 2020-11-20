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
        Me.btnModificar = New System.Windows.Forms.Button()
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
        Me.btnActualizarStock = New System.Windows.Forms.Button()
        Me.btnIngresarProducto = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.lblnombreprov = New System.Windows.Forms.Label()
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
        Me.dgvDatostock.Location = New System.Drawing.Point(19, 339)
        Me.dgvDatostock.Name = "dgvDatostock"
        Me.dgvDatostock.Size = New System.Drawing.Size(831, 111)
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
        Me.btnstockprincipal.Location = New System.Drawing.Point(357, 208)
        Me.btnstockprincipal.Name = "btnstockprincipal"
        Me.btnstockprincipal.Size = New System.Drawing.Size(161, 30)
        Me.btnstockprincipal.TabIndex = 3
        Me.btnstockprincipal.Text = "Actualizar Stock"
        Me.btnstockprincipal.UseVisualStyleBackColor = True
        '
        'txtImagen
        '
        Me.txtImagen.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagen.Location = New System.Drawing.Point(670, 57)
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.Size = New System.Drawing.Size(117, 20)
        Me.txtImagen.TabIndex = 10
        Me.txtImagen.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(586, 60)
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
        Me.btnIngresar.Location = New System.Drawing.Point(357, 17)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(161, 32)
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
        Me.btnEliminar.Location = New System.Drawing.Point(357, 121)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(161, 32)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(357, 87)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(161, 32)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(357, 155)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(161, 32)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.avatar)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.btnImagen)
        Me.GroupBox3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(604, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(202, 194)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones Foto"
        Me.GroupBox3.Visible = False
        '
        'avatar
        '
        Me.avatar.Location = New System.Drawing.Point(44, 19)
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
        Me.Button8.Location = New System.Drawing.Point(107, 146)
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
        Me.btnImagen.Size = New System.Drawing.Size(96, 36)
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
        Me.cmdProveedores.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProveedores.FormattingEnabled = True
        Me.cmdProveedores.Location = New System.Drawing.Point(150, 149)
        Me.cmdProveedores.Name = "cmdProveedores"
        Me.cmdProveedores.Size = New System.Drawing.Size(121, 20)
        Me.cmdProveedores.TabIndex = 30
        '
        'txtDescuento
        '
        Me.txtDescuento.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(150, 204)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(117, 20)
        Me.txtDescuento.TabIndex = 29
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(150, 178)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(117, 20)
        Me.txtStock.TabIndex = 28
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioVenta.Location = New System.Drawing.Point(150, 123)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(117, 20)
        Me.txtPrecioVenta.TabIndex = 27
        '
        'txtPrecioCosto
        '
        Me.txtPrecioCosto.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioCosto.Location = New System.Drawing.Point(150, 94)
        Me.txtPrecioCosto.Name = "txtPrecioCosto"
        Me.txtPrecioCosto.Size = New System.Drawing.Size(117, 20)
        Me.txtPrecioCosto.TabIndex = 26
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(150, 61)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(117, 20)
        Me.txtNombre.TabIndex = 25
        '
        'txtIdmercaderia
        '
        Me.txtIdmercaderia.Enabled = False
        Me.txtIdmercaderia.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdmercaderia.Location = New System.Drawing.Point(150, 33)
        Me.txtIdmercaderia.Name = "txtIdmercaderia"
        Me.txtIdmercaderia.Size = New System.Drawing.Size(117, 20)
        Me.txtIdmercaderia.TabIndex = 24
        Me.txtIdmercaderia.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 12)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 12)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 12)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Id Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 12)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Precio Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 12)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Precio Costo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 12)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Id Mercaderia"
        '
        'btnActualizarStock
        '
        Me.btnActualizarStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarStock.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnActualizarStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnActualizarStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnActualizarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarStock.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarStock.Location = New System.Drawing.Point(71, 252)
        Me.btnActualizarStock.Name = "btnActualizarStock"
        Me.btnActualizarStock.Size = New System.Drawing.Size(170, 29)
        Me.btnActualizarStock.TabIndex = 31
        Me.btnActualizarStock.Text = "Actualizar"
        Me.btnActualizarStock.UseVisualStyleBackColor = True
        Me.btnActualizarStock.Visible = False
        '
        'btnIngresarProducto
        '
        Me.btnIngresarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnIngresarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnIngresarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnIngresarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarProducto.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarProducto.Location = New System.Drawing.Point(258, 252)
        Me.btnIngresarProducto.Name = "btnIngresarProducto"
        Me.btnIngresarProducto.Size = New System.Drawing.Size(170, 29)
        Me.btnIngresarProducto.TabIndex = 32
        Me.btnIngresarProducto.Text = "&Ingresar"
        Me.btnIngresarProducto.UseVisualStyleBackColor = True
        Me.btnIngresarProducto.Visible = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.Location = New System.Drawing.Point(357, 52)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(161, 32)
        Me.btnnuevo.TabIndex = 33
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'lblnombreprov
        '
        Me.lblnombreprov.AutoSize = True
        Me.lblnombreprov.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreprov.Location = New System.Drawing.Point(278, 155)
        Me.lblnombreprov.Name = "lblnombreprov"
        Me.lblnombreprov.Size = New System.Drawing.Size(44, 12)
        Me.lblnombreprov.TabIndex = 34
        Me.lblnombreprov.Text = "Label9"
        '
        'stockprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1011, 560)
        Me.Controls.Add(Me.lblnombreprov)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnIngresarProducto)
        Me.Controls.Add(Me.btnActualizarStock)
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
        Me.Controls.Add(Me.btnModificar)
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
    Friend WithEvents btnModificar As System.Windows.Forms.Button
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
    Friend WithEvents btnActualizarStock As System.Windows.Forms.Button
    Friend WithEvents btnIngresarProducto As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents lblnombreprov As System.Windows.Forms.Label
End Class
