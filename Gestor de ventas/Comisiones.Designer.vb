﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comisiones
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
        Me.PanelComisiones = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelComisiones
        '
        Me.PanelComisiones.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelComisiones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelComisiones.Location = New System.Drawing.Point(0, 0)
        Me.PanelComisiones.Name = "PanelComisiones"
        Me.PanelComisiones.Size = New System.Drawing.Size(1048, 617)
        Me.PanelComisiones.TabIndex = 0
        '
        'Comisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1048, 617)
        Me.Controls.Add(Me.PanelComisiones)
        Me.Name = "Comisiones"
        Me.Text = "Comisiones"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelComisiones As Panel
End Class
