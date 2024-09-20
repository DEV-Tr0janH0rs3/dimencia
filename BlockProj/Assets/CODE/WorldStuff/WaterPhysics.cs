using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPhysics : MonoBehaviour
{
    public GameObject scripta;

    void Start()
    {
        scripta = GameObject.Find("Generator");
        StartCoroutine(InfiniteLoop());
    }
    void OnEnable()
    {
        scripta = GameObject.Find("Generator");
        StartCoroutine(InfiniteLoop());
    }

    private IEnumerator InfiniteLoop()
    {
        WaitForSeconds waitTime = new WaitForSeconds(0.2f);
        while (true)
        {
            Vector2 pos = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 1);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);
            Vector2 pos2 = new Vector2(this.gameObject.transform.position.x - 1, this.gameObject.transform.position.y);
            RaycastHit2D hit2 = Physics2D.Raycast(pos2, Vector2.up, 0f);
            Vector2 pos3 = new Vector2(this.gameObject.transform.position.x + 1, this.gameObject.transform.position.y - 1);
            RaycastHit2D hit3 = Physics2D.Raycast(pos3, Vector2.up, 0f);
            if (hit.collider == null)
            {
                this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 1);
                if(hit2.collider == null){
                   this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x - 1, this.gameObject.transform.position.y); 
                }
                if(hit3.collider == null){
                   this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + 1, this.gameObject.transform.position.y); 
                }
            } else {
                if(hit2.collider == null){
                   this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x - 1, this.gameObject.transform.position.y); 
                }
                if(hit3.collider == null){
                   this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + 1, this.gameObject.transform.position.y); 
                }
            }

            if(hit.collider.gameObject.GetComponent<SpriteRenderer>() && hit.collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == "BACKGROUNDBLOCK")
            {
                this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 1);
                if(hit2.collider.gameObject.GetComponent<SpriteRenderer>() && hit2.collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == "BACKGROUNDBLOCK"){
                   this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x - 1, this.gameObject.transform.position.y); 
                }
                if(hit3.collider.gameObject.GetComponent<SpriteRenderer>() && hit3.collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == "BACKGROUNDBLOCK"){
                   this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + 1, this.gameObject.transform.position.y); 
                }
            }
            yield return waitTime;
        }
    }
}

