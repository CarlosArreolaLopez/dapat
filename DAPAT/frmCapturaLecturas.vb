Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException

Public Class frmCapturaLecturas

#Region "Variables"
    Dim cadena As String = (My.Resources.cdTau) '"Data Source=DOMAINADMINS73;Initial Catalog=Nomina;Integrated Security=True"
    Dim varconexion As New SqlConnection(cadena)
    Dim cmd, cmdSql As New SqlCommand
    Dim cCOn As New SqlConnection
    Dim Sql1 As String
    Dim daLecturas As New SqlDataAdapter
    Dim dsLecturas As New DataSet
    Dim hacerConsulta, idrecorridovigenciadetalle, oidrecorridovigenciadetalle As Integer
    Dim LecturaNva, LecturaAnt, ConsumoAnterior As Integer
    Dim Msg, Style, Title, Respuesta As String
    Dim consumoPorcentaje As Double
    Dim renglon, i, filas, cveInsidencia, lectura As Integer
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cCOn.ConnectionString = My.Resources.cdTau
        hacerConsulta = 1
        btnGuardarLectura.Enabled = False
        Dim cmdSql As New SqlCommand("Select distinct oid, nombre from Recorrido order by nombre", cCOn)
        daLecturas.SelectCommand = cmdSql
        Try

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
            llenaInsidencias()
            cmbRecorrido.Focus()

        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
                cCOn.Close()
            End If

            MsgBox(Err.Number & " : " & Err.Description)
        End Try

    End Sub

    Private Sub cmbRecorrido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRecorrido.SelectedIndexChanged
        'If hacerConsulta = 0 Then
        ' If cmbRecorrido.SelectedItem.ToString <> lbRecorrido.Text Then
        'btnAplicaAdeudo.Enabled = False
        'btnAplicaConsumo.Enabled = False
        hacerConsulta = 1


        'End If
        'End If


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Application.Exit()
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
            'If hacerConsulta = 1 Then
            realizoConsulta()
            'hacerConsulta = 0
            'End If
        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try

        'MostrarGrid()

    End Sub

    Private Sub realizoConsulta()
        Try
            'Dim Sql1 As String
            cCOn.ConnectionString = My.Resources.cdTau
            Sql1 = "select  nombre, Contrato, Vigencia, Secuencia, Mes, LecturaAnterior, ConsumoPromedioMensual, LecturaNueva, Insidencia, RecorridoVigencia, RegistroLectura from uvw_Tlq_CapturaLecturas where nombre = '" & cmbRecorrido.SelectedItem.ToString & "' and mes = '" & cmbA.SelectedItem.ToString & "/" & cmbM.SelectedItem.ToString & "' order by secuencia"
            Dim cmdSql As New SqlCommand(Sql1, cCOn)
            daLecturas.SelectCommand = cmdSql
            dsLecturas.Clear()
            cCOn.Open()
            'Dim DT = New DataTable(Sql1)
            daLecturas.Fill(dsLecturas, "Recorrido")
            cCOn.Close()

            If dsLecturas.Tables("Recorrido").Rows.Count = 0 Then
                MsgBox("No se encontraron registros", MsgBoxStyle.OkOnly, "Recorrido")

            Else
                grdRecorrido.DataSource = dsLecturas.Tables("Recorrido")
                grdRecorrido.AutoResizeColumns()
                grdRecorrido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'grdRecorrido.DataSource = DT
                'capturaLecturas()
            End If

        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
                cCOn.Close()
            End If
            MsgBox(Err.Number & " : " & Err.Description)

        End Try

    End Sub

    Private Sub llenaInsidencias()
        cCOn.ConnectionString = My.Resources.cdTau

        Dim cmdSql As New SqlCommand("Select OID, Descripcion FROM IncidenciaAgua WHERE  Activa = 1 order by Descripcion", cCOn)
        daLecturas.SelectCommand = cmdSql
        Try

            cCOn.Open()
            daLecturas.Fill(dsLecturas, "InsidenciaAgua")
            cCOn.Close()


            For A = 0 To dsLecturas.Tables("InsidenciaAgua").Rows.Count - 1

                cmbInsidencias.Items.Add(dsLecturas.Tables("InsidenciaAgua").Rows(A).Item("Descripcion"))

            Next
        Catch ex As Exception
            If cCOn.State = ConnectionState.Open Then
                cCOn.Close()
            End If
            MsgBox(Err.Number & " : " & Err.Description)

        End Try

    End Sub

    Private Sub cmbInsidencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInsidencias.SelectedIndexChanged
        buscaInsidencia()
    End Sub

    Private Sub grdRecorrido_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRecorrido.CellClick

        btnGuardarLectura.Enabled = True
        txtLecturaAnterior.Text = Convert.ToUInt32(grdRecorrido.SelectedCells.Item(5).Value)
        txtConsumoAnterior.Text = Convert.ToUInt32(grdRecorrido.SelectedCells.Item(6).Value)
        idrecorridovigenciadetalle = grdRecorrido.SelectedCells.Item(9).Value
        oidrecorridovigenciadetalle = grdRecorrido.SelectedCells.Item(10).Value
        txtLecturaNueva.Focus()

    End Sub

    Private Sub txtLecturaNueva_LostFocus(sender As Object, e As EventArgs) Handles txtLecturaNueva.LostFocus
        LecturaAnt = Convert.ToInt32(txtLecturaAnterior.Text)
        LecturaNva = Convert.ToInt32(txtLecturaNueva.Text)
        ConsumoAnterior = Convert.ToInt32(txtConsumoAnterior.Text)
        If LecturaNva < LecturaAnt Then
            Msg = "Lectura Actual debe ser mayor o igual a Lectura Anterior"
            Style = vbYesNo + vbQuestion + vbDefaultButton2
            Title = "Validar Lecturas (Si = Acepta Lectura / No = Modificar Lectura)"
            Respuesta = MsgBox(Msg, Style, Title)
            If Respuesta = vbNo Then
                txtLecturaNueva.Focus()
            Else
                cmbInsidencias.Focus()
            End If
        End If
    End Sub

    Private Sub btnGuardarLectura_Click(sender As Object, e As EventArgs) Handles btnGuardarLectura.Click
        grabarlectura()
    End Sub

    Private Sub capturaLecturas()

        If grdRecorrido.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In grdRecorrido.Rows
                If Not Fila Is Nothing Then
                    btnGuardarLectura.Enabled = True
                    txtLecturaAnterior.Text = grdRecorrido.SelectedCells.Item(5).Value
                    txtConsumoAnterior.Text = grdRecorrido.SelectedCells.Item(6).Value
                    idrecorridovigenciadetalle = grdRecorrido.SelectedCells.Item(9).Value
                    txtLecturaNueva.Focus()

                End If
            Next
        End If

    End Sub

    Private Sub grabarlectura()
        If cveInsidencia = 0 And (LecturaNva < LecturaAnt) Then
            Msg = "Debe haber Insidencia cuando Lectura Actual sea menor o igual a Lectura Anterior"
            Style = vbOKOnly + vbQuestion + vbDefaultButton1
            Title = "Validar Insidencias"
            Respuesta = MsgBox(Msg, Style, Title)
            cmbInsidencias.Focus()
        Else
            Try
                Sql1 = "exec dbo.usp_ActualizaLecturasTLQ " & Convert.ToUInt32(txtLecturaNueva.Text) & "," & cveInsidencia & "," & Convert.ToInt32(idrecorridovigenciadetalle) & "," & Convert.ToInt32(oidrecorridovigenciadetalle)
                cmdSql = New SqlCommand(Sql1, cCOn)
                cCOn.Open()
                cmdSql.ExecuteNonQuery()
                cCOn.Close()
            Catch ex As Exception
                If cCOn.State = ConnectionState.Open Then
                    cCOn.Close()
                End If
                MsgBox(Err.Number & " : " & Err.Description)
            End Try
        End If
        realizoConsulta()
        btnGuardarLectura.Enabled = False
        limpiar()
    End Sub

    Private Sub limpiar()
        txtConsumoAnterior.Clear()
        txtLecturaAnterior.Clear()
        txtLecturaNueva.Clear()

    End Sub

    Private Sub buscaInsidencia()
        'Dim Sql1 As String
        cCOn.ConnectionString = My.Resources.cdTau
        Sql1 = "Select OID FROM IncidenciaAgua WHERE  Descripcion = '" & cmbInsidencias.SelectedItem.ToString & "'"
        Dim cmdSql As New SqlCommand(Sql1, cCOn)
        Dim tabla As DataTable
        daLecturas = New SqlDataAdapter(Sql1, cCOn)
        tabla = New DataTable()
        daLecturas.Fill(tabla)
        cveInsidencia = tabla.Rows(0)("OID").ToString()

    End Sub

End Class
