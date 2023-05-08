using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelePort : MonoBehaviour
{
    public GameObject targetObj;

    public GameObject toObj;
    public GameObject virutualCamera;
    
    

    void Start()
    {
        virutualCamera = GameObject.Find ("Virutual Camera");
        Debug.Log(virutualCamera);
        
    }
    
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
            //cameraComponent.BoundingShape2D = Ground;
            targetObj.transform.position = new Vector2(3.5f, 30);
        }
        else if(this.name == "TelePort2")
        {
            //cameraComponent.BoundingShape2D = Ground2;
            targetObj.transform.position = new Vector2(3.5f, 2.5f);
        }
        
    }
}
