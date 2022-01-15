<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Domicilio
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
        Me.cmbVialidad = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbCruce1 = New System.Windows.Forms.ComboBox()
        Me.cmbCruce2 = New System.Windows.Forms.ComboBox()
        Me.txtExterior = New System.Windows.Forms.TextBox()
        Me.txtInterior = New System.Windows.Forms.TextBox()
        Me.cmbColonia = New System.Windows.Forms.ComboBox()
        Me.btnVialidad = New System.Windows.Forms.Button()
        Me.btnColonia = New System.Windows.Forms.Button()
        Me.btnCruce1 = New System.Windows.Forms.Button()
        Me.btnCruce2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtContrato = New System.Windows.Forms.TextBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.lbContrato = New System.Windows.Forms.Label()
        Me.chbLimpiar = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmbVialidad
        '
        Me.cmbVialidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbVialidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbVialidad.FormattingEnabled = True
        Me.cmbVialidad.Location = New System.Drawing.Point(52, 149)
        Me.cmbVialidad.Name = "cmbVialidad"
        Me.cmbVialidad.Size = New System.Drawing.Size(424, 24)
        Me.cmbVialidad.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Vialidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Cruce 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Cruce 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Colonia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(568, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Exterior"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(678, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Interior"
        '
        'cmbCruce1
        '
        Me.cmbCruce1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCruce1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCruce1.FormattingEnabled = True
        Me.cmbCruce1.Location = New System.Drawing.Point(54, 287)
        Me.cmbCruce1.Name = "cmbCruce1"
        Me.cmbCruce1.Size = New System.Drawing.Size(424, 24)
        Me.cmbCruce1.TabIndex = 6
        '
        'cmbCruce2
        '
        Me.cmbCruce2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCruce2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCruce2.FormattingEnabled = True
        Me.cmbCruce2.Location = New System.Drawing.Point(54, 358)
        Me.cmbCruce2.Name = "cmbCruce2"
        Me.cmbCruce2.Size = New System.Drawing.Size(424, 24)
        Me.cmbCruce2.TabIndex = 7
        '
        'txtExterior
        '
        Me.txtExterior.Location = New System.Drawing.Point(571, 148)
        Me.txtExterior.Name = "txtExterior"
        Me.txtExterior.Size = New System.Drawing.Size(88, 22)
        Me.txtExterior.TabIndex = 2
        '
        'txtInterior
        '
        Me.txtInterior.Location = New System.Drawing.Point(681, 148)
        Me.txtInterior.Name = "txtInterior"
        Me.txtInterior.Size = New System.Drawing.Size(88, 22)
        Me.txtInterior.TabIndex = 3
        '
        'cmbColonia
        '
        Me.cmbColonia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbColonia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbColonia.FormattingEnabled = True
        Me.cmbColonia.Location = New System.Drawing.Point(52, 222)
        Me.cmbColonia.Name = "cmbColonia"
        Me.cmbColonia.Size = New System.Drawing.Size(425, 24)
        Me.cmbColonia.TabIndex = 4
        '
        'btnVialidad
        '
        Me.btnVialidad.Location = New System.Drawing.Point(484, 148)
        Me.btnVialidad.Name = "btnVialidad"
        Me.btnVialidad.Size = New System.Drawing.Size(61, 24)
        Me.btnVialidad.TabIndex = 10
        Me.btnVialidad.Text = "Buscar"
        Me.btnVialidad.UseVisualStyleBackColor = True
        '
        'btnColonia
        '
        Me.btnColonia.Location = New System.Drawing.Point(484, 220)
        Me.btnColonia.Name = "btnColonia"
        Me.btnColonia.Size = New System.Drawing.Size(61, 24)
        Me.btnColonia.TabIndex = 11
        Me.btnColonia.Text = "Buscar"
        Me.btnColonia.UseVisualStyleBackColor = True
        '
        'btnCruce1
        '
        Me.btnCruce1.Location = New System.Drawing.Point(484, 287)
        Me.btnCruce1.Name = "btnCruce1"
        Me.btnCruce1.Size = New System.Drawing.Size(61, 24)
        Me.btnCruce1.TabIndex = 12
        Me.btnCruce1.Text = "Buscar"
        Me.btnCruce1.UseVisualStyleBackColor = True
        '
        'btnCruce2
        '
        Me.btnCruce2.Location = New System.Drawing.Point(484, 358)
        Me.btnCruce2.Name = "btnCruce2"
        Me.btnCruce2.Size = New System.Drawing.Size(61, 24)
        Me.btnCruce2.TabIndex = 13
        Me.btnCruce2.Text = "Buscar"
        Me.btnCruce2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(564, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Codigo Postal"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(567, 222)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(88, 22)
        Me.txtCP.TabIndex = 5
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(559, 58)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 27)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(669, 58)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 27)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtContrato
        '
        Me.txtContrato.Location = New System.Drawing.Point(123, 65)
        Me.txtContrato.Name = "txtContrato"
        Me.txtContrato.Size = New System.Drawing.Size(83, 22)
        Me.txtContrato.TabIndex = 24
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(212, 65)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(108, 23)
        Me.btBuscar.TabIndex = 15
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'lbContrato
        '
        Me.lbContrato.AutoSize = True
        Me.lbContrato.Location = New System.Drawing.Point(51, 68)
        Me.lbContrato.Name = "lbContrato"
        Me.lbContrato.Size = New System.Drawing.Size(66, 17)
        Me.lbContrato.TabIndex = 16
        Me.lbContrato.Text = "Contrato:"
        '
        'chbLimpiar
        '
        Me.chbLimpiar.AutoSize = True
        Me.chbLimpiar.Location = New System.Drawing.Point(55, 44)
        Me.chbLimpiar.Name = "chbLimpiar"
        Me.chbLimpiar.Size = New System.Drawing.Size(76, 21)
        Me.chbLimpiar.TabIndex = 14
        Me.chbLimpiar.Text = "Limpiar"
        Me.chbLimpiar.UseVisualStyleBackColor = True
        '
        'Domicilio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 486)
        Me.Controls.Add(Me.chbLimpiar)
        Me.Controls.Add(Me.lbContrato)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.txtContrato)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCruce2)
        Me.Controls.Add(Me.btnCruce1)
        Me.Controls.Add(Me.btnColonia)
        Me.Controls.Add(Me.btnVialidad)
        Me.Controls.Add(Me.cmbColonia)
        Me.Controls.Add(Me.txtInterior)
        Me.Controls.Add(Me.txtExterior)
        Me.Controls.Add(Me.cmbCruce2)
        Me.Controls.Add(Me.cmbCruce1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbVialidad)
        Me.Name = "Domicilio"
        Me.Text = "Domicilio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbVialidad As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbCruce1 As ComboBox
    Friend WithEvents cmbCruce2 As ComboBox
    Friend WithEvents txtExterior As TextBox
    Friend WithEvents txtInterior As TextBox
    Friend WithEvents cmbColonia As ComboBox
    Friend WithEvents btnVialidad As Button
    Friend WithEvents btnColonia As Button
    Friend WithEvents btnCruce1 As Button
    Friend WithEvents btnCruce2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtContrato As TextBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents lbContrato As Label
    Friend WithEvents chbLimpiar As CheckBox
End Class
