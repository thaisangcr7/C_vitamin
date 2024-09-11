namespace _33._Excercise_____Area_of_a_Triangle;

class Program
{
    // Ask user for width and height, store them
    // Create Function to calculate the area
    // Function should calculate the area using (Width * Height) /2
    // Call in main and print out the area of the triangle
    static void Main(string[] args)
    {
        // // Ask User for Inputs - normal way
        //     System.Console.WriteLine("Enter your width: ");
        //     int width = Convert.ToInt32(Console.ReadLine());
            
        //     System.Console.WriteLine("Enter your height: ");
        //     int height = Convert.ToInt32(Console.ReadLine());

        // 1. using function 
            int width_1 = ReadInt("Enter your width");
            int height_1 = ReadInt(" Enter your height");

        // 2. Call funciton 2
            int Result_Area = CalArea(width_1,height_1);
            // print result:
            System.Console.WriteLine($" The Area of the Triangle is {Result_Area}!");
            // You can try this
            // System.Console.WriteLine($" The Area of the Triangle is {CalArea(width_1,height_1)}");

        
    }

    // 1. Create a Read interger Functions 
        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    // 2. Create a Calculator Funciton
        static int CalArea(int width_1, int height_1)
        {
            return (width_1 * height_1) / 2;
        }

}
