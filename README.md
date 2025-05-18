# Unity Test Runner サンプルプロジェクト

こんにちは。  
このリポジトリは、UnityのTest Runnerを使ってTDD（テスト駆動開発）を実践した小さなサンプルプロジェクトです。

普段ゲームを作るとき、テストはどうしても後回しにされがちですが、ちゃんと書くとコードがすっきりして、バグも早く見つかるし、安心して手を加えられるようになります。

---

## このプロジェクトでやっていること

- **Play Mode**  
  DamageTestというSceneを開いてスタートしたらUIをクリックするとHpが10減ることを確認できます。これをTest RunnerのPlayModeでもテストできます。
  <img width="991" alt="image" src="https://github.com/user-attachments/assets/81bab46b-e944-4b12-afb4-5fc3b2e336c7" />

- **Editor Mode**  
  PlayしなくてもUnity上で計算が問題ないのか、正規表現が問題なのかを確認するのができます。

  <img width="642" alt="image" src="https://github.com/user-attachments/assets/b8328ae7-478b-48f3-8a18-ea52b6c60579" />
  計算のテストコード

  <img width="754" alt="image" src="https://github.com/user-attachments/assets/9a892d9e-21c9-4d4a-9bf4-c1decdf514a1" />
  正規表現のテストコード

  <img width="1052" alt="image" src="https://github.com/user-attachments/assets/3edac980-3986-4dd3-aa69-e66010c8cfd8" />
  

---

## テスト構成

### EditMode テスト
- 計算結果が合っているかの確認（加算・減算）
- 正規表現を使った文字列の整形テスト（記号除去）

### PlayMode テスト
- モンスターを1回クリックするとHPが10減るか
- 事前に `Main Camera` や `EventSystem` を準備しておく必要あり
- テストのための簡単なヘルパークラスも用意しています

## 実行手順

1. Unity エディタを開く
2. メニューから `Window > General > Test Runner` を開く
3. `EditMode` または `PlayMode` タブからテストを実行

---

## 使用している技術

- Unity 6.0
- NUnit / Unity Test Framework
- uGUI
- C#
