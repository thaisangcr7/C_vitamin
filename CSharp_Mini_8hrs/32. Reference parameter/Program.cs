namespace _32._Reference_parameter;

class Program
{
    static void Main(string[] args)
    {
        //ex1: 
            // int num = 10;
            // Assign(out num);

            // System.Console.WriteLine(num);

        // ex2:
            int num = 10;
            Assign(ref num);
            
            System.Console.WriteLine(num);

        // ex:3
            int num1 = 10;
            string name = "";
            Assign_2(ref num1, ref name);

            System.Console.WriteLine($"{num1} and {name}");
            

    }

    
        //ex: 1
            // static void Assign(out int num)
            // {
            //     num = 20; // assign value for out
            // }

    // Instead of using out - we can also using ref
    // the num = 20 will link directly t0 int num = 10!
    // 
        //ex: 2
             static void Assign(ref int num)
             {
                num = 20;
             }

        // ex3"
            static void Assign_2(ref int num1,ref string name)
            {
                num1 = 30;
                name = "John";
            }

}
