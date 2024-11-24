<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btCalcularConsumo = New System.Windows.Forms.Button()
        Me.btConsultar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btCalcularConsumo)
        Me.GroupBox1.Controls.Add(Me.btConsultar)
        Me.GroupBox1.Controls.Add(Me.btAgregar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(505, 138)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Escoja una acción"
        '
        'btCalcularConsumo
        '
        Me.btCalcularConsumo.Location = New System.Drawing.Point(303, 54)
        Me.btCalcularConsumo.Margin = New System.Windows.Forms.Padding(2)
        Me.btCalcularConsumo.Name = "btCalcularConsumo"
        Me.btCalcularConsumo.Size = New System.Drawing.Size(184, 49)
        Me.btCalcularConsumo.TabIndex = 3
        Me.btCalcularConsumo.Text = "Consultar Consumo"
        Me.btCalcularConsumo.UseVisualStyleBackColor = True
        '
        'btConsultar
        '
        Me.btConsultar.Location = New System.Drawing.Point(168, 54)
        Me.btConsultar.Margin = New System.Windows.Forms.Padding(2)
        Me.btConsultar.Name = "btConsultar"
        Me.btConsultar.Size = New System.Drawing.Size(115, 49)
        Me.btConsultar.TabIndex = 2
        Me.btConsultar.Text = "Consultar"
        Me.btConsultar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Location = New System.Drawing.Point(24, 54)
        Me.btAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(115, 49)
        Me.btAgregar.TabIndex = 1
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 188)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuPrincipal"
        Me.Text = "s"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btConsultar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents btCalcularConsumo As Button
End Class
