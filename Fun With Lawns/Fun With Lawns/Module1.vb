Module Module1
    Class cCompany
        Public companyname As String
        Public ownersname As String
        Public contactnumber As String
        Public companyaddress As String
        Public hourlyrate As Integer
    End Class
    Dim company As New cCompany

    Sub companyinfo()



        Console.Clear()
        Console.WriteLine("No company information has been found. We'll setup a profile before we begin.")
        Console.WriteLine()
        Console.Write("Press any key to continue...")
        Console.ReadKey()

        Console.Clear()

        Console.WriteLine("Here you need to enter the details for you new company profile. ")
        Console.WriteLine()
        Console.Write("Company name: ")
        company.companyname = Console.ReadLine
        Console.Write("Company owner's name: ")
        company.ownersname = Console.ReadLine
        Console.Write("Company contact number: ")
        company.contactnumber = Console.ReadLine
        Console.Write("Company address: ")
        company.companyaddress = Console.ReadLine
        Console.Write("Company hourly rate: $")
        company.hourlyrate = Console.ReadLine

        Console.ReadLine()

    End Sub
    Sub Menu()

        Console.Clear()
        Console.WriteLine("Welcome " & company.companyname)
        Console.WriteLine()

    End Sub
    Sub startscreen()
        Console.SetCursorPosition(25, 0)
        Console.WriteLine("Welcome to Fun With Lawns v0.1")
        Console.SetCursorPosition(20, 1)
        Console.WriteLine("Your all in one lawn management system.")
        Console.WriteLine()
        Console.SetCursorPosition(25, 3)
        Console.WriteLine("Press any key to continue...")

        Console.ReadKey()
    End Sub
    Sub Main()

        startscreen()
        companyinfo()
        Menu()



    End Sub

End Module
