Public Class Client
    Private name As String
    Private id As Integer
    Private address As String
    Private phone As String

    Public Sub New()

    End Sub
    Public Sub New(na As String, pho As String, idNumber As Integer, add As String)
        name = na
        id = idNumber
        phone = pho
        address = add
    End Sub

    Public Property ClientName() As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property ClientId() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property ClientPhone() As String
        Get
            Return phone
        End Get
        Set(value As String)
            phone = value
        End Set
    End Property

    Public Property ClientAddress() As String
        Get
            Return address
        End Get
        Set(value As String)
            address = value
        End Set
    End Property
End Class