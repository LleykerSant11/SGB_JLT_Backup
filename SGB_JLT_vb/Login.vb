Imports System.Data.SqlClient
Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click

        ' --- INICIO DE LA FUNCIÓN DE LOGIN MODIFICADA ---

        abrir() ' Llama a tu función que inicializa y abre la conexión

        ' Verifica si la conexión se abrió correctamente
        If conexion1 IsNot Nothing AndAlso conexion1.State = ConnectionState.Open Then

            Try
                ' 1. Consulta SQL: Busca el NombreApellidos en la tabla BIBLIOTECARIO
                '    AHORA USAMOS EL CAMPO "Usuario" para la verificación de credenciales.
                Dim sqlQuery As String = "SELECT NombreApellidos FROM BIBLIOTECARIO WHERE Usuario = @user AND Clave = @pass AND Estado = 'A'"

                enunciado = New SqlCommand(sqlQuery, conexion1)

                ' 2. Uso de Parámetros: Asignar valores de los TextBoxes a los parámetros
                enunciado.Parameters.AddWithValue("@user", Me.txt_usuario.Text) ' Asume txt_bibliotecario contiene el Nombre de Usuario
                enunciado.Parameters.AddWithValue("@pass", Me.txt_clave.Text)         ' Asume txt_clave contiene la Clave/Hash

                ' 3. Ejecución de la consulta
                respuesta = enunciado.ExecuteReader()

                ' 4. Verificación del resultado
                If respuesta.Read() Then
                    ' Acceso Concedido
                    MsgBox("¡Bienvenido " & respuesta("NombreApellidos").ToString() & "!", MsgBoxStyle.Information, "Acceso Concedido")

                    ' Abrir el formulario principal
                    Dim frmStar As New Inicio()
                    frmStar.Show()
                    Me.Hide()

                Else
                    ' Acceso Denegado
                    MsgBox("Usuario o Contraseña incorrectos.", MsgBoxStyle.Exclamation, "Error de Login")
                    Me.txt_clave.Clear()
                    Me.txt_usuario.Focus()
                End If

            Catch ex As Exception
                MsgBox("Error durante la verificación: " & ex.Message, MsgBoxStyle.Critical)

            Finally
                ' 5. Limpieza y cierre de recursos
                If respuesta IsNot Nothing AndAlso Not respuesta.IsClosed Then
                    respuesta.Close()
                End If
                ' Si la conexión se abrió, se debe cerrar aquí
                If conexion1 IsNot Nothing AndAlso conexion1.State = ConnectionState.Open Then
                    conexion1.Close()
                End If
            End Try

        Else
            ' Error de conexión
            MsgBox("No se pudo establecer la conexión a la base de datos.", MsgBoxStyle.Critical)
        End If

        ' --- FIN DE LA FUNCIÓN DE LOGIN MODIFICADA ---

        Dim frmInicio As New Inicio()
        frmInicio.Show()
        Me.Hide()

    End Sub

    Private Sub btn_ver_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        txt_clave.PasswordChar = ""
        btn_ver.Visible = False
        btn_ocultar.Visible = True
    End Sub

    Private Sub btn_ocultar_Click(sender As Object, e As EventArgs) Handles btn_ocultar.Click
        txt_clave.PasswordChar = "*"
        btn_ocultar.Visible = False
        btn_ver.Visible = True
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class
