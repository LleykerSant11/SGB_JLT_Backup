Imports System.Data.Sql
Imports System.Data.SqlClient
Module conexion
    Public conexion1 As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Sub abrir()
        Try
            conexion1 = New SqlConnection("Data Source=LAPTOP-3AS1QTB4\SQLEXPRESS;Initial Catalog=BD_BIBLIOTECA_V2;Integrated Security=True")
            conexion1.Open()
        Catch ex As Exception
            MsgBox("No se pudo Conectar" + ex.ToString)
        End Try
    End Sub
End Module
