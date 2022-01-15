Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class frmAplicoRecorrido

#Region "Variables"

    Dim cCOn As New SqlConnection
    Dim daLecturas As New SqlDataAdapter
    Dim dsLecturas As New DataSet
    Dim hacerConsulta As Integer
    Dim oidRecorridoVigencia As Integer


#End Region

    Private Sub frmAplicoRecorrido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            cCOn.ConnectionString = My.Resources.cdTau
            hacerConsulta = 1


            Dim cmdSql As New SqlCommand("Select distinct oid, nombre from Recorrido order by nombre", cCOn)
            daLecturas.SelectCommand = cmdSql

            cCOn.Open()
            daLecturas.Fill(dsLecturas, "Rutas")
            cCOn.Close()


            For A = 0 To dsLecturas.Tables("Rutas").Rows.Count - 1

                cmbRecorrido.Items.Add(dsLecturas.Tables("Rutas").Rows(A).Item("Nombre"))

            Next
            For B = 2004 To Year(Now)
                cmbA.Items.Add(B)
            Next

            For C = 1 To 12
                If C < 10 Then
                    cmbM.Items.Add("0" & C)
                Else
                    cmbM.Items.Add(C)
                End If

            Next


        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
                cCOn.Close()
            End If

            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chbMostrarTodos.CheckedChanged
        If chbMostrarTodos.Checked = False Then
            chbAdeudos.Enabled = True
            chbConsumo.Enabled = True

        Else
            chbAdeudos.Checked = False
            chbConsumo.Checked = False
            chbAdeudos.Enabled = False
            chbConsumo.Enabled = False

        End If

    End Sub

    Private Sub Mostrar_Click(sender As Object, e As EventArgs) Handles Mostrar.Click
        Try
            If cmbRecorrido.SelectedIndex < 0 Then
                MsgBox("No has seleccionado recorrido", MsgBoxStyle.OkOnly, "Recorrido")
                cmbRecorrido.Focus()
                Exit Sub
            End If
            If cmbA.SelectedIndex < 0 Then
                MsgBox("No has seleccionado Año", MsgBoxStyle.OkOnly, "Periodo")
                cmbA.Focus()
                Exit Sub
            End If
            If cmbA.SelectedIndex < 0 Or cmbM.SelectedIndex < 0 Then
                MsgBox("No has seleccionado Mes", MsgBoxStyle.OkOnly, "Periodo")
                cmbA.Focus()
                Exit Sub
            End If
            If hacerConsulta = 1 Then
                realizoConsulta()
                calculoTotales()
                hacerConsulta = 0
                lsErrores.Visible = False
                lsErrores.Items.Clear()
                lbErrores.Visible = False


            End If

            MostrarGrid()


        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try


    End Sub
    Private Sub MostrarGrid()


        For a = grdRecorrido.Rows.Count - 1 To 0 Step -1
            If chbMostrarTodos.Checked = True Then
                grdRecorrido.Rows(a).Visible = True
            Else
                If chbAdeudos.Checked = grdRecorrido.Item("AplicaAdeudos", a).Value And chbConsumo.Checked = grdRecorrido.Item("aplicaconsumo", a).Value Then
                    grdRecorrido.Rows(a).Visible = True
                    'oidRecorridoVigencia = grdRecorrido.Item("aplicaconsumo", a).Value
                Else
                    grdRecorrido.CurrentCell = Nothing

                    grdRecorrido.Rows(a).Visible = False

                End If
            End If

        Next


        'grdRecorrido.Rows(1).Visible = False
        grdRecorrido.Refresh()
    End Sub

    Private Sub cmbRecorrido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRecorrido.SelectedIndexChanged
        If hacerConsulta = 0 Then
            If cmbRecorrido.SelectedItem.ToString <> lbRecorrido.Text Then
                btnAplicaAdeudo.Enabled = False
                btnAplicaConsumo.Enabled = False
                hacerConsulta = 1


            End If
        End If



    End Sub

    Private Sub cmbA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbA.SelectedIndexChanged

        If hacerConsulta = 0 Then
            If cmbA.SelectedItem.ToString <> Mid(lbPeriodo.Text, 1, 4) Then
                btnAplicaAdeudo.Enabled = False
                btnAplicaConsumo.Enabled = False
                hacerConsulta = 1


            End If
        End If
    End Sub

    Private Sub cmbM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbM.SelectedIndexChanged
        If hacerConsulta = 0 Then
            If cmbM.SelectedItem.ToString <> Mid(lbPeriodo.Text, 6, 2) Then
                btnAplicaAdeudo.Enabled = False
                btnAplicaConsumo.Enabled = False
                hacerConsulta = 1


            End If
        End If

    End Sub
    Private Sub realizoConsulta()
        Try
            Dim Sql1 As String
            cCOn.ConnectionString = My.Resources.cdTau

            Sql1 = "select Contrato,Mes,LecturaAnterior,LecturaActual,Consumo,Secuencia,Nombre,AplicaAdeudos ,AplicaConsumo,NoContrato,RecorridoVigencia from uvw_TlqLecturas where nombre = '" & cmbRecorrido.SelectedItem.ToString & "' and mes = '" & cmbA.SelectedItem.ToString & "/" & cmbM.SelectedItem.ToString & "' order by secuencia"
            Dim cmdSql As New SqlCommand(Sql1, cCOn)
            daLecturas.SelectCommand = cmdSql
            dsLecturas.Clear()
            cCOn.Open()
            daLecturas.Fill(dsLecturas, "Recorrido")
            cCOn.Close()



            If dsLecturas.Tables("Recorrido").Rows.Count = 0 Then
                MsgBox("No se encontraron registros", MsgBoxStyle.OkOnly, "Recorrido")
                btnAplicaAdeudo.Enabled = False
                btnAplicaConsumo.Enabled = False

            Else
                grdRecorrido.DataSource = dsLecturas.Tables("Recorrido")
                oidRecorridoVigencia = grdRecorrido.Item("RecorridoVigencia", 0).Value
            End If




        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
                cCOn.Close()
            End If
            MsgBox(Err.Number & " : " & Err.Description)

        End Try

    End Sub
    Private Sub calculoTotales()
        Try
            Dim Total As Integer
            Dim AdeudosGenerados As Integer
            Dim Consumos As Integer
            AdeudosGenerados = 0
            Consumos = 0

            Total = grdRecorrido.Rows.Count

            For a = grdRecorrido.Rows.Count - 1 To 0 Step -1
                If grdRecorrido.Item("AplicaAdeudos", a).Value = True Then
                    AdeudosGenerados = AdeudosGenerados + 1

                End If
                If grdRecorrido.Item("aplicaconsumo", a).Value = True Then
                    Consumos = Consumos + 1
                End If



            Next
            If Total = AdeudosGenerados Then

                btnAplicaAdeudo.Enabled = False
                btnAplicaConsumo.Enabled = False

            Else
                If Consumos = 0 Then
                    btnAplicaConsumo.Enabled = True


                Else
                    If Consumos < Total Then
                        btnAplicaConsumo.Enabled = True
                    End If
                    btnAplicaAdeudo.Enabled = True


                End If
            End If
            lbRecorrido.Text = cmbRecorrido.SelectedItem.ToString
            lbPeriodo.Text = cmbA.SelectedItem.ToString & "/" & cmbM.SelectedItem.ToString
            lbTotalContratos.Text = Total.ToString

            lbAdeudosGenerados.Text = AdeudosGenerados.ToString
            lbConsumos.Text = Consumos.ToString
        Catch ex As Exception

            MsgBox(Err.Number & " : " & Err.Description)

        End Try

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub btnAplicaConsumo_Click(sender As Object, e As EventArgs) Handles btnAplicaConsumo.Click

        Aplicar(1)

        If MsgBox("Proceso Terminado, ¿Desea aplicar los adeudos?", MsgBoxStyle.OkCancel, "Proceso terminado") = 1 Then
            Aplicar(0)
        End If
        realizoConsulta()
        calculoTotales()
        hacerConsulta = 0
        MostrarGrid()

    End Sub
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles btnAplicaAdeudo.Click

        Aplicar(0)

        realizoConsulta()
        calculoTotales()
        hacerConsulta = 0
        MostrarGrid()


    End Sub
    Private Sub Aplicar(Cons As Integer)
        Try
            Dim Sqlaplica As String
            Dim cmdSql1 As New SqlCommand
            Dim SConsumo As String



            Sqlaplica = ""
            cCOn.ConnectionString = My.Resources.cdTau

            If cmbRecorrido.SelectedIndex < 0 Then
                MsgBox("No has seleccionado recorrido", MsgBoxStyle.OkOnly, "Recorrido")
                cmbRecorrido.Focus()
                Exit Sub
            End If
            If cmbA.SelectedIndex < 0 Or cmbM.SelectedIndex < 0 Then
                MsgBox("No has seleccionado periodo", MsgBoxStyle.OkOnly, "Periodo")
                cmbA.Focus()
                Exit Sub
            End If
            If Cons = 1 Then
                SConsumo = "AplicaConsumo"
            Else
                SConsumo = "AplicaAdeudos"
            End If
            If grdRecorrido.Rows.Count = 0 Then
                MsgBox("No se encontraron registros", MsgBoxStyle.OkOnly, "Recorrido")

            Else
                MsgBox("Espere un momento", MsgBoxStyle.Information, "proceso iniciado")
                cCOn.Open()
                cmdSql1.Connection = cCOn
                ProgressBar1.Minimum = 0
                ProgressBar1.Maximum = grdRecorrido.Rows.Count
                habilita(False)

                For a = grdRecorrido.Rows.Count - 1 To 0 Step -1
                    If grdRecorrido.Item(SConsumo, a).Value = False Then
                        Sqlaplica = "exec  usp_AguaSM_GeneraAdeudoindividual " & grdRecorrido.Item("RecorridoVigencia", a).Value.ToString & " , " & grdRecorrido.Item("NoContrato", a).Value.ToString & " , " & Cons.ToString
                        ProgressBar1.Value = grdRecorrido.Rows.Count - a
                        cmdSql1.CommandText = Sqlaplica
                        cmdSql1.CommandTimeout = 2000
                        Try
                            cmdSql1.ExecuteNonQuery()

                        Catch ex As Exception
                            lsErrores.Visible = True
                            lbErrores.Visible = True
                            lsErrores.Items.Add(grdRecorrido.Item("Contrato", a).Value.ToString & " : " & Err.Description)
                        End Try


                    End If
                Next
                Sqlaplica = "exec  usp_AguaSM_GeneraAdeudoPosteriortlq " & grdRecorrido.Item("RecorridoVigencia", 0).Value.ToString & " , " & Cons.ToString
                cmdSql1.CommandText = Sqlaplica
                cmdSql1.CommandTimeout = 2000
                cmdSql1.ExecuteNonQuery()
                cCOn.Close()


                MsgBox("Terminado", MsgBoxStyle.OkOnly, "proceso terminado")

                ProgressBar1.Value = 0

                cambiarOrigenLectura()

                habilita(True)


            End If




        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
                cCOn.Close()
            End If
            MsgBox(Err.Number & " : " & Err.Description)

        End Try
    End Sub





    Private Sub cambiarOrigenLectura()
        Dim Sqlaplica As String
        Dim cmdSql1 As New SqlCommand
        Try
            'Sql1 = "exec dbo.usp_ActualizaLecturasTLQ " & Convert.ToUInt32(txtLecturaNueva.Text) & "," & cveInsidencia & "," & Convert.ToInt32(idrecorridovigenciadetalle)
            Sqlaplica = "exec dbo.usp_AguaSM_CambiaOrigenLectura " & oidRecorridoVigencia

            cmdSql1 = New SqlCommand(Sqlaplica, cCOn)
            cCOn.Open()
            cmdSql1.ExecuteNonQuery()
            cCOn.Close()
        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
            cCOn.Close()
        End If
        MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub
    Private Sub habilita(bHabi As Boolean)

        btnAplicaAdeudo.Enabled = bHabi
        btnAplicaConsumo.Enabled = bHabi
        Mostrar.Enabled = bHabi
        cmbRecorrido.Enabled = bHabi
        cmbA.Enabled = bHabi
        chbAdeudos.Enabled = bHabi
        chbConsumo.Enabled = bHabi
        chbMostrarTodos.Enabled = bHabi

        If bHabi = True Then
            chbMostrarTodos.Checked = True
            chbAdeudos.Checked = False
            chbConsumo.Checked = False
            chbAdeudos.Enabled = False
            chbConsumo.Enabled = False

        End If


    End Sub
End Class
