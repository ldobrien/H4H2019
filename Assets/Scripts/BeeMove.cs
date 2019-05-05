using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMove : MonoBehaviour
{
    public float speed = 0.1f;
    Vector2 dest = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        dest = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 move = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(move);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            dest = (Vector2)transform.position + Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            dest = (Vector2)transform.position + Vector2.down;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            dest = (Vector2)transform.position + Vector2.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            dest = (Vector2)transform.position + Vector2.right;
        }
    }
}
