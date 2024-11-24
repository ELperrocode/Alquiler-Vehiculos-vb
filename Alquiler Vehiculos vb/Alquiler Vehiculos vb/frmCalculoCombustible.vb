'Henry MAldonado RUben RIvera Michael Aparicio
Public Class frmCalculoCombustible
    Private vehiculoLogica As New VehiculoLogica()

    Private Sub frmCalculoCombustible_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar ComboBox de Marcas desde el diccionario
        cmbMarcas.DataSource = vehiculoLogica.ObtenerMarcas()
    End Sub

    Private Sub cmbMarcas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMarcas.SelectedIndexChanged
        ' Obtener la marca seleccionada
        Dim marcaSeleccionada As String = cmbMarcas.SelectedItem.ToString()

        ' Llenar ComboBox de Modelos según la marca seleccionada
        cmbModelos.DataSource = vehiculoLogica.ObtenerModelosPorMarca(marcaSeleccionada)
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            ' Validar entradas de texto a Double
            Dim distanciaKm As Double
            If Not Double.TryParse(txtDistanciaKm.Text, distanciaKm) Then
                MessageBox.Show("Por favor ingrese una distancia válida.")
                Return
            End If

            Dim precioPorLitro As Double
            If Not Double.TryParse(txtPrecioLitro.Text, precioPorLitro) Then
                MessageBox.Show("Por favor ingrese un precio válido por litro.")
                Return
            End If

            ' Obtener el modelo seleccionado
            Dim modeloSeleccionado As String = cmbModelos.SelectedItem.ToString()


            Dim dt As DataTable = vehiculoLogica.ObtenerMarcasConRendimiento()


            Dim rendimientoKmPorLitro As Double = 0
            For Each row As DataRow In dt.Rows
                If row("Modelo").ToString() = modeloSeleccionado Then

                    If Not Double.TryParse(row("RendimientoKmPorLitro").ToString(), rendimientoKmPorLitro) Then
                        MessageBox.Show("El rendimiento del modelo seleccionado no es un valor numérico válido.")
                        Return
                    End If
                    Exit For
                End If
            Next


            If rendimientoKmPorLitro <= 0 Then
                MessageBox.Show("El rendimiento del modelo seleccionado no es válido.")
                Return
            End If


            Dim combustibleNecesario As Double
            Dim costoTotal As Double

            vehiculoLogica.CalcularConsumoCombustible(distanciaKm, rendimientoKmPorLitro, precioPorLitro, combustibleNecesario, costoTotal)


            txtCombustibleNecesario.Text = $"{combustibleNecesario:F2} litros"
            txtCostoTotal.Text = $"{costoTotal:C}"

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


End Class
