using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    GameObject catcherObj;
    float count = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (catcherObj != null)
        {
            count += Time.deltaTime;
            Vector3 newPositon = Vector3.Lerp(transform.position,
                                                  catcherObj.transform.position,
                                                  count / 0.3f);
            transform.position = newPositon;
        }
    }

    private void OnEnable()
    {
        catcherObj = null;
        count = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("itemCatcher"))
        {
            catcherObj = other.gameObject;
        }
        if (other.tag == "yobi")
        {
            gameObject.SendMessage("getItem");
            ObjectPool.Instance.reuseObject(gameObject);
        }
    }
}
