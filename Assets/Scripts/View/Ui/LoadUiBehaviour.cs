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
            inputField.text = SaveControl.Load<TemplateSaveData>().SaveDataName;
        }
    }
}