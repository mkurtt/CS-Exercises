using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGK.Basecore.Xml.Data
{
    public interface IXmlHelper
    {
        T GetOnlineData<T>(string url);

        T GetXmlData<T>(string path);
    }
}
