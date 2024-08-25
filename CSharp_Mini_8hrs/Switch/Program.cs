namespace Switch;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(" Enter a day of the week: ");
        int day = Convert.ToInt32(Console.ReadLine());

            // if (day == 1)
            // {
            //     System.Console.WriteLine("Monday");
            // }
            // else if (day == 2)
            // {
            //     System.Console.WriteLine("Tuesday");
            // }
            // else if (day == 3)
            // {
            //     System.Console.WriteLine("Wednesday");  
            // }

// Switch ===============================================================================================
        // Better way
        

            switch(day)
            {
                case 1: System.Console.WriteLine("Monday");
                    break;
                case 2: System.Console.WriteLine("Tuesday");
                    break;
                case 3: System.Console.WriteLine("Wednesday");
                    break;
                //  enter 4 or 5 will result in Thurs and Fri for switch case 4 and case 5        
                case 4:
                case 5: System.Console.WriteLine("Thursday or Friday");
                    break;
                case 6: System.Console.WriteLine("Sat");
                    break;
                case 7: System.Console.WriteLine("Sun");
                    break;    
                // if not from 1 to 7 then invalid
                default: System.Console.WriteLine("Invalid Input for day! Note: Enter from 1 to 7");
                    break;
              
            }

        Console.ReadLine();
    }
}
