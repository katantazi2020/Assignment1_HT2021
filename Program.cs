using System;

namespace Assignment1_HT2021
{
    class Program
    {
        static void Main(string[] args)
        {
            prepareConsolesLooks();
            // Create a pet object
            Pet petobj = new Pet();
            
            // Call the method of the object  to run
            petobj.start();
            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();
            
            // Start TicketSeller
            TicketSeller ticket = new TicketSeller();
            ticket.Start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

        }
        static void prepareConsolesLooks()
        {
            //Arrange the console window
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); // Paint the background with the above color
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "KIDS' FAIR";
















































        }
    }
}
