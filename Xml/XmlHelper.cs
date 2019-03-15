using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MGK.Basecore.Xml.Data
{
    public class XmlHelper : IXmlHelper
    {

        public T GetOnlineData<T>(string url)
        {
            WebClient client = new WebClient();
            byte[] kurbilgisi = client.DownloadData(url);
            MemoryStream stream = new MemoryStream(kurbilgisi);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T result = (T)serializer.Deserialize(stream);
            
            return result;
        }

        public T GetXmlData<T>(string path)
        {
            StreamReader reader = new StreamReader(path, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T result = (T)serializer.Deserialize(reader);
            
            return result;
        }
    }
}
