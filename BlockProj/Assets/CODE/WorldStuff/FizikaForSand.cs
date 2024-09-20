using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizikaForSand : MonoBehaviour
{
    void Update()
    {
        Vector2 pos = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);
        if(hit.collider != null && hit.collider.gameObject != this.gameObject)
        {
            Destroy(hit.collider.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        if (collision.gameObject.tag == "Item")
        {
            Vector2 direction = collision.GetContact(0).normal;
            if (direction.y == -1)
            {
                this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + 1);
            }
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Item"))
        {
                this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + 1);
        }
    }
}
