<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAplicoRecorrido
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
        Me.cmbRecorrido = New System.Windows.Forms.ComboBox()
        Me.cmbA = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbM = New System.Windows.Forms.ComboBox()
        Me.grdRecorrido = New System.Windows.Forms.DataGridView()
        Me.btnAplicaAdeudo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chbMostrarTodos = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chbAdeudos = New System.Windows.Forms.CheckBox()
        Me.Mostrar = New System.Windows.Forms.Button()
        Me.chbConsumo = New System.Windows.Forms.CheckBox()
        Me.lbTotalContratos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbAdeudosGenerados = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Periodo = New System.Windows.Forms.Label()
        Me.lbRecorrido = New System.Windows.Forms.Label()
        Me.lbPeriodo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbConsumos = New System.Windows.Forms.Label()
        Me.btnAplicaConsumo = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbErrores = New System.Windows.Forms.Label()
        Me.lsErrores = New System.Windows.Forms.ListBox()
        CType(Me.grdRecorrido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbRecorrido
        '
        Me.cmbRecorrido.FormattingEnabled = True
        Me.cmbRecorrido.Location = New System.Drawing.Point(103, 113)
        Me.cmbRecorrido.Name = "cmbRecorrido"
        Me.cmbRecorrido.Size = New System.Drawing.Size(254, 24)
        Me.cmbRecorrido.TabIndex = 0
        '
        'cmbA
        '
        Me.cmbA.FormattingEnabled = True
        Me.cmbA.Location = New System.Drawing.Point(380, 113)
        Me.cmbA.Name = "cmbA"
        Me.cmbA.Size = New System.Drawing.Size(89, 24)
        Me.cmbA.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Recorrido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(377, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Año"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(489, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mes"
        '
        'cmbM
        '
        Me.cmbM.FormattingEnabled = True
        Me.cmbM.Location = New System.Drawing.Point(492, 113)
        Me.cmbM.Name = "cmbM"
        Me.cmbM.Size = New System.Drawing.Size(84, 24)
        Me.cmbM.TabIndex = 6
        '
        'grdRecorrido
        '
        Me.grdRecorrido.AllowUserToAddRows = False
        Me.grdRecorrido.AllowUserToDeleteRows = False
        Me.grdRecorrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRecorrido.Location = New System.Drawing.Point(95, 258)
        Me.grdRecorrido.Name = "grdRecorrido"
        Me.grdRecorrido.ReadOnly = True
        Me.grdRecorrido.RowTemplate.Height = 24
        Me.grdRecorrido.Size = New System.Drawing.Size(1104, 286)
        Me.grdRecorrido.TabIndex = 7
        '
        'btnAplicaAdeudo
        '
        Me.btnAplicaAdeudo.Enabled = False
        Me.btnAplicaAdeudo.Location = New System.Drawing.Point(691, 20)
        Me.btnAplicaAdeudo.Name = "btnAplicaAdeudo"
        Me.btnAplicaAdeudo.Size = New System.Drawing.Size(177, 32)
        Me.btnAplicaAdeudo.TabIndex = 8
        Me.btnAplicaAdeudo.Text = "Generar Adeudos"
        Me.btnAplicaAdeudo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total de Contratos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(111, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Mostrar Contratos:"
        '
        'chbMostrarTodos
        '
        Me.chbMostrarTodos.AutoSize = True
        Me.chbMostrarTodos.Checked = True
        Me.chbMostrarTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbMostrarTodos.Location = New System.Drawing.Point(242, 164)
        Me.chbMostrarTodos.Name = "chbMostrarTodos"
        Me.chbMostrarTodos.Size = New System.Drawing.Size(70, 21)
        Me.chbMostrarTodos.TabIndex = 15
        Me.chbMostrarTodos.Text = "Todos"
        Me.chbMostrarTodos.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(332, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Aplicados:"
        '
        'chbAdeudos
        '
        Me.chbAdeudos.AutoSize = True
        Me.chbAdeudos.Enabled = False
        Me.chbAdeudos.Location = New System.Drawing.Point(512, 164)
        Me.chbAdeudos.Name = "chbAdeudos"
        Me.chbAdeudos.Size = New System.Drawing.Size(86, 21)
        Me.chbAdeudos.TabIndex = 18
        Me.chbAdeudos.Text = "Adeudos"
        Me.chbAdeudos.UseVisualStyleBackColor = True
        '
        'Mostrar
        '
        Me.Mostrar.Location = New System.Drawing.Point(604, 156)
        Me.Mostrar.Name = "Mostrar"
        Me.Mostrar.Size = New System.Drawing.Size(111, 34)
        Me.Mostrar.TabIndex = 19
        Me.Mostrar.Text = "Mostrar"
        Me.Mostrar.UseVisualStyleBackColor = True
        '
        'chbConsumo
        '
        Me.chbConsumo.AutoSize = True
        Me.chbConsumo.Enabled = False
        Me.chbConsumo.Location = New System.Drawing.Point(417, 164)
        Me.chbConsumo.Name = "chbConsumo"
        Me.chbConsumo.Size = New System.Drawing.Size(89, 21)
        Me.chbConsumo.TabIndex = 20
        Me.chbConsumo.Text = "Consumo"
        Me.chbConsumo.UseVisualStyleBackColor = True
        '
        'lbTotalContratos
        '
        Me.lbTotalContratos.AutoSize = True
        Me.lbTotalContratos.Location = New System.Drawing.Point(235, 230)
        Me.lbTotalContratos.Name = "lbTotalContratos"
        Me.lbTotalContratos.Size = New System.Drawing.Size(16, 17)
        Me.lbTotalContratos.TabIndex = 21
        Me.lbTotalContratos.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(273, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Adeudos Generados:"
        '
        'lbAdeudosGenerados
        '
        Me.lbAdeudosGenerados.AutoSize = True
        Me.lbAdeudosGenerados.Location = New System.Drawing.Point(422, 230)
        Me.lbAdeudosGenerados.Name = "lbAdeudosGenerados"
        Me.lbAdeudosGenerados.Size = New System.Drawing.Size(16, 17)
        Me.lbAdeudosGenerados.TabIndex = 23
        Me.lbAdeudosGenerados.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(100, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Recorrido:"
        '
        'Periodo
        '
        Me.Periodo.AutoSize = True
        Me.Periodo.Location = New System.Drawing.Point(332, 202)
        Me.Periodo.Name = "Periodo"
        Me.Periodo.Size = New System.Drawing.Size(61, 17)
        Me.Periodo.TabIndex = 25
        Me.Periodo.Text = "Periodo:"
        '
        'lbRecorrido
        '
        Me.lbRecorrido.AutoSize = True
        Me.lbRecorrido.Location = New System.Drawing.Point(180, 202)
        Me.lbRecorrido.Name = "lbRecorrido"
        Me.lbRecorrido.Size = New System.Drawing.Size(104, 17)
        Me.lbRecorrido.TabIndex = 26
        Me.lbRecorrido.Text = "                        "
        '
        'lbPeriodo
        '
        Me.lbPeriodo.AutoSize = True
        Me.lbPeriodo.Location = New System.Drawing.Point(418, 207)
        Me.lbPeriodo.Name = "lbPeriodo"
        Me.lbPeriodo.Size = New System.Drawing.Size(36, 17)
        Me.lbPeriodo.TabIndex = 27
        Me.lbPeriodo.Text = "       "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(477, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Consumos Generados:"
        '
        'lbConsumos
        '
        Me.lbConsumos.AutoSize = True
        Me.lbConsumos.Location = New System.Drawing.Point(659, 230)
        Me.lbConsumos.Name = "lbConsumos"
        Me.lbConsumos.Size = New System.Drawing.Size(16, 17)
        Me.lbConsumos.TabIndex = 29
        Me.lbConsumos.Text = "0"
        '
        'btnAplicaConsumo
        '
        Me.btnAplicaConsumo.Enabled = False
        Me.btnAplicaConsumo.Location = New System.Drawing.Point(505, 20)
        Me.btnAplicaConsumo.Name = "btnAplicaConsumo"
        Me.btnAplicaConsumo.Size = New System.Drawing.Size(170, 33)
        Me.btnAplicaConsumo.TabIndex = 30
        Me.btnAplicaConsumo.Text = "Generar Consumos"
        Me.btnAplicaConsumo.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(761, 224)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(305, 23)
        Me.ProgressBar1.TabIndex = 31
        '
        'lbErrores
        '
        Me.lbErrores.AutoSize = True
        Me.lbErrores.Location = New System.Drawing.Point(860, 67)
        Me.lbErrores.Name = "lbErrores"
        Me.lbErrores.Size = New System.Drawing.Size(146, 17)
        Me.lbErrores.TabIndex = 32
        Me.lbErrores.Text = "Contrato para revisar:"
        Me.lbErrores.Visible = False
        '
        'lsErrores
        '
        Me.lsErrores.FormattingEnabled = True
        Me.lsErrores.ItemHeight = 16
        Me.lsErrores.Location = New System.Drawing.Point(863, 98)
        Me.lsErrores.Name = "lsErrores"
        Me.lsErrores.Size = New System.Drawing.Size(194, 100)
        Me.lsErrores.TabIndex = 33
        Me.lsErrores.Visible = False
        '
        'frmAplicoRecorrido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 632)
        Me.Controls.Add(Me.lsErrores)
        Me.Controls.Add(Me.lbErrores)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnAplicaConsumo)
        Me.Controls.Add(Me.lbConsumos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbPeriodo)
        Me.Controls.Add(Me.lbRecorrido)
        Me.Controls.Add(Me.Periodo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbAdeudosGenerados)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbTotalContratos)
        Me.Controls.Add(Me.chbConsumo)
        Me.Controls.Add(Me.Mostrar)
        Me.Controls.Add(Me.chbAdeudos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chbMostrarTodos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAplicaAdeudo)
        Me.Controls.Add(Me.grdRecorrido)
        Me.Controls.Add(Me.cmbM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbA)
        Me.Controls.Add(Me.cmbRecorrido)
        Me.Name = "frmAplicoRecorrido"
        Me.Text = "Aplicar Recorrido"
        CType(Me.grdRecorrido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbRecorrido As ComboBox
    Friend WithEvents cmbA As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbM As ComboBox
    Friend WithEvents grdRecorrido As DataGridView
    Friend WithEvents btnAplicaAdeudo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chbMostrarTodos As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chbAdeudos As CheckBox
    Friend WithEvents Mostrar As Button
    Friend WithEvents chbConsumo As CheckBox
    Friend WithEvents lbTotalContratos As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbAdeudosGenerados As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Periodo As Label
    Friend WithEvents lbRecorrido As Label
    Friend WithEvents lbPeriodo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbConsumos As Label
    Friend WithEvents btnAplicaConsumo As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lbErrores As Label
    Friend WithEvents lsErrores As ListBox
End Class
