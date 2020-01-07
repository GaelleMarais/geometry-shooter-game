using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    public int color_tag;
    public int shape_tag;

    public Sprite[] shapes;
    public Color[] colors;

    public void update_sprite(){
        GetComponent<SpriteRenderer>().color = colors[color_tag];
        GetComponent<SpriteRenderer>().sprite = shapes[shape_tag];
    }

}
