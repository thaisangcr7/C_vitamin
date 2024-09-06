namespace _31._Out_Parameters;

class Program
{
    static void Main(string[] args)
    {
        
        //1. test 2 outputs with 1 function
            int num = 0;
            test(out num);
            System.Console.WriteLine(num);

        //2. int.TryParse();

        // 3.// Create a list of shopping items
            List<string> shoppingList = new List<string>
            {
                "coffee", "milk"
            };
            // Test the IndexOf method to find the index of an item in the list
            System.Console.WriteLine(shoppingList.IndexOf("Coffee"));
            // Note: IndexOf is case-sensitive and will return -1 if not found
            
            // Test the custom FindInList function to find an item in the list
            // System.Console.WriteLine(FindInList("Milk", shoppingList, out int index));
            // Console.WriteLine("" + index);

            // Call FindInList and store the result and index in 'found' and 'index'
            Console.Write("Enter an item to search: ");
            string? search = Console.ReadLine();
            
            if (FindInList(search, shoppingList, out int index))
            {
                Console.WriteLine($"Found {search} at Index {index}");
            }
            else
            {
                System.Console.WriteLine("Not Found");
            }

            // int index = -1;

            // for (int i = 0; i < shoppingList.Count(); i++)
            // {
            //     if (shoppingList[i].ToLower().Equals("coffee"))
            //     {
            //         index = i;
            //     }
            // }

            // bool found = index > -1;

            //System.Console.WriteLine(found ? "Found" : "Not Found");





        Console.ReadLine();
    }

        //1.  test function- // A test function that assigns a value to the out parameter 'num'
            static void test(out int num)
            {
                num = 5; // Assign a value to the out parameter      
            }
        //2.  Make a TryParse Function

            // // A function to find an item in a list and return its index
            static bool FindInList(string s, List<string> list, out int index)
            {
                index = -1; // Initialize index to -1 (not found)

                // Iterate over the list to find the item
                for (int i = 0; i < list.Count(); i++)
                {
                    // Compare the item in a case-insensitive manner
                    if (list[i].ToLower().Equals(s.ToLower()))
                    {
                        index = i; // Store the index of the found item
                    }
                }
                // Return true if the item was found, false otherwise
                return index >-1;
            }

            // A custom TryParse function (not fully implemented)
            static bool TryParse(string s, out int result)
            {
                // This implementation is incomplete, as it always returns true and sets result to 0
                result= 0;
                return true;
            }
        //3. Real world Function

}
