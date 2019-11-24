using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public GameObject terraPrefab;

    float count = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count > 2)
        {
            count = 0;
            GameObject obj = ObjectPool.Instance.getGameObject(terraPrefab);
            obj.SetActive(true);
            obj.transform.position = new Vector3(8, Random.Range(0,3) / 2.0f , 0);
            obj.transform.SetParent(transform, true);
        }
    }
}
