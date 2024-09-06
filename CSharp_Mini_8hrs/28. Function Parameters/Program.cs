namespace _28._Function_Parameters;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Sang is on his way to be the developer");

        // Fuction parameters
        // Function is only useful with parameters

        //ex 1: create function without parameter
                // this a bad example of a function
                System.Console.WriteLine(Add());
                static int Add()
                {
                    return 5 + 5;
                }
                // better way
                int Cal = AddNum(3,3);
                static int AddNum(int a, int b)
                {
                    return a + b;
                }
        
        // ex2: Create function with parameter
            // Call the function and add the parameter (5,6)
            System.Console.WriteLine(AddParermeter(5,6));

            // create a function -  int a and int b are known as local variable
            static int AddParermeter(int a, int b) 
            {
                return a + b;
            }

                // another use case for the ReadInt() and AddParemeter() functions
                int First_Num = ReadInt("Enter your first num");
                int Second_Num = ReadInt("Enter you second num");
                int result = AddParermeter(First_Num, Second_Num);
                System.Console.WriteLine(result);
                
                // Using function ReadInt and ReadString
                string? name2 = ReadString("Enter your name");
                int age2 = ReadInt("Enter your age: ");
                string? details = UserDetails(name2, age2); 

                System.Console.WriteLine($"Your name is {name2} annd your age is {age2}");
        // ReadInt 

        // ex3: Create a function to read to ask user number input
            // Call the function and use different purpose
                // 1. System.Console.WriteLine(ReadInt());
                    //System.Console.WriteLine($"Here is your number: {ReadInt()}");
                // 2. assing diffrent varible
                    // int num = ReadInt();
                    // System.Console.WriteLine($"Here is your number: {num}");
                // 3. use in another function
                System.Console.WriteLine($"Here is your number: {AddParermeter(ReadInt("Enter your number for adding "),30)}"); // the result of this will be 50 if you put in 20 to input


            // FUNCTION: Create A User Detail  Function
            static string? UserDetails(string? name2, int age2)
            {
                return $"Hello my nam is {name2} and my age is {age2}";
            }
            // FUNCTION: Create the Readstring  function using return        
            static string? ReadString(string StringMessage)
            {
                System.Console.WriteLine($" {StringMessage} ");
                return Console.ReadLine();
            }
            // FUNCTION: Create the ReadInt  function using return        
            static int ReadInt(string message)
            {
                System.Console.WriteLine($"{message}");
                //int num = Convert.ToInt32(Console.ReadLine());  //  Using return instead
                return Convert.ToInt32(Console.ReadLine());
            }

        // ex4: Add the parameter inside the method 

                // Call the function and use different purpose
                // 1. assing diffrent varible
                int num1 = ReadInt_withParameter("Your magic number");
                System.Console.WriteLine($" Thank you! Here is your number: {num1}");
               
            // FUNCTION: Create function to specify the message that we put in -- by directly adding the parameter into the function -- ReadInt(string messge)       
            static int ReadInt_withParameter(string message) 
            {
                System.Console.WriteLine($"Enter your {message}: ");
                return Convert.ToInt32(Console.ReadLine());
            }


    }
}
