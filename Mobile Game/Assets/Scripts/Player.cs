using System;
using UnityEngine;


public class Player : MonoBehaviour
{
    public LayerMask playerMask;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MoveUp();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            MoveDown();
        }

        if (Input.GetKeyDown(KeyCode.A)) { MoveLeft(); }

        if (Input.GetKeyDown(KeyCode.D)) { MoveRight(); }

    }

    public void MoveUp()
    {
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position,
            Vector2.up,
            1f , playerMask
        );

        if (hit.collider == null)
        {
            // Nothing ahead: move up
            transform.position += Vector3.up;
        }
        else if (hit.collider.CompareTag("Snow"))
        {
            Debug.Log("Hit Snow");
        }
        else if (hit.collider.CompareTag("Wall"))
        {
            Debug.Log("Hit Wall");
        }
        else
        {
            Debug.Log("Hit: " + hit.collider.gameObject.name);
        }
    }

    public void MoveDown()
    {

        RaycastHit2D hit = Physics2D.Raycast(
            transform.position,
            Vector2.down,
            1f, playerMask
        );

        if (hit.collider == null)
        {
            // Nothing ahead: move up
            transform.position += Vector3.down;
        }
        else if (hit.collider.CompareTag("Snow"))
        {
            Debug.Log("Hit Snow");
        }
        else if (hit.collider.CompareTag("Wall"))
        {
            Debug.Log("Hit Wall");
        }
        else
        {
            Debug.Log("Hit: " + hit.collider.gameObject.name);
        }
    }

    public void MoveLeft()
    {
        RaycastHit2D hit = Physics2D.Raycast(
         transform.position,
         Vector2.left,
         1f, playerMask
     );

        if (hit.collider == null)
        {
            // Nothing ahead: move up
            transform.position += Vector3.left;
        }
        else if (hit.collider.CompareTag("Snow"))
        {
            Debug.Log("Hit Snow");
        }
        else if (hit.collider.CompareTag("Wall"))
        {
            Debug.Log("Hit Wall");
        }
        else
        {
            Debug.Log("Hit: " + hit.collider.gameObject.name);
        }
    }

    public void MoveRight()
    {
        RaycastHit2D hit = Physics2D.Raycast(
         transform.position,
         Vector2.right,
         1f, playerMask
     );

        if (hit.collider == null)
        {
            // Nothing ahead: move up
            transform.position += Vector3.right;
        }
        else if (hit.collider.CompareTag("Snow"))
        {
            Debug.Log("Hit Snow");
        }
        else if (hit.collider.CompareTag("Wall"))
        {
            Debug.Log("Hit Wall");
        }
        else
        {
            Debug.Log("Hit: " + hit.collider.gameObject.name);
        }
    }
}
