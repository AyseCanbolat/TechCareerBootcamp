using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    class Oyuncu
    {
        public string _karakterAdi;
        public int _toplamCan=30;
        public List<Cephane> cephanes = new List<Cephane>();
        public Map secilenHarita;
        public Cephane secilenCephane;
        public Dusman anlikDusman;
        public bool siraDurumu = true;
        public bool isCephaneBicak = false;

        public Oyuncu(string karakterAdi)
        {
            _karakterAdi = karakterAdi;
        }


        public void cephaneDegistir(Cephane cephane)
        {
            secilenCephane = cephane;
        }

    }

    
    
}
