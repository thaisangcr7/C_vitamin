namespace Condition_Operator;

class Program
{
    static void Main(string[] args)
    {
        int age = -10;

        if (age >= 0)
        {
            System.Console.WriteLine("Valid");
        }
        else
        {
            System.Console.WriteLine("Invalid");
        }
        // Conditions True : False
        // Using the conditional operator (?:) to achieve the same result
        // The syntax is: condition ? true_value : false_value
        // In this case, the condition is 'age >= 0', the true_value is "valid", and the false_value is "Invalid"
        string result = age >= 0 ? "valid" : "Invalid";
        System.Console.WriteLine(result);

        Console.ReadLine();
    }
}
