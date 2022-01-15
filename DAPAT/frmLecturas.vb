Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
'Imports CrystalDecisions.Shared

Public Class frmLecturas
#Region "Variables"

    Dim cCOn As New SqlConnection
    Dim daLecturas As New SqlDataAdapter
    Dim dsLecturas As New DataSet

    Dim sRutaExe As String

    Dim rptPrint As New CrystalDecisions.CrystalReports.Engine.ReportDocument

#End Region

    Private Sub frmLecturas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try

            If e.KeyData = Keys.Escape And btnImprimir.Enabled = True Then

                ImprimeTicket(1)

            End If

        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)

        End Try
    End Sub

    Private Sub frmLecturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            sRutaExe = "C:\DAPAT\dapat"

            cCOn.ConnectionString = My.Resources.cdTau

            Dim cmdSql As New SqlCommand("Select distinct oid, nombre from Recorrido order by nombre", cCOn)
            daLecturas.SelectCommand = cmdSql

            cCOn.Open()
            daLecturas.Fill(dsLecturas, "Rutas")
            cCOn.Close()


            rptPrint.Load(sRutaExe & "\rptEdoCuenta.rpt")
            rptPrint.SetDatabaseLogon("usuariocaja", "cajatlq11", "Ingresos", "Ingresos")


            For A = 0 To dsLecturas.Tables("Rutas").Rows.Count - 1

                cmbRuta.Items.Add(dsLecturas.Tables("Rutas").Rows(A).Item("Nombre"))

            Next

            For B = 2004 To Year(Now)
                cmbAño.Items.Add(B)
            Next

            For C = 1 To 12
                If C < 10 Then
                    cmbMes.Items.Add("0" & C)
                Else
                    cmbMes.Items.Add(C)
                End If

            Next

            For Each PrinterName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters()
                lstImpresoras.Items.Add(PrinterName)
            Next


        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
                cCOn.Close()
            End If

            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            btnImprimir.Enabled = False
            Dim Sql1 As String
            cCOn.ConnectionString = My.Resources.cdIng

            Sql1 = "select * from uvw_TLQ_Lecturasnuevo where Ruta = '" & cmbRuta.SelectedItem & "' and Año = " & cmbAño.SelectedItem & " and Mes = '" & cmbMes.SelectedItem.ToString & "' order by SECUENCIA"
            Dim cmdSql As New SqlCommand(Sql1, cCOn)
            daLecturas.SelectCommand = cmdSql

            dsLecturas.Clear()

            cCOn.Open()
            daLecturas.Fill(dsLecturas, "Ruta")

            cCOn.Close()

            If dsLecturas.Tables("Ruta").Rows.Count = 0 Then
                MsgBox("No se encontraron registros", MsgBoxStyle.OkOnly, "Ruta") '= MsgBoxResult.Yes Then

                'Dim nRegistros As Integer

                'Dim cmdCargaRuta As New SqlCommand("dbo.usp_TLQ_CargaInicialRuta", cCOn)
                'cmdCargaRuta.CommandType = CommandType.StoredProcedure
                'cmdCargaRuta.Parameters.AddWithValue("@Vigencia", cmbAño.SelectedItem)
                'cmdCargaRuta.Parameters.AddWithValue("@Mes", cmbMes.SelectedItem.ToString)
                'cmdCargaRuta.Parameters.AddWithValue("@Ruta", cmbRuta.SelectedItem)

                'cCOn.Open()
                'cmdCargaRuta.CommandTimeout = 250
                'nRegistros = cmdCargaRuta.ExecuteNonQuery()
                'cCOn.Close()

                'MsgBox(nRegistros & " registros cargados.")

                'Else
                '    Exit Sub
                'End If
            End If
            grdRuta.DataSource = dsLecturas.Tables("Ruta")
            TxtTotalCuentas.Text = Convert.ToString(grdRuta.Rows.Count)

            btnImprimir.Enabled = True
        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
                cCOn.Close()
            End If

            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub

    Private Sub btnCarga_Click(sender As Object, e As EventArgs) Handles btnCarga.Click
        Try
            Dim f As New frmLectura
            f.Parent = Me
            f.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub ImprimeTicket(ByVal nFila As Integer)
        Try

            rptPrint.SetParameterValue(0, grdRuta.Item(2, nFila).Value.ToString)
            rptPrint.SetParameterValue(1, "03")
            rptPrint.SetParameterValue(2, Format(Now(), "dd/MM/yyyy HH:mm"))
            rptPrint.SetParameterValue(3, grdRuta.Item(3, nFila).Value.ToString)
            rptPrint.SetParameterValue(4, grdRuta.Item(2, nFila).Value.ToString)
            rptPrint.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            rptPrint.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait

            rptPrint.PrintOptions.PrinterName = lstImpresoras.SelectedItem.ToString
            rptPrint.PrintToPrinter(1, False, 1, 1)

        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
                cCOn.Close()
            End If

            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try

            If grdRuta.SelectedRows.Count = 1 Then
                If MsgBox("¿Desea imprimir el recibo de la cuenta seleccionada?", MsgBoxStyle.YesNo, "Impresión de Recibo") = MsgBoxResult.Yes Then
                    ImprimeTicket(grdRuta.CurrentRow.Index)
                End If
            End If

            If grdRuta.SelectedRows.Count > 1 Then
                If MsgBox("¿Desea imprimir los recibos de las cuentas selccionadas?", MsgBoxStyle.YesNo, "Impresión de Recibo") = MsgBoxResult.Yes Then
                    For a = grdRuta.SelectedRows.Count - 1 To 0 Step -1
                        ImprimeTicket(grdRuta.SelectedRows.Item(a).Index)
                    Next
                End If
            End If
            'If grdRuta.SelectedRows.Count > 1 Then
            '    If MsgBox("¿Desea imprimir los recibos de las cuentas selccionadas?", MsgBoxStyle.YesNo, "Impresión de Recibo") = MsgBoxResult.Yes Then
            '        For a = 0 To grdRuta.SelectedRows.Count - 1
            '            ImprimeTicket(grdRuta.SelectedRows.Item(a).Index)
            '        Next
            '    End If
            'End If
            If grdRuta.SelectedRows.Count = 0 Then
                If MsgBox("¿Desea imprimir todos los recibos de la ruta?", MsgBoxStyle.YesNo, "Impresión de Recibo") = MsgBoxResult.Yes Then
                    For a = 0 To grdRuta.RowCount - 1
                        ImprimeTicket(a)
                    Next

                End If
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Function NombreArchivo(sNombre As String, sTipo As String) As String
        Try
            Dim sNomArchivo As String

            If dlgCarpeta.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                NombreArchivo = ""
                Exit Function
            End If

            'Archivo Ingreso
            sNomArchivo = "\" & sNombre & "_." & sTipo
            NombreArchivo = dlgCarpeta.SelectedPath & sNomArchivo

        Catch ex As Exception

            NombreArchivo = ""
        End Try
    End Function

    Private Sub grdRuta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRuta.CellContentClick

    End Sub

    Private Sub cmbRuta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRuta.SelectedIndexChanged

    End Sub

    Private Sub lblRuta_Click(sender As Object, e As EventArgs) Handles lblRuta.Click

    End Sub
End Class
