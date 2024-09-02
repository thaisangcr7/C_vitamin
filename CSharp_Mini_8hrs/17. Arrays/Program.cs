using System.Runtime.Serialization.Formatters;

namespace _17._Arrays;

class Program
{
    static void Main(string[] args)
    {
       System.Console.WriteLine("Sang is on his way to become the Developer\n");

        // Array when use know the exact numbers you will begin to store
       // This is where Array begin:
       // ex1: 
            // decalare variable for an array:

                int[] numbers = new int[4];
    
                numbers[0] = 5;
                numbers[1] = 10;
                numbers[2] = 115;  
                numbers[3] = 115;  

            // 
            // ask user to input into our numbers Array

                System.Console.WriteLine("Enter your number to store in our array: ");
                numbers[0] = Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine("Enter your number to store in our array: ");
                numbers[1] = Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine("Enter your number to store in our array: ");
                numbers[2] = Convert.ToInt32(Console.ReadLine());

                 System.Console.WriteLine("Enter your number to store in our array: ");
                numbers[3] = Convert.ToInt32(Console.ReadLine());

            // Display the user input
                System.Console.WriteLine($"Your numbers in Array {numbers[0]} {numbers[1]} {numbers[2]} ");

            // ====================================================
            // Let make it more dinamic using for loop to ask user to put in number 
            //=====================================================
            // Better way to display the array using For Loop

                for (int i = 0; i < numbers.Length; i++)
                    {
                        System.Console.WriteLine("Enter your number to store in our array: ");
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                    }
                
                for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write($" {numbers[i]}");
                    }

        // ex2: Powerful of using for loop for asking user to create his own Array

            // Ask user to input how number he want to store in array
            //=====================================================
            // Ask user to input how many number he want to store in array
            // Then ask user to enter input - the for loop will ask by how many times based how his first input for the numbers he want for his array
            
                // number he wants for his array            
                    System.Console.Write("How many number you want to store in array? ");
                    int [] numberArray = new int[Convert.ToInt32(Console.ReadLine())];

                // asking for his inputs to store in his array
                // the for loop {} whill read his number and store in in array by the number his put in above
                    for (int i = 0; i < numberArray.Length; i++)
                    {
                        System.Console.Write("Enter a number");
                        numberArray[i] = Convert.ToInt32(Console.ReadLine());
                    }

                // display his array with his inputs
                // this will go into whatever position you want 
                    for (int i = 0; i < numberArray.Length;i++ )
                    {
                        //Display his array
                        System.Console.WriteLine($" {numberArray[i]}");
                    }

                // Use foreach instead of for loop - The foreach will always go through every single position
                // using write to not break the output
                    foreach (int num in numberArray)
                    {
                        Console.Write($" {num}");
                    }
            
            // ex3:

            const int angleCount = 3;
            int[] angles = new int[angleCount];

            for (int s = 0; s < angles.Length; s++)
            {
                Console.Write($"Eneter angle {s + 1}: ");
                angles[s] = Convert.ToInt32(Console.ReadLine());

            }

            int angleSum = 0;

            foreach (int angle in angles)
            {
                angleSum += angle;
            }

            System.Console.WriteLine(angleSum);

            System.Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");


            



       Console.ReadLine();
    }
}
