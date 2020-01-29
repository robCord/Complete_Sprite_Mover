using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_Mover : MonoBehaviour
{
    //public variables
    public Transform tf;
    public float speed = 1.0f;

    // Use this for initialization
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //if user holds any shift button the gameObject will only move 1 unit 
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            //used wasd and shift keys 
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("W key");
                tf.position += transform.up;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("S key");
                tf.position -= transform.up;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("A key");
                tf.position -= transform.right;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("D key");
                tf.position += transform.right;
            }
        }
        //if not hold a shift the gameObject will move freely 
        else
        { //uses wasd keys to move 
            if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("W key");
                tf.position += transform.up * Time.deltaTime * speed;
            }
            if (Input.GetKey(KeyCode.S))
            {
                Debug.Log("S key");
                tf.position -= transform.up * Time.deltaTime * speed;
            }
            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("A key");
                tf.position -= transform.right * Time.deltaTime * speed;
            }
            if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("D key");
                tf.position += transform.right * Time.deltaTime * speed;
            }
        }
        //once space is pressed the gameObject will return to the center of the screen
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = new Vector3(0, 0, 0);
        }
    }

}
