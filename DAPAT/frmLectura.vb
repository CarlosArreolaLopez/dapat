Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class frmLectura
#Region "Variables"

    Dim cCOn As New SqlConnection
    Dim daLectura As New SqlDataAdapter
    Dim dsLectura As New DataSet
    Dim dsLecturistas As New DataSet
#End Region


    Private Sub frmLectura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cCOn.ConnectionString = My.Resources.cdDAPAT

            Dim cmdSql As New SqlCommand("Select cLetClave_ as Clave, cLetNombre as Nombre from lecturis order by cletNombre", cCOn)
            daLectura.SelectCommand = cmdSql

            cCOn.Open()
            daLectura.Fill(dsLecturistas, "Lecturista")
            cCOn.Close()

            For a = 0 To dsLectura.Tables("Lecturista").Rows.Count

                cmbLecturista.Items.Add(dsLecturistas.Tables("Lecturista").Rows(a).ToString)

            Next

        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

    End Sub
End Class