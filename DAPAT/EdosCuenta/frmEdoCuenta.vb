Imports System.Data.SqlClient

Public Class frmEdoCuenta



#Region "Variables"
    Dim rptPrint As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim cCon As New SqlConnection
    Dim cmdCon As New SqlCommand
    Dim daLecturas As New SqlDataAdapter
    Dim dsLecturas As New DataSet
#End Region
    Private Sub frmEdoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            For Each PrinterName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters()
                lstImpresoras.Items.Add(PrinterName)
            Next

            'rptPrint.Load("C:\Lourdes Guerrero\DAPAT\DAPAT\rptEdoCuentaNvo.rpt")
            rptPrint.Load("C:\DAPAT\DAPAT\rptEdoCuentaNvo.rpt")
            rptPrint.SetDatabaseLogon("usuariocaja", "cajatlq11", "Ingresos", "Ingresos")

            cCon.ConnectionString = My.Resources.cdTau
            cmdCon.Connection = cCon
            cmdCon.CommandType = CommandType.Text
            cmdCon.CommandText = "select Domicilio.NombreColonia as Colonia From Contrato inner join Domicilio on Domicilio.OID = Contrato.Ubicacion where Tipo = 2 group by Domicilio.NombreColonia Order by Domicilio.NombreColonia "

            cCon.Open()
            daLecturas.SelectCommand = cmdCon
            daLecturas.Fill(dsLecturas, "Colonia")

            For a = 0 To dsLecturas.Tables("Colonia").Rows.Count - 1
                cmbColonia.Items.Add(dsLecturas.Tables("Colonia").Rows(a).Item("Colonia").ToString)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cCon.Close()
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If dsLecturas.Tables.Contains("Contratos") Then
                dsLecturas.Tables("Contratos").Clear()
            End If

            'cmdCon.CommandText = "select Contrato.Folio, NombreVialidad = Calle, Exterior, Interior, NombreColonia as Colonia from Contrato inner join Domicilio on Domicilio.OID = Contrato.Ubicacion where exists (select OrigenLectura from RecorridoVigenciadetalle where CONTRATO.OID = RecorridoVigenciadetalle.CONTRATO AND OrigenLectura = 1 and añoefectonuevo = '2020/12') and Tipo = 2 and exists(select cuentadepto from Adeudo where adeudo.CuentaDepto = contrato.Folio) and NombreColonia='" & cmbColonia.Text & "' order by NombreVialidad, Exterior, Interior"
            cmdCon.CommandText = "exec usp_AguaSMConsultaRecorridoImprimeReciboEstimadoAnual '" & cmbColonia.Text & "', '" & txtPeriodo.Text & "'"

            daLecturas.SelectCommand = cmdCon

            cCon.Open()
            daLecturas.Fill(dsLecturas, "Contratos")

            grdContratos.DataSource = dsLecturas
            grdContratos.DataMember = "Contratos"

            grdContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            grdContratos.AutoResizeColumns()
            grdContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells



            lblCuentas.Text = "Estados de cuenta: " & dsLecturas.Tables("Contratos").Rows.Count().ToString()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cCon.Close()
        End Try
    End Sub


    Private Sub ImprimeTicket(ByVal nFila As Integer)
        Try

            rptPrint.SetParameterValue(0, grdContratos.Item(0, nFila).Value.ToString)
            rptPrint.SetParameterValue(1, "03")
            rptPrint.SetParameterValue(2, Format(Now(), "dd/MM/yyyy HH:mm"))
            rptPrint.SetParameterValue(3, txtPeriodo.Text.ToString)
            rptPrint.SetParameterValue(4, grdContratos.Item(0, nFila).Value.ToString)
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
        If grdContratos.SelectedRows.Count = 1 Then
            If MsgBox("¿Desea imprimir el recibo de la cuenta seleccionada?", MsgBoxStyle.YesNo, "Impresión de Recibo") = MsgBoxResult.Yes Then
                ImprimeTicket(grdContratos.CurrentRow.Index)
            End If
        End If

        If grdContratos.SelectedRows.Count > 1 Then
            If MsgBox("¿Desea imprimir los recibos de las cuentas seleccionadas?", MsgBoxStyle.YesNo, "Impresión de Recibo") = MsgBoxResult.Yes Then
                For a = 0 To grdContratos.SelectedRows.Count - 1
                    ImprimeTicket(grdContratos.SelectedRows.Item(a).Index)
                Next
            End If
        End If

        If grdContratos.SelectedRows.Count = 0 Then
            If MsgBox("¿Desea imprimir todos los recibos de la ruta?", MsgBoxStyle.YesNo, "Impresión de Recibo") = MsgBoxResult.Yes Then
                For a = 0 To grdContratos.RowCount - 1
                    ImprimeTicket(a)
                Next

            End If
        End If
    End Sub

    Private Sub cmbColonia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColonia.SelectedIndexChanged

    End Sub

    Private Sub grdContratos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdContratos.CellContentClick

    End Sub

    Private Sub lblCuentas_Click(sender As Object, e As EventArgs) Handles lblCuentas.Click

    End Sub
End Class