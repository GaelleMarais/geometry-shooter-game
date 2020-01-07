using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "GAME OVER \n" + Score.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
