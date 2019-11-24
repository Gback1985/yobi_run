using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YobiAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void doAttack()
    {
        var result = Physics.RaycastAll(transform.position, new Vector3(1, 0, 0), 1);
        Debug.DrawLine(transform.position, transform.position + Vector3.right);
        if (result.Length > 0)
        {
            result[0].collider.SendMessage("beAttack");
        }
    }
}
