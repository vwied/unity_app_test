using UnityEngine;
using UnityEngine.UI;
using Utility;
using Data;

namespace View.Ui
{
    public class LoadUiBehaviour : MonoBehaviour
    {
        // セーブデータの名前を入力するためのインプットフィールド
        [SerializeField] private InputField inputField;

        private void Start()
        {
            // 中身が空だったら代入しない
            if (SaveControl.Load<TemplateSaveData>().SaveDataName != null)
            {
                inputField.text = SaveControl.Load<TemplateSaveData>().SaveDataName;
            }
        }
    }
}