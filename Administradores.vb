Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class Administradores
    Public Shared Function RecuperarTodosLosAdministradores() As BindingList(Of Frm_Administrador)
        Dim Retorno As New BindingList(Of Frm_Administrador)

        Dim conexion As New MySqlConnection
        conexion.ConnectionString =
        "server= localhost;Port=3306;Database=empresa;Uid=root;Pwd= ;"
        Try
            conexion.Open()
            'Comando
            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarAdministrador "
            Comando.Parameters.AddWithValue("ParOcion", 1)
            Comando.Parameters.AddWithValue("ParId", 0)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read
                    Dim Obj As New Frm_Administrador

                    Obj.Txtid_Administrador = Lector.GetValue(0)
                    Obj.TxtNombre_Administrador = Lector.GetValue(1)

                    Retorno.Add(Obj)
                End While
            End If

        Catch ex As Exception
            Throw
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
        Return Retorno
    End Function

    Public Shared Function RecuperarAdministradores(ByVal Id_Administrador As Integer) As Administradores
        Dim retorno As New Administradores
        '
        '     'CONEXION CON LA BASE DE DATOS 
        Dim conexion As New MySqlConnection
        conexion.ConnectionString =
            "server=localhost;port=3306;Database=empresa;Uid=root;Pwd=;"
        '
        Try
            conexion.Open()
            '
            'COMANDO
            Dim comando As New MySqlCommand
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText() = "pa_ConsultarAdministradores"
            comando.Parameters.AddWithValue("parOpcion", 2)
            comando.Parameters.AddWithValue("parId", Id_Administrador)

            Dim Lector As MySqlDataReader
            Lector = comando.ExecuteReader
            '
            If Lector.HasRows Then
                While Lector.Read

                    'dim obj as new Administrador

                    retorno.Id_Administrador = Lector.GetValue(0)
                    retorno.Nombre_Administrador = Lector.GetValue(1)
                    retorno.Area_Laboral = Lector.GetValue(2)
                    retorno.Telefono_Administrador = Lector.GetValue(3)
                    retorno.Correo_Administrador = Lector.GetValue(4)

                    '

                End While
            End If

        Catch ex As Exception
            Throw

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try

        Return retorno
    End Function

    Public Shared Function InsertarAdministradores(ByVal ObjetAdministrador As Frm_Administrador) As Integer
        Dim Retorno As Integer

        'CONEXION CON LA BASE DE DATOS
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString =
        "server= localhost;Port=3306;Database=empresa;Uid=root;Pwd= ;"
        Try
            Conexion.Open()
            'COMANDO
            Dim comando As New MySqlCommand
            comando.Connection = Conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "Pa_InsertarAdministrador"
            comando.Parameters.AddWithValue("ParOpcion", 1)
            comando.Parameters.AddWithValue("PaNombre_Administrador", ObjetAdministrador.TxtNombre_Administrador)
            comando.Parameters.AddWithValue("ParArea_Laboral", ObjetAdministrador.TxtArea_Laboral)
            comando.Parameters.AddWithValue("ParTelefono_Administrador", ObjetAdministrador.TxtTelefono_Administrador)
            comando.Parameters.AddWithValue("ParCorreo_Administrador", ObjetAdministrador.TxtCorreo_Administrador)

            Retorno = comando.ExecuteScalar
        Catch ex As Exception
            Throw

        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
        Return Retorno

    End Function

    Public Shadows Sub EditadorAdministradores(ByVal ObjetAdministrador As Frm_Administrador)
        '
        '   'CONEXION CON LA BASE DE DATOS
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString =
        "server= localhost;Port=3306;Database=empresa;Uid=root;Pwd= ;"
        '
        Try
            Conexion.Open()
            ' 
            'COMANDO
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText() = "Pa_EditarAdministrador"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParNombre_Administrador", ObjetAdministrador.TxtNombre_Administrador)
            Comando.Parameters.AddWithValue("ParArea_Laboral", ObjetAdministrador.TxtArea_Laboral)
            Comando.Parameters.AddWithValue("ParTelefono_Administrador", ObjetAdministrador.TxtTelefono_Administrador)
            Comando.Parameters.AddWithValue("ParCorreo_Administrador", ObjetAdministrador.TxtCorreo_Administrador)
            Comando.Parameters.AddWithValue("ParId", ObjetAdministrador.Txtid_Administrador)

            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw

        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

    End Sub
    Public Shared Sub EliminarAdministradores(ByVal ObjetAdministrador As Frm_Administrador)
        '
        '   'CONEXION CON LA BASE DE DATOS
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString =
        "server= localhost;Port=3306;Database=empresa;Uid=root;Pwd= ;"
        '
        Try
            Conexion.Open()
            '
            'COMANDO
            Dim comando As New MySqlCommand
            comando.Connection = Conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText() = "Pa_EliminarAdministradores"
            comando.Parameters.AddWithValue("ParOpcion", 1)
            comando.Parameters.AddWithValue("ParId", ObjetAdministrador.Id_Administrador)

            comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw

        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
    End Sub

    Private _Id_Administrador As Integer
    Public Property Id_Administrador As Integer
        Get
            Return Id_Administrador
        End Get
        Set(value As Integer)
            _Id_Administrador = value
        End Set
    End Property

    Private _Nombre_Administrador As String
    Public Property Nombre_Administrador As String
        Get
            Return _Nombre_Administrador
        End Get
        Set(value As String)
            _Nombre_Administrador = value
        End Set
    End Property

    Private _Area_Laboral As String
    Public Property Area_Laboral As String
        Get
            Return _Area_Laboral
        End Get
        Set(value As String)
            _Area_Laboral = value
        End Set
    End Property

    Private _Telefono_Administrador As String
    Public Property Telefono_Administrador As String
        Get
            Return _Telefono_Administrador
        End Get
        Set(value As String)
            _Telefono_Administrador = value
        End Set
    End Property

    Private _TxtCorreo_Administrador As String
    Public Property Correo_Administrador As String
        Get
            Return _TxtCorreo_Administrador
        End Get
        Set(value As String)
            _TxtCorreo_Administrador = value
        End Set
    End Property

    Shared Sub EditarAdministradores(NuevoAdministrador As Frm_Administrador)
        Throw New NotImplementedException
    End Sub

End Class
