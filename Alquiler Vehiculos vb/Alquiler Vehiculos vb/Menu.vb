Public Class MenuPrincipal
    'Henry MAldonado RUben RIvera Michael Aparicio
    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btConsultar_Click(sender As Object, e As EventArgs) Handles btConsultar.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btCalcularConsumo_Click(sender As Object, e As EventArgs) Handles btCalcularConsumo.Click
        frmCalculoCombustible.Show()
        Me.Hide()
    End Sub

End Class