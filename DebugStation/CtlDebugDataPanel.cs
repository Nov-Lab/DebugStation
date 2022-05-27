// @(h)CtlDebugDataPanel.cs ver 0.00 ( '22.05.07 Nov-Lab ) 作成開始
// @(h)CtlDebugDataPanel.cs ver 0.51 ( '22.05.10 Nov-Lab ) ベータ版完成
// @(h)CtlDebugDataPanel.cs ver 0.51a( '22.05.24 Nov-Lab ) その他  ：コメント整理

// @(s)
// 　【デバッグデータパネル(ユーザーコントロール)】デバッグデータを詳細表示するパネルです。

#if DEBUG
// #define VERBOSELOG  // 冗長ログ有効化
#endif

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using NovLab;
using NovLab.DebugStation;


namespace DebugStation
{
    //====================================================================================================
    /// <summary>
    /// 【デバッグデータパネル(ユーザーコントロール)】デバッグデータを詳細表示するパネルです。
    /// </summary>
    //====================================================================================================
    public partial class CtlDebugDataPanel : UserControl
    {
        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【コンストラクター】インスタンスを初期化します。
        /// </summary>
        //--------------------------------------------------------------------------------
        public CtlDebugDataPanel()
        {
            //------------------------------------------------------------
            // 自動生成された部分
            //------------------------------------------------------------
            InitializeComponent();


            //------------------------------------------------------------
            /// インスタンスを初期化する
            //------------------------------------------------------------
            Paint += M_ExecuteDelayedReflect;                           //// Paint イベントハンドラーにデバッグデータパネル遅延反映実施処理を追加する
        }


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【クリア】デバッグデータパネルをクリアします。
        /// </summary>
        //--------------------------------------------------------------------------------
        public void Clear() => SetInfo(null);


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【情報設定】デバッグデータをパネルに設定します。null を指定した場合はパネルをクリアします。
        /// </summary>
        /// <param name="debugData">[in ]：デバッグデータ</param>
        /// <remarks>
        /// 補足<br></br>
        /// ・リストビューの ItemSelectionChanged のようにごく短時間に頻繁に呼び出される場合は、
        ///   過剰な処理を防ぐため、代わりに RequestDelayedReflect を使用します。<br></br>
        /// </remarks>
        //--------------------------------------------------------------------------------
        public void SetInfo(DebugData debugData)
        {
            //------------------------------------------------------------
            /// デバッグデータ = null の場合はパネルをクリアする
            //------------------------------------------------------------
            if (debugData == null)
            {                                                           //// デバッグデータ = null の場合
                TxtHeaderInfo.Text = "";                                /////  ヘッダー情報テキストボックスをクリアする
                TxtContent.Text = "";                                   /////  内容テキストボックスをクリアする
                TxtDetail.Text = "";                                    /////  詳細テキストボックスをクリアする
                return;                                                 /////  関数終了
            }


            //------------------------------------------------------------
            /// デバッグデータから情報を取得する
            //------------------------------------------------------------
            string content;     // 内容文字列
            string detail;      // 詳細文字列

            //----------------------------------------
            // ヘッダー情報
            //----------------------------------------
            TxtHeaderInfo.Text =
                debugData.Header.EventDateTime.ToString("yy/MM/dd HH:mm:ss.fff") + " " +
                debugData.Header.EventSource.XRemoveEnd(".exe", true, null) +
                "(" + debugData.Header.ProcessId + ")";                     //// ヘッダー情報文字列を作成してテキストボックスに設定する

            if (debugData.Header.EventCategory.XIsValid())
            {                                                               //// カテゴリ名が設定されている場合
                TxtHeaderInfo.Text += "." + debugData.Header.EventCategory; /////  ヘッダー情報テキストボックスにカテゴリ名を追加する
            }

            //----------------------------------------
            // 内容と詳細
            //----------------------------------------
            switch (debugData.Header.DebugInfoKind)
            {                                                               //// デバッグ情報種別で分岐
                case DebugInfoKind.DebugStationSignal:                      /////  デバッグステーションシグナル情報の場合
                    content = debugData.DebugStationSignalKind.ToString();  //////   内容文字列 = デバッグステーションシグナル種別
                    detail = "";                                            //////   詳細文字列 = ""
                    break;

                default:                                                    /////  上記以外の場合
                    content = debugData.Message;                            //////   内容文字列 = メッセージ文字列
                    detail = debugData.DetailMessage;                       //////   詳細文字列 = 詳細メッセージ文字列
                    break;
            }


            //------------------------------------------------------------
            /// デバッグデータパネルに情報を設定する
            //------------------------------------------------------------
            if (content == null) content = "";                          //// 内容文字列 = null の場合、空文字列にする
            if (detail == null) detail = "";                            //// 詳細文字列 = null の場合、空文字列にする

            content = content.XReplaceNewLineChars("\r\n");             //// テキストボックス用に、内容文字列の改行文字群(CR+LF, CR, LF)を CR+LF に置換する
            detail = detail.XReplaceNewLineChars("\r\n");               //// テキストボックス用に、詳細文字列の改行文字群(CR+LF, CR, LF)を CR+LF に置換する

            TxtContent.Text = content;                                  //// 内容文字列をテキストボックスに設定する
            TxtDetail.Text = detail;                                    //// 詳細文字列をテキストボックスに設定する
        }


