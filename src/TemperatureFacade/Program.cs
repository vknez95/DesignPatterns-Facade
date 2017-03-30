using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureFacade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Count() == 0)
            {
                Console.WriteLine("Usage: dotnet run 'zipCode'");
            }
            else
            {
                const string zipCode = "83714";

                var temperatureFacade = new TemperatureLookupFacade();
                LocalTemperature localTemp = temperatureFacade.GetTemperature(zipCode);

                Console.WriteLine("The current temperature is {0}F/{1}C. in {2}, {3}",
                                    localTemp.Farenheit.ToString("F1"),
                                    localTemp.Celcius.ToString("F1"),
                                    localTemp.City,
                                    localTemp.State);
            }
        }
    }
}
