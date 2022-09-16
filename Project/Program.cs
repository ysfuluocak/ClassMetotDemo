

using Project;

MusteriManager musterimanager = new MusteriManager();
Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.Name = "Yusuf";
musteri1.Surname = "ULUOCAK";
musteri1.Email = "yszf@g.com";
Musteri musteri2 = new Musteri();
musteri2.Id = 2;
musteri2.Name = "Ziya";
musteri2.Surname = "kam";
musteri2.Email = "fsgf@g.com";
Musteri musteri3 = new Musteri();
musteri3.Id = 3;
musteri3.Name = "fasıl";
musteri3.Surname = "Ucak";
musteri3.Email = "mj45@g.com";
musterimanager.MusteriEkle(musteri1);
musterimanager.MusteriEkle(musteri2);
musterimanager.MusteriEkle(musteri3);
musterimanager.MusteriGetir();
musterimanager.MusteriSil(musteri3);
musterimanager.MusteriGetir();
