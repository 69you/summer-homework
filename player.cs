using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 暑假作業
{
    public class player
    {
        public string name;
        public int point;
        public double winper;
        public void playerinfo(string name,int per)
        {
            this.name = name;
            this.point = 0;
            this.winper = 0;
        }
    }
}
