<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.TxtTitulo = New System.Windows.Forms.TextBox()
        Me.TxtApellidos_Empleado = New System.Windows.Forms.TextBox()
        Me.TxtArea_Trabajo = New System.Windows.Forms.TextBox()
        Me.TxtNombre_Empleado = New System.Windows.Forms.TextBox()
        Me.TxtId_Empleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdAdministradorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreAdministradorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(643, 241)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 41
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(562, 241)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 40
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(481, 241)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 39
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.Location = New System.Drawing.Point(393, 241)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrabar.TabIndex = 38
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'TxtTitulo
        '
        Me.TxtTitulo.Location = New System.Drawing.Point(199, 289)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.Size = New System.Drawing.Size(180, 20)
        Me.TxtTitulo.TabIndex = 36
        '
        'TxtApellidos_Empleado
        '
        Me.TxtApellidos_Empleado.Location = New System.Drawing.Point(199, 175)
        Me.TxtApellidos_Empleado.MaxLength = 100
        Me.TxtApellidos_Empleado.Name = "TxtApellidos_Empleado"
        Me.TxtApellidos_Empleado.Size = New System.Drawing.Size(180, 20)
        Me.TxtApellidos_Empleado.TabIndex = 35
        '
        'TxtArea_Trabajo
        '
        Me.TxtArea_Trabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtArea_Trabajo.Location = New System.Drawing.Point(199, 214)
        Me.TxtArea_Trabajo.MaxLength = 200
        Me.TxtArea_Trabajo.Multiline = True
        Me.TxtArea_Trabajo.Name = "TxtArea_Trabajo"
        Me.TxtArea_Trabajo.Size = New System.Drawing.Size(180, 50)
        Me.TxtArea_Trabajo.TabIndex = 34
        '
        'TxtNombre_Empleado
        '
        Me.TxtNombre_Empleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre_Empleado.Location = New System.Drawing.Point(199, 137)
        Me.TxtNombre_Empleado.MaxLength = 200
        Me.TxtNombre_Empleado.Name = "TxtNombre_Empleado"
        Me.TxtNombre_Empleado.Size = New System.Drawing.Size(130, 20)
        Me.TxtNombre_Empleado.TabIndex = 33
        '
        'TxtId_Empleado
        '
        Me.TxtId_Empleado.Location = New System.Drawing.Point(199, 81)
        Me.TxtId_Empleado.Name = "TxtId_Empleado"
        Me.TxtId_Empleado.ReadOnly = True
        Me.TxtId_Empleado.Size = New System.Drawing.Size(60, 20)
        Me.TxtId_Empleado.TabIndex = 32
        Me.TxtId_Empleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Area de trabajo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Código de empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Empleado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Titulo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 18)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Apellido"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAdministradorDataGridViewTextBoxColumn, Me.NombreAdministradorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(429, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(269, 150)
        Me.DataGridView1.TabIndex = 44
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataSource = GetType(artemis.clientes)
        '
        'IdAdministradorDataGridViewTextBoxColumn
        '
        Me.IdAdministradorDataGridViewTextBoxColumn.DataPropertyName = "Id_Administrador"
        Me.IdAdministradorDataGridViewTextBoxColumn.HeaderText = "Id_Administrador"
        Me.IdAdministradorDataGridViewTextBoxColumn.Name = "IdAdministradorDataGridViewTextBoxColumn"
        '
        'NombreAdministradorDataGridViewTextBoxColumn
        '
        Me.NombreAdministradorDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Administrador"
        Me.NombreAdministradorDataGridViewTextBoxColumn.HeaderText = "Nombre_Administrador"
        Me.NombreAdministradorDataGridViewTextBoxColumn.Name = "NombreAdministradorDataGridViewTextBoxColumn"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(734, 361)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.TxtTitulo)
        Me.Controls.Add(Me.TxtApellidos_Empleado)
        Me.Controls.Add(Me.TxtArea_Trabajo)
        Me.Controls.Add(Me.TxtNombre_Empleado)
        Me.Controls.Add(Me.TxtId_Empleado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmClientes"
        Me.Text = "frmClientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents TxtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellidos_Empleado As System.Windows.Forms.TextBox
    Friend WithEvents TxtArea_Trabajo As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre_Empleado As System.Windows.Forms.TextBox
    Friend WithEvents TxtId_Empleado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdAdministradorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreAdministradorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
End Class
