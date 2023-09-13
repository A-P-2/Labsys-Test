using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectsManager", menuName = "ScriptableObjects/ObjectsManager")]
public class ObjectsManager : ScriptableObject
{
    [SerializeField] private ObjectInfo[] objectInfos;

    private readonly Dictionary<string, ObjectInfo> objects = new Dictionary<string, ObjectInfo>();

    public void Initialize()
    {
        foreach (ObjectInfo obj in objectInfos)
        {
            objects.Add(obj.ObjectName, obj);
        }
    }

    public Queue<string> GetObjectNames() => new Queue<string>(objects.Keys);

    public ObjectInfo GetObjectInfo(string name) => objects[name];
}
