using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : PlayerMovement
{
	public CharacterController2D controller;

public Sprite spriteA;
public Sprite spriteB;
public Sprite spriteC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetButtonDown("Jump"))
		{
			jump = true;
            idle = false;
		}

		if (Input.GetButtonUp("Jump"))
		{
			jump = false;
            idle = true;
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
            idle = false;
		}
		else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
            idle = true;
		}



        if (jump == true)
		{
		GetComponent<SpriteRenderer>().sprite = spriteA;
		}

        if (crouch == true)
		{
		GetComponent<SpriteRenderer>().sprite = spriteB;
		}

        if (idle == true)
		{
		GetComponent<SpriteRenderer>().sprite = spriteC;
		}

    }
}
