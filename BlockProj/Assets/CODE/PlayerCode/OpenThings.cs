using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenThings : MonoBehaviour
{
    public GameObject player;
    public Camera cam;
    public Sprite OpenDoor, CloseDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 pos = new Vector2(Mathf.Round(mousepos.x), Mathf.Round(mousepos.y));
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);

            if (hit.collider != null && hit.collider.gameObject.layer == LayerMask.NameToLayer("Door"))
            {
                if ((Mathf.RoundToInt(pos.x) - player.transform.position.x) < 5 && (Mathf.RoundToInt(pos.x) - player.transform.position.x) > -5 && (Mathf.RoundToInt(pos.y) - player.transform.position.y) < 5 && (Mathf.RoundToInt(pos.y) - player.transform.position.y) > -5)
                {
                    if (hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Door")
                    {
                        hit.collider.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                        hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite = CloseDoor;
                    }
                    else if (hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Door_Closed")
                    {
                        hit.collider.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                        hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite = OpenDoor;
                    }
                }
            }
        }
    }
}
