<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imprimir_Factura
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bntimprimir = New System.Windows.Forms.Button()
        Me.btnzoommas = New System.Windows.Forms.Button()
        Me.btnzoommenos = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(460, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bntimprimir
        '
        Me.bntimprimir.Location = New System.Drawing.Point(12, 2)
        Me.bntimprimir.Name = "bntimprimir"
        Me.bntimprimir.Size = New System.Drawing.Size(75, 23)
        Me.bntimprimir.TabIndex = 1
        Me.bntimprimir.Text = "Imprimir"
        Me.bntimprimir.UseVisualStyleBackColor = True
        '
        'btnzoommas
        '
        Me.btnzoommas.Location = New System.Drawing.Point(122, 2)
        Me.btnzoommas.Name = "btnzoommas"
        Me.btnzoommas.Size = New System.Drawing.Size(75, 23)
        Me.btnzoommas.TabIndex = 2
        Me.btnzoommas.Text = "Zoom   +"
        Me.btnzoommas.UseVisualStyleBackColor = True
        '
        'btnzoommenos
        '
        Me.btnzoommenos.Location = New System.Drawing.Point(234, 2)
        Me.btnzoommenos.Name = "btnzoommenos"
        Me.btnzoommenos.Size = New System.Drawing.Size(75, 23)
        Me.btnzoommenos.TabIndex = 3
        Me.btnzoommenos.Text = "Zoom   -"
        Me.btnzoommenos.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Document = Me.PrintDocument1
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(0, 25)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(460, 602)
        Me.PrintPreviewControl1.TabIndex = 4
        Me.PrintPreviewControl1.Zoom = 0.51924721984602229R
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Imprimir_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 627)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.btnzoommenos)
        Me.Controls.Add(Me.btnzoommas)
        Me.Controls.Add(Me.bntimprimir)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Imprimir_Factura"
        Me.Text = "Imprimir_Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bntimprimir As System.Windows.Forms.Button
    Friend WithEvents btnzoommas As System.Windows.Forms.Button
    Friend WithEvents btnzoommenos As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
