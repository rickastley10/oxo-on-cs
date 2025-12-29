using System;

class Program
{
    static void Main() 
    {
        string a1 = "1", a2 = "2", a3 = "3", 
               a4 = "4", a5 = "5", a6 = "6", 
               a7 = "7", a8 = "8", a9 = "9";

        
        
        while (true)
        {
            Console.WriteLine("\n\noxo\n");
            Console.WriteLine($"{a1}|{a2}|{a3}");
            Console.WriteLine("-----");
            Console.WriteLine($"{a4}|{a5}|{a6}");
            Console.WriteLine("-----");
            Console.WriteLine($"{a7}|{a8}|{a9}");
            
            Console.Write("where to place what?\n0 to quit\n> ");
            
            string num;
            num = Console.ReadLine();
            
            
            if (num == "1")
            {
                Console.Write("what to place?\n x / o\n> ");
                a1 = Console.ReadLine();
            }
            else if (num == "2")
            {
                Console.Write("what to place?\n x / o\n> ");
                a2 = Console.ReadLine();
            }
            else if (num == "3")
            {
                Console.Write("what to place?\n x / o\n> ");
                a3 = Console.ReadLine();
            }
            else if (num == "4")
            {
                Console.Write("what to place?\n x / o\n> ");
                a4 = Console.ReadLine();
            }
            else if (num == "5")
            {
                Console.Write("what to place?\n x / o\n> ");
                a5 = Console.ReadLine();
            }
            else if (num == "6")
            {
                Console.Write("what to place?\n x / o\n> ");
                a6 = Console.ReadLine();
            }
            else if (num == "7")
            {
                Console.Write("what to place?\n x / o\n> ");
                a7 = Console.ReadLine();
            }
            else if (num == "8")
            {
                Console.Write("what to place?\n x / o\n> ");
                a8 = Console.ReadLine();
            }
            else if (num == "9")
            {
                Console.Write("what to place?\n x / o\n> ");
                a9 = Console.ReadLine();
            }
            else if (num == "0")
            {
                break;
            }
            
        }
    }
}