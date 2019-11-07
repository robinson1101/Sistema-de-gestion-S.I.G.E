<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Planes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelPlanes = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 796)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1093, 10)
        Me.Panel1.TabIndex = 1
        '
        'PanelPlanes
        '
        Me.PanelPlanes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelPlanes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPlanes.Location = New System.Drawing.Point(0, 0)
        Me.PanelPlanes.Name = "PanelPlanes"
        Me.PanelPlanes.Size = New System.Drawing.Size(1093, 796)
        Me.PanelPlanes.TabIndex = 2
        '
        'Planes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1093, 806)
        Me.Controls.Add(Me.PanelPlanes)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Planes"
        Me.Text = "Planes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelPlanes As Panel
End Class
