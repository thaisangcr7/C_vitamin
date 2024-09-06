namespace _30._Named_Patameters;

class Program
{
    static void Main(string[] args)
    {
        string nameInput = "Sang";
        int ageInput = 25;
        string addressInput = "dev road";

        //Call the PrintDetail function with random order for the parameter using :
        PrintDetails(age:ageInput, 
                    name:nameInput,
                    address:addressInput);

        Console.ReadLine();
    }

    static void PrintDetails(string name, int age, string address)
    {
        System.Console.WriteLine($"Name: {name}");
        System.Console.WriteLine($"Age: {age}");
        System.Console.WriteLine($"Address: {address}");
    }
}


