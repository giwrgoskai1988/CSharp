using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose your bet:");
            Console.WriteLine("[1]-Odd\n[2]-Even\n[3]-Draw");
            int choose = Helper.IntInput(Console.ReadLine());
            while (choose != 1 && choose != 2 && choose != 3)
            {
                Console.WriteLine("Please type 1 for Odd, 2 for Even, 3 for Draw! :");
                choose = Helper.IntInput(Console.ReadLine());
            }
            Console.WriteLine("Please enter number of draws: ");
            int numofDraws = Helper.InputInRange(Kino.chooseDraws, Helper.IntInput(Console.ReadLine()));
            Console.WriteLine("Please enter your bet amount!: ");
            int betAmount = Helper.InputInRange(Kino.choosebet, Helper.IntInput(Console.ReadLine()));
            Console.WriteLine($"Your total bet amount is: {betAmount * numofDraws} for {numofDraws} draws !");

            IKino a = new Kino(choose, betAmount, numofDraws);

            for (int i = 1; i <= numofDraws; i++)
            {
                a.RunDraw();
                a.ShowDrawNumbers();
                a.CalcEarning();
            }
            Console.WriteLine($"Total Earnings = {a.totalEarning}!\n");

        }       
    }
}
