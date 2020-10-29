using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_Asmx
{
    [Serializable]
    public class A
    {
        public string s;
        public int k;
        public float f;

        public A(string s, int k, float f)
        {
            this.s = s;
            this.k = k;
            this.f = f;
        }

        public A()
        {

        }
    }
}