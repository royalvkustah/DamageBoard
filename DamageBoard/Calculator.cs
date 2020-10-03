using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageBoard
{
    class Calculator
    {
        public double str;
        public double wStr;
        public double dMod;
        public double damage1;
        public double damage2;

        public Calculator(double str, double wStr, double dMod)
        {
            this.str = str;
            this.wStr = wStr;
            this.dMod = dMod;
        }

        public string Cacl()
        {
            damage1 = (str * 0.82 + wStr) * dMod;
            damage2 = damage1 + wStr;
            string res = Math.Round(damage1, 2) + "--" + Math.Round(damage2, 2) + " hpt";
            return res;
        }
    }
}
