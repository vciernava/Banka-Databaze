﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Vlastnik
    {
        public string jmeno_V { get; private set; }
        public string prijmeni_V { get; private set; }
        public int vek_V { get; private set; }
        public string rodne_C { get; private set; }
        

        public Vlastnik(string jmeno_v, string prijmeni_v, int vek_v, string rodne_c)
        {
            jmeno_V = jmeno_v;
            prijmeni_V = prijmeni_v;
            vek_V = vek_v;
            rodne_C = rodne_c;
        }
    }
}
