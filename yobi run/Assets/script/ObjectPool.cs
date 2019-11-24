using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance { get; private set; }

    Dictionary<string, Queue<GameObject>> objects = new Dictionary<string, Queue<GameObject>>();
    private void Awake()
    {
        Instance = this;
    }

    public GameObject getGameObject(GameObject prefab)
    {
        string key = prefab.name;
        if (!objects.ContainsKey(key))
        {
            objects.Add(key, new Queue<GameObject>());
        }
        Queue<GameObject> queue = objects[key];
        if (queue.Count > 0)
        {
            return queue.Dequeue();
        }
        else
        {
            return Instantiate(prefab);
        }
    }

    public void reuseObject(GameObject obj)
    {
        obj.SetActive(false);
        string key = obj.name.Replace("(Clone)","");
        if (!objects.ContainsKey(key))
        {
            objects.Add(key, new Queue<GameObject>());
        }
        Queue<GameObject> queue = objects[key];
        queue.Enqueue(obj);


    }
}
