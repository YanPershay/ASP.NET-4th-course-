using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfSiplex
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class WcfSiplex : IWcfSiplex
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public string Concat(string s, double d)
        {
            return string.Concat(s, d);
        }

        public A Sum(A a1, A a2)
        {
            A result = new A();
            result.S = a1.S + a2.S;
            result.K = a1.K + a2.K;
            result.F = a1.F + a2.F;
            return result;
        }
    }

    [DataContract]
    public class A
    {
        [DataMember]
        public string S { get; set; }

        [DataMember]
        public int K { get; set; }

        [DataMember]
        public float F { get; set; }
    }
}
