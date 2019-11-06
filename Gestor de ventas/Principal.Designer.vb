<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.btn_Planes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_Reposiciones = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_planE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_kits = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_Proporcionados = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_Tv = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_triple = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_comisiones = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_ventas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Planes, Me.ToolStripSeparator1, Me.btn_Reposiciones, Me.ToolStripSeparator2, Me.btn_planE, Me.ToolStripSeparator4, Me.btn_kits, Me.ToolStripSeparator5, Me.btn_Proporcionados, Me.ToolStripSeparator3, Me.btn_Tv, Me.ToolStripSeparator6, Me.btn_triple, Me.ToolStripSeparator7, Me.btn_comisiones, Me.ToolStripSeparator8, Me.btn_ventas, Me.ToolStripButton1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1184, 72)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "Barra de contenido"
        '
        'btn_Planes
        '
        Me.btn_Planes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_Planes.Image = Global.Gestor_de_ventas.My.Resources.Resources.iconsPlanes50
        Me.btn_Planes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Planes.Margin = New System.Windows.Forms.Padding(2, 1, 0, 2)
        Me.btn_Planes.Name = "btn_Planes"
        Me.btn_Planes.Size = New System.Drawing.Size(54, 69)
        Me.btn_Planes.Text = "Planes"
        Me.btn_Planes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 72)
        '
        'btn_Reposiciones
        '
        Me.btn_Reposiciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_Reposiciones.Image = Global.Gestor_de_ventas.My.Resources.Resources.sim
        Me.btn_Reposiciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Reposiciones.Name = "btn_Reposiciones"
        Me.btn_Reposiciones.Size = New System.Drawing.Size(80, 69)
        Me.btn_Reposiciones.Text = "Reposiciones"
        Me.btn_Reposiciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Reposiciones.ToolTipText = "Reposiciones"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 72)
        '
        'btn_planE
        '
        Me.btn_planE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_planE.Image = Global.Gestor_de_ventas.My.Resources.Resources.smartphone
        Me.btn_planE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_planE.Name = "btn_planE"
        Me.btn_planE.Size = New System.Drawing.Size(84, 69)
        Me.btn_planE.Text = "Plan+Equipos"
        Me.btn_planE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_planE.ToolTipText = "Plan + Equipo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 72)
        '
        'btn_kits
        '
        Me.btn_kits.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_kits.Image = Global.Gestor_de_ventas.My.Resources.Resources.smartphone2
        Me.btn_kits.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_kits.Name = "btn_kits"
        Me.btn_kits.Size = New System.Drawing.Size(54, 69)
        Me.btn_kits.Text = "Kits"
        Me.btn_kits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_kits.ToolTipText = "Kit financiado"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 72)
        '
        'btn_Proporcionados
        '
        Me.btn_Proporcionados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_Proporcionados.Image = Global.Gestor_de_ventas.My.Resources.Resources.money_transfer
        Me.btn_Proporcionados.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Proporcionados.Name = "btn_Proporcionados"
        Me.btn_Proporcionados.Size = New System.Drawing.Size(66, 69)
        Me.btn_Proporcionados.Text = "Prestamos"
        Me.btn_Proporcionados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Proporcionados.ToolTipText = "Equipos proporcionados"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 72)
        '
        'btn_Tv
        '
        Me.btn_Tv.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_Tv.Image = Global.Gestor_de_ventas.My.Resources.Resources.icons8_gps_en_busca_50
        Me.btn_Tv.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Tv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Tv.Name = "btn_Tv"
        Me.btn_Tv.Size = New System.Drawing.Size(64, 69)
        Me.btn_Tv.Text = "Television"
        Me.btn_Tv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Tv.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.btn_Tv.ToolTipText = "Television"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 72)
        '
        'btn_triple
        '
        Me.btn_triple.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_triple.Image = Global.Gestor_de_ventas.My.Resources.Resources.Sin_título2
        Me.btn_triple.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_triple.Name = "btn_triple"
        Me.btn_triple.Size = New System.Drawing.Size(66, 69)
        Me.btn_triple.Text = "Triple Play"
        Me.btn_triple.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_triple.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.btn_triple.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_triple.ToolTipText = "Triple play"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 72)
        '
        'btn_comisiones
        '
        Me.btn_comisiones.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_comisiones.Image = Global.Gestor_de_ventas.My.Resources.Resources.icons8_circulacion_de_dinero_50
        Me.btn_comisiones.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_comisiones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_comisiones.Name = "btn_comisiones"
        Me.btn_comisiones.Size = New System.Drawing.Size(73, 69)
        Me.btn_comisiones.Text = "Comisiones"
        Me.btn_comisiones.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_comisiones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 72)
        '
        'btn_ventas
        '
        Me.btn_ventas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_ventas.Image = Global.Gestor_de_ventas.My.Resources.Resources.icons8_vieja_caja_registradora_50
        Me.btn_ventas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ventas.Name = "btn_ventas"
        Me.btn_ventas.Size = New System.Drawing.Size(84, 69)
        Me.btn_ventas.Text = "Ventas del dia"
        Me.btn_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripButton1.Image = Global.Gestor_de_ventas.My.Resources.Resources.bloc
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(57, 69)
        Me.ToolStripButton1.Text = "Iventario"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PanelContenedor
        '
        Me.PanelContenedor.AutoScroll = True
        Me.PanelContenedor.BackColor = System.Drawing.Color.White
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1184, 761)
        Me.PanelContenedor.TabIndex = 1
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PanelContenedor)
        Me.MinimumSize = New System.Drawing.Size(900, 700)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GESTOR DE MOVIMIENTOS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_Planes As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btn_Reposiciones As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btn_planE As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btn_kits As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents btn_Proporcionados As ToolStripButton
    Friend WithEvents btn_Tv As ToolStripButton
    Friend WithEvents btn_triple As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btn_comisiones As ToolStripButton
    Friend WithEvents btn_ventas As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents PanelContenedor As Panel
End Class
