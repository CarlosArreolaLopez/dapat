<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdoCuenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbColonia = New System.Windows.Forms.ComboBox()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.txtPeriodo = New System.Windows.Forms.TextBox()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.grdContratos = New System.Windows.Forms.DataGridView()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lstImpresoras = New System.Windows.Forms.ListBox()
        Me.lblCuentas = New System.Windows.Forms.Label()
        CType(Me.grdContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbColonia
        '
        Me.cmbColonia.FormattingEnabled = True
        Me.cmbColonia.Location = New System.Drawing.Point(15, 71)
        Me.cmbColonia.Name = "cmbColonia"
        Me.cmbColonia.Size = New System.Drawing.Size(200, 21)
        Me.cmbColonia.TabIndex = 0
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(12, 48)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(42, 13)
        Me.lblColonia.TabIndex = 1
        Me.lblColonia.Text = "Colonia"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(220, 72)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(100, 20)
        Me.txtPeriodo.TabIndex = 2
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(219, 48)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(43, 13)
        Me.lblPeriodo.TabIndex = 3
        Me.lblPeriodo.Text = "Periodo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(337, 48)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(135, 44)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'grdContratos
        '
        Me.grdContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdContratos.Location = New System.Drawing.Point(13, 98)
        Me.grdContratos.Name = "grdContratos"
        Me.grdContratos.Size = New System.Drawing.Size(939, 431)
        Me.grdContratos.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(736, 48)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(212, 44)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'lstImpresoras
        '
        Me.lstImpresoras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstImpresoras.FormattingEnabled = True
        Me.lstImpresoras.Location = New System.Drawing.Point(736, 12)
        Me.lstImpresoras.Name = "lstImpresoras"
        Me.lstImpresoras.Size = New System.Drawing.Size(215, 30)
        Me.lstImpresoras.TabIndex = 11
        '
        'lblCuentas
        '
        Me.lblCuentas.AutoSize = True
        Me.lblCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentas.Location = New System.Drawing.Point(478, 72)
        Me.lblCuentas.Name = "lblCuentas"
        Me.lblCuentas.Size = New System.Drawing.Size(165, 20)
        Me.lblCuentas.TabIndex = 12
        Me.lblCuentas.Text = "Estados de cuenta:"
        '
        'frmEdoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 541)
        Me.Controls.Add(Me.lblCuentas)
        Me.Controls.Add(Me.lstImpresoras)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.grdContratos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.cmbColonia)
        Me.Name = "frmEdoCuenta"
        Me.Text = "Estado de Cuenta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbColonia As System.Windows.Forms.ComboBox
    Friend WithEvents lblColonia As System.Windows.Forms.Label
    Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents grdContratos As System.Windows.Forms.DataGridView
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lstImpresoras As System.Windows.Forms.ListBox
    Friend WithEvents lblCuentas As System.Windows.Forms.Label
End Class
