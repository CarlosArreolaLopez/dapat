Imports System.Windows.Forms

Public Class mdiMain

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LecturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LecturasToolStripMenuItem.Click
        Try
            Dim f As New frmLecturas
            f.MdiParent = Me
            f.Show()
        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Try
            Dim f As New frmAbout
            f.ShowDialog()
        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub

    Private Sub CuotaFijaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuotaFijaToolStripMenuItem.Click
        Try
            Dim f As New frmCalculoAnualCF
            f.MdiParent = Me
            f.Show()
        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub

    Private Sub CuotaFijaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CuotaFijaToolStripMenuItem1.Click
        Try
            Dim f As New frmImpresionCuotaFija
            f.MdiParent = Me
            f.Show()
        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub

    Private Sub EstadoCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoCuentaToolStripMenuItem.Click
        Try
            Dim f As New frmEdoCuenta
            f.MdiParent = Me
            f.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AplicarRecorridosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplicarRecorridosToolStripMenuItem.Click

        Try
            Dim f As New frmAplicoRecorrido
            f.MdiParent = Me
            f.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub CreacionDomiciliosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreacionDomiciliosToolStripMenuItem.Click


    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Try
            Dim f As New Domicilio
            f.MdiParent = Me
            f.iNuevo = 1

            f.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Try
            Dim f As New Domicilio
            f.MdiParent = Me
            f.iNuevo = 0

            f.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CapturaLecturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaLecturasToolStripMenuItem.Click
        Try
            Dim f As New frmCapturaLecturas
            f.MdiParent = Me
            f.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub mdiMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ContratosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratosToolStripMenuItem.Click

    End Sub

    Private Sub NuevaSolicitudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaSolicitudToolStripMenuItem.Click

    End Sub

    Private Sub AdeudoEstimadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdeudoEstimadoToolStripMenuItem.Click
        Try
            Dim f As New frmEstimadoAnual
            'f.MdiParent = Me
            f.ShowDialog()
        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub
End Class
