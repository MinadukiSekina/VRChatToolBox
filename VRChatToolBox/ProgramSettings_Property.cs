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
   internal partial class ProgramSettings : IExtensibleDataObject
    {
        // 上位下位互換保持用
        public ExtensionDataObject ExtensionData { get; set; }

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
        // 写真取得でも使う
        internal const string LogPath1 = "C:\\Users\\";

        // VRChatのログのパス：ユーザー名から後
        internal const string LogPath2 = "\\AppData\\LocalLow\\VRChat\\vrchat";

        // VRChatのログのパス：ユーザーが指定する場合(フルパス想定)
        private string _designatedLogPath;
        [DataMember(Name = "VRChatのログフォルダ", Order = 0)]
        internal string DesignatedLogPath
        {
            get => string.IsNullOrWhiteSpace(_designatedLogPath) ? $"{LogPath1}{_userName}{LogPath2}" : _designatedLogPath;
            set => _designatedLogPath = value;
        }

        // VRChatのログの移動先：exeのフォルダパスにくっつけるつもり
        internal const string MovedLogPath = "VRChatLog";
 
        // VRChatのログの移動先：ユーザーが指定する場合(フルパス想定)
        private string _designatedMovedLogPath;
        [DataMember(Name = "VRChatのログの移動先", Order = 1)]
        internal string DesignatedMovedLogPath
        {
            get => string.IsNullOrWhiteSpace(_designatedMovedLogPath) ? $"{_exeFolderPath}\\{MovedLogPath}" : _designatedMovedLogPath;
            set => _designatedMovedLogPath = value;
        }

        // 編集したログの保存先：exeのフォルダパスにくっつけるつもり
        internal const string EditedLogPath = "VRChatLogEdited";

        // 編集したログの保存先：ユーザーが指定する場合(フルパス想定)
        private string _designatedEditedLogPath;
        [DataMember(Name = "編集したログの保存先", Order = 2)]
        internal string DesignatedEditedLogPath
        {
            get => string.IsNullOrWhiteSpace(_designatedEditedLogPath) ? $"{_exeFolderPath}\\{EditedLogPath}" : _designatedEditedLogPath;
            set => _designatedEditedLogPath = value;
        }

        // VRChatの写真のデフォルトフォルダ
        internal const string PicturesSavedFolder = "\\Pictures\\VRChat";

        // VRChatの写真のフォルダ：ユーザーが指定する場合
        private string _designatedPicturesSavedFolder;
        [DataMember(Name = "写真の保存フォルダ", Order = 3)]
        internal string DesignatedPicturesSavedFolder
        {
            get => string.IsNullOrWhiteSpace(_designatedPicturesSavedFolder) ? $"{LogPath1}{_userName}{PicturesSavedFolder}" : _designatedPicturesSavedFolder;
            set => _designatedPicturesSavedFolder = value;
        }

        // 整理後の写真の保存先：ユーザーが指定する場合
        private string _designatedPicturesMovedFolder;
        [DataMember(Name = "写真の整理先フォルダ", Order = 4)]
        internal string DesignatedPicturesMovedFolder
        {
            get => string.IsNullOrWhiteSpace(_designatedPicturesMovedFolder) ? $"{LogPath1}{_userName}{PicturesSavedFolder}" : _designatedPicturesMovedFolder;
            set => _designatedPicturesMovedFolder = value;
        }

    }
}
