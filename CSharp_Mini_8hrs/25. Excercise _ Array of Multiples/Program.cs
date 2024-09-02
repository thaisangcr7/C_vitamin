namespace _25._Excercise___Array_of_Multiples;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(" Sang is going to be a Developer");
        /*
            Define and initialize two interger (num, length) 
            (7,5) => [7, 14, 21, 28, 35]
            Create int array with size length
            Loop through and insert the (Loop counter x num) into the array
            print the final array 
        */

        // Break down
        // Create 2 int variables 1 is for num and and 1 is for length 
        // num is 7 and length is 5
        // Then create an array with a size of length
        // loop of through and insert value into array with expected output of [7, 14, 21, 28, 35]
            // loop 5 times and every times num x 3 then insert into array
        // then print the final array


        int num = 7;
        int length = 5;
        int Index_counter = 0;
         
        int[] Result_Array = new int[length];

        // everytime we loop = we increment these 2 varniables (i++, counter++)
        // we start mutiple from 1 not 0 
        for (int i = 1; i <= Result_Array.Length; i++, Index_counter++) // i = 0 // 0-4 => 1 -5 we want 1 to 5 so // also using less and equal to length because we want it to loop 5 times
        {
            // i for each index = num * i

            Result_Array[Index_counter] = num * i;
        }

        foreach (int i in Result_Array)
        {
            Console.Write($" {i}");

        }




        // ===============================================================================================

        // Explaination for For Loop and Foreach in Array
        System.Console.WriteLine();

        int number = 0;
        int length1 = 5;
        int[] Result_Array1 = new int[length1];

        for (int i = 0; i < Result_Array1.Length; i++)
        {
             Result_Array1[i] = number += 2;
                // Explanation: 
                // For each iteration:
                // i = 0: Result_Array1[0] = 2; result: [2]
                // i = 1: Result_Array1[1] = 4; result: [2, 4]
                // i = 2: Result_Array1[2] = 6; result: [2, 4, 6]
                // i = 3: Result_Array1[3] = 8; result: [2, 4, 6, 8]
                // i = 4: Result_Array1[4] = 10; result: [2, 4, 6, 8, 10]
        }

        foreach (int i in Result_Array1)
        {
            Console.Write($" {i}");
            // explaination: 
            // print each i in Result_Array[i,i] 
        }








    }
}
