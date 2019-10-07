using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    // Is this a mine?
    public int mine;

    // Different Textures
    public Sprite[] emptyTextures;
    public Sprite mineTexture;

    // Use this for initialization
    void Start () {
        // Randomly decide if it's a mine or not
       mine = Random.Range(1, 100);
        // Register in Grid
       int x = (int)transform.position.x;
       int y = (int)transform.position.y;
       Playfield.elements[x, y] = this;
       //loadTexture(1);
    }

    // Load another texture
    public void loadTexture(int layer)
    {
        if (mine >= 1)
        {
            GetComponent<SpriteRenderer>().sprite = mineTexture;
        }
        else
            GetComponent<SpriteRenderer>().sprite = emptyTextures[layer];
    }
    void OnMouseUpAsButton()
    {
        // It's a chest
        if (mine > 1)
        {
            // Uncover all mines
           GetComponent<SpriteRenderer>().sprite = mineTexture;
           Playfield.uncoverMines();

            // game over
            print("you lose");
        }
        // It's not a mine
        else {

        }
    }
}
