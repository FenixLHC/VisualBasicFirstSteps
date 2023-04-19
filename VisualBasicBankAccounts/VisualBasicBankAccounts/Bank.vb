Public Class Bank
    Private name As String
    Private accounts() As SavingsAccount

    Public Sub New(nameB As String)
        name = nameB
        accounts = New SavingsAccount(20) {}
    End Sub

    Public Sub CreateClientAccount(cl As Client, balance As Double)
        Dim n As Integer = accounts.Length
        Dim id As Integer
        For i = 0 To n - 1 Step 1
            If accounts(i) Is Nothing Then
                id = i
                Exit For
            End If

        Next
        Console.WriteLine(id)
        Console.WriteLine(accounts.Length)
        accounts(id) = New SavingsAccount(balance, cl)
    End Sub
    Public Sub DepositMoney(accId As Integer, value As Double)
        accounts(accId).depositMoney(value)
    End Sub
    Public Sub Withdrawals(accId As Integer, value As Double)
        accounts(accId).withdrawals(value)
    End Sub
    Public Function GetBalance(accId As Integer) As Double
        Return accounts(accId).balanceAccount()
    End Function
    Public Function getClientAccount(clt As Integer) As SavingsAccount
        Dim accId As Integer
        For i = 0 To accounts.Length - 1 Step 1
            If accounts(i).ClientAccount.ClientId.Equals(clt) Then
                accId = i
            End If
            Exit For
        Next
        Return accounts(accId)
    End Function
End Class