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
        }

        /// <summary>
        /// ロード
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Load<T>()
        {
            string json = File.ReadAllText(saveDataAtFilePathConst);
            return JsonUtility.FromJson<T>(json);
        }
    }
}