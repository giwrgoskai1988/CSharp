using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    static class Helper
    {
        public enum Choose { Odd = 1, Even, Draw }
        public static readonly List<int> choosebet = new List<int> { 1, 2, 3, 5, 10, 15, 20, 30, 50, 100 };
        public static readonly List<int> chooseDraws = new List<int> { 1, 2, 3, 4, 5, 6, 10, 20, 50, 100, 200 };
        public static Random rnd = new Random();
        public static List<int> results = new List<int>();

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

        public static void Menu(ref int choose,ref int numofDraws,ref int betAmount)
        {            
            Console.WriteLine("Please choose your bet:");
            Console.WriteLine("[1]-Odd\n[2]-Even\n[3]-Draw");
            choose = Helper.IntInput(Console.ReadLine());
            while (choose != 1 && choose != 2 && choose != 3)
            {
                Console.WriteLine("Please type 1 for Odd, 2 for Even, 3 for Draw! :");
                choose = Helper.IntInput(Console.ReadLine());
            }
            Console.WriteLine("Please enter number of draws: ");
            numofDraws = Helper.InputInRange(Helper.chooseDraws, Helper.IntInput(Console.ReadLine()));
            Console.WriteLine("Please enter your bet amount!: ");
            betAmount = Helper.InputInRange(Helper.choosebet, Helper.IntInput(Console.ReadLine()));
            Console.WriteLine($"Your total bet amount is: {betAmount * numofDraws} for {numofDraws} draws !");
        }

    }
}
