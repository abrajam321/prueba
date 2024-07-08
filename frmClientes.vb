Imports MySql.Data.MySqlClient

Public Class frmClientes

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dispose()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtId_Empleado.Text = 0
        TxtNombre_Empleado.Clear()
        TxtArea_Trabajo.Clear()
        TxtApellidos_Empleado.Clear()
        TxtTitulo.Clear()
        TxtNombre_Empleado.Focus()
    End Sub

    Private Sub TxtNombre_Empleado_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNombre_Empleado.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtArea_Trabajo.Focus()
        End If
    End Sub

    Private Sub TxtArea_Trabajo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtArea_Trabajo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtApellidos_Empleado.Focus()
        End If
    End Sub

    Private Sub TxtTitulo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTitulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnGrabar.Focus()
        End If
    End Sub

    Private Sub TxtApellidos_Empleado_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtApellidos_Empleado.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTitulo.Focus()
        End If
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString =
            "server= localhost;Port=3306;Database=empresa;Uid=root;Pwd= ;"

        Try
            Conexion.Open()

            MessageBox.Show("Operación realizada")

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error" & ex.Message)
        End Try
    End Sub

End Class