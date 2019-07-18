namespace Data
{
    /// <summary>
    /// セーブデータの入れ物として使うプロパティクラス
    /// </summary>7
    public class TemplateSaveData
    {
        // Jsonに書き出すためにシリアライズ化する
        //private string saveDataName;
        [UnityEngine.SerializeField]
        private string saveDataName;

        ///// <summary >
        ///// (Get only) セーブデータの名前
        ///// </summary>
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