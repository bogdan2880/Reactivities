using System.Xml.Linq;
using API.Models;

namespace API
{
    public class GetQuoteService : IGetQuote
    {
        public string Test(string s)
        {
            Console.WriteLine("Test Method Executed!");
            return s;
        }
        public void XmlMethod(XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }
        public MyCustomModel TestCustomModel(MyCustomModel customModel)
        {
            return customModel;
        }
    }
}