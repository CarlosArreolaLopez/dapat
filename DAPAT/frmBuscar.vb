Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient



Public Class frmBuscar
#Region "Variables"

    Dim cCOn As New SqlConnection
    Dim daLecturas As New SqlDataAdapter
    Dim dsLecturas As New DataSet
    Public sOpcion As String

#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Buscar " & sOpcion

        sRespuesta = ""



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        sRespuesta = ""
        If cCOn.State = ConnectionState.Open Then
            cCOn.Close()
        End If
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim sSql As String


            cCOn.ConnectionString = My.Resources.cdTau

            sSql = " select  nombre" & sOpcion & " from " & sOpcion & " where nombre" & sOpcion & " like '%" & txtCalle.Text & "%' order by nombre" & sOpcion
            Dim cmdSql As New SqlCommand(sSql, cCOn)
            daLecturas.SelectCommand = cmdSql

            dsLecturas.Clear()

            cCOn.Open()
            daLecturas.Fill(dsLecturas, "Busqueda")
            cCOn.Close()



            If dsLecturas.Tables("Busqueda").Rows.Count = 0 Then
                MsgBox("No se encontro " & sOpcion & " con los datos proporcionados", MsgBoxStyle.OkOnly, sOpcion)


            Else
                grdBusqueda.DataSource = dsLecturas.Tables("Busqueda")
            End If




        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
                cCOn.Close()
            End If
            MsgBox(Err.Number & " : " & Err.Description)

        End Try

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If grdBusqueda.SelectedRows.Count = 1 Then
            sRespuesta = grdBusqueda.CurrentRow.Cells("nombre" & sOpcion).Value.ToString
            Me.Close()
        Else
            MsgBox("No ha seleccionado " & sOpcion, MsgBoxStyle.OkOnly, "Seleccion")
        End If



    End Sub
End Class