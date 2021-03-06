using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VRChatToolBox
{
    public partial class PictureSelector : Form
    {
        // メタデータファイルの名称を保持
        private string MetaDataFileName { get; set; }
        // 呼び出しモード
        internal PictureSelectMode ActivateMode { get; set; }
        // ワールドのデータ保持
        private Dictionary<string, string> _worldData;
        internal Dictionary<string, string> WorldData
        {
            get => _worldData ?? new Dictionary<string, string> { };
            set => _worldData = value;
        }

        // デフォルト
        public PictureSelector()
        {
            InitializeComponent();
        }
        // 起動モード指定
        public PictureSelector(PictureSelectMode activateMode) : this()
        {
            ActivateMode = activateMode;
        }

        // フォーム起動時
        private void PictureSelector_Load(object sender, EventArgs e)
        {
            try
            {
                // 表示するフォルダの設定
                string selectFolderPath = (ActivateMode == PictureSelectMode.Select)
                                           ? ProgramSettings.Settings.DesignatedPicturesMovedFolder
                                           : ProgramSettings.Settings.DesignatedPicturesSelectedFolder;

                Text = $"{(ActivateMode == PictureSelectMode.Select? "写真選択": "写真投稿")}";

                // 無いとエラーになるので
                if (!Directory.Exists(selectFolderPath)) Directory.CreateDirectory(selectFolderPath);

                // 初期化
                DT_DirectoryList.InitList();
                TB_FolderPath.Text = selectFolderPath;
                FV_FileList.SetListItems(selectFolderPath);
                SetAvatarList();
                WorldData = XmlContractor.LoadObjectXML<Dictionary<string, string>>($"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.WorldDataFile}");
                FV_FileList.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "起動エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        // アバターリストのセット
        internal void SetAvatarList()
        {
            LI_AvatarList.DisplayMember = "AvatarName";
            LI_AvatarList.ValueMember   = "AvatarAuthor";
            LI_AvatarList.DataSource    = ProgramSettings.Settings.AvataData;
        }

        // ドラッグアンドドロップ用
        private void PB_Display_MouseDown(object sender, MouseEventArgs e)
        {
            if (!File.Exists(PB_Display.ImageLocation)) return;

            // これでドラッグアンドドロップで投稿できるけど、理由は理解できてません。
            string[] fileNames = { PB_Display.ImageLocation };
            using (Image image = Image.FromFile(fileNames[0]))
            {
                DataObject dataObject = new DataObject(DataFormats.FileDrop, fileNames);
                dataObject.SetData(DataFormats.Bitmap, image);
                PB_Display.DoDragDrop(dataObject, DragDropEffects.All);
            }
        }

        // 写真選択後
        internal void PictureSelected()
        {
            try
            {
                // 写真のファイル名の取得と、メタデータの設定
                string pictureName = Path.GetFileName(PB_Display.ImageLocation);
                MetaDataFileName = pictureName.Replace("png", "xml");
                string MetaDataFilePath;

                // 選択済みの写真ならメタデータは投稿前にある判断、投稿済みボタンは使用可、保存は可
                // 投稿済みの写真ならメタデータは投稿済みにある判断、投稿済みボタンは使用不可、保存は不可
                // どれでもない場合は未選択として、メタデータは無し、投稿済みボタンは使用不可、保存は可
                if (File.Exists($"{ProgramSettings.Settings.DesignatedPicturesSelectedFolder}\\{pictureName}"))
                {
                    MetaDataFilePath = $"{ProgramSettings.Settings.DesignatedPictureInfoPath}\\{MetaDataFileName}";
                    BT_Move.Enabled = true;
                    BT_Save.Enabled = true;
                }
                else if (File.Exists($"{ProgramSettings.Settings.DesignatedPicturesUpLoadedFolder}\\{pictureName}"))
                {
                    MetaDataFilePath = $"{ProgramSettings.Settings.DesignatedUpLoadedInfoPath}\\{MetaDataFileName}";
                    BT_Move.Enabled = false;
                    BT_Save.Enabled = false;
                }
                else
                {
                    MetaDataFilePath = "";
                    BT_Move.Enabled = false;
                    BT_Save.Enabled = true;
                }

                // 年月日の取得
                for (int i = 0; i <= 2; i++)
                {
                    pictureName = i == 2 ? pictureName.Remove(pictureName.IndexOf(".")) : pictureName.Substring(pictureName.IndexOf("_") + 1);
                }
                string worldName = "";
                string[] dateAndTime = pictureName.Split('_');
                dateAndTime[0] = dateAndTime[0].Replace("-", "");
                dateAndTime[1] = dateAndTime[1].Replace("-", "");

                // ワールド候補リストの設定
                LI_WorldList.Items.Clear();
                LI_WorldList.Items.AddRange(LogEditor.GetWorldList(dateAndTime, ref worldName));

                // 内容の読み込み（あれば）
                PictureInfo pictureInfo = XmlContractor.LoadObjectXML<PictureInfo>(MetaDataFilePath);
                if (string.IsNullOrWhiteSpace(pictureInfo.WorldName))
                {
                    TB_WorldName.Text = worldName;
                    TB_WorldAuthorName.Text = WorldData.Keys.Contains(worldName) ? WorldData[worldName] : "";
                }
                else
                {
                    TB_WorldName.Text = pictureInfo.WorldName;
                    TB_WorldAuthorName.Text = pictureInfo.WorldAuthor;
                }
                TB_AvatarName.Text = pictureInfo.AvatarName;
                TB_AvatarAuthor.Text = pictureInfo.AvatarAuthor;
                TB_Sentence.Lines = pictureInfo.TweetContents;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        // ワールド名選択
        private void LI_WorldList_Click(object sender, EventArgs e)
        {
            if (LI_WorldList.Items.Count == 0 || LI_WorldList.SelectedItem is null) return;
            string WorldName  = LI_WorldList.SelectedItem.ToString().Trim();
            TB_WorldName.Text = WorldName;

            TB_WorldAuthorName.Text = WorldData.Keys.Contains(WorldName)? WorldData[WorldName]: "";
        }

        // 閉じる
        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    
        // Twitterを開く
        private void BT_OpenTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/home");
        }
        
        // VRChatを開く：Home直開きは、何かしらの向こうのチェックが走って嫌な予感がしたのでやめました
        private void BT_OpenVRCHome_Click(object sender, EventArgs e)
        {
            Process.Start("https://hello.vrchat.com");
        }
        
        // 投稿後の処理
        private void BT_Move_Click(object sender, EventArgs e)
        {
            try
            {
                string upLoadedPicturePath = $"{ProgramSettings.Settings.DesignatedPicturesSelectedFolder}\\{Path.GetFileName(PB_Display.ImageLocation)}";
                // 写真を移動して、メタデータも移動
                PicturesOrganizer.MoveUpLoadedPicture(upLoadedPicturePath);
                LogEditor.MoveMetaDataFile($"{ProgramSettings.Settings.DesignatedPictureInfoPath}\\{MetaDataFileName}");

                // 追加で処理ができないように
                BT_Save.Enabled = false;
                BT_Move.Enabled = false;

                if (TB_FolderPath.Text.Trim() == ProgramSettings.Settings.DesignatedPicturesSelectedFolder)
                    FV_FileList.SetListItems(ProgramSettings.Settings.DesignatedPicturesSelectedFolder);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // 選択した写真をコピー：メタデータも作成
        private void BT_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // インスタンスにメタデータを格納
                PictureInfo pictureInfo = new PictureInfo
                {
                    WorldName     = TB_WorldName.Text.Trim(),
                    WorldAuthor   = TB_WorldAuthorName.Text.Trim(),
                    AvatarName    = TB_AvatarName.Text.Trim(),
                    AvatarAuthor  = TB_AvatarAuthor.Text.Trim(),
                    TweetContents = TB_Sentence.Lines
                };

                string metaDataFilePath = $"{ProgramSettings.Settings.DesignatedPictureInfoPath}\\{MetaDataFileName}";

                // 写真をコピーして、メタデータを作成
                PicturesOrganizer.MoveSelectedPicture(PB_Display.ImageLocation);
                XmlContractor.WriteObjectXML(metaDataFilePath, pictureInfo);

                // とりあえずワールド情報を保持
                WorldData[pictureInfo.WorldName] = pictureInfo.WorldAuthor;

                // 投稿済みボタンを押せるように
                BT_Move.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 上の階層へ
        private void BT_UP_Click(object sender, EventArgs e)
        {
            try
            {
                string tmpString = TB_FolderPath.Text.Trim();
                int strPosition = tmpString.LastIndexOf("\\");

                tmpString = tmpString.Remove(strPosition, tmpString.Length - strPosition);

                TB_FolderPath.Text = tmpString;
                FV_FileList.SetListItems(tmpString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // パス指定時
        private void TB_FolderPath_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // エンター時のみ、パスチェックしてリスト設定
                if (e.KeyCode != Keys.Enter) return;
                if (!Path_Validation(TB_FolderPath.Text)) return;

                // 気持ち的に整形
                TB_FolderPath.Text = TB_FolderPath.Text.Trim().TrimEnd('\\');
                FV_FileList.SetListItems(TB_FolderPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // パスチェックするイベント
        private void TB_FolderPath_Validating(object sender, CancelEventArgs e)
        {
            TB_FolderPath.Text = TB_FolderPath.Text.Trim().TrimEnd('\\');
            e.Cancel = Path_Validation(TB_FolderPath.Text) ? false : true;
        }

        //　パスチェックのメインメソッド
        private bool Path_Validation(string pathString)
        {
            if (Directory.Exists(pathString)) return true;

            MessageBox.Show("存在しないパスです。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        // フォルダリストから選択時
        private void DT_DirectoryList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                FV_FileList.SetListItems(e.Node.FullPath);
                TB_FolderPath.Text = e.Node.FullPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        // ファイルの選択時
        private void FV_FileList_Click(object sender, EventArgs e)
        {
            try
            {
                // 既に選択したものなら処理しない
                if (FV_FileList.StringPath == PB_Display.ImageLocation) return;
                // 情報の更新
                if (FV_FileList.SelectedItemType == ListSelectedItemType.Picture) PB_Display.ImageLocation = FV_FileList.StringPath;
                PictureSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        // ファイル一覧からフォルダを選択時
        private void FV_FileList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // 情報の更新
                if (FV_FileList.SelectedItemType == ListSelectedItemType.Folder) TB_FolderPath.Text = FV_FileList.StringPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region"テキストボックスのカーソル送り"
        private void TB_WorldName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            TB_WorldAuthorName.Select();
        }

        private void TB_WorldAuthorName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            TB_Sentence.Select();
        }

        private void TB_AvatarName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            TB_AvatarAuthor.Select();
        }

        private void TB_AvatarAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            TB_Sentence.Select();
        }

        #endregion

        // アバター選択時
        private void LI_AvatarList_Click(object sender, EventArgs e)
        {
            if (LI_AvatarList.Items.Count == 0 || LI_AvatarList.SelectedItem is null) return;
            TB_AvatarName.Text = ((DataRowView)LI_AvatarList.SelectedItem)[0].ToString();
            TB_AvatarAuthor.Text = LI_AvatarList.SelectedValue.ToString();
        }

        // フォーム終了時
        private void PictureSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // ワールド情報の保存
                XmlContractor.WriteObjectXML($"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.WorldDataFile}", WorldData);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 投稿内容のコピー
        private void BT_Sentence_Click(object sender, EventArgs e)
        {
            try
            {
                // プログラム終了後は残さない
                Clipboard.SetDataObject(TB_Sentence.Text, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        // ワールド名のコピー
        private void BT_WorldName_Click(object sender, EventArgs e)
        {
            try
            {
                // プログラム終了後は残さない
                Clipboard.SetDataObject(TB_WorldName.Text, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // ワールド製作者のコピー
        private void BT_WorldAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                // プログラム終了後は残さない
                Clipboard.SetDataObject(TB_WorldAuthorName.Text, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // アバター名のコピー
        private void BT_AvatarName_Click(object sender, EventArgs e)
        {
            try
            {
                // プログラム終了後は残さない
                Clipboard.SetDataObject(TB_AvatarName.Text, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // アバター製作者のコピー
        private void BT_AvatarAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                // プログラム終了後は残さない
                Clipboard.SetDataObject(TB_AvatarAuthor.Text, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 左回転
        private void BT_TurnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if (PB_Display.Image is null) return;
                PB_Display.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                PB_Display.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 変更の上書き保存
        private void BT_SavePicture_Click(object sender, EventArgs e)
        {
            try
            {
                // 変更を上書き保存
                if (PB_Display.Image is null) return;
                PB_Display.Image.Save(PB_Display.ImageLocation);

                // サムネイルの更新
                string destPath = $"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.ThumbnailFolderName}\\{Path.GetFileName(PB_Display.ImageLocation)}";
                PicturesOrganizer.CreateThumbNail(PB_Display.ImageLocation, destPath);

                // ファイル一覧の更新
                if (TB_FolderPath.Text.Trim() == Path.GetDirectoryName(PB_Display.ImageLocation)) FV_FileList.SetListItems(TB_FolderPath.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 右回転
        private void BT_TurnRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (PB_Display.Image is null) return;
                PB_Display.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                PB_Display.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
