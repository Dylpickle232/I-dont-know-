using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobility : MonoBehaviour {
    
    public int speed;
    public Sprite[] sprites;

	private void Awake()
	{
        //sprites = Resources.LoadAll<Sprite>("Sprites");
	}

	private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3(-.01f*speed, 0, 0);
                    }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(0.01f*speed, 0, 0);
            

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0.01f*speed);
            

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -0.01f*speed);

        }
        else 
        {
            //GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
	}

}