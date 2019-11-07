<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.PanelClientes = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelClientes
        '
        Me.PanelClientes.BackColor = System.Drawing.Color.Navy
        Me.PanelClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelClientes.Location = New System.Drawing.Point(0, 0)
        Me.PanelClientes.Name = "PanelClientes"
        Me.PanelClientes.Size = New System.Drawing.Size(1068, 634)
        Me.PanelClientes.TabIndex = 0
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1068, 634)
        Me.Controls.Add(Me.PanelClientes)
        Me.MaximumSize = New System.Drawing.Size(1084, 673)
        Me.MinimumSize = New System.Drawing.Size(1084, 673)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelClientes As Panel
End Class
