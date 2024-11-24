Public Class Form2
    Dim vehiculoLogica As New VehiculoLogica
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVehiculosDisponibles()
    End Sub
    Sub CargarVehiculosDisponibles()
        Dim dtVehiculos As DataTable = VehiculoLogica.ObtenerVehiculosDisponibles()

        dgvVehiculos.DataSource = dtVehiculos
    End Sub

    Private Sub dgvVehiculos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVehiculos.SelectionChanged

        lbCantidadDias.Text = ""
        lbPrecio.Text = ""
    End Sub

    Private Sub dtpFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpFinal.ValueChanged
        If dtpFinal.Value < dtpInicio.Value Then
            MessageBox.Show("La fecha de fin debe ser posterior a la fecha de inicio.")
            lbCantidadDias.Text = ""
            lbPrecio.Text = ""
            Return
        End If

        ' Calcular la cantidad de días
        Dim dias As Integer = (dtpFinal.Value - dtpInicio.Value).Days + 1 ' Incluir el día de inicio
        lbCantidadDias.Text = "La cantidad de días a reservar es: " & dias.ToString()


        If dgvVehiculos.SelectedRows.Count > 0 Then
            Dim precioPorDia As Decimal = Convert.ToDecimal(dgvVehiculos.SelectedRows(0).Cells("PrecioPorDia").Value)


            Dim precioTotal As Decimal = dias * precioPorDia
            lbPrecio.Text = "El precio total a pagar es: " & precioTotal.ToString("F2")
        End If
    End Sub

    Private Sub btReservar_Click(sender As Object, e As EventArgs) Handles btReservar.Click
        If dgvVehiculos.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un vehículo.")
            Return
        End If

        ' Obtener el vehículo seleccionado y sus datos
        Dim rowIndex As Integer = dgvVehiculos.SelectedRows(0).Index
        Dim idVehiculo As String = dgvVehiculos.SelectedRows(0).Cells("idVehiculo").Value.ToString()
        Dim precioPorDia As Decimal = Convert.ToDecimal(dgvVehiculos.SelectedRows(0).Cells("PrecioPorDia").Value)

        ' Calcular la cantidad de días y el precio total
        Dim fechaInicio As Date = dtpInicio.Value
        Dim fechaFinal As Date = dtpFinal.Value
        Dim diasAlquiler As Integer = (fechaFinal - fechaInicio).Days

        ' Validar que los días sean positivos
        If diasAlquiler <= 0 Then
            MessageBox.Show("La fecha final debe ser posterior a la fecha de inicio.")
            Return
        End If
        ' Procesar la reserva
        Try
            vehiculoLogica.ProcesarReserva(idVehiculo, fechaInicio, fechaFinal, precioPorDia)
            MessageBox.Show("Reserva guardada exitosamente.")


        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al procesar la reserva: " & ex.Message)

        Finally
            lbCantidadDias.Text = ""
            lbPrecio.Text = ""
            dtpFinal.Value = Date.Now
            dtpInicio.Value = Date.Now
            CargarVehiculosDisponibles()
        End Try


    End Sub

    Private Sub btRetornar_Click(sender As Object, e As EventArgs) Handles btRetornar.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub
End Class