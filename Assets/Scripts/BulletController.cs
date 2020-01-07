using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public int color_tag;
    public int shape_tag;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        var go = collision.gameObject;
        GameObject player = GameObject.Find("Player");

        if(go.tag == "ennemi"){
            SpriteController ennemi = go.GetComponent<SpriteController>();
            if( ennemi.color_tag == color_tag || ennemi.shape_tag == shape_tag){          
                Destroy(go);
                player.GetComponent<SpriteController>().color_tag = ennemi.color_tag;
                player.GetComponent<SpriteController>().shape_tag = ennemi.shape_tag;
                player.GetComponent<SpriteController>().update_sprite();

                player.GetComponent<PlayerController>().increment_score(100);
            }

            Destroy(gameObject);            
        }

    }
}
