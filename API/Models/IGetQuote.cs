using System.ServiceModel;

namespace API.Models
{
    public interface IGetQuote
    {
         [OperationContract]
        string Test(string s);
        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);
        [OperationContract]
        MyCustomModel TestCustomModel(MyCustomModel inputModel);
    }
}