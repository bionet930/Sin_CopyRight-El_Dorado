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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblmenuempleados
        '
        Me.lblmenuempleados.AutoSize = True
        Me.lblmenuempleados.Location = New System.Drawing.Point(234, 9)
        Me.lblmenuempleados.Name = "lblmenuempleados"
        Me.lblmenuempleados.Size = New System.Drawing.Size(89, 13)
        Me.lblmenuempleados.TabIndex = 0
        Me.lblmenuempleados.Text = "Menu Empleados"
        '
        'btnregistroempl
        '
        Me.btnregistroempl.Location = New System.Drawing.Point(71, 41)
        Me.btnregistroempl.Name = "btnregistroempl"
        Me.btnregistroempl.Size = New System.Drawing.Size(75, 51)
        Me.btnregistroempl.TabIndex = 1
        Me.btnregistroempl.Text = "Registro de Empleados"
        Me.btnregistroempl.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.lblmenuempleados)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 35)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(53, 226)
        Me.Panel2.TabIndex = 3
        '
        'empleadosprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 261)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnregistroempl)
        Me.Name = "empleadosprincipal"
        Me.Text = "empleadosprincipal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblmenuempleados As System.Windows.Forms.Label
    Friend WithEvents btnregistroempl As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
