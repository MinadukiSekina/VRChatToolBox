﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.Reflection;
using System.IO;

namespace VRChatToolBox
{
    internal partial class ProgramSettings
    {
        internal ProgramSettings()
        {
            ExeFolderPath = "";
            UserName = "";
            DesignatedLogPath = "";
            DesignatedEditedLogPath = "";
            DesignatedMovedLogPath = "";

        }

        // 設定の初期処理
        internal static void InitializeSettings()
        {
            string exeFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string settingsFilePath = $"{exeFolderPath}\\MySettings.settings";

            // 設定ファイルがあれば読み込み
            if (File.Exists(settingsFilePath)) LoadSettings(settingsFilePath);

            // exeのフォルダパスとユーザー名格納
            Settings.ExeFolderPath = exeFolderPath;
            Settings.UserName = Environment.UserName;

        }

        // 設定の書き込み
        internal static void WriteSettings(string filePath)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(ProgramSettings));
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
            {
                //BOM無しUTF8、整形アリ
                Encoding = new UTF8Encoding(false),
                Indent = true
            };

            using (XmlWriter xmlWriter = XmlWriter.Create(filePath, xmlWriterSettings))
            {
                serializer.WriteObject(xmlWriter, Settings);
            }
        }

        // 設定のロード
        internal static void LoadSettings(string filePath)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(ProgramSettings));
            using (XmlReader xmlReader = XmlReader.Create(filePath))
            {
                Settings = (ProgramSettings)serializer.ReadObject(xmlReader);
            }
        }

        // VRChatのログのパスを返す
        internal static string GetVRChatLogPath()
        {
            if (string.IsNullOrWhiteSpace(Settings.DesignatedLogPath))
            {
                return $"{LogPath1}{Settings.UserName}{LogPath2}";
            }
            else
            {
                return Settings.DesignatedLogPath;
            }
        }

        // VRChatのログの移動先のパスを返す
        internal static string GetVRChatLogMovedPath()
        {
            if (string.IsNullOrWhiteSpace(Settings.DesignatedMovedLogPath))
            {
                return $"{Settings.ExeFolderPath}\\{MovedLogPath}";
            }
            else
            {
                return Settings.DesignatedMovedLogPath;
            }
        }

        // 編集後ログの保存先のパスを返す
        internal static string GetEditedLogPath()
        {
            if (string.IsNullOrWhiteSpace(Settings.DesignatedEditedLogPath))
            {
                return $"{Settings.ExeFolderPath}\\{EditedLogPath}";
            }
            else
            {
                return Settings.DesignatedEditedLogPath;
            }
        }

    }
}