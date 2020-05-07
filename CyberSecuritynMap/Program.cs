using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CyberSecuritynMap
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xDocument = XDocument.Load("result.xml");
            XName X = XName.Get("host", xDocument.Root.Name.NamespaceName);
            foreach (XElement data in xDocument.Descendants(X))
            {
                Console.WriteLine(data.ToString());
                xDocument.Save("Kayıtlı.xml");
            }
            Console.ReadKey();
        }
    }
}

