using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSGOMusicPlayer.Models
{
    public class ProviderDto
    {
        public string name { get; set; }
        public int appid { get; set; }
        public int version { get; set; }
        public string steamid { get; set; }
        public int timestamp { get; set; }
    }
}
