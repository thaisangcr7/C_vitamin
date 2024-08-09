using System;


namespace Vitamin_C_Funda
{
    public class _3_Learning_C__Syntax

        {
            public void run()
            {
                /* // 1.1 -----
                // C# syntax
                
                Console.WriteLine("Hello, World!");

                Console.WriteLine("Please enter your name: ");
                string? name = Console.ReadLine(); // using console.readline is to accept intput from the console.
                Console.WriteLine("Hello " + name);

                string? ageInput = Console.ReadLine();
                //int age = Convert.ToInt32(ageInput);
                //int age = int.Parse(ageInput);
                //System.Console.WriteLine(" Your name is " + name + age + " year old");

                // Better Option is using int.tryparse because it allows us
                //to handle invalid input and avoid exceptions
                

                if (int.TryParse(ageInput, out int age))
                    {
                        System.Console.WriteLine($"Hello {name}, you are {age} years old.");

                    }
                else
                    {
                        System.Console.WriteLine($"Invalid input {ageInput}");
                    }
                */ // 1.1 ------

                // 1.2 -----
                /*
                int monthlyWage = 1234;
                int months = 12; 
                int bonuses = 1000;
                //bool isActive = true;
                //double rating = 99.25;
                

                //byte [] date = new byte; // byte on contain from 0-265 
                //int hoursWorked = 125;
                double rateperhour = 12.34;
                int hoursWorked = 148;
                int numberofemployee = 15;


                int annual = monthlyWage * months;
                int total = annual + bonuses;
                System.Console.WriteLine(annual);
                System.Console.WriteLine(total);

                Console.WriteLine("Please enter your age: ");
                double currentmonthlywage = hoursWorked * rateperhour + bonuses;
                System.Console.WriteLine("Current Montly Wage" + currentmonthlywage);
                numberofemployee--;

                //System.Console.WriteLine( rating);

                //monthlyWage = true;

                if (currentmonthlywage > 2000)
                    System.Console.WriteLine("Top earner");

                char mychar = 'a';
                bool isWhiteSpace = char.IsWhiteSpace(mychar);
                bool isDigit = char.IsDigit(mychar);
                bool isPunctuaion = char.IsPunctuation(mychar);
                
                // Datetime and Timespan
                // Create a datetime
                DateTime hireDate = new DateTime(2022, 2, 15, 2, 40, 50 );
                System.Console.WriteLine(hireDate);
                DateTime exitDate = new DateTime(2025, 12, 14);
                System.Console.WriteLine(exitDate);

                DateTime startDate = hireDate.AddDays(15);
                System.Console.WriteLine(startDate);

                DateTime currentDate = DateTime.Now;
                bool areWeInDst = currentDate.IsDaylightSavingTime();
                
                DateTime startHour = DateTime.Now;
                TimeSpan workTime = new TimeSpan(8, 35, 0);
                DateTime endHour = startHour.Add(workTime);

                System.Console.WriteLine(startHour);
                System.Console.WriteLine(endHour);
                System.Console.WriteLine(startHour.ToLongDateString());
                System.Console.WriteLine(endHour.ToShortTimeString());
                */
                /*
                int NumberOfHourWorked = 165;
                long VeryLongMonth = NumberOfHourWorked;

                double d = 123456789.0;
                int x = (int)d;

                int IntVeryLongMonth = (int)VeryLongMonth;




                Console.ReadLine();
                */

    

            }

        }
}
