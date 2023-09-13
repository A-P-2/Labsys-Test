using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ListManager : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private Transform container;
    [SerializeField] private GameObject buttonTemplate;

    private void Start()
    {
        mainPanel.SetActive(false);
        buttonTemplate.SetActive(false);
    }

    public void ShowWindow(bool value) => mainPanel.SetActive(value);

    public void FillList(Queue<string> values, Action<string> buttonFunction)
    {
        foreach (var value in values)
        {
            GameObject button = Instantiate(buttonTemplate, container);
            button.GetComponentInChildren<TextMeshProUGUI>().text = value;

            Button buttonComponent = button.GetComponent<Button>();
            buttonComponent.onClick.AddListener(() => ShowWindow(false));
            buttonComponent.onClick.AddListener(() => buttonFunction(value));

            button.SetActive(true);
        }
    }
}
