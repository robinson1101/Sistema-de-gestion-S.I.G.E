﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.PanelVentasDia = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelVentasDia
        '
        Me.PanelVentasDia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelVentasDia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVentasDia.Location = New System.Drawing.Point(0, 0)
        Me.PanelVentasDia.Name = "PanelVentasDia"
        Me.PanelVentasDia.Size = New System.Drawing.Size(1062, 633)
        Me.PanelVentasDia.TabIndex = 0
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1062, 633)
        Me.Controls.Add(Me.PanelVentasDia)
        Me.Name = "Ventas"
        Me.Text = "Ventas del dia"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelVentasDia As Panel
End Class
