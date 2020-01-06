using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiSpawner : MonoBehaviour
{
    public GameObject ennemi;
    public float time_between_spawns;

    // Start is called before the first frame update
    void Start()
    {
        time_between_spawns = 2;
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
            int rand_shape = (int) (Random.value * 3);

            create_ennemi(rand_color, rand_shape);
            if (time_between_spawns > 0.3){
                time_between_spawns -= 0.1f;
                Debug.Log(time_between_spawns);
            }
            
        }
    }

    void create_ennemi(int color_tag, int shape_tag){
        Transform player = GameObject.Find("Player").transform;

        Vector3 spawn_position = new Vector3(player.position.x, player.position.y, 0f);
        int rand = (int) (Random.value * 4);
        switch(rand){
            case 0:
                spawn_position.x += 9;
                break;
            case 1:
                spawn_position.x -= 9;
                break;
            case 2:
                spawn_position.y += 5;
                break;
            case 3:
                spawn_position.y -= 5;
                break;
        }


        var go = Instantiate(ennemi, spawn_position, Quaternion.identity) as GameObject;

        go.GetComponent<SpriteController>().color_tag = color_tag;
        go.GetComponent<SpriteController>().shape_tag = shape_tag;

        go.GetComponent<SpriteController>().update_sprite();

        
    }


}
