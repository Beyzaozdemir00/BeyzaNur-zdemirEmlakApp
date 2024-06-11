using EvlerLib;

namespace EmlakciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool appcontrol = true;

            do
            {
                Console.WriteLine("Seçiminizi Yapınız : ");
                Console.WriteLine("1-Satılık Ev");
                Console.WriteLine("2-Kiralık Ev");
                string secim = Console.ReadLine();
                SatilikEvler satilik = new SatilikEvler();
                KiralikEvler kiralik = new KiralikEvler();
                bool kontrol = true;

                if (secim == "1")
                {
                    Console.WriteLine("1- Satılık Ev Bilgileri");
                    Console.WriteLine("2- Yeni Satılık Ev Kayıtı");
                    string satiliksecim = Console.ReadLine();


                    if (satiliksecim == "1")
                    {
                        Console.WriteLine(satilik.EvBilgileriGetir());
                    }
                    else if (satiliksecim == "2")
                    {
                        List<string> satilikkayit = new List<string>();
                        do
                        {
                            Console.WriteLine("Yeni Kayıtları Giriniz : ");
                            Console.WriteLine("Semt : ");
                            satilik.Semt = Console.ReadLine();
                            Console.WriteLine("Satış Fiyati : ");
                            satilik.Satisfiyat = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Oda Sayisi : ");
                            satilik.Odasayisi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kat Numarası : ");
                            satilik.Katno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Metrekaresi : ");
                            satilik.Alan = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Kayıta devam etmek istiyor musunuz ? E/H");
                            string sorgu = Console.ReadLine().ToUpper();
                            if (sorgu == "H") { kontrol = false; }

                            satilikkayit.Add(satilik.EvBilgileri());

                        } while (kontrol);

                        satilik.EvKayit(satilikkayit);


                    }
                }
                else if (secim == "2")
                {
                    Console.WriteLine("1-Kiralık Evleri Görüntüle");
                    Console.WriteLine("2-Yeni Kiralık Ev Kayıtı");
                    string kiraliksecim = Console.ReadLine();
                    if (kiraliksecim == "1")
                    {
                        Console.WriteLine(kiralik.EvBilgileriGetir());
                    }
                    else if (kiraliksecim == "2")
                    {
                        List<string> kiralikkayit = new List<string>();
                        do
                        {
                            Console.WriteLine("Yeni Kayıtları Giriniz : ");
                            Console.WriteLine("Semt : ");
                            kiralik.Semt = Console.ReadLine();
                            Console.WriteLine("Kira Fiyati : ");
                            kiralik.Kira = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Depozito Ücreti : ");
                            kiralik.Depozito = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Oda Sayisi : ");
                            kiralik.Odasayisi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kat Numarası : ");
                            kiralik.Katno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Metrekaresi : ");
                            kiralik.Alan = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kayıta devam etmek istiyor musunuz ? E/H");
                            string sorgu = Console.ReadLine().ToUpper();
                            if (sorgu == "H") { kontrol = false; }

                            kiralikkayit.Add(kiralik.EvBilgileri());

                        } while (kontrol);

                        kiralik.EvKayit(kiralikkayit);

                    }
                }

                else
                {
                    Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                }

                Console.WriteLine("Başka İşlem Yapmak İster misiniz ? E/H");
                string tercih = Console.ReadLine().ToUpper();

                if (tercih == "H")
                {
                    appcontrol = false;
                }

            } while (appcontrol);



        }
    }
}