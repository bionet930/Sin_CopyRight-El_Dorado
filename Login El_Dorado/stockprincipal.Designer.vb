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
        Me.datosstock = New System.Windows.Forms.DataGridView()
        Me.panelsupstock = New System.Windows.Forms.Panel()
        Me.panelizqstock = New System.Windows.Forms.Panel()
        Me.btnstockprincipal = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.txtPrecioCosto = New System.Windows.Forms.TextBox()
        Me.txtImagen = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdmercaderia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.avatar = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.ofdStock = New System.Windows.Forms.OpenFileDialog()
        CType(Me.datosstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        'datosstock
        '
        Me.datosstock.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datosstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datosstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datosstock.Location = New System.Drawing.Point(68, 424)
        Me.datosstock.Name = "datosstock"
        Me.datosstock.Size = New System.Drawing.Size(758, 63)
        Me.datosstock.TabIndex = 1
        '
        'panelsupstock
        '
        Me.panelsupstock.BackColor = System.Drawing.Color.Gold
        Me.panelsupstock.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelsupstock.Location = New System.Drawing.Point(0, 0)
        Me.panelsupstock.Name = "panelsupstock"
        Me.panelsupstock.Size = New System.Drawing.Size(852, 40)
        Me.panelsupstock.TabIndex = 2
        '
        'panelizqstock
        '
        Me.panelizqstock.BackColor = System.Drawing.Color.MidnightBlue
        Me.panelizqstock.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelizqstock.Location = New System.Drawing.Point(0, 40)
        Me.panelizqstock.Name = "panelizqstock"
        Me.panelizqstock.Size = New System.Drawing.Size(37, 447)
        Me.panelizqstock.TabIndex = 3
        '
        'btnstockprincipal
        '
        Me.btnstockprincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstockprincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnstockprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnstockprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstockprincipal.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstockprincipal.Location = New System.Drawing.Point(131, 372)
        Me.btnstockprincipal.Name = "btnstockprincipal"
        Me.btnstockprincipal.Size = New System.Drawing.Size(107, 34)
        Me.btnstockprincipal.TabIndex = 3
        Me.btnstockprincipal.Text = "Ver Stock"
        Me.btnstockprincipal.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.txtStock)
        Me.GroupBox2.Controls.Add(Me.txtIdProveedor)
        Me.GroupBox2.Controls.Add(Me.txtPrecioVenta)
        Me.GroupBox2.Controls.Add(Me.txtPrecioCosto)
        Me.GroupBox2.Controls.Add(Me.txtImagen)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtIdmercaderia)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(68, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(243, 248)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(95, 208)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(117, 20)
        Me.txtDescuento.TabIndex = 15
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(95, 182)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(117, 20)
        Me.txtStock.TabIndex = 14
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Location = New System.Drawing.Point(95, 158)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Size = New System.Drawing.Size(117, 20)
        Me.txtIdProveedor.TabIndex = 13
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(95, 132)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(117, 20)
        Me.txtPrecioVenta.TabIndex = 12
        '
        'txtPrecioCosto
        '
        Me.txtPrecioCosto.Location = New System.Drawing.Point(95, 103)
        Me.txtPrecioCosto.Name = "txtPrecioCosto"
        Me.txtPrecioCosto.Size = New System.Drawing.Size(117, 20)
        Me.txtPrecioCosto.TabIndex = 11
        '
        'txtImagen
        '
        Me.txtImagen.Location = New System.Drawing.Point(95, 78)
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.Size = New System.Drawing.Size(117, 20)
        Me.txtImagen.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(95, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(117, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtIdmercaderia
        '
        Me.txtIdmercaderia.Location = New System.Drawing.Point(95, 17)
        Me.txtIdmercaderia.Name = "txtIdmercaderia"
        Me.txtIdmercaderia.Size = New System.Drawing.Size(117, 20)
        Me.txtIdmercaderia.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Id Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio Costo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Imagen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Mercaderia"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnCerrar)
        Me.GroupBox1.Location = New System.Drawing.Point(317, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 150)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(24, 54)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(161, 23)
        Me.btnIngresar.TabIndex = 10
        Me.btnIngresar.Text = "&Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(24, 83)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(161, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(24, 21)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(161, 23)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(24, 112)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(161, 23)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.avatar)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.btnImagen)
        Me.GroupBox3.Location = New System.Drawing.Point(317, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(193, 194)
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
        Me.Button8.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(96, 146)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(89, 36)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Eliminar Imagen"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btnImagen
        '
        Me.btnImagen.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagen.Location = New System.Drawing.Point(5, 146)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(89, 36)
        Me.btnImagen.TabIndex = 7
        Me.btnImagen.Text = "Seleccionar Imagen"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'ofdStock
        '
        Me.ofdStock.FileName = "OpenFileDialog1"
        '
        'stockprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 487)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnstockprincipal)
        Me.Controls.Add(Me.panelizqstock)
        Me.Controls.Add(Me.panelsupstock)
        Me.Controls.Add(Me.datosstock)
        Me.Name = "stockprincipal"
        Me.Text = "stockprincipal"
        CType(Me.datosstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnstock As System.Windows.Forms.Button
    Friend WithEvents datosstock As System.Windows.Forms.DataGridView
    Friend WithEvents panelsupstock As System.Windows.Forms.Panel
    Friend WithEvents panelizqstock As System.Windows.Forms.Panel
    Friend WithEvents btnstockprincipal As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtIdProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtImagen As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIdmercaderia As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents avatar As System.Windows.Forms.PictureBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnImagen As System.Windows.Forms.Button
    Friend WithEvents ofdStock As System.Windows.Forms.OpenFileDialog
End Class
