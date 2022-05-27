// @(h)Program.cs ver 0.00 ( '22.04.09 Nov-Lab ) 作成開始(自動生成)
// @(h)Program.cs ver 0.51 ( '22.05.06 Nov-Lab ) 機能修正：メインフォームの表示前にアプリケーション初期処理を行うようにした。

// @(s)
// 　アプリケーションのメイン エントリ ポイントです。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace DebugStation
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static int Main()
        {
            //------------------------------------------------------------
            /// アプリケーションを実行する
            //------------------------------------------------------------
            //----------------------------------------
            // 自動生成された部分
            //----------------------------------------
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //----------------------------------------
            // 追加・修正した部分
            //----------------------------------------
            var success = AppBase.Initialize();                         //// アプリケーション初期処理を行う
            if (success == false)
            {                                                           //// 異常終了の場合
                Application.Exit();                                     /////  アプリケーションを終了する
                return -1;                                              /////  終了コード = -1(エラー) でプロセス終了
            }

            Application.Run(new FrmAppDebugStation());                  //// アプリケーションの実行を開始する
            return 0;                                                   //// 終了コード = 0(正常終了) でプロセス終了
        }
    }
}
