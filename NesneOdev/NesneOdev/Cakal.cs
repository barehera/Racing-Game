using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev
{
    public class Cakal : Hayvan
    {
        //Random number
        
        public override int HareketEt(int showStatus)
        {
            Random random = new Random();
            rng = random.Next(1, 101);
            //Çakal koşma 30%
            if (rng > 0 && rng <= 30)
            {
                //Console.WriteLine($"{Isim}-KOSTU +3 | Konum: {Konum}");
                if (showStatus == 1)
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
            //Çakal Yürüme 50%
            else if (rng > 30 && rng <= 80)
            {
                //Console.WriteLine($"{Isim}-YURUDU +2 | Konum: {Konum}");
                if (showStatus == 1)
                {
                    Console.WriteLine($"{Isim.ToUpper()} | YURUDU +2 | Konum: {Konum}");
                }
                if (base.Konum + 2 >= base.yarismaPisti)
                {
                    base.Konum = base.yarismaPisti;
                }
                else
                {
                    base.Konum += 2;
                   
                }

            }
            //Çakal Kayma 20%
            else
            {
                //Console.WriteLine($"{Isim}-KAYDI -4 | Konum: {Konum}");
                if (showStatus == 1)
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
            return base.Konum;
        }
        public Cakal(string isim, int yarismaciNo,int yarismaPisti) : base(isim, yarismaciNo,yarismaPisti)
        {
            base.Isim = isim;
            base.YarismaciNo = yarismaciNo;
            base.yarismaPisti = yarismaPisti;
           
        }

    }
}
