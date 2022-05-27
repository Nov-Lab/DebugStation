// @(h)FrmAppDebugStation_Menu.cs ver 0.00 ( '22.05.12 Nov-Lab ) 作成開始(FrmAppDebugStation.cs から分離)
// @(h)FrmAppDebugStation_Menu.cs ver 0.51 ( '22.05.12 Nov-Lab ) ベータ版完成
// @(h)FrmAppDebugStation_Menu.cs ver 0.51a( '22.05.24 Nov-Lab ) その他  ：コメント整理

// @(s)
// 　【デバッグステーション・メイン画面 - メニューイベント処理部分】デバッグステーションメイン画面のうち、メニューイベント処理に関連する部分です。

using System;
using System.Diagnostics;
using System.Windows.Forms;

using NovLab;
using NovLab.Windows.Forms;


namespace DebugStation
{
    // ソリューションエクスプローラーでこのソースファイルをダブルクリックしたときにデザイナーが起動されるのをブロックするためのダミーの記述です。
    // (VisualStudio2019で動作確認済み)
    public static partial class AppBase { }


    //====================================================================================================
    // 【デバッグステーション・メイン画面 - メニューイベント処理部分】
    //====================================================================================================
    public partial class FrmAppDebugStation : Form
    {
        //====================================================================================================
        // メニューイベント：ファイル
        //====================================================================================================

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【メニュー項目：ファイル - 終了_Click】アプリケーションを終了します。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuFile_AppExit_Click(object sender, EventArgs e)
        {
            //------------------------------------------------------------
            /// 必要な場合は実行確認をする
            //------------------------------------------------------------
            if (M_NeedConfirmationBeforeClose)
            {                                                           //// クローズ前に実行確認が必要な場合
                var result = XMessageBox.ShowExclamationYN(             /////  実行確認メッセージを表示する
                    "アプリケーションを終了します。\nよろしいですか?",
                    Application.ProductName);
                if (result != DialogResult.Yes)
                {                                                       /////  「はい」が選択されなかった場合
                    return;                                             //////   何もせずに関数終了
                }
            }


            //------------------------------------------------------------
            /// アプリケーションを終了する
            //------------------------------------------------------------
            M_CloseForceAll();                                          //// 全ウィンドウ強制クローズ処理を行う
            this.Close();                                               //// 本フォームを閉じる
        }


        //====================================================================================================
        // メニューイベント：表示
        //====================================================================================================

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【メニュー項目：表示 - ツールバー_Click】メニュー項目のチェック状態に合わせて、ツールバーの表示状態を切り替えます。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuView_ToolBar_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = MnuView_ToolBar.Checked;
        }


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【メニュー項目：表示 - ステータスバー_Click】メニュー項目のチェック状態に合わせて、ステータスバーの表示状態を切り替えます。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuView_StatusBar_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = MnuView_StatusBar.Checked;
        }


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【メニュー項目：表示 - 最前面に表示_Click】メニュー項目のチェック状態に合わせて、最前面表示状態を切り替えます。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuView_TopMost_Click(object sender, EventArgs e)
        {
            TopMost = MnuView_TopMost.Checked;
        }


        //====================================================================================================
        // メニューイベント：ウィンドウ
        //====================================================================================================

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【メニュー項目：ウィンドウ - 新しいウィンドウを開く_Click】
        /// 新しい出力ビュー画面を開きます
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuWindows_OpenNewWindow_Click(object sender, EventArgs e)
        {
            //------------------------------------------------------------
            /// 新しい出力ビュー画面を開く
            //------------------------------------------------------------
            var frmDebugOutput = new FrmOutputView()
            {                                                           //// 出力ビュー画面を生成する
                MdiParent = this,                                       /////  MDI親フォーム = このフォーム
            };
            frmDebugOutput.Show();                                      //// 出力ビュー画面を表示する
        }


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【メニュー項目：ウィンドウ - すべて閉じる】すべてのウィンドウを閉じます。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuWindows_CloseAll_Click(object sender, EventArgs e)
        {
            //------------------------------------------------------------
            /// 必要な場合は実行確認をする
            //------------------------------------------------------------
            if (M_NeedConfirmationBeforeClose)
            {                                                           //// クローズ前に実行確認が必要な場合
                var result = XMessageBox.ShowExclamationYN(             /////  実行確認メッセージを表示する
                    "すべてのウィンドウを閉じます。\nよろしいですか?",
                    "すべて閉じる");
                if (result != DialogResult.Yes)
                {                                                       /////  「はい」が選択されなかった場合
                    return;                                             //////   何もせずに関数終了
                }
            }


            //------------------------------------------------------------
            /// すべてのウィンドウを閉じる
            //------------------------------------------------------------
            M_CloseForceAll();                                          //// 全ウィンドウ強制クローズ処理を行う
        }


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【ウィンドウ - 重ねて表示】MDI子フォームを重ねて表示します。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuWindows_Cascade_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【ウィンドウ - 左右に並べて表示】MDI子フォームを左右に並べて表示します。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuWindows_TileVertical_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【ウィンドウ - 上下に並べて表示】MDI子フォームを上下に並べて表示します。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuWindows_TileHorizontal_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【ウィンドウ - アイコンの整列】MDI子アイコンを整列します。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuWindows_ArrangeIcons_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.ArrangeIcons);


        //====================================================================================================
        // メニューイベント(後で実装するかもしれないもの)
        //====================================================================================================

        // 後で実装するかも：MnuFile_OpenFile
        private void MnuFile_OpenFile_Click(object sender, EventArgs e)
        {
#if false
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "テキスト ファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
#endif
        }


        // 後で実装するかも：MnuFile_SaveAs
        private void MnuFile_SaveAs_Click(object sender, EventArgs e)
        {
#if false
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "テキスト ファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
#endif
        }

    }
}
