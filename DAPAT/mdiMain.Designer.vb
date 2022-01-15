<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturaLecturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LecturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuotaFijaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplicarRecorridosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreacionDomiciliosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculosAnualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuotaFijaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaOperativaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaSolicitudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiniestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.AdeudoEstimadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ModulosToolStripMenuItem, Me.CalculosAnualesToolStripMenuItem, Me.AreaOperativaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(913, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ModulosToolStripMenuItem
        '
        Me.ModulosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratosToolStripMenuItem, Me.CapturaLecturasToolStripMenuItem, Me.LecturasToolStripMenuItem, Me.CuotaFijaToolStripMenuItem1, Me.EstadoCuentaToolStripMenuItem, Me.AplicarRecorridosToolStripMenuItem, Me.CreacionDomiciliosToolStripMenuItem, Me.AdeudoEstimadoToolStripMenuItem})
        Me.ModulosToolStripMenuItem.Name = "ModulosToolStripMenuItem"
        Me.ModulosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ModulosToolStripMenuItem.Text = "Modulos"
        '
        'ContratosToolStripMenuItem
        '
        Me.ContratosToolStripMenuItem.Name = "ContratosToolStripMenuItem"
        Me.ContratosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ContratosToolStripMenuItem.Text = "Contratos"
        Me.ContratosToolStripMenuItem.Visible = False
        '
        'CapturaLecturasToolStripMenuItem
        '
        Me.CapturaLecturasToolStripMenuItem.Name = "CapturaLecturasToolStripMenuItem"
        Me.CapturaLecturasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CapturaLecturasToolStripMenuItem.Text = "Captura Lecturas"
        '
        'LecturasToolStripMenuItem
        '
        Me.LecturasToolStripMenuItem.Name = "LecturasToolStripMenuItem"
        Me.LecturasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LecturasToolStripMenuItem.Text = "Lecturas"
        '
        'CuotaFijaToolStripMenuItem1
        '
        Me.CuotaFijaToolStripMenuItem1.Name = "CuotaFijaToolStripMenuItem1"
        Me.CuotaFijaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CuotaFijaToolStripMenuItem1.Text = "Cuota Fija"
        '
        'EstadoCuentaToolStripMenuItem
        '
        Me.EstadoCuentaToolStripMenuItem.Name = "EstadoCuentaToolStripMenuItem"
        Me.EstadoCuentaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EstadoCuentaToolStripMenuItem.Text = "Estado Cuenta"
        '
        'AplicarRecorridosToolStripMenuItem
        '
        Me.AplicarRecorridosToolStripMenuItem.Name = "AplicarRecorridosToolStripMenuItem"
        Me.AplicarRecorridosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AplicarRecorridosToolStripMenuItem.Text = "Aplicar Recorridos"
        '
        'CreacionDomiciliosToolStripMenuItem
        '
        Me.CreacionDomiciliosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.CreacionDomiciliosToolStripMenuItem.Name = "CreacionDomiciliosToolStripMenuItem"
        Me.CreacionDomiciliosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CreacionDomiciliosToolStripMenuItem.Text = "Domicilios"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'CalculosAnualesToolStripMenuItem
        '
        Me.CalculosAnualesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuotaFijaToolStripMenuItem})
        Me.CalculosAnualesToolStripMenuItem.Name = "CalculosAnualesToolStripMenuItem"
        Me.CalculosAnualesToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.CalculosAnualesToolStripMenuItem.Text = "Calculos Anuales"
        '
        'CuotaFijaToolStripMenuItem
        '
        Me.CuotaFijaToolStripMenuItem.Name = "CuotaFijaToolStripMenuItem"
        Me.CuotaFijaToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CuotaFijaToolStripMenuItem.Text = "Cuota Fija"
        '
        'AreaOperativaToolStripMenuItem
        '
        Me.AreaOperativaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaSolicitudToolStripMenuItem, Me.SiniestrosToolStripMenuItem})
        Me.AreaOperativaToolStripMenuItem.Name = "AreaOperativaToolStripMenuItem"
        Me.AreaOperativaToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.AreaOperativaToolStripMenuItem.Text = "Area operativa"
        Me.AreaOperativaToolStripMenuItem.Visible = False
        '
        'NuevaSolicitudToolStripMenuItem
        '
        Me.NuevaSolicitudToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.AplicacionToolStripMenuItem})
        Me.NuevaSolicitudToolStripMenuItem.Name = "NuevaSolicitudToolStripMenuItem"
        Me.NuevaSolicitudToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NuevaSolicitudToolStripMenuItem.Text = "&Orden de servicio"
        Me.NuevaSolicitudToolStripMenuItem.Visible = False
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'AplicacionToolStripMenuItem
        '
        Me.AplicacionToolStripMenuItem.Name = "AplicacionToolStripMenuItem"
        Me.AplicacionToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.AplicacionToolStripMenuItem.Text = "Aplicacion"
        '
        'SiniestrosToolStripMenuItem
        '
        Me.SiniestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteToolStripMenuItem})
        Me.SiniestrosToolStripMenuItem.Name = "SiniestrosToolStripMenuItem"
        Me.SiniestrosToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SiniestrosToolStripMenuItem.Text = "&Siniestros"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 553)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(913, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(913, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'AdeudoEstimadoToolStripMenuItem
        '
        Me.AdeudoEstimadoToolStripMenuItem.Name = "AdeudoEstimadoToolStripMenuItem"
        Me.AdeudoEstimadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdeudoEstimadoToolStripMenuItem.Text = "Adeudo Estimado"
        '
        'mdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 575)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdiMain"
        Me.Text = "DAPAT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LecturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContratosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculosAnualesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuotaFijaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuotaFijaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadoCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AplicarRecorridosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreacionDomiciliosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CapturaLecturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AreaOperativaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaSolicitudToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiniestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents AdeudoEstimadoToolStripMenuItem As ToolStripMenuItem
End Class
