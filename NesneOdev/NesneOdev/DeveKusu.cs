using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace NesneOdev
{
    public class DeveKusu : Hayvan
    {
        //Random number
        
        
        public override int HareketEt(int showStatus)
        {
            Random random = new Random();
            rng = random.Next(1, 101);
            if (Paralize == false)
            {
                
                //Devekuşu koşma 50%
                if (rng > 0 && rng <= 50)
                {
                    if(showStatus == 1 && Paralize != true)
                    {
                        Console.WriteLine($"{Isim.ToUpper()} | KOSTU +3 | Konum: {Konum}");
                    }

                    if (base.Konum + 3 >= base.yarismaPisti)
                    {
                        base.Konum = base.yarismaPisti;
                    }
                    else
                    {
                        base.Konum += 3;
                    }

                }
                //Devekuşu Hızlı Koşma 20%
                else if (rng > 50 && rng <= 70)
                {
                    //Console.WriteLine($"{Isim}-HIZLI KOSTU +6 | Konum: {Konum}");
                    if (showStatus == 1 && Paralize != true)
                    {
                        Console.WriteLine($"{Isim.ToUpper()} | HIZLI KOSTU +6 | Konum: {Konum}");
                    }
                    if (base.Konum + 6 >= base.yarismaPisti)
                    {
                        base.Konum = base.yarismaPisti;
                        
                    }
                    else
                    {
                        base.Konum += 6;
                        
                    }
                }
                //Devekuşu Kayma 30%
                else
                {
                    //Console.WriteLine($"{Isim}-KAYDI -4 | Konum: {Konum}");
                    if (showStatus == 1 && Paralize != true)
                    {
                        Console.WriteLine($"{Isim.ToUpper()} | KAYDI -4 | Konum: {Konum}");
                    }
                    // Konum 0dan küçük olamaz...
                    if (base.Konum - 4 >= 0)
                    {
                        base.Konum -= 4;
                        
                    }
                    else
                    {
                        base.Konum = 0;
                        
                    }
                }
            }
            
                
                return base.Konum;
        }

        public bool Paralize { get; set; }

        public DeveKusu(string isim, int yarismaciNo,int yarismaPisti) : base(isim, yarismaciNo,yarismaPisti)
        {
            base.Isim = isim;
            base.YarismaciNo = yarismaciNo;
            base.yarismaPisti = yarismaPisti;
            Paralize = false;
        }
    }
}
