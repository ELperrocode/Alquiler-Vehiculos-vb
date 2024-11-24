<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculoCombustible
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbMarcas = New System.Windows.Forms.ComboBox()
        Me.cmbModelos = New System.Windows.Forms.ComboBox()
        Me.txtDistanciaKm = New System.Windows.Forms.TextBox()
        Me.txtPrecioLitro = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtCombustibleNecesario = New System.Windows.Forms.Label()
        Me.txtCostoTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbMarcas
        '
        Me.cmbMarcas.FormattingEnabled = True
        Me.cmbMarcas.Location = New System.Drawing.Point(103, 105)
        Me.cmbMarcas.Name = "cmbMarcas"
        Me.cmbMarcas.Size = New System.Drawing.Size(121, 21)
        Me.cmbMarcas.TabIndex = 0
        '
        'cmbModelos
        '
        Me.cmbModelos.FormattingEnabled = True
        Me.cmbModelos.Location = New System.Drawing.Point(103, 170)
        Me.cmbModelos.Name = "cmbModelos"
        Me.cmbModelos.Size = New System.Drawing.Size(121, 21)
        Me.cmbModelos.TabIndex = 1
        '
        'txtDistanciaKm
        '
        Me.txtDistanciaKm.Location = New System.Drawing.Point(279, 171)
        Me.txtDistanciaKm.MaxLength = 10
        Me.txtDistanciaKm.Name = "txtDistanciaKm"
        Me.txtDistanciaKm.Size = New System.Drawing.Size(100, 20)
        Me.txtDistanciaKm.TabIndex = 2
        '
        'txtPrecioLitro
        '
        Me.txtPrecioLitro.Location = New System.Drawing.Point(436, 170)
        Me.txtPrecioLitro.MaxLength = 10
        Me.txtPrecioLitro.Name = "txtPrecioLitro"
        Me.txtPrecioLitro.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioLitro.TabIndex = 3
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(279, 227)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtCombustibleNecesario
        '
        Me.txtCombustibleNecesario.AutoSize = True
        Me.txtCombustibleNecesario.Location = New System.Drawing.Point(397, 289)
        Me.txtCombustibleNecesario.Name = "txtCombustibleNecesario"
        Me.txtCombustibleNecesario.Size = New System.Drawing.Size(13, 13)
        Me.txtCombustibleNecesario.TabIndex = 5
        Me.txtCombustibleNecesario.Text = "0"
        '
        'txtCostoTotal
        '
        Me.txtCostoTotal.AutoSize = True
        Me.txtCostoTotal.Location = New System.Drawing.Point(397, 321)
        Me.txtCostoTotal.Name = "txtCostoTotal"
        Me.txtCostoTotal.Size = New System.Drawing.Size(13, 13)
        Me.txtCostoTotal.TabIndex = 7
        Me.txtCostoTotal.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(355, 37)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Calculo de Combustible"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ingrese Distancia a Recorrer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Costo del Combustible "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Combustible Necesario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(433, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ingrese Precio del combustible"
        '
        'frmCalculoCombustible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCostoTotal)
        Me.Controls.Add(Me.txtCombustibleNecesario)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtPrecioLitro)
        Me.Controls.Add(Me.txtDistanciaKm)
        Me.Controls.Add(Me.cmbModelos)
        Me.Controls.Add(Me.cmbMarcas)
        Me.Name = "frmCalculoCombustible"
        Me.Text = "frmCalculoCombustible"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbMarcas As ComboBox
    Friend WithEvents cmbModelos As ComboBox
    Friend WithEvents txtDistanciaKm As TextBox
    Friend WithEvents txtPrecioLitro As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtCombustibleNecesario As Label
    Friend WithEvents txtCostoTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
