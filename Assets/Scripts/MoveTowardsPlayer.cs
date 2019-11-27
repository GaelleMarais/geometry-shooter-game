using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Transform player = GameObject.Find("Player").transform;

        Vector3 target = new Vector3(player.position.x, player.position.y, 0);
        Vector3 direction = target - transform.position;
        transform.up = new Vector2(direction.x, direction.y).normalized;

        transform.Translate(Vector3.up * Time.deltaTime * speed);

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
}
