<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verificar_Venta
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
        Me.dgvverfactura = New System.Windows.Forms.DataGridView()
        Me.btnverventa = New System.Windows.Forms.Button()
        Me.btnimprimirfactura = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgvverfactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvverfactura
        '
        Me.dgvverfactura.AllowUserToAddRows = False
        Me.dgvverfactura.AllowUserToDeleteRows = False
        Me.dgvverfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvverfactura.Location = New System.Drawing.Point(102, 141)
        Me.dgvverfactura.Name = "dgvverfactura"
        Me.dgvverfactura.ReadOnly = True
        Me.dgvverfactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvverfactura.Size = New System.Drawing.Size(665, 209)
        Me.dgvverfactura.TabIndex = 0
        '
        'btnverventa
        '
        Me.btnverventa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnverventa.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnverventa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnverventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnverventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnverventa.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnverventa.Location = New System.Drawing.Point(112, 73)
        Me.btnverventa.Name = "btnverventa"
        Me.btnverventa.Size = New System.Drawing.Size(126, 62)
        Me.btnverventa.TabIndex = 1
        Me.btnverventa.Text = "Ver Venta"
        Me.btnverventa.UseVisualStyleBackColor = True
        '
        'btnimprimirfactura
        '
        Me.btnimprimirfactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnimprimirfactura.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnimprimirfactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnimprimirfactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnimprimirfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimirfactura.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimirfactura.Location = New System.Drawing.Point(564, 73)
        Me.btnimprimirfactura.Name = "btnimprimirfactura"
        Me.btnimprimirfactura.Size = New System.Drawing.Size(130, 62)
        Me.btnimprimirfactura.TabIndex = 2
        Me.btnimprimirfactura.Text = "Imprimir"
        Me.btnimprimirfactura.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 49)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(58, 571)
        Me.Panel2.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(301, 382)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 199)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "qr.png"
        Me.SaveFileDialog1.Filter = "PNG Image |*.png"
        '
        'Verificar_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(824, 620)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnimprimirfactura)
        Me.Controls.Add(Me.btnverventa)
        Me.Controls.Add(Me.dgvverfactura)
        Me.Name = "Verificar_Venta"
        Me.Text = "Verificar_Venta"
        CType(Me.dgvverfactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvverfactura As System.Windows.Forms.DataGridView
    Friend WithEvents btnverventa As System.Windows.Forms.Button
    Friend WithEvents btnimprimirfactura As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
