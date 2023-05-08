using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelePort : MonoBehaviour
{
    public GameObject targetObj;

    public GameObject toObj;
    
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.CompareTag("Player"))
        {
            targetObj = collision.gameObject;
        }
    }

    private void OnTriggerStay2D(Collider2D collision) 
        {
            if(collision.CompareTag("Player"))
            {
                TeleportRoutine();
            }
        }
    private void TeleportRoutine()
    {
        
        if(this.name == "TelePort")
        {
            targetObj.transform.position = new Vector2(4, 14);
        }
        else if(this.name == "TelePort2")
        {
            targetObj.transform.position = new Vector2(3.5f, 2.5f);
        }
        
    }
}
