using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;


namespace Stub.Model
{
    public class Helper: XmlElement
    {
        public Helper(string prefix, string localName, string namespaceURI, XmlDocument doc)
            : base(prefix, localName, namespaceURI, doc)
        {
        }
    }


    public class Resolver : XmlResolver
    {
        public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
        {
            throw new NotImplementedException();
        }
    }
}