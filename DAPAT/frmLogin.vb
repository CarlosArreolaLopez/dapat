
Imports System.Data.SqlClient

Public Class frmLogin
#Region "Variables"
    Dim cCon As New SqlConnection
    Dim dsUsuarios As New DataSet
    Dim daUsuarios As New SqlDataAdapter

#End Region

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try

            dsUsuarios.Clear()

            If txtUsuario.Text.Length < 1 Then
                MsgBox("Ingrese un nombre se usuario valido")

                txtUsuario.Focus()
                Exit Sub
            End If

            daUsuarios.SelectCommand.Parameters("@Usuario").Value = txtUsuario.Text

            cCon.Open()
            daUsuarios.Fill(dsUsuarios, "Usuarios")
            cCon.Close()

            If dsUsuarios.Tables("Usuarios").Rows.Count < 1 Then
                MsgBox("Usuario o contraseña no valida")
                txtUsuario.Focus()
                Exit Sub
            End If

            If txtPass.Text = Desencriptar(dsUsuarios.Tables("Usuarios").Rows(0).Item("cUsuPasswo").ToString) Then
                nUsuario = dsUsuarios.Tables("Usuarios").Rows(0).Item("NUSUNUMERO").ToString
                sUsuario = dsUsuarios.Tables("Usuarios").Rows(0).Item("CUSUNOMBRE").ToString
                mdiMain.Show()
                Me.Close()
            Else
                MsgBox("Usuario o contraseña no valida")
                txtUsuario.Focus()
            End If


        Catch ex As Exception

            If cCon.State = ConnectionState.Open Then
                cCon.Close()
            End If

            MsgBox(Err.Number & " : " & Err.Description)

        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cCon.ConnectionString = My.Resources.cdDAPAT

            Dim cmdUsuarios As New SqlCommand("Select * from USUAAGUA where Usuario = @Usuario ", cCon)
            daUsuarios.SelectCommand = cmdUsuarios
            daUsuarios.SelectCommand.Parameters.Add("@Usuario", SqlDbType.VarChar)

        Catch ex As Exception
            MsgBox(Err.Number & " : " & Err.Description)
        End Try
    End Sub

    Private Function Desencriptar(sCadena As String)
        Dim sCaracterx As String, sConcatenado As String
        Dim nContador As Integer

        sConcatenado = ""
        For nContador = 1 To Len(sCadena)

            sCaracterx = Chr((Asc(Mid$(sCadena, nContador, 1)) - nContador + 256) Mod 256)
            sConcatenado = sConcatenado & sCaracterx

        Next nContador


        Desencriptar = sConcatenado
    End Function
End Class
