using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public GameObject empty;
    public GameObject full;

    private GameObject[] lives;

    // Start is called before the first frame update
    void Start()
    {
        lives = new GameObject[3];

        var empty1 = Instantiate(empty, new Vector3(-0.8f, 4, 0), Quaternion.identity) as GameObject;
        var empty2 = Instantiate(empty, new Vector3(0, 4, 0), Quaternion.identity) as GameObject;
        var empty3 = Instantiate(empty, new Vector3(0.8f, 4, 0), Quaternion.identity) as GameObject;

        lives[0] = Instantiate(full, new Vector3(-0.8f, 4, 0), Quaternion.identity) as GameObject;
        lives[1] = Instantiate(full, new Vector3(0, 4, 0), Quaternion.identity) as GameObject;
        lives[2] = Instantiate(full, new Vector3(0.8f, 4, 0), Quaternion.identity) as GameObject;
        lives[0].transform.parent = gameObject.transform;
        lives[1].transform.parent = gameObject.transform;
        lives[2].transform.parent = gameObject.transform;

        empty1.transform.parent = gameObject.transform;
        empty2.transform.parent = gameObject.transform;
        empty3.transform.parent = gameObject.transform;
    }

    public void remove(int n){
        Destroy(lives[n]);
    }
}
