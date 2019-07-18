using UnityEngine;
using UnityEngine.UI;
using Utility;
using Data;

namespace View.Ui
{
    public class SaveUiBehaviour : MonoBehaviour
    {
        // セーブデータの名前を入力するためのインプットフィールド
        [SerializeField] private InputField inputField;
        // セーブボタン
        [SerializeField] private Button saveButton;

        
        private void Awake()
        {
            // セーブボタンが押された時の処理
            saveButton.onClick.AddListener(() =>
            {
                TemplateSaveData saveData = new TemplateSaveData(inputField.text);
                SaveControl.Save(saveData);
            });
        }
    }
}
