using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
    class Bil
    {
        private string märke;
        private string model;
        private string färg;
        private int årsmodel;
        private int mil;

        public Bil(string mä, string mo,string f, int å, int mi)
        {
        märke = mä;
        model = mo;
        färg = f;
        årsmodel = å;
        mil = mi;
        }
        public void B()
        {
        Console.WriteLine(märke);
        Console.WriteLine(model);
        Console.WriteLine(färg);
        Console.WriteLine(årsmodel);
        Console.WriteLine(mil);
    }
    }
