
namespace _13._String_Iteration_Looping;

class Program
{
    static void Main(string[] args)
    {
        string message = "C# is awesome";
        System.Console.WriteLine(message);

        // char[]
            // Console.WriteLine(message[3..8]);
            // System.Console.WriteLine(message[^3]);
            // System.Console.WriteLine(message[1]);

        // Check the length of the string 

            for (int i = 0; i < message.Length; i++)
            {
                System.Console.WriteLine(message[i]);
            }
            System.Console.WriteLine(message.Contains("C"));

        // 
            bool LoopContains = false;

            for (int s = 0; s < message.Length; s++)
            {
                if (message[s].Equals('C'))
                {
                    LoopContains = true;
                }
                else
                {
                    LoopContains = false;
                }
            }

        Console.ReadLine(); 
    }
}
