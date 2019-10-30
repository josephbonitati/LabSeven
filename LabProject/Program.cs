using System;
using System.Text.RegularExpressions;

namespace LabProject
{
    class Program
    {
        public static string NeedName()
        {
            string name = Console.ReadLine();
            Match temp = Regex.Match(name, @"(^[A-Z]{1}[a-z]{1,30}$)");

            while (!Regex.IsMatch(name, @"(^[A-Z]{1}[a-z]{1,30}$)"))
            {
                Console.WriteLine("Sorry name is not valid!");
                name = Console.ReadLine();
            }

            if ((Regex.IsMatch(name, @"(^[A-Z]{1}[a-z]{1,30}$)")))
                Console.WriteLine("Name is valid!");
            return name;
        }

        public static string NeedEmail()
        {
            

            string email = Console.ReadLine();
            Match temp = Regex.Match(email, @"([A-za-z1-9]+@{1}[A-Za-z1-9]+\.{1}[A-Za-z1-9]{3,5}$)");

            while (!Regex.IsMatch(email, @"([A-za-z1-9]+@{1}[A-Za-z1-9]+\.{1}[A-Za-z1-9]{3,5}$)"))
            {
                Console.WriteLine("Sorry email is not valid!");
                email = Console.ReadLine();
            }

            if ((Regex.IsMatch(email, @"([A-za-z1-9]+@{1}[A-Za-z1-9]+\.{1}[A-Za-z1-9]{3,5}$)")))
                Console.WriteLine("Email is valid!");
            return email;
        }
        public static string NeedPhone()
        {


            string phone = Console.ReadLine();
            Match temp = Regex.Match(phone, @"([0-9]{3}\-[0-9]{3}\-[0-9]{4})");

            while (!Regex.IsMatch(phone, @"([0-9]{3}\-[0-9]{3}\-[0-9]{4})"))
            {
                Console.WriteLine("Sorry phone number is not valid!");
                phone = Console.ReadLine();
            }

            if ((Regex.IsMatch(phone, @"([0-9]{3}\-[0-9]{3}\-[0-9]{4})")))
                Console.WriteLine("Phone number is valid!");
            return phone;
        }
        public static string NeedDate()
        {


            string Date = Console.ReadLine();
            Match temp = Regex.Match(Date, @"([0-2]{2}\/[0-9]{2}\/[0-9]{4})");

            while (!Regex.IsMatch(Date, @"([0-2]{2}\/[0-9]{2}\/[0-9]{4})"))
            {
                Console.WriteLine("Sorry date is not valid!");
                Date = Console.ReadLine();
            }

            if ((Regex.IsMatch(Date, @"([0-2]{2}\/[0-9]{2}\/[0-9]{4})")))
                Console.WriteLine("Date is valid!");
            return Date;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid name, must start with a capital letter.");
            NeedName();

            Console.WriteLine();

            Console.WriteLine("Please enter a valid email, this includes an (@) symbol and a domain (.com).");
            NeedEmail();

            Console.WriteLine();

            Console.WriteLine("Please enter a valid phone number with (-) included.");
            NeedPhone();

            Console.WriteLine();

            Console.WriteLine("Please enter a valid date with (/) included.");
            NeedDate();
        }
    }
}
