using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput; 

    // Start is called before the first frame update
    void Start()
    {
        horizontalInput =  Input.GetAxis(Horizontal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
