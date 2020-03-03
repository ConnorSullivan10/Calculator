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
            string operator1 = Console.ReadLine().ToLower();
            if (operator1 == "multiply")
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
            else if (operator1 == "square")
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

            Console.WriteLine("Enter a series of comma separated numbers as well as a prefix to indicate whether you'd like the numbers to be multiplied, squared, added, divided, or averaged (*, ^, +, /, avg) ");
            string initialEntry = Console.ReadLine().ToLower();
            char operator2 = initialEntry[0];
            if (initialEntry.Substring(0, 3) == "avg")
            {
                char[] charToTrim2 = { 'a', 'v', 'g' };
                string trimmedAvg = initialEntry.TrimStart(charToTrim2);
                string[] splitTrimmedAvg = trimmedAvg.Split(',');
                int sum = 0;
                for (var i = 0; i < splitTrimmedAvg.Length; i++)
                {
                    sum += int.Parse(splitTrimmedAvg[i]);
                }
                var average = sum / splitTrimmedAvg.Length;
                Console.WriteLine(average);
            }
            else
            {
                char[] charToTrim3 = { '*', '^', '+', '/' };
                string trimmedEntry = initialEntry.TrimStart(charToTrim3);
                string[] splitInitialEntry = trimmedEntry.Split(',');
                switch (operator2)
                {
                    case '*':
                        int multiplySequenceStart = 1;
                        foreach (var entry in splitInitialEntry)
                        {
                            int singleNum = int.Parse(entry);
                            multiplySequenceStart *= singleNum;
                        }
                        Console.WriteLine(multiplySequenceStart);
                        break;
                    case '^':
                        string squaredSequence = "";
                        foreach (var entry in splitInitialEntry)
                        {
                            int singleNum = int.Parse(entry);
                            var squared = singleNum * singleNum;
                            string squaredString = squared.ToString() + ",";
                            squaredSequence += squaredString;
                        }
                        char[] endComma = { ',' };
                        Console.WriteLine(squaredSequence.TrimEnd(endComma));
                        break;
                    case '+':
                        int additionSequenceStart = 0;
                        foreach (var entry in splitInitialEntry)
                        {
                            int singleNum = int.Parse(entry);
                            additionSequenceStart += singleNum;
                        }
                        Console.WriteLine(additionSequenceStart);
                        break;
                    case '/':
                        var divisionStart = 0m;
                        for (var k = 0; k < splitInitialEntry.Length; k++)
                        {
                            if (k == 0)
                            {
                                divisionStart = Convert.ToDecimal(splitInitialEntry[k]);
                            }
                            else
                            {
                                divisionStart /= Convert.ToDecimal(splitInitialEntry[k]);
                            }
                        }
                        Console.WriteLine(divisionStart);
                        break;
                }

            }
        }
    }

}
