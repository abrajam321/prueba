Imports MySql.Data.MySqlClient

Public Class Frm_Administrador

    Private Property Nombre_Administrador As String

    Private Property Area_Laboral As String

    Private Property Telefono_Administrador As String

    Private Property Correo_Administrador As String

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dispose()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Txtid_Administrador.Text = 0
        TxtNombre_Administrador.Clear()
        TxtArea_Laboral.Clear()
        TxtTelefono_Administrador.Clear()
        TxtCorreo_Administrador.Clear()
        TxtNombre_Administrador.Focus()
    End Sub

    Private Sub TxtNombre_Administrador_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNombre_Administrador.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtArea_Laboral.Focus()
        End If
    End Sub

    Private Sub TxtArea_Laboral_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtArea_Laboral.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTelefono_Administrador.Focus()
        End If
    End Sub

    Private Sub TxtTelefono_Administrador_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTelefono_Administrador.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCorreo_Administrador.Focus()
        End If
    End Sub

    Private Sub TxtCorreo_Administrador_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCorreo_Administrador.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnGrabar.Focus()
        End If
    End Sub

    Private Sub Frm_Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GrdAdministrador.DataSource =
                Administradores.RecuperarTodosLosAdministradores
        Catch ex As Exception
            MessageBox.Show("Ocurrio este eror: " & ex.Message)
        End Try

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

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Try
            Dim NuevoAdministrador As New Frm_Administrador
            Dim Id_Administrador As Integer
            'NuevoAdministrador.Id_Administrador = TxtId_Administrrador.Text
            NuevoAdministrador.Nombre_Administrador = TxtNombre_Administrador.Text.Trim
            NuevoAdministrador.Area_Laboral = TxtArea_Laboral.Text.Trim
            NuevoAdministrador.Telefono_Administrador = TxtTelefono_Administrador.Text.Trim
            NuevoAdministrador.Correo_Administrador = TxtCorreo_Administrador.Text.Trim

            If Txtid_Administrador.Text = 0 Then
                Id_Administrador =
                  Administradores.InsertarAdministradores(NuevoAdministrador)
            Else
                Administradores.EditarAdministradores(NuevoAdministrador)
            End If
            BtnNuevo_Click(Nothing, Nothing)

            'Muestra la tabla de datos
            GrdAdministrador.DataSource =
                Administradores.RecuperarTodosLosAdministradores

            MessageBox.Show("Operacion realizada ")
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error" & ex.Message)
        End Try
    End Sub

    Function Id_Administrador() As Object
        Throw New NotImplementedException
    End Function

End Class