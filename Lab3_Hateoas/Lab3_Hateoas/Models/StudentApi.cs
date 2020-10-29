using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace Lab3_Hateoas.Models
{
    public class StudentApi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        [XmlIgnore]
        public Hateoas HateOas { get; set; }

        public StudentApi()
        {

        }

        public StudentApi(Student student, Hateoas hateoas)
        {
            Id = student.Id;
            Name = student.Name;
            Phone = student.Phone;
            HateOas = hateoas;
        }
    }
}