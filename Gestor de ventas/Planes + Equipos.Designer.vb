﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Planes___Equipos
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
        Me.PanelPlnesYequipos = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelPlnesYequipos
        '
        Me.PanelPlnesYequipos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelPlnesYequipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPlnesYequipos.Location = New System.Drawing.Point(0, 0)
        Me.PanelPlnesYequipos.Name = "PanelPlnesYequipos"
        Me.PanelPlnesYequipos.Size = New System.Drawing.Size(1072, 629)
        Me.PanelPlnesYequipos.TabIndex = 0
        '
        'Planes___Equipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1072, 629)
        Me.Controls.Add(Me.PanelPlnesYequipos)
        Me.Name = "Planes___Equipos"
        Me.Text = "Planes___Equipos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPlnesYequipos As Panel
End Class
