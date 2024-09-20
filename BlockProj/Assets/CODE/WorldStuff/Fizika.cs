using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fizika : MonoBehaviour
{
    public GameObject anim;
    public GameObject dooranim;
    public GameObject itemdrop;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 1);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);
        Vector2 pos2 = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 1);
        RaycastHit2D hit2 = Physics2D.Raycast(pos2, Vector2.up, 0f);

        if (hit.collider == null)
        { 
           if (itemdrop != null)
            {
                float itembum = Random.Range(-0.7f, 0.7f);
                Destroy(this.gameObject);
                GameObject item = Instantiate(itemdrop, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);
                item.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 1), ForceMode2D.Impulse);
            } else {
            	Destroy(this.gameObject);
            }
            if(anim != null){
                GameObject animitembreak = Instantiate(anim, new Vector2(pos.x, pos.y + 1), Quaternion.identity);
               	Destroy(animitembreak, 0.45f);
            }

        } else if(hit.collider.gameObject.GetComponent<SpriteRenderer>() && hit.collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == "BACKGROUNDBLOCK")
        {
           if (itemdrop != null)
            {
                float itembum = Random.Range(-0.7f, 0.7f);
                Destroy(this.gameObject);
                GameObject item = Instantiate(itemdrop, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);
                item.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 1), ForceMode2D.Impulse);
            } else {
            	Destroy(this.gameObject);
            }
            if(anim != null){
                GameObject animitembreak = Instantiate(anim, new Vector2(pos.x, pos.y + 1), Quaternion.identity);
               	Destroy(animitembreak, 0.45f);
            }
        }
        if (hit2.collider != null)
        {
            if (hit2.collider.gameObject.tag == "Water")
            {
                Destroy(this.gameObject);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Sand"))
        {
           if (itemdrop != null)
            {
                float itembum = Random.Range(-0.7f, 0.7f);
                Destroy(this.gameObject);
                GameObject item = Instantiate(itemdrop, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);
                item.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 1), ForceMode2D.Impulse);
            }
           if(anim != null){
                GameObject animitembreak = Instantiate(anim, new Vector2(this.transform.position.x, this.transform.position.y + 1), Quaternion.identity);
               	Destroy(animitembreak, 0.45f);
            }
        }
    }
}
