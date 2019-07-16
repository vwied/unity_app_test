using UnityEngine;

namespace Data
{
    /// <summary>
    /// セーブデータの入れ物として使うプロパティクラス
    /// </summary>
    [System.Serializable]
    public class TemplateSaveData
    {
        [SerializeField]
        private string saveDataName;

        

        /// <summary>
        /// (Get only) セーブデータの名前
        /// </summary>
        public string SaveDataName
        {
            get
            {
                return SaveDataName1;              
            }
        }

        public string SaveDataName1 { get => saveDataName; set => saveDataName = value; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="saveDataName"></param>
        public TemplateSaveData(string saveDataName)
        {
            this.SaveDataName1 = saveDataName;
        }
    }
}