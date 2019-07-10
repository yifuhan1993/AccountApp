using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven
{
    class Program
    {
        static void Main(string[] args)
        {
            Oven oven = new Oven(37, 100);
            oven.OverHeat += new OvenEventHandler(() => { Console.WriteLine("Alarm!"); });
            oven.OverHeat += new OvenEventHandler(() => { oven.TurnOff(); });

            oven.Run();
        }
    }
}
