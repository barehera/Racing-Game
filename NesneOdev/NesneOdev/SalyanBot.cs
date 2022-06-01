using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev
{
    public class SalyanBot : Robot
    {
        public override int HareketEt(int showStatus)
        {
            // Console.WriteLine($"{Isim}-SURUNDU +1 | Konum: {Konum}");
            if (showStatus == 1)
            {
                Console.WriteLine($"{Isim.ToUpper()} | SURUNDU +1 | Konum: {Konum}");
            }
            // 100% Sürünme
            base.Konum += 1;
            
            return base.Konum;
        }
        public SalyanBot(string isim, int yarismaciNo, int yarismaPisti) : base(isim, yarismaciNo,yarismaPisti)
        {
            base.Isim = isim;
            base.YarismaciNo = yarismaciNo;
            base.yarismaPisti = yarismaPisti;
            
        }
    }
}
