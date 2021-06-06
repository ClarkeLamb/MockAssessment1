using System;

namespace MockAssessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //stuff used for all three problems
            AskUser();
            var userOne = GetNumberOne();
            var userTwo = GetNumberTwo();
            var userThree = GetNumberThree();

            //part one
            var result = IsTheSame(userOne, userTwo);
            Console.WriteLine(result);

            //part two
            double resultTwo = Subtract(userOne, userTwo);
            Console.WriteLine(resultTwo);

            //part three
             string resultThree = FindBuildingType(userThree);
            Console.WriteLine(resultThree);


        }

        static void AskUser()
        {
            Console.WriteLine("Enter three numbers.");
        }

        static int GetNumberOne()
        {
            var userInput = Console.ReadLine();
            return int.Parse(userInput);
        }
        static int GetNumberTwo()
        {
            var userInputTwo = Console.ReadLine();
            return int.Parse(userInputTwo);
        }

        static string GetNumberThree()
        {
            var userInputThree = Console.ReadLine();
            return userInputThree;
        }

        static bool IsTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;

            }
            else
            {
                return false;

            }

        }

        static double Subtract(double num1, double num2)
        {
            double diff = num1 - num2;
            return diff;
        }

        static string FindBuildingType(string num1)
        {
            int numOne = int.Parse(num1);

            if (numOne >= 4 && numOne <= 10)
            {
                string outcome = "This is an office building";
                return outcome;

            }else if(numOne > 50)
            {
                string outcome = "This is a SUPER skyscraper!";
                return outcome;

            }else if(numOne >= 11 && numOne <= 49)
            {
                string outcome = "This is a skyscraper";
                return outcome;

            }else if(numOne <= 3) 
            {
                string outcome = "This is a house";
                return outcome;
            }
            else
            {
                string outcome = "";
                return outcome;
            }
            
          
            

        }
    }
}
