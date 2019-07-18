using System.IO;
using UnityEngine;
using Data;

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
        private static readonly string saveDataAtFilePathConst = $"{Application.persistentDataPath}/sample.txt";



        /// <summary>
        /// セーブ
        /// </summary>
        /// <param name="instance"></param>
        /// <typeparam name="T"></typeparam>
        public static void Save<T>(T instance)
        {
            string json = JsonUtility.ToJson(instance);
            Debug.Log("SavePass:" + saveDataAtFilePathConst);

            var writer = new StreamWriter(saveDataAtFilePathConst, false);
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
        }

        /// <summary>
        /// ロード
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Load<T>()
        {
            string json = JsonUtility.ToJson(new TemplateSaveData(""));
            if (File.Exists(saveDataAtFilePathConst))
            {
                json = File.ReadAllText(saveDataAtFilePathConst);
                return JsonUtility.FromJson<T>(json);
            }
            else
            {
                Debug.Log("FileNull");
                return JsonUtility.FromJson<T>(json);
            }
        }
    }
}