using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    internal class WeatherStation : ISubject
    {
        List<IObserver> _subscribers = new List<IObserver>();
        int _temp = 0;

        public void Attach(IObserver ob)
        {
            //Tilføjer en ny abonnemnt
            _subscribers.Add(ob);
        }

        public void Detach(IObserver ob)
        {
            _subscribers.Remove(ob);
        }

        public void NotiFy()
        {
           foreach (IObserver subscriber in _subscribers)
            {
                subscriber.Update(_temp);

            }
        }

        //Sætter temperaturen
        public void SetTemperature(int temperature)
        {
            _temp = temperature;

            //Send besked ud til alle abonnenter
            NotiFy();

        }



    }
}
