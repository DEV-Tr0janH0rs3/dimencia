using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBreakS : MonoBehaviour
{
    public Camera cam;
    public GameObject player;
    GameObject selectedblock;
    Animator anima;
    public int breakingSpeed;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 pos = new Vector2(mousepos.x, mousepos.y);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);


            if(hit.collider != null && hit.collider.gameObject.GetComponent<BlockFunc>()){
                if ((hit.collider.gameObject.transform.position.x - player.transform.position.x) < 5 && (hit.collider.gameObject.transform.position.x - player.transform.position.x) > -5 && (hit.collider.gameObject.transform.position.y - player.transform.position.y) < 5 && (hit.collider.gameObject.transform.position.y - player.transform.position.y) > -5)
                {
                    selectedblock = hit.collider.gameObject;
                    anima = hit.collider.gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>();
                    anima.enabled = true;
                    hit.collider.gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>().speed = 0.03f;
                    hit.collider.gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>().Play("BlockBreakAnim");
                    //hit.collider.gameObject.GetComponent<BlockFunc>().BreakBlock();
                }

            }
                //BreakBlock();           
        } else {
            anima.enabled = false;
        }
    }


    void BreakBlock()
        {
            Vector3 mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 pos = new Vector2(mousepos.x, mousepos.y);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);

            if(hit.collider != null && hit.collider.gameObject.GetComponent<BlockFunc>()){
                if ((hit.collider.gameObject.transform.position.x - player.transform.position.x) < 5 && (hit.collider.gameObject.transform.position.x - player.transform.position.x) > -5 && (hit.collider.gameObject.transform.position.y - player.transform.position.y) < 5 && (hit.collider.gameObject.transform.position.y - player.transform.position.y) > -5)
                {
                    anima = hit.collider.gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>();
                    anima.enabled = true;
                    hit.collider.gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>().speed = 0.02f;
                    hit.collider.gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>().Play("BlockBreakAnim");
                    //hit.collider.gameObject.GetComponent<BlockFunc>().BreakBlock();
                }
            }
        }
    }

