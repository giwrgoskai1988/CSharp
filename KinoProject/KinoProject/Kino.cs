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
        private int choice { get; set; }
        public int moneyBet { get; set; }
        public int numberofDraws { get ; set ; }
        public int totalEarning { get ; set ; }
        private int even = 0;

        public Kino(int choose, int numofDraws , int betAmount)
        {            
            choice = choose;
            numberofDraws = numofDraws;
            moneyBet = betAmount;            
        }

        public void CalcEarning()
        {
            if (Helper.results.Count != 0)
            {
                if (even == 10 && choice == (int)Helper.Choose.Draw)
                {
                    totalEarning = totalEarning + moneyBet * 4;
                    Console.WriteLine($"\nYou won {moneyBet * 4} !");
                }
                else if (even > 10 && choice == (int)Helper.Choose.Even)
                {
                    totalEarning = totalEarning + moneyBet * 2;
                    Console.WriteLine($"\nYou won {moneyBet * 2} !");
                }
                else if (even < 10 && choice == (int)Helper.Choose.Odd)
                {
                    totalEarning = totalEarning + moneyBet * 2;
                    Console.WriteLine($"\nYou won {moneyBet * 2} !");
                }
                else
                    Console.WriteLine("\nYou lost!");
                even = 0;
            }
            else
                Console.WriteLine("No results to calculate! Run a draw first!");
        }

        public void RunDraw()
        {           
            for (int i = 0; i < 20; i++)
            {
                Helper.results.Add(Helper.rnd.Next(1, 81));
                even = Helper.results[i] % 2 == 0 ? even + 1 : even;
            }
        }

        public void ShowDrawNumbers()
        {
            if (Helper.results.Count != 0)
            {
                Console.WriteLine($"\nWinning numbers for this draw are :\n ");
                for (int i = 0; i < Helper.results.Count; i++)
                {

                    Console.Write($"|{Helper.results[i]}| ");
                }
            }
            else
                Console.WriteLine("No results to show! You must run a draw first!");
        }
    }
}
