using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    static class Helper
    {
        public static int IntInput(string str)
        { 
            int input;
            while (!int.TryParse(str, out input))
            {
                Console.WriteLine("Wrong input! Type an integer!:");
                str = Console.ReadLine();
            }
            return input;
        }

        public static int InputInRange(List<int> mylist, int input)
        { 
            while (!mylist.Contains(input))
            {
                Console.WriteLine("Wrong input! Please choose one of these :");
                for (int i = 0; i < mylist.Count; i++)
                {
                    Console.Write($"{mylist[i]}    ");
                }
                input = IntInput(Console.ReadLine());
            }
            return input;
        }

    }
}
