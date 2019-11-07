<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reposiciones
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
        Me.PanelReposiciones = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelReposiciones
        '
        Me.PanelReposiciones.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PanelReposiciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelReposiciones.Location = New System.Drawing.Point(0, 0)
        Me.PanelReposiciones.Name = "PanelReposiciones"
        Me.PanelReposiciones.Size = New System.Drawing.Size(1074, 641)
        Me.PanelReposiciones.TabIndex = 0
        '
        'Reposiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1074, 641)
        Me.Controls.Add(Me.PanelReposiciones)
        Me.Name = "Reposiciones"
        Me.Text = "Reposiciones"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelReposiciones As Panel
End Class
