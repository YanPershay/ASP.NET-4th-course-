using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace Lab4_Asmx
{
    /// <summary>
    /// Сводное описание для Simplex
    /// </summary>
    [WebService(Namespace = "http://pyb/", Description = "Service for Sum and Concat methods")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    [System.Web.Script.Services.ScriptService]
    public class Simplex : System.Web.Services.WebService
    {

        [WebMethod(Description = "Return sum of x & y", MessageName = "Add")]
        public int Add(int x, int y)
        {
            return x + y;
        }

        [WebMethod(Description = "Return Concat of String and Float", MessageName = "Concat")]
        public string Concat(string s, double d)
        {
            return String.Concat(s, d);
        }

        [WebMethod(Description = "Return Concat of two Objects of class A", MessageName = "Sum")]
        public A Sum(A a1, A a2)
        {
            Stream str = this.Context.Request.InputStream;
            str.Position = 0;
            StreamReader sr = new StreamReader(this.Context.Request.InputStream);
            string s = sr.ReadToEnd();
            return new A(String.Concat(a1.s, a2.s), a1.k + a2.k, a1.f + a2.f);
        }

        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        [WebMethod(MessageName = "Adds", Description = "Return sum of x & y. Response JSON")]
        public int Adds(int x, int y)
        {
            return x + y;
        }
    }
}
