Imports System.Runtime.InteropServices

Public Class Principal

    'METODO PARA ABRIR FORMULARIO DENTRO DEL PANEL 
    Private Sub AbrirFormEnPanel(Of miforms As {Form, New})()
        Dim formulario As Form
        formulario = PanelContenedor.Controls.OfType(Of miforms)().FirstOrDefault()

        If formulario Is Nothing Then
            formulario = New miforms()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            PanelContenedor.Controls.Add(formulario)
            PanelContenedor.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
            'AddHandler formulario.FormClosed, AddressOf Me.CloseForms
        Else

            If formulario.WindowState = FormWindowState.Minimized Then
                formulario.WindowState = FormWindowState.Normal
            End If

            formulario.BringToFront()
        End If


    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'metodo para iniciar el form principal MAXIMIZADO
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btn_Planes_Click(sender As Object, e As EventArgs) Handles btn_Planes.Click
        'llamado al formulario Planes
        AbrirFormEnPanel(Of Planes)()
    End Sub

    Private Sub btn_Reposiciones_Click(sender As Object, e As EventArgs) Handles btn_Reposiciones.Click
        'llamado al formulario Reposiciones 
        AbrirFormEnPanel(Of Reposiciones)()
    End Sub

    Private Sub btn_planE_Click(sender As Object, e As EventArgs) Handles btn_planE.Click
        'llamado al formulario Planes+Equipos
        AbrirFormEnPanel(Of Planes___Equipos)()
    End Sub

    Private Sub btn_kits_Click(sender As Object, e As EventArgs) Handles btn_kits.Click
        'llamado al formulario kits
        AbrirFormEnPanel(Of Kits)()
    End Sub

    Private Sub btn_Proporcionados_Click(sender As Object, e As EventArgs) Handles btn_Proporcionados.Click
        'llamado al formulario Proporcionados
        AbrirFormEnPanel(Of Proporcionados)()
    End Sub

    Private Sub btn_Tv_Click(sender As Object, e As EventArgs) Handles btn_Tv.Click
        'llamado al formulario Television
        AbrirFormEnPanel(Of Television)()
    End Sub

    Private Sub btn_comisiones_Click(sender As Object, e As EventArgs) Handles btn_comisiones.Click
        'llamado al formulario Comisiones
        AbrirFormEnPanel(Of Comisiones)()
    End Sub

    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click
        'llamado al formulario Ventas
        AbrirFormEnPanel(Of Ventas)()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'llamado al formulario Inventario general
        AbrirFormEnPanel(Of InventarioGeneral)()
    End Sub

    Private Sub btn_Clientes_Click(sender As Object, e As EventArgs) Handles btn_Clientes.Click
        Clientes.ShowDialog()
    End Sub
End Class
