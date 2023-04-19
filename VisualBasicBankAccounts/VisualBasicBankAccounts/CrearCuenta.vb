Public Class CrearCuenta
    Private na As String
    Private pho As String
    Private add As String
    Private id As Integer
    Private balance As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        na = valueName.Text
        pho = valuePhone.Text
        add = valueAddress.Text
        id = valueId.Text
        balance = valueBalance.Text
        Me.Close()
    End Sub
    Public Property createAccName() As String
        Get
            Return na
        End Get
        Set(value As String)
            na = value
        End Set
    End Property
    Public Property createAccPho() As String
        Get
            Return pho
        End Get
        Set(value As String)
            pho = value
        End Set
    End Property
    Public Property createAccAdd() As String
        Get
            Return add
        End Get
        Set(value As String)
            add = value
        End Set
    End Property
    Public Property createAccId() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property
    Public Property createAccBa() As Integer
        Get
            Return balance
        End Get
        Set(value As Integer)
            balance = value
        End Set
    End Property
End Class