<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Administrador
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
        Me.TxtCorreo_Administrador = New System.Windows.Forms.TextBox()
        Me.LbCorreo_Administrador = New System.Windows.Forms.Label()
        Me.DrdAdministrador = New System.Windows.Forms.DataGridView()
        Me.IdAdministradorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreAdministradorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdministradoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.TxtTelefono_Administrador = New System.Windows.Forms.TextBox()
        Me.TxtArea_Laboral = New System.Windows.Forms.TextBox()
        Me.TxtNombre_Administrador = New System.Windows.Forms.TextBox()
        Me.Txtid_Administrador = New System.Windows.Forms.TextBox()
        Me.LbTelefono_Administrador = New System.Windows.Forms.Label()
        Me.LbArea_Laboral = New System.Windows.Forms.Label()
        Me.LbNombre_Administrador = New System.Windows.Forms.Label()
        Me.Lbid_Administrador = New System.Windows.Forms.Label()
        CType(Me.DrdAdministrador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdministradoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCorreo_Administrador
        '
        Me.TxtCorreo_Administrador.Location = New System.Drawing.Point(127, 235)
        Me.TxtCorreo_Administrador.Name = "TxtCorreo_Administrador"
        Me.TxtCorreo_Administrador.Size = New System.Drawing.Size(180, 20)
        Me.TxtCorreo_Administrador.TabIndex = 32
        '
        'LbCorreo_Administrador
        '
        Me.LbCorreo_Administrador.AutoSize = True
        Me.LbCorreo_Administrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCorreo_Administrador.Location = New System.Drawing.Point(32, 235)
        Me.LbCorreo_Administrador.Name = "LbCorreo_Administrador"
        Me.LbCorreo_Administrador.Size = New System.Drawing.Size(55, 16)
        Me.LbCorreo_Administrador.TabIndex = 31
        Me.LbCorreo_Administrador.Text = "Correo"
        '
        'DrdAdministrador
        '
        Me.DrdAdministrador.AllowUserToAddRows = False
        Me.DrdAdministrador.AllowUserToDeleteRows = False
        Me.DrdAdministrador.AutoGenerateColumns = False
        Me.DrdAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DrdAdministrador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAdministradorDataGridViewTextBoxColumn, Me.NombreAdministradorDataGridViewTextBoxColumn})
        Me.DrdAdministrador.DataSource = Me.AdministradoresBindingSource
        Me.DrdAdministrador.Location = New System.Drawing.Point(395, 40)
        Me.DrdAdministrador.MultiSelect = False
        Me.DrdAdministrador.Name = "DrdAdministrador"
        Me.DrdAdministrador.ReadOnly = True
        Me.DrdAdministrador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DrdAdministrador.Size = New System.Drawing.Size(249, 150)
        Me.DrdAdministrador.TabIndex = 30
        '
        'IdAdministradorDataGridViewTextBoxColumn
        '
        Me.IdAdministradorDataGridViewTextBoxColumn.DataPropertyName = "Id_Administrador"
        Me.IdAdministradorDataGridViewTextBoxColumn.HeaderText = "Id_Administrador"
        Me.IdAdministradorDataGridViewTextBoxColumn.Name = "IdAdministradorDataGridViewTextBoxColumn"
        Me.IdAdministradorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreAdministradorDataGridViewTextBoxColumn
        '
        Me.NombreAdministradorDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Administrador"
        Me.NombreAdministradorDataGridViewTextBoxColumn.HeaderText = "Nombre_Administrador"
        Me.NombreAdministradorDataGridViewTextBoxColumn.Name = "NombreAdministradorDataGridViewTextBoxColumn"
        Me.NombreAdministradorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdministradoresBindingSource
        '
        Me.AdministradoresBindingSource.DataSource = GetType(artemis.Administradores)
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(618, 228)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 29
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(537, 228)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 28
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(456, 228)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 27
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.Location = New System.Drawing.Point(368, 228)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrabar.TabIndex = 26
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'TxtTelefono_Administrador
        '
        Me.TxtTelefono_Administrador.Location = New System.Drawing.Point(148, 196)
        Me.TxtTelefono_Administrador.MaxLength = 100
        Me.TxtTelefono_Administrador.Name = "TxtTelefono_Administrador"
        Me.TxtTelefono_Administrador.Size = New System.Drawing.Size(180, 20)
        Me.TxtTelefono_Administrador.TabIndex = 25
        '
        'TxtArea_Laboral
        '
        Me.TxtArea_Laboral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtArea_Laboral.Location = New System.Drawing.Point(148, 127)
        Me.TxtArea_Laboral.MaxLength = 200
        Me.TxtArea_Laboral.Multiline = True
        Me.TxtArea_Laboral.Name = "TxtArea_Laboral"
        Me.TxtArea_Laboral.Size = New System.Drawing.Size(180, 50)
        Me.TxtArea_Laboral.TabIndex = 24
        '
        'TxtNombre_Administrador
        '
        Me.TxtNombre_Administrador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre_Administrador.Location = New System.Drawing.Point(148, 89)
        Me.TxtNombre_Administrador.MaxLength = 200
        Me.TxtNombre_Administrador.Name = "TxtNombre_Administrador"
        Me.TxtNombre_Administrador.Size = New System.Drawing.Size(130, 20)
        Me.TxtNombre_Administrador.TabIndex = 23
        '
        'Txtid_Administrador
        '
        Me.Txtid_Administrador.Location = New System.Drawing.Point(148, 58)
        Me.Txtid_Administrador.Name = "Txtid_Administrador"
        Me.Txtid_Administrador.ReadOnly = True
        Me.Txtid_Administrador.Size = New System.Drawing.Size(60, 20)
        Me.Txtid_Administrador.TabIndex = 22
        Me.Txtid_Administrador.Tag = ""
        Me.Txtid_Administrador.Text = "0"
        Me.Txtid_Administrador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LbTelefono_Administrador
        '
        Me.LbTelefono_Administrador.AutoSize = True
        Me.LbTelefono_Administrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTelefono_Administrador.Location = New System.Drawing.Point(29, 196)
        Me.LbTelefono_Administrador.Name = "LbTelefono_Administrador"
        Me.LbTelefono_Administrador.Size = New System.Drawing.Size(70, 16)
        Me.LbTelefono_Administrador.TabIndex = 21
        Me.LbTelefono_Administrador.Text = "Telefono"
        '
        'LbArea_Laboral
        '
        Me.LbArea_Laboral.AutoSize = True
        Me.LbArea_Laboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbArea_Laboral.Location = New System.Drawing.Point(8, 137)
        Me.LbArea_Laboral.Name = "LbArea_Laboral"
        Me.LbArea_Laboral.Size = New System.Drawing.Size(98, 16)
        Me.LbArea_Laboral.TabIndex = 20
        Me.LbArea_Laboral.Text = "Área Laboral"
        '
        'LbNombre_Administrador
        '
        Me.LbNombre_Administrador.AutoSize = True
        Me.LbNombre_Administrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre_Administrador.Location = New System.Drawing.Point(32, 90)
        Me.LbNombre_Administrador.Name = "LbNombre_Administrador"
        Me.LbNombre_Administrador.Size = New System.Drawing.Size(63, 16)
        Me.LbNombre_Administrador.TabIndex = 19
        Me.LbNombre_Administrador.Text = "Nombre"
        '
        'Lbid_Administrador
        '
        Me.Lbid_Administrador.AutoSize = True
        Me.Lbid_Administrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbid_Administrador.Location = New System.Drawing.Point(29, 62)
        Me.Lbid_Administrador.Name = "Lbid_Administrador"
        Me.Lbid_Administrador.Size = New System.Drawing.Size(104, 16)
        Me.Lbid_Administrador.TabIndex = 18
        Me.Lbid_Administrador.Text = "Administrador"
        '
        'Frm_Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(734, 361)
        Me.Controls.Add(Me.TxtCorreo_Administrador)
        Me.Controls.Add(Me.LbCorreo_Administrador)
        Me.Controls.Add(Me.DrdAdministrador)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.TxtTelefono_Administrador)
        Me.Controls.Add(Me.TxtArea_Laboral)
        Me.Controls.Add(Me.TxtNombre_Administrador)
        Me.Controls.Add(Me.Txtid_Administrador)
        Me.Controls.Add(Me.LbTelefono_Administrador)
        Me.Controls.Add(Me.LbArea_Laboral)
        Me.Controls.Add(Me.LbNombre_Administrador)
        Me.Controls.Add(Me.Lbid_Administrador)
        Me.Name = "Frm_Administrador"
        Me.Text = "Frm_Administrador"
        CType(Me.DrdAdministrador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdministradoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCorreo_Administrador As System.Windows.Forms.TextBox
    Friend WithEvents LbCorreo_Administrador As System.Windows.Forms.Label
    Friend WithEvents DrdAdministrador As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents TxtTelefono_Administrador As System.Windows.Forms.TextBox
    Friend WithEvents TxtArea_Laboral As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre_Administrador As System.Windows.Forms.TextBox
    Friend WithEvents Txtid_Administrador As System.Windows.Forms.TextBox
    Friend WithEvents LbTelefono_Administrador As System.Windows.Forms.Label
    Friend WithEvents LbArea_Laboral As System.Windows.Forms.Label
    Friend WithEvents LbNombre_Administrador As System.Windows.Forms.Label
    Friend WithEvents Lbid_Administrador As System.Windows.Forms.Label
    Friend WithEvents IdAdministradorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreAdministradorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdministradoresBindingSource As System.Windows.Forms.BindingSource
End Class
