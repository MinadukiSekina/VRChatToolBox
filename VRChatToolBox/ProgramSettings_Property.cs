using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data;

namespace VRChatToolBox
{
    enum ListSelectedItemType
    {
        Folder,
        Picture
    }

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


        // 選択した写真の保存先
        internal const string PictureSelectedFolder = "SelectedPicture";

        // 選択した写真の保存先：ユーザーが指定する場合
        private string _designatedPicturesSelectedFolder;
        [DataMember(Name = "投稿用写真のフォルダ", Order = 5)]
        internal string DesignatedPicturesSelectedFolder
        {
            get => string.IsNullOrWhiteSpace(_designatedPicturesSelectedFolder) ?
                        $"{LogPath1}{_userName}{PicturesSavedFolder}\\{PictureSelectedFolder}" : _designatedPicturesSelectedFolder;
            set => _designatedPicturesSelectedFolder = value;
        }

        // 投稿済の保存フォルダ
        internal const string PictureUpLoadedFolder = "UpLoadedPicture";

        // 投稿後の写真の保存先：ユーザーが指定する場合
        private string _designatedPicturesUpLoadedFolder;
        [DataMember(Name = "写真の投稿後フォルダ", Order = 6)]
        internal string DesignatedPicturesUpLoadedFolder
        {
            get => string.IsNullOrWhiteSpace(_designatedPicturesUpLoadedFolder) ?
                        $"{LogPath1}{_userName}{PicturesSavedFolder}\\{PictureUpLoadedFolder}" : _designatedPicturesUpLoadedFolder;
            set => _designatedPicturesUpLoadedFolder = value;
        }


        // 写真のメタデータの保存先：exeのフォルダパスにくっつけるつもり
        internal const string PictureInfoPath = "PictureInfo";

        // 写真のメタデータの保存先：ユーザーが指定する場合(フルパス想定)
        private string _designatedPictureInfoPath;
        [DataMember(Name = "写真のメタデータの保存先", Order = 7)]
        internal string DesignatedPictureInfoPath
        {
            get => string.IsNullOrWhiteSpace(_designatedPictureInfoPath) ? $"{_exeFolderPath}\\{PictureInfoPath}" : _designatedPictureInfoPath;
            set => _designatedPictureInfoPath = value;
        }

        // 投稿後のメタデータの保存先：exeのフォルダパスにくっつけるつもり
        internal const string UpLoadedInfoPath = "UpLoadedInfo";

        // 投稿後のメタデータの保存先：ユーザーが指定する場合(フルパス想定)
        private string _designatedUpLoadedInfoPath;
        [DataMember(Name = "投稿後のメタデータの保存先", Order = 8)]
        internal string DesignatedUpLoadedInfoPath
        {
            get => string.IsNullOrWhiteSpace(_designatedUpLoadedInfoPath) ? $"{_exeFolderPath}\\{UpLoadedInfoPath}" : _designatedUpLoadedInfoPath;
            set => _designatedUpLoadedInfoPath = value;
        }

        // アバターのデータ
        private DataTable _avatarData;
        [DataMember(Name = "アバターのリスト", Order = 9)]
        internal DataTable AvataData
        {
            get
            {
                if (_avatarData is null) _avatarData = InitAvatarData();
                return _avatarData;
            }
            set => _avatarData = value;
        }

        // 投稿内容のデフォルト
        private string[] _Tweet;
        [DataMember(Name = "投稿内容", Order = 10)]
        internal string[] Tweet
        {
            get => _Tweet is null ? new string[] { } : _Tweet;
            set => _Tweet = value;
        }

    }
}
