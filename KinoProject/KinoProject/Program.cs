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
            int choose = 0, numofDraws = 0, betAmount = 0;

            Helper.Menu(ref choose,ref numofDraws,ref betAmount);

            IKino a = new Kino(choose, numofDraws, betAmount);           
            for (int i = 1; i <= a.numberofDraws; i++)
            {
                a.RunDraw();
                a.ShowDrawNumbers();
                a.CalcEarning();
            }
            Console.WriteLine($"Total Earnings = {a.totalEarning}!\n");

        }       
    }
}
