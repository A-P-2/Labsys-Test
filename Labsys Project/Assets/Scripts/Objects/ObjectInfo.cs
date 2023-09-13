using UnityEngine;

[CreateAssetMenu(fileName = "Object", menuName = "ScriptableObjects/Object")]
public class ObjectInfo : ScriptableObject
{
    [SerializeField] private string objectName;
    [SerializeField] [TextArea(3, 10)] private string description;
    [SerializeField] [TextArea(3, 10)] private string specifications;
    [SerializeField] private GameObject model;

    public string ObjectName { get => objectName; }
    public string Description { get => description; }
    public string Specifications { get => specifications; }
    public GameObject Model { get => model; }
}
