using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float speed = 15;
    private PlayerController PlayerControllerScript;
    private float leftBound = -15;
    public bool game gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerControllerScript.gameOver == false)
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    
    }
}
