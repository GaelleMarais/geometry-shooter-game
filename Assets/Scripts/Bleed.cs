using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bleed : MonoBehaviour
{
    // Start is called before the first frame update
    float bleeding = 0f;

    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0f);
    }

    public void bleed(){
        StartCoroutine("effect");

    }

    public IEnumerator effect(){
        while( bleeding < 0.3f){
            bleeding += 0.1f;
            GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, bleeding);
            yield return new WaitForSeconds(0.05f);
        }
        while( bleeding > 0){
            bleeding -= 0.1f;
            GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, bleeding);
            yield return new WaitForSeconds(0.05f);
        }

    }


}
