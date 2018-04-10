using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 [] - Brackets
 {} - Braces
 () - Parethesis
 
    Clean Code CTRL + K +D

*/
public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;
    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("Hello World!");
        }
        
    }

}
