Imports System.Data.SqlClient
Public Class frmEstimadoAnual
    Private Const CmdText As String = "sp_dapat2_eliminaEstimadoanual"
#Region "Variables"
    Dim rptPrint As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim ccon As New SqlConnection
    Dim cmdCon As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
#End Region

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles toolTotal.Click

    End Sub

    Private Sub frmEstimadoAnual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiaform()

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ActualizarDatos()
    End Sub
    Private Sub TraerAdeudo()
        dgAdeudos.DataSource = Nothing
        If ds.Tables.Contains("Adeudos") Then
            ds.Tables("Adeudos").Clear()
        End If
        ccon.ConnectionString = My.Resources.cdTau
        Dim sqlCmd As New SqlCommand("sp_dapat2_consultaEstimadoanual", ccon)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@cuenta", SqlDbType.Text).Value = txtCuenta.Text.Trim
        da.SelectCommand = sqlCmd
        Try
            ccon.Open()
            sqlCmd.ExecuteNonQuery()
            da.Fill(ds, "Adeudos")
            ccon.Close()
            dgAdeudos.DataSource = ds.Tables("Adeudos")
            dgAdeudos.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dim Total As Single
            Dim Col As Integer = Me.dgAdeudos.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.dgAdeudos.Rows
                Total += Val(row.Cells("Importe").Value)
            Next
            Me.toolTotal.Text = "Estimado anual total: " & Format(Total, "$ #,##0.00").ToString
        Catch ex As Exception
            If ccon.State = ConnectionState.Open Then
                ccon.Close()
                dgAdeudos.DataSource = Nothing
            End If
            MsgBox(Err.Number & " : " & Err.Description)
        End Try

    End Sub


    Private Sub Traercontribuyente()
        'MessageBox.Show(txtCuenta.Text)
        ccon.ConnectionString = My.Resources.cdTau
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim sqlCmd As New SqlCommand("sp_dapat2_consultacontribuyente", ccon)
        If ds.Tables.Contains("Contribuyente") Then
            ds.Tables("Contribuyente").Clear()
        End If
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@cuenta", SqlDbType.Text).Value = txtCuenta.Text.Trim
        da.SelectCommand = sqlCmd
        Try
            ccon.Open()
            sqlCmd.ExecuteNonQuery()
            da.Fill(ds, "Contribuyente")
            ccon.Close()
            ' Llenar campos 
            lblContribuyente.Text = ds.Tables("Contribuyente").Rows(0).Item("NombreCompleto").ToString
            lblDomicilio.Text = ds.Tables("Contribuyente").Rows(0).Item("Domicilio").ToString
        Catch ex As Exception
            If ccon.State = ConnectionState.Open Then
                ccon.Close()
            End If
            MsgBox(Err.Number & " : " & Err.Description)
        End Try


    End Sub
    Sub limpiaform()
        statustool.Text = ""
        txtCuenta.Text = ""
        lblContribuyente.Text = ""
        lblDomicilio.Text = ""
        dgAdeudos.DataSource = Nothing
        toolTotal.Text = ""
        txtCuenta.Focus()
    End Sub

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiaform()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If Not txtCuenta.Text = "" Then
            ' Dim dr As DialogResult = MessageBox.Show("Desea eliminar adeudo estimado?", "DAPAT", MessageBoxButtons.YesNo)

            'If dr = DialogResult.Yes Then
            'MessageBox.Show(dr.ToString())
            EliminaEstimado()
            'Else

            'End If
        Else
        End If
        limpiaform()

    End Sub
    Sub ActualizarDatos()
        If txtCuenta.Text = "" Or txtCuenta.TextLength < 8 Then
            txtCuenta.SelectAll()
            txtCuenta.Focus()
        Else
            Traercontribuyente()
            TraerAdeudo()
        End If
    End Sub
    Private Sub EliminaEstimado()
        ccon.ConnectionString = My.Resources.cdTau
        'MessageBox.Show("sp_dapat2_eliminaEstimadoanual '" & txtCuenta.Text & "'")
        Dim sqlCmd As New SqlCommand("sp_dapat2_eliminaEstimadoanual '" & txtCuenta.Text & "'", ccon)
        sqlCmd.CommandType = CommandType.Text
        'sqlCmd.Parameters.Add("@cuenta", SqlDbType.VarChar).Value = txtCuenta.Text
        da.SelectCommand = sqlCmd
        Try
            ccon.Open()
            sqlCmd.ExecuteNonQuery()
            ccon.Close()
        Catch ex As Exception
            If ccon.State = ConnectionState.Open Then
                ccon.Close()
            End If
            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub
End Class