Imports System.Data.SqlClient

Public Class VehiculoBd
    Private connectionString As String = "Data Source=localhost;Initial Catalog=AgenciaAlquiler;Integrated Security=True"

    ' Insertar un nuevo vehículo 
    Public Sub InsertarVehiculo(marca As String, modelo As String, año As Integer, precio As Decimal, disponibilidad As Boolean)
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("InsertarVehiculo", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Marca", marca)
            command.Parameters.AddWithValue("@Modelo", modelo)
            command.Parameters.AddWithValue("@Año", año)
            command.Parameters.AddWithValue("@PrecioPorDia", precio)
            command.Parameters.AddWithValue("@Disponibilidad", disponibilidad)

            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub
    'Obtener vehiculos disponibles
    Public Function ObtenerVehiculosDisponibles() As DataTable
        Dim dt As New DataTable()

        Using connection As New SqlConnection(connectionString)
            ' Crear el comando para ejecutar el procedimiento almacenado
            Dim command As New SqlCommand("ObtenerVehiculosDisponibles", connection)
            command.CommandType = CommandType.StoredProcedure

            ' Usar SqlDataAdapter para llenar el DataTable con los resultados
            Dim adapter As New SqlDataAdapter(command)

            connection.Open()
            adapter.Fill(dt)
        End Using

        Return dt
    End Function
    Public Sub InsertarReserva(idVehiculo As String, fechaInicio As Date, fechaFinal As Date, diasAlquiler As Integer, precioTotal As Decimal)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Crear un SqlCommand para ejecutar el procedimiento almacenado
                Using cmd As New SqlCommand("InsertarReserva", connection)
                    cmd.CommandType = CommandType.StoredProcedure

                    ' Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo)
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFinal)
                    cmd.Parameters.AddWithValue("@Dias", diasAlquiler)
                    cmd.Parameters.AddWithValue("@PrecioTotal", precioTotal)

                    ' Ejecutar el procedimiento
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al insertar la reserva: " & ex.Message)
        End Try
    End Sub

    ' Método para obtener marcas, modelos y rendimiento de combustible de la base de datos
    Public Function ObtenerMarcasConRendimiento() As DataTable
        Dim dt As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT Marca, Modelo, RendimientoKmPorLitro FROM Vehiculos"
            Dim command As New SqlCommand(query, connection)

            ' Usar SqlDataAdapter para llenar el DataTable con los resultados
            Dim adapter As New SqlDataAdapter(command)

            connection.Open()
            adapter.Fill(dt)
        End Using

        Return dt
    End Function

End Class
