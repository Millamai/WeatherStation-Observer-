using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    internal class FancyDisplay : IObserver
    {

        //Denne metode kaldes automatisk når publisher kalder metoden
        public void Update(int temperature) //Denne metode er tvunget implementering fra interfacet
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("FancyDisplay :" + temperature +" C");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
