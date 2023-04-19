<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearCuenta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.valueName = New System.Windows.Forms.TextBox()
        Me.valuePhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.valueAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.valueId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.valueBalance = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre usuario"
        '
        'valueName
        '
        Me.valueName.Location = New System.Drawing.Point(245, 78)
        Me.valueName.Name = "valueName"
        Me.valueName.Size = New System.Drawing.Size(100, 23)
        Me.valueName.TabIndex = 1
        '
        'valuePhone
        '
        Me.valuePhone.Location = New System.Drawing.Point(245, 117)
        Me.valuePhone.Name = "valuePhone"
        Me.valuePhone.Size = New System.Drawing.Size(100, 23)
        Me.valuePhone.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Teléfono"
        '
        'valueAddress
        '
        Me.valueAddress.Location = New System.Drawing.Point(245, 157)
        Me.valueAddress.Name = "valueAddress"
        Me.valueAddress.Size = New System.Drawing.Size(100, 23)
        Me.valueAddress.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dirección"
        '
        'valueId
        '
        Me.valueId.Location = New System.Drawing.Point(245, 196)
        Me.valueId.Name = "valueId"
        Me.valueId.Size = New System.Drawing.Size(100, 23)
        Me.valueId.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Id"
        '
        'valueBalance
        '
        Me.valueBalance.Location = New System.Drawing.Point(245, 235)
        Me.valueBalance.Name = "valueBalance"
        Me.valueBalance.Size = New System.Drawing.Size(100, 23)
        Me.valueBalance.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Saldo Inicial"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CrearCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.valueBalance)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.valueId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.valueAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.valuePhone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.valueName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CrearCuenta"
        Me.Text = "CrearCuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents valueName As TextBox
    Friend WithEvents valuePhone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents valueAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents valueId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents valueBalance As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
