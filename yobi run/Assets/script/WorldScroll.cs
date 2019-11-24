using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScroll : MonoBehaviour
{
    public float speed = 1f;

    bool isGameover = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameover) return;
        transform.localPosition -= new Vector3(Time.deltaTime * speed, 0, 0);
    }

    void gameover()
    {
        isGameover = true;
    }
}
