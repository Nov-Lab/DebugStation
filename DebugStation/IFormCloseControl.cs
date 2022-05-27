// @(h)IFormCloseControl.cs ver 0.00 ( '22.05.12 Nov-Lab ) 作成開始
// @(h)IFormCloseControl.cs ver 1.01 ( '22.05.12 Nov-Lab ) 初版完成

// @(s)
// 　【フォームクローズ制御I/F】実行確認付きのクローズ制御を行うフォームに必要な機能を定義します。

using System;
using System.Collections.Generic;


namespace DebugStation
{
    //====================================================================================================
    /// <summary>
    /// 【フォームクローズ制御I/F】実行確認付きのクローズ制御を行うフォームに必要な機能を定義します。
    /// </summary>
    //====================================================================================================
    public interface IFormCloseControl
    {
        /// <summary>
        /// 【強制クローズ】実行確認なしにフォームを閉じます。
        /// </summary>
        void CloseForce();

        /// <summary>
        /// 【クローズ前実行確認要求フラグ】クローズ前に実行確認が必要かどうかを示します。
        /// </summary>
        bool NeedConfirmationBeforeClose { get; }
    }
}
