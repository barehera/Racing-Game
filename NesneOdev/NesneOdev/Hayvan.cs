﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev
{
    public abstract class Hayvan : IYarismaci
    {
        
        private string isim;
        protected int rng;
        private int yarismaciNo;
        protected int yarismaPisti;

        public string Isim { get { return isim; } set { isim = value; } }
        public int Konum { get; set; }
        public int YarismaciNo { get { return yarismaciNo; } set { yarismaciNo = value; } }

       
        public virtual int HareketEt(int showStatus)
        {
            throw new NotImplementedException();
        }

        protected Hayvan(string isim, int yarismaciNo,int yarismaPisti)
        {
            Isim = isim;
            YarismaciNo = yarismaciNo;
            Konum = 0;
            this.yarismaPisti = yarismaPisti;
        }
    }
}
