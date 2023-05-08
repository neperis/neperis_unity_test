using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelePort : MonoBehaviour
{
    public GameObject targetObj;

    public GameObject toObj;
    public GameObject virutualCamera;

    CinemachineConfiner cameraComponent;
    public Collider2D Ground;
    public Collider2D Ground2;

    void Awake()
    {
        cameraComponent = FindObjectOfType<CinemachineConfiner>();
    }
    
    
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
            targetObj.transform.position = new Vector2(3.5f, 30);
            cameraComponent.m_BoundingShape2D = Ground2;
        }
        else if(this.name == "TelePort2")
        {
            targetObj.transform.position = new Vector2(3.5f, 2.5f);
            cameraComponent.m_BoundingShape2D = Ground;
        }

    }
}
