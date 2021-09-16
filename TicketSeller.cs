using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_HT2021
{
    class TicketSeller
    {
        private string name; // Name of the ticket buyer
        private double price = 100; // Ticket price
        private int numOfAdults; //
        private int numOfChildren;
        private double amountToPay; // Total amount to pay  for the purchased tickets


        public void Start()
        {
            Console.WriteLine(); //blankline
            Console.WriteLine("Greetings from the Ticket seller!");
            Console.WriteLine(); //Blankline
            ReadAndSaveTicketData();
            DisplayTicketInfo();
        }
        public void ReadAndSaveTicketData()
        {
            ReadName();
            ReadPrice();
            ReadAmountToPay();
        }
        public void ReadName()
        {
            //Read a line of text
            Console.Write("What is the name of Ticket buyer?  ");
            name = Console.ReadLine();
        }
        public void ReadPrice()
        {
            // Read Whole number
            Console.Write("Enter the price of the ticket:  ");
           string Ticketprice = Console.ReadLine();
            //convert string to double value
            price= double.Parse(Ticketprice);
        }
        public void ReadAmountToPay()
        {
            // Read the number of adults
            Console.Write("Enter the number of Adults: ");
            //convert string to integer
           String adultnum = Console.ReadLine();
            numOfAdults = int.Parse(adultnum);

            //Read the number of Chldren
            Console.Write("Enter the number of Children: ");
            string childnum = Console.ReadLine();
            // Convert string to intenger
            numOfChildren = int.Parse(childnum);

            int toTalOfpeople = numOfChildren + numOfAdults;
            Console.Write("Enter the total number of people: ");
            string allPeople = Console.ReadLine();
            toTalOfpeople = int.Parse(allPeople);

            amountToPay = toTalOfpeople * price;
            Console.WriteLine("The total price to pay is: "  + amountToPay);





        }
        public void DisplayTicketInfo()
        {

        }
    }
}
