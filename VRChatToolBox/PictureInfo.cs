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
    [DataContract(Namespace = "")]
    internal class PictureInfo : IExtensibleDataObject
    {
        // 上位下位互換保持用
        public ExtensionDataObject ExtensionData { get; set; }

        internal PictureInfo()
        {
            WorldName     = "";
            WorldAuthor   = "";
            AvatarName    = "";
            AvatarAuthor  = "";
            TweetContents = ProgramSettings.Settings.Tweet;
        }

        [DataMember(Name ="ワールド名",Order = 0)]
        internal string WorldName { get; set; }

        [DataMember(Name = "ワールド作者", Order = 1)]
        internal string WorldAuthor { get; set; }

        [DataMember(Name = "アバター名", Order = 2)]
        internal string AvatarName { get; set; }

        [DataMember(Name = "アバター作者", Order = 3)]
        internal string AvatarAuthor { get; set; }

        [DataMember(Name = "投稿内容", Order = 4)]
        internal string[] TweetContents { get; set; }

        // 情報の書き込み
        internal static void WriteInfo(string filePath, PictureInfo pictureInfo)
        {
            string destFolder = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(destFolder))
                 Directory.CreateDirectory(destFolder);

            DataContractSerializer serializer = new DataContractSerializer(typeof(PictureInfo));
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
            {
                //BOM無しUTF8、整形アリ
                Encoding = new UTF8Encoding(false),
                Indent = true
            };

            using (XmlWriter xmlWriter = XmlWriter.Create(filePath, xmlWriterSettings))
            {
                serializer.WriteObject(xmlWriter, pictureInfo);
            }
        }

        // 情報の読み込み
        internal static PictureInfo LoadInfo(string filePath)
        {
            if (!File.Exists(filePath)) return new PictureInfo();

            DataContractSerializer serializer = new DataContractSerializer(typeof(PictureInfo));
            using (XmlReader xmlReader = XmlReader.Create(filePath))
            {
                return (PictureInfo)serializer.ReadObject(xmlReader);
            }
        }

    }
}
