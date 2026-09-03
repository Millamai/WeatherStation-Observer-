using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    internal class BoringDisplay : IObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine("BoringDisplay :" + temperature + " C");
        }
    }
}
