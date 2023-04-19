Module main

    Sub Main()
        Dim bank As New Bank("ContiBank")

        bank.CreateClientAccount(New Client("Lautaro", "2235798135", 1, "Beruti 4118"), 10010.5)
        bank.DepositMoney(0, 20020)
        Console.WriteLine(bank.GetBalance(0))
    End Sub


    Sub arrayObjects()
        Dim accounts(2) As SavingsAccount
        For i = 0 To 2 Step 1
            Dim form As New CrearCuenta()
            form.ShowDialog()
            Dim name As String = form.createAccName
            Dim phone As String = form.createAccPho
            Dim address As String = form.createAccAdd
            Dim id As Integer = form.createAccId
            Dim balance As Double = form.createAccBa


            Dim newAccount As New SavingsAccount(balance, New Client(name, phone, id, address))
            accounts(i) = newAccount
        Next

        For Each ac As SavingsAccount In accounts
            Console.WriteLine("-----------------------")
            Console.WriteLine("Nro. Cuenta: " & ac.accNum)
            Console.WriteLine("-----------------------")
            Console.WriteLine("Nombre del cliente: " & ac.ClientAccount.ClientName)
            Console.WriteLine("-----------------------")
            Console.WriteLine("Saldo: " & ac.balanceAccount)
        Next
    End Sub
    Sub PruebasAccount()
        Dim newClient As Client = New Client("Lautaro", "2235798136", 1, "Beruti 4118")
        Dim account1 As New Account(250, newClient)

        Console.WriteLine(account1.balanceAccount())
        account1.depositMoney(650)
        Console.WriteLine(account1.balanceAccount())
        account1.withdrawals(200)
        Console.WriteLine(account1.balanceAccount())

        Console.WriteLine(account1.ClientAccount.ClientName)

        Dim savingAccount1 As New SavingsAccount(1000, newClient)
        Console.WriteLine(savingAccount1.balanceAccount())
        savingAccount1.depositMoney(650)
        Console.WriteLine(savingAccount1.balanceAccount())
        savingAccount1.withdrawals(200)
        Console.WriteLine(savingAccount1.balanceAccount())
    End Sub
End Module