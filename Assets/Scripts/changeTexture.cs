using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTexture : MonoBehaviour
{
	public Sprite[] Cur_texture;
	float Cur_life = 1;
	public bool isOver, Digable;
    void Start()
    {
	    isOver = false;
    }

    // Update is called once per frame
    void Update()
    {
	    if (Input.GetMouseButtonDown(0) && isOver && Digable)
		    Cur_life -= 0.005f;

	    if (Cur_life < 1 && Cur_life > 0.75f)
		    gameObject.GetComponent<SpriteRenderer>().sprite = Cur_texture[0];
	    else if (Cur_life < 0.75f && Cur_life > 0.25f)
		    gameObject.GetComponent<SpriteRenderer>().sprite = Cur_texture[1];
	    else if (Cur_life < 0.25 && Cur_life > 0.1f)
		    gameObject.GetComponent<SpriteRenderer>().sprite = Cur_texture[2];
	    else if (Cur_life <= 0)
		    Destroy(gameObject);
    }

    private void OnMouseOver()
    {
	    isOver = true;
    }
    
    private void OnMouseExit()
    {
	    isOver = false;
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
	    if (collision.gameObject.CompareTag("Player"))
		    Digable = true;
    }
    
    public void OnCollisionExit2D(Collision2D collision)
    {
	    if (collision.gameObject.CompareTag("Player"))
		    Digable = false;
    }
}
