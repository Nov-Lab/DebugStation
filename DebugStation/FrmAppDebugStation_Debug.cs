// @(h)FrmAppDebugStation_Debug.cs ver 0.00 ( '22.05.12 Nov-Lab ) 作成開始(FrmAppDebugStation.cs から分離)
// @(h)FrmAppDebugStation_Debug.cs ver 0.51 ( '22.05.12 Nov-Lab ) ベータ版完成
// @(h)FrmAppDebugStation_Debug.cs ver 0.51a( '22.05.24 Nov-Lab ) その他  ：コメント整理

// @(s)
// 　【デバッグステーション・メイン画面 - デバッグ処理部分】デバッグステーションメイン画面のうち、デバッグ処理に関連する部分です。

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using NovLab;
using NovLab.DebugStation;
using NovLab.Windows.Forms;


namespace DebugStation
{
    // ソリューションエクスプローラーでこのソースファイルをダブルクリックしたときにデザイナーが起動されるのをブロックするためのダミーの記述です。
    // (VisualStudio2019で動作確認済み)
    public static partial class AppBase { }


    //====================================================================================================
    // 【デバッグステーション・メイン画面 - デバッグ処理部分】
    //====================================================================================================
    public partial class FrmAppDebugStation : Form
    {
        //====================================================================================================
        // メニューイベント(DEBUGビルドのみ)
        //====================================================================================================

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【メニュー項目：デバッグ - テストプログラムを起動_Click】テストプログラムを起動します。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuDebug_LaunchTestProgram_Click(object sender, EventArgs e)
        {
#if DEBUG   // DEBUGビルドのみ
            //------------------------------------------------------------
            /// テストプログラムを起動する
            //------------------------------------------------------------
            var pathFile =                                              //// フルパスファイル名を作成する
                Path.GetFullPath("..\\..\\..\\..\\TestDebugStation\\TestDebugStation\\bin\\Debug\\TestDebugStation.exe");

            try
            {                                                           //// try開始
                Process.Start(pathFile);                                /////  テストプログラムを起動する
            }
            catch (Exception ex)
            {                                                           //// catch：すべての例外
                XMessageBox.ShowWarning(                                /////  エラーメッセージを表示する
                    "起動できません：" + pathFile + "\n\n" + ex.Message, "エラー");
            }
#endif
        }


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【メニュー項目：デバッグ - クイックテスト_Click】クイックテストを実施します。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuDebug_QuickTest_Click(object sender, EventArgs e)
        {
#if DEBUG   // DEBUGビルドのみ
            M_QuickTest();  /// クイックテスト処理を行う
#endif
        }


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【メニュー項目：デバッグ - メールスロットを閉じる_Click】
        /// (エラー系のテスト用)アプリケーションを起動したままメールスロットを閉じます。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void MnuDebug_CloseMailSlot_Click(object sender, EventArgs e)
        {
#if DEBUG   // DEBUGビルドのみ
            //------------------------------------------------------------
            /// アプリケーションを起動したままメールスロットを閉じる
            //------------------------------------------------------------
            if (AppBase.mailslotServer != null)
            {                                                           //// メールスロットサーバーを生成してある場合
                AppBase.mailslotServer.Close();                         /////  メールスロットサーバーを閉じる
                AppBase.mailslotServer = null;                          /////  メールスロットサーバー = null にクリアする
            }
#endif
        }


        //====================================================================================================
        // 内部メソッド(デバッグ用)
        //====================================================================================================

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【クイックテスト】
        /// </summary>
        //--------------------------------------------------------------------------------
        [Conditional("DEBUG")]
        protected static void M_QuickTest()
        {
            //------------------------------------------------------------
            /// 前準備：リスナーに登録されていない場合は一時追加する
            //------------------------------------------------------------
            bool tmpAdd = false;                                        //// 一時追加フラグ = false に初期化する

            //Console.WriteLine("1.リスナー登録状態：" + DebugStationTraceListener.ExistsInListener());
            if (DebugStationTraceListener.ExistsInListener() == false)
            {                                                           //// DebugStationTraceListener がリスナーに登録されていない場合
                DebugStationTraceListener.RegisterListener();           /////  リスナーに登録する
                tmpAdd = true;                                          /////  一時追加フラグ = true
            }
            //Console.WriteLine("2.リスナー登録状態：" + DebugStationTraceListener.ExistsInListener());


            //------------------------------------------------------------
            /// テスト本体
            //------------------------------------------------------------
            Debug.Print("♥🎁--- " + nameof(DebugStationTraceListener) + " のテスト ---🎁♥");


            Debug.Write("本日は\n");                   // カテゴリ名なしで Write - WriteLine
            Debug.WriteLine("晴天なり。");

            Debug.Write("本日は\n");                   // カテゴリ名なしで Write - Write - WriteLine
            Debug.Write("まことに\n");
            Debug.WriteLine("晴天なり。");

            Debug.Write("本日は\n");                   // 異なるカテゴリ名を挟んで Write - Write - WriteLine
            Debug.Write("ご来店いただき\n", "お礼");
            Debug.WriteLine("ありがとうございます。");


            //------------------------------------------------------------
            /// 後始末：リスナーを一時追加した場合は元に戻す
            //------------------------------------------------------------
            if (tmpAdd)
            {                                                           //// 一時追加した場合
                DebugStationTraceListener.UnregisterListener();         /////  リスナーの登録を解除する
            }

            //Console.WriteLine("3.リスナー登録状態：" + DebugStationTraceListener.ExistsInListener());
        }

    }
}
