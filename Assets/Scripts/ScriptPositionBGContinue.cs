using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPositionBGContinue : MonoBehaviour
{
    private GameObject BG11;
    private GameObject BG12;
    private GameObject BG21;
    private GameObject BG22;
    private GameObject player;

    void Start()
    {
        BG11 = GameObject.Find("Background 1.1");
        BG12 = GameObject.Find("Background 1.2");
        BG21 = GameObject.Find("Background 2.1");
        BG22 = GameObject.Find("Background 2.2");
        player = GameObject.Find("Player");
    }

    void Update()
    {
        //Décale les backgrounds de 2 tiles dans la position x si le joueur se décale trop sur l'axe des x correspondant

        if (BG12.transform.position.x - player.transform.position.x > 0)
        {
            Vector3 dx = new Vector3(-76.8f, 0, 0);
            BG12.transform.Translate(dx);
            BG22.transform.Translate(dx);
        }
        if (BG12.transform.position.x - player.transform.position.x < -38.4)
        {
            Vector3 dx = new Vector3(76.8f, 0, 0);
            BG12.transform.Translate(dx);
            BG22.transform.Translate(dx);
        }
        if (BG21.transform.position.x - player.transform.position.x > 0)
        {
            Vector3 dx = new Vector3(-76.8f, 0, 0);
            BG21.transform.Translate(dx);
            BG11.transform.Translate(dx);
        }
        if (BG21.transform.position.x - player.transform.position.x < -38.4)
        {
            Vector3 dx = new Vector3(76.8f, 0, 0);
            BG21.transform.Translate(dx);
            BG11.transform.Translate(dx);
        }

        //Décale les backgrounds de 2 tiles dans la position y si le joueur se décale trop sur l'axe des y correspondant

        if (BG21.transform.position.y - player.transform.position.y > 0)
        {
            Vector3 dy = new Vector3(0, -28, 0);
            BG21.transform.Translate(dy);
            BG22.transform.Translate(dy);
        }
        if (BG21.transform.position.y - player.transform.position.y < -14)
        {
            Vector3 dy = new Vector3(0, 28, 0);
            BG21.transform.Translate(dy);
            BG22.transform.Translate(dy);
        }
        if (BG11.transform.position.y - player.transform.position.y > 0)
        {
            Vector3 dy = new Vector3(0, -28, 0);
            BG11.transform.Translate(dy);
            BG12.transform.Translate(dy);
        }
        if (BG11.transform.position.y - player.transform.position.y < -14)
        {
            Vector3 dy = new Vector3(0, 28, 0);
            BG11.transform.Translate(dy);
            BG12.transform.Translate(dy);
        }
    }
}
