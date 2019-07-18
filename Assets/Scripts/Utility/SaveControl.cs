using System.IO;
using UnityEngine;

namespace Utility
{
    /// <summary>
    /// セーブを管理するクラス
    /// </summary>
    public static class SaveControl
    {
        /// <summary>
        /// セーブデータを保存するファイルパス定数
        /// </summary>
        private static readonly string saveDataAtFilePathConst = $"{Application.persistentDataPath}/sample.save";

        /// <summary>
        /// セーブ
        /// </summary>
        /// <param name="instance"></param>
        /// <typeparam name="T"></typeparam>
        public static void Save<T>(T instance)
        {
            string json = JsonUtility.ToJson(instance);
            File.WriteAllText(saveDataAtFilePathConst, json);

            Debug.Log(saveDataAtFilePathConst + "にデータを保存しました");
        }

        /// <summary>
        /// ロード
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Load<T>()
        {
            // 空データ
            string json = JsonUtility.ToJson(new Data.TemplateSaveData(""));

            // ファイルが存在しているかチェック(存在しない = false)
            if (File.Exists(saveDataAtFilePathConst) == false)
            {
                Debug.Log("ファイルが存在していません！");

                // ファイルが存在していないので、空データを返す
                return JsonUtility.FromJson<T>(json);
            }
            else
            {
                // 中身が入っていたらデータを取得
                json = File.ReadAllText(saveDataAtFilePathConst);

                // Jsonからstringに変換して返す
                return JsonUtility.FromJson<T>(json);
            }
        }
    }
}