using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.Reflection;
using System.IO;
using System.Data;

namespace VRChatToolBox
{
    internal partial class ProgramSettings
    {
        public ProgramSettings()
        {
            ExeFolderPath = "";
            UserName = "";
            DesignatedLogPath = "";
            DesignatedEditedLogPath = "";
            DesignatedMovedLogPath = "";
            DesignatedPicturesSavedFolder = "";
        }

        // 設定の初期処理
        internal static void InitializeSettings()
        {
            string exeFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string settingsFilePath = $"{exeFolderPath}\\{SettingsFileName}";

            // 設定ファイルがあれば読み込み
           Settings = XmlContractor.LoadObjectXML<ProgramSettings>(settingsFilePath);

            // exeのフォルダパスとユーザー名格納
            Settings.ExeFolderPath = exeFolderPath;
            Settings.UserName = Environment.UserName;

        }

        // AvatarDataの初期化
        internal static DataTable InitAvatarData()
        {
            DataTable dataTable = new DataTable("AvatarData");
            dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("AvatarName"), new DataColumn("AvatarAuthor") });
            return dataTable;
        }

    }
}
