<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.dgvVehiculos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btReservar = New System.Windows.Forms.Button()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.lbCantidadDias = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btRetornar = New System.Windows.Forms.Button()
        CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvVehiculos
        '
        Me.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehiculos.Location = New System.Drawing.Point(13, 13)
        Me.dgvVehiculos.Name = "dgvVehiculos"
        Me.dgvVehiculos.RowHeadersWidth = 51
        Me.dgvVehiculos.RowTemplate.Height = 24
        Me.dgvVehiculos.Size = New System.Drawing.Size(963, 309)
        Me.dgvVehiculos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btReservar)
        Me.GroupBox1.Controls.Add(Me.dtpFinal)
        Me.GroupBox1.Controls.Add(Me.lbPrecio)
        Me.GroupBox1.Controls.Add(Me.lbCantidadDias)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpInicio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 350)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 237)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de reserva"
        Me.GroupBox1.UseWaitCursor = True
        '
        'btReservar
        '
        Me.btReservar.Location = New System.Drawing.Point(600, 185)
        Me.btReservar.Name = "btReservar"
        Me.btReservar.Size = New System.Drawing.Size(116, 46)
        Me.btReservar.TabIndex = 7
        Me.btReservar.Text = "Reservar"
        Me.btReservar.UseVisualStyleBackColor = True
        Me.btReservar.UseWaitCursor = True
        '
        'dtpFinal
        '
        Me.dtpFinal.Location = New System.Drawing.Point(164, 79)
        Me.dtpFinal.MaxDate = New Date(2109, 11, 30, 0, 0, 0, 0)
        Me.dtpFinal.MinDate = New Date(2024, 10, 12, 0, 0, 0, 0)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(336, 28)
        Me.dtpFinal.TabIndex = 6
        Me.dtpFinal.UseWaitCursor = True
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Location = New System.Drawing.Point(30, 187)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(0, 22)
        Me.lbPrecio.TabIndex = 5
        Me.lbPrecio.UseWaitCursor = True
        '
        'lbCantidadDias
        '
        Me.lbCantidadDias.AutoSize = True
        Me.lbCantidadDias.Location = New System.Drawing.Point(26, 142)
        Me.lbCantidadDias.Name = "lbCantidadDias"
        Me.lbCantidadDias.Size = New System.Drawing.Size(0, 22)
        Me.lbCantidadDias.TabIndex = 4
        Me.lbCantidadDias.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha final: "
        Me.Label2.UseWaitCursor = True
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(164, 29)
        Me.dtpInicio.MaxDate = New Date(2109, 11, 30, 0, 0, 0, 0)
        Me.dtpInicio.MinDate = New Date(2024, 10, 12, 0, 0, 0, 0)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(336, 28)
        Me.dtpInicio.TabIndex = 1
        Me.dtpInicio.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de inicio: "
        Me.Label1.UseWaitCursor = True
        '
        'btRetornar
        '
        Me.btRetornar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRetornar.Location = New System.Drawing.Point(858, 535)
        Me.btRetornar.Name = "btRetornar"
        Me.btRetornar.Size = New System.Drawing.Size(118, 46)
        Me.btRetornar.TabIndex = 3
        Me.btRetornar.Text = "Retornar"
        Me.btRetornar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 690)
        Me.Controls.Add(Me.btRetornar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvVehiculos)
        Me.Name = "Form2"
        Me.Text = "Vehiculos Disponibles"
        CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvVehiculos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btReservar As Button
    Friend WithEvents dtpFinal As DateTimePicker
    Friend WithEvents lbPrecio As Label
    Friend WithEvents lbCantidadDias As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btRetornar As Button
End Class
