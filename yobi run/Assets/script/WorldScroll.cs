using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScroll : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobaleData.isGameover) return;
        transform.localPosition -= new Vector3(Time.deltaTime * speed, 0, 0);
        GameRoot.Instance.addDistance(Time.deltaTime * speed);
    }
}
