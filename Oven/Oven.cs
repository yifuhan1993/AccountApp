using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oven
{
    // 定义委托
    public delegate void OvenEventHandler();

    public class Oven
    {
        private int temp;
        public bool isTurnOn = false;

        // 定义事件
        public event OvenEventHandler OverHeat;

        public int TemperatureThreshold { get; set; }
        public Oven(int temperature, int thresholdTemp)
        {
            temp = temperature;
            TemperatureThreshold = thresholdTemp;
        }

        public void Run()
        {
            TurnOn();
            while (isTurnOn)
            {
                Heating();
                if (IsOverheating())
                {
                    OverHeat();
                }
                Thread.Sleep(1000);
            }
        }

        private bool IsOverheating()
        {
            return temp >= TemperatureThreshold;
        }

        public void TurnOn()
        {
            isTurnOn = true;
        }

        public void TurnOff()
        {
            isTurnOn = false;
        }

        private void Heating()
        {
            temp += 1;
            Console.WriteLine("The temperature is: {0}°C", temp);
        }
    }
}

