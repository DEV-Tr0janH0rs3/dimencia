using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanJump : MonoBehaviour
{
    public PlayerMovement script;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Item")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        if (col.gameObject.tag == "breakable")
        {
            script.CanJump = true;
        }
        else
        {
            script.CanJump = false;
        }

    }
    void OnCollisionStay2D(Collision2D col)
    {
        script.CanJump = true;


    }
    void OnCollisionExit2D(Collision2D col)
    {
        script.CanJump = false;


    }
}
