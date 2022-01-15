<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCapturaLecturas
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
        Me.grdRecorrido = New System.Windows.Forms.DataGridView()
        Me.cmbRecorrido = New System.Windows.Forms.ComboBox()
        Me.cmbA = New System.Windows.Forms.ComboBox()
        Me.cmbM = New System.Windows.Forms.ComboBox()
        Me.txtLecturaAnterior = New System.Windows.Forms.TextBox()
        Me.Mostrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLecturaNueva = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbInsidencias = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConsumoAnterior = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGuardarLectura = New System.Windows.Forms.Button()
        CType(Me.grdRecorrido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdRecorrido
        '
        Me.grdRecorrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRecorrido.Location = New System.Drawing.Point(12, 136)
        Me.grdRecorrido.Name = "grdRecorrido"
        Me.grdRecorrido.Size = New System.Drawing.Size(997, 384)
        Me.grdRecorrido.TabIndex = 0
        '
        'cmbRecorrido
        '
        Me.cmbRecorrido.FormattingEnabled = True
        Me.cmbRecorrido.Location = New System.Drawing.Point(64, 17)
        Me.cmbRecorrido.Name = "cmbRecorrido"
        Me.cmbRecorrido.Size = New System.Drawing.Size(121, 21)
        Me.cmbRecorrido.TabIndex = 1
        '
        'cmbA
        '
        Me.cmbA.FormattingEnabled = True
        Me.cmbA.Location = New System.Drawing.Point(64, 47)
        Me.cmbA.Name = "cmbA"
        Me.cmbA.Size = New System.Drawing.Size(121, 21)
        Me.cmbA.TabIndex = 2
        '
        'cmbM
        '
        Me.cmbM.FormattingEnabled = True
        Me.cmbM.Location = New System.Drawing.Point(64, 74)
        Me.cmbM.Name = "cmbM"
        Me.cmbM.Size = New System.Drawing.Size(121, 21)
        Me.cmbM.TabIndex = 3
        '
        'txtLecturaAnterior
        '
        Me.txtLecturaAnterior.Location = New System.Drawing.Point(367, 22)
        Me.txtLecturaAnterior.Name = "txtLecturaAnterior"
        Me.txtLecturaAnterior.Size = New System.Drawing.Size(100, 20)
        Me.txtLecturaAnterior.TabIndex = 4
        '
        'Mostrar
        '
        Me.Mostrar.Location = New System.Drawing.Point(204, 98)
        Me.Mostrar.Margin = New System.Windows.Forms.Padding(2)
        Me.Mostrar.Name = "Mostrar"
        Me.Mostrar.Size = New System.Drawing.Size(83, 28)
        Me.Mostrar.TabIndex = 32
        Me.Mostrar.Text = "Mostrar"
        Me.Mostrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Ruta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Año"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Mes"
        '
        'txtLecturaNueva
        '
        Me.txtLecturaNueva.Location = New System.Drawing.Point(367, 55)
        Me.txtLecturaNueva.Name = "txtLecturaNueva"
        Me.txtLecturaNueva.Size = New System.Drawing.Size(100, 20)
        Me.txtLecturaNueva.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Lectura Anterior"
        '
        'cmbInsidencias
        '
        Me.cmbInsidencias.FormattingEnabled = True
        Me.cmbInsidencias.Location = New System.Drawing.Point(588, 55)
        Me.cmbInsidencias.Name = "cmbInsidencias"
        Me.cmbInsidencias.Size = New System.Drawing.Size(270, 21)
        Me.cmbInsidencias.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Lectura Nueva"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(486, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Incidencia"
        '
        'txtConsumoAnterior
        '
        Me.txtConsumoAnterior.Location = New System.Drawing.Point(588, 25)
        Me.txtConsumoAnterior.Name = "txtConsumoAnterior"
        Me.txtConsumoAnterior.Size = New System.Drawing.Size(100, 20)
        Me.txtConsumoAnterior.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(486, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Consumo Anterior"
        '
        'btnGuardarLectura
        '
        Me.btnGuardarLectura.Location = New System.Drawing.Point(598, 98)
        Me.btnGuardarLectura.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardarLectura.Name = "btnGuardarLectura"
        Me.btnGuardarLectura.Size = New System.Drawing.Size(83, 28)
        Me.btnGuardarLectura.TabIndex = 44
        Me.btnGuardarLectura.Text = "Guardar Lectura"
        Me.btnGuardarLectura.UseVisualStyleBackColor = True
        '
        'frmCapturaLecturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 540)
        Me.Controls.Add(Me.btnGuardarLectura)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtConsumoAnterior)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbInsidencias)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLecturaNueva)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Mostrar)
        Me.Controls.Add(Me.txtLecturaAnterior)
        Me.Controls.Add(Me.cmbM)
        Me.Controls.Add(Me.cmbA)
        Me.Controls.Add(Me.cmbRecorrido)
        Me.Controls.Add(Me.grdRecorrido)
        Me.Name = "frmCapturaLecturas"
        Me.Text = "Captura Lecturas"
        CType(Me.grdRecorrido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdRecorrido As DataGridView
    Friend WithEvents cmbRecorrido As ComboBox
    Friend WithEvents cmbA As ComboBox
    Friend WithEvents cmbM As ComboBox
    Friend WithEvents txtLecturaAnterior As TextBox
    Friend WithEvents Mostrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLecturaNueva As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbInsidencias As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtConsumoAnterior As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGuardarLectura As Button
End Class
