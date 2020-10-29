    using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Lab3_Hateoas.Models
{
    [DataContractAttribute]
    public class Hateoas
    {
        [DataMemberAttribute]
        public string Href { get; set; }
        [DataMemberAttribute]
        public string Rel { get; set; }
        [DataMemberAttribute]
        public string Method { get; set; }

        public Hateoas(string href, string rel, string method)
        {
            Href = href;
            Rel = rel;
            Method = method;
        }

    }
}