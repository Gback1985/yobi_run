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
        var result = Physics.RaycastAll(transform.position, new Vector3(1, 0.2f, 0), 1.2f, 1 << 9);
        Debug.DrawLine(transform.position, transform.position + Vector3.right * 1.5f);
        if (result.Length > 0)
        {
            result[0].collider.SendMessage("beAttack");
        }
        else
        {
            result = Physics.RaycastAll(transform.position, new Vector3(1, -0.2f, 0), 1.2f, 1 << 9);
            if (result.Length > 0)
            {
                result[0].collider.SendMessage("beAttack");
            }
        }
    }
}
