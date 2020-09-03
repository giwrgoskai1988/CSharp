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

        int[] even ;


        public Kino(int choose, int numofDraws , int betAmount)
        {            
            choice = choose;
            numberofDraws = numofDraws;
            moneyBet = betAmount;
            even = new int[numberofDraws];
            
        }

        public void CalcEarning()
        {
            if (Helper.results.Count != 0)
            {
                for (int j = 0; j < numberofDraws; j++)
                {
                    if (even[j] == 10 && choice == (int)Helper.Choose.Draw)
                    {
                        totalEarning = totalEarning + moneyBet * 4;
                        Console.WriteLine($"\n\nYou won {moneyBet * 4} in Draw {j+1} !");
                    }
                    else if (even[j] > 10 && choice == (int)Helper.Choose.Even)
                    {
                        totalEarning = totalEarning + moneyBet * 2;
                        Console.WriteLine($"\n\nYou won {moneyBet * 2} in Draw {j+1} !");
                    }
                    else if (even[j] < 10 && choice == (int)Helper.Choose.Odd)
                    {
                        totalEarning = totalEarning + moneyBet * 2;
                        Console.WriteLine($"\n\nYou won {moneyBet * 2} in Draw {j+1} !");
                    }
                    else
                        Console.WriteLine($"\n\nYou lost in Draw {j+1}!");
                }

                Console.WriteLine($"\nTotal Earnings = {totalEarning}!\n");
            }
            else
                Console.WriteLine("No results to calculate! Run a draw first!");
        }
        
        public void RunDraw()
        {
            for (int j = 1; j <= numberofDraws; j++)
            {
                
                for (int i = (j*20) -20; i < j*20; i++)
                {                    
                    Helper.results.Add(Helper.rnd.Next(1, 81));
                    even[j-1] = Helper.results[i] % 2 == 0 ? even[j-1] + 1 : even[j-1];
                }
            }
        }

        public void ShowDrawNumbers()
        {
            if (Helper.results.Count != 0)
            {
                for (int j = 1; j <= numberofDraws; j++)
                {
                    Console.WriteLine($"\n\nWinning numbers for  draw {j} are :\n ");
                    for (int i = ( j * 20 ) -20 ; i < j * 20 ; i++)
                    {
                        Console.Write($"|{Helper.results[i]}| ");
                    }
                }
            }
            else
                Console.WriteLine("No results to show! You must run a draw first!");
        }
    }
}
