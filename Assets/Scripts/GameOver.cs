using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Text>().text = "GAME OVER \n" + Score.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
