Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Module modulo1
    Public sRespuesta As String


End Module


Public Class Domicilio

#Region "Variables"

    Dim cCOn As New SqlConnection
    Dim daLecturas As New SqlDataAdapter
    Dim dsLecturas As New DataSet
    Public iNuevo As Integer



#End Region

    Private Sub Domicilio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cCOn.ConnectionString = My.Resources.cdTau
        llenaCombo()
        chbLimpiar.Checked = True

        If iNuevo = 1 Then
            txtContrato.Visible = False
            lbContrato.Visible = False
            btBuscar.Visible = False


        Else
            chbLimpiar.Visible = False
            btnAceptar.Enabled = False
            btnCancelar.Enabled = False
            txtContrato.Focus()




        End If
    End Sub
    Private Sub llenaCombo()
        Try
            Dim sTabla As String
            Dim sSql As String
            sSql = "Select distinct oid, nombrevialidad from vialidad order by nombrevialidad"
            sTabla = "Vialidad"

            cmbVialidad.Items.Clear()
            cmbCruce1.Items.Clear()
            cmbCruce2.Items.Clear()

            Llena(sSql, sTabla)
            llenar(sTabla, cmbVialidad)
            llenar(sTabla, cmbCruce1)
            llenar(sTabla, cmbCruce2)

            sSql = "Select distinct oid, NombreColonia from colonia order by NombreColonia"
            sTabla = "Colonia"
            Llena(sSql, sTabla)
            llenar(sTabla, cmbColonia)


        Catch ex As Exception

            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub
    Private Sub llenar(sTabla As String, ByRef cbCombo As ComboBox)
        Try
            For A = 0 To dsLecturas.Tables(sTabla).Rows.Count - 1
                cbCombo.Items.Add(dsLecturas.Tables(sTabla).Rows(A).Item("Nombre" & sTabla))
            Next


        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub

    Private Sub Llena(sSql As String, sTabla As String)
        Try
            cCOn.ConnectionString = My.Resources.cdTau
            Dim cmdSql As New SqlCommand(sSql, cCOn)
            daLecturas.SelectCommand = cmdSql

            cCOn.Open()
            daLecturas.Fill(dsLecturas, sTabla)
            cCOn.Close()



        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
                cCOn.Close()
            End If
            MsgBox(Err.Number & " : " & Err.Description)
        End Try

    End Sub


    Private Sub cmbVialidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbVialidad.KeyPress
        e.KeyChar = UCase(e.KeyChar)

    End Sub

    Private Sub cmbColonia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbColonia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmbCruce1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCruce1.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmbCruce2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCruce2.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If cCOn.State = ConnectionState.Open Then
            cCOn.Close()
        End If
        LimpiarFormulario()
        If iNuevo = 0 Then
            txtContrato.Enabled = True
            btBuscar.Enabled = True
            btnAceptar.Enabled = False
            btnCancelar.Enabled = False
        End If




    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            Dim Vialidad As Integer
            Dim viaCruce1 As Integer
            Dim viaCruce2 As Integer
            Dim Colonia As Integer

            Dim sSql As String

            If cmbColonia.Text = "" Then
                MsgBox("Falta capturar colonia", MsgBoxStyle.OkOnly, "Colonia")
                Exit Sub

            Else
                Colonia = buscarId(cmbColonia.Text, "Colonia")
                If Colonia = 0 Then
                    MsgBox("No se Encontro la colonia favor de revisar", MsgBoxStyle.OkOnly, "Colonia")
                    Exit Sub

                End If
            End If


            If cmbVialidad.Text = "" Then
                MsgBox("Falta capturar vialidad", MsgBoxStyle.OkOnly, "Vialidad")
                Exit Sub

            Else
                Vialidad = buscarId(cmbVialidad.Text, "Vialidad")
                If Vialidad = 0 Then
                    MsgBox("No se Encontro la Vialidad favor de revisar", MsgBoxStyle.OkOnly, "Vialidad")
                    Exit Sub

                End If
            End If
            If cmbCruce1.Text = "" Then
                viaCruce1 = 1087
            Else
                viaCruce1 = buscarId(cmbCruce1.Text, "Vialidad")
                If viaCruce1 = 0 Then
                    MsgBox("No se Encontro la Vialidad favor de revisar", MsgBoxStyle.OkOnly, "Vialidad")
                    Exit Sub

                End If
            End If
            If cmbCruce2.Text = "" Then
                viaCruce2 = 1087
            Else
                viaCruce2 = buscarId(cmbCruce2.Text, "Vialidad")
                If viaCruce2 = 0 Then
                    MsgBox("No se Encontro la Vialidad favor de revisar", MsgBoxStyle.OkOnly, "Vialidad")
                    Exit Sub

                End If
            End If
            If txtExterior.Text = "" Then
                MsgBox("Debe capturar exterior", MsgBoxStyle.OkOnly, "Exterior")
                Exit Sub

            End If

            If iNuevo = 1 Then
                sSql = "exec dbo.usp_CrearDomicilioTlq " & Vialidad & ", '" & cmbVialidad.Text & "', " & viaCruce1 & " ,'" & cmbCruce1.Text & "' ," & viaCruce2 & ",'" & cmbCruce2.Text & "' ," & Colonia & ",'" & cmbColonia.Text & "' ,'" & txtExterior.Text & "','" & txtInterior.Text & "' ,'" & txtCP.Text & "'"
            Else
                If txtContrato.Text = "" Then
                    MsgBox("Debe capturar contrato", MsgBoxStyle.OkOnly, "Contrato")
                    Exit Sub
                Else
                    sSql = "exec dbo.usp_ModificarDomicilioTlq " & dsLecturas.Tables("Contrato").Rows(0).Item("oidContrato").ToString & "," & dsLecturas.Tables("Contrato").Rows(0).Item("idUbicacion").ToString & "," & Vialidad & ", '" & cmbVialidad.Text & "', " & viaCruce1 & " ,'" & cmbCruce1.Text & "' ," & viaCruce2 & ",'" & cmbCruce2.Text & "' ," & Colonia & ",'" & cmbColonia.Text & "' ,'" & txtExterior.Text & "','" & txtInterior.Text & "' ,'" & txtCP.Text & "'"
                End If

            End If


            cCOn.Open()
            Dim cmdSql1 As New SqlCommand(sSql, cCOn)

            cmdSql1.ExecuteNonQuery()

            cCOn.Close()

            MsgBox("Se dio de alta correctamente", MsgBoxStyle.OkOnly, "Terminado")
            If chbLimpiar.Checked = True Then
                LimpiarFormulario()

            End If
            cmbVialidad.Focus()

            If iNuevo = 0 Then
                txtContrato.Enabled = True
                btBuscar.Enabled = True
                btnAceptar.Enabled = False
                btnCancelar.Enabled = False
                txtContrato.Focus()



            End If
        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
                cCOn.Close()
            End If
            MsgBox(Err.Number & " : " & Err.Description)
        End Try

    End Sub
    Private Function buscarId(sBuscar As String, sTabla As String) As Integer
        Dim iRes As Integer
        iRes = 0

        For A = 0 To dsLecturas.Tables(sTabla).Rows.Count - 1
            If dsLecturas.Tables(sTabla).Rows(A).Item("Nombre" & sTabla).ToString = sBuscar Then
                iRes = dsLecturas.Tables(sTabla).Rows(A).Item("oid")
                Exit For

            End If
        Next
        Return iRes
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVialidad.Click
        Buscar("Vialidad", cmbVialidad)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnColonia.Click
        Buscar("Colonia", cmbColonia)
    End Sub

    Private Sub btnCruce1_Click(sender As Object, e As EventArgs) Handles btnCruce1.Click
        Buscar("Vialidad", cmbVialidad)
    End Sub

    Private Sub btnCruce2_Click(sender As Object, e As EventArgs) Handles btnCruce2.Click
        Buscar("Vialidad", cmbVialidad)
    End Sub
    Private Sub Buscar(Opc As String, ByRef Combo As ComboBox)
        Try
            Dim f2 As New frmBuscar
            f2.sOpcion = Opc
            sRespuesta = ""
            f2.ShowDialog()
            If sRespuesta <> "" Then
                Combo.Text = sRespuesta

            End If


        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        If txtContrato.Text = "" Then
            MsgBox("Debe capturar contrato.", MsgBoxStyle.OkOnly, "Contrato")
        ElseIf Len(txtContrato.Text) > 8 Then
            MsgBox("El contrato tiene demasiado digitos", MsgBoxStyle.OkOnly, "Contrato")
        Else
            txtContrato.Text = Mid("00000000", 1, 8 - Len(txtContrato.Text)) & txtContrato.Text
            BuscaContrato()

        End If
    End Sub
    Private Sub BuscaContrato()
        Try
            Dim sSql As String

            sSql = "SELECT top 1 oidContrato,CuentaDepto,idUbicacion,Calle,Exterior,Interior,Colonia,CruceCalle1,CruceCalle2,CP FROM uvw_ContratoDomicilio where CuentaDepto ='" & txtContrato.Text & "'"
            If dsLecturas.Tables.Contains("Contrato") Then
                dsLecturas.Tables("Contrato").Clear()
            End If

            Llena(sSql, "Contrato")

            If dsLecturas.Tables("Contrato").Rows.Count = 1 Then
                cmbVialidad.Text = dsLecturas.Tables("Contrato").Rows(0).Item("Calle").ToString
                cmbColonia.Text = dsLecturas.Tables("Contrato").Rows(0).Item("Colonia").ToString
                cmbCruce1.Text = dsLecturas.Tables("Contrato").Rows(0).Item("CruceCalle1").ToString
                cmbCruce2.Text = dsLecturas.Tables("Contrato").Rows(0).Item("CruceCalle2").ToString()
                txtExterior.Text = dsLecturas.Tables("Contrato").Rows(0).Item("Exterior").ToString()
                txtInterior.Text = dsLecturas.Tables("Contrato").Rows(0).Item("Interior").ToString()
                txtCP.Text = dsLecturas.Tables("Contrato").Rows(0).Item("CP").ToString()
                txtContrato.Enabled = False
                btBuscar.Enabled = False
                btnAceptar.Enabled = True
                btnCancelar.Enabled = True

            Else
                MsgBox("No se encontraron registros", MsgBoxStyle.OkOnly, "Contrato")
            End If


        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try

    End Sub

    Private Sub txtContrato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContrato.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then

            e.Handled = True

            MsgBox("Introduzca sólo valores númericos", MsgBoxStyle.OkOnly, "Mensaje")
        End If

    End Sub
    Private Sub LimpiarFormulario()
        cmbVialidad.Text = ""
        cmbColonia.Text = ""
        cmbCruce1.Text = ""
        cmbCruce2.Text = ""
        txtExterior.Text = ""
        txtInterior.Text = ""
        txtCP.Text = ""
        txtContrato.Text = ""

    End Sub
End Class