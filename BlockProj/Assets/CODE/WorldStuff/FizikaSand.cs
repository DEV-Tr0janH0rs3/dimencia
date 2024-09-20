using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizikaSand : MonoBehaviour
{
      void OnCollisionEnter2D(Collision2D collision)
        {
           if(collision.gameObject.GetComponent<SpriteRenderer>() && collision.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Cactus_Texture" || collision.gameObject.GetComponent<SpriteRenderer>() && collision.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Lava_Texture")
         {
            Destroy(this.gameObject);
         }
           if (collision.gameObject.tag == "Item")
            {
               Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Sand"))
            {
                 Vector2 direction = collision.GetContact(0).normal;
                 if(direction.y == -1){
                    this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + 1);
            }
            }
        }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Sand"))
        {
            Vector2 direction = collision.GetContact(0).normal;
            if (direction.y == -1)
            {
                this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + 1);
            }
        }
    }

}
