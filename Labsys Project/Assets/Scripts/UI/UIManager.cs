using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button[] infoButtons;
    [SerializeField] private ListManager listWindow;
    [SerializeField] private InfoManager infoWindow;
    [SerializeField] private Transform modelShowcase;

    [SerializeField] private ObjectsManager objectsManager;

    private ObjectInfo currentObject;

    private void Start()
    {
        ActivateInfoButtons(false);

        objectsManager.Initialize();
        listWindow.FillList(objectsManager.GetObjectNames(), SetObject);
    }

    public void ShowListWindow() => listWindow.ShowWindow(true);

    public void ShowDescriptionWindow()
    {
        infoWindow.FillInfo("Описание", currentObject.Description);
        infoWindow.ShowWindow(true);
    }

    public void ShowSpecificationsWindow()
    {
        infoWindow.FillInfo("Характеристики", currentObject.Specifications);
        infoWindow.ShowWindow(true);
    }

    public void ActivateInfoButtons(bool value)
    {
        foreach (var button in infoButtons) button.interactable = value;
    }

    public void SetObject(string objectName)
    {
        foreach (Transform child in modelShowcase) Destroy(child.gameObject);

        currentObject = objectsManager.GetObjectInfo(objectName);
        Instantiate(currentObject.Model, modelShowcase);

        ActivateInfoButtons(true);
    }
}
