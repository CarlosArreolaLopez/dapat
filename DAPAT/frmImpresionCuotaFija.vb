Imports System.Data.SqlClient

Public Class frmImpresionCuotaFija
#Region "Variables"

    Dim cCOn As New SqlConnection
    Dim cmdCon As New SqlCommand
    Dim daLecturas As New SqlDataAdapter
    Dim dsContratos As New DataSet

    Dim sRutaExe As String

    Dim rptPrint As New CrystalDecisions.CrystalReports.Engine.ReportDocument

#End Region

    Private Sub frmImpresionCuotaFija_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each PrinterName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters()
                lstImpresoras.Items.Add(PrinterName)
            Next
            sRutaExe = "C:\DAPAT\Reportes"
            cCOn.ConnectionString = My.Resources.cdDAPAT

            '--------------------------
            cCOn.ConnectionString = My.Resources.cdTau
            cmdCon.Connection = cCOn
            cmdCon.CommandType = CommandType.Text
            cmdCon.CommandText = "select Domicilio.NombreColonia as Colonia From Contrato inner join Domicilio on Domicilio.OID = Contrato.Ubicacion where Tipo = 2 group by Domicilio.NombreColonia Order by Domicilio.NombreColonia "

            cCOn.Open()
            daLecturas.SelectCommand = cmdCon
            daLecturas.Fill(dsContratos, "Colonia")

            For a = 0 To dsContratos.Tables("Colonia").Rows.Count - 1
                cmbColonia.Items.Add(dsContratos.Tables("Colonia").Rows(a).Item("Colonia").ToString)
            Next
            '--------------------------



            rptPrint.Load(sRutaExe & "\rptDetalleCuentaCF.rpt")
            rptPrint.SetDatabaseLogon("usuariocaja", "cajatlq11", "Ingresos", "Ingresos")
            ' Call CargaDatos()
            cCOn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargaDatos()
        Try

            If dsContratos.Tables.Contains("Carga") Then
                dsContratos.Tables("Carga").Clear()
            End If
            'sp_dapat_AguaCFConsultaImprimeReciboEstimadoAnual
            Dim cmdSql As New SqlCommand("Select * from cfimpresion where impresion = '0' order by colonia, domicilio, exterior, interior", cCOn)
            daLecturas.SelectCommand = cmdSql

            cCOn.Open()
            daLecturas.Fill(dsContratos, "Carga")
            cCOn.Close()

            grdCF.DataSource = dsContratos
            grdCF.DataMember = "Carga"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargaDatos2()
        Try
            If dsContratos.Tables.Contains("Contratos") Then
                dsContratos.Tables("Contratos").Clear()
            End If

            'cmdCon.CommandText = "select Contrato.Folio, NombreVialidad = Calle, Exterior, Interior, NombreColonia as Colonia from Contrato inner join Domicilio on Domicilio.OID = Contrato.Ubicacion where exists (select OrigenLectura from RecorridoVigenciadetalle where CONTRATO.OID = RecorridoVigenciadetalle.CONTRATO AND OrigenLectura = 1 and añoefectonuevo = '2020/12') and Tipo = 2 and exists(select cuentadepto from Adeudo where adeudo.CuentaDepto = contrato.Folio) and NombreColonia='" & cmbColonia.Text & "' order by NombreVialidad, Exterior, Interior"
            cmdCon.CommandText = "exec sp_dapat_AguaCFConsultaImprimeReciboEstimadoAnual '" & cmbColonia.Text & "'"

            daLecturas.SelectCommand = cmdCon

            cCOn.Open()
            daLecturas.Fill(dsContratos, "Contratos")

            grdCF.DataSource = dsContratos
            grdCF.DataMember = "Contratos"

            grdCF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            grdCF.AutoResizeColumns()
            grdCF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells



            lblCuentas.Text = "Estados de cuenta: " & dsContratos.Tables("Contratos").Rows.Count().ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cCOn.Close()
        End Try
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            If grdCF.SelectedRows.Count = 1 Then
                If MsgBox("¿Desea imprimir el recibo de la cuenta seleccionada?", MsgBoxStyle.YesNo, "Impresión de Recibo") = MsgBoxResult.Yes Then
                    ImprimeTicket(grdCF.CurrentRow.Index)
                End If
            End If
            If grdCF.SelectedRows.Count > 1 Then
                If MsgBox("¿Desea imprimir los recibos de las cuentas selccionadas?", MsgBoxStyle.YesNo, "Impresión de Recibo") = MsgBoxResult.Yes Then
                    For a = 0 To grdCF.SelectedRows.Count - 1
                        ImprimeTicket(grdCF.SelectedRows.Item(a).Index)
                    Next
                End If
            End If

            If grdCF.SelectedRows.Count = 0 Then
                If MsgBox("¿Desea imprimir todos los recibos de la ruta?", MsgBoxStyle.YesNo, "Impresión de Recibo") = MsgBoxResult.Yes Then
                    For a = 0 To grdCF.RowCount - 1
                        ImprimeTicket(a)
                    Next

                End If
            End If

            MsgBox("Terminado")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ImprimeTicket(ByVal nFila As Integer)
        Try


            rptPrint.SetParameterValue(0, grdCF.Item(0, nFila).Value.ToString)
            rptPrint.SetParameterValue(1, grdCF.Item(0, nFila).Value.ToString)
            rptPrint.SetParameterValue(2, "03")
            rptPrint.SetParameterValue(3, Format(Now(), "dd/MM/yyyy HH:mm"))
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call CargaDatos2()
    End Sub
End Class