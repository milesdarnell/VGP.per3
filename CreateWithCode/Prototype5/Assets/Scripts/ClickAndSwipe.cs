/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickAndSwipe : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
        trail = GetComponent;
    }

    // Update is called once per frame
    
    void Update()
    {
        if(gameManager.isGameActive)
        {
            if(Input.GetMouseButtonDown(0))
            {
                swiping = true;
                UpdateComponents();
            }

            else if(Input.GetMouseButtonUp(0))
            {
                swiping = false;
                UpdateComponents();
            }

            if(swiping)
            {
                UpdateMousePosition();
            }
        }
    }

    void OnCollisionEnter(Collision collision)

    void UpdateMousePosition()
    {
        mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        transform.position
    }
}
*/