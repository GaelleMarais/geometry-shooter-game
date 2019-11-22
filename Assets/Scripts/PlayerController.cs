using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject bullet;

    public float speed = 10;
    public float bullet_speed;

    public string color_tag;
    public string shape_tag;

    Color red;
    Color blue;

    public Mesh square;
    public Mesh sphere;



    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        bullet_speed = 700;
        color_tag="blue";
        shape_tag="square";

        red = Color.red;
        blue = Color.blue;

        // Cursor.visible = false;
    }

    void Update()
    {
        rotate();
        move();
        shoot();
    }

    void move(){
        Vector3 movement = Vector3.zero;

        if(Input.GetButton("Left"))
            movement += Vector3.left; // (-1, 0, 0)            
        if(Input.GetButton("Right"))
            movement += Vector3.right; // (1, 0, 0)
        if(Input.GetButton("Up"))
            movement += Vector3.up;    // (0, 1, 0)
        if(Input.GetButton("Down"))
            movement += Vector3.down;  // (0, -1, 0)

        transform.position += movement * speed * Time.deltaTime;
    }


    //Update the player rotation to look at the mouse
    void rotate(){
        Vector3 mouse_position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        mouse_position = Camera.main.ScreenToWorldPoint(mouse_position);
        Vector3 direction = mouse_position - transform.position;
        transform.up = new Vector3(mouse_position.x, mouse_position.y, 0).normalized;       
    }

    void OnDrawGizmos()
    {
        // Draws axis
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + transform.up);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + transform.right);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward);
    }

    void shoot(){
        if (Input.GetMouseButtonDown(0)) {
            var go = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            go.GetComponent<BulletController>().player = this;
            go.GetComponent<BulletController>().color_tag = color_tag;
            go.GetComponent<BulletController>().shape_tag = shape_tag;
            go.transform.up = transform.up;
            go.GetComponent<Rigidbody>().AddForce(go.transform.up * bullet_speed);
        }
    }

    public void update_sprite(){

        Material mat = this.GetComponent<Renderer>().materials[0];

        switch(color_tag){
            case "blue":
                mat.SetColor("_Color", blue);
                break;
            case "red":
                mat.SetColor("_Color", red);
                break;
        }

        switch(shape_tag){
            case "square":
                Debug.Log("square");
                this.GetComponent<MeshFilter>().mesh = square;

                break;
            case "sphere":
                Debug.Log("sphere");
                //this.GetComponent<MeshFilter>().mesh = sphere;
                // Cynlinder not oriented bc of rotation transform.up
                break;
        }
    }
    
    
}
