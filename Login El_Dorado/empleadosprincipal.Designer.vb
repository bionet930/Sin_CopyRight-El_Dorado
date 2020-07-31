<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleadosprincipal
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
        Me.lblmenuempleados = New System.Windows.Forms.Label()
        Me.btnregistroempl = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlpempl = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.pnlpempl.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblmenuempleados
        '
        Me.lblmenuempleados.AutoSize = True
        Me.lblmenuempleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblmenuempleados.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmenuempleados.Location = New System.Drawing.Point(238, 9)
        Me.lblmenuempleados.Name = "lblmenuempleados"
        Me.lblmenuempleados.Size = New System.Drawing.Size(133, 16)
        Me.lblmenuempleados.TabIndex = 0
        Me.lblmenuempleados.Text = "Menu Empleados"
        '
        'btnregistroempl
        '
        Me.btnregistroempl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregistroempl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnregistroempl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnregistroempl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregistroempl.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistroempl.Location = New System.Drawing.Point(12, 6)
        Me.btnregistroempl.Name = "btnregistroempl"
        Me.btnregistroempl.Size = New System.Drawing.Size(75, 51)
        Me.btnregistroempl.TabIndex = 1
        Me.btnregistroempl.Text = "Registro de Empleados"
        Me.btnregistroempl.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblmenuempleados)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 35)
        Me.Panel1.TabIndex = 2
        '
        'pnlpempl
        '
        Me.pnlpempl.Controls.Add(Me.btnregistroempl)
        Me.pnlpempl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlpempl.Location = New System.Drawing.Point(0, 35)
        Me.pnlpempl.Name = "pnlpempl"
        Me.pnlpempl.Size = New System.Drawing.Size(578, 226)
        Me.pnlpempl.TabIndex = 4
        '
        'empleadosprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 261)
        Me.Controls.Add(Me.pnlpempl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "empleadosprincipal"
        Me.Text = "empleadosprincipal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlpempl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblmenuempleados As System.Windows.Forms.Label
    Friend WithEvents btnregistroempl As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlpempl As System.Windows.Forms.Panel
End Class
