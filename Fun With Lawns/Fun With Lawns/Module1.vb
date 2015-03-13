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

        'This gives the company info

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
        Console.WriteLine("No company information has been found. We'll setup a profile before we begin.")
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write("Press any key to continue...")
        Console.ReadKey()

        Console.Clear()

        Console.ForegroundColor = ConsoleColor.Black
        Console.WriteLine("Here you need to enter the details for you new company profile. ")
        Console.WriteLine()

        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write("Company name: ")
        Console.ForegroundColor = ConsoleColor.Black
        company.companyname = Console.ReadLine

        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write("Company owner's name: ")
        Console.ForegroundColor = ConsoleColor.Black
        company.ownersname = Console.ReadLine

        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write("Company contact number: ")
        Console.ForegroundColor = ConsoleColor.Black
        company.contactnumber = Console.ReadLine

        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write("Company address: ")
        Console.ForegroundColor = ConsoleColor.Black
        company.companyaddress = Console.ReadLine

        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write("Company hourly rate: $")
        Console.ForegroundColor = ConsoleColor.Black
        company.hourlyrate = Console.ReadLine

        Console.ReadLine()

    End Sub
    Sub Menu()

        Console.Clear()
        Console.WriteLine("Welcome " & company.companyname)
        Console.WriteLine()

    End Sub
    Sub startscreen()
        'Startscreen
        Console.BackgroundColor = ConsoleColor.White
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black

        Console.SetCursorPosition(25, 0)
        Console.WriteLine("Welcome to Fun With Lawns v0.1")
        Console.SetCursorPosition(20, 1)
        Console.WriteLine("Your all in one lawn management system.")
        Console.WriteLine()
        Console.SetCursorPosition(25, 3)
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Press any key to continue...")

        Console.ReadKey()
    End Sub
    Sub Main()

        startscreen()
        companyinfo()
        Menu()



    End Sub

End Module
