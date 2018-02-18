﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CryptoInfo
{
    [DataContract]
    public class CInfo
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string symbol { get; set; }
        [DataMember]
        public string rank { get; set; }
        [DataMember]
        public string price_usd { get; set; }
        [DataMember]
        public string price_btc { get; set; }
        [DataMember]
        public string __invalid_name__24h_volume_usd { get; set; }
        [DataMember]
        public string market_cap_usd { get; set; }
        [DataMember]
        public string available_supply { get; set; }
        [DataMember]
        public string total_supply { get; set; }
        [DataMember]
        public string max_supply { get; set; }
        [DataMember]
        public string percent_change_1h { get; set; }
        [DataMember]
        public string percent_change_24h { get; set; }
        [DataMember]
        public string percent_change_7d { get; set; }
        [DataMember]
        public string last_updated { get; set; }
        [DataMember]
        public string price_eur { get; set; }
        [DataMember]
        public string __invalid_name__24h_volume_eur { get; set; }
        [DataMember]
        public string market_cap_eur { get; set; }
    }
}
