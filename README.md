﻿# DebugStation アプリケーション

デバッグ支援用 Windows アプリケーションです。

NovLab.Base クラスライブラリと併用します。


# 動作環境

- Windows 8.1以降
- .NET Framework 4.5.1 以降、または互換性のある .NET 実装

### デバッグ対象プログラム側の必要要件

- [NovLab.Base](https://github.com/Nov-Lab/NovLab.Base) クラスライブラリ


# 特長

- `Debug` クラスによるデバッグ出力や、`Trace` クラスによるトレース出力を、デバッグ対象プログラムから受け取って表示することができます。
- 連携して動作する複数プロセスからの出力内容をひとまとめに俯瞰することができます。
- `NLDebug` クラスを通じたデバッグ支援機能を利用することができます。


# 依存リポジトリ

- [NovLab.Base](https://github.com/Nov-Lab/NovLab.Base) クラスライブラリ
- [NovLab.Windows.Forms](https://github.com/Nov-Lab/NovLab.Windows.Forms) クラスライブラリ

### ローカルリポジトリにおけるフォルダー配置について

本リポジトリのソリューションと、依存リポジトリのソリューションは、以下のように同じ親フォルダーの下へ配置してください。
```
＜親フォルダー＞
  ├ DebugStation ソリューション
  ├ NovLab.Base ソリューション
  └ NovLab.Windows.Forms ソリューション
```


# 使い方

- デバッグ対象プログラム側で以下の対応を行います。
  1. `NovLab.Base` アセンブリへの参照を追加します。
  2. `DebugStationTraceListener` をトレースリスナーに追加します。

     プログラムの初期処理などに以下のコードを追加するか、アプリケーション構成ファイルを修正します。
      ```
      using NovLab.DebugStation;
      
      Debug.Listeners.Add(new DebugStationTraceListener());
      ```

- 上記対応を行ったのち、DebugStation アプリケーションを起動した状態でデバッグ対象プログラムを実行すると、デバッグ出力やトレース出力が DebugStation に表示されます。

- `NLDebug` クラスを使うと、DebugStation 独自のデバッグ支援機能を利用することができます。


# フォルダー構成

- `binfile` ：コンパイル済みのバイナリーファイルです。
- `DebugStation` ：DebugStation のプロジェクトです。


# ライセンス

本ソフトウェアは、MITライセンスに基づいてライセンスされています。

ただし、改変する場合は、namespace の名前を変えて重複や混乱を避けることを強く推奨します。


# 関連リポジトリ

- [TestDebugStation](https://github.com/Nov-Lab/TestDebugStation) ：本アプリケーションのテスト用プロジェクトです。


# 開発環境

## 開発ツール、SDKなど
- Visual Studio Community 2019
  - ワークロード：.NET デスクトップ開発

## 言語
- C#


# その他

Nov-Lab 独自の記述ルールと用語については [NovLabRule.md](https://github.com/Nov-Lab/Nov-Lab/blob/main/NovLabRule.md) を参照してください。
