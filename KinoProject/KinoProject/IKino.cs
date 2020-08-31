using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    interface IKino
    {        
        int moneyBet { get; set; }
        int numberofDraws { get; set; }
        int totalEarning { get; set; }

        void ShowDrawNumbers();
        void CalcEarning();
        void RunDraw();
    }
}
