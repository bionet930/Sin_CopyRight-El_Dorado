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
        Me.btnstockprincipal = New System.Windows.Forms.Button()
        Me.datosstock = New System.Windows.Forms.DataGridView()
        Me.panelsupstock = New System.Windows.Forms.Panel()
        Me.panelizqstock = New System.Windows.Forms.Panel()
        CType(Me.datosstock, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnstockprincipal
        '
        Me.btnstockprincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstockprincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnstockprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnstockprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstockprincipal.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstockprincipal.Location = New System.Drawing.Point(145, 52)
        Me.btnstockprincipal.Name = "btnstockprincipal"
        Me.btnstockprincipal.Size = New System.Drawing.Size(212, 34)
        Me.btnstockprincipal.TabIndex = 0
        Me.btnstockprincipal.Text = "Ver Stock"
        Me.btnstockprincipal.UseVisualStyleBackColor = True
        '
        'datosstock
        '
        Me.datosstock.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datosstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datosstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datosstock.Location = New System.Drawing.Point(43, 92)
        Me.datosstock.Name = "datosstock"
        Me.datosstock.Size = New System.Drawing.Size(416, 150)
        Me.datosstock.TabIndex = 1
        '
        'panelsupstock
        '
        Me.panelsupstock.BackColor = System.Drawing.Color.Gold
        Me.panelsupstock.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelsupstock.Location = New System.Drawing.Point(0, 0)
        Me.panelsupstock.Name = "panelsupstock"
        Me.panelsupstock.Size = New System.Drawing.Size(510, 40)
        Me.panelsupstock.TabIndex = 2
        '
        'panelizqstock
        '
        Me.panelizqstock.BackColor = System.Drawing.Color.MidnightBlue
        Me.panelizqstock.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelizqstock.Location = New System.Drawing.Point(0, 40)
        Me.panelizqstock.Name = "panelizqstock"
        Me.panelizqstock.Size = New System.Drawing.Size(37, 256)
        Me.panelizqstock.TabIndex = 3
        '
        'stockprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 296)
        Me.Controls.Add(Me.panelizqstock)
        Me.Controls.Add(Me.panelsupstock)
        Me.Controls.Add(Me.datosstock)
        Me.Controls.Add(Me.btnstockprincipal)
        Me.Name = "stockprincipal"
        Me.Text = "stockprincipal"
        CType(Me.datosstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnstock As System.Windows.Forms.Button
    Friend WithEvents btnstockprincipal As System.Windows.Forms.Button
    Friend WithEvents datosstock As System.Windows.Forms.DataGridView
    Friend WithEvents panelsupstock As System.Windows.Forms.Panel
    Friend WithEvents panelizqstock As System.Windows.Forms.Panel
End Class
