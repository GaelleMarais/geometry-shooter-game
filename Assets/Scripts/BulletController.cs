using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public PlayerController player; 
    public string color_tag;
    public string shape_tag;

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
        if(go.tag == "ennemi"){
            EnnemiController ennemi = go.GetComponent<EnnemiController>();
            if( ennemi.color_tag == color_tag || ennemi.shape_tag == shape_tag){          
                Destroy(go);
                player.color_tag = ennemi.color_tag;
                player.shape_tag = ennemi.shape_tag;
                player.update_sprite();
            }

            Destroy(gameObject);
        }
    }
}
