using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    class Map
    {
       public string _mapName;
       public List<Dusman> dusmans = new List<Dusman>();

        public Map(string mapName)
        {
            _mapName = mapName;
        }

    }
    
    
}
