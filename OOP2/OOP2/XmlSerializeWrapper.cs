using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;

public class XmlSerializeWrapper<T>
{
    public List<T> list;

    public XmlSerializeWrapper()
    {
        list = new List<T>();
        using (FileStream fs = new FileStream("product.xml", FileMode.OpenOrCreate))
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
            list = (List<T>)formatter.Deserialize(fs);
        }

    }
    public void Serialize(T obj, string filename)
    {
        list.Add(obj);
        using (FileStream fs = new FileStream(filename, FileMode.Create))
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
            formatter.Serialize(fs, list);
        }
    }
    public T Deserialize(string filename)
    {
        using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
            list = (List<T>)formatter.Deserialize(fs);
        }
        return list.Last<T>();
    }
}
