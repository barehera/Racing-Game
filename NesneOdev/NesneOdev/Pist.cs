using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev
{
    public class Pist
    {
        //Random 
        Random random = new Random();

        private int pist;

        public int PistUzunlugu { get; set; }

        public void DurumunuYazdir(IYarismaci yarismaci)
        {
            if(yarismaci.GetType() == typeof(DeveKusu))
            {
                DeveKusu devekusu = (DeveKusu)yarismaci;
                if(devekusu.Paralize == true)
                {
                    Console.WriteLine($"{yarismaci.Isim.ToUpper()} - Paralize oldu!\n");
                }
                else
                {
                    Console.WriteLine($"Güncel Konum: {yarismaci.Konum}\n");
                }
            }
            else
            {
                Console.WriteLine($"Güncel Konum: {yarismaci.Konum}\n");
            }
            
            
        }


        
        public void KonumdakiYarismacilar(List<IYarismaci> yarismaciList,int showStatus)
        {
            foreach (IYarismaci yarismaci in yarismaciList)
            {
                
                foreach (IYarismaci yarismaci2 in yarismaciList)
                {
                    //Konumların aynı yere denk geldiğini kontrol edilmesi (6 birim ilerlenmeden özel durumların oluşmasını engelledim)
                    if(yarismaci2.Konum == yarismaci.Konum && yarismaci.Konum > 3 && yarismaci2.Konum > 3 && yarismaci.Isim != yarismaci2.Isim)
                    {
                        //Çakal ile deve kuşu denk gelirse oluşacak durumun kodu
                        if(yarismaci.GetType() == typeof(DeveKusu) && yarismaci2.GetType() == typeof(Cakal))
                        {
                            
                            int olasilik = random.Next(1, 101);
                            
                            if (olasilik > 0 && olasilik <= 50)
                            {
                                DeveKusu devekusu = (DeveKusu)yarismaci;
                                if(devekusu.Paralize == false)
                                {
                                    if(showStatus == 1)
                                    {
                                        Console.WriteLine($"\n{yarismaci2.Isim.ToUpper()}, {yarismaci.Isim.ToUpper()} adli yarismacinin kanatlarini kopardi...\n");
                                    }
                                    devekusu.Paralize = true;
                                }
                                
                            }
                            else
                            {
                                if (showStatus == 1)
                                {
                                    Console.WriteLine($"\n{yarismaci.Isim.ToUpper()} Ve {yarismaci2.Isim.ToUpper()} aynı konuma denk geldi fakat {yarismaci.Isim.ToUpper()} ucuz kurtuldu!\n");
                                }

                            }

                        }
                        //Mekanik fil ve devekuşu kodu
                        else if(yarismaci.GetType() == typeof(DeveKusu) && yarismaci2.GetType() == typeof(MekanikFil))
                        {
                            int olasilik = random.Next(1, 101);
                            
                            if (olasilik > 0 && olasilik <= 20)
                            {
                                
                                DeveKusu devekusu = (DeveKusu)yarismaci;
                                if (devekusu.Paralize == false)
                                {
                                    if (showStatus == 1)
                                    {
                                        Console.WriteLine($"\n{yarismaci2.Isim.ToUpper()}, {yarismaci.Isim.ToUpper()} adli yarismaciyi ezdi...\n");
                                    }
                                    devekusu.Paralize = true;
                                }
                                
                            }
                            else
                            {
                                if (showStatus == 1)
                                {
                                    Console.WriteLine($"\n{yarismaci.Isim.ToUpper()} Ve {yarismaci2.Isim.ToUpper()} aynı konuma denk geldi fakat {yarismaci.Isim.ToUpper()} ucuz kurtuldu!\n");
                                }
                            }
                        }
                        //Salyanbot ve çakal kodu
                        else if (yarismaci.GetType() == typeof(Cakal) && yarismaci2.GetType() == typeof(SalyanBot) )
                        {
                            int olasilik = random.Next(1, 101);
                            
                            if (olasilik > 0 && olasilik <= 25)
                            {
                                if (showStatus == 1)
                                {
                                    Console.WriteLine($"\n{yarismaci2.Isim.ToUpper()}, {yarismaci.Isim.ToUpper()} adli yarismaciyiya çarptı...");
                                }
                                int tempKonum = yarismaci.Konum;
                                yarismaci.Konum = tempKonum - 1;
                                if (showStatus == 1)
                                {
                                    Console.WriteLine($"{yarismaci.Isim.ToUpper()} | Güncel Konum: {yarismaci.Konum}\n");
                                }

                            }
                            else
                            {
                                if (showStatus == 1)
                                {
                                    Console.WriteLine($"\n{yarismaci.Isim.ToUpper()} Ve {yarismaci2.Isim.ToUpper()} aynı konuma denk geldi fakat {yarismaci.Isim.ToUpper()} ucuz kurtuldu!\n");
                                }
                            }

                        }
                        //Salyanbot ve devekuşu  kodu
                        else if (yarismaci.GetType() == typeof(DeveKusu) && yarismaci2.GetType() == typeof(SalyanBot))
                        {
                            int olasilik = random.Next(1, 101);
                            DeveKusu devekusu = (DeveKusu)yarismaci;
                            if (olasilik > 0 && olasilik <= 25)
                            {
                                if (devekusu.Paralize == false)
                                {
                                    if (showStatus == 1)
                                    {
                                        Console.WriteLine($"\n{yarismaci2.Isim.ToUpper()}, {yarismaci.Isim.ToUpper()} adli yarismaciyiya çarptı...");
                                    }
                                    int tempKonum = yarismaci.Konum;
                                    yarismaci.Konum = tempKonum-1;
                                    if (showStatus == 1)
                                    {
                                        Console.WriteLine($"{yarismaci.Isim.ToUpper()} | Güncel Konum: {yarismaci.Konum}\n");
                                    }
                                }
                            }
                            else
                            { 
                                if (devekusu.Paralize == false)
                                {
                                    if (showStatus == 1)
                                    {
                                        Console.WriteLine($"\n{yarismaci.Isim.ToUpper()} Ve {yarismaci2.Isim.ToUpper()} aynı konuma denk geldi fakat {yarismaci.Isim.ToUpper()} ucuz kurtuldu!\n");
                                    }
                                }
                            }
                        }
                    }
                }
            }  
        }    

        public void KonumGuncelle(IYarismaci yarismaci,int showStatus)
        {
            //Randomun doğru çalışabilmesi için gecikme koydum
            System.Threading.Thread.Sleep(1);
            yarismaci.HareketEt(showStatus);
            
        }

        public List<IYarismaci> YarismaciEkle(string yarismacilar,int lineCount, int yarismaPisti)
        {
            List<IYarismaci> yarismacilarObjectList = new List<IYarismaci>();
            //Yarismacilari ekleme
            while (lineCount > 0)
            {
                //txt dosyasındaki her bir line
                string line = yarismacilar.Split(new char[] { '\n' })[lineCount - 1];
                
                // satırdaki tür CAKAL vb.
                string tur = line.Split(new char[] { ' ' })[2];

                // satırdaki isim salyonbot_bot vb.
                string isim = line.Split(new char[] { ' ' })[1];

                // satırdaki yarismaci numarası 1,2 vb.
                string yarismaciNoString = line.Split(new char[] { ' ' })[0];

                //Yarismaci numarasını stringten integera çevirme
                int yarismaciNo = Int32.Parse(yarismaciNoString);
                
                //Türüne göre yarismaci ekleme
                if (tur == "CAKAL" || tur == "CAKAL\r")
                {
                    yarismacilarObjectList.Add(new Cakal(isim, yarismaciNo,yarismaPisti));
                    
                }
                else if (tur == "DEVEKUSU" || tur == "DEVEKUSU\r")
                {
                    yarismacilarObjectList.Add(new DeveKusu(isim, yarismaciNo, yarismaPisti));
                    
                }
                else if (tur == "SALYANBOT" || tur == "SALYANBOT\r")
                {
                    yarismacilarObjectList.Add(new SalyanBot(isim, yarismaciNo, yarismaPisti));
                    
                }
                else if (tur == "MEKANIKFIL" || tur == "MEKANIKFIL\r")
                {
                    yarismacilarObjectList.Add(new MekanikFil(isim, yarismaciNo, yarismaPisti));
                    
                }
                
                lineCount -= 1;
            }
            return yarismacilarObjectList;
            
        }

        public Pist(int pist, int pistUzunlugu)
        {
            this.pist = pist;
            PistUzunlugu = pistUzunlugu;
        }
    }
}
