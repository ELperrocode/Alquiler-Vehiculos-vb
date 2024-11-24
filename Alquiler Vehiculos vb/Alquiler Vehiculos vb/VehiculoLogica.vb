'Henry MAldonado RUben RIvera Michael Aparicio
Imports CombustibleCalculo
Imports CombustibleCalculo.CombustibleCalculo

Public Class VehiculoLogica
    Private vehiculoQuery As New VehiculoBd()
    Private calculadoraCombustible As New CalculadoraCombustible()

    ' Diccionario que relaciona marcas con sus modelos
    Public MarcasYModelos As New Dictionary(Of String, List(Of String)) From {
        {"Toyota", New List(Of String) From {"Corolla", "Yaris", "Prado"}},
        {"Kia", New List(Of String) From {"Picanto", "Sportage", "Sorento"}},
        {"Hyundai", New List(Of String) From {"Elantra", "i10", "Tucson"}},
        {"Changan", New List(Of String) From {"Hunter", "Oshan X7", "Alsvin v3"}}
    }
    ' Método para obtener todas las marcas
    Public Function ObtenerMarcas() As List(Of String)
        Return MarcasYModelos.Keys.ToList()
    End Function

    ' Método para obtener los modelos de una marca específica
    Public Function ObtenerModelosPorMarca(marca As String) As List(Of String)
        If MarcasYModelos.ContainsKey(marca) Then
            Return MarcasYModelos(marca)
        Else
            Return New List(Of String)() ' Retorna una lista vacía si la marca no existe
        End If
    End Function

    Public Sub InsertarVehiculo(marca As String, modelo As String, año As Integer, precio As Decimal, disponibilidad As Boolean)
        ' Validar que los campos no estén vacíos o con valores inválidos
        If String.IsNullOrEmpty(marca) Or String.IsNullOrEmpty(modelo) Or año <= 2005 Or precio <= 0 Then
            Throw New Exception("Todos los campos son obligatorios y deben ser válidos")
        End If

        ' Insertar el vehículo en la base de datos 
        vehiculoQuery.InsertarVehiculo(marca, modelo, año, precio, disponibilidad)
    End Sub

    Public Function ObtenerVehiculosDisponibles() As DataTable
        Return vehiculoQuery.ObtenerVehiculosDisponibles()
    End Function

    Sub ProcesarReserva(idVehiculo As String, fechaInicio As Date, fechaFinal As Date, precioPorDia As Decimal)
        Dim diasAlquiler As Integer = (fechaFinal - fechaInicio).Days
        If diasAlquiler <= 0 Then
            Throw New Exception("La fecha final debe ser posterior a la fecha de inicio.")
        End If

        Dim precioTotal As Decimal = diasAlquiler * precioPorDia

        vehiculoQuery.InsertarReserva(idVehiculo, fechaInicio, fechaFinal, diasAlquiler, precioTotal)
    End Sub

    Public Function ObtenerMarcasConRendimiento() As DataTable

        Return vehiculoQuery.ObtenerMarcasConRendimiento()
    End Function


    Public Sub CalcularConsumoCombustible(distanciaKm As Double, rendimientoKmPorLitro As Double, precioPorLitro As Double, ByRef combustibleNecesario As Double, ByRef costoTotal As Double)
        calculadoraCombustible.CalcularConsumoCombustible(distanciaKm, rendimientoKmPorLitro, precioPorLitro, combustibleNecesario, costoTotal)
    End Sub



End Class
