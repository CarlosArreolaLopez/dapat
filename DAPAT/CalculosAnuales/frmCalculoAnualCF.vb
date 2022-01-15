Imports System.Data.SqlClient

Public Class frmCalculoAnualCF
#Region "Variables"
    Dim cCon As New SqlConnection
    Dim daCalculo As New SqlDataAdapter
    Dim dsCalculo As New DataSet

    Dim nAno As Integer

    Dim cmdCom As New SqlCommand

#End Region

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try


            If dsCalculo.Tables.Contains("Contratos") Then
                dsCalculo.Tables("Contratos").Clear()
            End If


            If IsNumeric(txtAnio.Text) Then
                nAno = txtAnio.Text
            End If

            cmdCom.CommandText = "Select Contrato as Cuenta, cContipTar as Tarifa from contratos where escuotafija = '1' and cancelado = '0'"


            daCalculo.SelectCommand = cmdCom

            daCalculo.Fill(dsCalculo, "Contratos")



            grdContratos.DataSource = dsCalculo.Tables("Contratos")






        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub

    Private Sub frmCalculoAnualCF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            cCon.ConnectionString = My.Resources.cdDAPAT

            cmdCom.Connection = cCon



        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub
End Class