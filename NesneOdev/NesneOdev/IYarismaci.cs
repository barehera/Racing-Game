using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev
{
    public interface IYarismaci
    {
        string Isim { get; set; }
        int Konum { get; set; }

        int YarismaciNo { get; set; }

        int HareketEt(int showStatus);
    }
}
