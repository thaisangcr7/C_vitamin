namespace For_Loops;

class Program
{
    static void Main(string[] args)
    {
        // Normal   
            // Console.WriteLine("Hello, World!");
            // Console.WriteLine("Hello, World!");
            // Console.WriteLine("Hello, World!");
            // Console.WriteLine("Hello, World!");
            // Console.WriteLine("Hello, World!");

        // For Loop 
            // for (int i = 0; i < 5; i++) // for(declear a new varibale, condition(run 5 times), task)
            // {
            //     Console.WriteLine("Hello for For_Loops");
            // }

            // for (int i = 0; i < 5; i++) // for(declear a new varibale, condition(run 5 times), task)
            // {
            //     Console.WriteLine(i);
            // }

            // // i = 0, if i less or equal 10, i increase by 2;
            // for (int i = 0; i <= 10; i += 2)
            // {
            //     System.Console.WriteLine($"incement by 2: {i}");
            // }

        // Excercise 1:
            // Ask the user " how many times do they want to say Hi" and ask for their input
            
            // System.Console.WriteLine(" How many times do you want to say Hi: ");
            // int loopCounter = Convert.ToInt32(Console.ReadLine());

            // for (int i = 0; i < loopCounter; i++ )
            // {
            //     System.Console.WriteLine($"Hi");
            // }

        // Excercise 2:
            // Ask the user " how many times do they want to say Hi" and ask for their input
            // add if statement 
            // Add Ask them what do they want to repeat

            System.Console.WriteLine(" What do you want to repeat: ");
            string? Repeat = Console.ReadLine();
            System.Console.WriteLine(" How many times do you want to repeat ");
            int How_many_times = Convert.ToInt32(Console.ReadLine());

                if (How_many_times <= 0)
                        {
                            System.Console.WriteLine("Please enter a positive number");
                        }
                
                else
                {
                    for (int i = 0; i < How_many_times; i++ )
                    {
                        System.Console.WriteLine(Repeat);
                    }      
                }
      

    }
}
