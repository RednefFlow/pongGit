using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
     
    void fixedUpdate()
    {
           
     
    function Update () {
       
       
        if(Input.GetKey(KeyCode.W))
        {
            this.MovePosition(GetComponent<Rigidbody>().position + speed * Time.deltaTime);
        }
           
        if(Input.GetKey(KeyCode.S))
        {  
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + speed * Time.deltaTime);
        }
    }

    }
}
