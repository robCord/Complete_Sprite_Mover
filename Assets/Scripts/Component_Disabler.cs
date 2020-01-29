using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component_Disabler : MonoBehaviour
{
    public Sprite_Mover SpriteMover;
    // Start is called before the first frame update
    void Start()
    {
        SpriteMover = gameObject.GetComponent<Sprite_Mover>();
    }

    // Update is called once per frame
    void Update()
    {
        //when p is pressed down it disables sprite mover until p is pressed again
        if (Input.GetKeyDown(KeyCode.P))
        {
            SpriteMover.enabled = (!SpriteMover.enabled);
        }
    }
}
