using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSGOMusicPlayer.Models
{
    public class CsgoGameStateDto
    {
        public ProviderDto provider { get; set; }
        public MapDto map { get; set; }
        public PlayerDto player { get; set; }
        public RoundDto round { get; set; }
        
    }
}
