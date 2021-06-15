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

        public PictureInfo()
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

    }
}
