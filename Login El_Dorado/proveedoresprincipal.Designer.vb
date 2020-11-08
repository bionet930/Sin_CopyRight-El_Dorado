<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedoresprincipal
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtdirprov = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrutprov = New System.Windows.Forms.TextBox()
        Me.txtempresaprov = New System.Windows.Forms.TextBox()
        Me.txttelprov = New System.Windows.Forms.TextBox()
        Me.txtnombreprov = New System.Windows.Forms.TextBox()
        Me.txtidprov = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.dtgProveedores = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(386, 26)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(127, 27)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "&Ingresar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(386, 59)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 27)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Modificar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(386, 92)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 29)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "&Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdirprov)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtrutprov)
        Me.GroupBox2.Controls.Add(Me.txtempresaprov)
        Me.GroupBox2.Controls.Add(Me.txttelprov)
        Me.GroupBox2.Controls.Add(Me.txtnombreprov)
        Me.GroupBox2.Controls.Add(Me.txtidprov)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button11)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(48, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 336)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Proveedor"
        '
        'txtdirprov
        '
        Me.txtdirprov.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdirprov.Location = New System.Drawing.Point(150, 240)
        Me.txtdirprov.Name = "txtdirprov"
        Me.txtdirprov.Size = New System.Drawing.Size(148, 23)
        Me.txtdirprov.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Direccion Empresa "
        '
        'txtrutprov
        '
        Me.txtrutprov.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrutprov.Location = New System.Drawing.Point(150, 195)
        Me.txtrutprov.Name = "txtrutprov"
        Me.txtrutprov.Size = New System.Drawing.Size(148, 23)
        Me.txtrutprov.TabIndex = 21
        '
        'txtempresaprov
        '
        Me.txtempresaprov.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempresaprov.Location = New System.Drawing.Point(150, 156)
        Me.txtempresaprov.Name = "txtempresaprov"
        Me.txtempresaprov.Size = New System.Drawing.Size(138, 23)
        Me.txtempresaprov.TabIndex = 20
        '
        'txttelprov
        '
        Me.txttelprov.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelprov.Location = New System.Drawing.Point(150, 124)
        Me.txttelprov.Name = "txttelprov"
        Me.txttelprov.Size = New System.Drawing.Size(66, 23)
        Me.txttelprov.TabIndex = 19
        '
        'txtnombreprov
        '
        Me.txtnombreprov.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreprov.Location = New System.Drawing.Point(150, 90)
        Me.txtnombreprov.Name = "txtnombreprov"
        Me.txtnombreprov.Size = New System.Drawing.Size(141, 23)
        Me.txtnombreprov.TabIndex = 18
        '
        'txtidprov
        '
        Me.txtidprov.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidprov.Location = New System.Drawing.Point(150, 45)
        Me.txtidprov.Name = "txtidprov"
        Me.txtidprov.Size = New System.Drawing.Size(141, 23)
        Me.txtidprov.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "RUT Empresa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Empresa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre y Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID-Proveedor"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(79, 300)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(55, 23)
        Me.Button11.TabIndex = 11
        Me.Button11.Text = "<"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(201, 300)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(55, 23)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = ">>"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(140, 300)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(55, 23)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = ">"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'dtgProveedores
        '
        Me.dtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProveedores.Location = New System.Drawing.Point(373, 176)
        Me.dtgProveedores.Name = "dtgProveedores"
        Me.dtgProveedores.Size = New System.Drawing.Size(438, 150)
        Me.dtgProveedores.TabIndex = 20
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(386, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 29)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'proveedoresprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(883, 447)
        Me.Controls.Add(Me.dtgProveedores)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "proveedoresprincipal"
        Me.Text = "                                 "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtrutprov As System.Windows.Forms.TextBox
    Friend WithEvents txtempresaprov As System.Windows.Forms.TextBox
    Friend WithEvents txttelprov As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreprov As System.Windows.Forms.TextBox
    Friend WithEvents txtidprov As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents txtdirprov As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtgProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
