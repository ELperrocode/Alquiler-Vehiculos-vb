Public Class Form1
    Dim vehiculoLogica As New VehiculoLogica
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMarcas()
    End Sub
    ' Cargar las marcas en el ComboBox de Marca
    Sub CargarMarcas()
        cbMarca.Items.Clear()
        Dim marcas As List(Of String) = VehiculoLogica.ObtenerMarcas()

        For Each marca As String In marcas
            cbMarca.Items.Add(marca)
        Next
    End Sub
    Sub CargarModelos(marca As String)
        cbModelo.Items.Clear() ' Limpiar los modelos anteriores

        Dim modelos As List(Of String) = vehiculoLogica.ObtenerModelosPorMarca(marca)

        For Each modelo As String In modelos
            cbModelo.Items.Add(modelo)
        Next
    End Sub

    Private Sub cbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMarca.SelectedIndexChanged
        If cbMarca.SelectedItem IsNot Nothing Then
            Dim marcaSeleccionada As String = cbMarca.SelectedItem.ToString()
            CargarModelos(marcaSeleccionada)
        End If
    End Sub
    Sub LimpiarCampos()
        cbMarca.SelectedIndex = -1
        cbModelo.SelectedIndex = -1
        txtAnio.Clear()
        txtPrecioPorDia.Clear()

    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Try
            Dim marca As String = cbMarca.SelectedItem.ToString()
            Dim modelo As String = cbModelo.SelectedItem.ToString()
            Dim año As Integer = Convert.ToInt32(txtAnio.Text)
            Dim precio As Decimal = Convert.ToDecimal(txtPrecioPorDia.Text)
            Dim disponibilidad As Boolean = True

            ' Llamar a la capa de lógica de negocio para insertar el vehículo
            vehiculoLogica.InsertarVehiculo(marca, modelo, año, precio, disponibilidad)

            ' Mostrar mensaje de éxito
            MessageBox.Show("Vehículo agregado correctamente con ID generado automáticamente.")


        Catch ex As Exception
            MessageBox.Show("Error al agregar vehículo: " & ex.Message)
        Finally
            LimpiarCampos()
        End Try
    End Sub

    Private Sub btRetornar_Click(sender As Object, e As EventArgs) Handles btRetornar.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
