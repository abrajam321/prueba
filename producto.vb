Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class producto



    Private _Id_Producto As Integer
    Public Property Id_Producto As Integer
        Get
            Return _Id_Producto
        End Get
        Set(value As Integer)
            _Id_Producto = value
        End Set
    End Property

    Private _Nombre_Producto As String
    Public Property Nombre_Producto As String
        Get
            Return _Nombre_Producto
        End Get
        Set(value As String)
            _Id_Producto = value
        End Set
    End Property

    Private _Tipo_Producto As String
    Public Property Tipo_Producto As String
        Get
            Return _Tipo_Producto
        End Get
        Set(value As String)
            _Tipo_Producto = value
        End Set
    End Property

    Private _Telefono_Producto As String
    Public Property Telefono_Producto As String
        Get
            Return _Telefono_Producto
        End Get
        Set(value As String)
            _Telefono_Producto = value
        End Set
    End Property

End Class
