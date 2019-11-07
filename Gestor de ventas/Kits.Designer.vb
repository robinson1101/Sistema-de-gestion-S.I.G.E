<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kits
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
        Me.PanelKits = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelKits
        '
        Me.PanelKits.BackColor = System.Drawing.Color.Olive
        Me.PanelKits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKits.Location = New System.Drawing.Point(0, 0)
        Me.PanelKits.Name = "PanelKits"
        Me.PanelKits.Size = New System.Drawing.Size(1081, 617)
        Me.PanelKits.TabIndex = 0
        '
        'Kits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1081, 617)
        Me.Controls.Add(Me.PanelKits)
        Me.Name = "Kits"
        Me.Text = "Kits"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelKits As Panel
End Class
