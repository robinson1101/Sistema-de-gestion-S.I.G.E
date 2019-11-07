<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Television
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
        Me.PanelTelevision = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelTelevision
        '
        Me.PanelTelevision.BackColor = System.Drawing.Color.Navy
        Me.PanelTelevision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTelevision.Location = New System.Drawing.Point(0, 0)
        Me.PanelTelevision.Name = "PanelTelevision"
        Me.PanelTelevision.Size = New System.Drawing.Size(1083, 629)
        Me.PanelTelevision.TabIndex = 0
        '
        'Television
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1083, 629)
        Me.Controls.Add(Me.PanelTelevision)
        Me.Name = "Television"
        Me.Text = "Television"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTelevision As Panel
End Class
