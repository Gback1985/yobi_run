using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public bool destroyable = true;
    public GameObject explode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void beAttack()
    {
        if (destroyable)
        {
            GameObject obj = ObjectPool.Instance.getGameObject(explode);
            obj.SetActive(true);
            obj.transform.SetParent(transform.parent, false);
            obj.transform.localPosition = transform.localPosition;
            Animation anima = obj.GetComponent<Animation>();
            anima.Play();
            ObjectPool.Instance.reuseObject(gameObject);
        }
    }

}
