<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panelsupprincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.pnlsuperiorprinciapl = New System.Windows.Forms.Panel()
        Me.btnrestauraprincipal = New System.Windows.Forms.Button()
        Me.btnminimprincipal = New System.Windows.Forms.Button()
        Me.btnmaximprincipal = New System.Windows.Forms.Button()
        Me.btncerrarprincipal = New System.Windows.Forms.Button()
        Me.panelizqprincipal = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btncorreos = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnmantenimiento = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnproveedorprincipal = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnstockprincipal = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnclientesprincipal = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnempleadosprincipal = New System.Windows.Forms.Button()
        Me.pnldeco1principal = New System.Windows.Forms.Panel()
        Me.btnventasprincipal = New System.Windows.Forms.Button()
        Me.picboxlogo = New System.Windows.Forms.PictureBox()
        Me.btnmenuprincipal = New System.Windows.Forms.PictureBox()
        Me.tmocultarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmmostrarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.Stock = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.panelprincipal = New System.Windows.Forms.Panel()
        Me.pnlsuperiorprinciapl.SuspendLayout()
        Me.panelizqprincipal.SuspendLayout()
        CType(Me.picboxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmenuprincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelprincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlsuperiorprinciapl
        '
        Me.pnlsuperiorprinciapl.BackColor = System.Drawing.Color.Gold
        Me.pnlsuperiorprinciapl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlsuperiorprinciapl.Controls.Add(Me.btnrestauraprincipal)
        Me.pnlsuperiorprinciapl.Controls.Add(Me.btnminimprincipal)
        Me.pnlsuperiorprinciapl.Controls.Add(Me.btnmaximprincipal)
        Me.pnlsuperiorprinciapl.Controls.Add(Me.btncerrarprincipal)
        Me.pnlsuperiorprinciapl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlsuperiorprinciapl.Location = New System.Drawing.Point(0, 0)
        Me.pnlsuperiorprinciapl.Name = "pnlsuperiorprinciapl"
        Me.pnlsuperiorprinciapl.Size = New System.Drawing.Size(1514, 40)
        Me.pnlsuperiorprinciapl.TabIndex = 0
        '
        'btnrestauraprincipal
        '
        Me.btnrestauraprincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnrestauraprincipal.FlatAppearance.BorderSize = 0
        Me.btnrestauraprincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnrestauraprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnrestauraprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrestauraprincipal.Image = Global.Login_El_Dorado.My.Resources.Resources.Icono_Restaurar
        Me.btnrestauraprincipal.Location = New System.Drawing.Point(1432, 0)
        Me.btnrestauraprincipal.Name = "btnrestauraprincipal"
        Me.btnrestauraprincipal.Size = New System.Drawing.Size(40, 40)
        Me.btnrestauraprincipal.TabIndex = 3
        Me.btnrestauraprincipal.UseVisualStyleBackColor = True
        Me.btnrestauraprincipal.Visible = False
        '
        'btnminimprincipal
        '
        Me.btnminimprincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimprincipal.FlatAppearance.BorderSize = 0
        Me.btnminimprincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnminimprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnminimprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimprincipal.Image = Global.Login_El_Dorado.My.Resources.Resources.Icono_Minimizar
        Me.btnminimprincipal.Location = New System.Drawing.Point(1392, 0)
        Me.btnminimprincipal.Name = "btnminimprincipal"
        Me.btnminimprincipal.Size = New System.Drawing.Size(40, 40)
        Me.btnminimprincipal.TabIndex = 2
        Me.btnminimprincipal.UseVisualStyleBackColor = True
        '
        'btnmaximprincipal
        '
        Me.btnmaximprincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmaximprincipal.FlatAppearance.BorderSize = 0
        Me.btnmaximprincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnmaximprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnmaximprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmaximprincipal.Image = Global.Login_El_Dorado.My.Resources.Resources.Icono_Maximizar
        Me.btnmaximprincipal.Location = New System.Drawing.Point(1432, 0)
        Me.btnmaximprincipal.Name = "btnmaximprincipal"
        Me.btnmaximprincipal.Size = New System.Drawing.Size(40, 40)
        Me.btnmaximprincipal.TabIndex = 1
        Me.btnmaximprincipal.UseVisualStyleBackColor = True
        '
        'btncerrarprincipal
        '
        Me.btncerrarprincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrarprincipal.FlatAppearance.BorderSize = 0
        Me.btncerrarprincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btncerrarprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btncerrarprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrarprincipal.Image = Global.Login_El_Dorado.My.Resources.Resources.Icono_cerrar_FN
        Me.btncerrarprincipal.Location = New System.Drawing.Point(1472, 0)
        Me.btncerrarprincipal.Name = "btncerrarprincipal"
        Me.btncerrarprincipal.Size = New System.Drawing.Size(40, 40)
        Me.btncerrarprincipal.TabIndex = 0
        Me.btncerrarprincipal.UseVisualStyleBackColor = True
        '
        'panelizqprincipal
        '
        Me.panelizqprincipal.BackColor = System.Drawing.Color.MidnightBlue
        Me.panelizqprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelizqprincipal.Controls.Add(Me.Panel6)
        Me.panelizqprincipal.Controls.Add(Me.btncorreos)
        Me.panelizqprincipal.Controls.Add(Me.Panel5)
        Me.panelizqprincipal.Controls.Add(Me.btnmantenimiento)
        Me.panelizqprincipal.Controls.Add(Me.Panel4)
        Me.panelizqprincipal.Controls.Add(Me.btnproveedorprincipal)
        Me.panelizqprincipal.Controls.Add(Me.Panel3)
        Me.panelizqprincipal.Controls.Add(Me.btnstockprincipal)
        Me.panelizqprincipal.Controls.Add(Me.Panel2)
        Me.panelizqprincipal.Controls.Add(Me.btnclientesprincipal)
        Me.panelizqprincipal.Controls.Add(Me.Panel1)
        Me.panelizqprincipal.Controls.Add(Me.btnempleadosprincipal)
        Me.panelizqprincipal.Controls.Add(Me.pnldeco1principal)
        Me.panelizqprincipal.Controls.Add(Me.btnventasprincipal)
        Me.panelizqprincipal.Controls.Add(Me.picboxlogo)
        Me.panelizqprincipal.Controls.Add(Me.btnmenuprincipal)
        Me.panelizqprincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelizqprincipal.Location = New System.Drawing.Point(0, 40)
        Me.panelizqprincipal.Name = "panelizqprincipal"
        Me.panelizqprincipal.Size = New System.Drawing.Size(60, 728)
        Me.panelizqprincipal.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gold
        Me.Panel6.Location = New System.Drawing.Point(0, 592)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 9
        '
        'btncorreos
        '
        Me.btncorreos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncorreos.FlatAppearance.BorderSize = 0
        Me.btncorreos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btncorreos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btncorreos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncorreos.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncorreos.ForeColor = System.Drawing.Color.White
        Me.btncorreos.Image = Global.Login_El_Dorado.My.Resources.Resources.correo_27
        Me.btncorreos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncorreos.Location = New System.Drawing.Point(0, 592)
        Me.btncorreos.Name = "btncorreos"
        Me.btncorreos.Size = New System.Drawing.Size(220, 50)
        Me.btncorreos.TabIndex = 8
        Me.btncorreos.Text = "    Correo"
        Me.btncorreos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncorreos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncorreos.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gold
        Me.Panel5.Location = New System.Drawing.Point(0, 520)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 7
        '
        'btnmantenimiento
        '
        Me.btnmantenimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmantenimiento.FlatAppearance.BorderSize = 0
        Me.btnmantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnmantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnmantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmantenimiento.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmantenimiento.ForeColor = System.Drawing.Color.White
        Me.btnmantenimiento.Image = Global.Login_El_Dorado.My.Resources.Resources.relo3
        Me.btnmantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmantenimiento.Location = New System.Drawing.Point(0, 520)
        Me.btnmantenimiento.Name = "btnmantenimiento"
        Me.btnmantenimiento.Size = New System.Drawing.Size(220, 50)
        Me.btnmantenimiento.TabIndex = 6
        Me.btnmantenimiento.Text = "Mantenimiento"
        Me.btnmantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnmantenimiento.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gold
        Me.Panel4.Location = New System.Drawing.Point(0, 451)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 5
        '
        'btnproveedorprincipal
        '
        Me.btnproveedorprincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnproveedorprincipal.FlatAppearance.BorderSize = 0
        Me.btnproveedorprincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnproveedorprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnproveedorprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproveedorprincipal.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproveedorprincipal.ForeColor = System.Drawing.Color.White
        Me.btnproveedorprincipal.Image = Global.Login_El_Dorado.My.Resources.Resources.proveedores
        Me.btnproveedorprincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproveedorprincipal.Location = New System.Drawing.Point(0, 451)
        Me.btnproveedorprincipal.Name = "btnproveedorprincipal"
        Me.btnproveedorprincipal.Size = New System.Drawing.Size(220, 50)
        Me.btnproveedorprincipal.TabIndex = 4
        Me.btnproveedorprincipal.Text = " Proveedores"
        Me.btnproveedorprincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnproveedorprincipal.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gold
        Me.Panel3.Location = New System.Drawing.Point(0, 381)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 5
        '
        'btnstockprincipal
        '
        Me.btnstockprincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstockprincipal.FlatAppearance.BorderSize = 0
        Me.btnstockprincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnstockprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnstockprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstockprincipal.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstockprincipal.ForeColor = System.Drawing.Color.White
        Me.btnstockprincipal.Image = Global.Login_El_Dorado.My.Resources.Resources.producto
        Me.btnstockprincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstockprincipal.Location = New System.Drawing.Point(0, 381)
        Me.btnstockprincipal.Name = "btnstockprincipal"
        Me.btnstockprincipal.Size = New System.Drawing.Size(220, 50)
        Me.btnstockprincipal.TabIndex = 4
        Me.btnstockprincipal.Text = " Stock"
        Me.btnstockprincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnstockprincipal.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Location = New System.Drawing.Point(0, 309)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 5
        '
        'btnclientesprincipal
        '
        Me.btnclientesprincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclientesprincipal.FlatAppearance.BorderSize = 0
        Me.btnclientesprincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnclientesprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnclientesprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientesprincipal.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclientesprincipal.ForeColor = System.Drawing.Color.White
        Me.btnclientesprincipal.Image = Global.Login_El_Dorado.My.Resources.Resources.clientes
        Me.btnclientesprincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclientesprincipal.Location = New System.Drawing.Point(0, 309)
        Me.btnclientesprincipal.Name = "btnclientesprincipal"
        Me.btnclientesprincipal.Size = New System.Drawing.Size(220, 50)
        Me.btnclientesprincipal.TabIndex = 4
        Me.btnclientesprincipal.Text = " Clientes"
        Me.btnclientesprincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclientesprincipal.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Location = New System.Drawing.Point(0, 244)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 5
        '
        'btnempleadosprincipal
        '
        Me.btnempleadosprincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnempleadosprincipal.FlatAppearance.BorderSize = 0
        Me.btnempleadosprincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnempleadosprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnempleadosprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempleadosprincipal.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnempleadosprincipal.ForeColor = System.Drawing.Color.White
        Me.btnempleadosprincipal.Image = Global.Login_El_Dorado.My.Resources.Resources.empleados
        Me.btnempleadosprincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnempleadosprincipal.Location = New System.Drawing.Point(0, 244)
        Me.btnempleadosprincipal.Name = "btnempleadosprincipal"
        Me.btnempleadosprincipal.Size = New System.Drawing.Size(220, 50)
        Me.btnempleadosprincipal.TabIndex = 4
        Me.btnempleadosprincipal.Text = " Empleados"
        Me.btnempleadosprincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnempleadosprincipal.UseVisualStyleBackColor = True
        '
        'pnldeco1principal
        '
        Me.pnldeco1principal.BackColor = System.Drawing.Color.Gold
        Me.pnldeco1principal.Location = New System.Drawing.Point(0, 178)
        Me.pnldeco1principal.Name = "pnldeco1principal"
        Me.pnldeco1principal.Size = New System.Drawing.Size(5, 50)
        Me.pnldeco1principal.TabIndex = 3
        '
        'btnventasprincipal
        '
        Me.btnventasprincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnventasprincipal.FlatAppearance.BorderSize = 0
        Me.btnventasprincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnventasprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnventasprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnventasprincipal.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnventasprincipal.ForeColor = System.Drawing.Color.White
        Me.btnventasprincipal.Image = Global.Login_El_Dorado.My.Resources.Resources.venta
        Me.btnventasprincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnventasprincipal.Location = New System.Drawing.Point(0, 178)
        Me.btnventasprincipal.Name = "btnventasprincipal"
        Me.btnventasprincipal.Size = New System.Drawing.Size(151, 50)
        Me.btnventasprincipal.TabIndex = 2
        Me.btnventasprincipal.Text = " Ventas"
        Me.btnventasprincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnventasprincipal.UseVisualStyleBackColor = True
        '
        'picboxlogo
        '
        Me.picboxlogo.Image = Global.Login_El_Dorado.My.Resources.Resources.dorado
        Me.picboxlogo.Location = New System.Drawing.Point(60, 52)
        Me.picboxlogo.Name = "picboxlogo"
        Me.picboxlogo.Size = New System.Drawing.Size(98, 84)
        Me.picboxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxlogo.TabIndex = 1
        Me.picboxlogo.TabStop = False
        '
        'btnmenuprincipal
        '
        Me.btnmenuprincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenuprincipal.Image = Global.Login_El_Dorado.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnmenuprincipal.Location = New System.Drawing.Point(5, 3)
        Me.btnmenuprincipal.Name = "btnmenuprincipal"
        Me.btnmenuprincipal.Size = New System.Drawing.Size(48, 42)
        Me.btnmenuprincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmenuprincipal.TabIndex = 0
        Me.btnmenuprincipal.TabStop = False
        '
        'tmocultarmenu
        '
        Me.tmocultarmenu.Interval = 10
        '
        'tmmostrarmenu
        '
        Me.tmmostrarmenu.Interval = 10
        '
        'Stock
        '
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Name = "ChartArea1"
        Me.Stock.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Stock.Legends.Add(Legend1)
        Me.Stock.Location = New System.Drawing.Point(118, 98)
        Me.Stock.Name = "Stock"
        Me.Stock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Series1.BorderColor = System.Drawing.Color.Black
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.DodgerBlue
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Stock.Series.Add(Series1)
        Me.Stock.Size = New System.Drawing.Size(1033, 557)
        Me.Stock.TabIndex = 0
        Me.Stock.Text = "Stock"
        '
        'panelprincipal
        '
        Me.panelprincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelprincipal.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.panelprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelprincipal.Controls.Add(Me.Stock)
        Me.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelprincipal.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelprincipal.Location = New System.Drawing.Point(60, 40)
        Me.panelprincipal.Name = "panelprincipal"
        Me.panelprincipal.Size = New System.Drawing.Size(1454, 728)
        Me.panelprincipal.TabIndex = 2
        '
        'panelsupprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1514, 768)
        Me.Controls.Add(Me.panelprincipal)
        Me.Controls.Add(Me.panelizqprincipal)
        Me.Controls.Add(Me.pnlsuperiorprinciapl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "panelsupprincipal"
        Me.Text = "FormPrincipal"
        Me.pnlsuperiorprinciapl.ResumeLayout(False)
        Me.panelizqprincipal.ResumeLayout(False)
        CType(Me.picboxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmenuprincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelprincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlsuperiorprinciapl As System.Windows.Forms.Panel
    Friend WithEvents btncerrarprincipal As System.Windows.Forms.Button
    Friend WithEvents panelizqprincipal As System.Windows.Forms.Panel
    Friend WithEvents btnrestauraprincipal As System.Windows.Forms.Button
    Friend WithEvents btnminimprincipal As System.Windows.Forms.Button
    Friend WithEvents btnmaximprincipal As System.Windows.Forms.Button
    Friend WithEvents btnmenuprincipal As System.Windows.Forms.PictureBox
    Friend WithEvents tmocultarmenu As System.Windows.Forms.Timer
    Friend WithEvents tmmostrarmenu As System.Windows.Forms.Timer
    Friend WithEvents picboxlogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnventasprincipal As System.Windows.Forms.Button
    Friend WithEvents pnldeco1principal As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnproveedorprincipal As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnstockprincipal As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnclientesprincipal As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnempleadosprincipal As System.Windows.Forms.Button
    Friend WithEvents btnmantenimiento As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btncorreos As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Stock As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents panelprincipal As System.Windows.Forms.Panel
End Class
