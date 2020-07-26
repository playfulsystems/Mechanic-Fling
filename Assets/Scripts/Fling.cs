using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Allows the user to click on the square, drag, and release to fling
public class Fling : MonoBehaviour
{
    public float flingSpeed = 200f;

    Rigidbody2D rb;
    Vector2 mouseDownPos;
    Vector2 mouseUpPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        // get mouse position in world coordinates
        mouseDownPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseUp()
    {
        // get mouse position in world coordinates
        mouseUpPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // difference vector
        Vector2 diff = mouseDownPos - mouseUpPos;

        // add that force with speed
        rb.AddForce(diff * flingSpeed);
    }
}
