# TechCareerBootcamp
TechCareer War Game
Bu doküman geliştirilecek TechCareer War isimli oyunun analizini içermektedir. Bu oyun, kullanıcıların
yönettikleri oyun karakteriyle bilgisayar tarafından yönetilen oyun karakterlerine karşı savaştığı bir
oyundur.
Kullanıcılar oyuna başlarken karakterlerine bir isim verirler. Ardından oynayacakları haritayı seçerler.
Sonra cephanelikte yer alan silahlardan seçim yapıp oyuna başlarlar. Haritayı tamamlayana kadar
seçtikleri silahlardan başka silah kullanamazlar.
Oyun başladıktan sonra ilgili harita üzerinde yer alan ve bilgisayar tarafından yönetilen düşman
karakterlerinin hepsiyle sırayla savaşırlar. Bu savaşların birinde oyuncunun karakteri öldüğünde oyun
sonlanır. Oyuncu tüm düşmanlarını öldürmeyi başarırsa harita tamamlanır ve oyun sona erer.
Oyuncu harita üzerinde ilerlerken her defasında bir düşmanla savaşır. Bu birebir savaşın adı düellodur.
Bir düelloda oyuncu ve düşman karakter sırayla silah kullanır. Düellolarda ilk saldırı hakkı oyuncunundur.
Ardından düşman karakter saldırıda bulunur. Düşman karakter ölürse oyuncu düelloyu kazanmış olur.
Eğer harita üzerinde düello yapacak başka düşman kalmamışsa oyuncu oyunu başarıyla tamamlamış
olur.
Oyun Öncesi
Oyuncu bir oyuna başlarken önce karakteri oluşturulur. Karakterin oyuncu tarafından girilen bir adı ve
canı vardır. Karakterin can değeri başlangıçta 100’dür. Düellolar esnasında aldığı yaraların türüne göre bu
can değeri azalır. Can değeri 0 olduğunda karakter ölür.
Bu oyunda önceden tanımlı haritalar bulunmaktadır. Oyuncunun oyuna başlayabilmesi için bu
haritalardan birini seçmesi gerekir. Haritaların “Vahşi Batı”, ”Hayalet Şehir”, “Eski Altın Madeni”, “Kuzey
Ormanı” gibi isimleri vardır. Bir haritanın ismi 15 karakterden uzun değildir. Her harita için üzerinde yer
alan düşman karakter sayısı bellidir. Bu sayı en az 3 en çok 8’dir. Oyuncu haritayı seçip oyuna
başladığında kaç düşmanla savaşacağını görür.
Oyuncu seçtiği haritada ilerlemeye başlamadan önce cephanelikten kullanacağı 3 adet silah seçimi
yapmalıdır. Tüm oyun boyunca sadece bu silahları kullanabilir. Bir düelloda saldırı sırası oyuncudayken
kullanabileceği bir silah yoksa karakteri ölür ve oyun sonlanır.
Cephanelik
Oyuncunun seçim yapabileceği farklı tip silahların olduğu bir cephanelik mevcuttur. Düşman karakterler
de yine bu silahları kullanırlar.
• Rambo marka K500 model bıçak. Her kullanımdan sonra bileylenmesi gerekir. Karşı tarafın can
değerini 5 azaltır.
• Rambo marka K700 model bıçak. Her kullanımdan sonra bileylenmesi gerekir. Karşı tarafın can
değerini 8 azaltır.
• KST marka K100 model kasatura. Her kullanımdan sonra bileylenmesi gerekir. Karşı tarafın can
değerini 8 azaltır.
• Altıpatlar marka A300 model tabanca. Şarjörü 6 adet çekirdekli mermi alır. Her kullanımda tek
mermi atar. Karşı tarafın can değerini 8 azaltır.
• Su marka S1000 model tabanca. Şarjörü 15 adet çekirdekli mermi alır. Her kullanımda tek mermi
atar. Karşı tarafın can değerini 8 azaltır.
• Poz marka P400 model pompalı tüfek. Şarjörü 5 adet saçma mermisi alır. Her kullanımda tek
mermi atar. Karşı tarafın can değerini 15 azaltır. Hedefi net görmek için yakınlaştırma imkanı
tanır.
• Tara marka T600 model taramalı tüfek. Şarjörü 50 adet çekirdekli mermi alır. Her kullanımda 5
adet mermi atar. Karşı tarafın can değerini 10 azaltır. Hedefi net görmek için yakınlaştırma
imkanı tanır.
• Rot marka R100 model roketatar. 1 adet roket mermisi alır. Her kullanımda tek roket atar. Karşı
tarafın can değerini 40 azaltır. Hedefi net görmek için yakınlaştırma imkanı tanır.
• Guny marka G200 model top. 1 adet top mermisi alır. Her kullanımda tek top atar. Karşı tarafın
can değerini 30 azaltır.
Oyuna Başlama
Oyun başladığında öncelikle, oyuncunun seçtiği harita üzerinde yer alan düşman karakterleri oluşur. Her
karakterin kullandığı tek bir silah vardır. Bu silah rastgele belirlenir. Her karakterin can değeri de rastgele
belirlenir. Bu değer en az 30 en çok 70’dir.
Oyuncu ilk düellosunu harita üzerinde yer alan düşmanlardan herhangi biriyle yapar. Eğer bu düelloyu
kazanırsa sıradaki düşman karakteri de kalanlardan herhangi biridir.
Düello
Oyuncu bir düelloya başlarken öncelikle elindeki silahlardan birini seçer. Seçtiği silah ile ilk saldırısını
yapar. Silahın tipine göre düşman karakterinin can değeri azalır. Eğer düşmanın can değeri 0 olursa
düello oyuncu lehine sonuçlanmış olur.
Oyuncudan sonra saldırı sırası düşmana geçer. Düşmanın saldırısı sonucu silah tipine göre oyuncunun
can değeri azalır. Eğer can değeri 0 olursa düello oyuncu aleyhine sonuçlanmış olur.
Düellonun sonuçlanabilmesi için ya taraflardan birinin can değeri 0 olmalı, ya da saldırı sırası gelenin
saldırı yapabileceği bir silahının olmaması gerekir. Mermisi bitmiş silah kullanım dışı kalır. Silahı olmayan
ölmüş sayılır ve düello diğeri lehine sonuçlanır.
Oyuncu her saldırı sırasında isterse silahını değiştirebilir. 
