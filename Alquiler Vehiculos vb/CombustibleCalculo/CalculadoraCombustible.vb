Namespace CombustibleCalculo
    'Henry MAldonado RUben RIvera Michael Aparicio
    Public Class CalculadoraCombustible


        Public Sub CalcularConsumoCombustible(distanciaKm As Double, rendimientoKmPorLitro As Double, precioPorLitro As Double, ByRef combustibleNecesario As Double, ByRef costoTotal As Double)
            ' Validación de parámetros
            If rendimientoKmPorLitro <= 0 Then
                Throw New Exception("El rendimiento debe ser mayor a 0")
            End If

            ' Calcular el combustible necesario y el costo total
            combustibleNecesario = distanciaKm / rendimientoKmPorLitro
            costoTotal = combustibleNecesario * precioPorLitro
        End Sub
    End Class
End Namespace
