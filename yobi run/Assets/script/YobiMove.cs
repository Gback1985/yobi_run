using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YobiMove : MonoBehaviour
{
    public GameObject yobiObj;
    public Animator yobiAnima;
    public Keyboard controller;
    public AnimationCurve jumpCurve;

    float startY = 0f;
    float time = 0f;
    int jumpCount = 0;
    bool jumping = false;
    GameObject floorObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yobiAnima.SetBool("attack", controller.IsAttack);

        if (controller.IsJump)
        {           
            if (!jumping && jumpCount == 0)
            {
                jumping = true;
                jumpCount++;
            }              
        }
        else
        {
            jumping = false;
           
        }
        if (jumping)
        {
            time += Time.deltaTime;
            transform.localPosition = new Vector3(-3, startY + jumpCurve.Evaluate(time), 0);
            yobiAnima.SetBool("jump", true);
            if (time > 0.5)
            {
                jumping = false;
            }

        }
        else
        {
            if (floorObject == null)
            {
                transform.localPosition -= new Vector3(0, Time.deltaTime * 3f, 0);
            }
            else
            {
                yobiAnima.SetBool("jump", false);
                time = 0f;
                jumpCount = 0;
                startY = floorObject.transform.position.y + 1;
            }
        }


    }

    void gameover()
    {
        yobiAnima.SetTrigger("dead");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.position.y < transform.position.y - 0.9)
        {
            floorObject = other.gameObject;
        }
        else if(other.transform.position.x > transform.position.x)
        {
            transform.parent.gameObject.BroadcastMessage("gameover");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.Equals(floorObject))
        {
            floorObject = null;
        }
    }
}
