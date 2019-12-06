using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K300_12._06._2019
{
    class Car
    {
        public string marka;
        public string model;
        public double currentFuel;
        public double MaxFuel;
        public double usefuel;
        public Car(string marka, string model, double maxfuel, double usefuel, double currentFuel=30)
        {
            this.marka = marka;
            this.model = model;
            this.MaxFuel = maxfuel;
            this.usefuel = usefuel;
            this.currentFuel = currentFuel;
        }
        public void Go()
        {
            Console.WriteLine("Nece km getmek isteyirsiz?");
            double neededKm =0;
            while (neededKm == 0)
            {
                string input = Console.ReadLine();
                if(CheckInput(input))
                {
                    neededKm = Convert.ToDouble(input);
                }
            }
            
        }
        public bool CheckInput(string inp)
        {
            try
            {
                Convert.ToDouble(inp);
                return true;
            }
            catch (Exception)
            {

                Console.WriteLine("Zehmet olmasa  reqem daxil edin!");
                return false;
            }
        }
    }
}
