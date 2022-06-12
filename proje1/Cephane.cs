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
       public bool _bileylemek = true;
       public int _mermiSayisi;
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

        public void useCephane(Enum silahKullanicisi)
        {
            switch (silahKullanicisi) 
            {
                case SilahKullanicisi.dusman:
                    if (_oyuncu.anlikDusman.isCephaneBicak == true)
                    {
                        _oyuncu._toplamCan -= _oyuncu.anlikDusman.cephane._canDegeri;

                        if (_oyuncu._toplamCan <= 0)
                        {
                            Console.WriteLine("Düşman " + _oyuncu.anlikDusman.cephane._marka + " markaya sahip bıçak ile saldırısını gerçekleştirdi, oyuncunun kalan can sayısı: " + 0);
                            break;
                        } else if (_oyuncu._toplamCan > 0)
                        {
                            Console.WriteLine("Düşman " + _oyuncu.anlikDusman.cephane._marka + " markaya sahip bıçak ile saldırısını gerçekleştirdi, oyuncunun kalan can sayısı: " + _oyuncu._toplamCan);
                        }
                        
                        Bileyle(silahKullanicisi);
                        _oyuncu.anlikDusman.siraDurumu = false;
                        _oyuncu.siraDurumu = true;

                        if (_oyuncu._toplamCan <= 0)
                        {
                            Console.WriteLine(_oyuncu.anlikDusman.cephane._marka + " markaya sahip düşman seni öldürdü ve oyunu kaybettin.");
                            break;
                        }

                    }

                    else
                    {
                        _oyuncu.anlikDusman.cephane._mermiSayisi -= _oyuncu.anlikDusman.cephane._mermiKullanimSayisi;
                        _oyuncu._toplamCan -= _oyuncu.anlikDusman.cephane._canDegeri;



                        if (_oyuncu._toplamCan <= 0)
                        {
                            Console.WriteLine("Düşman " + _oyuncu.anlikDusman.cephane._marka + " markaya sahip silah ile oyuncuya saldırdı, oyuncu can bilgisi: " + 0);
                            Console.WriteLine(_oyuncu.anlikDusman.cephane._marka + " markaya sahip düşman seni öldürdü ve oyunu kaybettin.");
                            break;
                        }
                        else if (_oyuncu._toplamCan > 0)
                        {
                            Console.WriteLine("Düşman " + _oyuncu.anlikDusman.cephane._marka + " markaya sahip silah ile oyuncuya saldırdı, oyuncu can bilgisi: " + _oyuncu._toplamCan);
                        }

                        _oyuncu.anlikDusman.siraDurumu = false;
                        _oyuncu.siraDurumu = true;
                    }

                    break;
                case SilahKullanicisi.oyuncu:

                    if (_oyuncu.isCephaneBicak == true)
                    {
                        _oyuncu.anlikDusman._canSayisi -= _oyuncu.secilenCephane._canDegeri;

                        if ((_oyuncu.anlikDusman._canSayisi <= 0) && (_oyuncu.secilenHarita.dusmans.Count >= 0))
                        {
                            _oyuncu.secilenHarita.dusmans.RemoveAt(0);
                            Console.WriteLine("Oyuncu " + _oyuncu.anlikDusman.cephane._marka + " markaya sahip düşmanı öldürdü.");

                            if (_oyuncu.secilenHarita.dusmans.Count != 0)
                            {

                                _oyuncu.anlikDusman = _oyuncu.secilenHarita.dusmans[0];

                                //ANLIK DÜŞMAN SİLAH MI KULLANIYOR?
                                if ((_oyuncu.anlikDusman.cephane._marka == "Rambo") || (_oyuncu.anlikDusman.cephane._marka == "KST"))
                                {
                                    _oyuncu.anlikDusman.isCephaneBicak = true;
                                }
                                else
                                {
                                    _oyuncu.anlikDusman.isCephaneBicak = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Oyunu kazandın.");
                                break;
                            }
                        }

                        Console.WriteLine("Oyuncu " + _oyuncu.secilenCephane._marka + " markaya sahip bıçak ile saldırısını gerçekleştirdi.. Düşmanın kalan can sayısı: " + _oyuncu.anlikDusman._canSayisi);
                        _oyuncu.siraDurumu = false;
                        _oyuncu.anlikDusman.siraDurumu = true;
                        _oyuncu.anlikDusman.cephane._bileylemek = false;
                        Bileyle(silahKullanicisi);

                        if ((_oyuncu._toplamCan > 0) && (_oyuncu.secilenHarita.dusmans.Count == 0))
                        {
                            Console.WriteLine("Tebrikler " + _oyuncu._karakterAdi + " oyunu başarılı bir şekilde kazandın.");
                            break;
                        }
                    }
                    else
                    {
                        _oyuncu.secilenCephane._mermiSayisi -= _oyuncu.secilenCephane._mermiKullanimSayisi;
                        _oyuncu.anlikDusman._canSayisi -= _oyuncu.secilenCephane._canDegeri;

                        if ((_oyuncu.anlikDusman._canSayisi <= 0) && (_oyuncu.secilenHarita.dusmans.Count >= 0))
                        {
                            _oyuncu.secilenHarita.dusmans.RemoveAt(0);
                            Console.WriteLine("Oyuncu " + _oyuncu.anlikDusman.cephane._marka + " markaya sahip düşmanı öldürdü.");

                            if (_oyuncu.secilenHarita.dusmans.Count != 0)
                            {

                                _oyuncu.anlikDusman = _oyuncu.secilenHarita.dusmans[0]; //remove ettiğimiz düşmanın (anlık düşmanın) yerine tekrar bir sonraki indextekini atadık.

                                //ANLIK DÜŞMAN SİLAH MI KULLANIYOR?
                                if ((_oyuncu.anlikDusman.cephane._marka == "Rambo") || (_oyuncu.anlikDusman.cephane._marka == "KST"))
                                {
                                    _oyuncu.anlikDusman.isCephaneBicak = true;
                                }
                                else
                                {
                                    _oyuncu.anlikDusman.isCephaneBicak = false;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Oyunu kazandın.");
                                break;
                            }
                        }



                        Console.WriteLine("Oyuncu " + _oyuncu.secilenCephane._marka + " markaya sahip silah ile saldırısını gerçekleştirdi, düşmanın kalan can sayısı: " + _oyuncu.anlikDusman._canSayisi);
                        _oyuncu.siraDurumu = false;
                        _oyuncu.anlikDusman.siraDurumu = true;


                        if ((_oyuncu._toplamCan > 0) && (_oyuncu.secilenHarita.dusmans.Count == 0))
                        {
                            Console.WriteLine("Tebrikler " + _oyuncu._karakterAdi + " oyunu başarılı bir şekilde kazandın.");
                            break;
                        }
                    }
                    break;
            }
        }

        private void Bileyle(Enum silahKullanicisi)
        {

            switch (silahKullanicisi)
            {
                case SilahKullanicisi.dusman:
                    _oyuncu.anlikDusman.cephane._bileylemek = true;
                    Console.WriteLine("Düşman " + _oyuncu.anlikDusman.cephane._marka + " markalı bıçağını bileyledi.");
                    break;
                case SilahKullanicisi.oyuncu:
                    _oyuncu.secilenCephane._bileylemek = true;
                    Console.WriteLine(_oyuncu.secilenCephane._marka + " markalı bıçağın bileylendi.");
                    break;
            }
            
        }


    }
}
