Public Class Account
    Private balance As Double
    Private accountNumber As Integer
    Private cnt As Client
    Private Shared setAccountNumber As Integer = 1

    Public Sub New()
        accountNumber = setAccountNumber
        balance = 0
        cnt = Nothing

        setAccountNumber += 1
    End Sub

    Public Sub New(ba As Double, cl As Client)
        balance = ba
        accountNumber = setAccountNumber
        cnt = cl

        setAccountNumber += 1
    End Sub

    Public Function balanceAccount() As Double
        Return balance
    End Function

    Public Function accNum() As Integer
        Return accountNumber
    End Function

    Public Property ClientAccount() As Client
        Get
            Return cnt
        End Get
        Set(value As Client)
            If cnt Is Nothing Then
                cnt = value
            Else
                Console.WriteLine("The client is already asignent")
            End If
        End Set
    End Property

    Public Sub depositMoney(value As Double)
        balance += value
    End Sub
    Public Sub withdrawals(value As Double)
        If balance >= value Then
            balance -= value
        Else
            Console.WriteLine("Balance is not enough")
        End If
    End Sub
End Class