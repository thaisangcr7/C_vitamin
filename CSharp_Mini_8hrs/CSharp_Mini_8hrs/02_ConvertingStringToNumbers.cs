using System;

namespace CSharp_Mini_8hrs
    
{
    public class _02_ConvertingStringToNumbers
    {
        public void run()
        {
            // Convert using Convert.toInt32()
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            System.Console.WriteLine(age);

            string textBigNumber = "9000000";
            long bignumber = Convert.ToInt64(textBigNumber);
            System.Console.WriteLine(bignumber);


            string Textnegative = "-55.2";
            Double negative = Convert.ToDouble(Textnegative);
            System.Console.WriteLine(negative);

            // Float
            string Textprecision = "5.00001"; 
            float floatprecision = Convert.ToSingle(Textprecision);
            System.Console.WriteLine(floatprecision);


            // Decimal 
            string textmoney = "14.99";
            decimal decimalmoney = Convert.ToDecimal(textmoney);
            System.Console.WriteLine(decimalmoney);






        }
    }

}
