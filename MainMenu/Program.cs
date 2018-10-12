using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool turn = true;
            while (turn)
            {
                Console.WriteLine("ADMIN MENU");
                Console.WriteLine("==========");
                Console.WriteLine("[1] Read bicycle info from file");
                Console.WriteLine("[2] Display all bicycle info with servicing indication");
                Console.WriteLine("[3] Display selected bicycle info");
                Console.WriteLine("[4] Add a bicycle");
                Console.WriteLine("[5] Perform bicycle maintenance");
                Console.WriteLine("[0] Exit");
                Console.Write("Enter your option: ");
                string option = Console.ReadLine();
                Console.WriteLine("You have selected option {0}", option);

                if (option == "0")
                {
                    turn = false;
                }
            }
        }
    }
}
