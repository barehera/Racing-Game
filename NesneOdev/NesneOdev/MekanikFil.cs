using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev
{
    public class MekanikFil : Robot
    {
        //Random number
        
        public override int HareketEt(int showStatus)
        {
            Random random = new Random();
            rng = random.Next(1, 101);

            //Mekanik fil yürüme 40%
            if (rng > 0 && rng <= 40)
            {
                // Console.WriteLine($"{Isim}-YURUDU +2 | Konum: {Konum}");
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
            //Mekanik fil koşma 10%
            else if(rng > 40 && rng <= 50)
            {
                // Console.WriteLine($"{Isim}-KOSTU +3 | Konum: {Konum}");
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
            //Mekanik fil Bekleme 50%
            else
            {
                //Console.WriteLine($"{Isim}-BEKLEDI +0 | Konum: {Konum}");
                if (showStatus == 1)
                {
                    Console.WriteLine($"{Isim.ToUpper()} | BEKLEDI +0 | Konum: {Konum}");
                }
                base.Konum += 0;
            }
            return base.Konum;
        }

        public MekanikFil(string isim,int yarismaciNo,int yarismaPisti) : base(isim,yarismaciNo,yarismaPisti)
        {
            base.Isim = isim;
            base.YarismaciNo = yarismaciNo;
            base.yarismaPisti = yarismaPisti;
            
        }

       

    }
}
