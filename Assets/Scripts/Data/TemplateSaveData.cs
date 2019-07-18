using System;
using UnityEngine;
namespace Data
{

    /// <summary>
    /// セーブデータの入れ物として使うプロパティクラス
    /// </summary>
    /// 
    [Serializable]
    public class TemplateSaveData
    {
        [SerializeField]
        private string saveDataName;

        /// <summary>
        /// (Get only) セーブデータの名前
        /// </summary>
        /// 

        public string SaveDataName
        {
            get
            {
                return saveDataName;              
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="saveDataName"></param>
        public TemplateSaveData(string saveDataName)
        {
            this.saveDataName = saveDataName;
        }
    }
}