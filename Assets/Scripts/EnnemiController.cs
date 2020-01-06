using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiController : MonoBehaviour
{    
    private void OnCollisionEnter(Collision collision)
    {
        var go = collision.gameObject;
        

        if(go.tag == "player"){
            go.GetComponent<PlayerController>().get_hurt();
        }
    }
}
