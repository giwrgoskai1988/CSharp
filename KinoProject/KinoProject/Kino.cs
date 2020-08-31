using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    
    class Kino : IKino
    {   
        private enum Choose { Odd = 1, Even , Draw }
        private int choice { get; set; }
        public int moneyBet { get; set; }
        public int numberofDraws { get ; set ; }
        public int totalEarning { get ; set ; }

        public static readonly List<int> choosebet = new List<int> { 1, 2, 3, 5, 10, 15, 20, 30, 50, 100 };
        public static readonly List<int> chooseDraws = new List<int> { 1, 2, 3, 4, 5, 6, 10, 20, 50, 100, 200 };

        public List<int> results = new List<int>();
        private int even = 0;
        private static Random rnd = new Random();

        public Kino(int choose, int numofDraws , int betAmount)
        {            
            choice = choose;
            numberofDraws = numofDraws;
            moneyBet = betAmount;            
        }

        public void CalcEarning()
        {
            if (even == 10 && choice == (int)Choose.Draw)
            {
                totalEarning = totalEarning + moneyBet * 4;
                Console.WriteLine($"\nYou won {moneyBet*4} !");
            }
            else if (even > 10 && choice == (int)Choose.Even)
            {
                totalEarning = totalEarning + moneyBet * 2;
                Console.WriteLine($"\nYou won {moneyBet * 2} !");
            }
            else if (even < 10 && choice == (int)Choose.Odd)
            {
                totalEarning = totalEarning + moneyBet * 2;
                Console.WriteLine($"\nYou won {moneyBet * 2} !");
            }
            else
                Console.WriteLine("\nYou lost!");
            even = 0 ;
        }

        public void RunDraw()
        {
            results.Clear();
            for (int i = 0; i < 20; i++)
            {
                results.Add(rnd.Next(1, 81));
                even = results[i] % 2 == 0 ? even + 1 : even;
            }
        }

        public void ShowDrawNumbers()
        {
            Console.WriteLine($"\nWinning numbers for this draw are :\n ");
            for (int i = 0; i < 20; i++)
                Console.Write($"|{results[i]}| ");
        }
    }
}
