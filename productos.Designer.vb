<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCTOS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPrecio_Producto = New System.Windows.Forms.TextBox()
        Me.TxtTipo_Producto = New System.Windows.Forms.TextBox()
        Me.TxtNombre_Producto = New System.Windows.Forms.TextBox()
        Me.TxtId_Producto = New System.Windows.Forms.TextBox()
        Me.DrdAdministrador = New System.Windows.Forms.DataGridView()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdAdministradorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreAdministradorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DrdAdministrador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Productos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre del producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo del producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio del producto"
        '
        'TxtPrecio_Producto
        '
        Me.TxtPrecio_Producto.Location = New System.Drawing.Point(183, 224)
        Me.TxtPrecio_Producto.MaxLength = 100
        Me.TxtPrecio_Producto.Name = "TxtPrecio_Producto"
        Me.TxtPrecio_Producto.Size = New System.Drawing.Size(180, 20)
        Me.TxtPrecio_Producto.TabIndex = 21
        '
        'TxtTipo_Producto
        '
        Me.TxtTipo_Producto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTipo_Producto.Location = New System.Drawing.Point(183, 155)
        Me.TxtTipo_Producto.MaxLength = 200
        Me.TxtTipo_Producto.Multiline = True
        Me.TxtTipo_Producto.Name = "TxtTipo_Producto"
        Me.TxtTipo_Producto.Size = New System.Drawing.Size(180, 50)
        Me.TxtTipo_Producto.TabIndex = 20
        '
        'TxtNombre_Producto
        '
        Me.TxtNombre_Producto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre_Producto.Location = New System.Drawing.Point(183, 117)
        Me.TxtNombre_Producto.MaxLength = 200
        Me.TxtNombre_Producto.Name = "TxtNombre_Producto"
        Me.TxtNombre_Producto.Size = New System.Drawing.Size(130, 20)
        Me.TxtNombre_Producto.TabIndex = 19
        '
        'TxtId_Producto
        '
        Me.TxtId_Producto.Location = New System.Drawing.Point(183, 86)
        Me.TxtId_Producto.Name = "TxtId_Producto"
        Me.TxtId_Producto.ReadOnly = True
        Me.TxtId_Producto.Size = New System.Drawing.Size(60, 20)
        Me.TxtId_Producto.TabIndex = 18
        Me.TxtId_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DrdAdministrador
        '
        Me.DrdAdministrador.AllowUserToAddRows = False
        Me.DrdAdministrador.AllowUserToDeleteRows = False
        Me.DrdAdministrador.AutoGenerateColumns = False
        Me.DrdAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DrdAdministrador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAdministradorDataGridViewTextBoxColumn, Me.NombreAdministradorDataGridViewTextBoxColumn})
        Me.DrdAdministrador.DataSource = Me.ProductoBindingSource
        Me.DrdAdministrador.Location = New System.Drawing.Point(397, 37)
        Me.DrdAdministrador.MultiSelect = False
        Me.DrdAdministrador.Name = "DrdAdministrador"
        Me.DrdAdministrador.ReadOnly = True
        Me.DrdAdministrador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DrdAdministrador.Size = New System.Drawing.Size(253, 150)
        Me.DrdAdministrador.TabIndex = 23
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(627, 221)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 27
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(546, 221)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 26
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(465, 221)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 25
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.Location = New System.Drawing.Point(377, 221)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrabar.TabIndex = 24
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataSource = GetType(artemis.producto)
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
        'PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 361)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.DrdAdministrador)
        Me.Controls.Add(Me.TxtPrecio_Producto)
        Me.Controls.Add(Me.TxtTipo_Producto)
        Me.Controls.Add(Me.TxtNombre_Producto)
        Me.Controls.Add(Me.TxtId_Producto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PRODUCTOS"
        Me.Text = "PRODUCTOS"
        CType(Me.DrdAdministrador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio_Producto As System.Windows.Forms.TextBox
    Friend WithEvents TxtTipo_Producto As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre_Producto As System.Windows.Forms.TextBox
    Friend WithEvents TxtId_Producto As System.Windows.Forms.TextBox
    Friend WithEvents DrdAdministrador As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents IdAdministradorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreAdministradorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
End Class
