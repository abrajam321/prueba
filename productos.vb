Imports MySql.Data.MySqlClient

Public Class PRODUCTOS

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dispose()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtId_Producto.Text = 0
        TxtNombre_Producto.Clear()
        TxtTipo_Producto.Clear()
        TxtPrecio_Producto.Clear()
        TxtNombre_Producto.Focus()
    End Sub

    Private Sub TxtNombre_Producto_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNombre_Producto.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTipo_Producto.Focus()
        End If
    End Sub

    Private Sub TxtTipo_Producto_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTipo_Producto.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPrecio_Producto.Focus()
        End If
    End Sub

    Private Sub TxtPrecio_Producto_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPrecio_Producto.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNombre_Producto.Focus()
        End If
    End Sub

    Private Sub PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString =
            "server=localhost;Port=3306;Database=empresa;Uid=root;pwd= ;"
        Try
            Conexion.Open()
            MessageBox.Show("Operación realizada")
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error" & ex.Message)

        End Try
    End Sub
End Class