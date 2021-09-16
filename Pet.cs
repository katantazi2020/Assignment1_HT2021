using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_HT2021
{
    class Pet
    {
        private string name; // name of the pet
        private int age; //age as an integer
        private bool isFemale; // true if female false otherwise


        public void start()
        {
            Console.WriteLine(); //blankline
            Console.WriteLine("Greetings from the pet Owner application!");
            Console.WriteLine(); //blankline

            ReadAndSavePetData();
            DisplayPetInfo();
        }
        public void ReadAndSavePetData()
        {

            ReadNAme();
            ReadAge();
            ReadGender();
            
        }
        public void ReadNAme()
        {
            //Read a line of text
            Console.Write("What is the name of your pet?  ");
            name = Console.ReadLine();
        }
        public void ReadAge()
        {
            // Read Whole number
            Console.Write("What is " + name + "'s age?  ");
            string textValue = Console.ReadLine();
            //convert string to number
            age = int.Parse(textValue);
        }
        public void ReadGender()
        {
            // Read the logigal value (y/n)
            Console.Write("Is your pet female (y/n)?  ");
            string strGender = Console.ReadLine();
            strGender = strGender.Trim(); // delete leading and trailing spaces.
            char response = strGender[0];
            if ((response == 'Y') || (response == 'Y'))
                isFemale = true;
            //Console.Write("The pet is Female:");
            else
                isFemale = false;
            Console.Write("The pet is Male");
        }
        public void DisplayPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            string textOut = "Name:  " + name + ", " + "Age:  " + age;
            Console.WriteLine(textOut);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
        }
    }
}
