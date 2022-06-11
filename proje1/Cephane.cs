using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{

    public enum SilahKullanicisi
    {
        dusman,
        oyuncu
    };


    class Cephane
    {


       public string _marka;
       public string _model;
       public string _adi; 
       public int _canDegeri;
       public bool _bileymek = true;
       public int _mermiSayisi;
       public int _currentIndex;
       public int _mermiKullanimSayisi;

        Oyuncu _oyuncu;

        public Cephane(string marka, string model, string adi, int canDegeri, Oyuncu oyuncu)
        {
            _marka = marka;
            _model = model;
            _adi = adi;
            _canDegeri = canDegeri;
            _oyuncu = oyuncu;
            

        }
        public Cephane(string marka, string model, string adi, int canDegeri, int mermiSayisi, int mermiKullanimSayisi, Oyuncu oyuncu)
        {
            _marka = marka;
            _model = model;
            _adi = adi;
            _canDegeri = canDegeri;
            _mermiSayisi = mermiSayisi;
            _oyuncu = oyuncu;
            _mermiKullanimSayisi = mermiKullanimSayisi;
        }

        public Cephane(int index)
        {
            _currentIndex = index;
            
        }
        public void useCephane(Enum silahKullanicisi)
        {
            switch (silahKullanicisi) 
            {
                case SilahKullanicisi.dusman:
                    _oyuncu.anlikDusman.cephane._mermiSayisi -= _oyuncu.anlikDusman.cephane._mermiKullanimSayisi;
                    _oyuncu._toplamCan -= _oyuncu.anlikDusman.cephane._canDegeri;
                    _oyuncu.anlikDusman.siraDurumu = false;
                    _oyuncu.siraDurumu = true;
                    break;
                case SilahKullanicisi.oyuncu:
                    _oyuncu.secilenCephane._mermiSayisi -= _oyuncu.secilenCephane._mermiKullanimSayisi;
                    _oyuncu.anlikDusman._canSayisi -= _oyuncu.secilenCephane._canDegeri;
                    _oyuncu.siraDurumu = false;
                    _oyuncu.anlikDusman.siraDurumu = true;
                    break;
            }
        }

        private void Bileyle()
        {
            _bileymek = true;
        }


    }
}
