namespace C_vitamin_p1;

class Program
{
    static void Main(string[] args)
    {

        // - 1 Fizbull 
        //FizzBuzz fizzBuzz = new FizzBuzz();
        //fizzBuzz.Run(10000);


        // - 2 CalculatorSimple 
        // note: CalculatorSimple(name of the class) - calulator is a variable name 
        // note: new CalculatorSimple() - this expression creates a new instance of the CalculatorSimple class.
        // note:  calculator: this refers to the instance of CalculatorSimple that was created and stored in the variable 'calculator'
        CalculatorSimple calculator = new CalculatorSimple();
        calculator.Run();

    
        Console.WriteLine("Hello, World!");
        
    }
}

