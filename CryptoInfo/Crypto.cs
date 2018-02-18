using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;


namespace CryptoInfo
{
    class Crypto
    {
        private HttpClient c;
        public Crypto()
        {
            c = new HttpClient();
            c.BaseAddress = new Uri("https://api.coinmarketcap.com/v1/ticker/");

        }


        public async Task<double> getPrice(string cryptocurrency)
        {
            string path = "?convert=EUR";
            HttpResponseMessage m = await c.GetAsync(path);
            Stream s = await m.Content.ReadAsStreamAsync();

            DataContractJsonSerializer dcjss = new DataContractJsonSerializer(typeof(List<CInfo>));

            List<CInfo> ci = (List<CInfo>)dcjss.ReadObject(s);
            CInfo currency = ci.Find(x => x.id.Equals(cryptocurrency));
            if (currency == null) return -1.0;
            double aux = Double.Parse(currency.price_eur.Replace(".", ","));
            return aux;
        }

    }
}
