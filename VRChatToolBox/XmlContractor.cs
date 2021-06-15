using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;

namespace VRChatToolBox
{
    internal static class XmlContractor
    {
        // XMLからのインスタンス生成
        internal static T LoadObjectXML<T>(string xmlPath) where T : new()
        {
            if (!File.Exists(xmlPath)) return new T();

            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            using (XmlReader xmlReader = XmlReader.Create(xmlPath))
            {
                return (T)serializer.ReadObject(xmlReader);
            }
        }

        // XMLへのシリアライズ
        internal static void WriteObjectXML<T>(string xmlPath, T instance)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
            {
                //BOM無しUTF8、整形アリ
                Encoding = new UTF8Encoding(false),
                Indent = true
            };

            string destFolder = Path.GetDirectoryName(xmlPath);
            if (!Directory.Exists(destFolder)) Directory.CreateDirectory(destFolder);

            using (XmlWriter xmlWriter = XmlWriter.Create(xmlPath, xmlWriterSettings))
            {
                serializer.WriteObject(xmlWriter, instance);
            }
        }

    }
}