        //====================================================================================================
        // 遅延反映処理関連
        //====================================================================================================

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【デバッグデータパネル遅延反映要求】デバッグデータのパネルへの遅延反映を要求します。
        /// </summary>
        /// <param name="debugData">[in ]：デバッグデータ[null = パネルをクリアする]</param>
        /// <remarks>
        /// 補足<br></br>
        /// ・リストビューの ItemSelectionChanged のように、ごく短時間に頻繁に呼び出される場合は、
        ///   過剰な処理を防ぐため、即時反映ではなく、遅延反映で処理した方が効率的です。<br></br>
        /// <br></br>
        /// 以下のような手順で遅延反映を行います。<br></br>
        /// ①RequestDelayedReflect は即時反映をせず、遅延反映要求情報を生成し、コントロールの再描画要求をする。<br></br>
        /// ②Paint イベントでのコントロール再描画時、遅延反映要求情報がある場合はパネルに反映する。<br></br>
        /// </remarks>
        //--------------------------------------------------------------------------------
        public void RequestDelayedReflect(DebugData debugData)
        {
            //------------------------------------------------------------
            /// デバッグデータのパネルへの遅延反映を要求する
            //------------------------------------------------------------
            m_delayedReflectInfo = new DelayedReflectInfo(debugData);   //// 遅延反映要求情報を生成する
            Invalidate();                                               //// 本コントロールを無効化する(再描画要求。次回のPaintイベントでパネルに反映される)
        }


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【デバッグデータパネル遅延反映実施】
        /// 本コントロールの再描画時に Paint イベントによって呼び出されます。
        /// 遅延反映要求がある場合はデバッグデータをパネルに反映します。
        /// </summary>
        //--------------------------------------------------------------------------------
        protected void M_ExecuteDelayedReflect(object sender, PaintEventArgs e)
        {
            //------------------------------------------------------------
            /// パネル反映要求がある場合はデバッグデータをパネルにを反映する
            //------------------------------------------------------------
            if (m_delayedReflectInfo == null)
            {                                                           //// 遅延反映要求情報がない場合
                return;                                                 /////  何もせずに関数終了
            }

            var debugData = m_delayedReflectInfo.debugData;             //// 遅延反映要求情報からデバッグデータを取得する
            m_delayedReflectInfo = null;                                //// 遅延反映要求情報 = null(要求なし) にクリアする

#if VERBOSELOG
            if (debugData == null)
            {
                Debug.Print("ExecuteDelayedReflect:(clear)");
            }
            else
            {
                Debug.Print("ExecuteDelayedReflect:" + debugData?.GetOutline());
            }
#endif

            SetInfo(debugData);                                         //// デバッグデータをパネルに反映する(null時はパネルをクリア)
        }


        /// <summary>
        /// 【遅延反映要求情報】[null = 要求なし]
        /// </summary>
        protected DelayedReflectInfo m_delayedReflectInfo;


        //================================================================================
        /// <summary>
        /// 【デバッグデータパネル遅延反映情報】デバッグデータパネルの遅延反映に必要な情報を管理します。
        /// </summary>
        //================================================================================
        protected class DelayedReflectInfo
        {
            /// <summary>
            /// 【デバッグデータ】[null = パネルをクリアする]
            /// </summary>
            public DebugData debugData;


            public DelayedReflectInfo(DebugData debugData)
            {
                this.debugData = debugData;
            }
        }

    }
}
