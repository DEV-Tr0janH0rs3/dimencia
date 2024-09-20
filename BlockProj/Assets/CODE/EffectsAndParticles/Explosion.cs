using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<BlockFunc>())
        {
            collision.gameObject.GetComponent<BlockFunc>().BreakBlock();
        }
        if(collision.gameObject.tag == "Item")
        {
        	Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Player")
        {
        	collision.gameObject.GetComponent<Animation>().Play("Shake");
        }
    }
}
