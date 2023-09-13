using TMPro;
using UnityEngine;

public class InfoManager : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private TextMeshProUGUI titleField;
    [SerializeField] private TextMeshProUGUI textField;

    private void Start()
    {
        mainPanel.SetActive(false);
    }

    public void ShowWindow(bool value) => mainPanel.SetActive(value);

    public void FillInfo(string title, string text)
    {
        titleField.text = title; 
        textField.text = text;
    }
}
