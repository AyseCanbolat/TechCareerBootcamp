using System;
using System.Collections.Generic;

namespace proje1
{
    class Program
    { 


        static void Main(string[] args)
        {

            Console.WriteLine("Düelloya hoşgeldiniz.");
            Console.WriteLine("**********************");
            Console.WriteLine("Karakterinize isim veriniz.");
            Oyuncu oyuncu = new Oyuncu(Console.ReadLine()); // OYUNCUDAN INSTANCE ALDIK.
            Console.WriteLine("Karakteriniz " + oyuncu._karakterAdi + " ismi ile oluşturuldu.");
            

            //MAP KISMI.
            List<Map> maps = new List<Map>();
            Map map1 = new Map("Vahşi Batı");
            maps.Add(map1);
            Map map2 = new Map("Hayalet Şehir");
            maps.Add(map2);
            Map map3 = new Map("Eski Altın Madeni");
            maps.Add(map3);
            Map map4 = new Map("Kuzey Ormanı");
            maps.Add(map4);
            Map map5 = new Map("Vahşi Batı");
            maps.Add(map5);
            Map map6 = new Map("Mavi Gökyüzü");
            maps.Add(map6);
            Map map7 = new Map("Ege Suları");
            maps.Add(map7);
            Map map8 = new Map("Galaksi");
            maps.Add(map8);

            //MAPLERİ SIRALADIK.
            Console.WriteLine("\nAşağıdaki haritalardan birini seçiniz.\n");
            for (int i = 0; i < maps.Count; i++)
            {
                Console.WriteLine((i + 1) + "." + maps[i]._mapName);
            }

            //SEÇTİĞİ HARİTA ATANIYOR.
            oyuncu.secilenHarita = maps[Convert.ToInt32(Console.ReadLine()) - 1];
            Console.WriteLine("\n" + oyuncu.secilenHarita._mapName + " haritasını seçtiniz. \n");

            //CEPHANE KISMI.
            List<Cephane> cephanes = new List<Cephane>();
            Cephane rambo = new Cephane("Rambo", "K500", "bıçak", 5, oyuncu);
            cephanes.Add(rambo);
            Cephane rambo1 = new Cephane("Rambo", "K700", "bıçak", 8, oyuncu);
            cephanes.Add(rambo1);
            Cephane kst = new Cephane("KST", "K100", "kasatura", 8, oyuncu);
            cephanes.Add(kst);
            Cephane altipatlar = new Cephane("Altıpatlar", "A300", "tabanca", 8, 6, 1, oyuncu);
            cephanes.Add(altipatlar);
            Cephane su = new Cephane("Su", "S1000", "tabanca", 8, 15, 1, oyuncu);
            cephanes.Add(su);
            Cephane poz = new Cephane("Poz", "P400", "pompalı tüfek", 15, 5, 1, oyuncu);
            cephanes.Add(poz);
            Cephane tara = new Cephane("Tara", "T600", "taramalı tüfek", 10, 50, 5, oyuncu);
            cephanes.Add(tara);
            Cephane rot = new Cephane("Rot", "R100", "roket atar", 40, 1, 1, oyuncu);
            cephanes.Add(rot);
            Cephane guny = new Cephane("Guny", "G200", "top", 30, 1, 1, oyuncu);
            cephanes.Add(guny);



            /* DÜŞMAN KISMI 
              Random bir sayı ürettik o sayıya kadar for loop ile o sayı kadar düşman oluşturduk.
              For içinde unique düşman objesi oluşturduk ve düşman objesi içerisinde yer alan cephane listesini oyuncumuzun silahları ile eşledik.
              Oyuncunun seçmiş olduğu harita objesine düşmanlarımızı atadık.
            */

            List<Dusman> dusmanlar = new List<Dusman>();
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            int dusmanSayisi = rnd1.Next(2, 4);

            for (int i = 0; i < dusmanSayisi; i++)
            {
                Dusman yeniDusman = new Dusman(rnd3.Next(10,30));// canSayısı na random can gönderdik.
                yeniDusman.cephane = cephanes[rnd2.Next(0, cephanes.Count)];
                dusmanlar.Add(yeniDusman);
            }

            int kalanDusman = 0;
            oyuncu.secilenHarita.dusmans = dusmanlar;
            oyuncu.anlikDusman = oyuncu.secilenHarita.dusmans[kalanDusman];

            //ANLIK DÜŞMAN SİLAH MI KULLANIYOR?
            if ((oyuncu.anlikDusman.cephane._marka == "Rambo") || (oyuncu.anlikDusman.cephane._marka == "KST"))
            {
                oyuncu.anlikDusman.isCephaneBicak = true;
            }
            else
            {
                oyuncu.anlikDusman.isCephaneBicak = false;
            }


            //Seçilen haritaya atanan düşmanları sıraladık. 
            Console.WriteLine("\nAşağıdaki özelliklerdeki düşmanlar ile savaşacaksınız!\n");
            for (int i = 0; i < oyuncu.secilenHarita.dusmans.Count; i++)
            {
                Console.WriteLine((i + 1) + ". Düşman -> Silah Bilgisi: " + oyuncu.secilenHarita.dusmans[i].cephane._marka + " marka, " + oyuncu.secilenHarita.dusmans[i].cephane._model + " model, " + oyuncu.secilenHarita.dusmans[i].cephane._adi + ". Can Sayisi: " + oyuncu.secilenHarita.dusmans[i]._canSayisi);
            }

            //CEPHANEYİ SIRALIYORUZ.
            Console.WriteLine("\nAşağıdaki silahlardan 3 tane seçiniz.\n");
            for (int i = 0; i < cephanes.Count; i++)
            {
                Console.WriteLine((i + 1) + "." + cephanes[i]._marka + " marka" + " " + cephanes[i]._model + " model" + " " + cephanes[i]._adi + ". ");
            }

            //CEPHANEYİ KULLANICIDAN ALIYORUZ.
            for (int i = 0; i < 3; i++)
            {
                oyuncu.cephanes.Add(cephanes[Convert.ToInt32(Console.ReadLine()) - 1]);
            }

            //SEÇTİKLERİNİ TEKRAR SIRALIYORUZ.
            for (int i = 0; i < oyuncu.cephanes.Count; i++)
            {
                
                Console.WriteLine("\n" + (i + 1) + "." + oyuncu.cephanes[i]._marka + " marka" + " " + oyuncu.cephanes[i]._model + " model" + " " + oyuncu.cephanes[i]._adi + ". ");
            }

            Console.Write("\n ***Düello birazdan başlıyor***\n");

            //BAŞLANGIÇ SİLAHI SEÇER.
            Console.WriteLine("\n Başlamak için silahlarınızdan birini seçiniz.\n Silahlarınız: \n");
            for (int i = 0; i < oyuncu.cephanes.Count; i++)
            {
                Console.WriteLine("\n" + (i + 1) + "." + oyuncu.cephanes[i]._marka + " marka" + " " + oyuncu.cephanes[i]._model + " model" + " " + oyuncu.cephanes[i]._adi + ". ");
            }

            //BAŞLANGIÇ SİLAHINI SECİLEN CEPHANEYE ATADIK.
            oyuncu.secilenCephane = oyuncu.cephanes[Convert.ToInt32(Console.ReadLine()) - 1];

            //OYUNCU BIÇAK MI SEÇTİ ?
            if ((oyuncu.secilenCephane._marka == "Rambo") || (oyuncu.secilenCephane._marka == "KST"))
            {
                oyuncu.isCephaneBicak = true;
            } else
            {
                oyuncu.isCephaneBicak = false;
            }


            Console.WriteLine("\nDüelloya " + oyuncu.secilenCephane._marka + " marka" + " " + oyuncu.secilenCephane._model + " model" + " " + oyuncu.secilenCephane._adi + " ile başlıyorsunuz. \n");
            Console.WriteLine("***Default olarak karakterinizin toplam can puanı 100 olarak atanmıştır.***");

            while (oyuncu._toplamCan > 0 && oyuncu.anlikDusman._canSayisi > 0)
            {
                
                if (oyuncu.siraDurumu == true) {
                    Console.Write("\nPress 'a' to atack or choose weapon to 'c'\n");
                    string choice = Console.ReadLine();

                    if (choice == "a")
                    {

                        oyuncu.secilenCephane.useCephane(SilahKullanicisi.oyuncu);

                    }

                    else if (choice == "c")
                    {
                        //SEÇTİKLERİNİ TEKRAR SIRALIYORUZ.
                        for (int i = 0; i < oyuncu.cephanes.Count; i++)
                        {
                            Console.WriteLine("\n" + (i + 1) + "." + oyuncu.cephanes[i]._marka + " marka" + " " + oyuncu.cephanes[i]._model + " model" + " " + oyuncu.cephanes[i]._adi + ". ");
                        }

                        oyuncu.secilenCephane = oyuncu.cephanes[Convert.ToInt32(Console.ReadLine()) - 1];

                        if ((oyuncu.secilenCephane._marka == "Rambo") || (oyuncu.secilenCephane._marka == "KST"))
                        {
                            oyuncu.isCephaneBicak = true;
                        }
                        else
                        {
                            oyuncu.isCephaneBicak = false;
                        }
                    }
                }

                else
                {
  
                    if ((oyuncu.anlikDusman._canSayisi > 0) && ((oyuncu.anlikDusman.cephane._mermiSayisi > 0) || (oyuncu.anlikDusman.isCephaneBicak == true)))
                    {
                        oyuncu.anlikDusman.cephane.useCephane(SilahKullanicisi.dusman);
                    }

                }
            }

            Console.ReadLine();
    }
    
    }
}
