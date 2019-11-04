Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class InventarioHardware

    Public Function AutoCompletarGlobal(ByVal Control As TextBox, ByVal item As String) As AutoCompleteStringCollection


        Dim auto4 As New AutoCompleteStringCollection
        Dim comando4 As String

        comando4 = "SELECT " & item & " FROM `inventariohardware`"
        Dim llamado04 As New connection
        Dim consulta04 As New MySqlCommand(comando4, llamado04.conexion)
        llamado04.AbrirConexion()

        Dim lector04 As MySqlDataReader = consulta04.ExecuteReader()

        While lector04.Read()

            auto4.AddRange(New String() {lector04(0)})

        End While
        lector04.Close()
        llamado04.conexion.Close()
        With Control
            .AutoCompleteMode = AutoCompleteMode.Suggest

            .AutoCompleteSource = AutoCompleteSource.CustomSource

            .AutoCompleteCustomSource = auto4

        End With
        Return auto4
        llamado04.conexion.Close()
    End Function
    Private Sub InventarioHardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtCodigoH.Focus()


        AutoCompletarGlobal(Me.txtCodigoH, "codigoArticuloH")
        AutoCompletarGlobal(Me.txtTipoArticulo, "tipoArticuloH")
        AutoCompletarGlobal(Me.txtOficina, "oficinaH")
        AutoCompletarGlobal(Me.txtMarcaArticuloH, "marcaArticuloH")
        AutoCompletarGlobal(Me.txtTonnerH, "tonnerH")
        AutoCompletarGlobal(Me.txtSistemaOP, "sistemaOperativo")
        AutoCompletarGlobal(Me.txtMicrosoftOf, "mOffice")
        AutoCompletarGlobal(Me.txtHclient, "hClient")
        AutoCompletarGlobal(Me.txtCodigoSOFT, "serialArticuloSoft")

        AutoCompletarGlobal(Me.txtCapacidadDDH, "capacidadDdH")
        AutoCompletarGlobal(Me.txtMemoriaRamH, "memoriaRamH")
        AutoCompletarGlobal(Me.txtEstadoArticulo, "estadoArticuloH")
        AutoCompletarGlobal(Me.txtScreenV, "screemView")
        AutoCompletarGlobal(Me.txtSicacom, "sicacomVPN")
        AutoCompletarGlobal(Me.txtAdobePDF, "adobePDF")
        AutoCompletarGlobal(Me.txtDopBox, "dropBox")
        AutoCompletarGlobal(Me.txtAreaSoft, "areaSoft")
        AutoCompletarGlobal(Me.txtAdminT, "adminTurno")
        AutoCompletarGlobal(Me.txtRR, "rrVpnFijo")
        AutoCompletarGlobal(Me.txtCorreoE, "correoElectronico")
        AutoCompletarGlobal(Me.txtDemo, "numeroDemo")
        AutoCompletarGlobal(Me.txtAnyDesk, "anyDesk")

    End Sub

    Private Sub BtnGuardarH_Click(sender As Object, e As EventArgs) Handles btnGuardarH.Click

        Try
            Dim validador As Integer
            validador = 0
            Dim llamadoValidarSerial As New connection
            Dim consultaValidarSerial As New MySqlCommand("Select * from inventariohardware where codigoArticuloH='" & txtCodigoH.Text & "' or serialArticuloSoft='" & txtCodigoSOFT.Text & "'", llamadoValidarSerial.conexion)
            llamadoValidarSerial.AbrirConexion()
            Dim leerValidarSerial As MySqlDataReader = consultaValidarSerial.ExecuteReader()
            If leerValidarSerial.Read Then
                validador = 1
            End If
            llamadoValidarSerial.CerrarConexion()

            If validador = 0 Then

                Dim llamado0 As New connection
                llamado0.AbrirConexion()

                If txtCapacidadDDH.Text <> "" And txtRR.Text <> "" And txtCorreoE.Text <> "" And txtDemo.Text <> "" And txtAnyDesk.Text <> "" And txtAdminT.Text <> "" And
                    txtAdobePDF.Text <> "" And txtSicacom.Text <> "" And txtScreenV.Text <> "" And txtCodigoSOFT.Text <> "" And txtAreaSoft.Text <> "" And txtDopBox.Text <> "" And
                    txtHclient.Text <> "" And txtMicrosoftOf.Text <> "" And txtSistemaOP.Text <> "" And txtCodigoH.Text <> "" And
                    txtEstadoArticulo.Text <> "" And txtMarcaArticuloH.Text <> "" And txtOficina.Text <> "" And txtTipoArticulo.Text <> "" And txtTonnerH.Text <> "" And
                    txtMemoriaRamH.Text <> "" And ComboBoxIS.Text <> "SELECCIONAR" Then

                    Dim consulta0 As New MySqlCommand("INSERT INTO `inventariohardware` VALUES (null,'" + txtCodigoH.Text + "', '" + txtTipoArticulo.Text + "', '" + txtOficina.Text + "',
'" + txtMarcaArticuloH.Text + "','" + txtTonnerH.Text + "','" + txtCapacidadDDH.Text + "','" + txtMemoriaRamH.Text + "','" + txtEstadoArticulo.Text + "',
'" + txtSistemaOP.Text + "','" + txtMicrosoftOf.Text + "','" + txtHclient.Text + "','" + txtDopBox.Text + "','" + txtAreaSoft.Text + "','" + txtCodigoSOFT.Text + "',
'" + txtScreenV.Text + "','" + txtSicacom.Text + "','" + txtAdobePDF.Text + "','" + txtAdminT.Text + "','" + txtRR.Text + "','" + txtCorreoE.Text + "','" + txtDemo.Text + "',
'" + txtAnyDesk.Text + "','" + ComboBoxIS.SelectedItem + "','" + RichTextBox1.Text + "', '" + labelNombreH.Text + "', CURRENT_TIMESTAMP)", llamado0.conexion)

                    consulta0.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")

                    ComboBoxIS.Text = "SELECCIONAR"
                    txtCapacidadDDH.Text = ""
                    txtCodigoH.Text = ""

                    txtEstadoArticulo.Text = ""
                    txtMarcaArticuloH.Text = ""
                    txtOficina.Text = ""
                    txtTipoArticulo.Text = ""
                    txtTonnerH.Text = ""
                    txtMemoriaRamH.Text = ""

                    RichTextBox1.Text = ""

                    txtSistemaOP.Text = ""
                    txtMicrosoftOf.Text = ""
                    txtHclient.Text = ""
                    txtDopBox.Text = ""
                    txtAreaSoft.Text = ""
                    txtCodigoSOFT.Text = ""
                    txtScreenV.Text = ""
                    txtSicacom.Text = ""
                    txtAdobePDF.Text = ""
                    txtAdminT.Text = ""

                    txtRR.Text = ""
                    txtCorreoE.Text = ""
                    txtDemo.Text = ""
                    txtAnyDesk.Text = ""

                    txtCodigoH.Focus()

                Else
                    If ComboBoxIS.Text = "SELECCIONAR" Then

                        MsgBox("DEBE SELECCIONAR UN ITEM VALIDO.", MsgBoxStyle.Information, "INFORMACION")
                    Else
                        MsgBox("DEBE LLENAR LOS CAMPOS OBLIGATORIOS", MsgBoxStyle.Information, "INFORMACION")
                        txtCodigoH.Focus()
                    End If


                End If
                llamado0.conexion.Close()
            ElseIf validador = 1 Then
                MsgBox("Uno o los dos seriales ya estan registrados en la base de datos.")
            End If

        Catch ex As Exception
            MsgBox("Error de conexion")
        End Try

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        labelNombreH.Text = InventarioSH.Label3.Text
    End Sub

    Private Sub BtnLimpiarHard_Click(sender As Object, e As EventArgs) Handles btnLimpiarHard.Click


        txtCapacidadDDH.Text = ""
        txtCodigoH.Text = ""

        txtEstadoArticulo.Text = ""
        txtMarcaArticuloH.Text = ""
        txtOficina.Text = ""
        txtTipoArticulo.Text = ""
        txtTonnerH.Text = ""
        txtMemoriaRamH.Text = ""

        RichTextBox1.Text = ""

        txtSistemaOP.Text = ""
        txtMicrosoftOf.Text = ""
        txtHclient.Text = ""
        txtDopBox.Text = ""
        txtAreaSoft.Text = ""
        txtCodigoSOFT.Text = ""
        txtScreenV.Text = ""
        txtSicacom.Text = ""
        txtAdobePDF.Text = ""
        txtAdminT.Text = ""

        txtRR.Text = ""
        txtCorreoE.Text = ""
        txtDemo.Text = ""
        txtAnyDesk.Text = ""

        txtCodigoH.Focus()

    End Sub

    Private Sub RichTextBox1_Enter(sender As Object, e As EventArgs) Handles RichTextBox1.Enter
        PictureBoxColor.Visible = True
    End Sub

    Private Sub RichTextBox1_Leave(sender As Object, e As EventArgs) Handles RichTextBox1.Leave
        PictureBoxColor.Visible = False
    End Sub

    Private Sub TxtCodigoH_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoH.TextChanged
        'AutoCompletar(Me.txtCodigoH)
    End Sub

    Private Sub TxtCodigoH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoH.KeyPress
        'aqui deberia dejar borrar cuando ingreso un codigo mal
        If (e.KeyChar = ChrW(Keys.Space) And txtCodigoH.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("+{TAB}")

        End If
    End Sub

    Private Sub TxtTipoArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoArticulo.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtTipoArticulo.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtOficina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOficina.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtOficina.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtMarcaArticuloH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarcaArticuloH.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtMarcaArticuloH.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtTonnerH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTonnerH.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtTonnerH.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtSistemaOP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSistemaOP.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtSistemaOP.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtMicrosoftOf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMicrosoftOf.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtMicrosoftOf.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtHclient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHclient.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtHclient.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtCodigoSOFT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoSOFT.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtCodigoSOFT.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    'Private Sub TxtDependenciaH_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = ChrW(Keys.Space) And txtDependenciaH.Text = "") Then
    '        e.Handled = True
    '    End If
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        SendKeys.Send("{TAB}")

    '    End If
    'End Sub

    Private Sub TxtCapacidadDDH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapacidadDDH.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtCapacidadDDH.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtMemoriaRamH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMemoriaRamH.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtMemoriaRamH.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtEstadoArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstadoArticulo.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtEstadoArticulo.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtScreenV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScreenV.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtScreenV.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtSicacom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSicacom.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtSicacom.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtAdobePDF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdobePDF.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtAdobePDF.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtDopBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDopBox.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtDopBox.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtAreaSoft_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAreaSoft.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtAreaSoft.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtAdminT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdminT.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtAdminT.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtRR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRR.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtRR.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtCorreoE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreoE.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtCorreoE.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtDemo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDemo.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
        End If

        If (e.KeyChar = ChrW(Keys.Space) And txtDemo.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TxtAnyDesk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnyDesk.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And txtAnyDesk.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
        If (e.KeyChar = ChrW(Keys.Space) And RichTextBox1.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub ComboBoxIS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxIS.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBoxIS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxIS.SelectedIndexChanged
        If ComboBoxIS.SelectedItem = "DISPONIBLE" Then
            ComboBoxIS.BackColor = Color.Yellow
        ElseIf ComboBoxIS.SelectedItem = "EN USO" Then
            ComboBoxIS.BackColor = Color.Green
        ElseIf ComboBoxIS.SelectedItem = "DADO DE BAJA" Then
            ComboBoxIS.BackColor = Color.Red

        End If
    End Sub
End Class