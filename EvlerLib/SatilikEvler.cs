using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EvlerLib
{
    public class SatilikEvler : Evler
    {
        private double satisfiyat;
        string dosyayolu = "C:\\EmlakciUygulamasi\\EmlakciUygulaması\\SatilikEvler.txt";
        public double Satisfiyat { get => satisfiyat; set => satisfiyat = value; }

        public override string EvBilgileriGetir()
        {
            StreamReader sr = File.OpenText(dosyayolu);
            return sr.ReadToEnd();
        }

        public void EvKayit(List<string> list)
        {

            using (StreamWriter sw = new StreamWriter(dosyayolu))
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                    sw.WriteLine("----------------------------------");
                }
            }

        }

        public virtual string EvBilgileri()
        {
            return $"{base.EvBilgileri()} \nFiyat : {satisfiyat}";
        }



    }
}
