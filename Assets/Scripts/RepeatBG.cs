using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{
    public float horizontalSize;
    Vector2 _offsetRight;

    void Update()
    {
        if (transform.position.x < -horizontalSize)
            RepeatBackground();
    }

    void RepeatBackground()
    {

        _offsetRight = new Vector2(horizontalSize * 2f, 0); // 2f -> 2 sprites total
        transform.position = (Vector2) transform.position + _offsetRight;
    }
}
