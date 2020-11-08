<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventasprincipal
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnIngresarProducto = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnimprimirfac = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmbEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtIdmercaderia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.dgvFactura = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(563, 373)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 27)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnIngresarProducto
        '
        Me.btnIngresarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnIngresarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnIngresarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnIngresarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarProducto.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarProducto.Location = New System.Drawing.Point(563, 183)
        Me.btnIngresarProducto.Name = "btnIngresarProducto"
        Me.btnIngresarProducto.Size = New System.Drawing.Size(161, 29)
        Me.btnIngresarProducto.TabIndex = 29
        Me.btnIngresarProducto.Text = "Ingresar Producto"
        Me.btnIngresarProducto.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(563, 236)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(161, 27)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnimprimirfac
        '
        Me.btnimprimirfac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnimprimirfac.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnimprimirfac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnimprimirfac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnimprimirfac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimirfac.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimirfac.Location = New System.Drawing.Point(563, 342)
        Me.btnimprimirfac.Name = "btnimprimirfac"
        Me.btnimprimirfac.Size = New System.Drawing.Size(161, 25)
        Me.btnimprimirfac.TabIndex = 7
        Me.btnimprimirfac.Text = "Verificar Venta"
        Me.btnimprimirfac.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "yyyy/MM/dd"
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(179, 18)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(87, 20)
        Me.dtpFecha.TabIndex = 32
        '
        'cmbEmpleados
        '
        Me.cmbEmpleados.FormattingEnabled = True
        Me.cmbEmpleados.Location = New System.Drawing.Point(170, 44)
        Me.cmbEmpleados.Name = "cmbEmpleados"
        Me.cmbEmpleados.Size = New System.Drawing.Size(96, 21)
        Me.cmbEmpleados.TabIndex = 31
        Me.cmbEmpleados.Text = "Seleccione Empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "ID-Empleado"
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(167, 77)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(99, 21)
        Me.cmbClientes.TabIndex = 29
        Me.cmbClientes.Text = "Seleccione el cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "ID-Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 14)
        Me.Label1.TabIndex = 12
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(458, 122)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(53, 20)
        Me.nudCantidad.TabIndex = 28
        Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtIdmercaderia
        '
        Me.txtIdmercaderia.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdmercaderia.Location = New System.Drawing.Point(167, 120)
        Me.txtIdmercaderia.Name = "txtIdmercaderia"
        Me.txtIdmercaderia.Size = New System.Drawing.Size(99, 22)
        Me.txtIdmercaderia.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(372, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ID-Mercaderia"
        '
        'dgvVentas
        '
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(44, 173)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(487, 39)
        Me.dgvVentas.TabIndex = 21
        '
        'dgvFactura
        '
        Me.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFactura.Location = New System.Drawing.Point(45, 236)
        Me.dgvFactura.Name = "dgvFactura"
        Me.dgvFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFactura.Size = New System.Drawing.Size(486, 150)
        Me.dgvFactura.TabIndex = 30
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(372, 395)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(50, 18)
        Me.lblTotal.TabIndex = 31
        Me.lblTotal.Text = "Total"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(619, 82)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(44, 12)
        Me.lblPrecio.TabIndex = 32
        Me.lblPrecio.Text = "Label5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(537, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Precio"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(281, 123)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 12)
        Me.lblNombre.TabIndex = 34
        Me.lblNombre.Text = "Mercaderia"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(563, 308)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 28)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "finalizar venta"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(431, 392)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(610, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 12)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "precio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(520, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 12)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Precio Unitario"
        '
        'dgvStock
        '
        Me.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Location = New System.Drawing.Point(407, 5)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStock.Size = New System.Drawing.Size(104, 43)
        Me.dgvStock.TabIndex = 41
        '
        'ventasprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(790, 532)
        Me.Controls.Add(Me.dgvStock)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnIngresarProducto)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.cmbEmpleados)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnimprimirfac)
        Me.Controls.Add(Me.cmbClientes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dgvFactura)
        Me.Controls.Add(Me.nudCantidad)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdmercaderia)
        Me.Controls.Add(Me.Label4)
        Me.Name = "ventasprincipal"
        Me.Text = "ventasprincipal"
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnimprimirfac As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nudCantidad As System.Windows.Forms.NumericUpDown
    Public WithEvents dgvVentas As System.Windows.Forms.DataGridView
    Public WithEvents txtIdmercaderia As System.Windows.Forms.TextBox
    Friend WithEvents cmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents btnIngresarProducto As System.Windows.Forms.Button
    Friend WithEvents dgvFactura As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents cmbEmpleados As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvStock As System.Windows.Forms.DataGridView
End Class
