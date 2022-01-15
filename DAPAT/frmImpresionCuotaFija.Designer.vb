<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpresionCuotaFija
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
        Me.grdCF = New System.Windows.Forms.DataGridView()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lstImpresoras = New System.Windows.Forms.ListBox()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.cmbColonia = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblCuentas = New System.Windows.Forms.Label()
        CType(Me.grdCF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCF
        '
        Me.grdCF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCF.Location = New System.Drawing.Point(12, 134)
        Me.grdCF.Name = "grdCF"
        Me.grdCF.Size = New System.Drawing.Size(928, 406)
        Me.grdCF.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(707, 85)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(233, 36)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'lstImpresoras
        '
        Me.lstImpresoras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstImpresoras.FormattingEnabled = True
        Me.lstImpresoras.Location = New System.Drawing.Point(707, 10)
        Me.lstImpresoras.Name = "lstImpresoras"
        Me.lstImpresoras.Size = New System.Drawing.Size(233, 69)
        Me.lstImpresoras.TabIndex = 11
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(12, 77)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(42, 13)
        Me.lblColonia.TabIndex = 12
        Me.lblColonia.Text = "Colonia"
        '
        'cmbColonia
        '
        Me.cmbColonia.FormattingEnabled = True
        Me.cmbColonia.Location = New System.Drawing.Point(12, 100)
        Me.cmbColonia.Name = "cmbColonia"
        Me.cmbColonia.Size = New System.Drawing.Size(236, 21)
        Me.cmbColonia.TabIndex = 13
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(254, 85)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(135, 33)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblCuentas
        '
        Me.lblCuentas.AutoSize = True
        Me.lblCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentas.Location = New System.Drawing.Point(409, 98)
        Me.lblCuentas.Name = "lblCuentas"
        Me.lblCuentas.Size = New System.Drawing.Size(165, 20)
        Me.lblCuentas.TabIndex = 15
        Me.lblCuentas.Text = "Estados de cuenta:"
        '
        'frmImpresionCuotaFija
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 552)
        Me.Controls.Add(Me.lblCuentas)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cmbColonia)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.lstImpresoras)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.grdCF)
        Me.Name = "frmImpresionCuotaFija"
        Me.Text = "frmImpresionCuotaFija"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdCF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdCF As System.Windows.Forms.DataGridView
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lstImpresoras As System.Windows.Forms.ListBox
    Friend WithEvents lblColonia As Label
    Friend WithEvents cmbColonia As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblCuentas As Label
End Class
