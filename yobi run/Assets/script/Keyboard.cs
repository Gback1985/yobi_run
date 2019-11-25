using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
   
    public bool IsAttack { get; private set; }
    public bool IsJump { get; private set; }

    // Update is called once per frame
    void Update()
    {
        if (GlobaleData.isGameover)
        {
            IsAttack = false;
            IsJump = false;
            return;
        }
        if (Input.GetKeyDown("space"))
        {
            IsAttack = true;
        }
        if (Input.GetKeyUp("space"))
        {
            IsAttack = false;
        }
        if (Input.GetKeyDown("up"))
        {
            IsJump = true;
        }
        if (Input.GetKeyUp("up"))
        {
            IsJump = false;
        }
    }
}
