<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verificar_venta
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
        Me.dgvimprimir = New System.Windows.Forms.DataGridView()
        Me.btnimprimirfac = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Id_Mercaderia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadMerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioMerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvimprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvimprimir
        '
        Me.dgvimprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvimprimir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Mercaderia, Me.NombreMerc, Me.CantidadMerc, Me.PrecioMerc})
        Me.dgvimprimir.Location = New System.Drawing.Point(54, 86)
        Me.dgvimprimir.Name = "dgvimprimir"
        Me.dgvimprimir.Size = New System.Drawing.Size(725, 340)
        Me.dgvimprimir.TabIndex = 0
        '
        'btnimprimirfac
        '
        Me.btnimprimirfac.Location = New System.Drawing.Point(83, 28)
        Me.btnimprimirfac.Name = "btnimprimirfac"
        Me.btnimprimirfac.Size = New System.Drawing.Size(167, 52)
        Me.btnimprimirfac.TabIndex = 1
        Me.btnimprimirfac.Text = "Imprimir"
        Me.btnimprimirfac.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(576, 28)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(167, 52)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'Id_Mercaderia
        '
        Me.Id_Mercaderia.HeaderText = "ID"
        Me.Id_Mercaderia.Name = "Id_Mercaderia"
        '
        'NombreMerc
        '
        Me.NombreMerc.HeaderText = "Producto"
        Me.NombreMerc.Name = "NombreMerc"
        '
        'CantidadMerc
        '
        Me.CantidadMerc.HeaderText = "Cantidad"
        Me.CantidadMerc.Name = "CantidadMerc"
        '
        'PrecioMerc
        '
        Me.PrecioMerc.HeaderText = "Precio"
        Me.PrecioMerc.Name = "PrecioMerc"
        '
        'verificar_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 449)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnimprimirfac)
        Me.Controls.Add(Me.dgvimprimir)
        Me.Name = "verificar_venta"
        Me.Text = "verificar_venta"
        CType(Me.dgvimprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvimprimir As System.Windows.Forms.DataGridView
    Friend WithEvents btnimprimirfac As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents Id_Mercaderia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreMerc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadMerc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioMerc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
