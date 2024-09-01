namespace _22._Lists;

class Program
{
    static void Main(string[] args)
    {
        
        // Array
        int[] array = new int[3] { 1, 2, 3}; 
        
        // List
        // List does not have length so we cannot use .length, so instead of .length , 
        // we use .Count for List
        // you can add and remove item from list
        
        // ex:1
        List<int> list_numbers = new List<int>()
        {
            1,2,3,4
        };
        // list_numbers.Add(1);
        // list_numbers.Add(2);
        // list_numbers.Add(3);
        // list_numbers.Add(4);

        // ex:2
            // List<int> List_numbers2 = new List<int>();
            
            // for (int i = 0; i < 4; i++)
            // {
            //     Console.Write("Enter your number: ");
            //     int number = Convert.ToInt32(Console.ReadLine());

            //     list_numbers.Add(number);
                
            // }

            // different way
            List<int> List_numbers2 = new List<int>();
            
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter your number: ");
             
                List_numbers2.Add(Convert.ToInt32(Console.ReadLine()));
                
            }

            // use Count - Print list 
            for (int i = 0; i < List_numbers2.Count; i++)
            {
                System.Console.Write(List_numbers2[i]) ;
            }

            // Print list 
            foreach (int item in List_numbers2)
            {
                Console.Write(item + " ") ;
            }

            // Remove
            List_numbers2.RemoveAt(0);

            System.Console.WriteLine(List_numbers2); // This does not give a list since Console.Writeline is default for string


        
        


       

        Console.ReadLine();

    }
}
