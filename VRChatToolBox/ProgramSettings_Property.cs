using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace VRChatToolBox
{
    [DataContract(Namespace = "")]
   internal partial class ProgramSettings
    {
        // ただ１つのインスタンス
        private static ProgramSettings _instance;
        internal static ProgramSettings Settings
        {
            get
            {
                if (_instance == null) _instance = new ProgramSettings();
                return _instance;
            }
            set { _instance = value; }
        }

        // exeのフォルダパス：実行時に取得
        private string _exeFolderPath;
        internal string ExeFolderPath
        {
            get { return _exeFolderPath; }
            set { _exeFolderPath = value; }
        }

        // ユーザー名保持用
        private string _userName;
        internal string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        // VRChatのログのパス：ユーザー名の前まで
        internal const string LogPath1 = "C:\\Users\\";

        // VRChatのログのパス：ユーザー名から後
        internal const string LogPath2 = "\\AppData\\LocalLow\\VRChat\\vrchat";

        // VRChatのログのパス：ユーザーが指定する場合(フルパス想定)
        private string _designatedLogPath;
        [DataMember(Name = "VRChatのログフォルダ", Order = 0)]
        internal string DesignatedLogPath
        {
            get { return _designatedLogPath; }
            set { _designatedLogPath = value; }
        }

        // VRChatのログの移動先：exeのフォルダパスにくっつけるつもり
        internal const string MovedLogPath = "VRChatLog";
 
        // VRChatのログの移動先：ユーザーが指定する場合(フルパス想定)
        private string _designatedMovedLogPath;
        [DataMember(Name = "VRChatのログの移動先", Order = 1)]
        internal string DesignatedMovedLogPath
        {
            get { return _designatedMovedLogPath; }
            set { _designatedMovedLogPath = value; }
        }

        // 編集したログの保存先：exeのフォルダパスにくっつけるつもり
        internal const string EditedLogPath = "VRChatLogEdited";

        // 編集したログの保存先：ユーザーが指定する場合(フルパス想定)
        private string _designatedEditedLogPath;
        [DataMember(Name = "編集したログの保存先", Order = 2)]
        internal string DesignatedEditedLogPath
        {
            get { return _designatedEditedLogPath; }
            set { _designatedEditedLogPath = value; }
        }

    }
}
