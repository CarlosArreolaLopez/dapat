<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLecturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbRuta = New System.Windows.Forms.ComboBox()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.grdRuta = New System.Windows.Forms.DataGridView()
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCarga = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.dlgCarpeta = New System.Windows.Forms.FolderBrowserDialog()
        Me.lstImpresoras = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTotalCuentas = New System.Windows.Forms.TextBox()
        CType(Me.grdRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbRuta
        '
        Me.cmbRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRuta.FormattingEnabled = True
        Me.cmbRuta.Location = New System.Drawing.Point(12, 24)
        Me.cmbRuta.Name = "cmbRuta"
        Me.cmbRuta.Size = New System.Drawing.Size(136, 21)
        Me.cmbRuta.TabIndex = 0
        '
        'lblRuta
        '
        Me.lblRuta.AutoSize = True
        Me.lblRuta.Location = New System.Drawing.Point(12, 9)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(53, 13)
        Me.lblRuta.TabIndex = 1
        Me.lblRuta.Text = "Recorrido"
        '
        'grdRuta
        '
        Me.grdRuta.AllowUserToAddRows = False
        Me.grdRuta.AllowUserToDeleteRows = False
        Me.grdRuta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRuta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.grdRuta.Location = New System.Drawing.Point(12, 116)
        Me.grdRuta.Name = "grdRuta"
        Me.grdRuta.Size = New System.Drawing.Size(740, 243)
        Me.grdRuta.TabIndex = 2
        '
        'cmbAño
        '
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(154, 24)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(88, 21)
        Me.cmbAño.TabIndex = 3
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Location = New System.Drawing.Point(151, 8)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(26, 13)
        Me.lblAño.TabIndex = 4
        Me.lblAño.Text = "Año"
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(248, 24)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(83, 21)
        Me.cmbMes.TabIndex = 5
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(245, 8)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(27, 13)
        Me.lblMes.TabIndex = 6
        Me.lblMes.Text = "Mes"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(356, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(73, 28)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCarga
        '
        Me.btnCarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCarga.Location = New System.Drawing.Point(12, 365)
        Me.btnCarga.Name = "btnCarga"
        Me.btnCarga.Size = New System.Drawing.Size(73, 28)
        Me.btnCarga.TabIndex = 8
        Me.btnCarga.Text = "Cargar"
        Me.btnCarga.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(435, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(65, 27)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'lstImpresoras
        '
        Me.lstImpresoras.FormattingEnabled = True
        Me.lstImpresoras.Location = New System.Drawing.Point(519, 8)
        Me.lstImpresoras.Name = "lstImpresoras"
        Me.lstImpresoras.Size = New System.Drawing.Size(233, 30)
        Me.lstImpresoras.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cuentas para Imprimir"
        '
        'TxtTotalCuentas
        '
        Me.TxtTotalCuentas.Location = New System.Drawing.Point(136, 74)
        Me.TxtTotalCuentas.Name = "TxtTotalCuentas"
        Me.TxtTotalCuentas.Size = New System.Drawing.Size(80, 20)
        Me.TxtTotalCuentas.TabIndex = 12
        Me.TxtTotalCuentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmLecturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 398)
        Me.Controls.Add(Me.TxtTotalCuentas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstImpresoras)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCarga)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.cmbMes)
        Me.Controls.Add(Me.lblAño)
        Me.Controls.Add(Me.cmbAño)
        Me.Controls.Add(Me.grdRuta)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.cmbRuta)
        Me.KeyPreview = True
        Me.Name = "frmLecturas"
        Me.Text = "Lecturas"
        CType(Me.grdRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbRuta As System.Windows.Forms.ComboBox
    Friend WithEvents lblRuta As System.Windows.Forms.Label
    Friend WithEvents grdRuta As System.Windows.Forms.DataGridView
    Friend WithEvents cmbAño As System.Windows.Forms.ComboBox
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCarga As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents dlgCarpeta As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lstImpresoras As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTotalCuentas As TextBox
End Class
