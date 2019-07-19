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
            // ファイルが存在していなかったら作成
            if (!File.Exists(saveDataAtFilePathConst))
            {
                File.Create(saveDataAtFilePathConst);
            }
            // Jsonに変換
            string json = JsonUtility.ToJson(instance);

            // 書き込み
            File.WriteAllText(saveDataAtFilePathConst, json);

#if UNITY_EDITOR
            Debug.Log(saveDataAtFilePathConst + "にデータを保存しました");
#endif
        }

        /// <summary>
        /// ロード
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Load<T>()
        {
            if (!File.Exists(saveDataAtFilePathConst))
            {
#if UNITY_EDITOR
                Debug.Log("ファイルが存在しません");
#endif
                return JsonUtility.FromJson<T>(null);
            }
            else
            {
                string json = File.ReadAllText(saveDataAtFilePathConst);
                return JsonUtility.FromJson<T>(json);
            }
        }
    }
}