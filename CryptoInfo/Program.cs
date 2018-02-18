using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Crypto c = new Crypto();
            while (true)
            {
                Console.WriteLine("¿tQue cryptocurrency quieres consultar?");
                string currency = Console.ReadLine();
                Task<double> t = c.getPrice(currency);
                Console.WriteLine(t.GetAwaiter().GetResult());
            }
        }
    }
}
