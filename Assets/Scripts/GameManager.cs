using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //variables
    public GameObject beachBall;
    // Update is called once per frame
    void Update()
    {
        //should user press q gameObject is disabled until pressed again
        if (Input.GetKeyDown(KeyCode.Q))
        {
            beachBall.SetActive(!beachBall.activeInHierarchy);
        }
        //if escape is pressed it will close the application
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
