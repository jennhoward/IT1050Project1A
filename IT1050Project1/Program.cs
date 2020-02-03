using System;

namespace IT10590Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("What is your middle initial? ");
            string middleInitial = Console.ReadLine();
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();
            //Console.Write("Enter Your Name ---> ");
            //string name = Console.ReadLine();
            string fullName = (firstName + " " + middleInitial + " " + lastName);


            Console.Write("What is the feet part of your height? ");
            int heightFeet = int.Parse(Console.ReadLine());
            //Console.Write("Enter Your Age ---> ");
            //int age = int.Parse(Console.ReadLine());
            Console.Write("What is the inches part of your height? ");
            double heightInches = double.Parse(Console.ReadLine());
            //Console.Write("Enter Your Height ---> ");
            //double height = double.Parse(Console.ReadLine());
            double totalHeightCM = ((12 * heightFeet * 2.54) + (heightInches * 2.54));


            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Are you a citizen? ");
            bool isCitizen = Console.ReadLine().ToUpper().StartsWith("Y");
            Console.Write("Can You Vote? ");
            bool canVote = Console.ReadLine().ToUpper().StartsWith("Y");

            //writeline fullName, assumes string, prints fine
            Console.WriteLine(fullName);

            //return Console.Writeline(fullHeightCM);
            //writeline double fullHeight to console, need to convert double to string
            //return Console.Writeline(canVote);


            //writeline bool canVote to console, need to convert bool to string
            //return public static void Console.WriteLine(bool canVote);
            //"raining.ToString() returns {0}",
            //Console.WriteLine("raining.ToString() returns {0}", raining);
            //return public static void Console.WriteLine(bool canVote);

            //Console.WriteLine("Hit any key for the progam to end!");
            //Console.ReadKey();
        }
    }
}

