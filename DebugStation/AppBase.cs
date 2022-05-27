// @(h)AppBase.cs ver 0.00 ( '22.05.06 Nov-Lab ) 作成開始
// @(h)AppBase.cs ver 0.51 ( '22.05.06 Nov-Lab ) ベータ版完成
// @(h)AppBase.cs ver 0.51a( '22.05.24 Nov-Lab ) その他  ：コメント整理

// @(s)
// 　【アプリケーション基本部】デバッグステーションアプリケーションの基本部分や共通部分を管理します。

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Windows.Forms;

using NovLab;
using NovLab.IO.Mailslot;
using NovLab.DebugStation;
using NovLab.Windows.Forms;

//[-] 保留。受信したデータはすべて蓄積しておき、後からフィルター処理できるようにする


namespace DebugStation
{
    //====================================================================================================
    /// <summary>
    /// 【アプリケーション基本部】デバッグステーションアプリケーションの基本部分や共通部分を管理します。
    /// </summary>
    //====================================================================================================
    public static partial class AppBase
    {
        //====================================================================================================
        // グローバル変数
        //====================================================================================================
        /// <summary>
        /// 【メールスロットサーバー】
        /// </summary>
        public static MailslotServer mailslotServer;


        //[-] 保留：初期化ファイルで指定・選択できるようにする
        /// <summary>
        /// 【メールスロット名】
        /// </summary>
        public const string MAILSLOT_NAME = DebugStationClient.DEFAULT_MAILSLOT_NAME;


        //====================================================================================================
        // static 公開メソッド
        //====================================================================================================

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【アプリケーション初期処理】本アプリケーションを初期化します。
        /// </summary>
        /// <returns>
        /// 処理結果[true = 正常終了 / false = 異常終了]
        /// </returns>
        //--------------------------------------------------------------------------------
        public static bool Initialize()
        {
            //------------------------------------------------------------
            /// 本アプリケーションを初期化する
            //------------------------------------------------------------
            Application.ApplicationExit +=
                new EventHandler(OnApplicationExit);                    //// アプリケーション_ApplicationExit イベントハンドラーを追加する


            //------------------------------------------------------------
            /// DEBUGビルドの場合はWin32定義テストの準備をする
            //------------------------------------------------------------
#if DEBUG   // DEBUGビルドのみ有効
#if false   // Win32定義テストを行うときは true にする
            NovLab.Win32.TestWin32Define.PrepareTest();
#endif
#endif


            //[-] 保留：初期化ファイルにメールスロット名候補を複数記載しておき、複数起動によるエラーの場合はそこから選べるようにする。
            //------------------------------------------------------------
            /// メールスロットを作成する
            //------------------------------------------------------------
            try
            {                                                           //// try開始
                mailslotServer = new MailslotServer(MAILSLOT_NAME);     /////  メールスロットサーバーを生成する
            }
            catch (COMException ex)
            {                                                           //// catch：COMException
                if ((uint)ex.ErrorCode == 0x800700B7)
                {                                                       /////  HRESULT = 0x800700B7「既に存在するファイルを作成することはできません。」 の場合
                    XMessageBox.ShowError(                              //////   エラーメッセージを表示する
                        "同じ名前のメールスロットがすでに作成されています。",
                        Application.ProductName);
                    return false;                                       //////   戻り値 = false(異常終了) で関数終了
                }
                else
                {                                                       /////  HRESULTが上記以外の場合
                    XMessageBox.ShowError(                              //////   エラーメッセージを表示する
                        "メールスロットの作成に失敗しました。\n\n" + ex.Message,
                        Application.ProductName);
                    return false;                                       //////   戻り値 = false(異常終了) で関数終了
                }
            }
            catch (Exception ex)
            {                                                           //// catch：全ての例外
                XMessageBox.ShowError(                                  /////  エラーメッセージを表示する
                    "メールスロットの作成に失敗しました。\n\n" + ex.Message,
                    Application.ProductName);
                return false;                                           /////  戻り値 = false(異常終了) で関数終了
            }


            return true;                                                //// 戻り値 = true(正常終了) で関数終了
        }


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【アプリケーション_ApplicationExit】アプリケーションが終了するときに呼び出され、本アプリケーションの後始末を行います。
        /// </summary>
        //--------------------------------------------------------------------------------
        public static void OnApplicationExit(object sender, EventArgs e)
        {
            //------------------------------------------------------------
            /// 本アプリケーションの後始末をする
            //------------------------------------------------------------
            if (mailslotServer != null)
            {                                                           //// メールスロットサーバーを生成してある場合
                mailslotServer.Close();                                 /////  メールスロットサーバーを閉じる
                mailslotServer = null;                                  /////  メールスロットサーバー = null にクリアする
            }
        }

    }
}
