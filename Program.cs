internal class Program
{
    private static void Main(string[] args)
    {

        while (true)
        {
        Console.Clear();
        Console.ForegroundColor=ConsoleColor.DarkCyan;
        Console.WriteLine("    ~~~[WELCOME TO THE TOBACCO AND SALT MUSEUM!]~~~\n \n [You are now standing at the entrance of the museum]\n  [Pick a room from the menu to explore the museum]\n\n");
        Console.WriteLine("[1] - GIFT SHOP");
        Console.WriteLine("[2] - CAFÉ");
        Console.WriteLine("[3] - EXHIBIT 1");
        Console.WriteLine("[4] - EXHIBIT 2");
        Console.WriteLine("_________________\n");
        Console.WriteLine("[A] - SALT SCULPTURES");
        Console.WriteLine("[B] - CIGARS");
        Console.WriteLine("[R] - EXIT MUSEUM");
        Console.ResetColor();

        var menuKey = Console.ReadKey(true).Key;
        if (menuKey == ConsoleKey.D1)
        {
            Console.Clear();
            GiftShop();
        }
        else if (menuKey == ConsoleKey.D2)
        {
            Console.Clear();
            Cafe();
        }
        else if (menuKey == ConsoleKey.D3)
        {
            Console.Clear();
            Exhibit1();
        }
        else if (menuKey == ConsoleKey.D4)
        {
            Console.Clear();
            Exhibit2();
        }
        else if (menuKey == ConsoleKey.A)
        {
            Console.Clear();
            Salt();
        }
        else if (menuKey == ConsoleKey.B)
        {
            Console.Clear();
            Cigars();
        }
        else if (menuKey == ConsoleKey.R)
        {
            Environment.Exit(0);
        }
        }

void GiftShop()
{
    Console.WriteLine("~~~[Welcome to our gift shop]~~~\n\nThe Menu\n\nPress any key to return to Entrance");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Returning to entrance...");
    Thread.Sleep(2500);
    Console.Clear();   
}

void Cafe()
{
    Console.WriteLine("~~~[Welcome to our café]~~~\n\nMerchandise\n\nPress any key to return to Entrance");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Returning to entrance...");
    Thread.Sleep(2500);
    Console.Clear();    
}

void Exhibit1()
{
    Console.WriteLine("     EXHIBIT 1\n\n[Information about exhibit 1]\n\nPress any key to return to Entrance");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Returning to entrance...");
    Thread.Sleep(2500);
    Console.Clear(); 
}

void Exhibit2()
{
    while (true)
        {
    Console.WriteLine("[A] Pipes \n\n[B] Pictures \n\n[R] Return to Entrance");
        var exhibit2Key = Console.ReadKey(true).Key;
        if (exhibit2Key == ConsoleKey.A)
        {
            Console.Clear();
            Console.WriteLine("[Information about pipes...] \n\nPress any key to return to Exhibit 2");
            Console.ReadKey();
            Console.Clear();  
        }
        else if (exhibit2Key == ConsoleKey.B)
        {
            Console.Clear();
            Console.WriteLine("[Information about the pictures...] \n\nPress any key to return to Exhibit 2");
            Console.ReadKey();
            Console.Clear();
        }
        else if (exhibit2Key == ConsoleKey.R)
        {
            Console.Clear();
            Console.WriteLine("Returning to entrance...");
            Thread.Sleep(2500);               
            Console.Clear();
            return;          
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Only (A), (B), or (R) is allowed.\nReturning to Exhibit 2...");
            Thread.Sleep(2500);
            Console.Clear();
        }
        }    
}

void Salt()
{
    Console.WriteLine("     Salt sculpture\n\n[Information about the salt sculptures]\n\nPress any key to return to Entrance");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Returning to entrance...");
    Thread.Sleep(2500);  
    Console.Clear(); 
}

void Cigars()
{
    Console.WriteLine("     Cigars\n\n[Information about the cigars]\n\nPress any key to return to Entrance");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Returning to entrance...");
    Thread.Sleep(2500);  
    Console.Clear(); 
}
    }
}