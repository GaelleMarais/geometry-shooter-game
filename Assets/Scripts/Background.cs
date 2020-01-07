using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    float opacity = 0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("fade");
    }

    public IEnumerator fade(){
        while (true){
            while( opacity < 1){
                opacity += 0.02f;
                GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, opacity);
                yield return new WaitForSeconds(0.1f);
            }
            while( opacity > 0f){
                opacity -= 0.02f;
                GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, opacity);
                yield return new WaitForSeconds(0.1f);
            }
             while( opacity < 1){
                opacity += 0.02f;
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, opacity);
                yield return new WaitForSeconds(0.1f);
            }            
            while( opacity > 0f){
                opacity -= 0.02f;
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, opacity);
                yield return new WaitForSeconds(0.1f);
            }         
            
        }
    }
}
