using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = UserInput();
            List<char> Alist = Checker(userInput);
            Calculate(Alist);
            
        }

        static string UserInput ()
        {
            Console.WriteLine("Enter the IC to be validated: ");
            string userIC = Console.ReadLine();
            return userIC;

        }

        static List<char> Checker(string input)
        {
            List<char> letters = new List<char>();

            foreach (char item in input)
            {
                letters.Add(item);
            }

            // We check if the first letter is T or t
            if (letters[0] == 't' || letters[0] == 'T')
            {
                if (letters.Count == 9)
                {
                    return letters;
                }
                else
                {
                    Console.WriteLine("Validity of the IC: False");
                }
            }
            else
            {
                Console.WriteLine(" Validity of the IC: False");
            }

            return letters;
        }


        static void Calculate(List<char> Somelist)
        {
            //We get the last letter
            char lastLetter = char.ToUpper(Somelist[8]);

            List<int> numbers = new List<int> { 2, 7, 6, 5, 4, 3, 2 };
            List<char> innerList = Somelist.GetRange(1, 8);
            List<int> icNumbers = new List<int>();

            // We convert each char into an int
            foreach (char item in innerList)
            {   
                // we convert the chars into integers
                int num = item - '0';
                icNumbers.Add(num);
            }

            // We multiply the numbers together
            int total = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = icNumbers[i] * numbers[i];
                total += sum;
            }
            total = total + 4;


            // list of elements
            List<int> listNum = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<char> listLetter = new List<char> { 'J', 'Z', 'I', 'H', 'G', 'F', 'E', 'D', 'C', 'B', 'A' };

            // we get the remainder
            int remainder = total % 11;

            // We get the position of the letter in the list
            int position = listLetter.IndexOf(lastLetter);


            //We check if the remainder is equal the the number in the list
            if (remainder != listNum[position])
            {   
                Console.WriteLine("Validity of the IC: False");
            } else
            {
                Console.WriteLine("Validity of the IC: True");
            }

     
        }

    }
        
    
    
}
