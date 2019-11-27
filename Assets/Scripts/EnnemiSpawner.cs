using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiSpawner : MonoBehaviour
{
    public GameObject ennemi;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(spawn_random_ennemies()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawn_random_ennemies(){
        while(true){
            yield return new WaitForSeconds(2);

            int rand_color = (int) (Random.value * 4);
            int rand_shape = (int) (Random.value * 2);

            create_ennemi(rand_color, rand_shape);
            
        }
    }

    void create_ennemi(int color_tag, int shape_tag){
        Transform player = GameObject.Find("Player").transform;
        var go = Instantiate(ennemi, new Vector3(player.position.x, player.position.y+5, 0), Quaternion.identity) as GameObject;

        go.GetComponent<SpriteController>().color_tag = color_tag;
        go.GetComponent<SpriteController>().shape_tag = shape_tag;

        go.GetComponent<SpriteController>().update_sprite();

        
    }


}
