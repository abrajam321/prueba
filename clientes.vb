Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class clientes
    Public Shared Function RecuperarTodosLosAdministradores() As BindingList(Of clientes)
        Dim Retorno As New BindingList(Of clientes)

        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString =
"server= localhost;Port=3306;Database=empresa;Uid=root;Pwd= ;"
        Try
            Conexion.Open()
            'Comando
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_Consultarclientes"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParId", 0)

            Dim Lector As MySqlDataAdapter
            Lector = Comando.EndExecuteReader

            If Lector.HasRows Then
                While Lector.Read
                    Dim Obj As New Administradores

                    Obj.Id_Administrador = Lector.GetValue(0)
                    Obj.Nombre_Administrador = Lector.GetValue(1)

                    Retorno.Add(Obj)
                End While
            End If

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
            Return Retorno
        End Try

    End Function

    Private _Id_Empleado As Integer
    Public Property Id_Empleado As Integer
        Get
            Return _Id_Empleado
        End Get
        Set(value As Integer)
            _Id_Empleado = value
        End Set
    End Property

    Private _Nombre_Empleado As String
    Public Property Nombre_Empleado As String
        Get
            Return _Nombre_Empleado
        End Get
        Set(value As String)
            _Nombre_Empleado = value
        End Set
    End Property

    Private _Area_Trabajo As String
    Public Property Area_Trabajo As String
        Get
            Return _Area_Trabajo
        End Get
        Set(value As String)
            _Area_Trabajo = value
        End Set
    End Property

    Private _Apellidos_Empleado As String
    Public Property Apellidos_Empleado As String
        Get
            Return _Apellidos_Empleado
        End Get
        Set(value As String)
            _Apellidos_Empleado = value
        End Set
    End Property

    Private _Titulo As String
    Public Property Titulo As String
        Get
            Return _Titulo
        End Get
        Set(value As String)
            _Titulo = value
        End Set
    End Property
End Class
