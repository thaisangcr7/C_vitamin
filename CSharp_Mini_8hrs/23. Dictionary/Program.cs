namespace _23._Dictionary;

class Program
{
    static void Main(string[] args)
    {
        // Create a dictionary
        // a dictionary can store any values as we want but not null
        // Key must be unique and value can be the same

        // example1:  to create a dictionary with unique id and name
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                { 1, " D" },
            };
            // Add keyValue Pair
            names.Add(2, "John");
            names.Add(3, "Doe");
            names.Add(4, "John");

            // print dictionary
            foreach (var pair in names)
            {
                Console.WriteLine("Key = {0}, Value = {1}", pair.Key, pair.Value);
            }
        
        // ex 2: create a new Dic
            Dictionary<int, string> Dic_Names = new Dictionary<int, string>()
            {
                // keyValuePair
                { 1, "Sang" },
                { 2, "Thu" },
                {3, "Sang"}
            };

            // Use For Loop to access our dictionary
            for (int i = 0; i < Dic_Names.Count; i ++)
            {
                // Use ElementAt to return return keyvaluePair 
                KeyValuePair<int, string> pair = Dic_Names.ElementAt(i);

                System.Console.WriteLine($"Key:{pair.Key} - Value: {pair.Value}");
            }

            // Use Foreach to access our dictionary - print
            foreach (KeyValuePair<int, string> item in Dic_Names)
            {
                System.Console.WriteLine($"Key:{item.Key} - Value: {item.Value}");
            }

        // ex 3: ========================== Teacher ==========================
            Dictionary<string, string?> teachers = new Dictionary<string, string?>()
            {
                { "Math", "Sang Thai" },
                {"English", "Thu"},
            };
            System.Console.WriteLine(teachers["Math"]); 
            // This will go and find the value of the Key // the result will be: Sang
            // System.Console.WriteLine(teachers["math"]); // This will give the error because we mistype the key

            // TryGetValues is similar with int.TryParse Convert 
            // If the key is not found, it will return false
            // if (teachers.TryGetValue("Math", out string value))

            if (teachers.TryGetValue("Math", out string? TeacherValue))
            {
                System.Console.WriteLine(TeacherValue);

                // // we also change/update the name of the teacher using the [""]
                //teachers["Math"] = "Aleena Thai";
            }
            else
            {
                System.Console.WriteLine("Math teacher is not found");
            }
            
            // To Remove 
            // make sure the item exist 
                // if (teachers.ContainsKey("English"))
                // {
                //     teachers.Remove("English");
                // }
                // else
                // {
                // System.Console.WriteLine("item not found");
                // }

            // teachers.Remove("Math");

            // print Teachers dictionary
            foreach (KeyValuePair<string, string?> item in teachers)
            {
                System.Console.WriteLine($"Key:{item.Key} - Value: {item.Value}");
            }


        
        
    }
}
