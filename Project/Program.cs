

using Project;

MusteriManager musterimanager = new MusteriManager();
Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.Name = "Yusuf";
musteri1.Surname = "Soyad1";
musteri1.Email = "ysf@g.com";
Musteri musteri2 = new Musteri();
musteri2.Id = 2;
musteri2.Name = "Ziya";
musteri2.Surname = "Soyad2";
musteri2.Email = "zys@g.com";
Musteri musteri3 = new Musteri();
musteri3.Id = 3;
musteri3.Name = "Kişi";
musteri3.Surname = "Soyad3";
musteri3.Email = "kisi@g.com";
musterimanager.MusteriEkle(musteri1);
musterimanager.MusteriEkle(musteri2);
musterimanager.MusteriEkle(musteri3);
musterimanager.MusteriGetir();
musterimanager.MusteriSil(musteri3);
musterimanager.MusteriGetir();
