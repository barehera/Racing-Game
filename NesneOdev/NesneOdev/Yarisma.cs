using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev
{
    public class Yarisma
    {
        private string yarismacilar;
        private int yarismaPisti;
        private List<IYarismaci> yarismaciList;
        

        public void Baslat()
        {
            Pist testPisti = new Pist(1, yarismaPisti);
            // Girilen yarismacilarin line sayısını buluyor...
            int lineCount = 1;
            for (int i = 0; i < yarismacilar.Length; i++)
            {

                if (yarismacilar[i] == '\n')
                {
                    lineCount += 1;
                }
            }
            //Yarismacilar oluşturulup listte depolandı.
            yarismaciList = testPisti.YarismaciEkle(yarismacilar, lineCount , yarismaPisti);
            
            // Önemli değişkenler en öndeki oyuncu için max konum değişkeni
            int maxKonum = 0;
            int roundCount = 1;
            int showStatus;
            // Oyun kısmı başlıyor...
            Console.WriteLine("Oyun başladı...\n");
            Console.WriteLine("Yarismacilarin durumunu görüntülemek için 1'i görüntülemeden devam etmek için 0'ı seçiniz");
            showStatus = Convert.ToInt32(Console.ReadLine());
            if (showStatus == 0)
            {
                Console.WriteLine("Roundlar oynanıyor...\n");
            }
            while (maxKonum <= yarismaPisti-1)
            {
                // Bütün oyuncuları oynatmak için gerekli olan indexi ayarlıyoruz
                int tempCount = lineCount - 1;
                // Oyuncular gerekli hamleleri yapıyor 

                if (showStatus == 1)
                {
                    Console.WriteLine($"\nRound - {roundCount}\n-------------------------");
                }
                while (tempCount >= 0)
                {
                    testPisti.KonumGuncelle(yarismaciList[tempCount],showStatus);
                    if(showStatus == 1)
                    {
                        testPisti.DurumunuYazdir(yarismaciList[tempCount]);
                    }

                    tempCount -= 1;
                }


                tempCount = lineCount - 1;
                // Yarismacilardan en öndekini hesaplamak için kullanılan algoritma
                foreach (IYarismaci yarismaci in yarismaciList)
                {
                    if (yarismaci.Konum > maxKonum)
                    {
                        maxKonum = yarismaci.Konum;
                    }
                }
                //her round aynı konumda biri var mı karşılaştırıp gerekli eylemi uygulama
                testPisti.KonumdakiYarismacilar(yarismaciList,showStatus);
                roundCount++;
            }
        }
        public void KonumlariYazdir()
        {
            Console.WriteLine("\nMAÇ SONU SKORLARI\n");
            Console.WriteLine("---------------------\n");
            //Yarismacilarin konumlarını sıralayan kod
            var yarismacilarSorted = from yarismaci in yarismaciList
                        orderby yarismaci.Konum
                        select yarismaci;
            //her bir yarışmacının oyun sonu bilgilerini yazdırmak için gerekli olan foreach bloğu
            foreach (var yarismaci in yarismacilarSorted)
            {
                //Oyun sonu bilgilendirmesi
                Console.Write($"{yarismaci.Konum} || {yarismaci.YarismaciNo}, {yarismaci.Isim.ToUpper()}\n");
            }
            //Kazananlari yazdirma
            Console.WriteLine("\nKazananlar\n--------------------------");
            foreach (var yarismaci in yarismacilarSorted)
            {
                if(yarismaci.Konum == yarismaPisti)
                {
                    Console.Write($"{yarismaci.Konum} || {yarismaci.Isim.ToUpper()}({yarismaci.YarismaciNo})\n");
                } 
            }

        }

        public Yarisma(string yarismacilar, int yarismaPisti)
        {
            this.yarismacilar = File.ReadAllText(yarismacilar);
            this.yarismaPisti = yarismaPisti;
        }
    }
}
