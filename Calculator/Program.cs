using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of comma separated numbers that you'd like to have multiplied by one another in order");
            string givenNumbers = Console.ReadLine();
            string[] splitNumbers = givenNumbers.Split(',');
            // loop through numbers and multiply
            int numberSequence = 1;
            foreach (var splitNumber in splitNumbers)
            {
                int number = int.Parse(splitNumber);
                numberSequence *= number;
            }
            Console.WriteLine(numberSequence);


            Console.WriteLine("Now before you enter your next set of numbers separated by commas, would you like to square or multiply them?");
            string operand = Console.ReadLine().ToLower();
            if (operand == "multiply")
            {
                Console.WriteLine("Enter the comma separated numbers that you'd like multiplied");
                string numsToMultiply = Console.ReadLine();
                string[] splitMultipliedNumbers = numsToMultiply.Split(',');
                int multipliedSequenceStart = 1;
                foreach (var splitMultipliedNumber in splitMultipliedNumbers)
                {
                    int individualNumber = int.Parse(splitMultipliedNumber);
                    multipliedSequenceStart *= individualNumber;
                }
                Console.WriteLine(multipliedSequenceStart);
                Console.ReadLine();
            }
            else if (operand == "square")
            {
                Console.WriteLine("Enter the comma separated numbers that you'd like squared");
                string numsToSquare = Console.ReadLine();
                string[] splitSquaredNumbers = numsToSquare.Split(',');
                string squaredSequence = "";
                foreach (var splitSquaredNumber in splitSquaredNumbers)
                {
                    int singleNum = int.Parse(splitSquaredNumber);
                    var squared = singleNum * singleNum;
                    string squaredString = squared.ToString() + ",";
                    squaredSequence += squaredString;
                }
                char[] charToTrim = { ',' };
                Console.WriteLine(squaredSequence.TrimEnd(charToTrim));
                Console.ReadLine();
            }
        }
    }

}
