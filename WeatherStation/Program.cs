namespace WeatherStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            WeatherStation ws = new WeatherStation();

            FancyDisplay fd = new FancyDisplay();
            BoringDisplay boring = new BoringDisplay();
            ws.Attach(fd);
            ws.Attach(boring);

            for (int i = 0; i < 10; i++)
            {
                ws.SetTemperature(r.Next(12, 30));
                Thread.Sleep(1000);

            }

            Console.ReadLine();
        }
    }
}
