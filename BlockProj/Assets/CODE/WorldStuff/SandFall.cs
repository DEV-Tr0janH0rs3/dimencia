using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandFall : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(InfiniteLoop());
    }
    void OnEnable()
    {
        StartCoroutine(InfiniteLoop());
    }

    private IEnumerator InfiniteLoop()
    {
        WaitForSeconds waitTime = new WaitForSeconds(0.045f);
        while (true)
        {
            //var aa;
            Vector2 pos = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.689f);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);
            if (this.gameObject.GetComponent<SpriteRenderer>().sortingLayerName != "BACKGROUNDBLOCK")
            {
                if (hit.collider == null)
                {
                    this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.2f);
                }
                else if (hit.collider.gameObject.GetComponent<SpriteRenderer>() && hit.collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == "BACKGROUNDBLOCK")
                {
                    this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.2f);
                }
                else if (hit.collider.gameObject.tag == "Water")
                {
                    this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.2f);
                }
                else if (hit.collider.gameObject.GetComponent<SpriteRenderer>() && hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Rose_Texture")
                {
                    Destroy(hit.collider.gameObject);
                    hit.collider.gameObject.GetComponent<BlockToItem>().Drop();
                    this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.2f);
                }
                else if (hit.collider.gameObject.GetComponent<SpriteRenderer>() && hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Real_Grass_Texture")
                {
                    Destroy(hit.collider.gameObject);
                    this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.2f);
                }
                else if (hit.collider.gameObject.tag == "Item")
                {
                    this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 0.2f);
                }
            } else
            {
                if (hit.collider == null)
                {
                    this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 1);
                }
                else if (hit.collider.gameObject.tag == "Water")
                {
                    this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 1);
                }
                else if (hit.collider.gameObject.GetComponent<SpriteRenderer>() && hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Rose_Texture")
                {
                    this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 1);
                }
                else if (hit.collider.gameObject.GetComponent<SpriteRenderer>() && hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Real_Grass_Texture")
                {
                    this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 1);
                } else if(hit.collider.gameObject.tag == "Item")
                {
                    this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 1);
                }
            }
        yield return waitTime;
        }
    }
}
