Imports System.Data.SqlClient

Public Class BDHelper

    'Aca llamamos al metodo stringDeConexion que se nos devuelve un string con la conexion.
    Private Shared string_conexion As String = StringDeConexion.stringDeConexion

    Public Shared Function EjecutarSQL(ByVal strSql As String) As Integer

        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New Data.DataTable

        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Shared Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            tabla.Load(cmd.ExecuteReader())
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Shared Function getNombreTipoDispositivo(codigo As Integer) As String
        Return ConsultaSQL("SELECT descripcion FROM TipoDispositivo WHERE codTipo = " & codigo).ToString

    End Function

    Public Shared Function getTipoDispositivo() As DataTable
        Return ConsultaSQL("SELECT * FROM TipoDispositivo where baja = 1")
    End Function

    Public Shared Sub setDispositivo(nombre As String, descripcion As String, codTipo As Integer)
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New Data.DataTable

        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Dispositivo (nombre, descripcion, codTipo) " & _
                                                  "VALUES ('" & nombre & "', '" & descripcion & "' ," & codTipo & ")"
            cmd.ExecuteNonQuery()
            MsgBox("Se agrego el registro correctamente")

        Catch ex As Exception
            MsgBox("Hubo un error al guardar el registro")
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub

    Public Shared Function getDispositivo() As DataTable
        Return ConsultaSQL("SELECT * FROM Dispositivo WHERE baja = 1")
    End Function

    Public Shared Function getArea() As DataTable
        Return ConsultaSQL("SELECT * FROM Area WHERE baja = 1")
    End Function

    Public Shared Sub setTipoDispositivo(descripcion As String)
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New Data.DataTable

        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO TipoDispositivo (descripcion) " & _
                                                  "VALUES ('" & descripcion & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Se agrego el nuevo Tipo correctamente")

        Catch ex As Exception
            MsgBox("Hubo un error al guardar el nuevo Tipo")
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub

    Public Shared Sub bajaDispositivo(codDispositivo)
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New Data.DataTable

        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE Dispositivo SET baja = 0 WHERE codDispositivo = " & codDispositivo
            cmd.ExecuteNonQuery()
            MsgBox("Se borro exitosamente")

        Catch ex As Exception
            MsgBox("Hubo un error al borrar el dispositivo")
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub

    Public Shared Sub modificarDispositivo(codDispositivo, nombre, descripcion, codTipo)
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New Data.DataTable

        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE Dispositivo SET nombre = '" & nombre & "', descripcion = '" & descripcion & "', codTipo = " & codTipo _
                & "WHERE codDispositivo = " & codDispositivo
            cmd.ExecuteNonQuery()
            MsgBox("Se modifico exitosamente")

        Catch ex As Exception
            MsgBox("Hubo un error al modificar el dispositivo")
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub

    Public Shared Function datosTabla(ByVal nombreTabla As String)
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * from" + nombreTabla + "where baja = 1"
            tabla.Load(cmd.ExecuteReader())

        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return tabla
    End Function


End Class
