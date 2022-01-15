Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Public Class frmAuditorias
#Region "Variables"
    Dim cadena As String = (My.Resources.cdTau)
    Dim varconexion As New SqlConnection(cadena)
    Dim cmd, cmdSql As New SqlCommand
    Dim cConn As New SqlConnection
    Dim Sql1 As String
    Dim daLecturas As New SqlDataAdapter
    Dim dsLecturas As New DataSet
    Dim hacerConsulta, idrecorridovigenciadetalle, oidrecorridovigenciadetalle As Integer
    Dim LecturaNva, LecturaAnt, ConsumoAnterior As Integer

    Private Sub txtCuenta_Leave(sender As Object, e As EventArgs) Handles txtCuenta.Leave
        Traercontribuyente()
        TraerAdeudo()
    End Sub

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged

    End Sub

    Dim Msg, Style, Title, Respuesta As String

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

    End Sub

    Private Sub lnkDMedidor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDMedidor.LinkClicked
        Dim f = New dlgMedidor
        f.ShowDialog()

    End Sub

    Dim consumoPorcentaje As Double
    Dim renglon, i, filas, cveInsidencia, lectura As Integer
#End Region
    Private Sub frmAuditorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
    Private Sub Traercontribuyente()
        cConn.ConnectionString = My.Resources.cdTau
        Dim daContribuyente As New SqlDataAdapter
        Dim dsContribuyente As New DataSet
        Dim sqlCmd As New SqlCommand("sp_dapat2_consultacontribuyente", cConn)

        If dsContribuyente.Tables.Contains("Contribuyente") Then
            dsContribuyente.Tables("Contribuyente").Clear()
        End If

        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@cuenta", SqlDbType.Text).Value = txtCuenta.Text.Trim
        daContribuyente.SelectCommand = sqlCmd
        Try
            cConn.Open()
            sqlCmd.ExecuteNonQuery()
            daContribuyente.Fill(dsContribuyente, "Contribuyente")
            cConn.Close()
            ' Llenar campos 
            lnkContribuyente.Text = dsContribuyente.Tables("Contribuyente").Rows(0).Item("NombreCompleto").ToString
            lnkDomicilio.Text = dsContribuyente.Tables("Contribuyente").Rows(0).Item("Domicilio").ToString
            lnkDMedidor.Text = dsContribuyente.Tables("Contribuyente").Rows(0).Item("NumeroSerie").ToString

        Catch ex As Exception
            If cConn.State = ConnectionState.Open Then
                cConn.Close()
            End If
            MsgBox(Err.Number & " : " & Err.Description)
        End Try


    End Sub
    Private Sub TraerAdeudo()
        dgAdeudos.DataSource = Nothing
        If dsLecturas.Tables.Contains("Adeudos") Then
            dsLecturas.Tables("Adeudos").Clear()
        End If
        cConn.ConnectionString = My.Resources.cdTau
        Dim sqlCmd As New SqlCommand("sp_dapat2_AudAdeudosXcuenta", cConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@cuenta", SqlDbType.Text).Value = txtCuenta.Text.Trim
        daLecturas.SelectCommand = sqlCmd
        Try
            cConn.Open()
            sqlCmd.ExecuteNonQuery()

            daLecturas.Fill(dsLecturas, "Adeudos")
            cConn.Close()
            dgAdeudos.DataSource = dsLecturas.Tables("Adeudos")
        Catch ex As Exception
            If cConn.State = ConnectionState.Open Then
                cConn.Close()
                dgAdeudos.DataSource = Nothing
            End If
            MsgBox(Err.Number & " : " & Err.Description)
        End Try

    End Sub


End Class