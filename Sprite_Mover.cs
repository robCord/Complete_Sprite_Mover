using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_Mover : MonoBehaviour
{
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
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("W key");
                tf.position += transform.up;
            }
            if (Input.GetKey(KeyCode.S))
            {
                Debug.Log("S key");
                tf.position -= transform.up;
            }
            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("A key");
                tf.position -= transform.right;
            }
            if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("D key");
                tf.position += transform.right;
            }
        }
        else
        { 
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
        //
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = new Vector3(0, 0, 0);
        }
    }

}
